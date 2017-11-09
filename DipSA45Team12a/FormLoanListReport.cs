//Written by Li Jianing and Lim Chang Siang
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DipSA45Team12a.DataSetForCrystalReportTableAdapters;

namespace DipSA45Team12a
{
    public partial class FormLoanListReport : Form
    {

        
        int transID = 3;
        public FormLoanListReport()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            CrystalReportLoanTrans cr = new CrystalReportLoanTrans();
            DataSetForCrystalReport ds = new DataSetForCrystalReport();
            LoanTransTableAdapter lt = new LoanTransTableAdapter();
            MembersTableAdapter memb = new MembersTableAdapter();
            lt.Fill(ds.LoanTrans);
            memb.Fill(ds.Members);
            cr.SetDataSource(ds);
            crystalReportViewer1.ReportSource = cr;
        }
            
 

        public int SetTransID
        {
            set
            {
                transID = value;
            }
        }
    }
}
