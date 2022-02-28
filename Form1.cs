using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        private void Guardar(string fileName, string texto)
        {
            
            FileStream stream = new FileStream(fileName, FileMode.Append, FileAccess.Write);
           
            StreamWriter writer = new StreamWriter(stream);
            writer.WriteLine(texto);
            writer.Close();
        }
        private void buttonIr_Click(object sender, EventArgs e)
        {
            /*

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
           */
            string uri = "";

            if (comboBox1!=null)
                uri = comboBox1.Text;
            else if (comboBox1.SelectedItem!=null)
                uri=comboBox1.SelectedItem.ToString();

            if (!uri.Contains("."))
                uri = "https://www.google.com/search?q=" + uri;

            if (!uri.Contains("https://"))
                uri = "https://" + uri;

            webBrowser1.Navigate(new Uri(uri));
            comboBox1.Items.Add(uri);
            Guardar("Historial.txt", uri);

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
