using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabajo_Final_Taller_de_programacion
{
    public partial class Listar_trabajadores : Form
    {
        public Listar_trabajadores()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Listar_trabajadores_Load(object sender, EventArgs e)
        {
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.DataSource = ins.ListaRegistro();
        }

        private void registroSueldoDelTrabajadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registro_Sueldo_del_Trabajador mv = new Registro_Sueldo_del_Trabajador();
            mv.ShowDialog();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Autentificación mv = new Autentificación();
            mv.ShowDialog();
        }
    }
}
