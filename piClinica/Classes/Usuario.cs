using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace piClinica.Classes
{
    class Usuario
    {
        #region Variáveis
        private string _user;
        private string _senha;
        /*private string _nome;
        private string _endereco;
        private string _cpf;
        private string _nasc;*/
        #endregion

        #region Propriedades
        public string User
        {
            get { return _user; }
            set { _user = value; }
        }
        public string Senha
        {
            get { return _senha; }
            set { _senha = value; }
        }
        #endregion

        #region Construtores
        public Usuario(string user, string senha)
        {
            User = user;
            Senha = senha;
        }
        #endregion
        
        #region Métodos
        public static Usuario FazLogin(string user, string senha)
        {

        }
        #endregion
    }
}
