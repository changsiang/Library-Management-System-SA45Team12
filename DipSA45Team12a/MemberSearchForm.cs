//Written by Pradeep Elango DipSA45 12a

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace DipSA45Team12a
{
    public partial class MemberSearchForm : Form
    {
        DipSA45Team12aLibEntities context = new DipSA45Team12aLibEntities();
        FormMain MainForm = new FormMain();
        string memberID;

        //checking whether the form is opened from Loan Form(so that UI can be changed slightly)
        public bool IsFromLoanFrom { get; set; }
        public string GetMemberID
        {
            get
            {
                return memberID;
            }
        }

        public MemberSearchForm()
        {
            InitializeComponent();
        }

        private void MemberSearchForm_Load(object sender, EventArgs e)
        {
            PopulateGrid();
            ColumnComboBox.SelectedIndex = 1;
            this.WindowState = FormWindowState.Maximized;
            if (IsFromLoanFrom == true)
            {
                buttonClose.Text = "Select Member";
                ViewLoansButton.Visible = false;
                ViewLoansButton.Enabled = false;
                UpdateButton.Visible = false;
                UpdateButton.Enabled = false;
            }
            else
            {
                buttonClose.Visible = false;
                buttonClose.Enabled = false;
                ViewLoansButton.Visible = true;
                ViewLoansButton.Enabled = true;
                UpdateButton.Visible = true;
                UpdateButton.Enabled = true;
            }
        }
        //get info from database
        private void ViewAllMembersButton_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = context.Members.Select
            (x => new { x.MemberID, x.ContactTitle, x.Name, x.MemberCategory, x.Address, x.DateOfBirth, x.PhoneNumber, x.EmailAddress, x.Remarks }).ToList();
            ViewLoansButton.Enabled = true;
            UpdateButton.Enabled = true;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            label1.Hide();
            Regex r = new Regex(@"^[a-zA-Z0-9\s]*$");
            if (r.IsMatch(SearchBox.Text))
            {
                if (ColumnComboBox.Text == "Member ID")
                {
                    dataGridView1.DataSource = context.Members.Where(x => x.MemberID.Contains(SearchBox.Text)).Select(x => new { x.MemberID, x.ContactTitle, x.Name, x.MemberCategory, x.Address, x.DateOfBirth, x.PhoneNumber, x.EmailAddress, x.Remarks }).ToList();

                }
                else if (ColumnComboBox.Text == "Name")
                {
                    Regex r1 = new Regex(@"[a-zA-Z\s]+$");
                    if (r1.IsMatch(SearchBox.Text))
                    {
                        dataGridView1.DataSource = context.Members.Where(x => x.Name.Contains(SearchBox.Text)).Select(x => new { x.MemberID, x.ContactTitle, x.Name, x.MemberCategory, x.Address, x.DateOfBirth, x.PhoneNumber, x.EmailAddress, x.Remarks }).ToList();
                    }
                    else
                    {
                        ((FormMain)this.MdiParent).SetToolStripLabelText = "Invalid Characters Entered in Name Field";
                    }
                }
                else if (ColumnComboBox.Text == "Phone Number")
                {
                    Regex r2 = new Regex(@"^\d+$");
                    if (r2.IsMatch(SearchBox.Text))
                    {
                        int phonenumber;
                        Int32.TryParse(SearchBox.Text, out phonenumber);
                        dataGridView1.DataSource = context.Members.Where(x => x.PhoneNumber == phonenumber).Select(x => new { x.MemberID, x.ContactTitle, x.Name, x.MemberCategory, x.Address, x.DateOfBirth, x.PhoneNumber, x.EmailAddress, x.Remarks }).ToList();
                    }
                    else
                    {
                        ((FormMain)this.MdiParent).SetToolStripLabelText = "Invalid Characters Entered in Phone Number Field";
                    }
                }
            }
            else
            {
                ((FormMain)this.MdiParent).SetToolStripLabelText = "Invalid Characters Entered in Member Information";

            }

            Int32 selectedRowCount = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);

            if (selectedRowCount > 0)
            {
                ViewLoansButton.Enabled = true;
                UpdateButton.Enabled = true;
            }
            else
            {
                ViewLoansButton.Enabled = false;
                UpdateButton.Enabled = false;
            }
        }
        //open loan details form
        public void ViewLoansButton_Click(object sender, EventArgs e)
        {

            string mID = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string mName = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            LoanDetailsForm frm2 = new LoanDetailsForm(this);
            frm2.mID = mID;
            frm2.mName = mName;
            frm2.ShowDialog();
        }
        //open update member info form
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            MemberUpdateForm frm3 = new MemberUpdateForm(this);

            string mID = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string mContactTitle = dataGridView1.CurrentRow.Cells[1].Value.ToString().ToUpper();
            string mName = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            string mCategory = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            string mAddress = EmptyIfNull(dataGridView1.CurrentRow.Cells[4].Value);
            string mDOB = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            string mPhoneNumber = EmptyIfNull(dataGridView1.CurrentRow.Cells[6].Value);
            string mEmailAddress = EmptyIfNull(dataGridView1.CurrentRow.Cells[7].Value);
            string mRemarks = EmptyIfNull(dataGridView1.CurrentRow.Cells[8].Value);

            frm3.mID = mID;
            frm3.mContactTitle = mContactTitle;
            frm3.mName = mName;
            frm3.mCategory = mCategory;
            frm3.mAddress = mAddress;
            frm3.mDOB = mDOB;
            frm3.mPhoneNumber = mPhoneNumber;
            frm3.mEmailAddress = mEmailAddress;
            frm3.mRemarks = mRemarks;
            frm3.ShowDialog();
        }

        //fill in datagrid with info
        public void PopulateGrid()
        {
            dataGridView1.DataSource = context.Members.Select
            (x => new { x.MemberID, x.ContactTitle, x.Name, x.MemberCategory, x.Address, x.DateOfBirth, x.PhoneNumber, x.EmailAddress, x.Remarks }).ToList();
        }
        private string EmptyIfNull(object value)
        {
            if (value == null)
                return "";
            return value.ToString();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            memberID = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            this.DialogResult = DialogResult.Cancel;
            this.Close();

        }

    }
}
