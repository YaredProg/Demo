using BookProject.Classes;
using BookProject.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookProject.Forms
{
    public partial class FrmInsertBook : Form
    {
        public FrmInsertBook()
        {
            InitializeComponent();
        }
        //===========Variables======
        bool Down;
        Point Po;

        //=======funcsion=============
        void clearText()
        {
            picBook.Image = null;

            foreach (Control c in grpBookInfo.Controls)
            {
                if (c is TextBox)
                    c.Text = "";
            }

        }
        private void picClose_MouseEnter(object sender, EventArgs e)
        {
            picClose.BackColor = Color.Red;
        }

        private void picClose_MouseLeave(object sender, EventArgs e)
        {
            picClose.BackColor = Color.FromArgb(233, 236, 239);
            //picClose.BackColor = Settings.Default.Color;

        }

        private void panel8_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Down = true;
                Po = e.Location;
            }
        }

        private void panel8_MouseUp(object sender, MouseEventArgs e)
        {
            Down = false;
        }

        private void panel8_MouseMove(object sender, MouseEventArgs e)
        {
            if (Down == true)
            {
                this.Location = new Point(this.Location.X + (e.X - Po.X), this.Location.Y + (e.Y - Po.Y));
            }
        }
        private void FrmInsertBook_Load(object sender, EventArgs e)
        {
            //panel8.BackColor = Settings.Default.Color;

            lblBookPic.Parent = picBook;
            lblBookPic.Left = 50;
            lblBookPic.Top = 150;
            dtpYearOfPublication.CustomFormat = Settings.Default.DateFormat;
            txtRegNum.Select();
            cmbCatecory.SelectedIndex = 0;
        }
        private void picClose_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (txtAuthorName.Text == "" | txtDescription.Text == "" | txtPrice.Text == "" | txtRegNum.Text == "" | txtTitle.Text == "")
            {
                MessageBox.Show("الرجاء ملئ جميع الحقول", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataTable dt = new DataTable();
            try
            {

                ConClass.SqlQuery = "SELECT  " +
                    "TblBooks.*,TblUsers.UserName FROM TblBooks,TblUsers " +
                    "WHERE TblUsers.id = TblBooks.UserId";

                ConClass.da = new SqlDataAdapter(ConClass.SqlQuery, ConClass.con);
                ConClass.da.Fill(dt);

            }
            catch (Exception ex)
            {
                MessageBox.Show("فشل في الاتصال بقواعد البيانات" + Environment.NewLine + Environment.NewLine + ex.Message, "خطأ اتصال", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            for (int i = 0; i <= dt.Rows.Count - 1; i++)
            {
                if (Convert.ToInt64(txtRegNum.Text) == (long)dt.Rows[i][1]

                    & (int)dt.Rows[i][0] != VariablesClass.BookId)
                {
                    MessageBox.Show("لا يمكن الاضافة" + Environment.NewLine + "رقم القيد الذي ادخلته موجود مسبقاً لكتاب:" + Environment.NewLine + dt.Rows[i][2] + " لي المؤلف  " + dt.Rows[i][4], "خطأ إدخال بيانات", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtRegNum.SelectAll();
                    txtRegNum.Focus();
                    return;
                }
            }

            try
            {
                ConClass.cmd = new SqlCommand("BookInsert", ConClass.con);
                ConClass.cmd.CommandType = CommandType.StoredProcedure;


                var param = new SqlParameter[9];

                param[0] = new SqlParameter("@RegNum", Convert.ToInt64(txtRegNum.Text));
                param[1] = new SqlParameter("@Title", txtTitle.Text);
                param[2] = new SqlParameter("@Description", txtDescription.Text);
                param[3] = new SqlParameter("@AuthorName", txtAuthorName.Text);
                //لان عند تحديد النص وعمل نقطة سيتم اسناد النقطة ويسبب هذا في خطء 
                double price;
                double.TryParse(txtPrice.Text.Trim(), out price);
                param[4] = new SqlParameter("@Price", price);
                //====================
                param[5] = new SqlParameter("@YearOfPublication", dtpYearOfPublication.Value);

                param[6] = new SqlParameter("@UserId", VariablesClass.userId);


                if (picBook.Image == null)
                {
                    param[7] = new SqlParameter("@Pic", SqlDbType.VarBinary);
                    param[7].Value = DBNull.Value;
                }
                else
                {
                    // --------------------------------------------------
                    var ms = new MemoryStream();
                    picBook.Image.Save(ms, ImageFormat.Png);
                    byte[] img = ms.ToArray();
                    // ---------------------------------------------------
                    param[7] = new SqlParameter("@Pic", img);
                }

                if (cmbCatecory.SelectedIndex == -1)
                {
                    param[8] = new SqlParameter("@BookCategory", "غيرذالك");

                }
                else
                {
                    param[8] = new SqlParameter("@BookCategory", cmbCatecory.Text);

                }

                ConClass.cmd.Parameters.AddRange(param);
                ConClass.cmd.Parameters.Add("@SaveState", SqlDbType.Int).Direction = ParameterDirection.Output;

                ConClass.cmd.Parameters.Add("@MaxBookId", SqlDbType.Int)
                   .Direction = ParameterDirection.Output;

                ConClass.con.Open();
                ConClass.cmd.ExecuteNonQuery();
                ConClass.con.Close();

                int saveState = Convert.ToInt32(ConClass.cmd.Parameters["@SaveState"].Value.ToString());

                if (saveState == 1)
                {
                    MessageBox.Show(" تم اضافة كتاب " + txtTitle.Text + " بنجاح ", "اضافة بيانات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearText();
                    FrmMain frmMain = Application.OpenForms.OfType<FrmMain>().FirstOrDefault();
                    if (frmMain != null)
                        frmMain.btnRefresh_Click(sender, e);
                }

                else if (saveState == 0)
                {
                    MessageBox.Show(" لم يتم الحفظ، خطأ في تنفيذ العملية", "خطأ في الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                ConClass.con.Close();
                MessageBox.Show("فشل في الإتصال بقاعدة البيانات" + Environment.NewLine + ex.Message, "خطأ إتصال", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void picBook_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                openFileDialog1.FileName = "";
                openFileDialog1.Filter = "(Image Files)|*.jpg;*.png;*.bmp;*.gif;*.ico|Jpg, | *.jpg|Png, | *.png|Bmp, | *.bmp|Gif, | *.gif|Ico | *.ico";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    picBook.Image = Image.FromFile(openFileDialog1.FileName);
                    picBook.ContextMenuStrip = contextMenuStrip1;
                }
            }
        }

        private void cmsDeletePicture_Click(object sender, EventArgs e)
        {
            picBook.Image = null;
            picBook.ContextMenuStrip = null;
        }

        private void lblBookPic_Click(object sender, EventArgs e)
        {
            picBook_MouseUp(sender, (MouseEventArgs)e);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
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

            if ((Keys)e.KeyChar == Keys.Enter)
            {
                txtTitle.Focus();
            }
        }

        private void txtTitle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                txtDescription.Focus();
            }
        }

        private void txtDescription_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                txtAuthorName.Focus();
            }
        }

        private void txtAuthorName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                txtPrice.Focus();
            }
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) == false)
            {
                e.Handled = true;
            }

            if ((Keys)e.KeyChar == Keys.Back | e.KeyChar == 46 &
                     txtPrice.Text.IndexOf(".") == -1 & txtPrice.Text.Length != 0)
            {
                e.Handled = false;
            }
        }
    }
}
