using PrimeiroWebSite.controller;
using PrimeiroWebSite.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PrimeiroWebSite
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        ConectaBanco cb = new ConectaBanco();
        EntityUsuario eu = new EntityUsuario();
        Usuario u = new Usuario();


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void limpar_campos()
        {
            txtNome.Text = "";
            dtData.Text = "";
            txtEmail.Text = "";
            txtLogin.Text = "";
            txtSenha.Text = "";
            txtNome.Focus();
        }

        protected void btnGravar_Click(object sender, EventArgs e)
        {

            u.nome_Usuario = txtNome.Text;
            try
            {
                u.dt_Usuario = Convert.ToDateTime(dtData.Text);
            }
            catch { }
            u.email_Usuario = txtEmail.Text;
            u.login_Usuario = txtLogin.Text;
            u.senha_Usuario = txtSenha.Text;
            if (string.IsNullOrEmpty(u.nome_Usuario) || string.IsNullOrEmpty(dtData.ToString())
                || string.IsNullOrEmpty(u.email_Usuario) || string.IsNullOrEmpty(u.login_Usuario)
                || string.IsNullOrEmpty(u.senha_Usuario))
            {

                Response.Write("<script>alert('Complete todos os Campos')</script>");


            }
            else
            {
                eu.inserir_Usuario(u);
                Response.Write("<script>alert('Usuário Inserido com Sucesso!')</script>");
                limpar_campos();
                txtNome.Focus();
            }
        

    
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Write("<script>alert('Operação Abortada!')</script>");
            limpar_campos();
            txtNome.Focus();
        }
    }
}