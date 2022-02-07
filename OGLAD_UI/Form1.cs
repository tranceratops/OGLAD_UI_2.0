using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OGLAD_UI
{
    public partial class Form1 : Form
    {
        //Global Variables
        bool guiRunning = false;
        // Create graphics object
        Graphics g;
        List<double> voltageArr = new List<double>();
        List<double> currentArr = new List<double>();
        List<double> timeArr = new List<double>();
        List<double> pfArr = new List<double>();
        List<double> freqArr = new List<double>();
        List<double> ce1Arr = new List<double>();
        List<double> ce24Arr = new List<double>();

        public Form1()
        {
            InitializeComponent();
            // Set the initial state of the control check boxes.
            txtStatus.Text = "The O-Glad System is not running";
            cbxParam1.Checked = true;
            cbxParam2.Checked = false;
            cbxParam3.Checked = false;
            this.WindowState = FormWindowState.Maximized;
            SetupGraphLabels();
        }

        public void SetupGraphLabels()
        {
            plotGraph.Plot.XLabel("Time");
            plotGraph.Plot.Title("Signal Graph");

        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (!guiRunning)
            {
                // Turn on GUI running flag
                guiRunning = true;
                //plot signal data
                double[] timeArrX = timeArr.ToArray();

                if (cbxParam1.Checked)
                {   // converting voltage data array
                    // plotting on chart box
                    double[] voltageArrY = voltageArr.ToArray();
                    plotGraph.Plot.YLabel("Voltage");
                    plotGraph.Plot.AddScatter(timeArrX, voltageArrY);
                    plotGraph.Refresh();
                }
                if (cbxParam2.Checked)
                {
                    // converting current data array
                    // plotting on chart box
                    double[] currentArrY = currentArr.ToArray();
                    plotGraph.Plot.YLabel("Current");
                    plotGraph.Plot.AddScatter(timeArrX, currentArrY);
                    plotGraph.Refresh();

                }
                if (cbxParam3.Checked)
                {
                    // converting power factor data array
                    // plotting on chart box
                    double[] pfArrY = pfArr.ToArray();
                    plotGraph.Plot.YLabel("Power Factor");
                    plotGraph.Plot.AddScatter(timeArrX, pfArrY);
                    plotGraph.Refresh();
                }
                if (cbxParam4.Checked)
                {
                    // converting frequency data array
                    // plotting on chart box
                    double[] freqArrY = freqArr.ToArray();
                    plotGraph.Plot.YLabel("Frequency");
                    plotGraph.Plot.AddScatter(timeArrX, freqArrY);
                    plotGraph.Refresh();
                }
                txtStatus.Text = "The O-GLAD System is running";

            }
            else
            {
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (guiRunning)
            {
                guiRunning = false;
                plotGraph.Plot.Clear();
                plotGraph.Refresh();
                txtStatus.Text = " The O-GLAD System is not running";

            }
            else
            {

            }
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            //upload signal data to grid
            try
            {
                openFileDialog1.ShowDialog();
                string fn = openFileDialog1.FileName;
                string readfile = File.ReadAllText(fn);
                string[] line = readfile.Split('\n');

                string [] tmp;
                foreach (string s1 in readfile.Split('\n'))
                {
                    tmp = s1.Split(',');
                    timeArr.Add(Convert.ToDouble(tmp[0]));
                    voltageArr.Add(Convert.ToDouble(tmp[1]));
                    currentArr.Add(Convert.ToDouble(tmp[2]));
                    pfArr.Add(Convert.ToDouble(tmp[3]));
                    freqArr.Add(Convert.ToDouble(tmp[4]));
                    ce1Arr.Add(Convert.ToDouble(tmp[5]));
                    ce24Arr.Add(Convert.ToDouble(tmp[6]));

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error in loading file.");
            }
        }
    }
}
