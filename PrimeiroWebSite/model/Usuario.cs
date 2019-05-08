using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrimeiroWebSite.model
{
    public class Usuario
    {
        public int id_Usuario { get; set; }
        public DateTime dt_Usuario { get; set; }
        public string nome_Usuario { get; set; }
        public string email_Usuario { get; set; }
        public string login_Usuario { get; set; }
        public string senha_Usuario { get; set; }
    }
}