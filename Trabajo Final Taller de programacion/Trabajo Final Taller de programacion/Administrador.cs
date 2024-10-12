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
    public partial class Administrador : Form
    {
        public Administrador()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Listar_trabajadores mv = new Listar_trabajadores();
            mv.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Autentificación mv = new Autentificación();
            mv.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Insercion insercion = new Insercion();
            insercion.nombre = TexNombre.Text;
            insercion.rut = Convert.ToInt32 (TexRut.Text);
            insercion.Direcion = TexDirecion.Text;
            insercion.Telefono = Convert.ToInt32(TexTelefono.Text);
            insercion.ValorHora = Convert.ToInt32(TexValorHora.Text);
            insercion.ValorExtra = Convert.ToInt32(TexValorExtra.Text);

            int reust = ins.agregar(insercion);
            if (reust > 0)
            {
                MessageBox.Show("exito");
            }
            else
            {
                MessageBox.Show("fracaso");
            }
        }

        private void Administrador_Load(object sender, EventArgs e)
        {

        }
    }
}
