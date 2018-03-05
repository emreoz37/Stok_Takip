using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Software_Testing_LastProject.Controller;
using DevExpress.XtraCharts;
namespace Software_Testing_LastProject.Views.Reports
{
    public partial class ReportsForm : DevExpress.XtraEditors.XtraForm
    {
        public ReportsForm()
        {
            InitializeComponent();
        }
        private void tileBar_SelectedItemChanged(object sender, TileItemEventArgs e)
        {
            navigationFrame.SelectedPageIndex = tileBarGroupTables.Items.IndexOf(e.Item);
        }

        private void ReportsForm_Load(object sender, EventArgs e)
        {
            getStockReport();
            
        }

        public void getStockReport()
        {
            var result = StokController.StoklarıGetir();
            if (result.Count ==0) return;
            ChartControl DoughnutChart = new ChartControl();

            //// Create a doughnut series.
            Series series1 = new Series("Series 1", ViewType.Doughnut);
            foreach (var item in result)
            {
                series1.Points.Add(new SeriesPoint(item.UrunStok.Urunler.UrunAdi.ToString(),item.UrunStok.Stok));
            }
            DoughnutChart.Series.Add(series1);

            // Specify the text pattern of series labels.
            series1.Label.TextPattern = "{A}: {VP:P0}";

            // Specify how series points are sorted.
            series1.SeriesPointsSorting = SortingMode.Ascending;
            series1.SeriesPointsSortingKey = SeriesPointKey.Argument;

            // Specify the behavior of series labels.
            ((DoughnutSeriesLabel)series1.Label).Position = PieSeriesLabelPosition.TwoColumns;
            ((DoughnutSeriesLabel)series1.Label).ResolveOverlappingMode = ResolveOverlappingMode.Default;
            ((DoughnutSeriesLabel)series1.Label).ResolveOverlappingMinIndent = 5;

            // Adjust the view-type-specific options of the series.
            ((DoughnutSeriesView)series1.View).ExplodedPoints.Add(series1.Points[0]);
            ((DoughnutSeriesView)series1.View).ExplodedDistancePercentage = 30;

            // Access the diagram's options.
            ((SimpleDiagram)DoughnutChart.Diagram).Dimension = 2;

            // Add a title to the chart and hide the legend.
            ChartTitle chartTitle1 = new ChartTitle();
            chartTitle1.Text = "Stok Pasta Grafiği";
            DoughnutChart.Titles.Add(chartTitle1);
            DoughnutChart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;

            // Add the chart to the form.
            DoughnutChart.Dock = DockStyle.Fill;
            this.panel_Stok.Controls.Add(DoughnutChart);
        }

        
    }
}