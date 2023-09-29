using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoUpdaterDotNET;

namespace AutoUpdateTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            //AutoUpdater.InstalledVersion = new Version("1.2");
            //AutoUpdater.ShowSkipButton = false;
            //AutoUpdater.Mandatory = true;
            AutoUpdater.Mandatory = true;
            AutoUpdater.UpdateMode = Mode.Forced;
            AutoUpdater.Start("http://47.243.42.238:8888/down/ssytuGPGP9kW");
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
