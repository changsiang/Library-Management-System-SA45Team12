//Written by Lim Chang Siang

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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

        }
        public string SetToolStripLabelText
        {
            set
            {
                toolStripStatusLabel1.Text = value;
                Form form = new Form();
            }
        }

        private void loanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            Loan loanForm = new Loan();
            loanForm.MdiParent = this;
            loanForm.Show();

        }

        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            ReturnForm returnForm = new ReturnForm();
            returnForm.MdiParent = this;
            returnForm.Show();
        }

        private void bookListReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            FormBookReport bookReport = new FormBookReport();
            bookReport.MdiParent = this;
            bookReport.Show();
        }

        private void printReceiptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            FormLoanListReport transIDForm = new FormLoanListReport();
            transIDForm.MdiParent = this;
            transIDForm.Show();
        }

        private void crossTabReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            FormCrossTabReport crossTabForm = new FormCrossTabReport();
            crossTabForm.MdiParent = this;
            crossTabForm.Show();
        }

        private void memberCatagoryRatioToolStripMenuItem_Click(object sender, EventArgs e)
        {
                this.IsMdiContainer = true;
                FormPieChartReport pieChartForm = new FormPieChartReport();
                pieChartForm.MdiParent = this;
                pieChartForm.Show();

        }

        private void createNewMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            NewMemberForm createMember = new NewMemberForm();
            createMember.MdiParent = this;
            createMember.Show();
        }

        private void updateExistingMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            MemberSearchForm searchMember = new MemberSearchForm();
            searchMember.MdiParent = this;
            searchMember.Show();
        }

        private void manageMemberCatagoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            FormEditMembCat editMemberCat = new FormEditMembCat();
            editMemberCat.MdiParent = this;
            editMemberCat.Show();
        }
        
        public string SetToolStatusStripe
        {
            set
            {
                toolStripStatusLabel1.Text = value;
            }
        }

        private void availablityOfLoanedBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            FormBooksAvailability bookAvailForm = new FormBooksAvailability();
            bookAvailForm.MdiParent = this;
            bookAvailForm.Show();
        }

        private void addNewBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            FormAddBook addBookForm = new FormAddBook();
            addBookForm.MdiParent = this;
            addBookForm.Show();
        }

        private void searchForBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            FormSearchBook bookSearchForm = new FormSearchBook();
            bookSearchForm.MdiParent = this;
            bookSearchForm.Show();
        }

        private void updateBookInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            FormEditBook bookUpdateForm = new FormEditBook();
            bookUpdateForm.MdiParent = this;
            bookUpdateForm.Show();
        }

        private void disableSearchUpdateMemberOption()
        {
            if (Loan.ActiveForm.Enabled)
            {
                updateExistingMemberToolStripMenuItem.Enabled = false;
            }
        }

        public bool SetdisableSearchUpdateMemberOption
        {
            set
            {
                updateExistingMemberToolStripMenuItem.Enabled = value;
            }
        }

        private void deleteBookFromLibraryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            FormDeleteBook bookDeleteForm = new FormDeleteBook();
            bookDeleteForm.MdiParent = this;
            bookDeleteForm.Show();
        }

        private void softwareDocumentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            FormHelpFaq HelpFaqForm = new FormHelpFaq();
            HelpFaqForm.MdiParent = this;
            HelpFaqForm.Show();
        }

        private void aboutLMSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            FormAboutLMS HelpAboutForm = new FormAboutLMS();
            HelpAboutForm.MdiParent = this;
            HelpAboutForm.Show();

        }
    }

}
