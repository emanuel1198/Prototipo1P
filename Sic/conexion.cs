using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Odbc;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Sic
{
    public class Conexion
    {
        public OdbcConnection conexion()
        {
            //creacion de la conexion via ODBC
            OdbcConnection conn = new OdbcConnection("Dsn=Proyecto");
            try
            {
                conn.Open();
            }
            catch (OdbcException)
            {
                Console.WriteLine("Conectó");
                MessageBox.Show("conecto");
            }
            return conn;
        }
        //metodo para cerrar la conexion
        public void desconexion(OdbcConnection conn)
        {
            try
            {
                conn.Close();
            }
            catch (OdbcException)
            {
                Console.WriteLine("Desconectado");
            }
        }

        public static MySqlConnection conex()
        {
            string servidor = "server=localhost; database=sic; Uid=root; pwd=lololocoA12";

            MySqlConnection conexionBD = new MySqlConnection(servidor);

            try
            {
                return conexionBD;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + e.StackTrace);
                return null;
            }


        }

    }
}