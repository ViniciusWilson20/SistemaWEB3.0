using SistemaDeRelatorios.ProdutosModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeRelatorios.ProdutosDAO
{
    interface ProdutoDAO
    {
        void inserir(Produto p);

        Produto buscar(); 

        void alterar(Produto p);

        void excluir(Produto p);
        
    }
}
