using BookProject.Classes;
using BookProject.Properties;
using BookProject.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookProject.Forms
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        //===========Variables======

        DataTable dt = new DataTable();
        ResizeControls r = new ResizeControls();
        int cr = -1;
        int bookId;
        bool conState = false;
        bool ChackMotion = false, ChackUp = false;
        //=======funcsion=================
        void clearSearch()
        {
            bookId = 0;
            cr = -1;

            dgvBooks.ClearSelection();
            progressBar1.Value = 0;

            txtRegNum.SelectAll();
            txtRegNum.Focus();
            cmbCatecory.SelectedIndex = 0;
        }

        void Set_Color()
        {
            if (Settings.Default.Color == Color.FromArgb(0, 48, 73))
            {
                menuStrip1.BackColor = Settings.Default.Color;
                panel2.BackColor = Settings.Default.Color;
                panel2.ForeColor = Color.White;
                menuStrip1.ForeColor = Color.White;
            }
            else if (Settings.Default.Color == Color.FromArgb(2, 62, 138))
            {
                menuStrip1.BackColor = Settings.Default.Color;
                panel2.BackColor = Settings.Default.Color;
                panel2.ForeColor = Color.White;
                menuStrip1.ForeColor = Color.White;
            }
            else
            {
                menuStrip1.BackColor = Settings.Default.Color;
                panel2.BackColor = Settings.Default.Color;
                panel2.ForeColor = Color.Black;
                menuStrip1.ForeColor = Color.Black;
            }

        }
        void EditFont_MouseEnter(Button b)
        {
            Font f;
            f = b.Font;
            b.Font = new Font(f.Name, f.Size + 2, FontStyle.Regular);
        }
        void EditFont_MouseLeave(Button b)
        {
            Font f;
            f = b.Font;
            b.Font = new Font(f.Name, f.Size - 2, FontStyle.Regular);
        }
        void PicMouseEnter(PictureBox p)
        {
            p.SetBounds(p.Left - 3, p.Top - 3, p.Width + 6, p.Height + 6);
        }
        void PicMouseLeave(PictureBox p)
        {
            p.SetBounds(p.Left + 3, p.Top + 3, p.Width - 6, p.Height - 6);
        }

        void PicMotion_MouseEnter(PictureBox p, Label l)
        {
            p.SetBounds(p.Left, p.Top, p.Width, p.Height = 56);

            l.Visible = true;
        }
        void PicMotion_MouseLeave(PictureBox p, Label l)
        {
            
            p.SetBounds(p.Left, p.Top, p.Width, p.Height = panel1.Height-10 );

            l.Visible = false;
        }

        void SaveFormSize()
        {
            if (this.WindowState != FormWindowState.Maximized)
            {
                Settings.Default.FrmMainSize = this.Size;
                Settings.Default.FrmMainLocation = this.Location;
            }

            Settings.Default.FrmMainWindowState = (int)this.WindowState;
            Settings.Default.Save();
        }
        void BackupDatabase()
        {
            try
            {
                //if (Directory.Exists(Settings.Default.AutoBackupPath) == false)

                if (!Directory.Exists(Settings.Default.AutoBackupPath))
                {
                    Directory.CreateDirectory(Settings.Default.AutoBackupPath);
                    Settings.Default.BackupCounter = 0;
                    Settings.Default.Save();
                }

                ConClass.SqlQuery = "backup database " + Settings.Default.Database + " TO DISK ='" + Settings.Default.AutoBackupPath + @"\" + "(" + DateTime.Now.ToString("dd-MM-yyyy") + ")" + "Auto_" + Settings.Default.Database + (Settings.Default.BackupCounter + 1) + ".bak' WITH INIT";
                ConClass.cmd = new SqlCommand(ConClass.SqlQuery, ConClass.con);
                ConClass.con.Open();
                ConClass.cmd.ExecuteNonQuery();
                ConClass.con.Close();
                Settings.Default.BackupCounter = Settings.Default.BackupCounter + 1;
                Settings.Default.Save();

                ShowBackupInfo();
                DeleteBackupDays();
                DeleteBackupFiles();
            }

            catch (Exception ex)
            {
                ConClass.con.Close();
                MessageBox.Show("فشل في أخذ نسخة احتياطية من قاعدة البيانات" + Environment.NewLine + ex.Message, "نسخ احتياطي  لقاعدة البيانات", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign);
            }
        }

        void ShowBackupInfo()
        {
            var di = new DirectoryInfo(Settings.Default.AutoBackupPath);
            var fl = di.GetFileSystemInfos().ToList();
            string last =
                        (from file in from file in fl select file
                         orderby file.CreationTime descending
                         select file)
                         .FirstOrDefault().FullName;


            var fi = new FileInfo(last);

            notifyIcon1.BalloonTipText += Environment.NewLine + fi.FullName + Environment.NewLine + "(" + fi.Length / 1024L / 1024L + " MBytes) " + Convert.ToString(fi.LastWriteTime);
            notifyIcon1.ShowBalloonTip(1);



            DriveInfo dri = new DriveInfo(Path.GetPathRoot(Settings.Default.AutoBackupPath));

            if (dri.AvailableFreeSpace < fi.Length * 3)
            {
                MessageBox.Show("المساحة المتاحة للنسخ الإحتياطي انتهت سيتم ايقاف النسخ الإحتياطي التلقائي ", "تحذير انخفاض مساحة القرص الصلب", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Settings.Default.AutoBackup = false;
                Settings.Default.Save();
            }
            else if (dri.AvailableFreeSpace < fi.Length * 6)
            {
                MessageBox.Show("المساحة المتاحة للنسخ الإحتياطي لقواعد البيانات في القرص الصلب على وشك الانتهاء ", "تحذير انخفاض مساحة القرص الصلب", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }
        void DeleteBackupDays()
        {
            if (Settings.Default.BackupDays == 0)
                return;

            var di = new DirectoryInfo(Settings.Default.AutoBackupPath);



            foreach (FileInfo file in di.GetFiles("*.bak", SearchOption.TopDirectoryOnly))
            {
                if ((DateTime.Now - file.CreationTime).Days > Settings.Default.BackupDays)
                    file.Delete();
            }
        }
        void DeleteBackupFiles()
        {
            if (Settings.Default.BackupFiles == 0)
                return;

            var di = new DirectoryInfo(Settings.Default.AutoBackupPath);

            var fl = di.GetFiles("*.bak", SearchOption.TopDirectoryOnly);  /*var fl = di.GetFileSystemInfos().ToList();*/

            foreach (var ff in from file in from file in fl select file orderby file.CreationTime ascending select file)
            {
                if (di.GetFiles("*.bak", SearchOption.TopDirectoryOnly).Count() > Settings.Default.BackupFiles)
                    ff.Delete();
            }


            //Directory.GetFiles(Settings.Default.AutoBackupPath).Count();
        }

        void FillDgvBooks()
        {
            try
            {
                dt.Clear();
                ConClass.SqlQuery = "SELECT ROW_NUMBER() OVER (ORDER BY (SELECT 1)) N, " +
                    "TblBooks.*,TblUsers.UserName,TblCategory.BookCategory  " +
                    "FROM TblBooks,TblUsers,TblCategory WHERE TblUsers.id = TblBooks.UserId " +
                    "AND TblBooks.Id = TblCategory.BookId";

                ConClass.da = new SqlDataAdapter(ConClass.SqlQuery, ConClass.con);
                ConClass.da.Fill(dt);
                dt.Columns["N"].SetOrdinal(1);
                dgvBooks.DataSource = dt;

                dgvBooks.Columns[9].DefaultCellStyle.Format = Settings.Default.DateFormat;
            }
            catch (Exception ex)
            {
                MessageBox.Show("فشل في الاتصال بقواعد البيانات" + Environment.NewLine + Environment.NewLine + ex.Message, "خطأ اتصال", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conState = true;
            }
            if (conState == false)
            {
                lblBooks.Text = dt.Rows.Count.ToString();
            }
        }

        void SetPermissions()

        {
            if (VariablesClass.updatePermission == false)
            {
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
            }

            if (VariablesClass.insertPermission == false)
            {
                
                btnAddBook.Enabled = false;
            }

            if (VariablesClass.printPermission == false)
            {
                picPrintBookInformation.Enabled = false;
                picPrintInformationBooks.Enabled = false;
            }



            if (VariablesClass.settingsPermission == false)
            {
                picSettings.Visible = false;  // لوحة التحكم
                tsmSettings.Enabled = false;
            }

            if (VariablesClass.MonitorPermission == false)
            {
                picMonitor.Visible = false;
                tsmMonitor.Enabled = false;
            }

            // picSettings.Visible = VariablesClass.settingsPermission;  // لوحة التحكم
            // tsmSettings.Enabled = VariablesClass.settingsPermission;

        }
        //=================================
        private void FrmMain_Resize(object sender, EventArgs e)
        {
            r.ResizeControl();
            lblUserInfo.Margin = new Padding(this.Width - (lblDateNow.Width + lblUserInfo.Width + lblUser.Width + 50), 5, 0, 5);

        }
        private void FrmMain_HandleCreated(object sender, EventArgs e)
        {
            r.Container = this;
        }
        public void FrmMain_Load(object sender, EventArgs e)
        {
            SetPermissions();
            Set_Color();
            lblLibrary.Text = Settings.Default.libraryName;
            dgvBooks.ColumnHeadersDefaultCellStyle.Font = new Font("Hacen Saudi Arabia", 12, FontStyle.Regular);
            dgvBooks.DefaultCellStyle.Font = new Font("Times New Roman", 14, FontStyle.Regular);

            cmbCatecory.SelectedIndex = 0;

            lblDateNow.Text = DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss tt");
            lblUser.Text = "مستخدم المنظومة :";
            lblUserInfo.Text = VariablesClass.userName + " - " + VariablesClass.userJob;
            lblUserInfo.Margin = new Padding(this.Width - (lblDateNow.Width + lblUserInfo.Width + lblUser.Width + 50), 5, 0, 5);
            FillDgvBooks();
        }

        private void picUsers_MouseEnter(object sender, EventArgs e)
        {
            PicMouseEnter(picUsers);
        }

        private void picUsers_MouseLeave(object sender, EventArgs e)
        {
            PicMouseLeave(picUsers);
        }

        private void picSettings_MouseEnter(object sender, EventArgs e)
        {
            PicMouseEnter(picSettings);

        }

        private void picSettings_MouseLeave(object sender, EventArgs e)
        {
            PicMouseLeave(picSettings);

        }

        private void picMonitor_MouseEnter(object sender, EventArgs e)
        {
            PicMouseEnter(picMonitor);

        }

        private void picMonitor_MouseLeave(object sender, EventArgs e)
        {
            PicMouseLeave(picMonitor);

        }
        private void dgvBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dgvBooks_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvBooks.CurrentRow == null) return;
                if (dgvBooks.CurrentRow.Index == dgvBooks.Rows.Count
                    | dgvBooks.Rows[dgvBooks.CurrentRow.Index].Cells[0].Value == null
                    | dgvBooks.Rows[dgvBooks.CurrentRow.Index].Selected == false)
                    return;
            }
            catch
            {
                return;
            }

            cr = dgvBooks.CurrentRow.Index;
            bookId = (int)dgvBooks.Rows[cr].Cells[0].Value;
            VariablesClass.BookId = bookId;
            VariablesClass.RegNum = dgvBooks.Rows[cr].Cells[2].Value.ToString();
            VariablesClass.Title = dgvBooks.Rows[cr].Cells[3].Value.ToString();
            VariablesClass.Description = dgvBooks.Rows[cr].Cells[4].Value.ToString();
            VariablesClass.AuthorName = dgvBooks.Rows[cr].Cells[5].Value.ToString();
            VariablesClass.Price = dgvBooks.Rows[cr].Cells[6].Value.ToString();
            VariablesClass.YearOfPublication = (DateTime)dgvBooks.Rows[cr].Cells[9].Value;
            VariablesClass.Category = dgvBooks.Rows[cr].Cells[11].Value.ToString();
            if (dt.Rows[cr][7] is DBNull == false)
            {
                byte[] img = (byte[])dt.Rows[cr][7];     // تخزين الصورة في مصفوفة من البايتات
                var ms = new MemoryStream(img);                // حجز مساحة في الذاكرة لتركيب الصورة من مصفوفة البايتات 'Imports System.IO
                VariablesClass.PicBook = Image.FromStream(ms);

            }
            else
            {
                VariablesClass.PicBook = null;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (bookId == 0)
            {
                MessageBox.Show("لم يتم تحديد الكتاب ", "تعديل بيانات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            FrmUpDateBook frmUpDateBook = new FrmUpDateBook();
            frmUpDateBook.ShowDialog();
            bookId = 0;
            btnRefresh_Click(sender, e);
        }

        public void btnRefresh_Click(object sender, EventArgs e)
        {
            FillDgvBooks();
            clearSearch();
        }

        private void dgvBooks_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvBooks.SortOrder.ToString() == "Ascending")
                dt.DefaultView.Sort = dgvBooks.SortedColumn.Name + " ASC";
            else if (dgvBooks.SortOrder.ToString() == "Descending")
                dt.DefaultView.Sort = dgvBooks.SortedColumn.Name + " DESC";

            dt = dt.DefaultView.ToTable();
        }

        private void dgvBooks_Sorted(object sender, EventArgs e)
        {
            bookId = 0;
            dgvBooks.ClearSelection();
        }



        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (bookId == 0)
                return;

            if (MessageBox.Show("سيتم حذف كتاب" + " " + dgvBooks.Rows[cr].Cells[3].Value.ToString(), "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {

                try
                {

                    ConClass.cmd = new SqlCommand("BookDelete", ConClass.con);
                    ConClass.cmd.CommandType = CommandType.StoredProcedure;

                    var param = new SqlParameter();
                    param = new SqlParameter("@Id", bookId);
                    ConClass.cmd.Parameters.Add(param);
                    ConClass.cmd.Parameters.Add("@SaveState", SqlDbType.Int).Direction = ParameterDirection.Output;

                    ConClass.con.Open();
                    ConClass.cmd.ExecuteNonQuery();
                    ConClass.con.Close();

                    int saveState = Convert.ToInt32(ConClass.cmd.Parameters["@SaveState"].Value.ToString());

                    if (saveState == 1)
                    {
                        btnRefresh.PerformClick();
                        MessageBox.Show(" تم حذف الكتاب بنجاح ", "حذف بيانات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (saveState == 0)
                    {
                        MessageBox.Show(" لم يتم الحذف، خطأ في تنفيذ العملية", "خطأ في الحذف", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }



                }
                catch (Exception ex)
                {

                    ConClass.con.Close();
                    MessageBox.Show("فشل في الإتصال بقاعدة البيانات" + Environment.NewLine + ex.Message, "خطأ إتصال", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (VariablesClass.backupProcess == true)
            {
                MessageBox.Show("لا يمكن اغلاق المنظومة .. جاري أخذ نسخة احتياطية من قاعدة البيانات" + Environment.NewLine, "نسخ احتياطي  لقاعدة البيانات", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
                return;
            }

            if (MessageBox.Show("هل تريد إغلاق المنظومة", "تأكيد طلب إغلاق", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                e.Cancel = true;

                if (Settings.Default.AutoBackup == true)
                    BackupDatabase();


                SaveFormSize();

                timClosing.Enabled = true;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void btnInfoBook_Click(object sender, EventArgs e)
        {
            if (bookId == 0)
            {
                MessageBox.Show("لم يتم تحديد الكتاب ", "تعديل بيانات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            FrmInfoBook frmInfoBook = new FrmInfoBook();
            frmInfoBook.ShowDialog();
        }

        private void timTime_Tick(object sender, EventArgs e)
        {
            lblDateNow.Text = DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss tt");
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void txtRegNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) == false)
            {
                e.Handled = true;
            }
            if ((Keys)e.KeyChar == Keys.Back)
            {
                e.Handled = false;

            }
        }

        private void txtRegNum_TextChanged(object sender, EventArgs e)
        {
            if (txtRegNum.Text == "")
            {
                clearSearch();
            }
        }

       

        private void cmbCatecory_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbCatecory.Text.Trim() == "الكل")
            {
                cmbCatecory.Text = "";
            }
            try
            {
                dt.Clear();
                ConClass.SqlQuery = "SELECT DISTINCT ROW_NUMBER() OVER (ORDER BY (SELECT 1)) N," +
                "TblBooks.*, TblUsers.UserName, TblCategory.BookCategory" +
               " FROM TblBooks, TblUsers, TblCategory WHERE TblBooks.UserID = TblUsers.id " +
                "AND TblBooks.Id = TblCategory.BookId AND BookCategory LIKE '%" + cmbCatecory.Text.Trim() + "%' ";

                ConClass.da = new SqlDataAdapter(ConClass.SqlQuery, ConClass.con);
                ConClass.da.Fill(dt);
                dgvBooks.DataSource = dt;
                dgvBooks.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("فشل في الإتصال بقاعدة البيانات" + Environment.NewLine + ex.Message, "خطأ إتصال", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbCatecory_TextChanged(object sender, EventArgs e)
        {
            if (cmbCatecory.Text == "")
            {
                cmbCatecory.SelectedIndex = 0;
            }
        }


        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            if (btnSearch.Text == "بحث")
            {


                if (txtRegNum.Text.Trim() == "")
                {
                    MessageBox.Show("الرجاء ادخال رقم الكتاب", "بحث", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtRegNum.Focus();
                    return;
                }
                FillDgvBooks();

                progressBar1.Value = 0;
                progressBar1.Minimum = 0;
                progressBar1.Maximum = dt.Rows.Count;

                for (int i = 0; i <= dt.Rows.Count - 1; i++)
                {
                    if (Convert.ToInt64(txtRegNum.Text) == (long)dt.Rows[i][2])  // search in dgv after sort
                    {
                        bookId = (int)dgvBooks.Rows[i].Cells[0].Value;
                        VariablesClass.BookId = bookId;
                        VariablesClass.RegNum = dgvBooks.Rows[i].Cells[2].Value.ToString();
                        VariablesClass.Title = dgvBooks.Rows[i].Cells[3].Value.ToString();
                        VariablesClass.Description = dgvBooks.Rows[i].Cells[4].Value.ToString();
                        VariablesClass.AuthorName = dgvBooks.Rows[i].Cells[5].Value.ToString();
                        VariablesClass.Price = dgvBooks.Rows[i].Cells[6].Value.ToString();
                        VariablesClass.YearOfPublication = (DateTime)dgvBooks.Rows[i].Cells[9].Value;
                        if (dt.Rows[i][7] is DBNull == false)
                        {
                            byte[] img = (byte[])dt.Rows[i][7];     // تخزين الصورة في مصفوفة من البايتات
                            var ms = new MemoryStream(img);                // حجز مساحة في الذاكرة لتركيب الصورة من مصفوفة البايتات 'Imports System.IO
                            VariablesClass.PicBook = Image.FromStream(ms);

                        }
                        else
                        {
                            VariablesClass.PicBook = null;
                        }
                        progressBar1.Value = progressBar1.Maximum;

                        dgvBooks.Rows[i].Selected = true;
                        dgvBooks.FirstDisplayedScrollingRowIndex = i;
                        cr = i;  // int cr = -1;
                        btnSearch.Text = "جديد";
                        return;
                    }
                    progressBar1.Value = progressBar1.Value + 1;
                }
                MessageBox.Show("رقم الكتاب غير موجود  ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearSearch();
            }
            else if (btnSearch.Text == "جديد")
            {
                FillDgvBooks();
                clearSearch();
                btnSearch.Text = "بحث";
            }
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            FrmInsertBook frmInsertBook = new FrmInsertBook();
            frmInsertBook.ShowDialog();
            btnRefresh_Click(sender, e);
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (bookId == 0)
            {
                MessageBox.Show("لم يتم تحديد الكتاب ", "حذف بيانات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("سيتم حذف كتاب" + " " + dgvBooks.Rows[cr].Cells[3].Value.ToString(), "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {

                try
                {

                    ConClass.cmd = new SqlCommand("BookDelete", ConClass.con);
                    ConClass.cmd.CommandType = CommandType.StoredProcedure;

                    var param = new SqlParameter[2];
                    param[0] = new SqlParameter("@Id", bookId);
                    param[1] = new SqlParameter("@UserId", VariablesClass.userId);
                    ConClass.cmd.Parameters.AddRange(param);
                    ConClass.cmd.Parameters.Add("@SaveState", SqlDbType.Int).Direction = ParameterDirection.Output;

                    ConClass.con.Open();
                    ConClass.cmd.ExecuteNonQuery();
                    ConClass.con.Close();

                    int saveState = Convert.ToInt32(ConClass.cmd.Parameters["@SaveState"].Value.ToString());

                    if (saveState == 1)
                    {
                        btnRefresh.PerformClick();
                        MessageBox.Show(" تم حذف الكتاب بنجاح ", "حذف بيانات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (saveState == 0)
                    {
                        MessageBox.Show(" لم يتم الحذف، خطأ في تنفيذ العملية", "خطأ في الحذف", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }



                }
                catch (Exception ex)
                {

                    ConClass.con.Close();
                    MessageBox.Show("فشل في الإتصال بقاعدة البيانات" + Environment.NewLine + ex.Message, "خطأ إتصال", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void picUsers_Click(object sender, EventArgs e)
        {
            if (VariablesClass.usersPermission == true)
            {
                FrmUserManagement frmUsers = new FrmUserManagement();
                frmUsers.ShowDialog();
            }
            else if (VariablesClass.usersPermission == false)
            {
                FrmChangePassword frmChangePassword = new FrmChangePassword();
                frmChangePassword.ShowDialog();

                //MessageBox.Show("ليس لديك الصلاحيات للدخول الى ادارة المستخدمين ", "تحذير مستوى الصلاحية", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void timClosing_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.05;
            if (this.Opacity <= 0)
            {
                Environment.Exit(0);
            }
        }

        private void picSettings_Click(object sender, EventArgs e)
        {
            Form frmConfirmPassword = new FrmConfirmPassword();
            frmConfirmPassword.ShowDialog();
        }

        private void timMotion_Tick(object sender, EventArgs e)
        {
            if (ChackMotion == true)
            {

                picPrintBookInformation.Height -= 1;
                if (picPrintBookInformation.Height <= 70)
                {
                    lblPrintBookInformation.Visible = true;
                }

                if (picPrintBookInformation.Height <= 56)
                {
                    timMotion.Enabled = false;
                    ChackUp = true;
                }

            }
        }

        private void picPrintBookInformation_MouseEnter(object sender, EventArgs e)
        {
            PicMotion_MouseEnter(picPrintBookInformation, lblPrintBookInformation);

        }

        private void picPrintBookInformation_MouseLeave(object sender, EventArgs e)
        {
            PicMotion_MouseLeave(picPrintBookInformation, lblPrintBookInformation);
        }
        private void picPrintInformationBooks_MouseEnter(object sender, EventArgs e)
        {
            PicMotion_MouseEnter(picPrintInformationBooks, lblPrintInformationBooks);
        }

        private void picPrintInformationBooks_MouseLeave(object sender, EventArgs e)
        {
            PicMotion_MouseLeave(picPrintInformationBooks, lblPrintInformationBooks);
           //yared
           //yared
        }

        private void picPrintInformationBooks_Click(object sender, EventArgs e)
        {
            var f = new FrmPrint();
            var c = new CrtList();


            c.SetDataSource(dt);
            f.crystalReportViewer1.ReportSource = c;   //Modifiers = Protected Internal

            c.SetParameterValue(0, Settings.Default.libraryName);
            f.crystalReportViewer1.Refresh();
            f.crystalReportViewer1.Zoom(100);
            f.Text = "طباعة القائمة ";
            f.WindowState = FormWindowState.Maximized;
            f.Show();
        }

        private void tsmExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsmChangePassword_Click(object sender, EventArgs e)
        {
            FrmChangePassword frmChangePassword = new FrmChangePassword();
            frmChangePassword.ShowDialog();
        }

        private void tsmAbout_Click(object sender, EventArgs e)
        {
            FrmAbout frmAbout = new FrmAbout();
            frmAbout.ShowDialog();
        }


        private void picPrintBookInformation_Click(object sender, EventArgs e)
        {
            if (bookId == 0)
            {
                MessageBox.Show("الرجاء تحديد الكتاب لطباعة بياناته", "طباعة بيانات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataTable dtPrint = new DataTable();
            try
            {
                ConClass.SqlQuery = "select * from TblBooks where  Id=" + bookId;
                ConClass.da = new SqlDataAdapter(ConClass.SqlQuery, ConClass.con);
                ConClass.da.Fill(dtPrint);
            }
            catch (Exception ex)
            {
                MessageBox.Show("فشل في الإتصال بقاعدة البيانات" + Environment.NewLine + ex.Message, "خطأ إتصال", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var f = new FrmPrint();
            var c = new CrtSelectedBook ();

            c.SetDataSource(dtPrint); 
            f.crystalReportViewer1.ReportSource = c;

            c.SetParameterValue(0, Settings.Default.libraryName);
            c.SetParameterValue(1, VariablesClass.userName); ;
            c.SetParameterValue(2, lblPrintBookInformation.Text);
            c.SetParameterValue(3, Settings.Default.NuberOne);
            c.SetParameterValue(4, Settings.Default.NuberTwo);
            c.SetParameterValue(5, Settings.Default.LibraryWebsite);

            f.Text = "طباعة الكتاب المحدد";
            f.crystalReportViewer1.Refresh();
            f.crystalReportViewer1.Zoom(100);
            f.WindowState = FormWindowState.Maximized;
            f.Show();
        }

        private void btnRefresh_MouseLeave(object sender, EventArgs e)
        {
            EditFont_MouseLeave(btnRefresh);
        }

        private void btnAddBook_MouseEnter(object sender, EventArgs e)
        {
            EditFont_MouseEnter(btnAddBook);
        }

        private void btnAddBook_MouseLeave(object sender, EventArgs e)
        {

            EditFont_MouseLeave(btnAddBook);
        }

        private void btnUpdate_MouseEnter(object sender, EventArgs e)
        {
            EditFont_MouseEnter(btnUpdate);

        }

        private void btnUpdate_MouseLeave(object sender, EventArgs e)
        {

            EditFont_MouseLeave(btnUpdate);
        }

        private void btnInfoBook_MouseEnter(object sender, EventArgs e)
        {
            EditFont_MouseEnter(btnInfoBook);

        }

        private void btnInfoBook_MouseLeave(object sender, EventArgs e)
        {

            EditFont_MouseLeave(btnInfoBook);
        }

        private void btnDelete_MouseEnter(object sender, EventArgs e)
        {

            EditFont_MouseEnter(btnDelete);
        }

        private void btnDelete_MouseLeave(object sender, EventArgs e)
        {

            EditFont_MouseLeave(btnDelete);
        }

        private void txtQuickSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dt.Clear();
                ConClass.SqlQuery = "SELECT ROW_NUMBER() OVER (ORDER BY (SELECT 1)) N, TblBooks.*,TblUsers.UserName  from TblBooks,TblUsers where TblBooks.UserId=TblUsers.Id AND Title + AuthorName like '%" + txtQuickSearch.Text.Trim() + "%'";
                ConClass.da = new SqlDataAdapter(ConClass.SqlQuery, ConClass.con);
                ConClass.da.Fill(dt);
                dgvBooks.DataSource = dt;
                dgvBooks.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("فشل في الإتصال بقاعدة البيانات" + Environment.NewLine + ex.Message, "خطأ إتصال", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmsinfo_Click(object sender, EventArgs e)
        {
            if (bookId == 0)
            {
                MessageBox.Show("لم يتم تحديد الكتاب ", "تعديل بيانات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            FrmInfoBook frmInfoBook = new FrmInfoBook();
            frmInfoBook.ShowDialog();
        }

        private void picMonitor_Click(object sender, EventArgs e)
        {
            FrmSystemMonitor frmSystemMonitor = new FrmSystemMonitor();
            frmSystemMonitor.ShowDialog();
        }

        private void btnRefresh_MouseEnter(object sender, EventArgs e)
        {
            EditFont_MouseEnter(btnRefresh);

        }
    }
}
