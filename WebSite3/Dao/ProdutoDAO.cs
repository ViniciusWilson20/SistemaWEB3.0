using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSite3.model;

namespace WebSite3.controller
{
    interface ProdutoDAO
    {
        void inserir(Produto p);

        void alterar(Produto p);

        void excluir(Produto p);

        Produto ler(Produto p);
    }
}
