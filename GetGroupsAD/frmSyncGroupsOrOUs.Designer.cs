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
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(259, 223);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Authentication";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Domain";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(8, 164);
            this.txtPass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(207, 22);
            this.txtPass.TabIndex = 6;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // txtDomain
            // 
            this.txtDomain.Location = new System.Drawing.Point(8, 50);
            this.txtDomain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDomain.Name = "txtDomain";
            this.txtDomain.Size = new System.Drawing.Size(207, 22);
            this.txtDomain.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 144);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Domain\\user";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(8, 106);
            this.txtUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(207, 22);
            this.txtUser.TabIndex = 4;
            // 
            // trvGroups
            // 
            this.trvGroups.Location = new System.Drawing.Point(16, 389);
            this.trvGroups.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.trvGroups.Name = "trvGroups";
            this.trvGroups.Size = new System.Drawing.Size(257, 344);
            this.trvGroups.TabIndex = 9;
            this.trvGroups.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.trvGroups_NodeMouseDoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtResult);
            this.groupBox2.Location = new System.Drawing.Point(283, 103);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(747, 633);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Result";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(9, 21);
            this.txtResult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtResult.MaxLength = 1999999999;
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResult.Size = new System.Drawing.Size(728, 600);
            this.txtResult.TabIndex = 0;
            this.txtResult.WordWrap = false;
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(863, 742);
            this.btnImport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(167, 55);
            this.btnImport.TabIndex = 10;
            this.btnImport.Text = "SYNC USERS";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnSync
            // 
            this.btnSync.Location = new System.Drawing.Point(135, 346);
            this.btnSync.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSync.Name = "btnSync";
            this.btnSync.Size = new System.Drawing.Size(140, 36);
            this.btnSync.TabIndex = 11;
            this.btnSync.Text = "Sync Groups/OUs";
            this.btnSync.UseVisualStyleBackColor = true;
            this.btnSync.Click += new System.EventHandler(this.btnSync_Click);
            // 
            // btnCleanSync
            // 
            this.btnCleanSync.Location = new System.Drawing.Point(16, 346);
            this.btnCleanSync.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCleanSync.Name = "btnCleanSync";
            this.btnCleanSync.Size = new System.Drawing.Size(85, 36);
            this.btnCleanSync.TabIndex = 12;
            this.btnCleanSync.Text = "Clear";
            this.btnCleanSync.UseVisualStyleBackColor = true;
            this.btnCleanSync.Click += new System.EventHandler(this.btnCleanSync_Click);
            // 
            // btnCleanResult
            // 
            this.btnCleanResult.Location = new System.Drawing.Point(769, 768);
            this.btnCleanResult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCleanResult.Name = "btnCleanResult";
            this.btnCleanResult.Size = new System.Drawing.Size(85, 30);
            this.btnCleanResult.TabIndex = 13;
            this.btnCleanResult.Text = "Clear Results";
            this.btnCleanResult.UseVisualStyleBackColor = true;
            this.btnCleanResult.Click += new System.EventHandler(this.btnCleanResult_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(292, 775);
            this.lblTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(0, 17);
            this.lblTime.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(292, 745);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Elapsed time:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 745);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(215, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Synced users:";
            // 
            // lblUsers
            // 
            this.lblUsers.AutoSize = true;
            this.lblUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsers.Location = new System.Drawing.Point(16, 775);
            this.lblUsers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsers.Name = "lblUsers";
            this.lblUsers.Size = new System.Drawing.Size(66, 17);
            this.lblUsers.TabIndex = 17;
            this.lblUsers.Text = "users.";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnTest);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtUserTest);
            this.groupBox3.Location = new System.Drawing.Point(283, 15);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(747, 81);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search user";
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(405, 18);
            this.btnTest.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(167, 55);
            this.btnTest.TabIndex = 11;
            this.btnTest.Text = "Search";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(84, 22);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "Domain\\User";
            // 
            // txtUserTest
            // 
            this.txtUserTest.Location = new System.Drawing.Point(88, 42);
            this.txtUserTest.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUserTest.Name = "txtUserTest";
            this.txtUserTest.Size = new System.Drawing.Size(207, 22);
            this.txtUserTest.TabIndex = 4;
            // 
            // chkSyncOus
            // 
            this.chkSyncOus.AutoSize = true;
            this.chkSyncOus.Location = new System.Drawing.Point(24, 246);
            this.chkSyncOus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkSyncOus.Name = "chkSyncOus";
            this.chkSyncOus.Size = new System.Drawing.Size(93, 21);
            this.chkSyncOus.TabIndex = 18;
            this.chkSyncOus.Text = "Sync OUs";
            this.chkSyncOus.UseVisualStyleBackColor = true;
            // 
            // chkSyncGroups
            // 
            this.chkSyncGroups.AutoSize = true;
            this.chkSyncGroups.Location = new System.Drawing.Point(24, 276);
            this.chkSyncGroups.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkSyncGroups.Name = "chkSyncGroups";
            this.chkSyncGroups.Size = new System.Drawing.Size(112, 21);
            this.chkSyncGroups.TabIndex = 19;
            this.chkSyncGroups.Text = "Sync Groups";
            this.chkSyncGroups.UseVisualStyleBackColor = true;
            // 
            // chkSyncPartial
            // 
            this.chkSyncPartial.AutoSize = true;
            this.chkSyncPartial.Location = new System.Drawing.Point(24, 305);
            this.chkSyncPartial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkSyncPartial.Name = "chkSyncPartial";
            this.chkSyncPartial.Size = new System.Drawing.Size(136, 21);
            this.chkSyncPartial.TabIndex = 20;
            this.chkSyncPartial.Text = "Sync partial OUs";
            this.chkSyncPartial.UseVisualStyleBackColor = true;
            // 
            // frmSyncGroupsOrOUs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 804);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1061, 851);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1061, 851);
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
    }
}

