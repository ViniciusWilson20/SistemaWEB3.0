using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace PrimeiroWebSite.controller
{
    public class ConectaBanco
    {
       private static String sqlCon = @"Data Source=Wilson; Initial Catalog=bdWebSite; Integrated Security=true";

       SqlConnection objCon = null;

        public bool Conetar() {
            objCon = new SqlConnection(sqlCon);
            try
            {
                objCon.Open();
                return true;
            }
            catch {

                return false;
            }
        }
        public SqlConnection getConexão()
        {
            return objCon;
        }

        public bool desconectar() {

            if (objCon.State != ConnectionState.Closed)
            {
                objCon.Close();
                objCon.Dispose();
                return true;
            }
            else {
                objCon.Dispose();
                return false;
            }
        }
    }
}