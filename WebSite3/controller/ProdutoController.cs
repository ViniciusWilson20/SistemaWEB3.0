using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebSite3.model;

namespace WebSite3.controller
{
    public class ProdutoController
    {

        private ProdutoDAO produtoDAO = new ProdutoDAOImpl();
       
        private List<string> categorias;
        public List<string> inserirCategorias() {

            categorias = new List<string>();
            categorias.Add("Alimentos");
            categorias.Add("Cosméticos");
            categorias.Add("Eletrodomésticos");
            categorias.Add("Equipamentos Eletrônicos");
            categorias.Add("Produtos de Limpeza");
            return categorias;
        }

        public void inserirProduto(Produto p) {
            produtoDAO.inserir(p);
        }
    }
}