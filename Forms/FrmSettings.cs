using BookProject.Classes;
using BookProject.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookProject.Forms
{
    public partial class FrmSettings : Form
    {
        public FrmSettings()
        {
            InitializeComponent();
        }
        //===========Variables======
        bool testCon;
        //=======funcsion=================
        void backupDatabase()
        {
            // BACKUP DATABASE StudentDB TO Disk='D:\bbb\std1.bak' WITH INIT
            try
            {
                ConClass.SqlQuery = "BACKUP DATABASE " + Settings.Default.Database + " TO DISK ='" + txtBackupPath.Text.Trim() + @"\" + txtBackupName.Text.Trim() + ".bak' WITH INIT";
                ConClass.cmd = new SqlCommand(ConClass.SqlQuery, ConClass.con);
                ConClass.con.Open();
                ConClass.cmd.ExecuteNonQuery();
                ConClass.con.Close();

                MessageBox.Show("Database Backup successfully ", "Backup Database", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                ConClass.con.Close();
                MessageBox.Show("Failed to backup the database" + Environment.NewLine + ex.Message, "Backup Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmSettings_Load(object sender, EventArgs e)
        {
            this.Width = 1240;
            this.Height = 710;
            txtServer.Text = Settings.Default.Server;
            txtDatabase.Text = Settings.Default.Database;
            txtSQLUser.Text = Settings.Default.SQLLogin;
            txtSQLPassword.Text = Settings.Default.SQLPassword;

            txtAdminName.Text = Settings.Default.AdminName;
            txtAdminPass.Text = Settings.Default.AdminPassword;

            txtNumberOne.Text = Settings.Default.NuberOne;
            txtNumberTwo.Text = Settings.Default.NuberTwo;
            txtLibraryWebsite.Text = Settings.Default.LibraryWebsite;

            panel8.BackColor = Settings.Default.Color;

            if (VariablesClass.userId != 1)
            {
                txtAdminName.ReadOnly = true;
                txtAdminName.UseSystemPasswordChar = true;
                txtAdminPass.ReadOnly = true;
            }

            txtCompany.Text = Settings.Default.libraryName;
            txtAutoBackupPath.Text = Settings.Default.AutoBackupPath;

            if (Settings.Default.BackupFiles == 0)
                chkUnlimitedFiles.Checked = true;
            else
                txtBackupFiles.Text = Settings.Default.BackupFiles.ToString();

            if (Settings.Default.BackupDays == 0)
                chkUnlimitedDays.Checked = true;
            else
                txtBackupDays.Text = Settings.Default.BackupDays.ToString();

            radYes.Checked = Settings.Default.AutoBackup;

            cmbDateFormat.Items.Add("dd-MM-yyyy");
            cmbDateFormat.Items.Add("dd.MM.yyyy");
            cmbDateFormat.Items.Add("dd/MM/yyyy");

            cmbDateFormat.Text = Settings.Default.DateFormat;

           
            txtBackupPath.Select();
        }

        private void btnBackupPath_Click(object sender, EventArgs e)
        {
            string DeskTopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                if (folderBrowserDialog1.SelectedPath != @"C:\"
                          & folderBrowserDialog1.SelectedPath != DeskTopPath)
                    txtBackupPath.Text = folderBrowserDialog1.SelectedPath;
                else
                    MessageBox.Show("The backup cannot be placed on the hard disk " + Environment.NewLine + @"'C:\'" + " directly or on the desktop");
            }
        }

        private async void btnBackupDatabase_Click(object sender, EventArgs e)
        {
            if (txtBackupPath.Text == "")
            {
                btnBackupPath.PerformClick();
                return;
            }
            if (txtBackupName.Text == "")
            {
                MessageBox.Show("Please insert Backup name", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtBackupName.Focus();
                return;
            }

            Task task = new Task(backupDatabase);
            task.Start();

            lblWait.Visible = true;
            this.UseWaitCursor = true;
            VariablesClass.backupProcess = true;
            lblWait.Text = "Processing please wait...";
            await task;
            VariablesClass.backupProcess = false;
            this.UseWaitCursor = false;
            lblWait.Text = "done...";
            lblWait.Visible = false;
        }

        private void btnRestoeDatabase_Click(object sender, EventArgs e)
        {
            ofd.Filter = "Bakup files (*.Bak)|*.Bak|All Files|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ConClass.SqlQuery = "Use master Restore Database " + Settings.Default.Database + " From Disk= '" + ofd.FileName + "' WITH REPLACE";
                    //ConClass.sqlQuery = "Use master Restore Database StudentDB From Disk= 'D:\\bak\\test1.bak' WITH REPLACE";

                    ConClass.cmd = new SqlCommand(ConClass.SqlQuery, ConClass.con);
                    ConClass.con.Open();
                    ConClass.cmd.ExecuteNonQuery();
                    ConClass.con.Close();
                    MessageBox.Show("تم استعادة النسخة الإحتياطية من قواعد البيانات بنجاح", "انشاء نسخة أحتياطية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                catch (Exception ex)
                {
                    ConClass.con.Close();
                    if (MessageBox.Show("تم ايقاف العملية " + Environment.NewLine + ex.Message, "استعادة نسخة أحتياطية", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign) == DialogResult.Retry)
                        btnRestoeDatabase_Click(sender, e);
                }
            }
        }

        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            var newCon = new SqlConnection("Data Source=" + txtServer.Text + ";Initial Catalog=master;Integrated Security=False;User Id=" + txtSQLUser.Text + ";Password=" + txtSQLPassword.Text + ";");
            var dtTestCon = new DataTable();
            try
            {
                ConClass.SqlQuery = "SELECT * FROM sys.databases WHERE name = '" + txtDatabase.Text + "'";
                ConClass.da = new SqlDataAdapter(ConClass.SqlQuery, newCon);
                ConClass.da.Fill(dtTestCon);

                if (dtTestCon.Rows.Count == 0)
                {
                    MessageBox.Show("Database Name is not found");
                    testCon = false;
                }
                else
                {
                    MessageBox.Show("The Connection Is True");
                    testCon = true;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error in Settings Of System Conncetion " + Environment.NewLine + ex.Message);
                testCon = false;
            }
        }

        private void btnAutoBackupPath_Click(object sender, EventArgs e)
        {
            string DeskTopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                if (folderBrowserDialog1.SelectedPath != @"C:\" & folderBrowserDialog1.SelectedPath != DeskTopPath)
                {
                    txtAutoBackupPath.Text = folderBrowserDialog1.SelectedPath;
                }
                else
                {
                    MessageBox.Show("The backup cannot be placed on the hard disk " + Environment.NewLine + @"'C:\'" + " directly or on the desktop");
                }
            }
        }

        private void chkUnlimitedFiles_CheckedChanged(object sender, EventArgs e)
        {
            txtBackupFiles.Text = "";
            if (chkUnlimitedFiles.Checked)
                txtBackupFiles.Enabled = false;
            else
            {
                txtBackupFiles.Enabled = true;
                txtBackupFiles.Focus();
            }
        }

        private void chkUnlimitedDays_CheckedChanged(object sender, EventArgs e)
        {
            txtBackupDays.Text = "";
            if (chkUnlimitedDays.Checked)
                txtBackupDays.Enabled = false;
            else
            {
                txtBackupDays.Enabled = true;
                txtBackupDays.Focus();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(" Do you want to save the settings?", "Save Settings", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {


                if (MessageBox.Show(" Do you want to save the settings?", "Save Settings", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (Settings.Default.Server == txtServer.Text.Trim() & Settings.Default.Database == txtDatabase.Text.Trim() & Settings.Default.SQLLogin == txtSQLUser.Text.Trim() & Settings.Default.SQLPassword == txtSQLPassword.Text)
                        testCon = true;  //  bool testCon;
                    else
                        btnTestConnection_Click(sender, e);

                    if (testCon == false)
                    {
                        MessageBox.Show("Cannot Save The Settings, Error in system Conncetion ", "Failed to save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    Settings.Default.Server = txtServer.Text.Trim();
                    Settings.Default.Database = txtDatabase.Text.Trim();
                    Settings.Default.SQLLogin = txtSQLUser.Text.Trim();
                    Settings.Default.SQLPassword = txtSQLPassword.Text;

                    Settings.Default.AdminName = txtAdminName.Text.Trim();
                    Settings.Default.AdminPassword = txtAdminPass.Text;
                    Settings.Default.libraryName = txtCompany.Text.Trim();

                    Settings.Default.NuberOne = txtNumberOne.Text.Trim();
                    Settings.Default.NuberTwo = txtNumberTwo.Text.Trim();
                    Settings.Default.LibraryWebsite = txtLibraryWebsite.Text.Trim();

                    Settings.Default.Color = panel8.BackColor;
                    // -------------------------------------------------
                    Settings.Default.AutoBackup = radYes.Checked; // True Or False
                    Settings.Default.AutoBackupPath = txtAutoBackupPath.Text; // D:\StudentBak
                    int backupFiles, backupDays;
                    int.TryParse(txtBackupFiles.Text, out backupFiles);
                    Settings.Default.BackupFiles = backupFiles;
                    int.TryParse(txtBackupDays.Text, out backupDays);
                    Settings.Default.BackupDays = backupDays;
                    // --------------------------------------------------------
                    Settings.Default.DateFormat = cmbDateFormat.Text;



                    Settings.Default.Save();


                    //---------------Refresh FrmMain---------------------------------------

                    //FrmMain frmMain1 = new FrmMain();
                    FrmMain frmMain = Application.OpenForms.OfType<FrmMain>().FirstOrDefault();


                    if (frmMain != null)
                        frmMain.FrmMain_Load(sender, e);

                    MessageBox.Show("Settings saved successfully", "Save Settings", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }
        }

        private void bntCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            panel8.BackColor = label13.BackColor;
        }

        private void label14_Click(object sender, EventArgs e)
        {
            panel8.BackColor = label14.BackColor;
        }

        private void label20_Click(object sender, EventArgs e)
        {
            panel8.BackColor = label20.BackColor;
        }

        private void label17_Click(object sender, EventArgs e)
        {
            panel8.BackColor = label17.BackColor;
        }

       
    }
}
