using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace WebSite3.model
{
    public class Usuario
    {
        public int Id_Usuario { get; set; }
        public string Nome_Usuario { get; set; }
        public DateTime DataN_Usuario { get; set; }
        public string Email_Usuario { get; set; }
        public string Login_Usuario { get; set; }

        private string Senha_Usuario;
        public string getSenha_usuario() { return Senha_Usuario; }
        public void setSenha_Usuario(string Senha_Usuario) {

            StringBuilder _senha = new StringBuilder();
            MD5 MD5 = MD5.Create();
            byte[] entrada = Encoding.ASCII.GetBytes(Senha_Usuario);
            byte[] hash = MD5.ComputeHash(entrada);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++) {
                _senha.Append(hash[i].ToString("X2"));
            }
            this.Senha_Usuario = _senha.ToString();
        }
    }
}