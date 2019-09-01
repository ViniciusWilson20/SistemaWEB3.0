using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaDeRelatorios.ProdutosModels
{
    public class Fornecedor
    {
        public int codFornecedor { get; set; }
        public string nomeFantasia { get; set; }
        public override string ToString()
        {
            return nomeFantasia;
        }
    }


}