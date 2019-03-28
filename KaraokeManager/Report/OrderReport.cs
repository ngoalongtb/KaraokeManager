using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using KaraokeManager.AppCode;

namespace KaraokeManager.Report
{
    public partial class OrderReport : DevExpress.XtraReports.UI.XtraReport
    {
        private OrderReportModel model;
        public OrderReport()
        {
            InitializeComponent();
        }
        public OrderReport(OrderReportModel model)
        {
            this.model = model;
            InitializeComponent();
        }

    }
}
