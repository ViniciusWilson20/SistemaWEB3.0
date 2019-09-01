using SistemaDeRelatorios.FornecedorController;
using SistemaDeRelatorios.ProdutosController;
using SistemaDeRelatorios.ProdutosModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SistemaDeRelatorios.ProdutosView
{
    public partial class FormProdutos : System.Web.UI.Page
    {

    
        private List<Fornecedor> ltFornecedores;
        private ControllProdutos controllProdutos = new ControllProdutos();
        private ControllFornecedor controllFornecedor = new ControllFornecedor();
        private Produto p;
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadCombo();
        }


        public void ClearFields()
        {

            txtDescricao.Text = null;
            txtValorUnt.Text = null;
            cmbCategoria.SelectedIndex = -1;
            cmbFornecedor.SelectedIndex = -1;
            txtDescricao.Focus();

        }

        public void LoadCombo()
        {
            List<string> ltCategorias = new List<string>();
            ltCategorias.Clear();
            ltCategorias = controllProdutos.InserirCategorias();
    
            foreach (string categoria in ltCategorias)
            {
                cmbCategoria.Items.Add(categoria);
            }

            /*ltFornecedores = new List<Fornecedor>();
            ltFornecedores.Clear();
            ltFornecedores = controllFornecedor.AdicionarFornecedor();
            cmbFornecedor.Items.Clear();

            foreach (Fornecedor fornecedor in ltFornecedores)
            {
                cmbFornecedor.Items.Add(fornecedor.ToString());
            }*/
        }


        public Produto boundaryToProduto()
        {
            p = new Produto();
            p.descProduto = txtDescricao.Text;
            p.valorUnit = Convert.ToDouble(txtValorUnt.Text);
            p.categoria = cmbCategoria.SelectedItem.ToString();
            return p;
        }
        public bool ValidarCampos()
        {
            bool isValido = true;
            string mensagem = "Preencha todos os Campos";
            if (string.IsNullOrEmpty(txtDescricao.Text)
             || string.IsNullOrEmpty(txtValorUnt.Text)
             || cmbCategoria.SelectedItem == null)
            {
                Response.Write("<Script>alert('" + mensagem + "')</Script>");
                isValido = false;
            }
            return isValido;
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        protected void btnInserir_Click(object sender, EventArgs e)
        {
            string mensagem = "Produto Inserido com Êxito";
            p = boundaryToProduto();
            if (ValidarCampos() == true)
            {
                controllProdutos.InserirProduto(p);
                // Response.Write("<Script>alert('" + mensagem + "')</Script>");
                cmbCategoria.Items.Clear();
                LoadCombo();
            }
        }
    }
}