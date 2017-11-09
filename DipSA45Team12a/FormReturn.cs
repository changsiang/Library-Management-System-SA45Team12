//Written by Lim Chang Siang DipSA45 Team 12a

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
    public partial class ReturnForm : Form
    {
        DipSA45Team12aLibEntities context = new DipSA45Team12aLibEntities();
        BookInfo bookInfo;
        BookCatalogue bookCatalogue;
        LoanTran loanTrans;
        TransDetail transDetail;
        double bookID;
        int transID;
        string bookStatus;
        public ReturnForm()
        {
            InitializeComponent();
            dateTimePickerReturnDate.Value = DateTime.Now.Date;
            this.WindowState = FormWindowState.Maximized;
        }


        private void buttonRetrievebk_Click(object sender, EventArgs e)
        {
            try
            {
                bookID = Double.Parse(textBoxBookID.Text);
                bookInfo = context.BookInfoes.Where(x => x.BookID == bookID).First();
            }
            catch (Exception ex)
            {
                if (ex is InvalidOperationException || ex is FormatException)
                ((FormMain)this.MdiParent).SetToolStripLabelText = "Invalid BookID";
                return;
            }
            DefineBookObjects();
            SetBookStatus();
            if (IsBookAlreadyIN(bookStatus) == true)
            {
                ((FormMain)this.MdiParent).SetToolStripLabelText = "Book is not on loan.";
                ClearTextBoxes();
                return;
            }
            DefineTransactionObject();
            DisplayLoanInformation();


        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {                    
            try
            {
                bookID = Double.Parse(textBoxBookID.Text);
                bookInfo = context.BookInfoes.Where(x => x.BookID == bookID).First();
            }
            catch (Exception ex)
            {
                if (ex is InvalidOperationException || ex is FormatException)
                ((FormMain)this.MdiParent).SetToolStripLabelText = "Invalid BookID";
                return;
            }
            DefineBookObjects();
            SetBookStatus();
            if (IsBookAlreadyIN(bookStatus) == true)
            {
                ((FormMain)this.MdiParent).SetToolStripLabelText = "Book is not on loan. Invalid Return";
                ClearTextBoxes();
                return;
            }
            DefineTransactionObject();
            if (dateTimePickerReturnDate.Value > DateTime.Now.Date)
            {
                ((FormMain)this.MdiParent).SetToolStripLabelText = "Error! Cannot Return on future date.";
                return;
            }
            try
            {
                transDetail.ReturnDate = dateTimePickerReturnDate.Value;
            }
            catch (NullReferenceException)
            {
                ((FormMain)this.MdiParent).SetToolStripLabelText = "No Book ID is entered";
                return;
            }
            DisplayLoanInformation();
            transDetail.DueDate = null;
            transDetail = context.TransDetails.Where(x => x.TransID == transID).OrderByDescending(x => x.Sn).First();
            bookInfo.Remarks = textBoxBkRemark.Text;
            bookInfo.Status = "IN";
            bookCatalogue.NumberOnLoan = --bookCatalogue.NumberOnLoan;
            bookCatalogue.StockInLibrary = ++bookCatalogue.StockInLibrary;
            loanTrans.NumberOfBooks = --loanTrans.NumberOfBooks;

            ClearTextBoxes();
            context.SaveChanges();
            ((FormMain)this.MdiParent).SetToolStripLabelText = "Return transaction processed successfully!";
            ReinitialiseObjects();

        }

        public void DisplayLoanInformation()
        {


            textBoxMembID.Text = context.LoanTrans.Where(x => x.TransID == transID).Select(x => x.MemberID).First().ToString();
            textBoxMembName.Text = context.Members.Where(x => x.MemberID == textBoxMembID.Text).Select(x => x.Name).First().ToString();
            textBoxMembCat.Text = context.Members.Where(x => x.MemberID == textBoxMembID.Text).Select(x => x.MemberCategory).First().ToString();
            textBoxBkTitle.Text = EmptyIfNull(context.BookInfoes.Where(x => x.BookID == bookID).Select(x => x.BookTitle).First().ToString());
            textBoxISBN.Text = context.BookInfoes.Where(x => x.BookID == bookID).Select(x => x.ISBN).First().ToString();
            textBoxDueDate.Text = context.TransDetails.Where(x => x.BookID == bookID).Select(x => x.DueDate).First().ToString();
            textBoxCallNumber.Text = EmptyIfNull(context.BookCatalogues.Where(x => x.BookTitle == textBoxBkTitle.Text).Select(x => x.CallNumber).First().ToString());
            textBoxShelfLocal.Text = EmptyIfNull(context.BookCatalogues.Where(x => x.BookTitle == textBoxBkTitle.Text).Select(x => x.ShelfNumber).First().ToString());
            textBoxBkRemark.Text = EmptyIfNull(context.BookInfoes.Where(x => x.BookID == bookID).Select(x => x.Remarks).First().ToString());
        }

        public bool IsBookAlreadyIN(string bookStatus)
        {
            if (bookStatus == "IN")
                return true;
            else
                return false;
        }

        public void ClearTextBoxes()
        {
            textBoxMembID.Clear();
            textBoxMembID.Text = string.Empty;
            textBoxMembName.Clear();
            textBoxMembName.Text = string.Empty;
            textBoxMembCat.Clear();
            textBoxMembCat.Text = string.Empty;
            textBoxBookID.Clear();
            textBoxBookID.Text = string.Empty;
            textBoxBkTitle.Clear();
            textBoxBkTitle.Text = string.Empty;
            textBoxISBN.Clear();
            textBoxISBN.Text = string.Empty;
            textBoxDueDate.Clear();
            textBoxDueDate.Text = string.Empty;
            textBoxCallNumber.Clear();
            textBoxCallNumber.Text = string.Empty;
            textBoxShelfLocal.Clear();
            textBoxShelfLocal.Text = string.Empty;
            textBoxBkRemark.Clear();
            textBoxBkRemark.Text = string.Empty;
        }

        public void ReinitialiseObjects()
        {
            bookInfo = null;
            bookCatalogue = null;
            loanTrans = null;
            transDetail = null;
            bookID = 0;
            transID = 0;
            bookStatus = "";
        }

        public void DefineBookObjects()
        {
            bookInfo = context.BookInfoes.Where(x => x.BookID == bookID).First();
            bookCatalogue = context.BookCatalogues.Where(x => x.ISBN == bookInfo.ISBN).First();

        }

        public void DefineTransactionObject()
        {
            transDetail = context.TransDetails.Where(x => x.BookID == bookID).OrderByDescending(x => x.Sn).First();
            loanTrans = context.LoanTrans.Where(x => x.TransID == transDetail.TransID).First();
            transID = loanTrans.TransID;
        }

        public void SetBookStatus()
        {
            bookStatus = context.BookInfoes.Where(x => x.BookID == bookID).Select(x => x.Status).First().ToString();
        }
        private string EmptyIfNull(object value)
        {
            if (value == null)
                return "";
            return value.ToString();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    public class ReturnBookException : ApplicationException
    {
        public ReturnBookException() { }
        public ReturnBookException(string message) : base("Invalid Request. Make sure you have entered a valid Book ID to return.") { }
    }

}


