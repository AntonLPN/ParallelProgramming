using System;
using System.Diagnostics;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParallelProgramming
{
    public partial class Task1 : Form
    {
        public Task1()
        {
            InitializeComponent();
            
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {

            ProcessStartInfo processStart = new ProcessStartInfo("ConsoleApp1");

            Process process = Process.Start(processStart);

            process.WaitForExit();
        }
    }
}
