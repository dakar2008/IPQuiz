using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPQuiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Thread trd = new Thread(new ThreadStart(SplashScreen));
            trd.Start();
            Thread.Sleep(6000);
            InitializeComponent();
            trd.Abort();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            RandomIPLabel.Text = Helper.GenerateRandomIP();
            Properties.Settings.Default.CurrentRandomIP = RandomIPLabel.Text;
            CorrectAnswerCounter.Text = Properties.Settings.Default.CorrentAnswersCounter.ToString();
            WrongAnswerCounter.Text = Properties.Settings.Default.WrongAnswersCounter.ToString();
            Properties.Settings.Default.Save();
        }

        private void SplashScreen()
        {
            Application.Run(new Splash());
        }

        private void newipbtn_Click(object sender, EventArgs e)
        {
            string newrandomip = Helper.GenerateRandomIP();
            RandomIPLabel.Text = newrandomip;
            Properties.Settings.Default.CurrentRandomIP = newrandomip;
            Properties.Settings.Default.Save();
        }

        private void UserInput_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if(UserInput.Text.Length == 35)
                {
                    GetResult();
                }
            }
        }
        public void GetResult()
        {
            string systemip = Properties.Settings.Default.CurrentRandomIP;
            string ReplaceCommaWithDot = UserInput.Text.Replace(',', '.');
            if (Helper.IsAnswerCorrect(systemip, ReplaceCommaWithDot))
            {
                CheckAnwerLabel.Text = "Korrekt Svar";
                CheckAnwerLabel.ForeColor = Color.Green;
                CheckAnwerLabel.Visible = true;
                CheckAnwerLabel.Size = new Size(913, 110);
                Properties.Settings.Default.CorrentAnswersCounter++;
                Properties.Settings.Default.Save();
                CorrectAnswerCounter.Text = Properties.Settings.Default.CorrentAnswersCounter.ToString();
            }
            else
            {
                CheckAnwerLabel.Text = "Forkert Svar, skulle havde været:";
                CheckAnwerLabel.ForeColor = Color.Red;
                CheckAnwerLabel.Size = new Size(913, 55);
                CheckAnwerLabel.Visible = true;
                AnswerResult.Text = Helper.ShowResult(systemip);
                AnswerResult.Visible = true;
                Properties.Settings.Default.WrongAnswersCounter++;
                Properties.Settings.Default.Save();
                WrongAnswerCounter.Text = Properties.Settings.Default.WrongAnswersCounter.ToString();
            }
            string newrandomip = Helper.GenerateRandomIP();
            Properties.Settings.Default.CurrentRandomIP = newrandomip;
            Properties.Settings.Default.Save();
            UserInput.Clear();
            UserInput.SelectAll();
            UserInput.Focus();
            RandomIPLabel.Text = Properties.Settings.Default.CurrentRandomIP;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CorrectAnswerCounter.Text = "0";
            WrongAnswerCounter.Text = "0";
            Properties.Settings.Default.CorrentAnswersCounter = 0;
            Properties.Settings.Default.WrongAnswersCounter = 0;
            Properties.Settings.Default.Save();
            string newrandomip = Helper.GenerateRandomIP();
            Properties.Settings.Default.CurrentRandomIP = newrandomip;
            Properties.Settings.Default.Save();
            CheckAnwerLabel.Visible = false;
            AnswerResult.Visible = false;
            UserInput.Clear();
            UserInput.SelectAll();
            UserInput.Focus();
            RandomIPLabel.Text = Properties.Settings.Default.CurrentRandomIP;
        }

        private void UserInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.D0) || e.KeyChar == Convert.ToChar(Keys.D1) || e.KeyChar == 13)
            {
                e.Handled = false;
            }
            else if(e.KeyChar == Convert.ToChar(Keys.Back))
            {
                e.Handled = false;
                UserInput.SelectAll();
                UserInput.Clear();
                UserInput.Focus();
            }
            else
            {
                e.Handled = true;
            }
        }

        private void UserInput_TextChanged(object sender, EventArgs e)
        {
            if (UserInput.Text.Length == 8)
            {
                UserInput.Text += ".";
                UserInput.SelectionStart = UserInput.Text.Length;
                UserInput.SelectionLength = 0;
            }
            if (UserInput.Text.Length == 17)
            {
                UserInput.Text += ".";
                UserInput.SelectionStart = UserInput.Text.Length;
                UserInput.SelectionLength = 0;
            }
            if (UserInput.Text.Length == 26)
            {
                UserInput.Text += ".";
                UserInput.SelectionStart = UserInput.Text.Length;
                UserInput.SelectionLength = 0;
            }
        }
    }
}