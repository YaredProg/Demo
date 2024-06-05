using BookProject.Classes;
using BookProject.Properties;
using BookProject.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookProject.Forms
{
    public partial class FrmInfoBook : Form
    {
        public FrmInfoBook()
        {
            InitializeComponent();
        }

        private void FrmInfoBook_Load(object sender, EventArgs e)
        {
           

            lblRegNum.Text = VariablesClass.RegNum;
            lblTitle.Text = VariablesClass.Title;
            lblPrice.Text = VariablesClass.Price;
            lblDescription.Text = VariablesClass.Description;
            lblAuthorName.Text = VariablesClass.AuthorName;
            lblYearOfPublication.Text = VariablesClass.YearOfPublication.ToString(Settings.Default.DateFormat);
            picBook.Image = VariablesClass.PicBook;
           lblCatecory.Text = VariablesClass.Category;
        }

        private void picClose_MouseEnter(object sender, EventArgs e)
        {
            picClose.BackColor = Color.Transparent;
        }

        private void picClose_MouseLeave(object sender, EventArgs e)
        {

            picClose.BackColor = Color.Red;
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (VariablesClass.BookId == 0)
            {
                MessageBox.Show("الرجاء تحديد الكتاب لطباعة بياناته", "طباعة بيانات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataTable dtPrint = new DataTable();
            try
            {
                ConClass.SqlQuery = "select * from TblBooks where  Id=" + VariablesClass.BookId;
                ConClass.da = new SqlDataAdapter(ConClass.SqlQuery, ConClass.con);
                ConClass.da.Fill(dtPrint);
            }
            catch (Exception ex)
            {
                MessageBox.Show("فشل في الإتصال بقاعدة البيانات" + Environment.NewLine + ex.Message, "خطأ إتصال", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var f = new FrmPrint();
            var c = new CrtSelectedBook();

            c.SetDataSource(dtPrint);
            f.crystalReportViewer1.ReportSource = c;

            c.SetParameterValue(0, Settings.Default.libraryName);
            c.SetParameterValue(1, VariablesClass.userName); ;
            c.SetParameterValue(2, btnPrint.Text);
            c.SetParameterValue(3, Settings.Default.NuberOne);
            c.SetParameterValue(4, Settings.Default.NuberTwo);
            c.SetParameterValue(5, Settings.Default.LibraryWebsite);

            f.Text = "طباعة الكتاب المحدد";
            f.crystalReportViewer1.Refresh();
            f.crystalReportViewer1.Zoom(100);
            f.WindowState = FormWindowState.Maximized;
            f.Show();
        }
    }
}
