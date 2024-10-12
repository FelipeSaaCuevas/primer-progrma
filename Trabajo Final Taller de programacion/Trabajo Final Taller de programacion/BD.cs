using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.Sql;

namespace Trabajo_Final_Taller_de_programacion
{
    public class BD
    {
        SqlConnection cnn = new SqlConnection("Data Source = DESKTOP-HE8F66U\\SQLEXPRESS; Initial Catalog = BSTF; Integrated Security = True");
        public SqlConnection AbrirCon()
        {
            cnn.Open();
            return cnn;
        }
        public SqlConnection cerraCon()
        {
            cnn.Close();
            return cnn;
        }
        public static SqlConnection Co()
        {
            SqlConnection cnn = new SqlConnection("Data Source = DESKTOP-HE8F66U\\SQLEXPRESS; Initial Catalog = BSTF; Integrated Security = True");
            cnn.Open();
            return cnn;
        }
    }
}
