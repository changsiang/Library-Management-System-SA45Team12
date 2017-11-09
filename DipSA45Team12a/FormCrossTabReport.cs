//Written by Li Jianing and Sicat Jane Escalada

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
    public partial class FormCrossTabReport : Form
    {
        DipSA45Team12aLibEntities context = new DipSA45Team12aLibEntities();
        public FormCrossTabReport()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            CrystalReportCrossTab cr = new CrystalReportCrossTab();
            cr.SetDataSource(context.BookCatalogues.ToList());

            crystalReportViewer1.ReportSource = cr;

        }
    }
}
