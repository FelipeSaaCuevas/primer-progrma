using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Final_Taller_de_programacion
{
    public class ins
    {
        public static int agregar(Insercion insercion)
        {
            int retorno = 0;
            using (SqlConnection connection = BD.Co())
            {
                string query = "insert into Empleado(Rango,rut,nombre,Direcion,Telefono,ValorHora,ValorExtra,Clave) value(" + insercion.Rango + "," + insercion.rut + ",'" + insercion.nombre + "','" + insercion.Direcion + "'," + insercion.Telefono + "," + insercion.ValorHora + "," + insercion.ValorExtra + "," + insercion.Clave + ",)";
                SqlCommand comado = new SqlCommand(query, connection);
                retorno = comado.ExecuteNonQuery();
            }
            return retorno;
        }
        public static object ListaRegistro()
        {
            List<Insercion> lista = new List<Insercion>();

            using (SqlConnection connection = BD.Co())
            {
                string query = "Select * from empleado";
                SqlCommand comando = new SqlCommand(query, connection);
                connection.Open();  

                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Insercion insercion = new Insercion();
                    insercion.Rango = reader.GetInt32(0);
                    insercion.rut = reader.GetInt32(1);
                    insercion.nombre = reader.GetString(2);
                    insercion.Direcion = reader.GetString(3);
                    insercion.Telefono = reader.GetInt32(4);
                    insercion.ValorHora = reader.GetInt32(5);
                    insercion.ValorExtra = reader.GetInt32(6);
                    lista.Add(insercion);
                }
            }

            return lista;  
        }
        public static Insercion BuscarPorRango(int rangoBuscado)
        {
            Insercion resultado = null;

            using (SqlConnection connection = BD.Co())
            {
                string query = "SELECT * FROM empleado WHERE Rango = @Rango";
                SqlCommand comando = new SqlCommand(query, connection);
                comando.Parameters.AddWithValue("@Rango", rangoBuscado);  // Parámetro seguro para evitar SQL injection

                connection.Open();

                SqlDataReader reader = comando.ExecuteReader();
                if (reader.Read())
                {
                    resultado = new Insercion
                    {
                        Rango = reader.GetInt32(0),
                        rut = reader.GetInt32(1),
                        nombre = reader.GetString(2),
                        Direcion = reader.GetString(3),
                        Telefono = reader.GetInt32(4),
                        ValorHora = reader.GetInt32(5),
                        ValorExtra = reader.GetInt32(6)
                    };
                }
            }

            return resultado;  
        }
    }
    
}
