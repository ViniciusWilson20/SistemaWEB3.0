using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebSite3.model
{
    public class Produto
    {
        public int codProduto { get; set; }

        public string descProduto { get; set; }

        public Double ValorUnitario { get; set; }

        public string Categoria { get; set; }

    }
}