using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Trabajo_Final_Taller_de_programacion
{
    public partial class Autentificación : Form
    {
          
        public Autentificación()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string b = UsuarioAutentificacion.Text;
            string a = "admin";
            if (UsuarioAutentificacion.Text.Length == 0)
            {
                errorProvider1.SetError(UsuarioAutentificacion, "ingresar usuario");
            }
            else
            {
                errorProvider1.SetError(UsuarioAutentificacion, "");
            }
            if (ContraseñaAutentificacion.Text.Length == 0)
            {
                errorProvider1.SetError(ContraseñaAutentificacion, "ingresar contraseña");
            }
            else
            {
                errorProvider1.SetError(ContraseñaAutentificacion, "");
                if (b == a)
                {
                    Administrador mv = new Administrador();
                    mv.ShowDialog();
                }
                else
                {
                    Registro_Sueldo_del_Trabajador mv = new Registro_Sueldo_del_Trabajador();
                    mv.ShowDialog();
                }
            }
            
            
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
