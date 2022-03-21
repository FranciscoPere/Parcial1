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
                futbolistas.codigo = reader.ReadLine();
                futbolistas.fecha = reader.ReadLine();
                futbolistas.Equipo = reader.ReadLine();
                futbolistas.gol = Int32.Parse(reader.ReadLine());

                goles.Add(futbolistas);
            }

            reader.Close();
            mostrar();
        }
        public void mostrar()
        {

            dataGridView1.DataSource = null;
            dataGridView1.Refresh();

            dataGridView1.DataSource = goles;
            dataGridView1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ordenar();
            mostrar();
        }
        public void ordenar()
        {

            goles = goles.OrderByDescending(c => c.gol).ToList();

        }
    }
}
