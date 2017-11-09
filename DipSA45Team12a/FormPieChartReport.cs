//Written by Li Jianing and Lim Chang Siang DipSA45 Team12a

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DipSA45Team12a;
using DipSA45Team12a.DataSetForCrystalReportTableAdapters;

namespace DipSA45Team12a
{
    public partial class FormPieChartReport : Form
    {
        DipSA45Team12aLibEntities context = new DipSA45Team12aLibEntities();
        public FormPieChartReport()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            DataSetForCrystalReport ds = new DataSetForCrystalReport();
            MembersTableAdapter ta = new MembersTableAdapter();
            CrystalReportPieChart cr = new CrystalReportPieChart();

            ta.Fill(ds.Members);
            cr.SetDataSource(ds);
            crystalReportViewer1.ReportSource = cr;
        }
    }
}
