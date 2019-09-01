using SistemaDeRelatorios.Controller;
using SistemaDeRelatorios.ProdutosDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SistemaDeRelatorios.Views
{
    public partial class FormUsuarios : System.Web.UI.Page
    {
        private Usuario u;
        private ControllUsuario controllUsuario = new ControllUsuario();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnInserir_Click(object sender, EventArgs e)
        {
            u = boundaryToUsuario();
            string mensagem = "Cadastro Efetuado com Sucesso!"; 
            if (ValidaCampos() == true) {
                controllUsuario.inserir(u);
                Response.Write("<Script>alert('"+ mensagem +"');</Script>");
                ClearFields();
            } 
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private Usuario boundaryToUsuario() {

            u = new Usuario();
            u.nomeUsuario = txtNome.Text;
            u.dataNascimento = Convert.ToDateTime(txtData.Text);
            u.emailUsuario = txtEmail.Text;
            u.loginUsuario = txtLogin.Text;
            u.senhaUsuario = txtSenha.Text;
            return u; 
        }

        private bool ValidaCampos()
        {
            bool isValido = true;
            string mensagem = "Preencha todos os Campos"; 

            if (string.IsNullOrEmpty(txtNome.Text) || string.IsNullOrEmpty(txtData.Text)
            || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtLogin.Text)
            || string.IsNullOrEmpty(txtSenha.Text))
            {
                Response.Write("<Script>alert('" + mensagem + "');</Script>");
                isValido = false;
            }
            else {
                isValido = true;
            }
            return isValido;
        }
        private void ClearFields() {

            txtNome.Text = null;
            txtEmail.Text = null;
            txtData.Text = null;
            txtLogin.Text = null;
            txtSenha.Text = null;
            txtNome.Focus();
        }
    }
}