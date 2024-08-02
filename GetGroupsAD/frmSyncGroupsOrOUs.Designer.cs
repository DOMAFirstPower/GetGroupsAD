namespace GetGroupsAD
{
    partial class frmSyncGroupsOrOUs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtDomain = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.trvGroups = new System.Windows.Forms.TreeView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnSync = new System.Windows.Forms.Button();
            this.btnCleanSync = new System.Windows.Forms.Button();
            this.btnCleanResult = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblUsers = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUserTest = new System.Windows.Forms.TextBox();
            this.chkSyncOus = new System.Windows.Forms.CheckBox();
            this.chkSyncGroups = new System.Windows.Forms.CheckBox();
            this.chkSyncPartial = new System.Windows.Forms.CheckBox();
            this.chkLogResult = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtPass);
            this.groupBox1.Controls.Add(this.txtDomain);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtUser);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(194, 181);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Authentication";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Domain";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(6, 133);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(156, 20);
            this.txtPass.TabIndex = 6;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // txtDomain
            // 
            this.txtDomain.Location = new System.Drawing.Point(6, 41);
            this.txtDomain.Name = "txtDomain";
            this.txtDomain.Size = new System.Drawing.Size(156, 20);
            this.txtDomain.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Domain\\user";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(6, 86);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(156, 20);
            this.txtUser.TabIndex = 4;
            // 
            // trvGroups
            // 
            this.trvGroups.Location = new System.Drawing.Point(12, 316);
            this.trvGroups.Name = "trvGroups";
            this.trvGroups.Size = new System.Drawing.Size(194, 280);
            this.trvGroups.TabIndex = 9;
            this.trvGroups.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.trvGroups_NodeMouseDoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.txtResult);
            this.groupBox2.Location = new System.Drawing.Point(212, 84);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(560, 514);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Result";
            // 
            // txtResult
            // 
            this.txtResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResult.Location = new System.Drawing.Point(6, 14);
            this.txtResult.MaxLength = 1999999999;
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResult.Size = new System.Drawing.Size(547, 488);
            this.txtResult.TabIndex = 0;
            this.txtResult.WordWrap = false;
            this.txtResult.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtResult_KeyDown);
            // 
            // btnImport
            // 
            this.btnImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImport.Location = new System.Drawing.Point(647, 603);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(125, 45);
            this.btnImport.TabIndex = 10;
            this.btnImport.Text = "SYNC USERS";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnSync
            // 
            this.btnSync.Location = new System.Drawing.Point(102, 281);
            this.btnSync.Name = "btnSync";
            this.btnSync.Size = new System.Drawing.Size(105, 29);
            this.btnSync.TabIndex = 11;
            this.btnSync.Text = "Sync Groups/OUs";
            this.btnSync.UseVisualStyleBackColor = true;
            this.btnSync.Click += new System.EventHandler(this.btnSync_Click);
            // 
            // btnCleanSync
            // 
            this.btnCleanSync.Location = new System.Drawing.Point(11, 281);
            this.btnCleanSync.Name = "btnCleanSync";
            this.btnCleanSync.Size = new System.Drawing.Size(64, 29);
            this.btnCleanSync.TabIndex = 12;
            this.btnCleanSync.Text = "Clear";
            this.btnCleanSync.UseVisualStyleBackColor = true;
            this.btnCleanSync.Click += new System.EventHandler(this.btnCleanSync_Click);
            // 
            // btnCleanResult
            // 
            this.btnCleanResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCleanResult.Location = new System.Drawing.Point(577, 624);
            this.btnCleanResult.Name = "btnCleanResult";
            this.btnCleanResult.Size = new System.Drawing.Size(64, 24);
            this.btnCleanResult.TabIndex = 13;
            this.btnCleanResult.Text = "Clear Results";
            this.btnCleanResult.UseVisualStyleBackColor = true;
            this.btnCleanResult.Click += new System.EventHandler(this.btnCleanResult_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(219, 630);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(0, 13);
            this.lblTime.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(219, 605);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Elapsed time:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 605);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Synced users:";
            // 
            // lblUsers
            // 
            this.lblUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblUsers.AutoSize = true;
            this.lblUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsers.Location = new System.Drawing.Point(12, 630);
            this.lblUsers.Name = "lblUsers";
            this.lblUsers.Size = new System.Drawing.Size(35, 13);
            this.lblUsers.TabIndex = 17;
            this.lblUsers.Text = "users.";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnTest);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtUserTest);
            this.groupBox3.Location = new System.Drawing.Point(212, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(560, 70);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search user";
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(304, 15);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(125, 45);
            this.btnTest.TabIndex = 11;
            this.btnTest.Text = "Search";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(63, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Domain\\User";
            // 
            // txtUserTest
            // 
            this.txtUserTest.Location = new System.Drawing.Point(66, 34);
            this.txtUserTest.Name = "txtUserTest";
            this.txtUserTest.Size = new System.Drawing.Size(156, 20);
            this.txtUserTest.TabIndex = 4;
            // 
            // chkSyncOus
            // 
            this.chkSyncOus.AutoSize = true;
            this.chkSyncOus.Location = new System.Drawing.Point(18, 200);
            this.chkSyncOus.Name = "chkSyncOus";
            this.chkSyncOus.Size = new System.Drawing.Size(74, 17);
            this.chkSyncOus.TabIndex = 18;
            this.chkSyncOus.Text = "Sync OUs";
            this.chkSyncOus.UseVisualStyleBackColor = true;
            // 
            // chkSyncGroups
            // 
            this.chkSyncGroups.AutoSize = true;
            this.chkSyncGroups.Location = new System.Drawing.Point(18, 217);
            this.chkSyncGroups.Name = "chkSyncGroups";
            this.chkSyncGroups.Size = new System.Drawing.Size(87, 17);
            this.chkSyncGroups.TabIndex = 19;
            this.chkSyncGroups.Text = "Sync Groups";
            this.chkSyncGroups.UseVisualStyleBackColor = true;
            // 
            // chkSyncPartial
            // 
            this.chkSyncPartial.AutoSize = true;
            this.chkSyncPartial.Location = new System.Drawing.Point(18, 234);
            this.chkSyncPartial.Name = "chkSyncPartial";
            this.chkSyncPartial.Size = new System.Drawing.Size(105, 17);
            this.chkSyncPartial.TabIndex = 20;
            this.chkSyncPartial.Text = "Sync partial OUs";
            this.chkSyncPartial.UseVisualStyleBackColor = true;
            // 
            // chkLogResult
            // 
            this.chkLogResult.AutoSize = true;
            this.chkLogResult.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkLogResult.Location = new System.Drawing.Point(67, 260);
            this.chkLogResult.Name = "chkLogResult";
            this.chkLogResult.Size = new System.Drawing.Size(140, 17);
            this.chkLogResult.TabIndex = 21;
            this.chkLogResult.Text = "Log Groups/OUs Result";
            this.chkLogResult.UseVisualStyleBackColor = true;
            // 
            // frmSyncGroupsOrOUs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 660);
            this.Controls.Add(this.chkLogResult);
            this.Controls.Add(this.chkSyncPartial);
            this.Controls.Add(this.chkSyncGroups);
            this.Controls.Add(this.chkSyncOus);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.lblUsers);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnCleanResult);
            this.Controls.Add(this.btnCleanSync);
            this.Controls.Add(this.btnSync);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.trvGroups);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.MinimumSize = new System.Drawing.Size(800, 699);
            this.Name = "frmSyncGroupsOrOUs";
            this.Text = "Synchronize Groups/OUs";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Closing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtDomain;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TreeView trvGroups;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnSync;
        private System.Windows.Forms.Button btnCleanSync;
        private System.Windows.Forms.Button btnCleanResult;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblUsers;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUserTest;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.CheckBox chkSyncOus;
        private System.Windows.Forms.CheckBox chkSyncGroups;
        private System.Windows.Forms.CheckBox chkSyncPartial;
        private System.Windows.Forms.CheckBox chkLogResult;
    }
}

