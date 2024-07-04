using System;
using System.Collections.Generic;
using System.DirectoryServices;

namespace GetGroupsAD
{
    public class ActiveDirectoryBLL
    {
        public DirectoryEntry AutenticacaoAD { get; set; }

        /// <summary>
        /// Faz a autenticação no Active Directory (AD) com um usuário que tem permissão para tal.
        /// </summary>
        /// <returns>Retorna o Directory Entry já autenticado</returns>
        public bool AutenticarAD(UserADInfo userAD)
        {
            DirectoryEntry autenticacao = new DirectoryEntry(string.Empty, userAD.Login, userAD.Password);

            try
            {
                Object o = autenticacao.NativeObject; //Força a validação de acesso
                AutenticacaoAD = autenticacao;
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Busca os departamentos do AD para preencher as TreeView na tela de importação de usuários
        /// </summary>
        /// <param name="pUserLoginAD">Usuário para efetuar o login no AD</param>
        /// <returns></returns>
        public DirectoryEntryInfo GetOusAD(UserADInfo pUserLoginAD, String pRootAccess, String pNodeName, bool pIsChildren, bool pPartial)
        {
            String domain = pRootAccess.Split(':')[0];

            String rootAccess = pIsChildren ?
                String.Format("LDAP://{0}/<GUID={1}>", domain, pRootAccess.Split(':')[1]) :
                String.Format("LDAP://{0}", domain);

            if (!String.IsNullOrEmpty(rootAccess) && !String.IsNullOrEmpty(pUserLoginAD.Login))
            {
                using (DirectoryEntry acessoAd = new DirectoryEntry(rootAccess, pUserLoginAD.Login, pUserLoginAD.Password))
                {
                    DirectoryEntryInfo entry = new DirectoryEntryInfo()
                    {
                        ID = acessoAd.Guid.ToString(),
                        Text = pIsChildren ? pNodeName : domain,
                        Expanded = true,
                        Items = null
                    };

                    foreach (DirectoryEntry ou in acessoAd.Children)
                        using (ou)
                        {
                            if (ShouldAddNode(ou.SchemaClassName))
                            {
                                if (entry.Items == null)
                                    entry.Items = new List<DirectoryEntryInfo>();


                                entry.Items.Add(GetChildNode(ou, domain, pPartial));
                            }
                        }

                    return entry;
                }
            }

            return null;
        }

        #region Métodos Privados
        private bool ShouldAddNode(String filtro)
        {
            return filtro.Equals("organizationalUnit", StringComparison.InvariantCultureIgnoreCase) ||
                   filtro.Equals("container", StringComparison.InvariantCultureIgnoreCase);
        }

        private DirectoryEntryInfo GetChildNode(DirectoryEntry entry, String pDomain, bool pPartial)
        {
            DirectoryEntryInfo entryChild = new DirectoryEntryInfo()
            {
                ID = pDomain + ":" + entry.Guid.ToString(),
                Text = entry.Name,
                Path = entry.Properties["distinguishedName"][0].ToString(),
                Items = null
            };

            foreach (DirectoryEntry childEntry in entry.Children)
                using (childEntry)
                {
                    if (ShouldAddNode(childEntry.SchemaClassName))
                    {
                        if (pPartial)
                        {
                            entryChild.Items = new List<DirectoryEntryInfo>();
                            break;
                        }

                        entryChild.Expanded = true;

                        if (entryChild.Items == null)
                            entryChild.Items = new List<DirectoryEntryInfo>();
                        entryChild.Items.Add(GetChildNode(childEntry, pDomain, false));
                    }
                }

            return entryChild;
        }
        #endregion
    }
}
