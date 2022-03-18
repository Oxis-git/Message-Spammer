using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Guna;

namespace Gui1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
                SendKeys.Send(guna2TextBox1.Text);
                SendKeys.Send("{Enter}");

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Clipboard.SetText(guna2TextBox3.Text);
            SendKeys.Send("^{v}");
            SendKeys.Send("{ENTER}");
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void timer5_Tick(object sender, EventArgs e)
        {
            SendKeys.Send(guna2TextBox1.Text);
            SendKeys.Send("{Enter}");
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            SendKeys.Send(guna2TextBox1.Text);
            SendKeys.Send("{Enter}");

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
          Application.Exit();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "txt files (*.txt)|*.txt";
            openFileDialog.InitialDirectory = Environment.CurrentDirectory;
            openFileDialog.RestoreDirectory = true;
            openFileDialog.Reset();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                guna2Button4.Enabled = false;
            }
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            timer3.Start();
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }


        private void guna2Button9_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            timer2.Stop();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            timer3.Stop();
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            Clipboard.SetText(Properties.Resources.TextFile1);
            SendKeys.Send("^{v}"); // Paste
            SendKeys.Send("{ENTER}"); // Enter
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2CircleButton23_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2CircleButton20_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2CircleButton17_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2CircleButton14_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2CircleButton15_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void guna2CircleButton18_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void guna2CircleButton21_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void guna2CircleButton24_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void guna2CircleButton22_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void guna2CircleButton19_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void guna2CircleButton16_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void guna2CircleButton13_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton26_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2CircleButton27_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void guna2CircleButton25_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Oxis-git");
        }
    }
}
 