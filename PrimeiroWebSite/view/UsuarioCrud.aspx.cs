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

namespace PrimeiroWebSite.view
{
    public partial class UsuarioCrud : System.Web.UI.Page
    {
        ConectaBanco cb = new ConectaBanco();
        Usuario u = new Usuario();
        EntityUsuario eu = new EntityUsuario();
        bool select = false;
   
        protected void Page_Load(object sender, EventArgs e) {}
        private void EnableAll(){
            txtNome.Enabled = true;
            dtData.Enabled = true;
            txtEmail.Enabled = true;
            txtLogin.Enabled = true;
            btnEditar.Enabled = true;
            btnRemover.Enabled = true; 
        }
        private void DisableAll()
        {
            txtNome.Enabled = false;
            dtData.Enabled = false;
            txtEmail.Enabled = false;
            txtLogin.Enabled = false;
            btnEditar.Enabled = false;
            btnRemover.Enabled = false;

        }
        private void ClearAll() {
            txtNome.Text = null;
            dtData.Text = null;
            txtEmail.Text = null;
            txtLogin.Text = null;
        }

        protected void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                u.id_Usuario = Convert.ToInt32(txtCodigo.Text);
                select = eu.busca_Usuario(u);

                if (select == true)
                {
                    EnableAll();
                    txtNome.Text = u.nome_Usuario;
                    dtData.Text = Convert.ToString(u.dt_Usuario.ToShortDateString());
                    txtEmail.Text = u.email_Usuario;
                    txtLogin.Text = u.login_Usuario;

                }
                else
                {
                    DisableAll();
                    ClearAll();
                }
            }
            catch (Exception ex) {
            }
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                u.id_Usuario = Convert.ToInt32(txtCodigo.Text);
                u.nome_Usuario = txtNome.Text;
                try{
                    u.dt_Usuario = Convert.ToDateTime(dtData.Text);
                }
                catch { }
                u.email_Usuario = txtEmail.Text;
                u.login_Usuario = txtLogin.Text;

                if (string.IsNullOrEmpty(u.nome_Usuario) || string.IsNullOrEmpty(dtData.ToString())
                ||  string.IsNullOrEmpty(u.email_Usuario) || string.IsNullOrEmpty(u.login_Usuario))
                {
                    Response.Write("<script>alert('Complete todos os Campos')</script>");
                }
                else {

                    eu.editar_Usuario(u);
                    Response.Write("<script>alert('Usuário Alterado com Sucesso!')</script>");
                    ClearAll();
                    DisableAll();
                    txtCodigo.Focus();
                }

            }
            catch {
            }

        }

        protected void btnRemover_Click(object sender, EventArgs e)
        {
            try
            {
                u.id_Usuario = Convert.ToInt32(txtCodigo.Text);
                u.nome_Usuario = txtNome.Text;
                u.dt_Usuario = Convert.ToDateTime(dtData.Text);
                u.email_Usuario = txtEmail.Text;
                u.login_Usuario = txtLogin.Text;
                eu.deletarUsuario(u);
                Response.Write("<script>alert('Usuário Removido com Sucesso!')</script>");
                ClearAll();
                DisableAll();
                txtCodigo.Focus();
            }
            catch {
            }

        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Write("<script>alert('Operação Abortada!')</script>");
 
            txtCodigo.Focus();
            DisableAll();
            ClearAll();
        }
    }
}