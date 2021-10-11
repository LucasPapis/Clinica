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
        private int _admin;
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
        public int Admin
        {
            get { return _admin; }
            set { _admin = value; }
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
          
        }
        //Buscar
        public Usuario(int id_user, string user, string senha, int admin, int ativo)
        {
            Id_usuario = id_user;
            User = user;
            Senha = senha;
            Admin = admin;
            Ativo = ativo;
        }
        //Cadastrar
        public Usuario(string user, string senha, int admin, int ativo)
        {
            User = user;
            Senha = senha;
            Admin = admin;
            Ativo = ativo;
        }
        //Alterar
        public Usuario(int id_usuario, string user, string senha, int admin)
        {
            Id_usuario = id_usuario;
            User = user;
            Senha = senha;
            Admin = admin;
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
                        usuLogin = new Usuario(Convert.ToInt32(cn.dr["id_usuario"]),cn.dr["user"].ToString(), cn.dr["senha"].ToString(), Convert.ToInt32(cn.dr["admin"]), Convert.ToInt32(cn.dr["ativo"]));
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
        public static List<Usuario> BuscaUser()
        {
            List<Usuario> listaUsuarios = new List<Usuario>();
            string query = "SELECT * FROM usuario";
            Conexao cn = new Conexao(query);
            try
            {
                cn.AbreConexao();
                cn.dr = cn.cmd.ExecuteReader();
                if (cn.dr.HasRows)
                {
                    while (cn.dr.Read())
                    {
                        listaUsuarios.Add(new Usuario(Convert.ToInt32(cn.dr[0]),
                            cn.dr[1].ToString(),
                            cn.dr[2].ToString(),
                            Convert.ToInt32(cn.dr[3]),
                            Convert.ToInt32(cn.dr[4])));
                    }
                }
                return listaUsuarios;
            }
            catch (Exception error)
            {
                throw new Exception(error.ToString());
            }
            finally
            {
                cn.FecharConexao();
            }
        }
        //Cadastra o Usuário
        public void Cadastrausu()
        {
            string query = "SELECT * FROM usuario WHERE user='" + User + "'";
            Conexao cn = new Conexao(query);
            try
            {
                cn.AbreConexao();
                cn.dr = cn.cmd.ExecuteReader();
                if (!cn.dr.HasRows)
                {
                    cn.FecharConexao();
                    query = string.Format("INSERT INTO usuario (user, senha, admin, ativo) VALUES ('{0}','{1}','{2}','{3}')", User, Senha, Admin, Ativo);
                    cn = new Conexao(query);
                    cn.AbreConexao();
                    cn.cmd.ExecuteNonQuery();
                }
                else
                {
                    throw new Exception("Usuário já cadastrado");
                }
            }
            catch (Exception error)
            {

                throw new Exception(error.ToString());
            }
            finally
            {
                cn.FecharConexao();
            }
        }
        public void AlteraUsu()
        {
            string query = string.Format("UPDATE usuario SET user='{0}', senha='{1}', admin='{2}', ativo='{3}'WHERE id_usuario='{4}'", User, Senha, Admin, Id_usuario);
            Conexao cn = new Conexao(query);
            try
            {
                cn.AbreConexao();
                cn.cmd.ExecuteNonQuery();
            }
            catch (Exception error)
            {

                throw new Exception(error.ToString());
            }
        }
        public void DesativaAtivaUsu(int id_usuario, int ativo)
        {
            string query = "UPDATE usuario SET ativo='" + ativo + "' WHERE id_usuario='" + id_usuario + "'";
            Conexao cn = new Conexao(query);
            try
            {
                cn.AbreConexao();
                cn.cmd.ExecuteNonQuery();
            }
            catch (Exception error)
            {

                throw new Exception(error.ToString());
            }
        }
        public void DeletaUso(int id_usuario)
        {
            string query = "DELETE FROM usuario WHERE id_usuario='" + id_usuario + "'";
            Conexao cn = new Conexao(query);
            try
            {
                cn.AbreConexao();
                cn.cmd.ExecuteNonQuery();
            }
            catch (Exception error)
            {

                throw new Exception(error.ToString());
            }
        }
        #endregion
    }
}
