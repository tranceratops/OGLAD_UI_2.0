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
        List<DateTime> dateTimeArr = new List<DateTime>();
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
            txtStatus.Text = "Ready for data read-in.";
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
            plotGraph.Plot.XAxis.DateTimeFormat(true);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (!guiRunning)
            {
                // Turn on GUI running flag
                guiRunning = true;
                //plot signal data
                double [] timeArrX = dateTimeArr.Select(x => x.ToOADate()).ToArray();

                if (cbxParam1.Checked)
                {   // converting voltage data array
                    // plotting on chart box
                    double[] voltageArrY = voltageArr.ToArray();
                    plotGraph.Plot.YLabel("Voltage");
                    plotGraph.Plot.AddSignalXY(timeArrX, voltageArrY);
                    plotGraph.Plot.SetOuterViewLimits(yMin: voltageArrY.Min() - (0.1)*voltageArrY.Max(),
                    yMax: voltageArrY.Max()+(0.1) * voltageArrY.Max());
                    plotGraph.Refresh();
                }   
                if (cbxParam2.Checked)
                {
                    // converting current data array
                    // plotting on chart box
                    double[] currentArrY = currentArr.ToArray();
                    plotGraph.Plot.YLabel("Current");
                    plotGraph.Plot.AddSignalXY(timeArrX, currentArrY);
                    plotGraph.Refresh();

                }
                if (cbxParam3.Checked)
                {
                    // converting power factor data array
                    // plotting on chart box
                    double[] pfArrY = pfArr.ToArray();
                    plotGraph.Plot.YLabel("Power Factor");
                    plotGraph.Plot.AddSignalXY(timeArrX, pfArrY);
                    plotGraph.Refresh();
                }
                if (cbxParam4.Checked)
                {
                    // converting frequency data array
                    // plotting on chart box
                    double[] freqArrY = freqArr.ToArray();
                    plotGraph.Plot.YLabel("Frequency");
                    plotGraph.Plot.AddSignalXY(timeArrX, freqArrY);
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
                voltageArr.Clear();
                timeArr.Clear();
                plotGraph.Refresh();
                txtStatus.Text = " The O-GLAD System is not running";

            }
            else
            {

            }
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            //parse signal data
            try
            {
                openFileDialog1.ShowDialog();
                string fn = openFileDialog1.FileName;
                string readfile = File.ReadAllText(fn);   //read in CSV file
                string[] line = readfile.Split('\n');
                line = line.Skip(1).ToArray();            //skip header line of CSV

                string [] tmp;
                foreach (string s1 in readfile.Split('\n'))
                {
                    tmp = s1.Split(',');                  //create array for each row
                    if (tmp[0] == "")                     //null case for when CSV is fully read in
                        break;
                    dateTimeArr.Add(DateTime.Parse(tmp[0]));   //appending values to global lists
                    //timeArr.Add(Convert.ToDouble(tmp[0]));
                    voltageArr.Add(Convert.ToDouble(tmp[1]));
                    //currentArr.Add(Convert.ToDouble(tmp[2]));
                    //pfArr.Add(Convert.ToDouble(tmp[3]));
                    //freqArr.Add(Convert.ToDouble(tmp[4]));
                    //ce1Arr.Add(Convert.ToDouble(tmp[5]));
                    //ce24Arr.Add(Convert.ToDouble(tmp[6]));
                }
                txtStatus.Text = "Data is loaded and ready to plot."; //status update for completion
            }
            catch (Exception)
            {
                MessageBox.Show("Error in loading file.");
            }
        }
    }
}
