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

namespace Parcial1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextWriter writer = new StreamWriter(@"GolesAnotados.txt", true);
            writer.WriteLine(textBox1.Text);
            writer.WriteLine(dateTimePicker1.Text);
            writer.WriteLine(textBox2.Text);
            writer.WriteLine(textBox3.Text);
           
            writer.Close();
            limpiar();
        }
        public void limpiar() {

            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            GolesTotales Form2 = new GolesTotales();
            Form2.Closed += (s, args) => this.Close();
            Form2.ShowDialog();
        }
    }
}
