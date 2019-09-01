using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebSite3.model
{
    public class Global
    {

        private static string _VarLogin;
        private static string _VarNome;
        private static string _VarEmail;

        public static string VarLogin { get => _VarLogin; set => _VarLogin = value; }
        public static string VarNome  { get => _VarNome;  set => _VarNome  = value; }
        public static string VarEmail { get => _VarEmail; set => _VarEmail = value; }
    }
}