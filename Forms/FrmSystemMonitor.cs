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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookProject.Forms
{
    public partial class FrmSystemMonitor : Form
    {
        public FrmSystemMonitor()
        {
            InitializeComponent();
        }

        //<==============Variables=================>
        DataTable dtMonitor = new DataTable();


        //<===================Function===================>

        void fillDgv()
        {
            try
            {
                dtMonitor.Clear();
                ConClass.SqlQuery = "SELECT Id ,ROW_NUMBER() OVER (ORDER BY (SELECT 1)) N , EventType,EventDate,userId,userName,BookRegNum,BookName,AuthorName FROM TblEvents";
                ConClass.da = new SqlDataAdapter(ConClass.SqlQuery, ConClass.con);
                ConClass.da.Fill(dtMonitor);
                dgvMonitor.DataSource = dtMonitor;
            }

            catch (Exception ex)
            {
                MessageBox.Show("فشل في الإتصال بقاعدة البيانات" + Environment.NewLine + ex.Message, "خطأ إتصال", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void SetHeader()
        {
            // -----------------------------------------------
            dgvMonitor.ColumnHeadersHeight = 50;
            dgvMonitor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvMonitor.ColumnHeadersDefaultCellStyle.Font = new Font("Hacen Saudi Arabia", 10, FontStyle.Regular);
            // ----------------------------------------------
            dgvMonitor.Columns[0].Visible = false;
            dgvMonitor.Columns[1].HeaderText = "ت";
            dgvMonitor.Columns[1].Width = 40;
            dgvMonitor.Columns[2].HeaderText = "نوع العملية ";
            dgvMonitor.Columns[2].Width = 100;
            dgvMonitor.Columns[3].HeaderText = "تاريخ العملية";
            dgvMonitor.Columns[3].DefaultCellStyle.Format = Settings.Default.DateFormat + " hh:mm:ss tt";
            dgvMonitor.Columns[3].Width = 200;
            dgvMonitor.Columns[4].HeaderText = "رقم تسجيل المستخدم";
            dgvMonitor.Columns[5].HeaderText = "اسم المستخدم";
            dgvMonitor.Columns[6].HeaderText = "رقم الكتاب";
            dgvMonitor.Columns[7].HeaderText = "اسم الكناب";
            dgvMonitor.Columns[8].HeaderText = "اسم المؤلف";
        }
        private void FrmSystemMonitor_Load(object sender, EventArgs e)
        {
            fillDgv();
            SetHeader();
            checkBox1_CheckedChanged(sender, e);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            int RowsAffected;
            if (MessageBox.Show("هل تريد بالتأكيد  مسح جميع بيانات مراقبة النظام", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    ConClass.SqlQuery = "DELETE FROM TblEvents";
                    ConClass.cmd = new SqlCommand(ConClass.SqlQuery, ConClass.con);
                    ConClass.con.Open();
                    RowsAffected = ConClass.cmd.ExecuteNonQuery();
                    ConClass.con.Close();
                    MessageBox.Show("تم مسح جميع بيانات مراقبة النظام بنجاح وهي : " + RowsAffected + " حدث", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dtMonitor.Clear();
                }
                catch (Exception ex)
                {
                    ConClass.con.Close();
                    MessageBox.Show("فشل في الإتصال بقاعدة البيانات" + Environment.NewLine + ex.Message, "خطأ إتصال", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnSearchDate_Click(object sender, EventArgs e)
        {
            try
            {
                dtMonitor.Clear();
                if (CheckState == true)
                {
                    ConClass.SqlQuery = "SELECT Id, ROW_NUMBER() OVER(ORDER BY(SELECT 1)) N , EventType,EventDate,userId,userName,BookRegNum,BookName,AuthorName FROM TblEvents WHERE  EventDate >=  '" + dtpDateFrom.Value.Date + "'AND EventDate<= '" + dtpDateTo.Value.Date + "'";
                }
                else if (CheckState == false)
                {

                    ConClass.SqlQuery = "SELECT Id, ROW_NUMBER() OVER(ORDER BY(SELECT 1)) N , EventType,EventDate,userId,userName,BookRegNum,BookName,AuthorName FROM TblEvents WHERE  EventDate >=  '" + dtpDateFrom.Value + "'AND EventDate <= '" + dtpDateTo.Value + "'";
                }

                ConClass.da = new SqlDataAdapter(ConClass.SqlQuery, ConClass.con);
                ConClass.da.Fill(dtMonitor);
                dgvMonitor.DataSource = dtMonitor;
            }
            catch (Exception ex)
            {
                MessageBox.Show("فشل في الإتصال بقاعدة البيانات" + Environment.NewLine + ex.Message, "خطأ إتصال", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void picRefresh_Click(object sender, EventArgs e)
        {
            fillDgv();
        }

            bool CheckState = true;
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                dtpDateTo.CustomFormat = Settings.Default.DateFormat;
                dtpDateFrom.CustomFormat = Settings.Default.DateFormat;

                dtpDateFrom.Width = 155;
                dtpDateTo.Width = 155;

                dtpDateFrom.Left += 110;
                dtpDateTo.Left += 110;

                CheckState = true;
            }
            else if (checkBox1.Checked == true)
            {
                dtpDateFrom.CustomFormat = "hh:mm:ss tt " + Settings.Default.DateFormat;
                dtpDateTo.CustomFormat = "hh:mm:ss tt " + Settings.Default.DateFormat;

                dtpDateFrom.Left -= 110;
                dtpDateTo.Left -= 110;

                dtpDateFrom.Width = 270;
                dtpDateTo.Width = 270;
                CheckState = false;
            }
        }
    }
}
