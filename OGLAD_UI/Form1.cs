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

        List<double> ce1Arr = new List<double>();
        List<double> ce24Arr = new List<double>();

        double[] timeArrX;
        double[] voltageArrY;
        double[] currentArrY;
        double[] pfArrY;
        double[] leadLagArrY;
        double[] apparentArrY;
        double[] powerArrY;

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

        public void CECalculation(double[] valueArr, int[] indexArr, List<double> cumEnergy)
        {
            double currTotal = 0;
            int start = 0;
            foreach(int i in indexArr)
            {
                for(int j = start; j<i+1; j++)
                {
                    currTotal += valueArr[j];
                }
                cumEnergy.Add(currTotal);
                currTotal = 0;
                start = i + 1;
            }
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
                foreach(double hourNum in ce1Arr)
                {
                    sw.WriteLine(hourNum.ToString());
                }
                sw.WriteLine("----------------------------");
                sw.WriteLine("Total Energy 24 Hr");
                foreach(double longHourNum in ce24Arr)
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

                string [] tmp;
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
                txtStatus.Text = "Data is loaded and ready to plot."; //status update for completion
            }
            catch (Exception)
            {
                MessageBox.Show("Error in loading file.");
            }
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
    }
}
