using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using piClinica.Classes;

namespace piClinica
{
    class Medico
    {
        private int id_medico;
        private string nome;
        private string sobrenome;
        private int crm;
        private string senha;
        private string espec;
        private string cpf;
        private string dispo;
        private string status;
        private int ativo;

        public int Id_medico
        {
            get { return id_medico; }
            set { id_medico = value; }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string Sobrenome
        {
            get { return sobrenome; }
            set { sobrenome = value; }
        }
        public int Crm
        {
            get { return crm; }
            set { crm = value; }
        }
        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }
        public string Espec
        {
            get { return espec; }
            set { espec = value; }
        }
        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }
        public string Dispo
        {
            get { return dispo; }
            set { dispo = value; }
        }
        public string Status
        {
            get { return status; }
            set { status = value; }
        }
        public int Ativo
        {
            get { return ativo; }
            set { ativo = value; }
        }

        public Medico()
        {

        }
        //Login
        public Medico(int crm, string senha)
        {
            Crm = crm;
            Senha = senha;
        }

        //Buscar
        public Medico(int id_medico, string nome, string sobrenome, int crm, string senha, string espec, string cpf, string dispo, string status, int ativo)
        {
            Id_medico = id_medico;         
            Nome = nome;
            Sobrenome = sobrenome;
            Crm = crm;
            Senha = senha;
            Espec = espec;
            Cpf = cpf;
            Dispo = dispo;
            Status = status;
            Ativo = ativo;
        }
        //Cadastrar
        public Medico(string nome, string sobrenome, int crm, string senha, string espec, string cpf, string dispo, string status, int ativo)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Crm = crm;
            Senha = senha;
            Espec = espec;
            Cpf = cpf;
            Dispo = dispo;
            Status = status;
            Ativo = ativo;
        }
        //Alterar
        public Medico(int id_medico, string nome, string sobrenome, int crm, string senha, string espec, string cpf, string dispo, string status)
        {
            Id_medico = id_medico;
            Nome = nome;
            Sobrenome = sobrenome;
            Crm = crm;
            Senha = senha;
            Espec = espec;
            Cpf = cpf;
            Dispo = dispo;
            Status = status;
        }
        #region Métodos
        public static Medico FazLogin(int crm, string senha)
        {
            string query = "SELECT crm, senha FROM medico WHERE crm = '" + crm + "'";
            Conexao cn = new Conexao(query);
            try
            {
                cn.AbreConexao();
                cn.dr = cn.cmd.ExecuteReader();
                if (cn.dr.HasRows)
                {
                    Medico medLogin = new Medico();
                    while (cn.dr.Read())
                    {
                        medLogin = new Medico(Convert.ToInt32(cn.dr["crm"]), cn.dr["senha"].ToString());
                    }
                    if (medLogin.Ativo == 0)
                    {
                        throw new Exception("Médico desativado ou não existe");
                    }
                    else
                    {
                        if (medLogin.Crm == crm && medLogin.Senha == senha)
                        {
                            return medLogin;
                        }
                        else
                        {
                            throw new Exception("Médico ou senha inválidos");
                        }
                    }

                }
                else
                {
                    throw new Exception("Médico não encontrado.");
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
        public static List<Medico> BuscaMed()
        {
            List<Medico> listaMed = new List<Medico>();
            string query = "SELECT * FROM medico";
            Conexao cn = new Conexao(query);
            try
            {
                cn.AbreConexao();
                cn.dr = cn.cmd.ExecuteReader();
                if (cn.dr.HasRows)
                {
                    while (cn.dr.Read())
                    {
                        listaMed.Add(new Medico(Convert.ToInt32(cn.dr[0]),
                            cn.dr[1].ToString(),
                            cn.dr[2].ToString(),
                            Convert.ToInt32(cn.dr[3]),
                            cn.dr[4].ToString(),
                            cn.dr[5].ToString(),
                            cn.dr[6].ToString(),
                            cn.dr[7].ToString(),
                            cn.dr[8].ToString(),
                            Convert.ToInt32(cn.dr[9])));
                    }
                }
                return listaMed;
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
        public void CadastraMed()
        {
            string query = "SELECT * FROM medico WHERE crm='" + Crm + "'";
            Conexao cn = new Conexao(query);
            try
            {
                cn.AbreConexao();
                cn.dr = cn.cmd.ExecuteReader();
                if (!cn.dr.HasRows)
                {
                    cn.FecharConexao();
                    query = string.Format("INSERT INTO medico (nome, sobrenome, crm, senha, especialidade, cpf, disponibilidade, status, ativo ) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')", Nome, Sobrenome, Crm, Senha, Espec, Cpf, Dispo, Status, Ativo);
                    cn = new Conexao(query);
                    cn.AbreConexao();
                    cn.cmd.ExecuteNonQuery();
                }
                else
                {
                    throw new Exception("Médico já cadastrado");
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
        public void AlteraMed()
        {
            string query = string.Format("UPDATE medico SET nome='{0}', sobrenome='{1}', crm='{2}', senha='{3}', espec='{4}', cpf='{5}', dispo='{6}', status='{7}', ativo='{8}' WHERE id_medico='{9}'", Nome, Sobrenome, Crm, Senha, Espec, Cpf, Dispo, Status, Ativo, Id_medico);
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
        public void DesativaAtivaMed(int id_medico, int ativo)
        {
            string query = "UPDATE medico SET ativo='" + ativo + "' WHERE id_medico='" + id_medico + "'";
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
        public void DeletaUso(int id_medico)
        {
            string query = "DELETE FROM medico WHERE id_medico='" + id_medico + "'";
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
