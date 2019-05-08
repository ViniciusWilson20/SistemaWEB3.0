using PrimeiroWebSite.controller;
using PrimeiroWebSite.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PrimeiroWebSite
{
    public partial class DadosdeUsuarios : System.Web.UI.Page
    {
        ConectaBanco cb = new ConectaBanco();
        Usuario u = new Usuario();

        protected void Page_Load(object sender, EventArgs e)
        {
            string sql = "select nomeUsuario, dataNascimento, loginUsuario, emailUsuario from tbUsuario";
            cb.Conetar();
            SqlDataAdapter da = new SqlDataAdapter(sql, cb.getConexão());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dtDados.DataSource = dt;
            dtDados.DataBind();
     
        }
    }
}