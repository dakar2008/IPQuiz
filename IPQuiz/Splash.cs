using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPQuiz
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            Thread trd = new Thread(new ThreadStart(RunProgressbar));
            trd.Start();
        }
        private void RunProgressbar()
        {
            int counter = 100;
            for (int i = 0; i <= counter; i++)
            {
                progressBar1.Value = i;
                Thread.Sleep(50);
            }
        }
    }
}