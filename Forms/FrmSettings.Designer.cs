namespace BookProject.Forms
{
    partial class FrmSettings
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSettings));
            this.panel5 = new System.Windows.Forms.Panel();
            this.chkUnlimitedFiles = new System.Windows.Forms.CheckBox();
            this.chkUnlimitedDays = new System.Windows.Forms.CheckBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnAutoBackupPath = new System.Windows.Forms.Button();
            this.radNo = new System.Windows.Forms.RadioButton();
            this.radYes = new System.Windows.Forms.RadioButton();
            this.label26 = new System.Windows.Forms.Label();
            this.txtAutoBackupPath = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.txtBackupDays = new System.Windows.Forms.TextBox();
            this.txtBackupFiles = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label22 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAdminName = new System.Windows.Forms.TextBox();
            this.txtSQLUser = new System.Windows.Forms.TextBox();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.txtAdminPass = new System.Windows.Forms.TextBox();
            this.txtSQLPassword = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnTestConnection = new System.Windows.Forms.Button();
            this.txtDatabase = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRestoeDatabase = new System.Windows.Forms.Button();
            this.btnBackupDatabase = new System.Windows.Forms.Button();
            this.btnBackupPath = new System.Windows.Forms.Button();
            this.lblWait = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBackupPath = new System.Windows.Forms.TextBox();
            this.txtBackupName = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.cmbDateFormat = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.bntCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtNumberOne = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLibraryWebsite = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNumberTwo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panColor = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel7.SuspendLayout();
            this.panColor.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.chkUnlimitedFiles);
            this.panel5.Controls.Add(this.chkUnlimitedDays);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.label24);
            this.panel5.Controls.Add(this.label23);
            this.panel5.Controls.Add(this.txtBackupDays);
            this.panel5.Controls.Add(this.txtBackupFiles);
            this.panel5.Location = new System.Drawing.Point(21, 358);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(499, 424);
            this.panel5.TabIndex = 11;
            // 
            // chkUnlimitedFiles
            // 
            this.chkUnlimitedFiles.AutoSize = true;
            this.chkUnlimitedFiles.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUnlimitedFiles.Location = new System.Drawing.Point(356, 267);
            this.chkUnlimitedFiles.Margin = new System.Windows.Forms.Padding(4);
            this.chkUnlimitedFiles.Name = "chkUnlimitedFiles";
            this.chkUnlimitedFiles.Size = new System.Drawing.Size(110, 26);
            this.chkUnlimitedFiles.TabIndex = 10;
            this.chkUnlimitedFiles.Text = "Unlimited";
            this.chkUnlimitedFiles.UseVisualStyleBackColor = true;
            this.chkUnlimitedFiles.CheckedChanged += new System.EventHandler(this.chkUnlimitedFiles_CheckedChanged);
            // 
            // chkUnlimitedDays
            // 
            this.chkUnlimitedDays.AutoSize = true;
            this.chkUnlimitedDays.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUnlimitedDays.Location = new System.Drawing.Point(356, 341);
            this.chkUnlimitedDays.Margin = new System.Windows.Forms.Padding(4);
            this.chkUnlimitedDays.Name = "chkUnlimitedDays";
            this.chkUnlimitedDays.Size = new System.Drawing.Size(110, 26);
            this.chkUnlimitedDays.TabIndex = 9;
            this.chkUnlimitedDays.Text = "Unlimited";
            this.chkUnlimitedDays.UseVisualStyleBackColor = true;
            this.chkUnlimitedDays.CheckedChanged += new System.EventHandler(this.chkUnlimitedDays_CheckedChanged);
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.btnAutoBackupPath);
            this.panel6.Controls.Add(this.radNo);
            this.panel6.Controls.Add(this.radYes);
            this.panel6.Controls.Add(this.label26);
            this.panel6.Controls.Add(this.txtAutoBackupPath);
            this.panel6.Location = new System.Drawing.Point(17, 44);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(462, 215);
            this.panel6.TabIndex = 0;
            // 
            // btnAutoBackupPath
            // 
            this.btnAutoBackupPath.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutoBackupPath.Location = new System.Drawing.Point(37, 148);
            this.btnAutoBackupPath.Name = "btnAutoBackupPath";
            this.btnAutoBackupPath.Size = new System.Drawing.Size(352, 54);
            this.btnAutoBackupPath.TabIndex = 12;
            this.btnAutoBackupPath.Text = "Auto Backup Path";
            this.btnAutoBackupPath.UseVisualStyleBackColor = true;
            this.btnAutoBackupPath.Click += new System.EventHandler(this.btnAutoBackupPath_Click);
            // 
            // radNo
            // 
            this.radNo.Checked = true;
            this.radNo.Font = new System.Drawing.Font("Hacen Saudi Arabia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radNo.Location = new System.Drawing.Point(316, 46);
            this.radNo.Margin = new System.Windows.Forms.Padding(4);
            this.radNo.Name = "radNo";
            this.radNo.Size = new System.Drawing.Size(85, 37);
            this.radNo.TabIndex = 0;
            this.radNo.TabStop = true;
            this.radNo.Text = "NO";
            this.radNo.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.radNo.UseVisualStyleBackColor = true;
            // 
            // radYes
            // 
            this.radYes.Font = new System.Drawing.Font("Hacen Saudi Arabia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radYes.Location = new System.Drawing.Point(41, 46);
            this.radYes.Margin = new System.Windows.Forms.Padding(4);
            this.radYes.Name = "radYes";
            this.radYes.Size = new System.Drawing.Size(104, 37);
            this.radYes.TabIndex = 0;
            this.radYes.Text = "YES";
            this.radYes.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.radYes.UseVisualStyleBackColor = true;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(60)))), ((int)(((byte)(73)))));
            this.label26.Location = new System.Drawing.Point(0, 12);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(395, 22);
            this.label26.TabIndex = 8;
            this.label26.Text = "Backup Database automatically when you close..\r\n";
            this.toolTip1.SetToolTip(this.label26, "Backup Database automatically when you close The system");
            // 
            // txtAutoBackupPath
            // 
            this.txtAutoBackupPath.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAutoBackupPath.Location = new System.Drawing.Point(37, 98);
            this.txtAutoBackupPath.Margin = new System.Windows.Forms.Padding(4);
            this.txtAutoBackupPath.Name = "txtAutoBackupPath";
            this.txtAutoBackupPath.Size = new System.Drawing.Size(352, 38);
            this.txtAutoBackupPath.TabIndex = 4;
            this.txtAutoBackupPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(60)))), ((int)(((byte)(73)))));
            this.label24.Location = new System.Drawing.Point(3, 303);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(337, 27);
            this.label24.TabIndex = 8;
            this.label24.Text = "Maximum Count Of Backup Files";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(60)))), ((int)(((byte)(73)))));
            this.label23.Location = new System.Drawing.Point(3, 377);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(341, 27);
            this.label23.TabIndex = 8;
            this.label23.Text = "Maximum(Days) Of Backup Days\r\n";
            // 
            // txtBackupDays
            // 
            this.txtBackupDays.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBackupDays.Location = new System.Drawing.Point(353, 372);
            this.txtBackupDays.Margin = new System.Windows.Forms.Padding(4);
            this.txtBackupDays.Name = "txtBackupDays";
            this.txtBackupDays.Size = new System.Drawing.Size(123, 38);
            this.txtBackupDays.TabIndex = 4;
            // 
            // txtBackupFiles
            // 
            this.txtBackupFiles.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBackupFiles.Location = new System.Drawing.Point(353, 298);
            this.txtBackupFiles.Margin = new System.Windows.Forms.Padding(4);
            this.txtBackupFiles.Name = "txtBackupFiles";
            this.txtBackupFiles.Size = new System.Drawing.Size(123, 38);
            this.txtBackupFiles.TabIndex = 4;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(60)))), ((int)(((byte)(73)))));
            this.label19.Location = new System.Drawing.Point(575, 658);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(150, 31);
            this.label19.TabIndex = 16;
            this.label19.Text = "Date Format";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Silver;
            this.panel4.Location = new System.Drawing.Point(68, 370);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(400, 4);
            this.panel4.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Location = new System.Drawing.Point(68, 164);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(400, 4);
            this.panel3.TabIndex = 9;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(60)))), ((int)(((byte)(73)))));
            this.label16.Location = new System.Drawing.Point(8, 400);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(140, 27);
            this.label16.TabIndex = 8;
            this.label16.Text = "Admin Name";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(60)))), ((int)(((byte)(73)))));
            this.label12.Location = new System.Drawing.Point(8, 194);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(157, 27);
            this.label12.TabIndex = 8;
            this.label12.Text = "SQLUserName";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(60)))), ((int)(((byte)(73)))));
            this.label6.Location = new System.Drawing.Point(8, 39);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 27);
            this.label6.TabIndex = 8;
            this.label6.Text = "Server Nmae";
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(60)))), ((int)(((byte)(73)))));
            this.label22.Location = new System.Drawing.Point(29, 343);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(288, 27);
            this.label22.TabIndex = 17;
            this.label22.Text = "Automatic Backup Database";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(60)))), ((int)(((byte)(73)))));
            this.label15.Location = new System.Drawing.Point(8, 469);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(175, 27);
            this.label15.TabIndex = 8;
            this.label15.Text = "Admin Password";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(60)))), ((int)(((byte)(73)))));
            this.label11.Location = new System.Drawing.Point(8, 257);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(148, 27);
            this.label11.TabIndex = 8;
            this.label11.Text = "SQLPassword";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(60)))), ((int)(((byte)(73)))));
            this.label3.Location = new System.Drawing.Point(8, 102);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 27);
            this.label3.TabIndex = 8;
            this.label3.Text = "Database Name";
            // 
            // txtAdminName
            // 
            this.txtAdminName.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdminName.Location = new System.Drawing.Point(204, 400);
            this.txtAdminName.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdminName.Name = "txtAdminName";
            this.txtAdminName.PasswordChar = '*';
            this.txtAdminName.Size = new System.Drawing.Size(288, 38);
            this.txtAdminName.TabIndex = 4;
            this.txtAdminName.UseSystemPasswordChar = true;
            // 
            // txtSQLUser
            // 
            this.txtSQLUser.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSQLUser.Location = new System.Drawing.Point(200, 188);
            this.txtSQLUser.Margin = new System.Windows.Forms.Padding(4);
            this.txtSQLUser.Name = "txtSQLUser";
            this.txtSQLUser.Size = new System.Drawing.Size(288, 38);
            this.txtSQLUser.TabIndex = 4;
            // 
            // txtServer
            // 
            this.txtServer.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServer.Location = new System.Drawing.Point(200, 39);
            this.txtServer.Margin = new System.Windows.Forms.Padding(4);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(288, 38);
            this.txtServer.TabIndex = 4;
            // 
            // txtAdminPass
            // 
            this.txtAdminPass.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdminPass.Location = new System.Drawing.Point(204, 463);
            this.txtAdminPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdminPass.Name = "txtAdminPass";
            this.txtAdminPass.Size = new System.Drawing.Size(288, 38);
            this.txtAdminPass.TabIndex = 4;
            this.txtAdminPass.UseSystemPasswordChar = true;
            // 
            // txtSQLPassword
            // 
            this.txtSQLPassword.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSQLPassword.Location = new System.Drawing.Point(200, 251);
            this.txtSQLPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtSQLPassword.Name = "txtSQLPassword";
            this.txtSQLPassword.Size = new System.Drawing.Size(288, 38);
            this.txtSQLPassword.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnTestConnection);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtAdminName);
            this.panel2.Controls.Add(this.txtSQLUser);
            this.panel2.Controls.Add(this.txtServer);
            this.panel2.Controls.Add(this.txtAdminPass);
            this.panel2.Controls.Add(this.txtSQLPassword);
            this.panel2.Controls.Add(this.txtDatabase);
            this.panel2.Location = new System.Drawing.Point(565, 43);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(525, 532);
            this.panel2.TabIndex = 12;
            // 
            // btnTestConnection
            // 
            this.btnTestConnection.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestConnection.Image = global::BookProject.Properties.Resources.database;
            this.btnTestConnection.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTestConnection.Location = new System.Drawing.Point(129, 302);
            this.btnTestConnection.Name = "btnTestConnection";
            this.btnTestConnection.Size = new System.Drawing.Size(284, 54);
            this.btnTestConnection.TabIndex = 12;
            this.btnTestConnection.Text = "Test Connection";
            this.btnTestConnection.UseVisualStyleBackColor = true;
            this.btnTestConnection.Click += new System.EventHandler(this.btnTestConnection_Click);
            // 
            // txtDatabase
            // 
            this.txtDatabase.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDatabase.Location = new System.Drawing.Point(200, 102);
            this.txtDatabase.Margin = new System.Windows.Forms.Padding(4);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Size = new System.Drawing.Size(288, 38);
            this.txtDatabase.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnRestoeDatabase);
            this.panel1.Controls.Add(this.btnBackupDatabase);
            this.panel1.Controls.Add(this.btnBackupPath);
            this.panel1.Controls.Add(this.lblWait);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtBackupPath);
            this.panel1.Controls.Add(this.txtBackupName);
            this.panel1.Location = new System.Drawing.Point(16, 43);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(499, 281);
            this.panel1.TabIndex = 13;
            // 
            // btnRestoeDatabase
            // 
            this.btnRestoeDatabase.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestoeDatabase.Image = global::BookProject.Properties.Resources.data_recovery;
            this.btnRestoeDatabase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRestoeDatabase.Location = new System.Drawing.Point(189, 187);
            this.btnRestoeDatabase.Name = "btnRestoeDatabase";
            this.btnRestoeDatabase.Size = new System.Drawing.Size(284, 54);
            this.btnRestoeDatabase.TabIndex = 12;
            this.btnRestoeDatabase.Text = "Restore";
            this.btnRestoeDatabase.UseVisualStyleBackColor = true;
            this.btnRestoeDatabase.Click += new System.EventHandler(this.btnRestoeDatabase_Click);
            // 
            // btnBackupDatabase
            // 
            this.btnBackupDatabase.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackupDatabase.Image = global::BookProject.Properties.Resources.sync;
            this.btnBackupDatabase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBackupDatabase.Location = new System.Drawing.Point(189, 127);
            this.btnBackupDatabase.Name = "btnBackupDatabase";
            this.btnBackupDatabase.Size = new System.Drawing.Size(284, 54);
            this.btnBackupDatabase.TabIndex = 12;
            this.btnBackupDatabase.Text = "Backup";
            this.btnBackupDatabase.UseVisualStyleBackColor = true;
            this.btnBackupDatabase.Click += new System.EventHandler(this.btnBackupDatabase_Click);
            // 
            // btnBackupPath
            // 
            this.btnBackupPath.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackupPath.Location = new System.Drawing.Point(12, 15);
            this.btnBackupPath.Name = "btnBackupPath";
            this.btnBackupPath.Size = new System.Drawing.Size(160, 54);
            this.btnBackupPath.TabIndex = 12;
            this.btnBackupPath.Text = "Backup Path";
            this.btnBackupPath.UseVisualStyleBackColor = true;
            this.btnBackupPath.Click += new System.EventHandler(this.btnBackupPath_Click);
            // 
            // lblWait
            // 
            this.lblWait.AutoSize = true;
            this.lblWait.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWait.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblWait.Location = new System.Drawing.Point(192, 245);
            this.lblWait.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWait.Name = "lblWait";
            this.lblWait.Size = new System.Drawing.Size(92, 27);
            this.lblWait.TabIndex = 11;
            this.lblWait.Text = "message";
            this.lblWait.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BookProject.Properties.Resources.database_storage_5732844;
            this.pictureBox1.Location = new System.Drawing.Point(21, 128);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(60)))), ((int)(((byte)(73)))));
            this.label2.Location = new System.Drawing.Point(9, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 27);
            this.label2.TabIndex = 8;
            this.label2.Text = "Backup Name";
            // 
            // txtBackupPath
            // 
            this.txtBackupPath.Enabled = false;
            this.txtBackupPath.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBackupPath.Location = new System.Drawing.Point(185, 23);
            this.txtBackupPath.Margin = new System.Windows.Forms.Padding(4);
            this.txtBackupPath.Name = "txtBackupPath";
            this.txtBackupPath.Size = new System.Drawing.Size(288, 38);
            this.txtBackupPath.TabIndex = 4;
            // 
            // txtBackupName
            // 
            this.txtBackupName.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBackupName.Location = new System.Drawing.Point(185, 82);
            this.txtBackupName.Margin = new System.Windows.Forms.Padding(4);
            this.txtBackupName.Name = "txtBackupName";
            this.txtBackupName.Size = new System.Drawing.Size(288, 38);
            this.txtBackupName.TabIndex = 4;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "cancel.png");
            this.imageList1.Images.SetKeyName(1, "database.png");
            this.imageList1.Images.SetKeyName(2, "diskette.png");
            this.imageList1.Images.SetKeyName(3, "save.png");
            this.imageList1.Images.SetKeyName(4, "cloud-backup-up-arrow.png");
            // 
            // cmbDateFormat
            // 
            this.cmbDateFormat.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDateFormat.FormattingEnabled = true;
            this.cmbDateFormat.Location = new System.Drawing.Point(771, 658);
            this.cmbDateFormat.Margin = new System.Windows.Forms.Padding(4);
            this.cmbDateFormat.Name = "cmbDateFormat";
            this.cmbDateFormat.Size = new System.Drawing.Size(288, 37);
            this.cmbDateFormat.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(60)))), ((int)(((byte)(73)))));
            this.label9.Location = new System.Drawing.Point(24, 27);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(165, 27);
            this.label9.TabIndex = 18;
            this.label9.Text = "Manual Backup";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(60)))), ((int)(((byte)(73)))));
            this.label5.Location = new System.Drawing.Point(575, 27);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(303, 27);
            this.label5.TabIndex = 19;
            this.label5.Text = "Settings Of System Connecion";
            // 
            // txtCompany
            // 
            this.txtCompany.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompany.Location = new System.Drawing.Point(771, 597);
            this.txtCompany.Margin = new System.Windows.Forms.Padding(4);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCompany.Size = new System.Drawing.Size(288, 38);
            this.txtCompany.TabIndex = 14;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(60)))), ((int)(((byte)(73)))));
            this.label18.Location = new System.Drawing.Point(537, 597);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(217, 27);
            this.label18.TabIndex = 20;
            this.label18.Text = "Title Company Name";
            // 
            // bntCancel
            // 
            this.bntCancel.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntCancel.Image = global::BookProject.Properties.Resources.Cancle1;
            this.bntCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntCancel.Location = new System.Drawing.Point(846, 744);
            this.bntCancel.Name = "bntCancel";
            this.bntCancel.Size = new System.Drawing.Size(236, 58);
            this.bntCancel.TabIndex = 12;
            this.bntCancel.Text = "Cancel";
            this.bntCancel.UseVisualStyleBackColor = true;
            this.bntCancel.Click += new System.EventHandler(this.bntCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::BookProject.Properties.Resources.settings;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(593, 744);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(234, 58);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save Settings";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.txtNumberOne);
            this.panel7.Controls.Add(this.label4);
            this.panel7.Controls.Add(this.txtLibraryWebsite);
            this.panel7.Controls.Add(this.label8);
            this.panel7.Controls.Add(this.txtNumberTwo);
            this.panel7.Controls.Add(this.label1);
            this.panel7.Location = new System.Drawing.Point(1118, 43);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(495, 273);
            this.panel7.TabIndex = 23;
            // 
            // txtNumberOne
            // 
            this.txtNumberOne.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumberOne.Location = new System.Drawing.Point(181, 40);
            this.txtNumberOne.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumberOne.Name = "txtNumberOne";
            this.txtNumberOne.Size = new System.Drawing.Size(288, 38);
            this.txtNumberOne.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(60)))), ((int)(((byte)(73)))));
            this.label4.Location = new System.Drawing.Point(8, 45);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 27);
            this.label4.TabIndex = 8;
            this.label4.Text = "Number One";
            // 
            // txtLibraryWebsite
            // 
            this.txtLibraryWebsite.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLibraryWebsite.Location = new System.Drawing.Point(181, 187);
            this.txtLibraryWebsite.Margin = new System.Windows.Forms.Padding(4);
            this.txtLibraryWebsite.Name = "txtLibraryWebsite";
            this.txtLibraryWebsite.Size = new System.Drawing.Size(288, 38);
            this.txtLibraryWebsite.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(60)))), ((int)(((byte)(73)))));
            this.label8.Location = new System.Drawing.Point(8, 192);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(167, 27);
            this.label8.TabIndex = 8;
            this.label8.Text = "Library Website";
            // 
            // txtNumberTwo
            // 
            this.txtNumberTwo.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumberTwo.Location = new System.Drawing.Point(181, 112);
            this.txtNumberTwo.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumberTwo.Name = "txtNumberTwo";
            this.txtNumberTwo.Size = new System.Drawing.Size(288, 38);
            this.txtNumberTwo.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(60)))), ((int)(((byte)(73)))));
            this.label1.Location = new System.Drawing.Point(8, 117);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 27);
            this.label1.TabIndex = 8;
            this.label1.Text = "Number Tow";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(60)))), ((int)(((byte)(73)))));
            this.label7.Location = new System.Drawing.Point(1132, 28);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(202, 27);
            this.label7.TabIndex = 19;
            this.label7.Text = "Library information";
            // 
            // panColor
            // 
            this.panColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panColor.Controls.Add(this.label17);
            this.panColor.Controls.Add(this.label14);
            this.panColor.Controls.Add(this.panel8);
            this.panColor.Location = new System.Drawing.Point(1118, 358);
            this.panColor.Name = "panColor";
            this.panColor.Size = new System.Drawing.Size(495, 368);
            this.panColor.TabIndex = 24;
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(216)))));
            this.label17.Location = new System.Drawing.Point(260, 193);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(214, 154);
            this.label17.TabIndex = 0;
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.label14.Location = new System.Drawing.Point(260, 32);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(214, 154);
            this.label14.TabIndex = 0;
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.label20);
            this.panel8.Controls.Add(this.label13);
            this.panel8.Location = new System.Drawing.Point(21, 29);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(452, 321);
            this.panel8.TabIndex = 1;
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(212)))), ((int)(((byte)(218)))));
            this.label20.Location = new System.Drawing.Point(1, 164);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(214, 154);
            this.label20.TabIndex = 0;
            this.label20.Click += new System.EventHandler(this.label20_Click);
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.label13.Location = new System.Drawing.Point(1, 3);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(214, 154);
            this.label13.TabIndex = 0;
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(60)))), ((int)(((byte)(73)))));
            this.label10.Location = new System.Drawing.Point(1132, 341);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(208, 27);
            this.label10.TabIndex = 19;
            this.label10.Text = "Main interface color";
            // 
            // FrmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1633, 809);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panColor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.bntCancel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmbDateFormat);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtCompany);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1651, 856);
            this.Name = "FrmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الضبط";
            this.Load += new System.EventHandler(this.FrmSettings_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panColor.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.CheckBox chkUnlimitedFiles;
        private System.Windows.Forms.CheckBox chkUnlimitedDays;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.RadioButton radNo;
        private System.Windows.Forms.RadioButton radYes;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox txtAutoBackupPath;
        private System.Windows.Forms.TextBox txtBackupDays;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtBackupFiles;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAdminName;
        private System.Windows.Forms.TextBox txtSQLUser;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.TextBox txtAdminPass;
        private System.Windows.Forms.TextBox txtSQLPassword;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtDatabase;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblWait;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBackupPath;
        private System.Windows.Forms.TextBox txtBackupName;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ComboBox cmbDateFormat;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnTestConnection;
        private System.Windows.Forms.Button btnRestoeDatabase;
        private System.Windows.Forms.Button btnBackupDatabase;
        private System.Windows.Forms.Button btnBackupPath;
        private System.Windows.Forms.Button btnAutoBackupPath;
        private System.Windows.Forms.Button bntCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txtNumberOne;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNumberTwo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLibraryWebsite;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panColor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel8;
    }
}