using SistemaDeRelatorios.DAO;
using SistemaDeRelatorios.ProdutosDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaDeRelatorios.Controller
{
    public class ControllUsuario
    {

        private UsuarioDAO usuarioDAO = new UsuarioDAOImpl();

        public void inserir(Usuario u) {

            usuarioDAO.Inserir(u);

        }

        public bool Logar(Usuario u) {
            return usuarioDAO.Logar(u);
        }
    }
}