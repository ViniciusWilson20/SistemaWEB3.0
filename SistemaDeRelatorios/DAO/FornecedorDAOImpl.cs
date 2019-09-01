using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using SistemaDeRelatorios.ProdutosModels;

namespace SistemaDeRelatorios.FornecedorDAO
{
    public class FornecedorDAOImpl : FornecedorDAO
    {
        ConnectionManager con = new ConnectionManager();
    

        public void alterar(Fornecedor f)
        {
            throw new NotImplementedException();
        }

        public Fornecedor Buscar(Fornecedor f)
        {
            throw new NotImplementedException();
        }

        public List<Fornecedor> Buscar()
        {
            string sql = "Select * From tbFornecedor";
            con.conectar();
            SqlCommand cmd = new SqlCommand(sql, con.getConexao());
            SqlDataReader read = cmd.ExecuteReader();
            List<Fornecedor> ltFornecedores = new List<Fornecedor>();
            while (read.Read()) {
                Fornecedor f = new Fornecedor();
                f.codFornecedor = Convert.ToInt32(read["codFornecedor"]);
                f.nomeFantasia = read["nomeFantasia"].ToString();
                ltFornecedores.Add(f);
            }
            read.Close();
            return ltFornecedores;
        }

        public void Excluir(Fornecedor f)
        {
            throw new NotImplementedException();
        }

        public void inserir(Fornecedor f)
        {
            throw new NotImplementedException();
        }
    }
}