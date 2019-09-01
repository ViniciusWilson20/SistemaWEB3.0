using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaDeRelatorios.ProdutosDAO
{
    public class Usuario
    {
        public int codUsuario { get; set; }
        public string nomeUsuario { get; set; }
        public DateTime dataNascimento { get; set; }
        public string emailUsuario { get; set; }
        public string loginUsuario { get; set; }
        public string senhaUsuario { get; set; }

    }
}