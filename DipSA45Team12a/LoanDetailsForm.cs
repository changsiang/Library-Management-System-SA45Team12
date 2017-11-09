//Written by  Pradeep Elango

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
    public partial class LoanDetailsForm : Form
    {
        DipSA45Team12aLibEntities context = new DipSA45Team12aLibEntities();
        FormMain MainForm = new FormMain();
        public string mID { get; set; }
        public string mName { get; set; }
        public LoanDetailsForm()
        {
            InitializeComponent();
        }
        public LoanDetailsForm (MemberSearchForm msearchfrm)
        {
            InitializeComponent();
            MemberSearchForm msearchfrm1;
            msearchfrm1 = msearchfrm;
        }
        private void LoanDetailsForm_Load(object sender, EventArgs e)
        {
            MemberIDBox.Text = mID;
            NameBox.Text = mName;
            ViewCurrentLoans();
        }
        private void ViewCurrentLoans()
        {
            DataGridTitleLabel.Text = "Current Loans";
            var q = from MID in context.Members
                    join LT in context.LoanTrans
                    on MID.MemberID equals LT.MemberID
                    join TD in context.TransDetails
                    on LT.TransID equals TD.TransID
                    join BI in context.BookInfoes
                    on TD.BookID equals BI.BookID
                    where TD.ReturnDate == null
                    where MID.MemberID == mID
                    select new { LT.TransID, TD.BookID, BI.BookTitle, TD.LoanDate, TD.DueDate, TD.ReturnDate };
            LoanHistoryDataGridView.DataSource = q.ToList();
        }

        private void CurrentLoansButton_Click(object sender, EventArgs e)
        {
            ViewCurrentLoans();
        }
        private void LoanHistoryButton_Click(object sender, EventArgs e)
        {
            DataGridTitleLabel.Text = "Loan History";
            var q = from MID in context.Members
                    join LT in context.LoanTrans
                    on MID.MemberID equals LT.MemberID
                    join TD in context.TransDetails
                    on LT.TransID equals TD.TransID
                    join BI in context.BookInfoes
                    on TD.BookID equals BI.BookID
                    where TD.ReturnDate != null
                    where MID.MemberID == mID
                    select new { LT.TransID, TD.BookID, BI.BookTitle, TD.LoanDate, TD.DueDate, TD.ReturnDate };
            LoanHistoryDataGridView.DataSource = q.ToList();
        }
        private void LoanHistoryDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void DataGridTitleLable_Click(object sender, EventArgs e)
        {

        }
        private void MemberIDBox_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
