namespace BookProject.Forms
{
    partial class FrmUserManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUserManagement));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.chkUsers = new System.Windows.Forms.CheckBox();
            this.chkMonitor = new System.Windows.Forms.CheckBox();
            this.chkSettings = new System.Windows.Forms.CheckBox();
            this.chkPrint = new System.Windows.Forms.CheckBox();
            this.chkInsert = new System.Windows.Forms.CheckBox();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.N = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserJob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserPic = new System.Windows.Forms.DataGridViewImageColumn();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsDeleteUser = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsDeletePicture = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.chkUpdate = new System.Windows.Forms.CheckBox();
            this.grpUserInfo = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblUserPic = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.picUser = new System.Windows.Forms.PictureBox();
            this.txtUserJob = new System.Windows.Forms.TextBox();
            this.btnResetPass = new System.Windows.Forms.Button();
            this.txtUserPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.grpPermissions = new System.Windows.Forms.Panel();
            this.chkAdmin = new System.Windows.Forms.CheckBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.contextMenuStrip2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.grpUserInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).BeginInit();
            this.grpPermissions.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "diskette.png");
            this.imageList1.Images.SetKeyName(1, "editing.png");
            this.imageList1.Images.SetKeyName(2, "refresh-button.png");
            this.imageList1.Images.SetKeyName(3, "cancel.png");
            // 
            // chkUsers
            // 
            this.chkUsers.AutoSize = true;
            this.chkUsers.Font = new System.Drawing.Font("Hacen Saudi Arabia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUsers.Location = new System.Drawing.Point(111, 102);
            this.chkUsers.Margin = new System.Windows.Forms.Padding(4);
            this.chkUsers.Name = "chkUsers";
            this.chkUsers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkUsers.Size = new System.Drawing.Size(164, 31);
            this.chkUsers.TabIndex = 5;
            this.chkUsers.Text = "إدارة المستخدمين";
            this.chkUsers.UseVisualStyleBackColor = true;
            this.chkUsers.CheckedChanged += new System.EventHandler(this.chkUpdate_CheckedChanged);
            // 
            // chkMonitor
            // 
            this.chkMonitor.AutoSize = true;
            this.chkMonitor.Font = new System.Drawing.Font("Hacen Saudi Arabia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMonitor.Location = new System.Drawing.Point(140, 153);
            this.chkMonitor.Margin = new System.Windows.Forms.Padding(4);
            this.chkMonitor.Name = "chkMonitor";
            this.chkMonitor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkMonitor.Size = new System.Drawing.Size(137, 31);
            this.chkMonitor.TabIndex = 5;
            this.chkMonitor.Text = "مراقبة النظام";
            this.chkMonitor.UseVisualStyleBackColor = true;
            this.chkMonitor.CheckedChanged += new System.EventHandler(this.chkUpdate_CheckedChanged);
            // 
            // chkSettings
            // 
            this.chkSettings.AutoSize = true;
            this.chkSettings.Font = new System.Drawing.Font("Hacen Saudi Arabia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSettings.Location = new System.Drawing.Point(159, 128);
            this.chkSettings.Margin = new System.Windows.Forms.Padding(4);
            this.chkSettings.Name = "chkSettings";
            this.chkSettings.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkSettings.Size = new System.Drawing.Size(121, 31);
            this.chkSettings.TabIndex = 5;
            this.chkSettings.Text = "لوحة تحكم";
            this.chkSettings.UseVisualStyleBackColor = true;
            this.chkSettings.CheckedChanged += new System.EventHandler(this.chkUpdate_CheckedChanged);
            // 
            // chkPrint
            // 
            this.chkPrint.AutoSize = true;
            this.chkPrint.Font = new System.Drawing.Font("Hacen Saudi Arabia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPrint.Location = new System.Drawing.Point(146, 77);
            this.chkPrint.Margin = new System.Windows.Forms.Padding(4);
            this.chkPrint.Name = "chkPrint";
            this.chkPrint.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkPrint.Size = new System.Drawing.Size(131, 31);
            this.chkPrint.TabIndex = 5;
            this.chkPrint.Text = "طباعةالتقارير";
            this.chkPrint.UseVisualStyleBackColor = true;
            this.chkPrint.CheckedChanged += new System.EventHandler(this.chkUpdate_CheckedChanged);
            // 
            // chkInsert
            // 
            this.chkInsert.AutoSize = true;
            this.chkInsert.Font = new System.Drawing.Font("Hacen Saudi Arabia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkInsert.Location = new System.Drawing.Point(156, 52);
            this.chkInsert.Margin = new System.Windows.Forms.Padding(4);
            this.chkInsert.Name = "chkInsert";
            this.chkInsert.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkInsert.Size = new System.Drawing.Size(121, 31);
            this.chkInsert.TabIndex = 5;
            this.chkInsert.Text = "إضافةبيانات";
            this.chkInsert.UseVisualStyleBackColor = true;
            this.chkInsert.CheckedChanged += new System.EventHandler(this.chkUpdate_CheckedChanged);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // N
            // 
            this.N.DataPropertyName = "N";
            this.N.FillWeight = 60.91371F;
            this.N.HeaderText = "ت";
            this.N.MinimumWidth = 6;
            this.N.Name = "N";
            this.N.ReadOnly = true;
            this.N.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "UserName";
            this.UserName.FillWeight = 107.8172F;
            this.UserName.HeaderText = "اسم المستخدم";
            this.UserName.MinimumWidth = 6;
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            // 
            // UserPassword
            // 
            this.UserPassword.DataPropertyName = "UserPassword";
            this.UserPassword.FillWeight = 107.8172F;
            this.UserPassword.HeaderText = "كلمة المرور";
            this.UserPassword.MinimumWidth = 6;
            this.UserPassword.Name = "UserPassword";
            this.UserPassword.ReadOnly = true;
            // 
            // UserJob
            // 
            this.UserJob.DataPropertyName = "UserJob";
            this.UserJob.FillWeight = 107.8172F;
            this.UserJob.HeaderText = "الوظيفة";
            this.UserJob.MinimumWidth = 6;
            this.UserJob.Name = "UserJob";
            this.UserJob.ReadOnly = true;
            // 
            // id1
            // 
            this.id1.DataPropertyName = "id";
            this.id1.FillWeight = 107.8172F;
            this.id1.HeaderText = "رقم التسجيل";
            this.id1.MinimumWidth = 6;
            this.id1.Name = "id1";
            this.id1.ReadOnly = true;
            // 
            // UserPic
            // 
            this.UserPic.DataPropertyName = "UserPic";
            this.UserPic.FillWeight = 107.8172F;
            this.UserPic.HeaderText = "الصورة";
            this.UserPic.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.UserPic.MinimumWidth = 6;
            this.UserPic.Name = "UserPic";
            this.UserPic.ReadOnly = true;
            this.UserPic.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsDeleteUser});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(176, 30);
            // 
            // cmsDeleteUser
            // 
            this.cmsDeleteUser.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsDeleteUser.Name = "cmsDeleteUser";
            this.cmsDeleteUser.Size = new System.Drawing.Size(175, 26);
            this.cmsDeleteUser.Text = "حذف المستخدم";
            this.cmsDeleteUser.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsDeletePicture});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip1.Size = new System.Drawing.Size(170, 30);
            // 
            // cmsDeletePicture
            // 
            this.cmsDeletePicture.Name = "cmsDeletePicture";
            this.cmsDeletePicture.Size = new System.Drawing.Size(169, 26);
            this.cmsDeletePicture.Text = "حذف الصورة";
            this.cmsDeletePicture.Click += new System.EventHandler(this.cmsDeletePicture_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Title = "تحميل صورة المستخدم";
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToResizeRows = false;
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsers.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Hacen Saudi Arabia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.N,
            this.UserName,
            this.UserPassword,
            this.UserJob,
            this.id1,
            this.UserPic});
            this.dgvUsers.ContextMenuStrip = this.contextMenuStrip2;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsers.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUsers.Location = new System.Drawing.Point(18, 283);
            this.dgvUsers.Margin = new System.Windows.Forms.Padding(4);
            this.dgvUsers.MultiSelect = false;
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvUsers.RowHeadersVisible = false;
            this.dgvUsers.RowHeadersWidth = 51;
            this.dgvUsers.RowTemplate.DividerHeight = 3;
            this.dgvUsers.RowTemplate.Height = 32;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.Size = new System.Drawing.Size(1136, 363);
            this.dgvUsers.TabIndex = 13;
            this.dgvUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellContentClick);
            this.dgvUsers.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvUsers_ColumnHeaderMouseClick);
            this.dgvUsers.Sorted += new System.EventHandler(this.dgvUsers_Sorted);
            this.dgvUsers.Click += new System.EventHandler(this.dgvUsers_Click);
            // 
            // chkUpdate
            // 
            this.chkUpdate.AutoSize = true;
            this.chkUpdate.Font = new System.Drawing.Font("Hacen Saudi Arabia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUpdate.Location = new System.Drawing.Point(154, 27);
            this.chkUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.chkUpdate.Name = "chkUpdate";
            this.chkUpdate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkUpdate.Size = new System.Drawing.Size(123, 31);
            this.chkUpdate.TabIndex = 5;
            this.chkUpdate.Text = "تعديل بيانات";
            this.chkUpdate.UseVisualStyleBackColor = true;
            this.chkUpdate.CheckedChanged += new System.EventHandler(this.chkUpdate_CheckedChanged);
            // 
            // grpUserInfo
            // 
            this.grpUserInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grpUserInfo.Controls.Add(this.label4);
            this.grpUserInfo.Controls.Add(this.label6);
            this.grpUserInfo.Controls.Add(this.lblUserPic);
            this.grpUserInfo.Controls.Add(this.label3);
            this.grpUserInfo.Controls.Add(this.picUser);
            this.grpUserInfo.Controls.Add(this.txtUserJob);
            this.grpUserInfo.Controls.Add(this.btnResetPass);
            this.grpUserInfo.Controls.Add(this.txtUserPassword);
            this.grpUserInfo.Controls.Add(this.txtUserName);
            this.grpUserInfo.Location = new System.Drawing.Point(330, 30);
            this.grpUserInfo.Margin = new System.Windows.Forms.Padding(4);
            this.grpUserInfo.Name = "grpUserInfo";
            this.grpUserInfo.Size = new System.Drawing.Size(823, 183);
            this.grpUserInfo.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Hacen Saudi Arabia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(653, 130);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 32);
            this.label4.TabIndex = 1;
            this.label4.Text = "الصفة/الوظيفة";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Hacen Saudi Arabia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(663, 23);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 32);
            this.label6.TabIndex = 1;
            this.label6.Text = "اسم المستخدم";
            // 
            // lblUserPic
            // 
            this.lblUserPic.AutoSize = true;
            this.lblUserPic.BackColor = System.Drawing.Color.Transparent;
            this.lblUserPic.Font = new System.Drawing.Font("Hacen Saudi Arabia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserPic.Location = new System.Drawing.Point(28, 126);
            this.lblUserPic.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserPic.Name = "lblUserPic";
            this.lblUserPic.Size = new System.Drawing.Size(122, 32);
            this.lblUserPic.TabIndex = 1;
            this.lblUserPic.Text = "ضبط الصورة";
            this.lblUserPic.Click += new System.EventHandler(this.lblUserPic_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Hacen Saudi Arabia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(685, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "كلمة المرور ";
            // 
            // picUser
            // 
            this.picUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picUser.Location = new System.Drawing.Point(5, 4);
            this.picUser.Margin = new System.Windows.Forms.Padding(4);
            this.picUser.Name = "picUser";
            this.picUser.Size = new System.Drawing.Size(175, 173);
            this.picUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUser.TabIndex = 8;
            this.picUser.TabStop = false;
            this.picUser.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picUser_MouseUp);
            // 
            // txtUserJob
            // 
            this.txtUserJob.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserJob.Location = new System.Drawing.Point(189, 126);
            this.txtUserJob.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserJob.Name = "txtUserJob";
            this.txtUserJob.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtUserJob.Size = new System.Drawing.Size(452, 38);
            this.txtUserJob.TabIndex = 2;
            // 
            // btnResetPass
            // 
            this.btnResetPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.btnResetPass.Font = new System.Drawing.Font("Hacen Saudi Arabia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetPass.ForeColor = System.Drawing.Color.White;
            this.btnResetPass.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnResetPass.Location = new System.Drawing.Point(189, 59);
            this.btnResetPass.Name = "btnResetPass";
            this.btnResetPass.Size = new System.Drawing.Size(219, 61);
            this.btnResetPass.TabIndex = 14;
            this.btnResetPass.Text = "ضبط كلمة المرور";
            this.btnResetPass.UseVisualStyleBackColor = false;
            this.btnResetPass.Click += new System.EventHandler(this.btnResetPass_Click);
            // 
            // txtUserPassword
            // 
            this.txtUserPassword.BackColor = System.Drawing.SystemColors.Window;
            this.txtUserPassword.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserPassword.Location = new System.Drawing.Point(415, 71);
            this.txtUserPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserPassword.Name = "txtUserPassword";
            this.txtUserPassword.ReadOnly = true;
            this.txtUserPassword.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtUserPassword.Size = new System.Drawing.Size(227, 38);
            this.txtUserPassword.TabIndex = 1;
            this.txtUserPassword.UseSystemPasswordChar = true;
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(193, 18);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtUserName.Size = new System.Drawing.Size(448, 38);
            this.txtUserName.TabIndex = 0;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Hacen Saudi Arabia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(117, 12);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(178, 32);
            this.label16.TabIndex = 9;
            this.label16.Text = "صلاحيات المستخدم";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Hacen Saudi Arabia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(976, 9);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 32);
            this.label7.TabIndex = 10;
            this.label7.Text = "بيانات المستخدم";
            // 
            // grpPermissions
            // 
            this.grpPermissions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grpPermissions.Controls.Add(this.chkUsers);
            this.grpPermissions.Controls.Add(this.chkMonitor);
            this.grpPermissions.Controls.Add(this.chkSettings);
            this.grpPermissions.Controls.Add(this.chkPrint);
            this.grpPermissions.Controls.Add(this.chkInsert);
            this.grpPermissions.Controls.Add(this.chkUpdate);
            this.grpPermissions.Controls.Add(this.chkAdmin);
            this.grpPermissions.Location = new System.Drawing.Point(18, 30);
            this.grpPermissions.Margin = new System.Windows.Forms.Padding(4);
            this.grpPermissions.Name = "grpPermissions";
            this.grpPermissions.Size = new System.Drawing.Size(301, 183);
            this.grpPermissions.TabIndex = 12;
            // 
            // chkAdmin
            // 
            this.chkAdmin.AutoSize = true;
            this.chkAdmin.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAdmin.ForeColor = System.Drawing.Color.DarkRed;
            this.chkAdmin.Location = new System.Drawing.Point(8, 9);
            this.chkAdmin.Margin = new System.Windows.Forms.Padding(4);
            this.chkAdmin.Name = "chkAdmin";
            this.chkAdmin.Size = new System.Drawing.Size(185, 25);
            this.chkAdmin.TabIndex = 4;
            this.chkAdmin.Text = "ADMINISTRATOR";
            this.chkAdmin.UseVisualStyleBackColor = true;
            this.chkAdmin.CheckedChanged += new System.EventHandler(this.chkAdmin_CheckedChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(9)))), ((int)(((byte)(0)))));
            this.btnDelete.Font = new System.Drawing.Font("Hacen Saudi Arabia", 13.8F);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.ImageList = this.imageList1;
            this.btnDelete.Location = new System.Drawing.Point(310, 218);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(232, 58);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "حذف";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(83)))), ((int)(((byte)(94)))));
            this.btnAddUser.Font = new System.Drawing.Font("Hacen Saudi Arabia", 13.8F);
            this.btnAddUser.ForeColor = System.Drawing.Color.White;
            this.btnAddUser.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddUser.Location = new System.Drawing.Point(917, 217);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(232, 58);
            this.btnAddUser.TabIndex = 16;
            this.btnAddUser.Text = "اضافة";
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(48)))), ((int)(((byte)(0)))));
            this.btnUpdate.Font = new System.Drawing.Font("Hacen Saudi Arabia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.Location = new System.Drawing.Point(610, 218);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(232, 58);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "تعديل";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.btnRefresh.Font = new System.Drawing.Font("Hacen Saudi Arabia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Image = global::BookProject.Properties.Resources.ref4;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.Location = new System.Drawing.Point(18, 217);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(232, 58);
            this.btnRefresh.TabIndex = 14;
            this.btnRefresh.Text = "تحديث";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // FrmUserManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 662);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.grpUserInfo);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.grpPermissions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1190, 709);
            this.Name = "FrmUserManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إدارة المستخدمين";
            this.Load += new System.EventHandler(this.FrmUserManagement_Load);
            this.contextMenuStrip2.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.grpUserInfo.ResumeLayout(false);
            this.grpUserInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).EndInit();
            this.grpPermissions.ResumeLayout(false);
            this.grpPermissions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.CheckBox chkUsers;
        private System.Windows.Forms.CheckBox chkMonitor;
        private System.Windows.Forms.CheckBox chkSettings;
        private System.Windows.Forms.CheckBox chkPrint;
        private System.Windows.Forms.CheckBox chkInsert;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn N;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserJob;
        private System.Windows.Forms.DataGridViewTextBoxColumn id1;
        private System.Windows.Forms.DataGridViewImageColumn UserPic;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem cmsDeleteUser;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cmsDeletePicture;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.CheckBox chkUpdate;
        private System.Windows.Forms.Panel grpUserInfo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblUserPic;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picUser;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtUserPassword;
        private System.Windows.Forms.TextBox txtUserJob;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel grpPermissions;
        private System.Windows.Forms.CheckBox chkAdmin;
        protected internal System.Windows.Forms.Button btnRefresh;
        protected internal System.Windows.Forms.Button btnResetPass;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnUpdate;
    }
}