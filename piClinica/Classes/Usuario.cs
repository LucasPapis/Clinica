using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using piClinica.Classes;


namespace piClinica.Classes
{
    public class Usuario
    {
        #region Variáveis
        private int _id_usuario;
        private string _user;
        private string _senha;
        private int _ativo;
        /*private string _nome;
        private string _endereco;
        private string _cpf;
        private string _nasc;*/
        #endregion

        #region Propriedades
        public int Id_usuario
        {
            get { return _id_usuario; }
            set { _id_usuario = value; }
        }
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
        public int Ativo
        {
            get { return _ativo; }
            set { _ativo = value; }
        }
        #endregion

        #region Construtores
        public Usuario()
        {
            Id_usuario = 0;
            User = string.Empty;
            Senha = string.Empty;

        }
        public Usuario(int id_user, string user, string senha, int ativo)
        {
            Id_usuario = id_user;
            User = user;
            Senha = senha;
            Ativo = ativo;
        }
        public Usuario(string user, string senha, int ativo)
        {
            User = user;
            Senha = senha;
            Ativo = ativo;
        }

        #endregion

        #region Métodos
        public static Usuario FazLogin(string user, string senha)
        {
            string query = "SELECT * FROM usuario WHERE user = '"+user+"'";
            Conexao cn = new Conexao(query);
            try
            {
                cn.AbreConexao();
                cn.dr = cn.cmd.ExecuteReader();
                if (cn.dr.HasRows)
                {
                    Usuario usuLogin = new Usuario();
                    while (cn.dr.Read())
                    {
                        usuLogin = new Usuario(cn.dr["user"].ToString(), cn.dr["senha"].ToString(), Convert.ToInt32(cn.dr["ativo"]));
                    }
                    if (usuLogin.Ativo == 0 )
                    {
                        throw new Exception("Usuário desativado ou não existe");
                    }
                    else
                    {
                        if (usuLogin.User == user && usuLogin.Senha == senha)
                        {
                            return usuLogin;
                        }
                        else
                        {
                            throw new Exception("Usuário ou senha inválidos");
                        }
                    }
                    
                }
                else
                {
                    throw new Exception("Usuario não encontrado.");
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cn.FecharConexao();
            }
        }
        #endregion
    }
}
