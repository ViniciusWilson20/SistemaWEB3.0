using SistemaDeRelatorios.ProdutosDAO;
using SistemaDeRelatorios.ProdutosModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaDeRelatorios.ProdutosController
{
    public class ControllProdutos
    {
        ProdutoDAO produtoDAO = new ProdutoDAOImpl();

        public void InserirProduto(Produto p) {
            produtoDAO.inserir(p);
        }

        public List<string> InserirCategorias()
        {
            List<string> categorias = new List<string>();
            categorias.Add("Alimentos");
            categorias.Add("Cosméticos");
            categorias.Add("Eletrodomésticos");
            categorias.Add("Produtos de Limpeza");
            categorias.Add("Equipamentos Eletrônicos");
            return categorias;
        }
        
    }
}