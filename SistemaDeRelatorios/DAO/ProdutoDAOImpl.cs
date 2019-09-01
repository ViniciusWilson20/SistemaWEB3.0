using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using SistemaDeRelatorios.ProdutosModels;

namespace SistemaDeRelatorios.ProdutosDAO
{
    public class ProdutoDAOImpl : ProdutoDAO
    {
        ConnectionManager con = new ConnectionManager();

        public void inserir(Produto p)
        {
            string sql =  "Insert Into tbProduto (descProduto, categoriaProduto, valorUnit) values (@desc, @categ, @valor)";
            con.conectar();
            SqlCommand cmd = new SqlCommand(sql, con.getConexao());
            cmd.Parameters.AddWithValue("@desc", p.descProduto);
            cmd.Parameters.AddWithValue("@categ", p.categoria);
            cmd.Parameters.AddWithValue("@valor", p.valorUnit);
            cmd.ExecuteNonQuery();
            con.desconectar();
        }
        public void alterar(Produto p)
        {
            //string sql = "UPDATE tbProduto SET ";
           
        }

        public Produto buscar()
        {
            return null;
        }

        public void excluir(Produto p)
        {
        
        }

    }
}