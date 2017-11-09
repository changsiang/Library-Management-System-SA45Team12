//Written by Lim Chang Siang Team12a DipSA45

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Transactions;
namespace DipSA45Team12a
{
    public partial class Loan : Form
    {
        List<BookInfo> booksToLoan = new List<BookInfo>();
        DipSA45Team12aLibEntities context = new DipSA45Team12aLibEntities();
        FormMain MainForm = new FormMain();
        string memberID;
        double bookID;
        string statusMessage;
        string memberCatagory;
        int borrowerLimit;
        int currentLoan;
        int availableLimit;
        
        //properties
        public string SetMemberID
        {
            set
            {
                textBoxMembID.Text = value;
            }
        }

        public Loan()
        {
            InitializeComponent();
            dateTimeLoanDatePicker.Value = DateTime.Now;
            dateTimeDueDatePicker.Value = DateTime.Now.AddDays(14);
            this.WindowState = FormWindowState.Maximized;
        }

        private void buttonRetriMemb_Click(object sender, EventArgs e)
        {
            List<string> memberList = context.Members.Select(x => x.MemberID).ToList();
            memberID = textBoxMembID.Text.ToUpper();

            if (textBoxMembID.Text.Length != 9)
            {
                MainForm.SetToolStripLabelText = "Minimum length of ID is 9 Character in A0000000X format. Please re-enter!";
                memberInfoClear();
            }
            else
            {


                foreach (string queryID in memberList)
                {
                    if (memberID == queryID)
                    {
                        memberCatagory = context.Members.Where(x => x.MemberID == memberID).Select(x => x.MemberCategory).First().ToString();
                        borrowerLimit = int.Parse(context.Memberships.Where(x => x.MemberCategory == memberCatagory).Select(x => x.LoanQuota).First().ToString());
                        try
                        {
                            currentLoan = int.Parse(context.LoanTrans.Where(x => x.MemberID == memberID).Sum(x => x.NumberOfBooks).ToString());
                        }
                        catch (FormatException)
                        {
                            currentLoan = 0;
                        }
                        availableLimit = borrowerLimit - currentLoan;

                        textBoxMembID.Text = memberID;
                        textBoxMembName.Text = context.Members.Where(x => x.MemberID == memberID).Select(x => x.Name).First().ToString();
                        textBoxMembCat.Text = context.Members.Where(x => x.MemberID == memberID).Select(x => x.MemberCategory).First().ToString();
                        textBoxCurrLoan.Text = context.LoanTrans.Where(x => x.MemberID == memberID).Sum(x => x.NumberOfBooks).ToString();
                        textBoxAvailLim.Text = availableLimit.ToString();

                        break;

                    }
                    else
                    {
                        statusMessage = "Member not found!";
                        memberInfoClear();

                    }


                }
            }
        }

        private void buttonGetBook_Click(object sender, EventArgs e)
        {
            try
            {
                bookID = Convert.ToDouble(textBoxBookID.Text);
            }
            catch (Exception ex)
            {
                if (ex is InvalidBookException || ex is FormatException)
                    statusMessage = ex.Message.ToString();
                clearBookInfo();
            }
            List<double> BookIDList = context.BookInfoes.Select(x => x.BookID).ToList();

            foreach (double queryID in BookIDList)
            {
                if (bookID == queryID)
                {
                    textBoxBkStatus.Text = context.BookInfoes.Where(x => x.BookID == bookID).Select(x => x.Status).First().ToString();
                    textBoxBkTitle.Text = context.BookInfoes.Where(x => x.BookID == bookID).Select(x => x.BookTitle).First().ToString();
                    textBoxISBN.Text = context.BookInfoes.Where(x => x.BookID == bookID).Select(x => x.ISBN).First().ToString();
                }
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            BookInfo books;

            try
            {
                bookID = Convert.ToDouble(textBoxBookID.Text);
                books = context.BookInfoes.Where(x => x.BookID == bookID).First();
            }
            catch (Exception ex)
            {
                if (ex is InvalidOperationException || ex is FormatException)
                ((FormMain)this.MdiParent).SetToolStripLabelText = "Invalid Book ID. Please enter a valid Book ID!";
                return;
            }
            if (IsBookAlreadyAdded(bookID) == true)
            {
                ((FormMain)this.MdiParent).SetToolStripLabelText = "Book already added!";
                return;
            }
            if (IsBookAlreadyOut(context.BookInfoes.Where(x => x.BookID == bookID).Select(x => x.Status).First().ToString()) == true)
            {
                ((FormMain)this.MdiParent).SetToolStripLabelText = "Invalid Request. Book is already on loan.";
                return;
            }

            booksToLoan.Add(books);
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            foreach (BookInfo item in booksToLoan)
            {
                dataGridView1.Refresh();
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[1].Value = item.BookID.ToString();
                dataGridView1.Rows[n].Cells[2].Value = item.ISBN.ToString();
                dataGridView1.Rows[n].Cells[3].Value = item.BookTitle.ToString();
                dataGridView1.Rows[n].Cells[4].Value = item.Status.ToString();
            }
        }



        private void buttonLoan_Click(object sender, EventArgs e)
        {
            using (TransactionScope loanTransScope = new TransactionScope())
            {
                int currentTransID = context.LoanTrans.OrderByDescending(x => x.TransID).First().TransID;
                try
                {
                    if (IsOverLoanLimit(availableLimit, booksToLoan.Count()) == true)
                    {
                        ((FormMain)this.MdiParent).SetToolStripLabelText = "Number of Books has exceeded borrowing limit.";
                        return;
                    }

                    if (IsBookAlreadyOut(context.BookInfoes.Where(x => x.BookID == bookID).Select(x => x.Status).First().ToString()) == true)
                    {
                        ((FormMain)this.MdiParent).SetToolStripLabelText = "Invalid Request. Book is already on loan.";
                        return;
                    }
                }
                catch (InvalidOperationException)
                {
                    ((FormMain)this.MdiParent).SetToolStripLabelText = "Invalid Operation!";
                }
                try
                {
                    Member memberinfo = context.Members.Where(x => x.MemberID == memberID).First();
                }
                catch (InvalidOperationException)
                {
                    ((FormMain)this.MdiParent).SetToolStripLabelText = "Invalid operation. Please make sure enter a valid Member ID and Book ID!";
                    return;
                }

                int createTransID = ++currentTransID;


                //need to have some function to bind bookinfo to the database
                foreach (BookInfo i in booksToLoan)
                {
                    BookInfo bookPersistence = context.BookInfoes.Where(x => x.BookID == i.BookID).First();
                    bookPersistence.Status = "OUT";

                    BookCatalogue bookInvenPersis = context.BookCatalogues.Where(x => x.ISBN == bookPersistence.ISBN).First();
                    bookInvenPersis.StockInLibrary = --bookInvenPersis.StockInLibrary;
                    bookInvenPersis.NumberOnLoan = ++bookInvenPersis.NumberOnLoan;
                }


                //create new loan transaction
                LoanTran newTrans = new LoanTran();

                newTrans.TransID = createTransID;
                newTrans.MemberID = memberID;
                newTrans.NumberOfBooks = booksToLoan.Count();
                context.LoanTrans.Add(newTrans);

                //Create new transDetails information
                foreach (BookInfo i in booksToLoan)
                {
                    int newSn = int.Parse(context.TransDetails.OrderByDescending(x => x.Sn).OrderByDescending(x => x.Sn).First().Sn.ToString());
                    TransDetail transDetails = new TransDetail();
                    transDetails.Sn = ++newSn;
                    transDetails.BookID = i.BookID;
                    try
                    {
                        if (dateTimeLoanDatePicker.Value.Date > DateTime.Today || dateTimeDueDatePicker.Value < dateTimeLoanDatePicker.Value || dateTimeDueDatePicker.Value.Date < DateTime.Today)
                        {
                            throw new LoanException();
                        }
                    }
                    catch (LoanException)
                    {
                        ((FormMain)this.MdiParent).SetToolStripLabelText = "Invalid Loan or Due Date";
                        return;
                    }
                    transDetails.LoanDate = dateTimeLoanDatePicker.Value.Date;
                    transDetails.DueDate = dateTimeDueDatePicker.Value.Date;
                    transDetails.TransID = currentTransID;
                    context.TransDetails.Add(transDetails);
                    context.SaveChanges();
                }


                context.SaveChanges();
                ((FormMain)this.MdiParent).SetToolStripLabelText = "Loan Processed Succesfully!";
                booksToLoan.Clear();
                memberInfoClear();
                clearBookInfo();
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            double selectedBookID;
            try
            {
                selectedBookID = double.Parse(dataGridView1.CurrentRow.Cells[1].Value.ToString());
            }
            catch (NullReferenceException)
            {
                ((FormMain)this.MdiParent).SetToolStripLabelText = "Invalid Operation. Please select a book to remove";
                return;
            }

            List<BookInfo> Removebooks = booksToLoan.Where(x => x.BookID == selectedBookID).ToList();
            booksToLoan = booksToLoan.Except(Removebooks).ToList();

            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            foreach (BookInfo item in booksToLoan)
            {
                dataGridView1.Refresh();
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[1].Value = item.BookID.ToString();
                dataGridView1.Rows[n].Cells[2].Value = item.ISBN.ToString();
                dataGridView1.Rows[n].Cells[3].Value = item.BookTitle.ToString();
                dataGridView1.Rows[n].Cells[4].Value = item.Status.ToString();

            }

        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            MainForm.SetdisableSearchUpdateMemberOption = true;
            this.Close();
        }
        private void buttonMembSearch_Click(object sender, EventArgs e)
        {
            MemberSearchForm memberSearchForm = new MemberSearchForm();
            memberSearchForm.IsFromLoanFrom = true;
            memberSearchForm.ShowDialog();
            if (memberSearchForm.DialogResult == DialogResult.Cancel)
            {
                textBoxMembID.Text = memberSearchForm.GetMemberID;
            }
        }


        //This is to make sure only one book is select at each time
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //clean all rows
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Cells[0].Value = false;
            }

            //check select row
            dataGridView1.CurrentRow.Cells[0].Value = true;
        }

        private void memberInfoClear()
        {
            textBoxMembID.Clear();
            textBoxMembID.Text = string.Empty;
            textBoxMembName.Clear();
            textBoxMembName.Text = string.Empty;
            textBoxMembCat.Clear();
            textBoxMembCat.Text = string.Empty;
            textBoxCurrLoan.Clear();
            textBoxCurrLoan.Text = string.Empty;
            textBoxAvailLim.Clear();
            textBoxAvailLim.Text = string.Empty;
        }

        private void clearBookInfo()
        {
            textBoxBookID.Clear();
            textBoxBookID.Text = string.Empty;
            textBoxBkStatus.Clear();
            textBoxBkStatus.Text = string.Empty;
            textBoxBkTitle.Clear();
            textBoxBkTitle.Text = string.Empty;
            textBoxISBN.Clear();
            textBoxBkTitle.Text = string.Empty;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

        }

        private bool IsOverLoanLimit(int limit, int numberOfBooks)
        {
            if (numberOfBooks > limit)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool IsBookAlreadyAdded(double bookID)
        {
            foreach (double i in booksToLoan.Select(x => x.BookID))
            {
                if (i == bookID)
                {
                    return true;
                }

            }
            return false;

        }
        public bool IsBookAlreadyOut(string bookStatus)
        {
            if (bookStatus == "OUT" || bookStatus == "DEL")
                return true;
            else
                return false;
        }

        public class InvalidBookException : ApplicationException
        {
            public InvalidBookException() { }
            public InvalidBookException(string message) : base("Book Not Found. Invalid Book ID") { }
        }

        public class LoanException : ApplicationException
        {
            public LoanException() { }
            public LoanException(string message) : base("Invalid Request. Please make sure all details has entered") { }
        }

        public class AddException : ApplicationException
        {
            public AddException() { }
            public AddException(string message) : base("Invalid Request. Please make sure you have entered a valid Book ID") { }
        }

        public class RemoveException : ApplicationException
        {
            public RemoveException() { }
            public RemoveException(string messsage) : base("Invalid Request. Please make sure you have selected a valid item to remove.") { }
        }



    }
}




