using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void bunifuSwitch1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked==true)
            {

                this.BackColor = Color.FromArgb(54, 36, 49);
                Properties.Settings.Default.CommonFormBackColor = Color.FromArgb(54, 36, 49);
                Properties.Settings.Default.Save();
            }
            else
            {
                this.BackColor = Color.White;
                Properties.Settings.Default.CommonFormBackColor = Color.White;
                Properties.Settings.Default.Save();
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {

                this.BackColor = Color.FromArgb(54, 36, 49);
                Properties.Settings.Default.CommonFormBackColor = Color.FromArgb(54, 36, 49);
                Properties.Settings.Default.Save();
            }
            else
            {
                this.BackColor = Color.White;
                Properties.Settings.Default.CommonFormBackColor = Color.White;
                Properties.Settings.Default.Save();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            checkBox1.Checked = Properties.Settings.Default.checkbox;
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.checkbox = checkBox1.Checked;
            Properties.Settings.Default.Save();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuGradientPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        Point lastPoint;
        private void bunifuGradientPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not cleared, may be added later as a feature...", //message
                "This doesn't work xD", //title
                MessageBoxButtons.OK, //buttons at dialog given
                MessageBoxIcon.Information); //icon
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://docs.google.com/forms/d/e/1FAIpQLScVIa7NaYBSqXDUbIuylj4pXMZeCtLWJzjxXLneKJwrF0VeNw/viewform");
        }
    }
}
