using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace intelli_tutor_frontend
{
    public partial class chartDemo : Form
    {
        public chartDemo()
        {
            InitializeComponent();
        }

        private void chartDemo_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Course Already Exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            int[] values = { 10, 20, 30, 40, 100, 60 };

            for (int i=0; i<values.Length; i++)
            {
                chart1.Series["Series1"].Points.AddXY("Category " + (i + 1), values[i]);
            }
            chart1.Series["Series1"].ChartType = SeriesChartType.Pie;
            chart1.Legends[0].Enabled = true;
            chart1.Titles.Add("Pie Chart Example");



            //chart1.ChartAreas[0].AxisX.Title = "Categories";
            //chart1.ChartAreas[0].AxisY.Title = "Values";
            //chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            //chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            //chart1.ChartAreas[0].AxisY.Maximum = 60; // Adjust maximum Y value if needed


        }
    }
}
