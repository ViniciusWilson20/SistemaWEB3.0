using SistemaDeRelatorios.ProdutosDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeRelatorios.DAO
{
    interface UsuarioDAO
    {
        void Inserir(Usuario u);
        
        bool Logar(Usuario u);

        

    }
}
