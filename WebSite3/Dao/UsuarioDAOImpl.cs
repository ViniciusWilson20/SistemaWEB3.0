using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebSite3.model;

namespace WebSite3.controller
{
    public class UsuarioDAOImpl : UsuarioDAO
    {
         ConnectionManager cb = new ConnectionManager();
        public void Inserir(Usuario u) {

            string sql = "Insert Into tbUsuario (nomeUsuario, dataNascimento, emailUsuario, loginUsuario, senhaUsuario)" +
                         "Values (@nome, @dataN, @email, @login, @senha)";
            cb.Conectar();
            SqlCommand query = new SqlCommand(sql, cb.getConexao());
            query.Parameters.AddWithValue("@nome" , u.Nome_Usuario);
            query.Parameters.AddWithValue("@dataN" , u.DataN_Usuario);
            query.Parameters.AddWithValue("@email" , u.Email_Usuario);
            query.Parameters.AddWithValue("@login" , u.Login_Usuario);
            query.Parameters.AddWithValue("@senha"  , u.getSenha_usuario());
            query.ExecuteNonQuery();
        }

        public bool Logar(Usuario u) {
           
            string sql = "Select * from tbUsuario where loginUsuario ='" + u.Login_Usuario 
            + "'OR emailUsuario ='" + u.Email_Usuario + "'AND senhaUsuario ='" + u.getSenha_usuario() + "'";
            cb.Conectar();
            SqlCommand query = new SqlCommand(sql , cb.getConexao());
            SqlDataReader read = query.ExecuteReader();
            while (read.Read()) {
                u.Nome_Usuario  = read["nomeUsuario"].ToString();
                u.Email_Usuario = read["emailUsuario"].ToString();
                u.Login_Usuario = read["loginUsuario"].ToString();
           
            }
            bool altentica = read.HasRows;
            if (altentica == true)
            {
                
                return true;
              
            }
            else {
                return false;
            }
        }
    }
}