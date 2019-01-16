using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Wpf;
using LiveCharts.WinForms;
using LiveCharts.Defaults;
using BB_app.Model;
using BB_app.Model.DB;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace BB_app.View
{
    public partial class Statistika_prikaz : Form
    {
        DataGridView gv;
        List<Igraci> igr;
        public Statistika_prikaz()
        {
            InitializeComponent();

            cartesianChart1.Series = new SeriesCollection
            {
                new LineSeries
                {
                   Values = new ChartValues<int> {4,5,6,7,1,2,10}
                }
            };

            pieChart1.Series = new SeriesCollection
            {
                new PieSeries
                {
                    Values = new ChartValues<int> {1}
                },
                new PieSeries
                {
                    Values = new ChartValues<int> {6}
                },
                new PieSeries
                {
                    Values = new ChartValues<int> {3}
                }
            };
        }

        private void cmbStatistikaOdabir_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
