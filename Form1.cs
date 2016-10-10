using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace RegresiLinear
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double sumX()  // variabel umur
        {
            double result = 0;
            foreach (var listBoxItem in listBoxUmur.Items)
            {
                result = result + int.Parse(listBoxItem.ToString());
            }
            lblSumX.Text = "SUM X : " + result.ToString();
            return result;
        }

        private double sumY()  // variabel berat badan
        {
            double result = 0;
            foreach (var listBoxItem in listBoxBB.Items)
            {
                result = result + int.Parse(listBoxItem.ToString());
            }
            lblSumY.Text = "SUM Y : " + result.ToString();
            return result;
        }

        private double sumXSqueare()
        {
            double result = 0;
            foreach (var listBoxItem in listBoxUmur.Items)
            {
                result = result + (Math.Pow(int.Parse(listBoxItem.ToString()), 2));
            }
            lblSumXSq.Text = "SUM X Sq : " + result.ToString();
            return result;
        }

        private double sumXY()
        {
            // chart
            chart1.Series.Clear();
            var series = new Series
            {
                Name = "Berat Badan",
                Color = System.Drawing.Color.Green,
                IsVisibleInLegend = false,
                IsXValueIndexed = true,
                ChartType = SeriesChartType.Line
            };
            this.chart1.Series.Add(series);

            double result = 0;
            for (int i = 0; i < listBoxUmur.Items.Count; i++)
            {
                int x = int.Parse(listBoxUmur.Items[i].ToString());
                int y = int.Parse(listBoxBB.Items[i].ToString());
                result = result + (x * y);

                // chart
                series.Points.AddXY(x, y);

            }
            chart1.Invalidate();
            lblSumXY.Text = "SUM XY : " + result.ToString();
            return result;
        }

        private double calculateLinearRegresion() {
            double denom = 0;
            double a0 = 0;
            double a1 = 0;
            double result = 0;

            // denom = n x sum(xsq) - sum(x) x sum(x)
            // a0 = (sum(y) x sum(xsq) - sum(x) x sum(xy)) / denom
            // a1 = (n x sum(xy) - sum(x) x sum(y)) / denom
            denom = (listBoxUmur.Items.Count * sumXSqueare()) - (Math.Pow(sumX(), 2));
            a0 = ((sumY() * sumXSqueare()) - (sumX() * sumXY())) / denom;
            a1 = ((listBoxUmur.Items.Count * sumXY()) - (sumX() * sumY())) / denom;    

            // y = a1x + a0
            result = (a1 * Int32.Parse(txtUmur.Text)) + a0;
            
            return result;
        }

        private void btnPrediksi_Click(object sender, EventArgs e)
        {
            lblHasilPrediksi.Text = calculateLinearRegresion().ToString();
        }
    }
}
