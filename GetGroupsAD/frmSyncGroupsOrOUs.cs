using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace GetGroupsAD
{
    public partial class frmSyncGroupsOrOUs : Form
    {
        public DirectoryEntry AutenticadoAD { get; set; }
        UserADInfo user = null;
        int totalUsers = 0;
        private List<String> lstLog = new List<String>();

        private bool thrdExecut = false;
        private bool thrdImpRunning = false;
        private bool thrdLogRunning = false;
        private System.Threading.Thread thrdImport;
        private System.Threading.Thread thrdLog;

        public frmSyncGroupsOrOUs()
        {
            InitializeComponent();

            this.thrdImport = new System.Threading.Thread(this.ThrdImportUsers);
            this.thrdLog = new System.Threading.Thread(this.ThrdLog);

            this.thrdLogRunning = true;
            this.thrdLog.Start();

        }

        private void ThrdLog()
        {
            while (this.thrdLogRunning)
            {
                if (lstLog.Count > 0)
                {
                    List<String> newLst = new List<string>(lstLog);

                    foreach (string log in newLst)
                    {
                        this.txtResult.Invoke(new UpdateTextCallback(this.UpdateText), new object[] { log });

                        lstLog.Remove(log);
                    }
                }

                this.lblUsers.Invoke(new UpdateTotalUsersCallback(this.UpdateTotalUsers), new object[] { totalUsers.ToString() });

                Thread.Sleep(1);
            }
        }

        private void ThrdImportUsers()
        {
            while (this.thrdImpRunning)
            {
                if (this.thrdExecut)
                {
                    DateTime time = DateTime.Now;

                    foreach (TreeNode node in this.trvGroups.Nodes[0].Nodes)
                    {
                        this.VerifyCheckedChildNode(node);
                    }
                }
            }
        }

        private void VerifyCheckedChildNode(TreeNode pNode)
        {
            foreach (TreeNode node in pNode.Nodes)
                VerifyCheckedChildNode(node);

            if (pNode.Checked)
            {
                if (pNode.Text.Contains("OU=") || pNode.Text.Contains("CN="))
                    GetUsersByOU(pNode.Tag.ToString(), pNode.Text);
                else
                    GetUsersByGroup(pNode.Tag.ToString(), pNode.Text, pNode.Parent.Text);
            }
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            try
            {
                ActiveDirectoryBLL adBLL = new ActiveDirectoryBLL();

                this.user = new UserADInfo()
                {
                    Login = this.txtUser.Text,
                    Password = this.txtPass.Text
                };

                if (adBLL.AutenticarAD(user))
                    this.AutenticadoAD = adBLL.AutenticacaoAD;

                this.trvGroups.Nodes.Clear();

                foreach (String dominio in this.txtDomain.Text.Split(';'))
                {
                    TreeNode masterNode = this.chkSyncOus.Checked ?
                        this.PrepareTreeView(adBLL, dominio, String.Empty, false) :
                        new TreeNode(dominio);

                    if (this.chkSyncGroups.Checked)
                    {
                        PrincipalContext ctx = new PrincipalContext(ContextType.Domain, dominio);
                        ctx.ValidateCredentials(this.txtUser.Text, this.txtPass.Text);
                        GroupPrincipal qbeGroup = new GroupPrincipal(ctx);
                        PrincipalSearcher srchGroup = new PrincipalSearcher(qbeGroup);
                        foreach (Principal item in srchGroup.FindAll())
                        {
                            TreeNode node = new TreeNode();
                            node.Text = item.Name;
                            node.Tag = dominio + ":" + item.Guid;
                            node.Checked = false;

                            masterNode.Nodes.Add(node);
                        }
                    }

                    this.trvGroups.Nodes.Add(masterNode);
                }

                this.trvGroups.CheckBoxes = true;
                this.trvGroups.Sort();
                this.trvGroups.ExpandAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private TreeNode PrepareTreeView(ActiveDirectoryBLL pAdBLL, String pRootAccess, String pNodeName, bool pIsChildren, TreeNode pSelectedNode = null)
        {
            DirectoryEntryInfo ousAd;
            if (pSelectedNode != null)
            {
                pSelectedNode.Nodes.Clear();
                ousAd = pAdBLL.GetOusAD(this.user, pSelectedNode.Tag.ToString(), pSelectedNode.Text, pIsChildren, this.chkSyncPartial.Checked);
            }
            else
            {
                ousAd = pAdBLL.GetOusAD(this.user, pRootAccess, pNodeName, pIsChildren, this.chkSyncPartial.Checked);
                pSelectedNode = new TreeNode(ousAd.Text);
                pSelectedNode.Tag = (object)ousAd.ID;
            }
            foreach (DirectoryEntryInfo pInfo in ousAd.Items)
                this.AdicionarChildNode(ref pSelectedNode, pInfo);
            return pSelectedNode;
        }

        private void AdicionarChildNode(ref TreeNode pRootNode, DirectoryEntryInfo pInfo)
        {
            String value = pInfo.ID + ":" + pInfo.Path;
            TreeNode node = new TreeNode();
            node.Text = pInfo.Text;
            node.Tag = pInfo.ID;
            node.Checked = false;

            if (pInfo.Items != null)
            {
                if (this.chkSyncPartial.Checked)
                    node.ForeColor = Color.DarkRed;
                else
                {
                    foreach (DirectoryEntryInfo child in pInfo.Items)
                        AdicionarChildNode(ref node, child);
                }
            }
            pRootNode.Nodes.Add(node);
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            txtResult.Text = String.Empty;
            lblTime.Text = String.Empty;
            lblUsers.Text = String.Empty;
            totalUsers = 0;

            this.thrdExecut = true;
            this.thrdImpRunning = true;

            if (this.thrdImport.ThreadState != System.Threading.ThreadState.Running)
            {
                this.thrdImport.Start();
                System.Threading.Thread.Sleep(10);
            }

            this.thrdExecut = false;
        }

        private void GetUsersByGroup(String pGuID, String groupName, String pDomain)
        {
            try
            {
                String persona = String.Empty;

                DirectoryEntry entry = new DirectoryEntry(String.Concat("LDAP://", pGuID.Split(':')[0]));
                DirectorySearcher deSearch = new DirectorySearcher(entry);
                deSearch.Filter = "(&(objectClass=group)(cn=" + groupName + "))";
                SearchResultCollection results = deSearch.FindAll();
                if (results.Count > 0)
                {
                    foreach (SearchResult group in results)
                    {

                        foreach (string member in group.Properties["member"])
                        {
                            persona = String.Empty;
                            DirectoryEntry de = new DirectoryEntry(String.Concat("LDAP://", pGuID.Split(':')[0], "/", member.ToString()));
                            if (de.Properties["objectClass"].Contains("user") && de.Properties["samaccountname"].Count > 0)
                            {
                                persona += "\r\nLogin: " + (String)de.Properties["samaccountname"][0];
                                persona += "\r\nName: " + ((de.Properties["DisplayName"].Count > 0) ? (String)de.Properties["DisplayName"][0] : "Not registred");
                                persona += "\r\nE-mail: " + ((de.Properties["Mail"].Count > 0) ? (String)de.Properties["Mail"][0] : "Not registred");

                                if (de.Properties["userAccountControl"].Count > 0)
                                {
                                    persona += "\r\nEnabled user: " + ((Convert.ToBoolean((int)de.Properties["userAccountControl"][0] & 0x0002)) ? "No" : "Yes");
                                }
                                persona += "\r\nDomain: " + this.GetDomainFromDistinguishedName((String)de.Properties["distinguishedname"][0]);

                                persona += " \r\n";

                                lstLog.Add(persona);


                            }
                        }

                        lstLog.Add("PATH: " + group.Path + "\r\n");
                        DirectorySearcher searcher = new DirectorySearcher(entry);
                        searcher.Filter = String.Format("(&(objectClass=user)(memberOf={0}))", group.Path.Replace("LDAP://" + pDomain + "/", ""));
                        searcher.PageSize = 5000;
                        searcher.SizeLimit = 0;

                        SearchResultCollection users = searcher.FindAll();
                        lstLog.Add("user.COUNT: " + users.Count + "\r\n");
                        if (users.Count > 0)
                        {
                            foreach (SearchResult member in users)
                            {
                                persona = String.Empty;
                                if (member.Properties.Count > 0 && member.Properties["objectClass"].Contains("user") && member.Properties["samaccountname"].Count > 0)
                                {
                                    persona += "\r\nLogin: " + (String)member.Properties["samaccountname"][0];
                                    persona += "\r\nName: " + ((member.Properties["DisplayName"].Count > 0) ? (String)member.Properties["DisplayName"][0] : "Not registred");
                                    persona += "\r\nE-mail: " + ((member.Properties["Mail"].Count > 0) ? (String)member.Properties["Mail"][0] : "Not registred");

                                    if (member.Properties["userAccountControl"].Count > 0)
                                    {
                                        persona += "\r\nEnabled User: " + ((Convert.ToBoolean((int)member.Properties["userAccountControl"][0] & 0x0002)) ? "No" : "Yes");
                                    }
                                    persona += "\r\nDomain: " + this.GetDomainFromDistinguishedName((String)member.Properties["distinguishedname"][0]);

                                    persona += " \r\n";

                                    lstLog.Add(persona);

                                }
                            }
                        }

                    }
                }
                else
                {
                    persona += "Not Found \r\n";
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error to synchronize users from group. ERRO: " + ex.Message);
            }
        }

        private void GetUsersByOU(String guID, String pText)
        {
            try
            {
                using (DirectoryEntry acessoAd = new DirectoryEntry(String.Format("LDAP://{0}/<GUID={1}>", guID.Split(':')[0], guID.Split(':')[1]), user.Login, user.Password))
                {
                    SearchResultCollection resultCol = null;

                    using (DirectorySearcher search = new DirectorySearcher(acessoAd))
                    {
                        search.SearchScope = SearchScope.Subtree;
                        search.Filter = "(&(ObjectClass=user)(objectCategory=person))";
                        search.PropertiesToLoad.Add("samaccountname");
                        search.PropertiesToLoad.Add("Mail");
                        search.PropertiesToLoad.Add("cn");
                        search.PropertiesToLoad.Add("userAccountControl");
                        search.PropertiesToLoad.Add("distinguishedname");

                        search.PageSize = 5000;
                        resultCol = search.FindAll();
                    }


                    if (resultCol != null)
                    {
                        lstLog.Add("\r\n===============================================================");
                        lstLog.Add("\r\n" + pText);
                        lstLog.Add("\r\n===============================================================");

                        foreach (SearchResult result in resultCol)
                        {
                            String persona = String.Empty;

                            if (result.Properties.Contains("samaccountname"))
                            {
                                persona += "\r\nLogin: " + (String)result.Properties["samaccountname"][0];
                                persona += "\r\nName: " + ((result.Properties["cn"].Count > 0) ? (String)result.Properties["cn"][0] : "Not registred");
                                persona += "\r\nE-mail: " + ((result.Properties["Mail"].Count > 0) ? (String)result.Properties["Mail"][0] : "Not registred");

                                if (result.Properties["userAccountControl"].Count > 0)
                                    persona += "\r\nEnabled User: " + ((Convert.ToBoolean((int)result.Properties["userAccountControl"][0] & 0x0002)) ? "No" : "Yes");

                                persona += "\r\nDomain: " + this.GetDomainFromDistinguishedName((String)result.Properties["distinguishedname"][0]);

                                persona += "\r\n";

                                lstLog.Add(persona);
                                totalUsers++;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnCleanSync_Click(object sender, EventArgs e)
        {
            trvGroups.Nodes.Clear();
        }

        private void btnCleanResult_Click(object sender, EventArgs e)
        {
            txtResult.Text = String.Empty;
            lblTime.Text = String.Empty;
            lblUsers.Text = String.Empty;

            totalUsers = 0;
        }


        private void UpdateText(string text)
        {
            this.txtResult.Text += text;

            this.txtResult.SelectionStart = this.txtResult.Text.Length;
            this.txtResult.ScrollToCaret();
        }
        public delegate void UpdateTextCallback(string text);

        private void UpdateTotalUsers(string value)
        {
            this.lblUsers.Text = value;
        }
        public delegate void UpdateTotalUsersCallback(string text);

        private void Form_Closing(object sender, FormClosingEventArgs e)
        {
            if (this.thrdImport != null)
            {
                this.thrdImport.Abort();
                this.thrdImport = null;
            }

            if (this.thrdLog != null)
            {
                this.thrdLog.Abort();
                this.thrdLog = null;
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            txtResult.Text = String.Empty;
            lblTime.Text = String.Empty;
            lblUsers.Text = String.Empty;
            totalUsers = 0;
            try
            {
                string[] param = this.txtUserTest.Text.Split('\\');
                string rootDomain = this.txtUser.Text.Split('\\')[0];
                using (DirectoryEntry acessoAd = new DirectoryEntry(String.Format("LDAP://{0}", rootDomain), txtUser.Text, txtPass.Text))
                {
                    SearchResultCollection resultCol = null;

                    using (DirectorySearcher search = new DirectorySearcher(acessoAd))
                    {
                        search.SearchScope = SearchScope.Subtree;
                        search.Filter = String.Format("(&(samaccountname={0}))", param[1]);
                        search.PageSize = 5000;
                        resultCol = search.FindAll();
                    }

                    if (resultCol != null)
                    {
                        foreach (SearchResult result in resultCol)
                        {
                            String persona = String.Empty;

                            if (result.Properties.Contains("samaccountname"))
                            {
                                foreach (System.Collections.DictionaryEntry kvpProperties in result.Properties)
                                {

                                    foreach (object value in (System.DirectoryServices.ResultPropertyValueCollection)kvpProperties.Value)
                                    {
                                        persona += String.Format("\r\n{0}: {1}", kvpProperties.Key, value);
                                    }
                                }

                                persona += "\r\n" + this.GetDomainFromDistinguishedName((String)result.Properties["distinguishedname"][0]);

                                lstLog.Add(persona);
                                totalUsers++;
                            }
                            else
                                lstLog.Add("User not found.");
                        }
                    }
                    else
                        lstLog.Add("No results to show.");
                }
            }
            catch (Exception ex)
            {
                txtResult.Text = "ERROR: " + ex.Message;
            }
        }

        private String GetDomainFromDistinguishedName(String pDistenguishedName)
        {
            String domain = pDistenguishedName.Substring(pDistenguishedName.IndexOf(",DC=")).Remove(0, 4).Split(',')[0];

            return domain;
        }

        private void trvGroups_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (this.trvGroups.SelectedNode.ForeColor != Color.DarkRed) return;
            try
            {
                ActiveDirectoryBLL adBLL = new ActiveDirectoryBLL();

                this.user = new UserADInfo()
                {
                    Login = this.txtUser.Text,
                    Password = this.txtPass.Text
                };

                if (adBLL.AutenticarAD(user))
                    this.AutenticadoAD = adBLL.AutenticacaoAD;

                TreeNode selectedNode = this.trvGroups.SelectedNode;

                this.trvGroups.Nodes.Clear();

                TreeNode node = this.PrepareTreeView(adBLL, "", "", true, selectedNode);

                TreeNode masterNode = AdicionarParenteNode(node);

                this.trvGroups.Nodes.Add(masterNode);
                this.trvGroups.CheckBoxes = true;
                this.trvGroups.Sort();
                this.trvGroups.ExpandAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private TreeNode CleanTree(TreeNode node)
        {
            TreeNode currNode = node;

            while (node.Parent != null)
            {
                TreeNode cleanNode = new TreeNode();
                cleanNode.Text = node.Parent.Text;
                cleanNode.Nodes.Add(currNode);
                node = node.Parent;

                currNode = node;           
            }

            return currNode;
        }

        private TreeNode AdicionarParenteNode(TreeNode pNode)
        {
            TreeNode nodeParente = new TreeNode();

            if (pNode.Parent != null)
            {
                nodeParente = AdicionarParenteNode(pNode.Parent);
            }
            else
                nodeParente = pNode;

            return nodeParente;
        }
    }
}
