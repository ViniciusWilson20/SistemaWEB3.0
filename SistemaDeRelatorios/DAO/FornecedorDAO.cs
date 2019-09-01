using SistemaDeRelatorios.ProdutosModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeRelatorios.FornecedorDAO
{
    interface FornecedorDAO
    {
        void inserir(Fornecedor f);
        void alterar(Fornecedor f);
        void Excluir(Fornecedor f);
        Fornecedor Buscar(Fornecedor f);
        List<Fornecedor> Buscar();
    }
}
