using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.ActiveControl = bunifuMaterialTextbox1;
            bunifuMaterialTextbox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(bunifuMaterialTextbox1.Text);
        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void bunifuProgressBar1_progressChanged(object sender, EventArgs e)
        {

        }

        private void webBrowser1_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                webBrowser1.Navigate(bunifuMaterialTextbox1.Text);
            }
        }

        private void webBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            bunifuCustomLabel1.ForeColor = Color.Red;
            bunifuCustomLabel1.Text = "Loading...";
            while (true)
            {
                if (bunifuProgressBar1.Value >= 100)
                    break;
                bunifuProgressBar1.Value += 5;
            }
        }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            bunifuMaterialTextbox1.Text = webBrowser1.Url.ToString();
            bunifuCustomLabel1.ForeColor = Color.LimeGreen;
            bunifuCustomLabel1.Text = "Done!";
            bunifuProgressBar1.Value = 0;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void bunifuMaterialTextbox1_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
