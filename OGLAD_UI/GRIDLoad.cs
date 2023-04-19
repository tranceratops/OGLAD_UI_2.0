using ScottPlot.Plottable;
using ScottPlot;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace OGLAD_UI
{
    public partial class GRIDLoad : Form
    {
        private List<DeviceData> deviceDataList;
        private List<DeviceData> loadProfile = new List<DeviceData>();
        private bool changesMade = false;
        private string openedFilePath = string.Empty;

        double[] actGridPower = new double[24];
        double[] appGridPower = new double[24];
        string graphType;

        public GRIDLoad()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            SetupGraphLabels();
            updateLoadProfile();
        }

        public void SetupGraphLabels()
        {
            plotGraph.Plot.XLabel("Time (24-Hour)");
            plotGraph.Plot.YLabel("Power (W)");
            plotGraph.Plot.Title("Signal Graph");
        }

        private void GRIDLoad_Load(object sender, EventArgs e)
        {
            string signalType;
            updateLoadProfile();
            if (signalGraphActPower.Checked)
            {
                signalType = "Active Power";
                gridPowerDecipher();
                updateLoadProfile();
                signalGraphing(actGridPower, signalType);
            }
            if (signalGraphAppPower.Checked)
            {
                signalType = "Apparent Power";
                gridPowerDecipher();
                updateLoadProfile();
                signalGraphing(appGridPower, signalType);
            }
            updateLoadProfile();
            plotGraph.Refresh();
            // taking selected, formatted array and plotting the signal graph
        }

        private void signalGraphing(double[] valueArr, string signalType)
        {

            double[] gridTime = { 0, 1, 2, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24 };
            updateLoadProfile();
            var signal = plotGraph.Plot.AddSignalXY(gridTime, valueArr);

            switch (signalType)
            {
                case "Apparent Power":
                    signal.Color = Color.Blue;
                    signal.Label = "Apparent Power";
                    break;
                case "Active Power":
                    signal.Color = Color.Red;
                    signal.Label = "Active Power";
                    break;
                default:
                    signal.Color = Color.Black;
                    signal.Label = "Signal";
                    break;
            }

            //plotGraph.Plot.AddSignalXY(gridTime, valueArr);
            plotGraph.Plot.AxisAuto();

            plotGraph.Plot.SetOuterViewLimits(yMin: valueArr.Min() - (0.1) * valueArr.Max(),
            yMax: valueArr.Max() + (0.1) * valueArr.Max());

            plotGraph.Plot.XLabel("Time (24-Hour)");
            plotGraph.Plot.YLabel("Power (W)");
            plotGraph.Plot.Title("Micro-Grid Signal Graph");
            plotGraph.Plot.Legend();
            plotGraph.Refresh();
            graphType = "waveform";
        }

        private void gridPowerDecipher()
        {
            for (int i = 0; i < loadProfile.Count; i++)
            {
                DeviceData selectedDevice = loadProfile[i];

                if (selectedDevice.DeviceType == "Continuous")
                {
                    for (int j = (int)selectedDevice.hourOn; j <= (int)selectedDevice.hourOff; j++)
                    {
                        actGridPower[j] += selectedDevice.avgActPower;
                        appGridPower[j] += selectedDevice.avgAppPower;
                    }
                }

                if (selectedDevice.DeviceType == "Non-Continous")
                {
                    /*
                    double y = selectedDevice.onTime;
                    double y2 = selectedDevice.offTime;

                    y = (y /60) / 60;
                    y2 = (y2 / 60) / 60;
                    double k = selectedDevice.hourOn;
                    double x = selectedDevice.hourOff;
                    double v = x - k;

                    y = y + y2; // total time in hours for one cycle

                    v = v / y; // how many cycle in the range


                    //for future use on how to calculate the changes at each hour
                    
                    */
                    for (int p = (int)selectedDevice.hourOn; p < (int)selectedDevice.hourOff; p++)
                    {
                        if (p >= (int)selectedDevice.hourOn && p <= (int)selectedDevice.hourOff)
                        {
                            //double j = selectedDevice.onActPower + selectedDevice.offActPower;
                            //double u = selectedDevice.onAppPower + selectedDevice.offAppPower;

                            //j = (j + u) / 2;
                            actGridPower[p] += selectedDevice.onActPower;
                            appGridPower[p] += selectedDevice.onAppPower;
                            actGridPower[p] += selectedDevice.offActPower;
                            actGridPower[p] += selectedDevice.offAppPower;
                        }
                        else
                        {
                            actGridPower[p] += selectedDevice.offActPower;
                            appGridPower[p] += selectedDevice.offAppPower;
                        }
                    }
                }
            }

        }

        private void peakPowerHour()
        {

        }

        private void formsPlot1_Load(object sender, EventArgs e)
        {
            SetupGraphLabels();
        }

        private void hourOff_TextChanged(object sender, EventArgs e)
        {
            // Parse the hourOn value from the TextBox control's Text property
            if (int.TryParse(hourOff.Text, out int hourOffValue))
            {
                // Check if the hourOn value is within the valid range of 0 to 24
                if (hourOffValue >= 0 && hourOffValue <= 23)
                {
                    // Update the hourOn value of the selected device using the parsed value
                    int selectedIndex = displayLoadProfileView.SelectedIndices[0];
                    DeviceData selectedDevice = loadProfile[selectedIndex];
                    selectedDevice.hourOff = hourOffValue;
                }
                else
                {
                    // Display an error message indicating that the hourOn value is invalid
                    MessageBox.Show("HourOff value must be an integer between 0 and 23.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else if (!string.IsNullOrEmpty(hourOff.Text))
            {
                // Display an error message indicating that the hourOn value is invalid
                MessageBox.Show("HourOff value must be an integer between 0 and 23.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void hourOff_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Prevent the TextBox control from losing focus
                e.Handled = true;

                // Update the value of the selected device's hourOn field
                hourOn_TextChanged(sender, EventArgs.Empty);
                displayLoadProfileView_SelectedIndexChanged(sender, EventArgs.Empty);
                changesMade = true;
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            updateLoadProfile();
            plotGraph.Plot.Clear();
            plotGraph.Refresh();
            updateLoadProfile();
        }

        private void hourOn_TextChanged(object sender, EventArgs e)
        {
            // Parse the hourOn value from the TextBox control's Text property
            if (int.TryParse(hourOn.Text, out int hourOnValue))
            {
                // Check if the hourOn value is within the valid range of 0 to 24
                if (hourOnValue >= 0 && hourOnValue <= 23)
                {
                    // Update the hourOn value of the selected device using the parsed value
                    int selectedIndex = displayLoadProfileView.SelectedIndices[0];
                    DeviceData selectedDevice = loadProfile[selectedIndex];
                    selectedDevice.hourOn = hourOnValue;
                }
                else
                {
                    // Display an error message indicating that the hourOn value is invalid
                    MessageBox.Show("HourOn value must be an integer between 0 and 23.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else if (!string.IsNullOrEmpty(hourOn.Text))
            {
                // Display an error message indicating that the hourOn value is invalid
                MessageBox.Show("HourOn value must be an integer between 0 and 23.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void hourOn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Prevent the TextBox control from losing focus
                e.Handled = true;

                // Update the value of the selected device's hourOn field
                hourOn_TextChanged(sender, EventArgs.Empty);
                displayLoadProfileView_SelectedIndexChanged(sender, EventArgs.Empty);
                changesMade = true;
            }
        }

        private void displayLoadProfileView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (displayLoadProfileView.SelectedItems.Count > 0)
            {
                int selectedIndex = displayLoadProfileView.SelectedIndices[0];
                DeviceData selectedDevice = loadProfile[selectedIndex];


                // Update the hourOn TextBox control with the hourOn value of the selected device
                hourOn.Text = selectedDevice.hourOn.ToString();
                hourOff.Text = selectedDevice.hourOff.ToString();

                // Set focus to the hourOn TextBox control
                hourOff.Focus();

                displayLoadProfileDetails(selectedDevice);
            }
        }

        private void updateLoadProfile()
        {
            displayLoadProfileView.Items.Clear();
            foreach (var deviceData in loadProfile)
            {
                ListViewItem item = new ListViewItem(deviceData.DeviceName);
                item.SubItems.Add(deviceData.DeviceType);
                if (deviceData.DeviceType == "Continuous")
                {
                    item.SubItems.Add(deviceData.avgAppPower.ToString());
                    item.SubItems.Add(deviceData.avgActPower.ToString());
                    item.SubItems.Add(deviceData.hourOn.ToString());
                    item.SubItems.Add(deviceData.hourOff.ToString());
                    displayLoadProfileView.Items.Add(item);
                }
                else if (deviceData.DeviceType == "Non-continuous")
                {
                    item.SubItems.Add(deviceData.onTime.ToString());
                    item.SubItems.Add(deviceData.offTime.ToString());
                    item.SubItems.Add(deviceData.onAppPower.ToString());
                    item.SubItems.Add(deviceData.onActPower.ToString());
                    item.SubItems.Add(deviceData.offAppPower.ToString());
                    item.SubItems.Add(deviceData.offActPower.ToString());
                    item.SubItems.Add(deviceData.hourOn.ToString());
                    item.SubItems.Add(deviceData.hourOff.ToString());
                    displayLoadProfileView.Items.Add(item);
                }
            }
        }

        

        private void displayLoadProfileDetails(DeviceData loadProfileList)
        {
            displayLoadProfileData.Items.Clear();

            if (loadProfileList != null)
            {
                // Add items and subitems to the ListView based on the device type
                ListViewItem deviceName = new ListViewItem("Device Name");
                deviceName.SubItems.Add(loadProfileList.DeviceName);
                displayLoadProfileData.Items.Add(deviceName);

                ListViewItem deviceType = new ListViewItem("Device Type");
                deviceType.SubItems.Add(loadProfileList.DeviceType);
                displayLoadProfileData.Items.Add(deviceType);

                if (loadProfileList.DeviceType == "Continuous")
                {
                    ListViewItem avgAppPower = new ListViewItem("Average Apparent Power (W)");
                    avgAppPower.SubItems.Add(loadProfileList.avgAppPower.ToString());
                    displayLoadProfileData.Items.Add(avgAppPower);

                    ListViewItem avgActPower = new ListViewItem("Average Active Power (W)");
                    avgActPower.SubItems.Add(loadProfileList.avgActPower.ToString());
                    displayLoadProfileData.Items.Add(avgActPower);

                    ListViewItem hourOn = new ListViewItem("Hour On (24-Hour)");
                    hourOn.SubItems.Add(loadProfileList.hourOn.ToString());
                    displayLoadProfileData.Items.Add(hourOn);

                    ListViewItem hourOff = new ListViewItem("Hour Off (24-hour)");
                    hourOff.SubItems.Add(loadProfileList.hourOff.ToString());
                    displayLoadProfileData.Items.Add(hourOff);

                }
                else if (loadProfileList.DeviceType == "Non-continuous")
                {
                    ListViewItem onTime = new ListViewItem("On Time (sec)");
                    onTime.SubItems.Add(loadProfileList.onTime.ToString());
                    displayLoadProfileData.Items.Add(onTime);

                    ListViewItem offTime = new ListViewItem("Off Time (sec)");
                    offTime.SubItems.Add(loadProfileList.offTime.ToString());
                    displayLoadProfileData.Items.Add(offTime);

                    ListViewItem onAppPower = new ListViewItem("On Average Apparent Power (W)");
                    onAppPower.SubItems.Add(loadProfileList.onAppPower.ToString());
                    displayLoadProfileData.Items.Add(onAppPower);

                    ListViewItem onActPower = new ListViewItem("On Average Active Power (W)");
                    onActPower.SubItems.Add(loadProfileList.onActPower.ToString());
                    displayLoadProfileData.Items.Add(onActPower);

                    ListViewItem offAppPower = new ListViewItem("Off Average Apparent Power (W)");
                    offAppPower.SubItems.Add(loadProfileList.offAppPower.ToString());
                    displayLoadProfileData.Items.Add(offAppPower);

                    ListViewItem offActPower = new ListViewItem("Off Average Active Power (W)");
                    offActPower.SubItems.Add(loadProfileList.offActPower.ToString());
                    displayLoadProfileData.Items.Add(offActPower);

                    ListViewItem hourOn = new ListViewItem("Hour On (24-Hour)");
                    hourOn.SubItems.Add(loadProfileList.hourOn.ToString());
                    displayLoadProfileData.Items.Add(hourOn);

                    ListViewItem hourOff = new ListViewItem("Hour Off (24-hour)");
                    hourOff.SubItems.Add(loadProfileList.hourOff.ToString());
                    displayLoadProfileData.Items.Add(hourOff);

                }
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Check if a load profile is currently opened and changes are made in it
            while (changesMade == true)
            {
                if (changesMade == true)
                {
                    // Ask the user if they want to save changes
                    DialogResult result = MessageBox.Show("Do you want to save changes to the load profile?", "Save Changes", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        saveTool();
                        openedFilePath = null;
                        changesMade = false;
                    }

                    else if (result == DialogResult.No)
                    {
                        changesMade = false;
                    }
                }
            }

            // Clear the screen or reopen the library window
            displayLoadProfileView.Items.Clear();
            displayLoadProfileData.Items.Clear();
            hourOn.Text = null;
            hourOff.Text = null;
            loadProfile.Clear();
            changesMade = false;
            openedFilePath = null;
        }

        private void openLoadProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // open finder and open .csv file and populate displayLoadProfileView
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV Files|*.csv";
            openFileDialog.Title = "Select a Load Profile CSV File";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Read the CSV file and populate the loadProfile list
                    openedFilePath = openFileDialog.FileName;
                    using (var reader = new StreamReader(openedFilePath))
                    {
                        // Skip the header row
                        reader.ReadLine();

                        while (!reader.EndOfStream)
                        {
                            var line = reader.ReadLine();
                            var values = line.Split(',');
                            if (values.Length == 10)
                            {
                                string deviceName = values[0];
                                string deviceType = values[1];

                                DeviceData deviceDataAppend = new DeviceData();
                                deviceDataAppend.DeviceName = deviceName;
                                deviceDataAppend.DeviceType = deviceType;
                                ListViewItem item = new ListViewItem(deviceName);
                                item.Tag = deviceDataAppend;

                                if (deviceType == "Continuous")
                                {
                                    double avgAppPower = double.Parse(values[2]);
                                    double avgActPower = double.Parse(values[3]);
                                    deviceDataAppend.avgAppPower = avgAppPower;
                                    deviceDataAppend.avgActPower = avgActPower;
                                    loadProfile.Add(deviceDataAppend);
                                }

                                else if (deviceType == "Non-continuous")
                                {
                                    double onTime = double.Parse(values[4]);
                                    double offTime = double.Parse(values[5]);
                                    double onAppPower = double.Parse(values[6]);
                                    double onActPower = double.Parse(values[7]);
                                    double offAppPower = double.Parse(values[8]);
                                    double offActPower = double.Parse(values[9]);
                                    deviceDataAppend.onTime = onTime;
                                    deviceDataAppend.offTime = offTime;
                                    deviceDataAppend.onAppPower = onAppPower;
                                    deviceDataAppend.onActPower = onActPower;
                                    deviceDataAppend.offAppPower = offAppPower;
                                    deviceDataAppend.offActPower = offActPower;
                                    loadProfile.Add(deviceDataAppend);
                                }
                            }

                            else if (values.Length == 12)
                            {
                                string deviceName = values[0];
                                string deviceType = values[1];

                                DeviceData deviceDataAppend = new DeviceData();
                                deviceDataAppend.DeviceName = deviceName;
                                deviceDataAppend.DeviceType = deviceType;
                                ListViewItem item = new ListViewItem(deviceName);
                                item.Tag = deviceDataAppend;

                                if (deviceType == "Continuous")
                                {
                                    double avgAppPower = double.Parse(values[2]);
                                    double avgActPower = double.Parse(values[3]);
                                    double hourOn = double.Parse(values[10]);
                                    double hourOff = double.Parse(values[11]);
                                    deviceDataAppend.avgAppPower = avgAppPower;
                                    deviceDataAppend.avgActPower = avgActPower;
                                    deviceDataAppend.hourOn = hourOn;
                                    deviceDataAppend.hourOff = hourOff;
                                    loadProfile.Add(deviceDataAppend);
                                }

                                else if (deviceType == "Non-continuous")
                                {
                                    double onTime = double.Parse(values[4]);
                                    double offTime = double.Parse(values[5]);
                                    double onAppPower = double.Parse(values[6]);
                                    double onActPower = double.Parse(values[7]);
                                    double offAppPower = double.Parse(values[8]);
                                    double offActPower = double.Parse(values[9]);
                                    double hourOn = double.Parse(values[10]);
                                    double hourOff = double.Parse(values[11]);
                                    deviceDataAppend.onTime = onTime;
                                    deviceDataAppend.offTime = offTime;
                                    deviceDataAppend.onAppPower = onAppPower;
                                    deviceDataAppend.onActPower = onActPower;
                                    deviceDataAppend.offAppPower = offAppPower;
                                    deviceDataAppend.offActPower = offActPower;
                                    deviceDataAppend.hourOn = hourOn;
                                    deviceDataAppend.hourOff = hourOff;
                                    loadProfile.Add(deviceDataAppend);
                                }
                            }
                        }
                    }
                    // Update the displayLoadProfileView
                    updateLoadProfile();
                    changesMade = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void saveAsTool()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV files (*.csv)|*.csv";
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                // If the file name is not empty, save the file
                if (saveFileDialog.FileName != "")
                {
                    // Write the load profile data to the file
                    using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                    {
                        // Write the headers to the file
                        writer.WriteLine("DeviceName,DeviceType,avgAppPower(W),avgActPower(W),onTime(sec),offTime(sec),onAppPower(W),onActPower(W),offAppPower(W),offActPower(W),hourOn(hr),hourOff(hr)");

                        // Write each device data to the file
                        foreach (var deviceData in loadProfile)
                        {
                            if (deviceData.DeviceType == "Continuous")
                            {
                                writer.WriteLine("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11}", deviceData.DeviceName, deviceData.DeviceType, deviceData.avgAppPower, deviceData.avgActPower, null, null, null, null, null, null, deviceData.hourOn, deviceData.hourOff);
                            }

                            else if (deviceData.DeviceType == "Non-continuous")
                            {
                                writer.WriteLine("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11}", deviceData.DeviceName, deviceData.DeviceType, null, null, deviceData.onTime, deviceData.offTime,
                                    deviceData.onAppPower, deviceData.onActPower, deviceData.offAppPower, deviceData.offActPower, deviceData.hourOn, deviceData.hourOff);
                            }
                        }
                    }
                    MessageBox.Show("Profile saved successfully.");
                }
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveAsTool();
        }

        private void saveTool()
        {
            if (!string.IsNullOrEmpty(openedFilePath))
            {
                string filePath = openedFilePath;
                File.WriteAllText(filePath, string.Empty); // clear the file
                using (var writer = new StreamWriter(filePath))
                {
                    // Write the headers to the file
                    writer.WriteLine("DeviceName,DeviceType,avgAppPower(W),avgActPower(W),onTime(sec),offTime(sec),onAppPower(W),onActPower(W),offAppPower(W),offActPower(W),hourOn(hr),hourOff(hr)");

                    // Write each device data to the file
                    foreach (var deviceData in loadProfile)
                    {
                        if (deviceData.DeviceType == "Continuous")
                        {
                            writer.WriteLine("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11}", deviceData.DeviceName, deviceData.DeviceType, deviceData.avgAppPower, deviceData.avgActPower, null, null, null, null, null, null, deviceData.hourOn, deviceData.hourOff);
                        }

                        else if (deviceData.DeviceType == "Non-continuous")
                        {
                            writer.WriteLine("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11}", deviceData.DeviceName, deviceData.DeviceType, null, null, deviceData.onTime, deviceData.offTime,
                                deviceData.onAppPower, deviceData.onActPower, deviceData.offAppPower, deviceData.offActPower, deviceData.hourOn, deviceData.hourOff);
                        }
                    }
                }
                MessageBox.Show("Profile saved successfully.");
            }
            else
            {
                saveAsTool();
            }
        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            saveTool();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetImage(plotGraph.Plot.Render());
            MessageBox.Show("Plot has been copied.");
        }

        private void exportPlotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog pic = new SaveFileDialog();
            pic.Filter = "PNG|*.png";
            pic.FileName = "Capture";
            if (pic.ShowDialog() == DialogResult.OK)
            {
                plotGraph.Plot.SaveFig(pic.FileName);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            updateLoadProfile();
            //update other label with value of peak power.
        }

        private void displayLoadProfileData_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

//private void hourOn_Click(DeviceData loadProfileList) { }