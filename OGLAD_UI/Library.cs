using System;
using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
//using CsvHelper;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;
//using OGLAD_UI;
//using System.Globalization;

namespace OGLAD_UI
{
    public partial class Library : Form
    {
        // gets device list from form1
        private List<DeviceData> deviceDataList;
        private List<DeviceData> loadProfile = new List<DeviceData>();
        private bool changesMade = false;
        private string openedFilePath = string.Empty;
        public Library(List<DeviceData> deviceList)
        {
            //read in the csv of the devices
            InitializeComponent();
            this.FormClosing += Library_Load;
            deviceDataList = deviceList; // replace with device list loaded from csv

            loadDeviceData();
            // initialize displayLoadProfile with load profile devices
            updateLoadProfile();
            updateDeviceList();
        }

        private void loadDeviceData()
        {
            string filePath = Path.Combine(Directory.GetParent(Directory.GetParent(Application.StartupPath).FullName).FullName, "Resources", "deviceLibrary.csv");
            if (File.Exists(filePath))
            {
                using (var reader = new StreamReader(filePath))
                {
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(',');
                        if (values.Length >= 10)
                        {
                            string deviceName = values[0];
                            string deviceType = values[1];

                            DeviceData deviceDataAppend = new DeviceData();
                            deviceDataAppend.DeviceName = deviceName;
                            deviceDataAppend.DeviceType = deviceType;

                            if (deviceType == "Continuous") {
                                double avgAppPower = double.Parse(values[2]);
                                double avgActPower = double.Parse(values[3]);
                                deviceDataAppend.avgAppPower = avgAppPower;
                                deviceDataAppend.avgActPower = avgActPower;
                                deviceDataList.Add(deviceDataAppend);
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
                                deviceDataList.Add(deviceDataAppend);
                            }
                        }
                    }
                }
            }
        }

        // gets string of device name
        public string getDeviceNameString(DeviceData deviceData)
        {
            //string deviceDataString = $"{deviceData.DeviceName}";
            //return deviceDataString;
            return deviceData.DeviceName;
        }

        private void updateDeviceList()
        {
            deviceDataList.Clear();
            loadDeviceData();
            displayDeviceListBox.Items.Clear();
            foreach (var deviceData in deviceDataList)
            {
                displayDeviceListBox.Items.Add(getDeviceNameString(deviceData));
            }
        }

        // displays selected device's details in list view
        private void DisplayDeviceDetails(DeviceData deviceData)
        {
            displayDeviceDataView.Items.Clear();

            if (deviceData != null)
            {
                // Add items and subitems to the ListView based on the device type
                ListViewItem deviceName = new ListViewItem("Device Name");
                deviceName.SubItems.Add(deviceData.DeviceName);
                displayDeviceDataView.Items.Add(deviceName);

                ListViewItem deviceType = new ListViewItem("Device Type");
                deviceType.SubItems.Add(deviceData.DeviceType);
                displayDeviceDataView.Items.Add(deviceType);

                if (deviceData.DeviceType == "Continuous")
                {
                    ListViewItem avgAppPower = new ListViewItem("Average Apparent Power (W)");
                    avgAppPower.SubItems.Add(deviceData.avgAppPower.ToString());
                    displayDeviceDataView.Items.Add(avgAppPower);

                    ListViewItem avgActPower = new ListViewItem("Average Active Power (W)");
                    avgActPower.SubItems.Add(deviceData.avgActPower.ToString());
                    displayDeviceDataView.Items.Add(avgActPower);
                }
                else if (deviceData.DeviceType == "Non-continuous")
                {
                    ListViewItem onTime = new ListViewItem("On Time (sec)");
                    onTime.SubItems.Add(deviceData.onTime.ToString());
                    displayDeviceDataView.Items.Add(onTime);

                    ListViewItem offTime = new ListViewItem("Off Time (sec)");
                    offTime.SubItems.Add(deviceData.offTime.ToString());
                    displayDeviceDataView.Items.Add(offTime);

                    ListViewItem onAppPower = new ListViewItem("On Average Apparent Power (W)");
                    onAppPower.SubItems.Add(deviceData.onAppPower.ToString());
                    displayDeviceDataView.Items.Add(onAppPower);

                    ListViewItem onActPower = new ListViewItem("On Average Active Power (W)");
                    onActPower.SubItems.Add(deviceData.onActPower.ToString());
                    displayDeviceDataView.Items.Add(onActPower);

                    ListViewItem offAppPower = new ListViewItem("Off Average Apparent Power (W)");
                    offAppPower.SubItems.Add(deviceData.offAppPower.ToString());
                    displayDeviceDataView.Items.Add(offAppPower);

                    ListViewItem offActPower = new ListViewItem("Off Average Active Power (W)");
                    offActPower.SubItems.Add(deviceData.offActPower.ToString());
                    displayDeviceDataView.Items.Add(offActPower);
                }
            }
        }

        // display the data information of devices when device is highlighted in listBox
        private void displayDeviceListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (displayDeviceListBox.SelectedIndex >= 0)
            {
                DeviceData selectedDevice = deviceDataList[displayDeviceListBox.SelectedIndex];
                DisplayDeviceDetails(selectedDevice);
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
                    displayLoadProfileView.Items.Add(item);
                }
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (displayDeviceListBox.SelectedIndex >= 0)
            {
                DeviceData selectedDevice = deviceDataList[displayDeviceListBox.SelectedIndex];
                loadProfile.Add(selectedDevice);
                changesMade = true;
                updateLoadProfile();
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (displayLoadProfileView.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in displayLoadProfileView.SelectedItems)
                {
                    int index = displayLoadProfileView.Items.IndexOf(item);
                    if (index >= 0 && index < loadProfile.Count)
                    {
                        loadProfile.RemoveAt(index);
                    }
                }
                changesMade = true;
                updateLoadProfile();
            }
        }

        private void deleteDeviceButton_Click(object sender, EventArgs e)
        {
            if (displayDeviceListBox.SelectedIndex >= 0)
            {
                var result = MessageBox.Show("Are you sure you want to delete this device?", "Delete Device", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    DeviceData selectedDevice = deviceDataList[displayDeviceListBox.SelectedIndex];

                    // Remove the device from deviceDataList
                    deviceDataList.Remove(selectedDevice);

                    // Remove the device from the CSV file
                    string filePath = Path.Combine(Directory.GetParent(Directory.GetParent(Application.StartupPath).FullName).FullName, "Resources", "deviceLibrary.csv");
                    var tempFile = Path.GetTempFileName();
                    using (var reader = new StreamReader(filePath))
                    using (var writer = new StreamWriter(tempFile))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            string[] values = line.Split(',');
                            if (selectedDevice.DeviceType == "Continuous")
                            {
                                if (values.Length >= 10 && values[0] == selectedDevice.DeviceName && values[1] == selectedDevice.DeviceType && values[2] == selectedDevice.avgAppPower.ToString() && values[3] == selectedDevice.avgActPower.ToString())
                                {
                                    // Skip the line corresponding to the deleted device
                                    continue;
                                }
                                writer.WriteLine(line);
                            }

                            else if (selectedDevice.DeviceType == "Non-continuous")
                            {
                                if (values.Length >= 10 && values[0] == selectedDevice.DeviceName && values[1] == selectedDevice.DeviceType && values[4] == selectedDevice.onTime.ToString() && values[5] == selectedDevice.offTime.ToString() 
                                    && values[6] == selectedDevice.onAppPower.ToString() && values[7] == selectedDevice.onActPower.ToString() && values[8] == selectedDevice.offAppPower.ToString() && values[9] == selectedDevice.offActPower.ToString())
                                {
                                    // Skip the line corresponding to the deleted device
                                    continue;
                                }
                                writer.WriteLine(line);
                            }
                            
                        }
                    }
                    File.Delete(filePath);
                    File.Move(tempFile, filePath);

                    // Remove the device from the displayDeviceListBox
                    displayDeviceListBox.Items.RemoveAt(displayDeviceListBox.SelectedIndex);

                    // Clear the device data view
                    displayDeviceDataView.Items.Clear();

                    updateDeviceList();
                }
            }

            else
            {
                return;
            }
        }

        private void saveLoadProfileAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveAsTool();
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
                        writer.WriteLine("DeviceName,DeviceType,avgAppPower(W),avgActPower(W),onTime(sec),offTime(sec),onAppPower(W),onActPower(W),offAppPower(W),offActPower(W)");

                        // Write each device data to the file
                        foreach (var deviceData in loadProfile)
                        {
                            if (deviceData.DeviceType == "Continuous")
                            {
                                writer.WriteLine("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9}", deviceData.DeviceName, deviceData.DeviceType, deviceData.avgAppPower, deviceData.avgActPower, null, null, null, null, null, null);
                            }

                            else if (deviceData.DeviceType == "Non-continuous")
                            {
                                writer.WriteLine("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9}", deviceData.DeviceName, deviceData.DeviceType, null, null, deviceData.onTime, deviceData.offTime,
                                    deviceData.onAppPower, deviceData.onActPower, deviceData.offAppPower, deviceData.offActPower);
                            }
                        }
                    }
                    MessageBox.Show("Load profile saved successfully.");
                }
            }
            changesMade = false;
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
                    writer.WriteLine("DeviceName,DeviceType,avgAppPower(W),avgActPower(W),onTime(sec),offTime(sec),onAppPower(W),onActPower(W),offAppPower(W),offActPower(W)");

                    // Write each device data to the file
                    foreach (var deviceData in loadProfile)
                    {
                        if (deviceData.DeviceType == "Continuous")
                        {
                            writer.WriteLine("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9}", deviceData.DeviceName, deviceData.DeviceType, deviceData.avgAppPower, deviceData.avgActPower, null, null, null, null, null, null);
                        }

                        else if (deviceData.DeviceType == "Non-continuous")
                        {
                            writer.WriteLine("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9}", deviceData.DeviceName, deviceData.DeviceType, null, null, deviceData.onTime, deviceData.offTime,
                                deviceData.onAppPower, deviceData.onActPower, deviceData.offAppPower, deviceData.offActPower);
                        }
                    }
                }
                MessageBox.Show("Load profile saved successfully.");
                changesMade = false;
            }
            else
            {
                saveAsTool();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveTool();
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
                            if (values.Length == 10 || values.Length == 12)
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
            loadProfile.Clear();
            changesMade = false;
            openedFilePath = null;

            // Check if there are any devices in the displayLoadProfileView
            if (displayLoadProfileView.Items.Count > 0)
            {
                // Ask the user if they want to save their work
                DialogResult result = MessageBox.Show("Do you want to save your work?", "Save Work", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    // Save changes and clear the screen
                    saveAsTool();
                }
            }
        }

        private void displayLoadProfileView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (displayLoadProfileView.SelectedItems.Count > 0)
            {
                int selectedIndex = displayLoadProfileView.SelectedIndices[0];
                DeviceData selectedDevice = loadProfile[selectedIndex];
                displayLoadProfileDetails(selectedDevice);
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
                }
            }
        }

        // If edits were made to load profile, ask user to save before exiting
        private void Library_Load(object sender, FormClosingEventArgs e)
        {
            if (changesMade == true)
            {
                // ask user if they want to save changes
                DialogResult result = MessageBox.Show("Do you want to save changes to the load profile?", "Save Changes", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    // save changes and close window
                    saveTool();
                    openedFilePath = null;
                }

                else if (result == DialogResult.No)
                {
                    // close window without saving changes
                    Console.WriteLine("Closing window without saving changes");
                    changesMade = false;
                    e.Cancel = false;
                    this.Close();
                    openedFilePath = null;
                }
                else
                {
                    // cancel closing the window
                    Console.WriteLine("Cancelling window close");
                    e.Cancel = true;
                    openedFilePath = null;
                }
            }
        }
    }
}

//saveAs
//if (!string.IsNullOrEmpty(openedFilePath))
//{
//    string filePath = openedFilePath;
//    File.WriteAllText(filePath, string.Empty); // clear the file
//    using (var writer = new StreamWriter(filePath))
//    {
//        // Write the headers to the file
//        writer.WriteLine("DeviceName,DeviceType,avgAppPower,avgActPower,onTime,offTime,onAppPower,onActPower,offAppPower,offActPower");

//        // Write each device data to the file
//        foreach (var deviceData in loadProfile)
//        {
//            if (deviceData.DeviceType == "Continuous")
//            {
//                writer.WriteLine("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9}", deviceData.DeviceName, deviceData.DeviceType, deviceData.avgAppPower, deviceData.avgActPower, null, null, null, null, null, null);
//            }

//            else if (deviceData.DeviceType == "Non-continuous")
//            {
//                writer.WriteLine("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9}", deviceData.DeviceName, deviceData.DeviceType, null, null, deviceData.onTime, deviceData.offTime,
//                    deviceData.onAppPower, deviceData.onActPower, deviceData.offAppPower, deviceData.offActPower);
//            }
//        }
//    }
//}
//else
//{
//    SaveFileDialog saveFileDialog = new SaveFileDialog();
//    saveFileDialog.Filter = "CSV files (*.csv)|*.csv";
//    saveFileDialog.RestoreDirectory = true;

//    if (saveFileDialog.ShowDialog() == DialogResult.OK)
//    {
//        string filePath = saveFileDialog.FileName;

//        // If the file name is not empty, save the file
//        if (saveFileDialog.FileName != "")
//        {
//            // Write the load profile data to the file
//            using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
//            {
//                // Write the headers to the file
//                writer.WriteLine("DeviceName,DeviceType,avgAppPower,avgActPower,onTime,offTime,onAppPower,onActPower,offAppPower,offActPower");

//                // Write each device data to the file
//                foreach (var deviceData in loadProfile)
//                {
//                    if (deviceData.DeviceType == "Continuous")
//                    {
//                        writer.WriteLine("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9}", deviceData.DeviceName, deviceData.DeviceType, deviceData.avgAppPower, deviceData.avgActPower, null, null, null, null, null, null);
//                    }

//                    else if (deviceData.DeviceType == "Non-continuous")
//                    {
//                        writer.WriteLine("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9}", deviceData.DeviceName, deviceData.DeviceType, null, null, deviceData.onTime, deviceData.offTime,
//                            deviceData.onAppPower, deviceData.onActPower, deviceData.offAppPower, deviceData.offActPower);
//                    }
//                }
//            }

//            MessageBox.Show("Load profile saved successfully.");
//        }
//    }
//}


//if (displayLoadProfileView.SelectedItems.Count > 0)
//{
//    foreach (ListViewItem item in displayLoadProfileView.SelectedItems)
//    {
//        DeviceData deviceToRemove = loadProfile.FirstOrDefault(d => d.DeviceName == item.SubItems[0].Text);
//        if (deviceToRemove != null)
//        {
//            loadProfile.Remove(deviceToRemove);
//        }
//    }
//    changesMade = true;
//    updateLoadProfile();
//}
//}

//private void saveToolStripMenuItem_Click(object sender, EventArgs e)
//{
//    SaveFileDialog saveFileDialog = new SaveFileDialog();
//    saveFileDialog.Filter = "CSV file (*.csv)|*.csv";
//    if (saveFileDialog.ShowDialog() == DialogResult.OK)
//    {
//        string fileName = saveFileDialog.FileName;
//        SaveLoadProfileDataToCSV(fileName);
//    }
//}

//private void SaveLoadProfileDataToCSV(string fileName)
//{
//    StringBuilder sb = new StringBuilder();
//    foreach (var deviceData in loadProfile)
//    {
//        if (deviceData.DeviceType == "Continuous")
//        {
//            sb.AppendLine("Device Name,Device Type,Average Apparent Power, Average Active Power");
//            sb.AppendLine($"{deviceData.DeviceName},{deviceData.DeviceType},{deviceData.avgAppPower},{deviceData.avgActPower}");
//        }

//        else if (deviceData.DeviceType == "Non-continuous")
//        {
//            sb.AppendLine("Device Name,Device Type,On Time,Off Time,On Average Apparent Power,On Average Active" +
//                "Power,Off Average Apparent Power, Off Average Active");
//            sb.AppendLine($"{deviceData.DeviceName},{deviceData.DeviceType},{deviceData.onTime},{deviceData.offTime}," +
//                $"{deviceData.onAppPower},{deviceData.onActPower},{deviceData.offAppPower},{deviceData.offActPower}");
//        }
//    }
//    File.WriteAllText(fileName, sb.ToString());
//}

//public string GetDeviceDataString(DeviceData deviceData)
//{
//    string deviceDataString = $"Device Name: {deviceData.DeviceName}\n";
//    deviceDataString += $"Device Type: {deviceData.DeviceType}\n";
//    deviceDataString += $"Peak Load: {deviceData.peakLoad}\n";
//    deviceDataString += $"Duty Cycle: {deviceData.dutyCycle}\n";
//    deviceDataString += "Average Load: ";
//    if (deviceData.averageLoad != null)
//    {
//        for (int i = 0; i < deviceData.averageLoad.Length; i++)
//        {
//            if (deviceData.averageLoad[i] != null)
//            {
//                deviceDataString += $"{deviceData.averageLoad[i]} ";
//            }
//        }
//    }
//    return deviceDataString;
//}

//public void ShowDeviceDataList()
//{
//    if (deviceDataList.Count == 0)
//    {
//        MessageBox.Show("No devices have been saved yet.");
//        return;
//    }

//    string deviceDataListString = "Saved Devices:\n";
//    for (int i = 0; i < deviceDataList.Count; i++)
//    {
//        deviceDataListString += $"Device {i + 1}:\n";
//        deviceDataListString += GetDeviceDataString(deviceDataList[i]);
//        deviceDataListString += "\n";
//    }
//    MessageBox.Show(deviceDataListString);
//}

//if (deviceDataList.Count == 0)
//{
//    MessageBox.Show("No devices have been saved yet.");
//    return;
//}

//for (int i = 0; i < deviceDataList.Count; i++)
//{
//    displayDeviceListBox.Items.Add(getDeviceNameString(deviceDataList[i]));
//}

//public void AddDeviceToListBox(DeviceData deviceData)
//{
//    if (deviceDataList.Count == 0)
//    {
//        MessageBox.Show("No devices have been saved yet.");
//        return;
//    }

//    displayDeviceListBox.Items.Add(getDeviceNameString(deviceData));
//}

//public void UpdateListBox(List<DeviceData> deviceDataList)
//{
//    displayDeviceListBox.Items.Clear();
//    foreach (DeviceData deviceData in deviceDataList)
//    {
//        displayDeviceListBox.Items.Add(getDeviceNameString(deviceData));
//    }
//}

//private void newToolStripMenuItem_Click(object sender, EventArgs e) { }

//// adds device from list to the display in library
//private void displayDeviceListBox_SelectedIndexChanged(object sender, EventArgs e)
//{
//    if (deviceDataList.Count == 0)
//    {
//        MessageBox.Show("No devices have been saved yet.");
//        return;
//    }

//    for (int i = 0; i < deviceDataList.Count; i++)
//    {
//        displayDeviceListBox.Items.Add(getDeviceNameString(deviceDataList[i]));
//    }
//}

//// adds a new device to the catalog
//private void AddNewDeviceToolStripMenuItem_Click(object sender, EventArgs e)
//{
//    var deviceForm = new deviceForm();
//    deviceForm.ShowDialog();

//    if (deviceForm.DialogResult == DialogResult.OK)
//    {
//        addDeviceToList(deviceForm.DeviceData);
//    }
//}

//// updates the selected device's details in the catalog
//private void EditDeviceToolStripMenuItem_Click(object sender, EventArgs e)
//{
//    if (displayDeviceListBox.SelectedItem == null)
//    {
//        MessageBox.Show("Please select a device to edit.");
//        return;
//    }

//    var deviceData = deviceDataList[displayDeviceListBox.SelectedIndex];
//    var deviceForm = new DeviceForm(deviceData);
//    deviceForm.ShowDialog();

//    if (deviceForm.DialogResult == DialogResult.OK)
//    {
//        deviceDataList[displayDeviceListBox.SelectedIndex] = deviceForm.DeviceData;
//        updateDeviceList();
//        DisplayDeviceDetails(deviceDataList[displayDeviceListBox.SelectedIndex]);
//    }
//}


//private void addDeviceToList(DeviceData deviceData)
//{
//    deviceDataList.Add(deviceData);
//    updateDeviceList();
//}

//if (displayDeviceListBox.SelectedIndex >= 0)
//{
//    DeviceData selectedDevice = deviceDataList[displayDeviceListBox.SelectedIndex];
//    ListViewItem item = new ListViewItem(selectedDevice.DeviceName);

//    if (selectedDevice.DeviceType == "Continuous")
//    {
//        item.SubItems.Add(selectedDevice.DeviceType);
//        item.SubItems.Add(selectedDevice.avgAppPower.ToString());
//        item.SubItems.Add(selectedDevice.avgActPower.ToString());
//    }

//    else if (selectedDevice.DeviceType == "Non-continuous")
//    {
//        item.SubItems.Add(selectedDevice.DeviceType);
//        item.SubItems.Add(selectedDevice.onTime.ToString());
//        item.SubItems.Add(selectedDevice.offTime.ToString());
//        item.SubItems.Add(selectedDevice.onAppPower.ToString());
//        item.SubItems.Add(selectedDevice.onActPower.ToString());
//        item.SubItems.Add(selectedDevice.offAppPower.ToString());
//        item.SubItems.Add(selectedDevice.offActPower.ToString());
//    }

//    displayDeviceDataView.Items.Add(item);
//    //displayDeviceDataView.Items.Clear();
//    //displayDeviceDataView.Items.Add(item);
//}

//private void addToLibraryButton_Click(object sender, EventArgs e)
//{
//    Form1 mainForm = new Form1();
//    mainForm.saveDeviceDataToolStripMenuItem_Click(sender, e);
//    updateDeviceList();
//}

// deletes the selected device from the catalog
//private void DeleteDeviceToolStripMenuItem_Click(object sender, EventArgs e)
//{
//    if (displayDeviceListBox.SelectedItem == null)
//    {
//        MessageBox.Show("Please select a device to delete.");
//        return;
//    }

//    var result = MessageBox.Show("Are you sure you want to delete this device?", "Delete Device", MessageBoxButtons.YesNo);

//    if (result == DialogResult.Yes)
//    {
//        deviceDataList.RemoveAt(displayDeviceListBox.SelectedIndex);
//        updateDeviceList();
//        //displayDeviceDataView.Items.Clear();
//    }
//}

//deviceDataList.RemoveAt(displayDeviceListBox.SelectedIndex);
//    string device = displayDeviceDataView.SelectedItems[0].Text;

//    // remove the device from the displayDeviceListBox
//    displayDeviceListBox.Items.RemoveAt(displayDeviceListBox.SelectedIndex);

//    // clear the device data view
//    displayDeviceDataView.Items.Clear();

//    updateDeviceList();

//    // remove the device from the deviceLibrary.csv file
//    string filePath = Path.Combine(Directory.GetParent(Directory.GetParent(Application.StartupPath).FullName).FullName, "Resources", "deviceLibrary.csv");
//    if (File.Exists(filePath))
//    {
//        string[] lines = File.ReadAllLines(filePath);
//        for (int i = 0; i < lines.Length; i++)
//        {
//            string[] values = lines[i].Split(',');
//            if (values.Length >= 4 && values[0] == device.DeviceName && values[1] == deviceData.DeviceType && values[2] == deviceData.AvgAppPower.ToString() && values[3] == deviceData.AvgActPower.ToString())
//            {
//                lines.ToList().RemoveAt(i);
//                break;
//            }
//        }
//        File.WriteAllLines(filePath, lines);
//    }

//}