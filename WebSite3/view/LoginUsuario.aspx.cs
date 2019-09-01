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
    public partial class LoginUsuario : System.Web.UI.Page
    {
   
        Usuario u = new Usuario();
        UsuarioDAOImpl dao = new UsuarioDAOImpl();
        Menu m = new Menu();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEntrar_Click(object sender, EventArgs e)
        {
            string mensagem;
            u.Login_Usuario = txtUsuario.Text;
            u.Email_Usuario = txtUsuario.Text;
            u.setSenha_Usuario(txtSenha.Text);
            if (string.IsNullOrEmpty(txtUsuario.Text) || string.IsNullOrEmpty(txtSenha.Text))
            {
                    mensagem = "Complete Todos os Campos";
                    Response.Write("<Script> alert('"+ mensagem +"'); </Script>");
            }
            else {

                bool autenticar = dao.Logar(u);
                if (autenticar == true)
                {

                    Global.VarLogin = u.Login_Usuario;
                    Response.Redirect("Menu.aspx");
                }
                else {
                    mensagem = "Falha No Login :( \n Usuario ou Senha não Identificados";
                    this.Response.Write("<Script> alert('" + mensagem + "'); </Script>");   
                }
            }
        }
    }
}