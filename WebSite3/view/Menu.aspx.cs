using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebSite3.controller;
using WebSite3.model;

namespace WebSite3.view
{
    public partial class Menu : System.Web.UI.Page
    {
        Usuario u = new Usuario();
        bool logado = false;
        UsuarioDAOImpl dao = new UsuarioDAOImpl(); 

        protected void Page_Load(object sender, EventArgs e)
        {
            lblTitulo.Text = "Seja Bem Vindo, " + Global.VarLogin;

        }

        protected void btnProduto_Click(object sender, EventArgs e)
        {
            Response.Redirect("FormProdutos.aspx");
        }

        protected void btnConProduto_Click(object sender, EventArgs e)
        {

        }

        protected void btnNewUsr_Click(object sender, EventArgs e)
        {

        }

        protected void btnRegistros_Click(object sender, EventArgs e)
        {

        }
    }
}