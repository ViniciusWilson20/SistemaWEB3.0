using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using SistemaDeRelatorios.ProdutosDAO;
using SistemaDeRelatorios.ProdutosModels;

namespace SistemaDeRelatorios.DAO
{
    public class UsuarioDAOImpl : UsuarioDAO
    {
        private ConnectionManager con = new ConnectionManager();
        public void Inserir(Usuario u)
        {
            string sql = "Insert Into tbUsuario(nomeUsuario, dataNascimento, emailUsuario, loginUsuario, senhaUsuario)" +
                "Values (@nome, @data, @email, @login, @senha)";
            con.conectar();
            SqlCommand cmd = new SqlCommand(sql, con.getConexao());
            cmd.Parameters.AddWithValue("@nome", u.nomeUsuario);
            cmd.Parameters.AddWithValue("@data", u.dataNascimento);
            cmd.Parameters.AddWithValue("@email", u.emailUsuario);
            cmd.Parameters.AddWithValue("@login", u.loginUsuario);
            cmd.Parameters.AddWithValue("@senha", u.senhaUsuario);
            cmd.ExecuteNonQuery();
            con.desconectar();
        }

        public bool Logar(Usuario u)
        {
            string sql = "Select * From tbUsuario Where loginUsuario='"
            + u.loginUsuario + "' OR emailUsuario='" + u.emailUsuario
            + "'AND senhaUsuario='" + u.senhaUsuario + "'";
            con.conectar();
            SqlCommand cmd = new SqlCommand(sql, con.getConexao());
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                u.nomeUsuario = reader["nomeUsuario"].ToString();
                u.dataNascimento = Convert.ToDateTime(reader["dataNascimento"]);
                u.emailUsuario = reader["emailUsuario"].ToString();
                u.loginUsuario = reader["loginUsuario"].ToString();
                u.senhaUsuario = reader["senhaUsuario"].ToString();
            }
            bool autenticador = reader.HasRows;
            if (autenticador == true)
            {
                return true;
            }
            else {
                return false;
            }
        }
    }
}