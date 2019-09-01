using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SistemaDeRelatorios.ProdutosModels
{
    public class ConnectionManager
    {
        private static String str_con = "Data Source=Wilson; initial catalog=bdRelSystem; integrated security=true;";
        private SqlConnection con = null;
        public bool conectar() {
            con = new SqlConnection(str_con);
            try
            {
                con.Open();
                return true;
            }
            catch {
                return false;
            }
        }
        public SqlConnection getConexao() {
            return con;
        }
        public bool desconectar() {
            if (con.State != ConnectionState.Closed)
            {
                con.Close();
                return true;
            }
            else {
                con.Dispose();
                return false;
            }
        }
    }
}