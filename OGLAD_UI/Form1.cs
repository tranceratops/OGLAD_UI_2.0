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
using Microsoft.VisualBasic;

namespace OGLAD_UI
{
    public partial class Form1 : Form
    {
        //Global Variables
        bool guiRunning = false;
        List<DateTime> dateTimeArr = new List<DateTime>();
        List<double> voltageArr = new List<double>();
        List<double> currentArr = new List<double>();
        List<double> timeArr = new List<double>();
        List<double> pfArr = new List<double>();
        List<double> freqArr = new List<double>();
        List<double> ce1Arr = new List<double>();
        List<double> ce24Arr = new List<double>();

        double[] timeArrX;
        double[] voltageArrY;
        double[] currentArrY;
        double[] pfArrY;
        double[] freqArrY;

        double histBinSize;
        double histBarWidth;

        public Form1()
        {
            InitializeComponent();
            // Set the initial state of the control check boxes.
            txtStatus.Text = "Ready for data read-in.";
            this.WindowState = FormWindowState.Maximized;
            SetupGraphLabels();
        }

        public void SetupGraphLabels()
        {
            plotGraph.Plot.XLabel("Time");
            plotGraph.Plot.Title("Signal Graph");
            plotGraph.Plot.XAxis.DateTimeFormat(true);
        }

        public void signalGraphing(double[] tArr, double[] valueArr)
        {
            plotGraph.Plot.AddSignalXY(tArr, valueArr);
            plotGraph.Plot.SetOuterViewLimits(yMin: valueArr.Min() - (0.1) * valueArr.Max(),
            yMax: valueArr.Max() + (0.1) * valueArr.Max());
            plotGraph.Plot.XAxis.DateTimeFormat(true);
            plotGraph.Plot.XLabel("Time");
            plotGraph.Plot.Title("Signal Graph");
            plotGraph.Refresh();
        }

        public void histogramGraph(double[] valueArr)
        {
            bool validInput = true;
            bool validInput2 = true;
            double vArrYMin = valueArr.Min();
            double vArrYMax = valueArr.Max();
            try
            {
                while (validInput)
                {
                    string strBinSize = Interaction.InputBox("Enter bin size:", "Histogram Controls", "", 500, 300);
                    if (strBinSize != "" && !strBinSize.Any(Char.IsLetter))
                    {
                        validInput = false;
                        while (validInput2)
                        {
                            string strBarWidth = Interaction.InputBox("Enter bar width:", "Histogram Controls", "", 500, 300);
                            if (strBarWidth != "" && !strBarWidth.Any(Char.IsLetter))
                            {
                                validInput2 = false;
                                histBinSize = Convert.ToDouble(strBinSize);
                                histBarWidth = Convert.ToDouble(strBarWidth);
                                (double[] counts, double[] binEdges) = ScottPlot.Statistics.Common.Histogram(valueArr, min: vArrYMin, max: vArrYMax, binSize: histBinSize);
                                double[] leftEdges = binEdges.Take(binEdges.Length - 1).ToArray();
                                //Array.Resize(ref binEdges, binEdges.Length - 1);
                                var bar = plotGraph.Plot.AddBar(values: counts, positions: leftEdges);
                                bar.BarWidth = histBarWidth;
                                plotGraph.Plot.YAxis.Label("Count (#)");
                                plotGraph.Plot.XAxis.Label("Voltage (V)");
                                plotGraph.Plot.SetAxisLimits(yMin: 0);

                                double[] smoothEdges = ScottPlot.DataGen.Range(start: binEdges.First(), stop: binEdges.Last(), step: 0.1, includeStop: true);
                                double[] densities = ScottPlot.Statistics.Common.ProbabilityDensity(valueArr, smoothEdges);
                                plotGraph.Plot.AddScatterLines(xs: smoothEdges, ys: densities, color: Color.Black, lineWidth: 2, lineStyle: ScottPlot.LineStyle.Dash);

                                plotGraph.Plot.XAxis.DateTimeFormat(false);
                                plotGraph.Plot.SetOuterViewLimits(yMin: 0, yMax: double.PositiveInfinity);
                                plotGraph.Plot.AxisAuto();
                                plotGraph.Plot.Title("Histogram Representation");
                                plotGraph.Refresh();
                            }
                            else
                            {
                                MessageBox.Show("Input must be numerical", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Input must be numerical", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error. Value out of range.");
            }

        }

        public void meanLine(double[] valueArr)
        {
            var stats = new ScottPlot.Statistics.BasicStats(valueArr);
            plotGraph.Plot.AddVerticalLine(stats.Mean, Color.Black, 2, ScottPlot.LineStyle.Solid, "mean");
            plotGraph.Plot.Legend(location: ScottPlot.Alignment.UpperRight);
            double dispMeanVal = Math.Round(stats.Mean, 2);
            statMeanVal.Text = dispMeanVal.ToString();
            plotGraph.Refresh();
        }
 
        public void standDev1(double[] valueArr)
        {
            var stats = new ScottPlot.Statistics.BasicStats(valueArr);
            plotGraph.Plot.AddVerticalLine(stats.Mean - stats.StDev, Color.Black, 2, ScottPlot.LineStyle.Dash, "1 SD");
            plotGraph.Plot.AddVerticalLine(stats.Mean + stats.StDev, Color.Black, 2, ScottPlot.LineStyle.Dash);
            plotGraph.Plot.Legend(location: ScottPlot.Alignment.UpperRight);
            double dispSD1ValLower = Math.Round(stats.Mean - stats.StDev, 2);
            double dispSD1ValUpper = Math.Round(stats.Mean + stats.StDev, 2);
            statSD1LowerVal.Text = "L bound: " + dispSD1ValLower.ToString();
            statSD1LowerVal.Location = new System.Drawing.Point(73, 104);
            statSD1UpperVal.Text = "U bound: " + dispSD1ValUpper.ToString();
            statSD1UpperVal.Location = new System.Drawing.Point(73, 124);
            statSD1UpperVal.Visible = true;
            plotGraph.Refresh();
        }

        public void standDev2(double[] valueArr)
        {
            var stats = new ScottPlot.Statistics.BasicStats(valueArr);
            plotGraph.Plot.AddVerticalLine(stats.Mean - stats.StDev * 2, Color.Black, 2, ScottPlot.LineStyle.Dot, "2 SD");
            plotGraph.Plot.AddVerticalLine(stats.Mean + stats.StDev * 2, Color.Black, 2, ScottPlot.LineStyle.Dot);
            plotGraph.Plot.Legend(location: ScottPlot.Alignment.UpperRight);
            double dispSD2ValLower = Math.Round(stats.Mean - stats.StDev * 2, 2);
            double dispSD2ValUpper = Math.Round(stats.Mean + stats.StDev * 2, 2);
            statSD2LowerVal.Text = "L bound: " + dispSD2ValLower.ToString();
            statSD2LowerVal.Location = new System.Drawing.Point(73, 169);
            statSD2UpperVal.Text = "U bound: " + dispSD2ValUpper.ToString();
            statSD2UpperVal.Location = new System.Drawing.Point(73, 189);
            statSD2UpperVal.Visible = true;
            plotGraph.Refresh();
        }

        public void minMaxLine(double[] valueArr)
        {
            var stats = new ScottPlot.Statistics.BasicStats(valueArr);
            plotGraph.Plot.AddVerticalLine(stats.Min, Color.Gray, 1, ScottPlot.LineStyle.Dash, "min/max");
            plotGraph.Plot.AddVerticalLine(stats.Max, Color.Gray, 1, ScottPlot.LineStyle.Dash);
            plotGraph.Plot.Legend(location: ScottPlot.Alignment.UpperRight);
            double dispMin = Math.Round(stats.Min, 2);
            double dispMax = Math.Round(stats.Max, 2);
            statMinVal.Text = dispMin.ToString();
            statMaxVal.Text = dispMax.ToString();
            plotGraph.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!guiRunning)
            {
                // Turn on GUI running flag
                guiRunning = true;
                //plot signal data

                if (signalGraphVolt.Checked && !histPlotTool.Checked)
                {   // converting voltage data array
                    // plotting on chart box
                    plotGraph.Plot.YLabel("Voltage");
                    signalGraphing(timeArrX, voltageArrY);
                }
                if (signalGraphCurr.Checked && !histPlotTool.Checked)
                {
                    // converting current data array
                    // plotting on chart box
                    plotGraph.Plot.YLabel("Current");
                    signalGraphing(timeArrX, currentArrY);
                }
                if (signalGraphPF.Checked && !histPlotTool.Checked)
                {
                    // converting power factor data array
                    // plotting on chart box
                    plotGraph.Plot.YLabel("Power Factor");
                    signalGraphing(timeArrX, pfArrY);
                }
                if (signalGraphFreq.Checked && !histPlotTool.Checked)
                {
                    // converting frequency data array
                    // plotting on chart box
                    plotGraph.Plot.YLabel("Frequency");
                }

                if (histPlotTool.Checked && signalGraphVolt.Checked && !signalGraphCurr.Checked && !signalGraphPF.Checked &&!signalGraphFreq.Checked)
                {
                    // creating histogram for voltage
                    // plotting on chart box
                    histogramGraph(voltageArrY);
                }
                if (meanPlotTool.Checked && signalGraphVolt.Checked && !signalGraphCurr.Checked && !signalGraphPF.Checked && !signalGraphFreq.Checked)
                {
                    meanLine(voltageArrY);
                }
                if (SD1PlotTool.Checked && signalGraphVolt.Checked && !signalGraphCurr.Checked && !signalGraphPF.Checked && !signalGraphFreq.Checked)
                {
                    standDev1(voltageArrY);
                    
                }
                if (SD2PlotTool.Checked && signalGraphVolt.Checked && !signalGraphCurr.Checked && !signalGraphPF.Checked && !signalGraphFreq.Checked)
                {
                    standDev2(voltageArrY);
                }
                if (minMaxPlotTool.Checked && signalGraphVolt.Checked && !signalGraphCurr.Checked && !signalGraphPF.Checked && !signalGraphFreq.Checked)
                {
                    minMaxLine(voltageArrY);
                }
                if (histPlotTool.Checked && !signalGraphVolt.Checked && signalGraphCurr.Checked && !signalGraphPF.Checked && !signalGraphFreq.Checked)
                {
                    // creating histogram for current
                    // plotting on chart box
                    histogramGraph(currentArrY);
                }
                if (meanPlotTool.Checked && signalGraphVolt.Checked && signalGraphCurr.Checked && !signalGraphPF.Checked && !signalGraphFreq.Checked)
                {
                    meanLine(currentArrY);
                }
                if (SD1PlotTool.Checked && !signalGraphVolt.Checked && signalGraphCurr.Checked && !signalGraphPF.Checked && !signalGraphFreq.Checked)
                {
                    standDev1(currentArrY);

                }
                if (SD2PlotTool.Checked && !signalGraphVolt.Checked && signalGraphCurr.Checked && !signalGraphPF.Checked && !signalGraphFreq.Checked)
                {
                    standDev2(currentArrY);
                }
                if (minMaxPlotTool.Checked && !signalGraphVolt.Checked && signalGraphCurr.Checked && !signalGraphPF.Checked && !signalGraphFreq.Checked)
                {
                    minMaxLine(currentArrY);
                }
                if (histPlotTool.Checked && !signalGraphVolt.Checked && !signalGraphCurr.Checked && signalGraphPF.Checked && !signalGraphFreq.Checked)
                {
                    // creating histogram for power factor
                    // plotting on chart box
                    histogramGraph(pfArrY);
                }
                if (meanPlotTool.Checked && !signalGraphVolt.Checked && !signalGraphCurr.Checked && signalGraphPF.Checked && !signalGraphFreq.Checked)
                {
                    meanLine(pfArrY);
                }
                if (SD1PlotTool.Checked && !signalGraphVolt.Checked && !signalGraphCurr.Checked && signalGraphPF.Checked && !signalGraphFreq.Checked)
                {
                    standDev1(pfArrY);

                }
                if (SD2PlotTool.Checked && !signalGraphVolt.Checked && !signalGraphCurr.Checked && signalGraphPF.Checked && !signalGraphFreq.Checked)
                {
                    standDev2(pfArrY);
                }
                if (minMaxPlotTool.Checked && !signalGraphVolt.Checked && !signalGraphCurr.Checked && signalGraphPF.Checked && !signalGraphFreq.Checked)
                {
                    minMaxLine(pfArrY);
                }
                if (histPlotTool.Checked && !signalGraphVolt.Checked && !signalGraphCurr.Checked && !signalGraphPF.Checked && signalGraphFreq.Checked)
                {
                    // creating histogram for frequency
                    // plotting on chart box
                    histogramGraph(freqArrY);
                }
                if (meanPlotTool.Checked && !signalGraphVolt.Checked && !signalGraphCurr.Checked && !signalGraphPF.Checked && signalGraphFreq.Checked)
                {
                    meanLine(freqArrY);
                }
                if (SD1PlotTool.Checked && !signalGraphVolt.Checked && !signalGraphCurr.Checked && !signalGraphPF.Checked && signalGraphFreq.Checked)
                {
                    standDev1(freqArrY);

                }
                if (SD2PlotTool.Checked && !signalGraphVolt.Checked && !signalGraphCurr.Checked && !signalGraphPF.Checked && signalGraphFreq.Checked)
                {
                    standDev2(freqArrY);
                }
                if (minMaxPlotTool.Checked && !signalGraphVolt.Checked && !signalGraphCurr.Checked && !signalGraphPF.Checked && signalGraphFreq.Checked)
                {
                    minMaxLine(freqArrY);
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
                statMeanVal.Text = "N/A";
                statSD1LowerVal.Text = "N/A";
                statSD2LowerVal.Text = "N/A";
                statMinVal.Text = "N/A";
                statMaxVal.Text = "N/A";
                statSD1LowerVal.Location = new System.Drawing.Point(111, 104);
                statSD2LowerVal.Location = new System.Drawing.Point(111, 169);
                statSD1UpperVal.Visible = false;
                statSD2UpperVal.Visible = false;
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
                    //dateTimeArr.Add(DateTime.ParseExact(tmp[0], "MM/dd/yyyy HH:mm:ss.fff", null));   //appending values to global lists
                    dateTimeArr.Add(DateTime.Parse(tmp[0]));
                    //timeArr.Add(Convert.ToDouble(tmp[0]));
                    voltageArr.Add(Convert.ToDouble(tmp[1]));
                    //currentArr.Add(Convert.ToDouble(tmp[2]));
                    //pfArr.Add(Convert.ToDouble(tmp[3]));
                    //freqArr.Add(Convert.ToDouble(tmp[4]));
                    //ce1Arr.Add(Convert.ToDouble(tmp[5]));
                    //ce24Arr.Add(Convert.ToDouble(tmp[6]));
                }
                timeArrX = dateTimeArr.Select(x => x.ToOADate()).ToArray();
                voltageArrY = voltageArr.ToArray();
                //currentArrY = currentArr.ToArray();
                //pfArrY = pfArr.ToArray();
                //freqArrY = freqArr.ToArray();
                txtStatus.Text = "Data is loaded and ready to plot."; //status update for completion
            }
            catch (Exception)
            {
                MessageBox.Show("Error in loading file.");
            }
        }

        private void getStartedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create a new instance of the Form2 class
            GettingStarted controls = new GettingStarted();

            // Show the settings form
            controls.Show();
        }

        private void capturePlotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string figureName = Interaction.InputBox("Save figure as: ", "Capture Plot", "", 500, 300);
            figureName = figureName + ".png";
            plotGraph.Plot.SaveFig(figureName);
        }
    }
}
