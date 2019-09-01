using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaDeRelatorios.ProdutosModels
{
    public class Produto
    {

        public int codProduto { get; set; }
        public string descProduto { get; set; }
        public double valorUnit { get; set; }
        public string categoria { get; set; }
        public int imagem { get; set; }
        public Fornecedor fornecedor { get; set; }
    }
}