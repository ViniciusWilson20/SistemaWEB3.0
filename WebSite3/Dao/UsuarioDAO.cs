using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSite3.model;

namespace WebSite3.controller
{
    interface UsuarioDAO
    {
        void Inserir(Usuario u);

        bool Logar(Usuario u);

    }

}
