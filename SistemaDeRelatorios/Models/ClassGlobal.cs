using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaDeRelatorios.Models
{
    public class ClassGlobal
    {
        private static string _VarNome;
        private static string _VarUser;
        private static string _VarEmail;

        public static string VarNome { get => _VarNome; set => _VarNome = value; }
        public static string VarUser { get => _VarUser; set => _VarUser = value; }
        public static string VarEmail { get => _VarEmail; set => _VarEmail = value; }
    }
}