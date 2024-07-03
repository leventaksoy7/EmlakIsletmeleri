using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmlakIsletmeleri
{
    public partial class CrystalReportViewerForm : Form
    {
        public CrystalReportViewerForm(ReportDocument reportDocument)
        {
            InitializeComponent();
            crystalReportViewer.ReportSource = reportDocument;
            crystalReportViewer.Refresh();
        }

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer;
    }
}
