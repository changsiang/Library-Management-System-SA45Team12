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
    public partial class NewMemberForm : Form
    {
        DipSA45Team12aLibEntities context = new DipSA45Team12aLibEntities();
        FormMain MainForm = new FormMain();
        public NewMemberForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }


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

        //regular expressions to limit input
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

        //max length of input
        const int MaxLength = 255;

        //add new member
        private void SaveChangesButton_Click(object sender, EventArgs e)
        {
            Member m = new Member();

            m.ContactTitle = ContactTitleCBox.Text;

            string mIDinput = "";
            bool isMIDValid = Regexp("^[0-9]{7}$$", MemberIDBox, label10);
            if (isMIDValid)
            {

                mIDinput = IDComboBox1.Text + MemberIDBox.Text + IDComboBox2.Text;
                if (doesMemberIDExist(mIDinput))
                {
                    isMIDValid = false;
                    label10.Text = "Member Already Exists";
                    label10.ForeColor = Color.Red;
                    label10.Show();
                }
                else
                {
                    m.MemberID = mIDinput;

                }
            }
            else
            {

                label10.ForeColor = Color.Red;
                label10.Text = "Please enter a 7 digit number";
                label10.Show();
            }

            bool isNameValid = Regexp(@"^[a-zA-Z ]+$", NameBox, label11);
            if (isNameValid)
            {
                if (NameBox.Text.Length < MaxLength)
                {
                    m.Name = NameBox.Text.ToString();
                }
                else
                {
                    ((FormMain)this.MdiParent).SetToolStripLabelText = "Name entered is too long";
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
                    ((FormMain)this.MdiParent).SetToolStripLabelText = "Email address is too long";
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

            m.MemberCategory = MemberCategoryCBox.Text;

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
                    ((FormMain)this.MdiParent).SetToolStripLabelText = "Address entered is too long";
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
                    ((FormMain)this.MdiParent).SetToolStripLabelText = "Remarks entered too long";
                    label16.Show();
                }
            }

            if (isNameValid && isPhoneNumberValid && isEmailValid && isMIDValid && isDOBValid && EmailAddressBox.Text.Length < MaxLength && NameBox.Text.Length < MaxLength && AddressBox.Text.Length < MaxLength && RemarksBox.Text.Length < MaxLength)
            {
                context.Members.Add(m);
                context.SaveChanges();
                ((FormMain)this.MdiParent).SetToolStripLabelText = "New member added to the database!";
                this.Close();
            }
        }

        private void NewMemberForm_Load(object sender, EventArgs e)
        {
            MemberCategoryCBox.SelectedIndex = 0;
            ContactTitleCBox.SelectedIndex = 0;
            IDComboBox1.SelectedIndex = 0;
            IDComboBox2.SelectedIndex = 0;
            DOBDateTimePicker.Text = DateTime.Today.AddYears(-18).ToString();
            label10.Hide();
            label11.Hide();
            label12.Hide();
            label13.Hide();
            label14.Hide();
            label15.Hide();
            label16.Hide();

        }

        //make member category correspond with first letter of memberID
        private void IDComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IDComboBox1.SelectedIndex == 0)
            {
                MemberCategoryCBox.SelectedIndex = 0;
            }
            else if (IDComboBox1.SelectedIndex == 1)
            {
                MemberCategoryCBox.SelectedIndex = 1;
            }
            else if (IDComboBox1.SelectedIndex == 2)
            {
                MemberCategoryCBox.SelectedIndex = 2;
            }
        }

        //check for existing member
        public bool doesMemberIDExist(string memberID)
        {
            List<string> memberIDList = context.Members.Select(x => x.MemberID).ToList();
            if (memberIDList.Contains(memberID))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //make member category correspond with first letter of memberID
        private void MemberCategoryCBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MemberCategoryCBox.SelectedIndex == 0)
            {
                IDComboBox1.SelectedIndex = 0;
            }
            else if (MemberCategoryCBox.SelectedIndex == 1)
            {
                IDComboBox1.SelectedIndex = 1;
            }
            else if (MemberCategoryCBox.SelectedIndex == 2)
            {
                IDComboBox1.SelectedIndex = 2;
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

