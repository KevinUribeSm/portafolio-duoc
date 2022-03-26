using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Oracle.DataAccess.Client;

namespace CapaConexion
{
    public class Conexion
    {

        OracleConnection conexion = new OracleConnection();

        public Conexion()
        {
            conexion.ConnectionString = "Data Source = (DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = XE))); User ID =Portafolio; Password = Portafolio; ";
            conexion.Open();
        }

        public Boolean AbrirConexion()
        {
            if (conexion.State == ConnectionState.Closed)
                conexion.Open();
            return true;
        }

        public Boolean CerrarConexion()
        {
            if (conexion.State == ConnectionState.Open)
                conexion.Close();
            return true;
        }
    }
}

