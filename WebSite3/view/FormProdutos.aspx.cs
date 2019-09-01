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
    public partial class FormProdutos : System.Web.UI.Page
    {
        private ProdutoController produtoController = new ProdutoController();
        private Produto p;
        private void LoadCategorias() {
            List<string> ltCategorias = new List<string>();
            ltCategorias.Clear();
            ltCategorias = produtoController.inserirCategorias();
            foreach (string categoria in ltCategorias) {
                cmbCategoria.Items.Add(categoria);
            }
        }
        private Produto boundaryToProduto() {

            p = new Produto();
            try
            {
                p.descProduto = txtDescricao.Text;
                p.ValorUnitario = Convert.ToDouble(txtValor.Text);
                p.Categoria = cmbCategoria.SelectedValue;
            }
            catch { }
            return p;
        }
        private bool ValidaCampos() {
            bool isValido = true;
            string mensagem = "Complete todos os Campos";
            if (string.IsNullOrEmpty(txtDescricao.Text)
            || string.IsNullOrEmpty(txtValor.Text)
            || string.IsNullOrEmpty(cmbCategoria.SelectedValue))
            {
                Response.Write("<script>alert('" + mensagem + "');</script>");
                isValido = false;
            }
            else {
                isValido = true;
            } 
            return isValido;
        }
        private void ClearFields()
        {
            txtDescricao.Text = "";
            txtValor.Text = "";
            txtDescricao.Focus();
            //cmbCategoria.Items.Clear();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadCategorias();
        }

        protected void btnInserir_Click(object sender, EventArgs e)
        {
            string mensagem = "Cadastro Efetuado com Sucesso!";
            p = boundaryToProduto();
            if (ValidaCampos() == true)
            {
                produtoController.inserirProduto(p);
                Response.Write("<script>alert('" + mensagem + "');</script>");
                cmbCategoria.Items.Clear();
                ClearFields();
            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        protected void btnAlterar_Click(object sender, EventArgs e)
        {

        }

        protected void btnExcluir_Click(object sender, EventArgs e)
        {

        }
    }
}