//Written Lim Chang Siang DipSA45 Team12a

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DipSA45Team12a
{
    public partial class FormBooksAvailability : Form
    {
        DipSA45Team12aLibEntities context = new DipSA45Team12aLibEntities();
        public FormBooksAvailability()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonListLoanBooks_Click(object sender, EventArgs e)
        {
            dataGridView1.Refresh();
            var q = from bkinfo in context.BookInfoes
                    join transdetails in context.TransDetails
                    on bkinfo.BookID equals transdetails.BookID
                    where bkinfo.Status == "OUT"
                    select new { transdetails.TransID, bkinfo.BookID, bkinfo.BookTitle, transdetails.DueDate, transdetails.LoanDate};
            dataGridView1.DataSource = q.ToList();

        }

        private void buttonBkIDSearch_Click(object sender, EventArgs e)
        {
            dataGridView1.Refresh();
            double bookID = 0;
            try
            {
                bookID = Convert.ToDouble(textBoxBookID.Text);
            }
            catch (FormatException)
            {
                ((FormMain)this.MdiParent).SetToolStripLabelText = "Invalid Book ID. Please enter a valid Book ID!";
                textBoxBookID.Clear();
                textBoxBookID.Text = string.Empty;
                return;
            }
            var q = from bkinfo in context.BookInfoes
                    join transdetails in context.TransDetails
                    on bkinfo.BookID equals transdetails.BookID
                    where bkinfo.Status == "OUT" && bkinfo.BookID == bookID
                    select new { transdetails.TransID, bkinfo.BookID, bkinfo.BookTitle, transdetails.DueDate, transdetails.LoanDate };
            dataGridView1.DataSource = q.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Refresh();
            string bookTitle = "";
            try
            {
                bookTitle = textBoxBkTitle.Text;
            }
            catch (FormatException)
            {
                ((FormMain)this.MdiParent).SetToolStripLabelText = "Invalid entry in the Book Title box. Please check and try again.";
                textBoxBkTitle.Clear();
                textBoxBkTitle.Text = string.Empty;
                return;
            }
            var q = from bkinfo in context.BookInfoes
                    join transdetails in context.TransDetails
                    on bkinfo.BookID equals transdetails.BookID
                    where bkinfo.Status == "OUT" && bkinfo.BookTitle.Contains(bookTitle)
                    select new { transdetails.TransID, bkinfo.BookID, bkinfo.BookTitle, transdetails.DueDate, transdetails.LoanDate };
            dataGridView1.DataSource = q.ToList();
        }
    }
}
