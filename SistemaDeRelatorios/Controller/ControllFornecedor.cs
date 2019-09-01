using SistemaDeRelatorios.FornecedorDAO;
using SistemaDeRelatorios.ProdutosModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaDeRelatorios.FornecedorController
{
    public class ControllFornecedor
    {
        private FornecedorDAOImpl fornecedorDAO = new FornecedorDAOImpl();
        public List<Fornecedor> AdicionarFornecedor() {
            List<Fornecedor> fornecedores = new List<Fornecedor>();
            fornecedores.AddRange(fornecedorDAO.Buscar());
            return fornecedores;
        }
    }
}