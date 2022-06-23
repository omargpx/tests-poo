using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCaja
{
    public class ModelCaja
    {
        string server = "localhost";
        string bd = "bdo_tienda";
        string user = "root";
        string password = "123456";

        public string getServer()
        {
            return server;
        }
        public string getBd()
        {
            return bd;
        }
        public string getUser()
        {
            return user;
        }
        public string getPassword()
        {
            return password;
        }
    }
}
