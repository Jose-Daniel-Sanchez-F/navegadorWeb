using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace navegadorWeb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonIr_Click(object sender, EventArgs e)
        {
          

            if(comboBox1.Text.Contains("https://"))
            {
                webBrowser1.Navigate(new Uri(comboBox1.Text.ToString()));
            }
            if(!comboBox1.Text.Contains("https://"))
            {
                if(comboBox1.Text.Contains(".com"))
                {
                    webBrowser1.Navigate(new Uri("https://"+comboBox1.Text.ToString()));

                }
            }
           if(!comboBox1.Text.Contains("https://"))
           {
                if (!comboBox1.Text.Contains(".com"))
                {
                    webBrowser1.Navigate(new Uri("https://www.google.com/search?q=" + comboBox1.Text.ToString()));
                }

            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }

        private void haciaAtrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void haciaAdelanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // comboBox1.SelectedIndex = 0;
         //  webBrowser1.GoHome();
        }
    }
}
