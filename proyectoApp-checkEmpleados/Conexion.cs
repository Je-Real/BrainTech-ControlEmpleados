using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace proyectoApp_checkEmpleados
{
    class Conexion
    {
        public static SqlConnection con; //conexion
        public static SqlDataReader result; //resultado de consulta

        private static string cadenaConexion = "Data source=" + Environment.MachineName + ";" +
            "Initial Catalog=control; Integrated Security=True";

        public static void Ejecutar(string comando)
        {
            try
            {
                con = new SqlConnection(cadenaConexion);
                con.Open();
                SqlCommand query = con.CreateCommand();
                query.CommandText = comando;
                int AffectedRows = query.ExecuteNonQuery();
                var result = AffectedRows > 0 ? 0 : MessageBox.Show("No se ejecuto correctamente");
            }
            catch (Exception e)
            {
                MessageBox.Show("Se produjo un error en 'Ejecutar()': " + e.ToString(), 
                    "Error de base de datos.");
            }
            finally
            {
                if (con.State != ConnectionState.Closed)
                {
                    con.Close();
                }
            }
        }

        public static void Consulta(string comando)
        {
            try
            {
                con = new SqlConnection(cadenaConexion);
                con.Open();
                SqlCommand query = con.CreateCommand();
                query.CommandText = comando;
                result = query.ExecuteReader();
            }
            catch (Exception e)
            {
                MessageBox.Show("Se produjo un error en 'Consulta()': " + e.ToString(), 
                    "Error de base de datos.");
            }
        }
    }
}
