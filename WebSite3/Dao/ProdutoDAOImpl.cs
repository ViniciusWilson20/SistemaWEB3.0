using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WebSite3.model;

namespace WebSite3.controller
{
    public class ProdutoDAOImpl : ProdutoDAO
    {
        ConnectionManager con = new ConnectionManager();

        public void inserir(Produto p)
        {
            string sql = "Insert into tbProduto(descProduto, categoriaProduto, valorProduto)" +
                "Values(@desc, @categoria, @valor)";
            con.Conectar();
            SqlCommand cmd = new SqlCommand(sql, con.getConexao());
            cmd.Parameters.AddWithValue("@desc", p.descProduto);
            cmd.Parameters.AddWithValue("@categoria", p.Categoria);
            cmd.Parameters.AddWithValue("@valor", p.ValorUnitario);
            cmd.ExecuteNonQuery();
            con.Desconectar();
        }

        public void excluir(Produto p)
        {
            throw new NotImplementedException();
        }

        public void alterar(Produto p)
        {
            throw new NotImplementedException();
        }

        public Produto ler(Produto p)
        {
            throw new NotImplementedException();
        }
    }
}