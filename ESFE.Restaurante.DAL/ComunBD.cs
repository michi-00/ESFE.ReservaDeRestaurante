using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESFE.Restaurante.DAL
{
    public class ComunBD
    {
        public enum TipoBD
        {
            SqlServer, Oracle, BD2
        }
        public const string Sqlconn = @"Data Source=./;Initial Catalog=DBReservaRestaurante;Integrated Security=True;TrustServerCertificate=True";
        public static IDbConnection ObtenerConexion(TipoBD pTipoBD)
        {
            IDbConnection _conn;
            if (pTipoBD == TipoBD.SqlServer)
            {
                _conn = new SqlConnection(Sqlconn);
                return _conn;
            }
            return null;
        }


    }
}
