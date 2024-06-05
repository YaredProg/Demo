using BookProject.Classes;
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
    public partial class FrmUserManagement : Form
    {
        public FrmUserManagement()
        {
            InitializeComponent();
        }
        //<==============Variables=================>

        int userID = 0, cr = -1;
        DataTable dtUsers = new DataTable();

      

        //<===================Function===================>
        void fillDgvUsers()
        {

            dtUsers.Clear();
            dgvUsers.Rows.Clear();

            try
            {
                ConClass.SqlQuery = "SELECT * FROM TblUsers,TblPermissions Where TblUsers.Id=TblPermissions.USERID";
                ConClass.da = new SqlDataAdapter(ConClass.SqlQuery, ConClass.con);
                ConClass.da.Fill(dtUsers);

                //dgvUsers.DataSource = dtUsers; // ممنوع الاقتراب خطر الموت

                for (int i = 0; i <= dtUsers.Rows.Count - 1; i++)
                {
                    dgvUsers.Rows.Add();

                    dgvUsers.Rows[i].Cells[0].Value = dtUsers.Rows[i][0];

                    dgvUsers.Rows[i].Cells[1].Value = i + 1;
                    dgvUsers.Rows[i].Cells[2].Value = dtUsers.Rows[i][1];
                    dgvUsers.Rows[i].Cells[3].Value = "************"; // dtUsers.Rows[i][2];
                    dgvUsers.Rows[i].Cells[4].Value = dtUsers.Rows[i][3];
                    dgvUsers.Rows[i].Cells[5].Value = dtUsers.Rows[i][0];

                    dgvUsers.Rows[i].DefaultCellStyle.ForeColor = Color.Black;

                    if ((bool)dtUsers.Rows[i][7] == true & (bool)dtUsers.Rows[i][8] == true & (bool)dtUsers.Rows[i][9] == true & (bool)dtUsers.Rows[i][10] == true & (bool)dtUsers.Rows[i][11] == true & (bool)dtUsers.Rows[i][12])
                    {
                        dgvUsers.Rows[i].DefaultCellStyle.BackColor = Color.LightGray;
                    }

                    if (dtUsers.Rows[i][4] is DBNull == false)
                    {
                        byte[] img = (byte[])dtUsers.Rows[i][4];     // تخزين الصورة في مصفوفة من البايتات
                        var ms = new MemoryStream(img);                // حجز مساحة في الذاكرة لتركيب الصورة من مصفوفة البايتات 'Imports System.IO
                        dgvUsers.Rows[i].Cells[6].Value = Image.FromStream(ms);
                    }
                }
                dgvUsers.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("فشل في الإتصال بقاعدة البيانات" + Environment.NewLine + ex.Message, "خطأ إتصال", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void clearText()
        {
            picUser.Image = null;

            foreach (Control c in grpUserInfo.Controls)
            {
                if (c is TextBox)
                    c.Text = "";
            }

            foreach (CheckBox c in grpPermissions.Controls)
            {
                if (c is CheckBox)
                {
                    c.Checked = false;
                    c.Enabled = true;
                }
            }

            userID = 0;
            cr = -1;
            dgvUsers.ClearSelection();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (userID == 0)
                return;

            if (txtUserName.Text.Trim() == "" | txtUserPassword.Text == "" | txtUserJob.Text.Trim() == "")
            {
                MessageBox.Show("الرجاء ملئ جميع الحقول", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            try
            {

                // الجزء الأول شحن الأوامر---------------------------------
                ConClass.cmd = new SqlCommand("UserUpdate", ConClass.con);
                ConClass.cmd.CommandType = CommandType.StoredProcedure;


                // إضافة الباراميترات------------------------------------
                var param = new SqlParameter[11];
                param[0] = new SqlParameter("@Id", userID);
                param[1] = new SqlParameter("@UserName", txtUserName.Text.Trim());

                if (txtUserPassword.Text == "0000")
                    param[2] = new SqlParameter("@UserPassword", txtUserPassword.Text);
                else
                    param[2] = new SqlParameter("@UserPassword", dtUsers.Rows[cr][2]);

                param[3] = new SqlParameter("@UserJob", txtUserJob.Text.Trim());

                param[4] = new SqlParameter("@UpdateP", chkUpdate.Checked);
                param[5] = new SqlParameter("@InsertP", chkInsert.Checked);
                param[6] = new SqlParameter("@PrintP", chkPrint.Checked);
                param[7] = new SqlParameter("@UsersP", chkUsers.Checked);
                param[8] = new SqlParameter("@SettingsP", chkSettings.Checked);
                param[9] = new SqlParameter("@MonitorP", chkMonitor.Checked);

                if (picUser.Image == null)
                {
                    param[10] = new SqlParameter("@UserPic", SqlDbType.VarBinary);
                    param[10].Value = DBNull.Value;
                }
                else
                {
                    // --------------------------------------------------
                    var ms = new MemoryStream();
                    picUser.Image.Save(ms, ImageFormat.Png);
                    var img = ms.ToArray(); // var => object
                                            //byte[] img = ms.ToArray(); 
                                            // ---------------------------------------------------
                    param[10] = new SqlParameter("@UserPic", img);
                }

                ConClass.cmd.Parameters.AddRange(param);

                ConClass.cmd.Parameters.Add("@SaveState", SqlDbType.Int)
                    .Direction = ParameterDirection.Output;

                // جزء ثابت للتنفيذ----------------------------------
                ConClass.con.Open();
                ConClass.cmd.ExecuteNonQuery();
                ConClass.con.Close();
                // ---------------------------------------------------
                int saveState = Convert.ToInt32(ConClass.cmd.Parameters["@SaveState"].Value.ToString());

                if (saveState == 1)
                {
                    MessageBox.Show(" تم حفظ بيانات المستخدم بنجاح ", "تعديل بيانات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnRefresh_Click(sender, e);
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            clearText();
            fillDgvUsers();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (userID != 0)
                return;

            if (txtUserName.Text.Trim() == "" | txtUserPassword.Text == "" | txtUserJob.Text == "")
            {
                MessageBox.Show("الرجاء ملئ جميع الحقول", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }



            try
            {


                // 'الجزء الأول شحن الأوامر--------------------------------
                ConClass.cmd = new SqlCommand("UserInsert", ConClass.con);
                ConClass.cmd.CommandType = CommandType.StoredProcedure;


                // 'إضافة الباراميترات------------------------------------
                var param = new SqlParameter[10];
                param[0] = new SqlParameter("@userName", txtUserName.Text.Trim());
                param[1] = new SqlParameter("@UserPassword", txtUserPassword.Text);
                param[2] = new SqlParameter("@userJob", txtUserJob.Text.Trim());

                if (picUser.Image == null)
                {
                    param[3] = new SqlParameter("@UserPic", SqlDbType.VarBinary);
                    param[3].Value = DBNull.Value;
                }
                else
                {
                    // --------------------------------------------------
                    var ms = new MemoryStream();
                    picUser.Image.Save(ms, ImageFormat.Png);
                    byte[] img = ms.ToArray();
                    // ---------------------------------------------------
                    param[3] = new SqlParameter("@UserPic", img);
                }

                param[4] = new SqlParameter("@UpdateP", chkUpdate.Checked);
                param[5] = new SqlParameter("@InsertP", chkInsert.Checked);
                param[6] = new SqlParameter("@PrintP", chkPrint.Checked);
                param[7] = new SqlParameter("@UsersP", chkUsers.Checked);
                param[8] = new SqlParameter("@SettingsP", chkSettings.Checked);
                param[9] = new SqlParameter("@MonitorP", chkMonitor.Checked);

                ConClass.cmd.Parameters.AddRange(param);




                ConClass.cmd.Parameters.Add("@MaxUserId", SqlDbType.Int)
                    .Direction = ParameterDirection.Output;

                ConClass.cmd.Parameters.Add("@SaveState", SqlDbType.Int)
                    .Direction = ParameterDirection.Output;


                // الجزء الثابت للتنفيذ----------------------------------
                ConClass.con.Open();
                ConClass.cmd.ExecuteNonQuery();
                ConClass.con.Close();
                // --------------------------------------------------------

                int id = Convert.ToInt32(ConClass.cmd.Parameters["@MaxUserId"].Value.ToString());
                int saveState = Convert.ToInt32(ConClass.cmd.Parameters["@SaveState"].Value.ToString());

                if (saveState == 1)
                {
                    MessageBox.Show(" تم اضافة المستخدم " + txtUserName.Text + " بنجاح " + Environment.NewLine + "وتسجيله بالرقم " + id, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnRefresh_Click(sender, e);
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (userID == 0)
                return;

            if (userID == 1) // زايد
                return;



            if (userID == VariablesClass.userId)
            {
                MessageBox.Show("يا غالي كيف بتحذف روحك !!!! فكر فيها كان تجي والله ما نردك");
                return;
            }

            if (MessageBox.Show(" هل تريد بالتأكيد حذف " + txtUserName.Text, "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    //ConClass.sqlQuery = "DELETE FROM TblUsers WHERE Id=" + userID;

                    //ConClass.cmd = new SqlCommand(ConClass.sqlQuery, ConClass.con);

                    //ConClass.con.Open();
                    //ConClass.cmd.ExecuteNonQuery();
                    //ConClass.con.Close();




                    // الجزء الأول شحن الأوامر----------------------------
                    ConClass.cmd = new SqlCommand("UserDelete", ConClass.con);
                    ConClass.cmd.CommandType = CommandType.StoredProcedure;


                    // إضافة باراميتر------------------------------------
                    var param = new SqlParameter();
                    param = new SqlParameter("@Id", userID);
                    ConClass.cmd.Parameters.Add(param);


                    // جزء ثابت للتنفيذ----------------------------------
                    ConClass.con.Open();
                    ConClass.cmd.ExecuteNonQuery();
                    ConClass.con.Close();
                    // ----------------------------------------------------


                    btnRefresh.PerformClick(); //btnRefresh_Click(sender, e);
                    MessageBox.Show(" تم حذف المستخدم بنجاح ", "حذف بيانات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                catch (Exception ex)
                {
                    ConClass.con.Close();
                    MessageBox.Show("فشل في الإتصال بقاعدة البيانات" + Environment.NewLine + ex.Message, "خطأ إتصال", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvUsers_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvUsers.CurrentRow == null) return;
                if (dgvUsers.CurrentRow.Index == dgvUsers.Rows.Count
                    | dgvUsers.Rows[dgvUsers.CurrentRow.Index].Cells[0].Value == null
                    | dgvUsers.Rows[dgvUsers.CurrentRow.Index].Selected == false)
                    return;
            }
            catch
            {
                return;
            }

            if ((int)dgvUsers.Rows[dgvUsers.CurrentRow.Index].Cells[0].Value == 1 & VariablesClass.userId != 1)
            {
                clearText();
                return;
            }

            cr = dgvUsers.CurrentRow.Index;


            userID = (int)dgvUsers.Rows[cr].Cells[0].Value; //int userID ; 
            txtUserName.Text = dgvUsers.Rows[cr].Cells[2].Value.ToString();
            txtUserPassword.Text = dgvUsers.Rows[cr].Cells[3].Value.ToString();
            txtUserJob.Text = dgvUsers.Rows[cr].Cells[4].Value.ToString();
            picUser.Image = (Image)dgvUsers.Rows[cr].Cells[6].Value;

            if (picUser.Image != null)
                picUser.ContextMenuStrip = contextMenuStrip1;
            else
                picUser.ContextMenuStrip = null;



            //if (chkAdmin.Checked == true)
            //    chkAdmin.Checked = false;
            //else
            //    chkAdmin_CheckedChanged(sender, e);

            chkAdmin.Checked = false;
            chkAdmin_CheckedChanged(sender, e);




            chkUpdate.Checked = (bool)dtUsers.Rows[cr][7];
            chkInsert.Checked = (bool)dtUsers.Rows[cr][8];
            chkPrint.Checked = (bool)dtUsers.Rows[cr][9];
            chkUsers.Checked = (bool)dtUsers.Rows[cr][10];
            chkSettings.Checked = (bool)dtUsers.Rows[cr][11];
            chkSettings.Checked = (bool)dtUsers.Rows[cr][11];
            chkMonitor.Checked = (bool)dtUsers.Rows[cr][12];
        }

        private void chkAdmin_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAdmin.Checked == true)
            {
                foreach (CheckBox c in grpPermissions.Controls)
                {
                    if (c.Name != "chkAdmin")
                    {

                        c.Checked = true;
                        c.Enabled = false;
                    }
                }
            }
            else if (chkAdmin.Checked == false)
            {
                foreach (CheckBox c in grpPermissions.Controls)
                {
                    c.Checked = false;
                    c.Enabled = true;
                }
            }
        }

        private void dgvUsers_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvUsers.SortOrder.ToString() == "Ascending")
                dtUsers.DefaultView.Sort = dgvUsers.SortedColumn.Name + " ASC";
            else if (dgvUsers.SortOrder.ToString() == "Descending")
                dtUsers.DefaultView.Sort = dgvUsers.SortedColumn.Name + " DESC";

            dtUsers = dtUsers.DefaultView.ToTable();
        }

        private void dgvUsers_Sorted(object sender, EventArgs e)
        {
            clearText();
        }

        private void btnResetPass_Click(object sender, EventArgs e)
        {
            txtUserPassword.Text = "0000";
        }

        private void lblUserPic_Click(object sender, EventArgs e)
        {
            picUser_MouseUp(sender, (MouseEventArgs)e);
        }

        private void picUser_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                openFileDialog1.FileName = "";
                openFileDialog1.Filter = "(Image Files)|*.jpg;*.png;*.bmp;*.gif;*.ico|Jpg, | *.jpg|Png, | *.png|Bmp, | *.bmp|Gif, | *.gif|Ico | *.ico";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    picUser.Image = Image.FromFile(openFileDialog1.FileName);
                    picUser.ContextMenuStrip = contextMenuStrip1;
                }
            }
        }

        private void cmsDeletePicture_Click(object sender, EventArgs e)
        {

        picUser.Image = null;
            picUser.ContextMenuStrip = null;
        }

        private void chkUpdate_CheckedChanged(object sender, EventArgs e)
        {
            if (chkUpdate.Checked == true & chkInsert.Checked == true & chkPrint.Checked == true & chkUsers.Checked == true & chkSettings.Checked == true & chkMonitor.Checked == true)
                chkAdmin.Checked = true;
        }

        private void FrmUserManagement_Load(object sender, EventArgs e)
        {
            lblUserPic.Parent = picUser;
            lblUserPic.Top = 100;
            lblUserPic.Left = 15;
            fillDgvUsers();
        }
    }
}
