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
        List<double> freqArr = new List<double>();
        List<double> powerArr = new List<double>();

        List<double> ce1Arr = new List<double>();
        List<double> ce24Arr = new List<double>();

        double[] timeArrX;
        double[] voltageArrY;
        double[] currentArrY;
        double[] pfArrY;
        double[] freqArrY;
        double[] powerArrY;

        double histBinSize;
        double histBarWidth;

        int counter = 0;
        int countbotCE1 = 0;
        int countbotCE24 = 0;

        int pf0count = 0;
        int pf1count = 0;
        string leadlag;

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
            plotGraph.Plot.YLabel(" ");
            plotGraph.Plot.Title("Signal Graph");
            plotGraph.Plot.XAxis.DateTimeFormat(true);
            signalGraphVolt.Checked = false;
            signalGraphCurr.Checked = false;
            signalGraphFreq.Checked = false;
            signalGraphPow.Checked = false;
            histPlotTool.Checked = false;
            meanPlotTool.Checked = false;
            SD1PlotTool.Checked = false;
            SD2PlotTool.Checked = false;
            minMaxPlotTool.Checked = false;
            leadLagPlotTool.Checked = false;
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
            currSD2Low = stats.Mean - stats.StDev * 2;
            currSD2Up = stats.Mean + stats.StDev * 2;
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
            foreach (double pfnum in valueArr)
            {
                if (pfnum == 0)
                {
                    pf0count++;
                }
                else if (pfnum == 1)
                {
                    pf1count++;
                }
            }
            if (pf0count > pf1count)
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
        
        public void writeToTxt(string fileName)
        {
            using (StreamWriter sw = new StreamWriter(fileName))
            {
                string secondLine = currMean.ToString() + ", " + currSD1Low.ToString() + ", " + currSD1Up.ToString() + ", " + currSD2Low.ToString() + ", " + currSD2Up.ToString() + ", " + currMin.ToString() + ", " + currMax.ToString() + ", " + leadlag;
                sw.WriteLine("Mean, SD1 Lower, SD1 Upper, SD 2 Lower, SD 2 Upper, Minimum, Maximum, Leading/Lagging");
                sw.WriteLine(secondLine);

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
                if (signalGraphFreq.Checked && !histPlotTool.Checked)
                {
                    // converting frequency data array
                    // plotting on chart box
                    plotGraph.Plot.YLabel("Frequency");
                }
                if (signalGraphPow.Checked && !histPlotTool.Checked)
                {
                    // converting power data array
                    // plotting on chart box
                    plotGraph.Plot.YLabel("Power");
                    signalGraphing(timeArrX, powerArrY);
                }
                if(signalGraphCE1.Checked && !histPlotTool.Checked)
                {
                    // converting cumulative energy data 1 hr array
                    // plotting on chart box
                    plotGraph.Plot.YLabel("Cumulative Energy 1 hour");
                    CECalculation(powerArrY, CE1IndexArr, ce1Arr);
                    //figure out x axis for CE graph

                }
                if (signalGraphCE24.Checked && !histPlotTool.Checked)
                {
                    // converting cumulative energy data 24 hr array
                    // plotting on chart box
                    plotGraph.Plot.YLabel("Cumulative Energy 24 hour");
                    CECalculation(powerArrY, CE24IndexArr, ce24Arr);
                    //figure out x axis for CE graph

                }
                if (histPlotTool.Checked && signalGraphVolt.Checked && !signalGraphCurr.Checked && !signalGraphFreq.Checked && !signalGraphPow.Checked)
                {
                    // creating histogram for voltage
                    // plotting on chart box
                    histogramGraph(voltageArrY);
                }
                if (meanPlotTool.Checked && signalGraphVolt.Checked && !signalGraphCurr.Checked && !signalGraphFreq.Checked && !signalGraphPow.Checked)
                {
                    meanLine(voltageArrY);
                }
                if (SD1PlotTool.Checked && signalGraphVolt.Checked && !signalGraphCurr.Checked && !signalGraphFreq.Checked && !signalGraphPow.Checked)
                {
                    standDev1(voltageArrY);
                    
                }
                if (SD2PlotTool.Checked && signalGraphVolt.Checked && !signalGraphCurr.Checked && !signalGraphFreq.Checked && !signalGraphPow.Checked)
                {
                    standDev2(voltageArrY);
                }
                if (minMaxPlotTool.Checked && signalGraphVolt.Checked && !signalGraphCurr.Checked && !signalGraphFreq.Checked && !signalGraphPow.Checked)
                {
                    minMaxLine(voltageArrY);
                }
                if (leadLagPlotTool.Checked && signalGraphVolt.Checked && !signalGraphCurr.Checked && !signalGraphFreq.Checked && !signalGraphPow.Checked)
                {
                    leadLagComp(pfArrY);
                }
                if (histPlotTool.Checked && !signalGraphVolt.Checked && signalGraphCurr.Checked && !signalGraphFreq.Checked && !signalGraphPow.Checked)
                {
                    // creating histogram for current
                    // plotting on chart box
                    histogramGraph(currentArrY);
                }
                if (meanPlotTool.Checked && signalGraphVolt.Checked && signalGraphCurr.Checked && !signalGraphFreq.Checked && !signalGraphPow.Checked)
                {
                    meanLine(currentArrY);
                }
                if (SD1PlotTool.Checked && !signalGraphVolt.Checked && signalGraphCurr.Checked && !signalGraphFreq.Checked && !signalGraphPow.Checked)
                {
                    standDev1(currentArrY);

                }
                if (SD2PlotTool.Checked && !signalGraphVolt.Checked && signalGraphCurr.Checked && !signalGraphFreq.Checked && !signalGraphPow.Checked)
                {
                    standDev2(currentArrY);
                }
                if (minMaxPlotTool.Checked && !signalGraphVolt.Checked && signalGraphCurr.Checked && !signalGraphFreq.Checked && !signalGraphPow.Checked)
                {
                    minMaxLine(currentArrY);
                }
                if (leadLagPlotTool.Checked && !signalGraphVolt.Checked && signalGraphCurr.Checked && !signalGraphFreq.Checked && !signalGraphPow.Checked)
                {
                    leadLagComp(pfArrY);
                }
                if (histPlotTool.Checked && !signalGraphVolt.Checked && !signalGraphCurr.Checked && signalGraphFreq.Checked && !signalGraphPow.Checked)
                {
                    // creating histogram for frequency
                    // plotting on chart box
                    histogramGraph(freqArrY);
                }
                if (meanPlotTool.Checked && !signalGraphVolt.Checked && !signalGraphCurr.Checked && signalGraphFreq.Checked && !signalGraphPow.Checked)
                {
                    meanLine(freqArrY);
                }
                if (SD1PlotTool.Checked && !signalGraphVolt.Checked && !signalGraphCurr.Checked && signalGraphFreq.Checked && !signalGraphPow.Checked)
                {
                    standDev1(freqArrY);

                }
                if (SD2PlotTool.Checked && !signalGraphVolt.Checked && !signalGraphCurr.Checked && signalGraphFreq.Checked && !signalGraphPow.Checked)
                {
                    standDev2(freqArrY);
                }
                if (minMaxPlotTool.Checked && !signalGraphVolt.Checked && !signalGraphCurr.Checked && signalGraphFreq.Checked && !signalGraphPow.Checked)
                {
                    minMaxLine(freqArrY);
                }
                if (leadLagPlotTool.Checked && !signalGraphVolt.Checked && !signalGraphCurr.Checked && signalGraphFreq.Checked && !signalGraphPow.Checked)
                {
                    leadLagComp(pfArrY);
                }
                if (histPlotTool.Checked && !signalGraphVolt.Checked && !signalGraphCurr.Checked && !signalGraphFreq.Checked && signalGraphPow.Checked)
                {
                    // creating histogram for power
                    // plotting on chart box
                    histogramGraph(powerArrY);
                }
                if (meanPlotTool.Checked && !signalGraphVolt.Checked && !signalGraphCurr.Checked && !signalGraphFreq.Checked && signalGraphPow.Checked)
                {
                    meanLine(powerArrY);
                }
                if (SD1PlotTool.Checked && !signalGraphVolt.Checked && !signalGraphCurr.Checked && !signalGraphFreq.Checked && signalGraphPow.Checked)
                {
                    standDev1(powerArrY);

                }
                if (SD2PlotTool.Checked && !signalGraphVolt.Checked && !signalGraphCurr.Checked && !signalGraphFreq.Checked && signalGraphPow.Checked)
                {
                    standDev2(powerArrY);
                }
                if (minMaxPlotTool.Checked && !signalGraphVolt.Checked && !signalGraphCurr.Checked && !signalGraphFreq.Checked && signalGraphPow.Checked)
                {
                    minMaxLine(powerArrY);
                }
                if (leadLagPlotTool.Checked && !signalGraphVolt.Checked && !signalGraphCurr.Checked && !signalGraphFreq.Checked && !signalGraphPow.Checked)
                {
                    leadLagComp(pfArrY);
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
                freqArr.Clear();
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
                    freqArr.Add(Convert.ToDouble(tmp[4]));
                    powerArr.Add(Convert.ToDouble(tmp[5]));
                    counter++;
                }
                timeArrX = dateTimeArr.Select(x => x.ToOADate()).ToArray();
                voltageArrY = voltageArr.ToArray();
                currentArrY = currentArr.ToArray();
                pfArrY = pfArr.ToArray();
                freqArrY = freqArr.ToArray();
                powerArrY = powerArr.ToArray();
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
            if (guiRunning)
            {
                guiRunning = false;
                plotGraph.Plot.Clear();
                voltageArr.Clear();
                currentArr.Clear();
                pfArr.Clear();
                freqArr.Clear();
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
                statLeadLagVal.Location = new System.Drawing.Point(111, 338);
                statSD1LowerVal.Location = new System.Drawing.Point(111, 104);
                statSD2LowerVal.Location = new System.Drawing.Point(111, 169);
                statSD1UpperVal.Visible = false;
                statSD2UpperVal.Visible = false;
                txtStatus.Text = "Ready for data read-in.";
                SetupGraphLabels();
                plotGraph.Refresh();

            }
            else
            {

            }
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
    }
}
