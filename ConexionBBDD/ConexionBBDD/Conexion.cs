using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ConexionBBDD
{
    internal class Conexion
    {
        string cadena = "Data Source = 192.168.0.100; Database=u6; User Id = u6; Password=u6";

        public SqlConnection conectarbbdd = new SqlConnection();

        public Conexion ()
        {
            conectarbbdd.ConnectionString = cadena;
        }

        public void Abrir()
        {
            try
            {
                conectarbbdd.Open();
                Console.WriteLine("Conexion Abierta");
            }
            catch (Exception ex)
            { 
                Console.WriteLine("Error al conectar con la BBDD" + ex.Message);
            }

        }

        public void Cerrar()
        {
            conectarbbdd.Close();
        }

    }
}
