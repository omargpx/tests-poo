using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCaja
{
    public class conexionDB
    {
        public static MySqlConnection conexionBD()
        {
            ModelCaja mc = new ModelCaja();
            
            string conn = "Database=" + mc.getBd() + "; Data Source="+mc.getServer()+"; User Id= "+mc.getUser()+"; Password= "+mc.getPassword()+"";

            try
            {
                MySqlConnection conexion = new MySqlConnection(conn);
                return conexion;
            }
            catch(ExceptionConectionBD e)
            {
                Console.WriteLine(e.Message);
            }
            return null;
        }
    }
}
