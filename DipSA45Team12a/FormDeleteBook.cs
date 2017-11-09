//Written by Lim Chang Siang and Pradeep Elango

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
    public partial class FormDeleteBook : Form
    {
        DipSA45Team12aLibEntities context = new DipSA45Team12aLibEntities();
        double bookID;
        BookInfo bookInfo;
        string bookStatus;
        BookCatalogue bookCatalogue;
        public FormDeleteBook()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void FormDeleteBook_Load(object sender, EventArgs e)
        {

        }

        //retrieve info of book
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
                {
                    ((FormMain)this.MdiParent).SetToolStripLabelText = "Invalid BookID";
                    ClearTextBoxes();
                    return;
                }

            }
            DefineBookObjects();
            SetBookStatus();
            if (IsBookAlreadyOUT(bookStatus) == true)
            {
                ((FormMain)this.MdiParent).SetToolStripLabelText = "Book is currently on loan.";
                ClearTextBoxes();
                return;
            }
            DisplayBookInformation();

        }

        //pull info of books from database 
        public void DefineBookObjects()
        {
            bookInfo = context.BookInfoes.Where(x => x.BookID == bookID).First();
            bookCatalogue = context.BookCatalogues.Where(x => x.ISBN == bookInfo.ISBN).First();

        }

        //delete book (set bookstatus to "DEL")
        private void buttonDelete_Click(object sender, EventArgs e)
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
            if (IsBookAlreadyOUT(bookStatus) == true)
            {
                ((FormMain)this.MdiParent).SetToolStripLabelText = "Book is currently on loan. Unable to delete";
                ClearTextBoxes();
                return;
            }

            bookInfo.Remarks = textBoxBkRemark.Text;
            bookInfo.Status = "DEL";
            bookCatalogue.StockInLibrary = --bookCatalogue.StockInLibrary;

            ClearTextBoxes();
            context.SaveChanges();
            ((FormMain)this.MdiParent).SetToolStripLabelText = "Delete transaction processed successfully!";
            ReinitialiseObjects();
        }

        public void SetBookStatus()
        {
            bookStatus = context.BookInfoes.Where(x => x.BookID == bookID).Select(x => x.Status).First().ToString();
        }

        //check if book is currently on loan
        public bool IsBookAlreadyOUT(string bookStatus)
        {
            if (bookStatus == "OUT")
                return true;
            else
                return false;
        }
        public void DisplayBookInformation()
        {
            textBoxBkTitle.Text = EmptyIfNull(context.BookInfoes.Where(x => x.BookID == bookID).Select(x => x.BookTitle).First().ToString());
            textBoxISBN.Text = context.BookInfoes.Where(x => x.BookID == bookID).Select(x => x.ISBN).First().ToString();
            textBoxCallNumber.Text = EmptyIfNull(context.BookCatalogues.Where(x => x.BookTitle == textBoxBkTitle.Text).Select(x => x.CallNumber).First().ToString());
            textBoxShelfLocal.Text = EmptyIfNull(context.BookCatalogues.Where(x => x.BookTitle == textBoxBkTitle.Text).Select(x => x.ShelfNumber).First().ToString());
            textBoxBkRemark.Text = EmptyIfNull(context.BookInfoes.Where(x => x.BookID == bookID).Select(x => x.Remarks).First().ToString());
        }
        public void ClearTextBoxes()
        {
            textBoxBookID.Clear();
            textBoxBookID.Text = string.Empty;
            textBoxBkTitle.Clear();
            textBoxBkTitle.Text = string.Empty;
            textBoxISBN.Clear();
            textBoxISBN.Text = string.Empty;
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
            bookID = 0;
            bookStatus = "";
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string EmptyIfNull(object value)
        {
            if (value == null)
                return "";
            return value.ToString();
        }
    }
}
