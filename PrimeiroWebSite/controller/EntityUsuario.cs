using PrimeiroWebSite.model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace PrimeiroWebSite.controller
{
    public class EntityUsuario
    {

        ConectaBanco cb = new ConectaBanco();

        public void inserir_Usuario(Usuario u)
        {

            string sql = "Insert into tbUsuario (nomeUsuario, dataNascimento, emailUsuario, loginUsuario, senhaUsuario)" +
                "Values(@nome, @data, @email, @login, @senha)";
            cb.Conetar();
            SqlCommand cmd = new SqlCommand(sql, cb.getConexão());
            cmd.Parameters.AddWithValue("@nome", u.nome_Usuario);
            cmd.Parameters.AddWithValue("@data", u.dt_Usuario);
            cmd.Parameters.AddWithValue("@email", u.email_Usuario);
            cmd.Parameters.AddWithValue("@login", u.login_Usuario);
            cmd.Parameters.AddWithValue("@senha", u.senha_Usuario);
            cmd.ExecuteNonQuery();

        }
        public bool busca_Usuario(Usuario u)
        {
            string sql = "Select nomeUsuario, dataNascimento, emailUsuario, loginUsuario from tbUsuario Where idUsuario=@id";
            cb.Conetar();
            SqlCommand cmd = new SqlCommand(sql, cb.getConexão());
            cmd.Parameters.AddWithValue("@id", u.id_Usuario);
            SqlDataReader read;
            read = cmd.ExecuteReader();
            while (read.Read())
            {
                u.nome_Usuario = read["nomeUsuario"].ToString();
                u.dt_Usuario = Convert.ToDateTime(read["dataNascimento"].ToString());
                u.email_Usuario = read["emailUsuario"].ToString();
                u.login_Usuario = read["loginUsuario"].ToString();
            }
            bool select = read.HasRows;
            if (select == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void editar_Usuario(Usuario u)
        {
            string sql = "UPDATE tbUsuario set nomeUsuario=@nome, dataNascimento=@data, emailUsuario=@email, loginUsuario=@login WHERE idUsuario=@id";
            cb.Conetar();
            SqlCommand cmd = new SqlCommand(sql, cb.getConexão());
            cmd.Parameters.AddWithValue("@id", u.id_Usuario);
            cmd.Parameters.AddWithValue("@nome", u.nome_Usuario);
            cmd.Parameters.AddWithValue("@data", u.dt_Usuario);
            cmd.Parameters.AddWithValue("@email", u.email_Usuario);
            cmd.Parameters.AddWithValue("@login", u.login_Usuario);
            cmd.ExecuteNonQuery();
        }
        public void deletarUsuario(Usuario u)
        {
            string sql = "DELETE from tbUsuario WHERE idUsuario=@id";
            cb.Conetar();
            SqlCommand cmd = new SqlCommand(sql, cb.getConexão());
            cmd.Parameters.AddWithValue("@id" , u.id_Usuario);
            cmd.ExecuteNonQuery();
        }
    }
}