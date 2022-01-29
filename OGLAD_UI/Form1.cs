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
                int rowcount = dataGridView1.RowCount - 1;

                if (cbxParam1.Checked)
                {   // reading voltage data from cell 1 and 2
                    // plotting on chart box
                    double c1, c2;
                    List<double> vListX = new List<double>();
                    List<double> vListY = new List<double>();
                    for (int i = 1; i < rowcount; i++)
                    {
                        c1 = Convert.ToDouble(dataGridView1.Rows[i].Cells[0].Value);
                        c2 = Convert.ToDouble(dataGridView1.Rows[i].Cells[1].Value);
                        vListX.Add(c1);
                        vListY.Add(c2);
                    }
                    double[] iArrX = vListX.ToArray();
                    double[] iArrY = vListY.ToArray();
                    plotGraph.Plot.YLabel("Voltage");
                    plotGraph.Plot.AddScatter(iArrX, iArrY);
                    plotGraph.Refresh();
                }
                if (cbxParam2.Checked)
                {
                    // reading current data from cell 3 and 4
                    // plotting on chart box
                    double c1, c2;
                    List<double> iListX = new List<double>();
                    List<double> iListY = new List<double>();
                    for (int i = 1; i < rowcount; i++)
                    {
                        c1 = Convert.ToDouble(dataGridView1.Rows[i].Cells[0].Value);
                        if (dataGridView1.Rows[i].Cells[2].Value == null)
                        {
                            continue;
                        }
                        c2 = Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value);
                        iListX.Add(c1);
                        iListY.Add(c2);
                    }
                    double[] iArrX = iListX.ToArray();
                    double[] iArrY = iListY.ToArray();
                    plotGraph.Plot.YLabel("Current");
                    plotGraph.Plot.AddScatter(iArrX, iArrY);
                    plotGraph.Refresh();

                }
                if (cbxParam3.Checked)
                {
                    // reading power data from cell 5 and 6
                    // plotting on chart box
                    double c1, c2;
                    List<double> pListX = new List<double>();
                    List<double> pListY = new List<double>();
                    for (int i = 1; i < rowcount; i++)
                    {
                        c1 = Convert.ToDouble(dataGridView1.Rows[i].Cells[0].Value);
                        c2 = Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value);
                        pListX.Add(c1);
                        pListY.Add(c2);
                    }
                    double[] pArrX = pListX.ToArray();
                    double[] pArrY = pListY.ToArray();
                    plotGraph.Plot.YLabel("Power");
                    plotGraph.Plot.AddScatter(pArrX, pArrY);
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
                int count = 0;
            
                foreach (string str in line[0].Split(','))
                {
                    count++;
                }
                dataGridView1.ColumnCount = count;
                foreach (string s1 in readfile.Split('\n'))
                {
                if (s1 != "")
                    dataGridView1.Rows.Add(s1.Split(','));
                    
                }
                //after figuring out how to read in the data
                double[] timeArr = new double[9999];
                double[] ACEnergyArr = new double[9999];
                for(int i = 0; i < 100000; i++)
                {
                    timeArr[i] = Convert.ToDouble(//read in time data value);
                    ACEnergyArr[i] = Convert.ToDouble(//read in energy data value);
                }
                plotGraph.Plot.AddScatter(timeArr, ACEnergyArr);
                plotGraph.Refresh();
            }
            catch (Exception)
            {
                MessageBox.Show("Error in loading file.");
            }
        }
    }
}
