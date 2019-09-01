using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebSite3.model
{
    public class ConnectionManager
    {
        private static String conexao = @"Data Source=Wilson; initial catalog=bdWebSite3; Integrated Security=true";
        SqlConnection con;
        public bool Conectar() {

            con = new SqlConnection(conexao);
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

        public bool Desconectar() {

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