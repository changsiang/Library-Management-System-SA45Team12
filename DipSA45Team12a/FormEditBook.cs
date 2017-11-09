//Written by Sicat Jane Escalada and Lim Chang Siang Team 12a

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
    public partial class FormEditBook : Form
    {
        DipSA45Team12aLibEntities context = new DipSA45Team12aLibEntities();
        double inputISBN;
        public string SetISBN { get; set; }
        public FormEditBook()
        {
            InitializeComponent();

        }

        private void FormEditBook_Load(object sender, EventArgs e)
        {
            txtISBN.Text = SetISBN;
            txtNewStock.Text = "0";
            inputISBN = Convert.ToDouble(txtISBN.Text);
            txtTitle.Text = context.BookCatalogues.Where(x => x.ISBN == inputISBN).Select(x => x.BookTitle).First().ToString();
            txtauthor.Text = context.BookCatalogues.Where(x => x.ISBN == inputISBN).Select(x => x.Author).First().ToString();
            dateTimePickerPub.Value = context.BookCatalogues.Where(x => x.ISBN == inputISBN).Select(x => x.YearOfPublication).First();
            txtPub.Text = context.BookCatalogues.Where(x => x.ISBN == inputISBN).Select(x => x.Publisher).First().ToString();
            txtDesc.Text = context.BookCatalogues.Where(x => x.ISBN == inputISBN).Select(x => x.Description).First().ToString();
            cbotType.Text = context.BookCatalogues.Where(x => x.ISBN == inputISBN).Select(x => x.Type).First().ToString();
            cboSub.Text = context.BookCatalogues.Where(x => x.ISBN == inputISBN).Select(x => x.Subject).First().ToString();
            txtCall.Text = context.BookCatalogues.Where(x => x.ISBN == inputISBN).Select(x => x.CallNumber).First().ToString();
            txtShelf.Text = context.BookCatalogues.Where(x => x.ISBN == inputISBN).Select(x => x.ShelfNumber).First().ToString();
            txtTotalStock.Text = context.BookCatalogues.Where(x => x.ISBN == inputISBN).Sum(x => x.NumberOnLoan + x.StockInLibrary).ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (TransactionScope updateBookTransScope = new TransactionScope())
            {
                int booksNewStock;
                try
                {
                    booksNewStock = Math.Abs(Convert.ToInt16(txtNewStock.Text));
                }
                catch (FormatException)
                {
                    MessageBox.Show("Error! Please enter a valid number in the New Stock field.");
                    return;
                }
                if (booksNewStock > 100)
                {
                    MessageBox.Show("Too many books added. Maximum allowable is 100 books per transaction.");
                    return;
                }
                BookCatalogue bkCatalogue = context.BookCatalogues.Where(x => x.ISBN == inputISBN).First();
                bkCatalogue.BookTitle = txtTitle.Text;
                bkCatalogue.Author = txtauthor.Text;
                bkCatalogue.YearOfPublication = dateTimePickerPub.Value;
                bkCatalogue.Publisher = txtPub.Text;
                bkCatalogue.Description = txtDesc.Text;
                bkCatalogue.Type = cbotType.Text;
                bkCatalogue.Subject = cboSub.Text;
                bkCatalogue.CallNumber = txtCall.Text;
                bkCatalogue.ShelfNumber = txtShelf.Text;
                try
                {
                    bkCatalogue.StockInLibrary = Convert.ToInt16(txtTotalStock.Text) + booksNewStock;
                }
                catch (Exception ex)
                {
                    if (ex is FormatException)
                    {
                        MessageBox.Show("Invalid Character entered. Please enter a number for number of New Stock arrived");
                        return;
                    }
                    else if (ex is OverflowException)
                    {
                        MessageBox.Show("Invalid number entry entered. Maximum allowedable number is 37000 books");
                        return;
                    }
                }

                if (booksNewStock > 0)

                {
                    for (int i = 0; i < booksNewStock - 1; i++)
                    {
                        double bookIDnew = double.Parse(context.BookInfoes.OrderByDescending(x => x.BookID).First().BookID.ToString());
                        BookInfo bookInfo = new BookInfo();
                        bookInfo.BookID = ++bookIDnew;
                        bookInfo.BookTitle = txtTitle.Text;
                        bookInfo.ISBN = Convert.ToDouble(txtISBN.Text);
                        bookInfo.BookTitle = txtTitle.Text;
                        bookInfo.Remarks = "";
                        bookInfo.Status = "IN";
                        context.BookInfoes.Add(bookInfo);
                        context.SaveChanges();

                    }
                }
                context.SaveChanges();
                MessageBox.Show("Book updated successfully!");
                this.Close();

            }
        }
        public class MaximumBooksException : Exception
        {
            public MaximumBooksException() { }

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
