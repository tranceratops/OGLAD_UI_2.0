////using System;
////using System.Collections.Generic;
////using System.ComponentModel;
////using System.Data;
////using System.Drawing;
////using System.Linq;
////using System.Text;
////using System.Threading.Tasks;
////using System.Windows.Forms;

////namespace OGLAD_UI
////{
////    public partial class DeviceForm : Form
////    {
////        public DeviceForm()
////        {
////            InitializeComponent();
////        }
////    }
////}

//using System;
//using System.Windows.Forms;

//namespace OGLAD_UI
//{
//    public partial class DeviceForm : Form
//    {
//        public DeviceData DeviceData { get; set; }

//        public DeviceForm(DeviceData deviceData = null)
//        {
//            InitializeComponent();

//            if (deviceData == null)
//            {
//                DeviceData = new DeviceData();
//            }
//            else
//            {
//                DeviceData = deviceData;
//                PopulateFields();
//            }
//        }

//        private void PopulateFields()
//        {
//            textBox1.Text = DeviceData.DeviceName;
//            comboBox1.SelectedItem = DeviceData.DeviceType;
//            numPeakLoad.Value = DeviceData.peakLoad;
//            numDutyCycle.Value = DeviceData.dutyCycle;

//            if (DeviceData.averageLoad != null)
//            {
//                numAverageLoad1.Value = DeviceData.averageLoad[0].Value;
//                numAverageLoad2.Value = DeviceData.averageLoad[1].Value;
//                numAverageLoad3.Value = DeviceData.averageLoad[2].Value;
//            }
//        }

//        private void btnSave_Click(object sender, EventArgs e)
//        {
//            DeviceData.DeviceName = txtDeviceName.Text;
//            DeviceData.DeviceType = cmbDeviceType.SelectedItem.ToString();
//            DeviceData.peakLoad = numPeakLoad.Value;
//            DeviceData.dutyCycle = numDutyCycle.Value;

//            if (DeviceData.averageLoad == null)
//            {
//                DeviceData.averageLoad = new float?[3];
//            }

//            DeviceData.averageLoad[0] = numAverageLoad1.Value;
//            DeviceData.averageLoad[1] = numAverageLoad2.Value;
//            DeviceData.averageLoad[2] = numAverageLoad3.Value;

//            DialogResult = DialogResult.OK;
//            Close();
//        }

//        private void btnCancel_Click(object sender, EventArgs e)
//        {
//            DialogResult = DialogResult.Cancel;
//            Close();
//        }
//    }
//}

