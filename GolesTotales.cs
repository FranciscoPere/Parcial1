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
    public partial class GolesTotales : Form
    {
        List<Futbolistas> goles = new List<Futbolistas>();
        public GolesTotales()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 principal = new Form1();
            principal.Closed += (s, args) => this.Close();
            principal.ShowDialog();
        }

        private void GolesTotales_Load(object sender, EventArgs e)
        {
            FileStream stream = new FileStream(@"GolesAnotados.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1)
            {
                Futbolistas futbolistas = new Futbolistas();
                futbolistas.

                goles.Add(Gol);
            }

            reader.Close();
        }
    }
}
