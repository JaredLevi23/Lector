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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Archivos de texto (*.txt)|*.txt";

            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                string linea;
                string texto ="";
                try {
                    string ruta = openFileDialog1.FileName;
                    label2.Text = ruta;
                    StreamReader sr = new StreamReader(ruta);
                    linea = sr.ReadLine();

                    while (linea != null) {
                        texto += linea + Environment.NewLine;
                        linea = sr.ReadLine();
                    }
                    sr.Close();
                    textBox1.Text = texto;

                }
                catch (Exception) {
                    MessageBox.Show("Algo salio mal");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //Open the File
                StreamWriter sw = new StreamWriter(label2.Text);
                //Writeout the numbers 1 to 10 on the same line.
                sw.Write(textBox1.Text);
                //close the file
                sw.Close();
            }
            catch (Exception)
            {
                Console.WriteLine("NO SE GUARDARON LOS CAMBIOS");
            }
        }
    }
}
