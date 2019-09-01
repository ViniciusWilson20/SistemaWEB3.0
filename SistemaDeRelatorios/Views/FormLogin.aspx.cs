using SistemaDeRelatorios.Controller;
using SistemaDeRelatorios.Models;
using SistemaDeRelatorios.ProdutosDAO;
using SistemaDeRelatorios.ProdutosModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace SistemaDeRelatorios.Views
{
    public partial class LoginView : System.Web.UI.Page
    {
        private Usuario u;
        private ControllUsuario controllUsuario = new ControllUsuario();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEntrar_Click(object sender, EventArgs e)
        {
            u = boundaryToUsuario();
            string mensagem;
            if (ValidaCampos() == true) {
                bool autenticar = controllUsuario.Logar(u);
                if (autenticar == true)
                {
                    ClassGlobal.VarUser = u.loginUsuario;  
                    Response.Redirect("FormMenu.aspx");
                }
                else {
                    mensagem = "Falha No Login :( \n Usuario ou Senha não Identificados";
                    Response.Write("<Script>alert('"+ mensagem +"');</Script>");
                }
            } 
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private bool ValidaCampos() {
            bool isValido = true;
            string mensagem = "Complete todos os campos";
            if (string.IsNullOrEmpty(txtUsuario.Text) || string.IsNullOrEmpty(txtSenha.Text))
            {
                Response.Write("<Script>alert('" + mensagem + "');</Script>");
                isValido = false;
            }
            else {
                isValido = true;
            }
            return isValido;
        }

        private Usuario boundaryToUsuario() {
            u = new Usuario();
            u.loginUsuario = txtUsuar
            return u;
        }

        private void ClearFields()
        {
            txtUsuario.Text = null;
            txtSenha.Text = null;
            txtUsuario.Focus();
        }
    }
}