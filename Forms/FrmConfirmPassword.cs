using BookProject.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookProject.Forms
{
    public partial class FrmConfirmPassword : Form
    {
        public FrmConfirmPassword()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == VariablesClass.userPassword)
            {
                this.Hide();
                FrmSettings frmSettingsControl = new FrmSettings();
                frmSettingsControl.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("كلمة المرور الحالية غير صحيحة " + Environment.NewLine + " أنت لست " + VariablesClass.userName, "خطأ إدخال", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Text = "";
                txtPassword.Focus();
                return;
            }
        }

        private void FrmConfirmPassword_Load(object sender, EventArgs e)
        {
            txtPassword.Select();
            picUser.Image = VariablesClass.PicUser;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
            pictureBox1.Image = Properties.Resources.visible;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            pictureBox1.Image = Properties.Resources.hide_filled_50px;

        }
    }
}
