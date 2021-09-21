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
        private int _id_user;
        private string _user;
        private string _senha;
        /*private string _nome;
        private string _endereco;
        private string _cpf;
        private string _nasc;*/
        #endregion

        #region Propriedades
        public int Id_user
        {
            get { return _id_user; }
            set { _id_user = value; }
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
        #endregion

        #region Construtores
        public Usuario()
        {
            Id_user = 0;
            User = string.Empty;
            Senha = string.Empty;

        }
        public Usuario(int id_user, string user, string senha)
        {
            Id_user = id_user;
            User = user;
            Senha = senha;
        }
        #endregion
        
        #region Métodos
        public static Usuario FazLogin(string user, string senha )
        {
            string query = "SELECT * FROM Usuarios WHERE user = '"+user+"'";
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
                        usuLogin = new Usuario(Convert.ToInt32(cn.dr["id_user"]),cn.dr["user"].ToString(), cn.dr["senha"].ToString());
                    }
                    if (usuLogin.User == user && usuLogin.Senha == senha)
                    {
                        return usuLogin;
                    }
                    else
                    {
                        throw new Exception("Usuario ou senha inválidos");
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
