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
        }

        private void button1_Click(object sender, EventArgs e)
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
            }
            catch (Exception)
            {
                MessageBox.Show("Error in loading file.");
            }
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
                {   // Creating List of point to plot and scaling wave to fit window
                    double c1, c2;
                    for (int i = 1; i < rowcount; i++)
                    {
                        c1 = Convert.ToDouble(dataGridView1.Rows[i].Cells[0].Value);
                        c2 = Convert.ToDouble(dataGridView1.Rows[i].Cells[1].Value);
                        chart1.Series["Series1"].Points.AddXY(c1, c2);
                    }
                }
                if (cbxParam2.Checked)
                {
                    double c1, c2;
                    for (int i = 1; i < rowcount; i++)
                    {
                        c1 = Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value);
                        c2 = Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value);
                        chart1.Series["Series1"].Points.AddXY(c1, c2);
                    }
                }
                if (cbxParam3.Checked)
                {
                    double c1, c2;
                    for (int i = 1; i < rowcount; i++)
                    {
                        c1 = Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value);
                        c2 = Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value);
                        chart1.Series["Series1"].Points.AddXY(c1, c2);
                    }
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
                g.Clear(Color.White);
                g.Dispose();
                txtStatus.Text = " The O-GLAD System is not running";
            }
            else
            {

            }
        }
    }
}
