using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Final_Taller_de_programacion
{
    public class Insercion
    {
        public int Rango { get; set; }
        public int rut { get; set; }
        public string nombre { get; set; }
        public string Direcion { get; set;}
        public int Telefono { get; set; }
        public int ValorHora { get; set; }
        public int ValorExtra { get; set; }
        public int Clave { get; set; }

        public Insercion() { }
        public Insercion(int Rango, int rut, string nombre, string Direcion, int Telefono, int ValorHora, int ValorExtra, int clave)
        {
            this.Rango = Rango;
            this.rut = rut;
            this.nombre = nombre;
            this.Direcion = Direcion;
            this.Telefono = Telefono;
            this.ValorHora = ValorHora;
            this.ValorExtra = ValorExtra;
            this.Clave = clave;
        }
        
    }
}
