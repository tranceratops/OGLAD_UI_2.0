//Load Analyzer GUI (LAGUI)
//Design and code done by Julian Saturno
//ScottPlot is licensed under the MIT License
//LAGUI
//Copyright 2022 goes to Julian Saturno for LAGUI design and code

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
using System.Globalization;
using System.Xml.Serialization;
using System.Xml;
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using Microsoft.VisualBasic.ApplicationServices;
using ScottPlot.Drawing.Colormaps;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms.DataVisualization.Charting;
using System.Text.RegularExpressions;
using System.Security.Permissions;

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
        List<double> leadLagArr = new List<double>();
        List<double> apparentArr = new List<double>();
        List<double> powerArr = new List<double>();

        List<DeviceData> deviceDataList = new List<DeviceData>();

        List<double> ce1Arr = new List<double>();
        List<double> ce24Arr = new List<double>();

        double[] timeArrX;
        double[] voltageArrY;
        double[] currentArrY;
        double[] pfArrY;
        double[] leadLagArrY;
        double[] apparentArrY;
        double[] powerArrY;
        double totAvgAppPower;
        double totAvgActPower;
        //double OnAvgAppPower;
        //double OnAvgActPower;
        //double OffAvgActPower;
        //double OffAvgAppPower;


        double histBinSize;
        double histBarWidth;

        int counter = 0;
        int countbotCE1 = 0;
        int countbotCE24 = 0;

        int leadLag0Count = 0;
        int leadLag1Count = 0;
        string leadlag;
        string powerFactor;
        string currGraph;

        int[] CE1IndexArr;
        int[] CE24IndexArr;

        double currMean;
        double currSD1Low;
        double currSD1Up;
        double currSD2Low;
        double currSD2Up;
        double currMin;
        double currMax;

        string graphType;
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
            // taking selected, formatted array and plotting the signal graph
            Array.Sort(tArr);
            plotGraph.Plot.AddSignalXY(tArr, valueArr);
            plotGraph.Plot.SetOuterViewLimits(yMin: valueArr.Min() - (0.1) * valueArr.Max(),
            yMax: valueArr.Max() + (0.1) * valueArr.Max());
            plotGraph.Plot.XAxis.DateTimeFormat(true);
            plotGraph.Plot.XLabel("Time");
            plotGraph.Plot.Title("Signal Graph");
            plotGraph.Refresh();
            graphType = "waveform";
        }

        public void histogramGraph(double[] valueArr)
        {
            //plotting histogram data
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
                                var bar = plotGraph.Plot.AddBar(values: counts, positions: leftEdges);
                                bar.BarWidth = histBarWidth;
                                plotGraph.Plot.YAxis.Label("Count (#)");
                                plotGraph.Plot.XAxis.Label(currGraph);
                                plotGraph.Plot.SetAxisLimits(yMin: 0);

                                double[] smoothEdges = ScottPlot.DataGen.Range(start: binEdges.First(), stop: binEdges.Last(), step: 0.1, includeStop: true);
                                double[] densities = ScottPlot.Statistics.Common.ProbabilityDensity(valueArr, smoothEdges);
                                plotGraph.Plot.AddScatterLines(xs: smoothEdges, ys: densities, color: Color.Black, lineWidth: 2, lineStyle: ScottPlot.LineStyle.Dash);

                                plotGraph.Plot.XAxis.DateTimeFormat(false);
                                plotGraph.Plot.SetOuterViewLimits(yMin: 0, yMax: double.PositiveInfinity);
                                plotGraph.Plot.AxisAuto();
                                plotGraph.Plot.Title("Histogram Representation");
                                plotGraph.Refresh();
                                graphType = "histogram";
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
                txtStatus.Text = "Invalid input. Please try again.";
            }

        }

        public void meanLine(double[] valueArr)
        {
            var stats = new ScottPlot.Statistics.BasicStats(valueArr);
            currMean = stats.Mean;
            plotGraph.Plot.AddVerticalLine(stats.Mean, Color.Black, 2, ScottPlot.LineStyle.Solid, "mean");
            plotGraph.Plot.Legend(location: ScottPlot.Alignment.UpperRight);
            double dispMeanVal = Math.Round(stats.Mean, 2);
            statMeanVal.Text = dispMeanVal.ToString();
            plotGraph.Refresh();
        }

        public void standDev1(double[] valueArr)
        {
            var stats = new ScottPlot.Statistics.BasicStats(valueArr);
            currSD1Low = stats.Mean - stats.StDev;
            currSD1Up = stats.Mean + stats.StDev;
            plotGraph.Plot.AddVerticalLine(stats.Mean - stats.StDev, Color.Black, 2, ScottPlot.LineStyle.Dash, "1 SD");
            plotGraph.Plot.AddVerticalLine(stats.Mean + stats.StDev, Color.Black, 2, ScottPlot.LineStyle.Dash);
            plotGraph.Plot.Legend(location: ScottPlot.Alignment.UpperRight);
            double dispSD1ValLower = Math.Round(stats.Mean - stats.StDev, 1);
            double dispSD1ValUpper = Math.Round(stats.Mean + stats.StDev, 1);
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
            currSD2Low = stats.Mean - stats.StDev * 2;
            currSD2Up = stats.Mean + stats.StDev * 2;
            plotGraph.Plot.AddVerticalLine(stats.Mean - stats.StDev * 2, Color.Black, 2, ScottPlot.LineStyle.Dot, "2 SD");
            plotGraph.Plot.AddVerticalLine(stats.Mean + stats.StDev * 2, Color.Black, 2, ScottPlot.LineStyle.Dot);
            plotGraph.Plot.Legend(location: ScottPlot.Alignment.UpperRight);
            double dispSD2ValLower = Math.Round(stats.Mean - stats.StDev * 2, 1);
            double dispSD2ValUpper = Math.Round(stats.Mean + stats.StDev * 2, 1);
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
            currMin = stats.Min;
            currMax = stats.Max;
            plotGraph.Plot.AddVerticalLine(stats.Min, Color.Gray, 1, ScottPlot.LineStyle.Dash, "min/max");
            plotGraph.Plot.AddVerticalLine(stats.Max, Color.Gray, 1, ScottPlot.LineStyle.Dash);
            plotGraph.Plot.Legend(location: ScottPlot.Alignment.UpperRight);
            double dispMin = Math.Round(stats.Min, 2);
            double dispMax = Math.Round(stats.Max, 2);
            statMinVal.Text = dispMin.ToString();
            statMaxVal.Text = dispMax.ToString();
            plotGraph.Refresh();
        }
        /*
        public void CECalculation(double[] valueArr, int[] indexArr, List<double> cumEnergy)
        {
            double currTotal = 0;
            int start = 0;
            foreach (int i in indexArr)
            {
                for (int j = start; j < i + 1; j++)
                {
                    currTotal += valueArr[j];
                }
                cumEnergy.Add(currTotal);
                currTotal = 0;
                start = i + 1;
            }
        }
        */

        //public double AvgPower(double[] valueArr1)
        //{
        //    double sum = 0;
        //    for (int i = 0; i < valueArr1.Length; i++)
        //    {
        //        sum += valueArr1[i];
        //    }
        //    double avgPower = sum / valueArr1.Length;
        //    return avgPower;
        //}

        public double avgPower(double[] valueArr)
        {
            double count = 0;
            double sum = 0;
            double pavg;

            foreach (double pnum in valueArr)
            {
                sum += pnum;
                count++;
            }
            pavg = sum / count; // check for zero count
            //return pavg;
            return Math.Round(pavg, 2); // round to 5 decimal place
        }

        public double offAVG(double[] valueArr1)
        {

            double avg = avgPower(valueArr1);
            double sumOff = 0;
            double avgOFF = 0;


            for (int j = 0; j < valueArr1.Length; j++)
            {
                if (valueArr1[j] < avg)
                {
                    sumOff += valueArr1[j];
                }
            }
            return avgOFF = sumOff / valueArr1.Length;
        }

        public double onAVG(double[] valueArr1)
        {
            double avg = avgPower(valueArr1);
            double sumOn = 0;
            double avgON = 0;


            for (int j = 0; j < valueArr1.Length; j++)
            {
                if (valueArr1[j] < avg)
                {
                    sumOn += valueArr1[j];
                }
            }
            return avgON = sumOn / valueArr1.Length;
        }

        public double getAvgAppPower()
        {
            return this.totAvgAppPower;
        }

        public double getAvgActPower()
        {
            return this.totAvgActPower;
        }


        public void leadLagComp(double[] valueArr)
        {
            foreach (double leadLagNum in valueArr)
            {
                if (leadLagNum == 0)
                {
                    leadLag0Count++;
                }
                else if (leadLagNum == 1)
                {
                    leadLag1Count++;
                }
            }
            if (leadLag0Count > leadLag1Count)
            {
                leadlag = "Leading";
            }
            else
            {
                leadlag = "Lagging";
            }
            statLeadLagVal.Text = leadlag;
            statLeadLagVal.Location = new System.Drawing.Point(102, 338);
        }

        public void pfComp(double[] valueArr)
        {
            double count = 0;
            double sum = 0;
            double pfavg;
            foreach (double pfnum in valueArr)
            {
                sum += pfnum;
                count++;
            }
            pfavg = sum / count;
            powerFactor = pfavg.ToString();
            statPFVal.Text = Math.Round(pfavg, 2).ToString();
            statPFVal.Location = new System.Drawing.Point(102, 399);
        }
        public void writeToTxt(string fileName)
        {
            using (StreamWriter sw = new StreamWriter(fileName))
            {
                string secondLine = currMean.ToString() + ", " + currSD1Low.ToString() + ", " + currSD1Up.ToString() + ", " + currSD2Low.ToString() + ", " + currSD2Up.ToString() + ", " + currMin.ToString() + ", " + currMax.ToString() + ", " + leadlag + ", " + powerFactor;
                sw.WriteLine("Mean, SD1 Lower, SD1 Upper, SD 2 Lower, SD 2 Upper, Minimum, Maximum, Leading/Lagging, Power Factor");
                sw.WriteLine(secondLine);
                sw.WriteLine("----------------------------");
                sw.WriteLine("Total Energy 1 Hr");
                foreach (double hourNum in ce1Arr)
                {
                    sw.WriteLine(hourNum.ToString());
                }
                sw.WriteLine("----------------------------");
                sw.WriteLine("Total Energy 24 Hr");
                foreach (double longHourNum in ce24Arr)
                {
                    sw.WriteLine(longHourNum.ToString());
                }
                sw.Flush();
                sw.Close();
            }
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
                    currGraph = "Voltage (V)";
                    plotGraph.Plot.YLabel(currGraph);
                    signalGraphing(timeArrX, voltageArrY);
                }
                if (signalGraphCurr.Checked && !histPlotTool.Checked)
                {
                    // converting current data array
                    // plotting on chart box
                    currGraph = "Current (A)";
                    plotGraph.Plot.YLabel(currGraph);
                    signalGraphing(timeArrX, currentArrY);
                }
                if (signalGraphPow.Checked && !histPlotTool.Checked)
                {
                    // converting power data array
                    // plotting on chart box
                    currGraph = "Power (VA)";
                    plotGraph.Plot.YLabel(currGraph);
                    signalGraphing(timeArrX, powerArrY);
                }
                if (histPlotTool.Checked && signalGraphVolt.Checked && !signalGraphCurr.Checked && !signalGraphPow.Checked)
                {
                    // creating histogram for voltage
                    // plotting on chart box
                    currGraph = "Voltage (V)";
                    histogramGraph(voltageArrY);
                }
                if (meanPlotTool.Checked && signalGraphVolt.Checked && !signalGraphCurr.Checked && !signalGraphPow.Checked)
                {
                    meanLine(voltageArrY);
                }
                if (SD1PlotTool.Checked && signalGraphVolt.Checked && !signalGraphCurr.Checked && !signalGraphPow.Checked)
                {
                    standDev1(voltageArrY);

                }
                if (SD2PlotTool.Checked && signalGraphVolt.Checked && !signalGraphCurr.Checked && !signalGraphPow.Checked)
                {
                    standDev2(voltageArrY);
                }
                if (minMaxPlotTool.Checked && signalGraphVolt.Checked && !signalGraphCurr.Checked && !signalGraphPow.Checked)
                {
                    minMaxLine(voltageArrY);
                }
                if (leadLagPlotTool.Checked && signalGraphVolt.Checked && !signalGraphCurr.Checked && !signalGraphPow.Checked)
                {
                    leadLagComp(leadLagArrY);
                }
                if (PFPlotTool.Checked && signalGraphVolt.Checked && !signalGraphCurr.Checked && !signalGraphPow.Checked)
                {
                    pfComp(pfArrY);
                }
                if (histPlotTool.Checked && !signalGraphVolt.Checked && signalGraphCurr.Checked && !signalGraphPow.Checked)
                {
                    // creating histogram for current
                    // plotting on chart box
                    currGraph = "Current (A)";
                    histogramGraph(currentArrY);
                }
                if (meanPlotTool.Checked && !signalGraphVolt.Checked && signalGraphCurr.Checked && !signalGraphPow.Checked)
                {
                    meanLine(currentArrY);
                }
                if (SD1PlotTool.Checked && !signalGraphVolt.Checked && signalGraphCurr.Checked && !signalGraphPow.Checked)
                {
                    standDev1(currentArrY);

                }
                if (SD2PlotTool.Checked && !signalGraphVolt.Checked && signalGraphCurr.Checked && !signalGraphPow.Checked)
                {
                    standDev2(currentArrY);
                }
                if (minMaxPlotTool.Checked && !signalGraphVolt.Checked && signalGraphCurr.Checked && !signalGraphPow.Checked)
                {
                    minMaxLine(currentArrY);
                }
                if (leadLagPlotTool.Checked && !signalGraphVolt.Checked && signalGraphCurr.Checked && !signalGraphPow.Checked)
                {
                    leadLagComp(leadLagArrY);
                }
                if (PFPlotTool.Checked && !signalGraphVolt.Checked && signalGraphCurr.Checked && !signalGraphPow.Checked)
                {
                    pfComp(pfArrY);
                }
                if (histPlotTool.Checked && !signalGraphVolt.Checked && !signalGraphCurr.Checked && signalGraphPow.Checked)
                {
                    // creating histogram for power
                    // plotting on chart box
                    currGraph = "Power (VA)";
                    histogramGraph(apparentArrY);
                }
                if (meanPlotTool.Checked && !signalGraphVolt.Checked && !signalGraphCurr.Checked && signalGraphPow.Checked)
                {
                    meanLine(apparentArrY);
                }
                if (SD1PlotTool.Checked && !signalGraphVolt.Checked && !signalGraphCurr.Checked && signalGraphPow.Checked)
                {
                    standDev1(apparentArrY);

                }
                if (SD2PlotTool.Checked && !signalGraphVolt.Checked && !signalGraphCurr.Checked && signalGraphPow.Checked)
                {
                    standDev2(apparentArrY);
                }
                if (minMaxPlotTool.Checked && !signalGraphVolt.Checked && !signalGraphCurr.Checked && signalGraphPow.Checked)
                {
                    minMaxLine(apparentArrY);
                }
                if (leadLagPlotTool.Checked && !signalGraphVolt.Checked && !signalGraphCurr.Checked && signalGraphPow.Checked)
                {
                    leadLagComp(leadLagArrY);
                }
                if (PFPlotTool.Checked && !signalGraphVolt.Checked && !signalGraphCurr.Checked && signalGraphPow.Checked)
                {
                    pfComp(pfArrY);
                }
                txtStatus.Text = "Plotting the " + graphType + " representation.";

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
                currentArr.Clear();
                pfArr.Clear();
                timeArr.Clear();
                ce1Arr.Clear();
                ce24Arr.Clear();
                plotGraph.Refresh();
                currMean = 0;
                currSD1Low = 0;
                currSD1Up = 0;
                currSD2Low = 0;
                currSD2Up = 0;
                currMin = 0;
                currMax = 0;
                leadlag = " ";
                statMeanVal.Text = "N/A";
                statSD1LowerVal.Text = "N/A";
                statSD2LowerVal.Text = "N/A";
                statMinVal.Text = "N/A";
                statMaxVal.Text = "N/A";
                statLeadLagVal.Text = "N/A";
                statPFVal.Text = "N/A";
                statLeadLagVal.Location = new System.Drawing.Point(111, 338);
                statSD1LowerVal.Location = new System.Drawing.Point(111, 104);
                statSD2LowerVal.Location = new System.Drawing.Point(111, 169);
                statSD1UpperVal.Visible = false;
                statSD2UpperVal.Visible = false;
                txtStatus.Text = "Plotting canvas is cleared.";

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

                string[] tmp;
                foreach (string s1 in readfile.Split('\n'))
                {
                    tmp = s1.Split(',');                  //create array for each row
                    if (tmp[0] == "")                     //null case for when CSV is fully read in
                        break;
                    if (!tmp[0].Any(x => !char.IsLetter(x)))
                        continue;
                    dateTimeArr.Add(DateTime.ParseExact(tmp[0], "MM/dd/yy HH:mm:ss.FFFFFF", CultureInfo.CurrentCulture));   //appending values to global lists
                    var resultCE1 = (dateTimeArr[counter] - dateTimeArr[countbotCE1]).TotalHours;     //getting the indexes of 1 hour marks
                    var resultCE24 = (dateTimeArr[counter] - dateTimeArr[countbotCE24]).TotalDays;   //getting the indexes of 24 hour marks
                    if (resultCE1 > 1)
                    {
                        CE1IndexArr.Append(counter);
                        countbotCE1 = counter;
                    }
                    if (resultCE24 > 1)
                    {
                        CE24IndexArr.Append(counter);
                        countbotCE24 = counter;
                    }
                    voltageArr.Add(Convert.ToDouble(tmp[1]));
                    currentArr.Add(Convert.ToDouble(tmp[2]));
                    pfArr.Add(Convert.ToDouble(tmp[3]));
                    leadLagArr.Add(Convert.ToDouble(tmp[4]));
                    apparentArr.Add(Convert.ToDouble(tmp[5]));
                    powerArr.Add(Convert.ToDouble(tmp[6]));
                    counter++;
                }
                timeArrX = dateTimeArr.Select(x => x.ToOADate()).ToArray();
                voltageArrY = voltageArr.ToArray();
                currentArrY = currentArr.ToArray();
                pfArrY = pfArr.ToArray();
                leadLagArrY = leadLagArr.ToArray();
                apparentArrY = apparentArr.ToArray();
                powerArrY = powerArr.ToArray();
                //var mean1 = new ScottPlot.Statistics.BasicStats(powerArrY);
                totAvgAppPower = avgPower(apparentArrY);//mean1;
                totAvgActPower = avgPower(powerArrY);
                txtStatus.Text = "Data is loaded and ready to plot."; //status update for completion
            }
            catch (Exception)
            {
                MessageBox.Show("Error in loading file.");
            }
        }
        private void PeakLoad(double[] valueArray1, double[] valueArray2)
        {
            //for (int = 0, i <= )
        }
        private void exportStatValuesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text File|*.txt";
            sfd.FileName = "statValues";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                writeToTxt(sfd.FileName);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PNG|*.png";
            sfd.FileName = "Capture";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                plotGraph.Plot.SaveFig(sfd.FileName);
            }
        }

        private void fullScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.WindowState = FormWindowState.Maximized;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetImage(plotGraph.Plot.Render());
            MessageBox.Show("Plot has been copied.");
        }

        private void openInNewWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ScottPlot.FormsPlotViewer(plotGraph.Plot).Show();
        }

        private void quickControlAssistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ScottPlot.FormHelp().Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void importingAFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create a new instance of the Form2 class
            GettingStarted controls = new GettingStarted();

            // Show the settings form
            controls.Show();
        }

        private void interactingWithDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create a new instance of the Form2 class
            Form3 controls = new Form3();

            // Show the settings form
            controls.Show();
        }

        private void fAQToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create a new instance of the Form2 class
            Form4 controls = new Form4();

            // Show the settings form
            controls.Show();
        }

        private void usingHistogramControlsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create a new instance of the Form2 class
            Form5 controls = new Form5();

            // Show the settings form
            controls.Show();
        }

        private void formattingExternalDataFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create a new instance of the Form2 class
            Form6 controls = new Form6();

            // Show the settings form
            controls.Show();
        }

        private void fAQToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Create a new instance of the Form2 class
            Form7 controls = new Form7();

            // Show the settings form
            controls.Show();
        }

        private void gridDesignToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GRIDLoad controls = new GRIDLoad();
            controls.Show();
        }

        private void libraryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Library controls = new Library(deviceDataList);
            controls.Show();
        }

        // User has ability to save a device's data without needing to graph it
        public void saveDeviceDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV files (*.csv)|*.csv";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                string path = Path.Combine(Directory.GetParent(Directory.GetParent(Application.StartupPath).FullName).FullName, "Resources", "deviceLibrary.csv");

                try
                {
                    if (!File.Exists(path))
                    {
                        using (StreamWriter writer = new StreamWriter(path))
                        {
                            writer.WriteLine("DeviceName,DeviceType,avgAppPower,avgActPower,onTime,offTime,onAppPower,onActPower,offAppPower,offActPower");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while saving the data. Error message: " + ex.Message);
                }

                string saveFilePath = path;

                // Get user input for device name and type
                string deviceName = "";
                bool deviceExists = false;
                Regex regex = new Regex("^[a-zA-Z0-9_]+$");

                do
                {
                    Form prompt = new Form();
                    prompt.StartPosition = FormStartPosition.CenterScreen;
                    prompt.Width = 380;
                    prompt.Height = 150;
                    prompt.Text = "Device Name";

                    Label deviceNameLabel = new Label() { Left = 50, Top = 20, Width = 150, Text = "Enter the device name:" };
                    TextBox deviceNameTextBox = new TextBox() { Left = 50, Top = 50, Width = 200 };

                    Button confirmButton = new Button() { Text = "OK", Left = 270, Width = 70, Top = 20 };
                    Button cancelButton = new Button() { Text = "Cancel", Left = 270, Width = 70, Top = 50 };
                    prompt.Controls.Add(deviceNameLabel);
                    prompt.Controls.Add(deviceNameTextBox);
                    prompt.Controls.Add(confirmButton);
                    prompt.Controls.Add(cancelButton);

                    confirmButton.Click += (s, args) =>
                    {
                        if (!regex.IsMatch(deviceNameTextBox.Text))
                        {
                            MessageBox.Show("Please enter a valid device name (letters, numbers, and underscores only).");
                        }
                        else
                        {
                            deviceName = deviceNameTextBox.Text;

                            using (var reader = new StreamReader(saveFilePath))
                            {
                                deviceExists = false;
                                while (!reader.EndOfStream)
                                {
                                    var line = reader.ReadLine();
                                    var values = line.Split(',');
                                    if (values[0] == deviceName)
                                    {
                                        deviceExists = true;
                                        break;
                                    }
                                }
                            }

                            if (deviceExists)
                            {
                                MessageBox.Show("A device with the same name already exists in the device library. Please enter a unique device name.");
                            }
                            else if (deviceName == "" || deviceName == " ")
                            {
                                MessageBox.Show("Please enter a valid device name.");
                            }
                            else
                            {
                                prompt.Close();
                            }
                        }
                    };

                    cancelButton.Click += (s, args) =>
                    {
                        prompt.Close();
                    };

                    if (prompt.ShowDialog() == DialogResult.Cancel)
                    {
                        break;
                    }

                    else
                    {
                        break;
                    }
                }
                while (deviceExists || deviceName == "");

                string[] deviceTypes = { "Continuous", "Non-continuous" };
                string deviceType = "";
                double avgAppPower;
                double avgActPower;
                double onTime = 0.0;
                double offTime = 0.0;
                double onAppPower;
                double onActPower;
                double offActPower;
                double offAppPower;

                try
                {
                    string readfile = File.ReadAllText(filePath);   //read in CSV file
                    string[] line = readfile.Split('\n');
                    line = line.Skip(1).ToArray();            //skip header line of CSV

                    string[] tmp;
                    foreach (string s1 in readfile.Split('\n'))
                    {
                        tmp = s1.Split(',');                  //create array for each row
                        if (tmp[0] == "")                     //null case for when CSV is fully read in
                            break;
                        if (!tmp[0].Any(x => !char.IsLetter(x)))
                            continue;

                        apparentArr.Add(Convert.ToDouble(tmp[5]));
                        powerArr.Add(Convert.ToDouble(tmp[6]));
                        counter++;
                    }
                    apparentArrY = apparentArr.ToArray();
                    powerArrY = powerArr.ToArray();
                }

                catch (Exception)
                {
                    MessageBox.Show("Error in loading file.");
                }

                if (string.IsNullOrEmpty(deviceName))
                {
                    return;
                }

                else
                {
                    DialogResult result = MessageBox.Show("Is the device continuous?", "Device Type", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        deviceType = "Continuous";
                        avgAppPower = avgPower(apparentArrY);
                        avgActPower = avgPower(powerArrY);

                        DeviceData deviceData = new DeviceData();
                        deviceData.DeviceName = deviceName;
                        deviceData.DeviceType = deviceType;
                        deviceData.avgAppPower = avgAppPower;
                        deviceData.avgActPower = avgActPower;
                        deviceDataList.Add(deviceData);

                        //Save device data to CSV file
                        using (StreamWriter sw = new StreamWriter(saveFilePath, true))
                        {
                            sw.WriteLine($"{deviceName},{deviceType},{avgAppPower},{avgActPower},null,null,null,null,null,null");
                        }

                        MessageBox.Show("The device has been saved!");
                    }

                    else if (result == DialogResult.No)
                    {
                        deviceType = "Non-continuous";

                        bool validInput = false;
                        while (!validInput)
                        {
                            // Show dialog box to get onTime and offTime
                            Form prompt = new Form();
                            prompt.StartPosition = FormStartPosition.CenterScreen;
                            prompt.Width = 350;
                            prompt.Height = 490;
                            prompt.Text = "Enter Device Data";

                            Label onLabel = new Label() { Left = 50, Top = 20, Width = 250, Text = "On Time (in seconds):" };
                            TextBox onTextBox = new TextBox() { Left = 50, Top = 50, Width = 200 };

                            Label offLabel = new Label() { Left = 50, Top = 80, Width = 250, Text = "Off Time (in seconds):" };
                            TextBox offTextBox = new TextBox() { Left = 50, Top = 110, Width = 200 };

                            Label onAppPowerLabel = new Label() { Left = 50, Top = 140, Width = 250, Text = "On Average Apparent Power:" };
                            TextBox onAppPowerTextBox = new TextBox() { Left = 50, Top = 170, Width = 200 };
                            //OnAvgAppPower = onAVG(apparentArrY);


                            Label onActPowerLabel = new Label() { Left = 50, Top = 200, Width = 250, Text = "On Average Active Power:" };
                            TextBox onActPowerTextBox = new TextBox() { Left = 50, Top = 230, Width = 200 };

                            //OnAvgActPower = onAVG(powerArrY);

                            Label offAppPowerLabel = new Label() { Left = 50, Top = 260, Width = 250, Text = "Off Average Apparent Power:" };
                            TextBox offAppPowerTextBox = new TextBox() { Left = 50, Top = 290, Width = 200 };

                            //OffAvgAppPower = offAVG(apparentArrY);

                            Label offActPowerLabel = new Label() { Left = 50, Top = 320, Width = 250, Text = "Off Average Active Power:" };
                            TextBox offActPowerTextBox = new TextBox() { Left = 50, Top = 350, Width = 200 };

                            //OffAvgActPower = offAVG(powerArrY);

                            Button confirmButton = new Button() { Text = "OK", Left = 70, Width = 70, Top = 410 };
                            Button cancelButton = new Button() { Text = "Cancel", Left = 150, Width = 70, Top = 410 };

                            confirmButton.Click += (s, args) =>
                            {
                                //Set onTime and offTime based on user input


                                if (!Double.TryParse(onTextBox.Text, out onTime))
                                {
                                    MessageBox.Show("Invalid input for On Time.");
                                    return;
                                }

                                else if (!Double.TryParse(offTextBox.Text, out offTime))
                                {
                                    MessageBox.Show("Invalid input for Off Time.");
                                    return;
                                }

                                else if (!Double.TryParse(onAppPowerTextBox.Text, out onAppPower))
                                {
                                    MessageBox.Show("Invalid input for On Average Apparent Power.");
                                    return;
                                }

                                else if (!Double.TryParse(onActPowerTextBox.Text, out onActPower))
                                {
                                    MessageBox.Show("Invalid input for On Average Active Power");
                                    return;
                                }

                                else if (!Double.TryParse(offAppPowerTextBox.Text, out offAppPower))
                                {
                                    MessageBox.Show("Invalid input for Off Average Apparent Power");
                                    return;
                                }

                                else if (!Double.TryParse(offActPowerTextBox.Text, out offActPower))
                                {
                                    MessageBox.Show("Invalid input for Off Average Active Power");
                                    return;
                                }

                                validInput = true;


                                MessageBox.Show("The device has been saved!");
                                prompt.Close();

                                DeviceData deviceData = new DeviceData();
                                deviceData.DeviceName = deviceName;
                                deviceData.DeviceType = deviceType;
                                deviceData.onTime = onTime; // set on-time for non-continuous device
                                deviceData.offTime = offTime; // set off-time for non-continuous device
                                deviceData.onAppPower = onAppPower;
                                deviceData.onActPower = onActPower;
                                deviceData.offAppPower = offAppPower;
                                deviceData.offActPower = offActPower;
                                deviceDataList.Add(deviceData);

                                //Save device data to CSV file

                                using (StreamWriter sw = new StreamWriter(saveFilePath, true))
                                {
                                    sw.WriteLine($"{deviceName},{deviceType},null,null,{onTime},{offTime},{onAppPower},{onActPower},{offAppPower},{offActPower}");
                                }
                            };

                            cancelButton.Click += (s, args) =>
                            {
                                prompt.DialogResult = DialogResult.Cancel;
                                prompt.Close();
                            };

                            prompt.Controls.Add(onLabel);
                            prompt.Controls.Add(onTextBox);

                            prompt.Controls.Add(offLabel);
                            prompt.Controls.Add(offTextBox);

                            prompt.Controls.Add(onAppPowerLabel);
                            prompt.Controls.Add(onAppPowerTextBox);

                            prompt.Controls.Add(onActPowerLabel);
                            prompt.Controls.Add(onActPowerTextBox);

                            prompt.Controls.Add(offAppPowerLabel);
                            prompt.Controls.Add(offAppPowerTextBox);

                            prompt.Controls.Add(offActPowerLabel);
                            prompt.Controls.Add(offActPowerTextBox);

                            prompt.Controls.Add(confirmButton);
                            prompt.Controls.Add(cancelButton);

                            DialogResult dialogResult = prompt.ShowDialog();

                            if (dialogResult == DialogResult.Cancel)
                            {
                                return;
                            }
                        }
                    }
                    else
                    {
                        //user clicked the close button or pressed Esc
                        return;
                    }
                }                 
            }
        }

        public void ConfirmButton_Click(object sender, EventArgs e)
        {
            Form prompt = (Form)sender;
            prompt.Close();
        }

        public void CancelButton_Click(object sender, EventArgs e)
        {
            Form prompt = (Form)((Button)sender).Parent;
            prompt.DialogResult = DialogResult.Cancel;
            prompt.Close();
        }

        //private void saveLibraryToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    SaveFileDialog saveFileDialog = new SaveFileDialog();
        //    saveFileDialog.Filter = "XML files (*.xml)|*.xml|JSON files (*.json)|*.json";

        //    if (saveFileDialog.ShowDialog() == DialogResult.OK)
        //    {
        //        string filePath = saveFileDialog.FileName;

        //        // serialize data to file
        //        if (Path.GetExtension(filePath) == ".xml")
        //        {
        //            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<DeviceData>));
        //            using (StreamWriter streamWriter = new StreamWriter(filePath))
        //            {
        //                xmlSerializer.Serialize(streamWriter, deviceDataList);
        //            }
        //        }
        //        else if (Path.GetExtension(filePath) == ".json")
        //        {
        //            JsonSerializerSettings jsonSerializerSettings = new JsonSerializerSettings();
        //            jsonSerializerSettings.Formatting = Newtonsoft.Json.Formatting.Indented;
        //            string json = JsonConvert.SerializeObject(deviceDataList, jsonSerializerSettings);
        //            File.WriteAllText(filePath, json);
        //        }
        //    }
        //}
    }
}
