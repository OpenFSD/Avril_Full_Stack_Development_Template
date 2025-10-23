using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TESTBENCH_Avril_FSD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("..\\..\\..\\APP_ServerAssembly\\bin\\x86\\Release\\net8.0\\APP_ServerAssembly.exe");
        }

        private void launcClient_Click(object sender, EventArgs e)
        {
            Process.Start("..\\..\\..\\APP_ClientAssembly\\bin\\x86\\Release\\net8.0\\APP_ClientAssembly.exe");
        }
    }
}
