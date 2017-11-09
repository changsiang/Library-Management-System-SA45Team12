//Written by Sicat Jane Escalada and Pradeep Elango

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
    public partial class FormSearchBook : Form
    {
        DipSA45Team12aLibEntities context = new DipSA45Team12aLibEntities();

        private void PopulateGrid()
        {
            dataGridView1.DataSource = context.BookCatalogues.ToList();
        }
        public FormSearchBook()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = context.BookCatalogues.Select
            (x => new { x.ISBN, x.BookTitle, x.Author, x.StockInLibrary, x.NumberOnLoan, x.YearOfPublication, x.Publisher, x.Description, x.Subject, x.Type, x.CallNumber }).ToList();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormAddBook addbook = new FormAddBook();
            addbook.Show();
        }

        private void Collections_Load(object sender, EventArgs e)
        {

            PopulateGrid();
            TypeComboBox.SelectedIndex = 0;
            SubjectComboBox.SelectedIndex = 0;

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            NameTextBox.Text.Trim();
            AuthorTextBox.Text.Trim();
            if (TypeComboBox.SelectedIndex == 0 && SubjectComboBox.SelectedIndex == 0)
            {
                dataGridView1.DataSource = context.BookCatalogues.Where(x => x.BookTitle.Contains(NameTextBox.Text) && x.Author.Contains(AuthorTextBox.Text)).Select
                (x => new { x.ISBN, x.BookTitle, x.Author, x.StockInLibrary, x.NumberOnLoan, x.YearOfPublication, x.Publisher, x.Description, x.Subject, x.Type, x.CallNumber }).ToList();
            }
            else if (TypeComboBox.SelectedIndex != 0 && SubjectComboBox.SelectedIndex == 0)
            {
                dataGridView1.DataSource = context.BookCatalogues.Where(x => x.BookTitle.Contains(NameTextBox.Text) && x.Author.Contains(AuthorTextBox.Text) && x.Type == TypeComboBox.Text).Select
                (x => new { x.ISBN, x.BookTitle, x.Author, x.StockInLibrary, x.NumberOnLoan, x.YearOfPublication, x.Publisher, x.Description, x.Subject, x.Type, x.CallNumber }).ToList();
            }
            else if (TypeComboBox.SelectedIndex == 0 && SubjectComboBox.SelectedIndex != 0)
            {
                dataGridView1.DataSource = context.BookCatalogues.Where(x => x.BookTitle.Contains(NameTextBox.Text) && x.Author.Contains(AuthorTextBox.Text) && x.Subject == SubjectComboBox.Text).Select
                (x => new { x.ISBN, x.BookTitle, x.Author, x.StockInLibrary, x.NumberOnLoan, x.YearOfPublication, x.Publisher, x.Description, x.Subject, x.Type, x.CallNumber }).ToList();
            }
            else if (TypeComboBox.SelectedIndex != 0 && SubjectComboBox.SelectedIndex != 0)
            {
                dataGridView1.DataSource = context.BookCatalogues.Where(x => x.BookTitle.Contains(NameTextBox.Text) && x.Author.Contains(AuthorTextBox.Text) && x.Subject == SubjectComboBox.Text && x.Type == TypeComboBox.Text).Select
                (x => new { x.ISBN, x.BookTitle, x.Author, x.StockInLibrary, x.NumberOnLoan, x.YearOfPublication, x.Publisher, x.Description, x.Subject, x.Type, x.CallNumber }).ToList();
            }

            Int32 selectedRowCount = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);

            if (selectedRowCount > 0)
            {
                btnEdit.Enabled = true;

            }
            else
            {
                btnEdit.Enabled = false;
            }
        }

        private void TypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            FormEditBook updateBookForm = new FormEditBook();
            updateBookForm.SetISBN = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            updateBookForm.ShowDialog();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
