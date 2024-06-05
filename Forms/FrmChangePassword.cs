using BookProject.Classes;
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
    public partial class FrmChangePassword : Form
    {
        public FrmChangePassword()
        {
            InitializeComponent();
        }

        private void FrmChangePassword_Load(object sender, EventArgs e)
        {
            txtUserName.Text = VariablesClass.userName;
            txtOldPass.Select();
            lblError.Visible = false;
        }
        private void txtNewPass_MouseEnter(object sender, EventArgs e)
        {
            if (txtOldPass.Text != VariablesClass.userPassword)
            {
                txtOldPass.Text = "";
                txtOldPass.Focus();
                lblError.Visible = true;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtOldPass.Text == "")
            {
                MessageBox.Show("يرجى ادخال كلمة المرور الحالية", "خطأ إدخال", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtOldPass.Focus();
                return;
            }
            if (txtNewPass.Text == "")
            {
                MessageBox.Show("يرجى ادخال كلمة المرور الجديدة", "خطأ إدخال", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNewPass.Focus();
                return;
            }

            try
            {
                ConClass.SqlQuery = "UPDATE TblUsers SET UserPassword='" + txtNewPass.Text + "' WHERE Id=" + VariablesClass.userId;
                ConClass.cmd = new SqlCommand(ConClass.SqlQuery, ConClass.con);
                ConClass.con.Open();
                ConClass.cmd.ExecuteNonQuery();
                ConClass.con.Close();
                MessageBox.Show("تم تعديل كلمة المرور بنجاح", "تعديل بيانات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                VariablesClass.userPassword = txtNewPass.Text;
                this.Close();
            }
            catch (Exception ex)
            {
                ConClass.con.Close();
                MessageBox.Show("خطأ اتصال" + Environment.NewLine + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txtOldPass.UseSystemPasswordChar = false;
                txtNewPass.UseSystemPasswordChar = false;
            }
            else
            {
                txtOldPass.UseSystemPasswordChar = true;
                txtNewPass.UseSystemPasswordChar = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtOldPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Enter)
            {
                txtNewPass.Focus();
            }
        }

        private void txtOldPass_TextChanged(object sender, EventArgs e)
        {
            lblError.Visible = false;
        }
        bool ChackState = false;
        private void picHidePassword_Click(object sender, EventArgs e)
        {
            if (ChackState == false)
            {
                txtOldPass.UseSystemPasswordChar = false;
                picHidePassword.Image = Properties.Resources.hide_filled_50px;
                ChackState = true;
            }else if (ChackState == true)
            {
                txtOldPass.UseSystemPasswordChar = true;
                picHidePassword.Image = Properties.Resources.visible;
                ChackState = false;
            }
        }

        private void picHidePassword1_Click(object sender, EventArgs e)
        {
            if (ChackState == false)
            {
                txtNewPass.UseSystemPasswordChar = false;
                picHidePassword.Image = Properties.Resources.hide_filled_50px;
                ChackState = true;
            }
            else if (ChackState == true)
            {
                txtNewPass.UseSystemPasswordChar = true;
                picHidePassword.Image = Properties.Resources.visible;
                ChackState = false;
            }
        }
    }
}
