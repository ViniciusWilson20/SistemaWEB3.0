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
    public partial class NovoUsuario : System.Web.UI.Page
    {
        Usuario u = new Usuario();
        UsuarioDAOImpl dao = new UsuarioDAOImpl();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void Limpar_Campos(){

            txtNome.Text = null;
            dtData.Text = null;
            txtEmail.Text = null;
            txtLogin.Text = null;
            txtSenha.Text = null;
            txtNome.Focus();
        }

        protected void btnGravar_Click(object sender, EventArgs e)
        {
            string mensagem;

            u.Nome_Usuario = txtNome.Text;
            try { u.DataN_Usuario = Convert.ToDateTime(dtData.Text); } catch { };
            u.Email_Usuario = txtEmail.Text;
            u.Login_Usuario = txtLogin.Text;
            u.setSenha_Usuario(txtSenha.Text);

            if (string.IsNullOrEmpty(u.Nome_Usuario) || u.DataN_Usuario==null ||
                string.IsNullOrEmpty(u.Email_Usuario)|| string.IsNullOrEmpty(u.Login_Usuario) ||
                string.IsNullOrEmpty(u.getSenha_usuario())) {
                mensagem = "Complete Todos os Campos";
                Response.Write("<Script> alert('"+ mensagem +"'); </Script>");

            } else {
                dao.Inserir(u);
                mensagem = "Usuario Inserido com Sucesso!";
                Response.Write("<Script> alert('"+ mensagem +"'); </Script>");
                Limpar_Campos();
            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
                 Limpar_Campos();
        }
    }
}