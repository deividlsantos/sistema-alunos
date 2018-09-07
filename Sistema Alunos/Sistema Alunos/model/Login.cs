using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Alunos.model
{
    class Login
    {

        private String login;
        private String senha;

        public string GetLogin()
        {
            return login;
        }

        public void SetLogin(string value)
        {
            login = value;
        }

        public string GetSenha()
        {
            return senha;
        }

        public void SetSenha(string value)
        {
            senha = value;
        }

        public Login()
        {

        }

        public Login(String login, String senha)
        {
            this.login = login;
            this.senha = senha;
        }

    }

}
