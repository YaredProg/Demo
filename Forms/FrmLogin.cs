using BookProject.Classes;
using BookProject.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace BookProject.Forms
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        //===========Variables======
        bool Down;
        Point Po;
        DataTable DataTable = new DataTable();
        int timerCount;

        //=======funcsion=============
        void PicEditMousEnter(PictureBox picture)
        {

            picture.BackColor = Color.Gray;

        }
        void PicEditMousLeave(PictureBox picture)
        {

            picture.BackColor = default(Color);

        }

        void EditFont_MousEnter(Button button)
        {
            Font f = button.Font;

            button.Font = new Font(f.Name, f.Size + 2, FontStyle.Bold);
        }
        void EditFont_MousLeave(Button button)
        {
            Font f = button.Font;
            button.Font = new Font(f.Name, f.Size - 2, FontStyle.Regular);
        }
        void MakeRoundedImage(Image img, PictureBox p)
        {
            if (picUser.Image == null) { return; }

            var bm = new Bitmap(img.Width, img.Height);
            Graphics grx2 = Graphics.FromImage(bm);
            grx2.SmoothingMode = SmoothingMode.AntiAlias;
            var tb = new TextureBrush(img);
            tb.TranslateTransform(0, 0);
            var gp = new GraphicsPath();
            gp.AddEllipse(0, 0, img.Width, img.Height);
            grx2.FillPath(tb, gp);
            if (p.Image is object)
                p.Image.Dispose();
            p.Image = new Bitmap(bm);


        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            MakeRoundedImage(picUser.Image, picUser);

            try
            {
                ConClass.SqlQuery = "SELECT * FROM TblUsers,TblPermissions WHERE TblUsers.id = TblPermissions.UserId";

                ConClass.da = new SqlDataAdapter(ConClass.SqlQuery, ConClass.con);
                ConClass.da.Fill(DataTable);

                cmbUserName.DataSource = DataTable;
                cmbUserName.DisplayMember = "UserName";
                cmbUserName.ValueMember = "id";

                txtPassword.Select();
                cmbUserName.SelectedValue = Settings.Default.SelectedUser;
                cmbUserName_SelectionChangeCommitted(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("فشل في الإتصال بقاعدة البيانات" +
                     Environment.NewLine + ex.Message, "خطأ إتصال", MessageBoxButtons.OK, MessageBoxIcon.Error);


                FrmAdmin frmAdmin = new FrmAdmin();
                frmAdmin.ShowDialog();
            }
        }

        private void picClose_MouseEnter(object sender, EventArgs e)
        {
            PicEditMousEnter(picClose);
        }

        private void picClose_MouseLeave(object sender, EventArgs e)
        {
            PicEditMousLeave(picClose);
        }

        private void picminimize_MouseEnter(object sender, EventArgs e)
        {
            PicEditMousEnter(picminimize);
        }

        private void picminimize_MouseLeave(object sender, EventArgs e)
        {
            PicEditMousLeave(picminimize);
        }

        private void btnOk_MouseEnter(object sender, EventArgs e)
        {
            EditFont_MousEnter(btnOk);
        }

        private void btnOk_MouseLeave(object sender, EventArgs e)
        {
            EditFont_MousLeave(btnOk);

        }

        private void btnExit_MouseEnter(object sender, EventArgs e)
        {
            EditFont_MousEnter(btnExit);

        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            EditFont_MousLeave(btnExit);

        }

        private void panel5_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Down = true;
                Po = e.Location;
            }
        }

        private void panel5_MouseUp(object sender, MouseEventArgs e)
        {
            Down = false;
        }

        private void panel5_MouseMove(object sender, MouseEventArgs e)
        {
            if (Down == true)
            {
                this.Location = new Point(this.Location.X + (e.X - Po.X), this.Location.Y + (e.Y - Po.Y));
            }
        }

        private void cmbUserName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbUserName.SelectedValue == null)
            {
                label4.Text = "رقم التسحيل >>";
                return;
            }
            label4.Text = "رقم التسجيل >> " + cmbUserName.SelectedValue.ToString();

            Settings.Default.SelectedUser = (int)cmbUserName.SelectedValue;
            Settings.Default.Save();
        }

        private void cmbUserName_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPassword.Clear();
            txtPassword.Focus();

            int cr = cmbUserName.SelectedIndex;
            if (cr == -1)
                return;

            if (DataTable.Rows[cr][4] is DBNull == false)
            {
                byte[] img = (byte[])DataTable.Rows[cr][4];
                var ms = new MemoryStream(img);
                picUser.Image = Image.FromStream(ms);

            }
            else
                picUser.Image = Properties.Resources.addstudent;

            MakeRoundedImage(picUser.Image, picUser);

        }

        private void cmbUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbUserName_SelectionChangeCommitted(sender, e);
            }
        }

        private void cmbUserName_TextChanged(object sender, EventArgs e)
        {
            if (cmbUserName.SelectedIndex == -1)
            {
                label3.Text = "";
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (cmbUserName.Text.Trim() == "")
            {
                MessageBox.Show("الرجاء ادخال اسم المستخدم", "خطأ ادخال", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbUserName.Focus();
                return;
            }

            if (txtPassword.Text == "")
            {
                MessageBox.Show("الرجاء ادخال كلمة المرور", "خطأ ادخال", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }

            for (int i = 0; i <= DataTable.Rows.Count - 1; i++)
            {
                if (cmbUserName.Text.Trim() == (string)DataTable.Rows[i][1])
                {
                    if (txtPassword.Text == (string)DataTable.Rows[i][2])
                    {

                        Settings.Default.ErrorLoginCount = 0;
                        Settings.Default.Save();

                        VariablesClass.userId = (int)DataTable.Rows[i][0];
                        VariablesClass.userName = (string)DataTable.Rows[i][1];
                        VariablesClass.userPassword = (string)DataTable.Rows[i][2];
                        VariablesClass.userJob = (string)DataTable.Rows[i][3];

                        if (DataTable.Rows[i][4] is DBNull == false)
                        {
                            byte[] img = (byte[])DataTable.Rows[i][4];     // تخزين الصورة في مصفوفة من البايتات
                            var ms = new MemoryStream(img);                // حجز مساحة في الذاكرة لتركيب الصورة من مصفوفة البايتات 'Imports System.IO
                            VariablesClass.PicUser = Image.FromStream(ms);

                        }
                        else
                        {
                            VariablesClass.PicUser = null;
                        }

                        VariablesClass.updatePermission = (bool)DataTable.Rows[i][7];
                        VariablesClass.printPermission = (bool)DataTable.Rows[i][8];
                        VariablesClass.usersPermission = (bool)DataTable.Rows[i][9];
                        VariablesClass.settingsPermission = (bool)DataTable.Rows[i][10];
                        VariablesClass.MonitorPermission = (bool)DataTable.Rows[i][11];
                        VariablesClass.insertPermission = (bool)DataTable.Rows[i][12];

                        if (txtPassword.Text == "0000")
                        {
                            MessageBox.Show("يرجى تغيير كلمة المرور الإفتراضية");
                            FrmChangePassword frmChange = new FrmChangePassword();
                            frmChange.ShowDialog();

                            if (VariablesClass.userPassword == "0000")
                            {
                                MessageBox.Show("لم يتم تغير كلمة المرور سيتم اغلاق النظومة لي اغراض امنية", "تغير كلمة المرور");
                                Environment.Exit(0);
                            }
                        }

                        this.Hide();
                        FrmMain frmMain = new FrmMain();
                        frmMain.Show();
                        return;

                    }
                    else
                    {
                        Settings.Default.ErrorLoginCount++;
                        Settings.Default.Save();

                        if (Settings.Default.ErrorLoginCount < 3)
                        {
                            MessageBox.Show("كلمة المرور غير صحيحة لقد استنفذت " + Settings.Default.ErrorLoginCount + " من 3 محاولات", "خطأ ادخال", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtPassword.Clear();
                            txtPassword.Focus();
                            return;
                        }
                        else
                        {
                            MessageBox.Show("لقد استنفذت جميع المحاولات", "خطأ ادخال", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            picUser.Visible = false;
                            timerCount = 30;
                            lblTimerCount.Text = timerCount.ToString();
                            lblTimerCount.Visible = true;
                            this.Enabled = false;
                            timer1.Enabled = true;
                            return;
                        }
                    }
                }

            }

            MessageBox.Show("اسم المستخدم غير مسجل في المنظومة", "خطأ ادخال", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            cmbUserName.SelectAll();
            cmbUserName.Focus();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timerCount--;
            lblTimerCount.Text = timerCount.ToString();
            if (timerCount == 0)
            {
                lblTimerCount.Visible = false;
                this.Enabled = true;
                timer1.Enabled = false;
                picUser.Visible = true;
                Settings.Default.ErrorLoginCount = 0;
                Settings.Default.Save();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Environment.Exit(0);
            Close();
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}