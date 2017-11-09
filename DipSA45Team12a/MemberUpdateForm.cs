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
    public partial class MemberUpdateForm : Form
    {
        DipSA45Team12aLibEntities context = new DipSA45Team12aLibEntities();
        public string mID { get; set; }
        public string mContactTitle { get; set; }
        public string mName { get; set; }
        public string mAddress { get; set; }
        public string mEmailAddress { get; set; }
        public string mPhoneNumber { get; set; }
        public string mRemarks { get; set; }
        public string mDOB { get; set; }
        public string mCategory { get; set; }

        public MemberSearchForm msearchfrm1;
        public MemberUpdateForm(MemberSearchForm msearchfrm)
        {
            InitializeComponent();
            msearchfrm1 = msearchfrm;
        }
        //set max length of input
        const int MaxLength = 255;

        //label methods for textboxes
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

        //get info from membersearchform
        public void MemberUpdateForm_Load(object sender, EventArgs e)
        {
            MemberIDBox.Text = this.mID;

            if (this.mContactTitle.Contains("MR"))
            {
                ContactTitleCBox.SelectedIndex = 0;
            }
            else
            {
                ContactTitleCBox.SelectedIndex = 1;
            }

            NameBox.Text = this.mName;

            if (this.mCategory.Contains("UNDERGRADUATE"))
            {
                MemberCategoryCBox.SelectedIndex = 0;
            }
            else if (this.mCategory.Contains("STAFF"))
            {
                MemberCategoryCBox.SelectedIndex = 2;
            }
            else if (this.mCategory == "GRADUATE")
            {
                MemberCategoryCBox.SelectedIndex = 1;
            }
            else if (this.mCategory.Contains("INACTIVE"))
            {
                MemberCategoryCBox.SelectedIndex = 3;
            }

            AddressBox.Text = this.mAddress;
            PhoneNumberBox.Text = this.mPhoneNumber;
            EmailAddressBox.Text = this.mEmailAddress;
            DOBDateTimePicker.Text = this.mDOB;
            RemarksBox.Text = this.mRemarks;
            label11.Hide();
            label12.Hide();
            label13.Hide();
            label14.Hide();
            label15.Hide();
            label16.Hide();

            if (this.mCategory == "INACTIVE")
            {
                DeleteButton.Enabled = false;
            }
        }

        //regular expressions method
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

        //update member info
        private void SaveChangesButton_Click(object sender, EventArgs e)
        {
            Member m = context.Members.Where(x => x.MemberID == mID).First();

            m.ContactTitle = ContactTitleCBox.Text;
            m.MemberCategory = MemberCategoryCBox.Text;
            bool isNameValid = Regexp(@"^[a-zA-Z ]+$", NameBox, label11);
            if (isNameValid)
            {
                if (NameBox.Text.Length < MaxLength)
                {
                    m.Name = NameBox.Text.ToString();
                }
                else
                {
                    label11.ForeColor = Color.Red;
                    label11.Text = "Too long";
                    label11.Show();
                }
            }
            bool isEmailValid = Regexp(@"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*@((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))\z", EmailAddressBox, label13);
            if (EmailAddressBox.Text.Trim() == "")
            {
                m.EmailAddress = null;
                isEmailValid = true;
                label13.Hide();
            }
            else
            {
                if (EmailAddressBox.Text.Length < MaxLength)
                {
                    if (isEmailValid)
                        m.EmailAddress = EmailAddressBox.Text.ToString();
                }
                else
                {
                    label13.ForeColor = Color.Red;
                    label13.Text = "Too long";
                    label13.Show();
                }
            }

            bool isPhoneNumberValid = Regexp(@"^(?!\s*$)[0-9\s]{7,8}$", PhoneNumberBox, label12);

            if (PhoneNumberBox.Text.Trim() == "")
            {
                m.PhoneNumber = null;
                isPhoneNumberValid = true;
                label12.Hide();
            }
            else
            {
                if (isPhoneNumberValid)
                {
                    m.PhoneNumber = Convert.ToInt32(PhoneNumberBox.Text);
                }
            }



            if (AddressBox.Text == "")
                m.Address = null;
            else
            {
                if (AddressBox.Text.Length < MaxLength)
                {
                    label15.Hide();
                    m.Address = AddressBox.Text;
                }
                else
                {
                    label15.ForeColor = Color.Red;
                    label15.Text = "Too long";
                    label15.Show();
                }
            }
            bool isDOBValid = false;
            if (DOBDateTimePicker.Value < DateTime.Today.AddYears(-5))
            {
                isDOBValid = true;
                m.DateOfBirth = DOBDateTimePicker.Value;
                ValidLabel(label14);
            }
            else
            {
                InvalidLabel(label14);
            }

            if (RemarksBox.Text == "")
                m.Remarks = null;
            else
            {
                if (RemarksBox.Text.Length < MaxLength)
                {
                    label16.Hide();
                    m.Remarks = RemarksBox.Text;
                }
                else
                {
                    label16.ForeColor = Color.Red;
                    label16.Text = "Too long";
                    label16.Show();
                }
            }

            //if (RemarksBox.Text == "")
            //	m.Remarks = null;
            //else
            //	m.Remarks = RemarksBox.Text;

            if (isNameValid && isPhoneNumberValid && isEmailValid && isDOBValid && EmailAddressBox.Text.Length < MaxLength && NameBox.Text.Length < MaxLength && AddressBox.Text.Length < MaxLength && RemarksBox.Text.Length < MaxLength)
            {
                if (this.mName == NameBox.Text && this.mAddress == AddressBox.Text && this.mPhoneNumber == PhoneNumberBox.Text && this.mEmailAddress == EmailAddressBox.Text && this.mRemarks == RemarksBox.Text && this.mDOB == DOBDateTimePicker.Value.ToString() && this.mCategory == MemberCategoryCBox.Text)
                {
                    MessageBox.Show("No changes were made!");
                    this.Close();
                }
                else
                {
                    context.SaveChanges();
                    msearchfrm1.PopulateGrid();
                    MessageBox.Show("Member information has been updated successfully!");
                    this.Close();
                }
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //restrict changing of membercategory
        private void MemberCategoryCBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (this.mCategory.Contains("UNDERGRADUATE"))
            {
                MemberCategoryCBox.SelectedIndex = 0;
            }
            else if (this.mCategory.Contains("STAFF"))
            {
                MemberCategoryCBox.SelectedIndex = 2;
            }
            else if (this.mCategory == "GRADUATE")
            {
                MemberCategoryCBox.SelectedIndex = 1;
            }
            else if (this.mCategory.Contains("INACTIVE"))
            {
                MemberCategoryCBox.SelectedIndex = 3;
            }
        }

        //delete member (set membercategory to "INACTIVE"
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int noOfBooks = 0;
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to permanently set member as inactive?", "Warning", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Member m = context.Members.Where(x => x.MemberID == mID).First();
                try
                {
                    noOfBooks = int.Parse(context.LoanTrans.Where(x => x.MemberID == mID).Sum(x => x.NumberOfBooks).ToString());
                }
                catch (FormatException)
                {

                }
                if (noOfBooks == 0)
                {
                    m.MemberCategory = "INACTIVE";
                    context.SaveChanges();
                    MessageBox.Show("Member has been set to inactive");
                    msearchfrm1.PopulateGrid();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Unable to set memeber to inactive as loaned books have not been returned");
                    this.Close();
                }


            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }
    }
}
