using OGLAD_UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace OGLAD_UI
{
    public partial class DeviceData : Form
    {
        public string DeviceName { get; set; }
        public string DeviceType { get; set; }
        public double avgAppPower { get; set; }
        public double avgActPower { get; set; }
        public double onTime { get; set; }
        public double offTime { get; set; }
        public double onAppPower { get; set; }
        public double onActPower { get; set; }
        public double offAppPower { get; set; }
        public double offActPower { get; set; }
        public double hourOn { get; set; }
        public double hourOff { get; set; }

        public override string ToString()
        {
            return DeviceName;
        }

        public DeviceData()
        {
            InitializeComponent();
        }
    }
}

//Form1 f = new Form1();
//avgAppPower = f.getAvgAppPower(); // total average apparent power
//avgActPower = f.getAvgActPower(); // total average active power
//onActPower = f.
//onAppPower = f.
//offAppPower = f.
//offActPower =  f.