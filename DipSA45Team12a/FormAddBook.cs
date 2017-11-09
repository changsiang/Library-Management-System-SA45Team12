//Written by Sicat Jane Escalada and Pradeep Elango Team 12a

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Transactions;

namespace DipSA45Team12a
{
    public partial class FormAddBook : Form
    {

        DipSA45Team12aLibEntities context = new DipSA45Team12aLibEntities();
        List<double> ISBNlist;

        public FormAddBook()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }
        //label methods for texboxes
        private void ValidLabel(Label lbl)
        {
            lbl.ForeColor = Color.Green;
            lbl.Text = "Valid";
            lbl.Show();
        }

        private void InvalidLabel(Label lblv)
        {
            lblv.ForeColor = Color.Red;
            lblv.Text = "Invalid";
            lblv.Show();
        }
        //regular expression method
        public bool Regexp(string re, TextBox tb, Label lbl)
        {
            Regex regex = new Regex(re);

            if (regex.IsMatch(tb.Text))
            {
                ValidLabel(lbl);
                return true;
            }
            else
            {
                InvalidLabel(lbl);
                return false;
            }
        }
        //length restraint for ISBN entry
        const int MaxLength = 13;
        //create new entry in BookCatalogue and BookInfo tables
        private void btnSave_Click(object sender, EventArgs e)
        {
            using (TransactionScope addBookTransScope = new TransactionScope())
            {
                ((FormMain)this.MdiParent).SetToolStripLabelText = "...";
                try
                {
                    int totalStock = Convert.ToInt16(txtTotalStock.Text);
                }
                catch (FormatException)
                {
                    ((FormMain)this.MdiParent).SetToolStripLabelText = "Invalid book number entered in the stock field.";
                    return;
                }

                if (Math.Abs(Convert.ToInt16(txtTotalStock.Text)) > 100)
                {
                    ((FormMain)this.MdiParent).SetToolStripLabelText = "Too many books added. Maximum allowable is 100 books per transaction.";
                    return;
                }
                if (dateTimePickerPub.Value > DateTime.Today)
                {
                    ((FormMain)this.MdiParent).SetToolStripLabelText = "Year published cannot be in the future";
                    return;
                }
                BookCatalogue bookCatalogue = new BookCatalogue();

                try
                {
                    bookCatalogue.ISBN = Convert.ToDouble(txtISBN.Text);
                }
                catch (FormatException)
                {
                    ((FormMain)this.MdiParent).SetToolStripLabelText = "Invalid ISBN String Format.";
                    return;
                }

                double ISBNinput;

                {
                    if (Convert.ToDouble(txtISBN.Text) > 1000000000000)
                    {
                        ISBNinput = Convert.ToDouble(txtISBN.Text);
                        if (doesISBNexist(ISBNinput) == true)
                        {
                            ((FormMain)this.MdiParent).SetToolStripLabelText = "ISBN already exists. Please use 'Update Book' function to update book information.";
                            return;
                        }
                        else
                        {
                            bookCatalogue.ISBN = ISBNinput;
                        }

                    }
                    else
                    {
                        InvalidLabel(lblISBN);
                        return;
                    }
                }

                bookCatalogue.BookTitle = txtTitle.Text;
                bookCatalogue.Author = txtauthor.Text;
                bookCatalogue.YearOfPublication = dateTimePickerPub.Value;
                bookCatalogue.Publisher = txtPub.Text;
                bookCatalogue.CallNumber = txtCall.Text;
                bookCatalogue.ShelfNumber = txtShelf.Text;
                bookCatalogue.Description = txtdesc.Text;
                bookCatalogue.StockInLibrary = Math.Abs(Convert.ToInt16(txtTotalStock.Text));
                bookCatalogue.Subject = cbosub.Text;
                bookCatalogue.Type = cbotype.Text;
                bookCatalogue.NumberOnLoan = 0;


                if (string.IsNullOrEmpty(txtISBN.Text) ||
                   (string.IsNullOrEmpty(txtTitle.Text) ||
                   (string.IsNullOrEmpty(txtauthor.Text) ||
                   (string.IsNullOrEmpty(txtTotalStock.Text)))))

                {
                    ((FormMain)this.MdiParent).SetToolStripLabelText = "Please enter ISBN, Title and Author";
                    return;
                }

                context.BookCatalogues.Add(bookCatalogue);
                context.SaveChanges();


                for (int i = 0; i <= Convert.ToInt16(txtTotalStock.Text); i++)
                {
                    double bookIDnew = context.BookInfoes.OrderByDescending(x => x.BookID).First().BookID;

                    BookInfo bookInfo = new BookInfo();
                    bookInfo.BookID = ++bookIDnew;
                    bookInfo.ISBN = Convert.ToDouble(txtISBN.Text);
                    bookInfo.BookTitle = txtTitle.Text;
                    bookInfo.Remarks = "";
                    bookInfo.Status = "IN";
                    context.BookInfoes.Add(bookInfo);
                    context.SaveChanges();
                }

                context.SaveChanges();
                MessageBox.Show("New Book has been saved!");
                this.Close();
            }
        }
        private void AddBook_Load(object sender, EventArgs e)
        {
            cbotype.SelectedIndex = 0;
            cbosub.SelectedIndex = 0;
            dateTimePickerPub.Text = DateTime.Today.ToString();
            ISBNlist = context.BookCatalogues.Select(x => x.ISBN).ToList();

        }
        //limit ISBN input
        private void txtISBN_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }

        }

        private void txtISBN_TextChanged(object sender, EventArgs e)
        {
            txtISBN.MaxLength = 13;

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //clear textboxes
        private void clear()
        {
            txtISBN.Clear();
            txtTitle.Clear();
            txtauthor.Clear();
            txtPub.Clear();
            txtdesc.Clear();
            cbotype.Items.Clear();
            cbosub.Items.Clear();
            txtCall.Clear();
            txtShelf.Clear();
            txtTotalStock.Clear();
            txtISBN.Focus();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Clear unsaved details?", "Confirm Form Reset.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                clear();
            }
        }

        //check for existing ISBN
        public bool doesISBNexist(double ISBNno)
        {
            foreach (double i in ISBNlist)
            {
                if (i == ISBNno)
                {
                    return true;
                }

            }
            return false;

        }

    }
}






