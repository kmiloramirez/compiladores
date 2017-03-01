using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace compilador
{
    public partial class Form1 : Form
    {
        public string codigo;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] lineas;
            lineas = textBox1.Lines;
            codigo = "";
            for ( int i = 0; i < lineas.Length; i++)
            {
                codigo = codigo + (i + 1) + " " + lineas[i] + "\r\n";
                
            }
            textBox2.Text = codigo;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog buscar = new OpenFileDialog();
            if (buscar.ShowDialog() == DialogResult.OK)
            {
                StreamReader leer = new StreamReader(@buscar.FileName);
                codigo = "";
                int i = 1;
                while (!leer.EndOfStream)
                {
                    codigo = codigo + (i) + " " + leer.ReadLine() + "\r\n"; ++i;
                }
                textBox2.Text = codigo;

            }
        }
    }
}
