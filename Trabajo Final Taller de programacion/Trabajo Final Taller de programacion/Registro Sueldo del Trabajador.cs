using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabajo_Final_Taller_de_programacion
{
    public partial class Registro_Sueldo_del_Trabajador : Form
    {
        public Registro_Sueldo_del_Trabajador()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Listar_trabajadores mv = new Listar_trabajadores();
            mv.ShowDialog();
        }

        private void Registro_Sueldo_del_Trabajador_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tI1;
            string tI2;

            tI1 = textBox1.Text;
            tI2 = textBox2.Text;
            if (textBox1.Text.Length == 0)
            {
                errorProvider1.SetError(textBox1, "ingresar valor");
            }
            else
            {
                errorProvider1.SetError(textBox1, "");
            }
            if (textBox2.Text.Length == 0)
            {
                errorProvider2.SetError(textBox2, "ingresar valor");
            }
            else
            {
                errorProvider2.SetError(textBox2, "");
            }

            int va = 0;
            string seleccion = comboBox1.SelectedItem.ToString();
            switch (seleccion)
            {
                case "CUPRUM":
                    va = 7;
                    break;
                case "MODELO":
                    va = 9;
                    break;
                case "CAPITAL":
                    va = 12;
                    break;
                case "PROVIDA":
                    va = 13;
                    break;
                default:
                     
                    break;
            }
            int de = 0;
            string selec = comboBox2.SelectedItem.ToString();
            switch (selec)
            {
                case "FONASA":
                    de = 12;
                    break;
                case "CONSALUD":
                    de = 13;
                    break;
                case "MASVIDA":
                    de = 14;
                    break;
                case "BANMEDICA":
                    de = 15;
                    break;
                default:

                    break;
            }

            int SB = Convert.ToInt32(tI1);
            int SL = Convert.ToInt32(tI2);
            int SuelBru = SB * 5000;
            int suelBru = SuelBru + SL + 7000;

            int afp = (suelBru * va) / 100;
            int salud = (suelBru * de) / 100;
            int sueldoLIque = suelBru - afp - salud;
            
            string Sueli = Convert.ToString(sueldoLIque);
            string Suebroto = Convert.ToString(suelBru);
            
            textBox3.Text = Suebroto;
            textBox4.Text = Sueli;





        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >=48 && e.KeyChar <=57)
            {
                errorProvider1.SetError(textBox1, "");
            }
            else
            {
                errorProvider1.SetError(textBox1, "solo numeros");
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 57)
            {
                errorProvider2.SetError(textBox2, "");
            }
            else
            {
                errorProvider2.SetError(textBox2, "solo numeros");
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Autentificación mv = new Autentificación();
            mv.ShowDialog();
        }

        private void listaDeTrabajadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Listar_trabajadores mv = new Listar_trabajadores();
            mv.ShowDialog(); mv = new Listar_trabajadores();
          
        }
    }
}
