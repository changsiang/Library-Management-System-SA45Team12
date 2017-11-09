//Written by Li Jianing

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
    public partial class FormEditMembCat : Form
    {
        DipSA45Team12aLibEntities context = new DipSA45Team12aLibEntities();
        public FormEditMembCat()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            Membership membershipGroup = context.Memberships.Where(x => x.MemberCategory == comboBoxCat.Text).First();
            try
            {
                membershipGroup.LoanQuota = Math.Abs(Convert.ToInt16(textBoxNewQuota.Text));
            }
            catch (Exception ex)
            {
                if (ex is FormatException)
                {
                    ((FormMain)this.MdiParent).SetToolStripLabelText = "Invalid number entry. Please enter a valid number.";
                    return;
                }
                else if (ex is OverflowException)
                {
                    ((FormMain)this.MdiParent).SetToolStripLabelText = "Invalid number entry. Please enter a number between 0 to 32000.";
                    return;
                }
            }
            context.SaveChanges();
            clearTextboxes();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxCurQuota.Text = context.Memberships.Where(x => x.MemberCategory == comboBoxCat.Text).Select(x => x.LoanQuota).First().ToString();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearTextboxes()
        {
            textBoxCurQuota.Text = context.Memberships.Where(x => x.MemberCategory == comboBoxCat.Text).Select(x => x.LoanQuota).First().ToString();
            textBoxNewQuota.Clear();
            textBoxNewQuota.Text = string.Empty;
        }
    }
}
