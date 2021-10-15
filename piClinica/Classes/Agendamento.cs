using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using piClinica.Classes;

namespace piClinica.Classes
{
    class Agendamento
    {
        private int id_agenda;
        private int id_paciente;
        private int id_medico;
        private string data;
        private string hora;
        private string descricao;

        public int Id_agenda
        {
            get { return id_agenda; }
            set { id_agenda = value; }
        }
        public int Id_paciente
        {
            get { return id_paciente; }
            set { id_paciente = value; }
        }
        public int Id_medico
        {
            get { return id_medico; }
            set { id_medico = value; }
        }
        public string Data
        {
            get { return data; }
            set { data = value; }
        }
        public string Hora
        {
            get { return hora; }
            set { hora = value; }
        }
        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        public Medico DadosMedico { get; set; }
        public Paciente DadosPaciente { get; set; }

        public Agendamento()
        {

        }
        //Busca Agendamentos tela principal
        public Agendamento(int id_agenda, string data, string hora, string descricao, Medico dadosMedico, Paciente dadosPaciente)
        {
            Id_agenda = id_agenda;
            Data = data;
            Hora = hora;
            Descricao = descricao;
            DadosMedico = dadosMedico;
            DadosPaciente = dadosPaciente;
        }
        //Busca Agendamentos
        public Agendamento(int id_agenda, string data, string hora, string descricao, Medico dadosMedico)
        {
            Id_agenda = id_agenda;
            Data = data;
            Hora = hora;
            Descricao = descricao;
            DadosMedico = dadosMedico;
        }
        //busca med disponivel
        public Agendamento(string data, string hora, Medico dadosMedico)
        {
            Data = data;
            Hora = hora;
            DadosMedico = dadosMedico;
        }
        //Altera
        public Agendamento(int id_agenda, int id_paciente, int id_medico, string data, string hora, string descricao)
        {
            Id_agenda = id_agenda;
            Id_paciente = id_paciente;
            Id_medico = id_medico;
            Data = data;
            Hora = hora;
            Descricao = descricao;
        }
        //Cadastra consulta
        public Agendamento(int id_paciente, int id_medico, string data, string hora, string descricao)
        {
            Id_paciente = id_paciente;
            Id_medico = id_medico;
            Data = data;
            Hora = hora;
            Descricao = descricao;
        }

        public static List<Agendamento> BuscaAgenda(string data)
        {
            List<Agendamento> listaAgenda = new List<Agendamento>();
            string query = "SELECT a.id_agenda, a.data, a.hora, a.descricao, m.nome, m.sobrenome, m.crm, m.especialidade, p.nome, p.sobrenome, p.dt_nasc, p.sexo FROM agendamento AS a INNER JOIN medico AS m ON a.id_medico = m.id_medico INNER JOIN paciente AS p ON a.id_paciente = p.id_paciente WHERE a.data='"+data+"'";
            Conexao cn = new Conexao(query);
            try
            {
                cn.AbreConexao();
                cn.dr = cn.cmd.ExecuteReader();
                if (cn.dr.HasRows)
                {
                    while (cn.dr.Read())
                    {
                        listaAgenda.Add(new Agendamento(Convert.ToInt32(cn.dr[0]),
                            cn.dr[1].ToString(),
                            cn.dr[2].ToString(),
                            cn.dr[3].ToString(),
                            new Medico(cn.dr[4].ToString(),
                            cn.dr[5].ToString(),
                            Convert.ToInt32(cn.dr[6]),
                            cn.dr[7].ToString()),
                            new Paciente(cn.dr[8].ToString(),
                            cn.dr[9].ToString(),
                            cn.dr[10].ToString(),
                            cn.dr[11].ToString())));
                    }
                }
                return listaAgenda;
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
        public static List<Agendamento> BuscaMedDispo(string espec)
        {
            List<Agendamento> listaMedA = new List<Agendamento>();
            string query = "SELECT a.data, a.hora, m.id_medico, m.nome, m.sobrenome, m.crm, m.especialidade FROM agendamento AS a INNER JOIN medico as m ON a.id_medico = m.id_medico WHERE m.especialidade = '" + espec + "' AND m.ativo = 1";
            Conexao cn = new Conexao(query);
            try
            {
                cn.AbreConexao();
                cn.dr = cn.cmd.ExecuteReader();
                if (cn.dr.HasRows)
                {
                    while (cn.dr.Read())
                    {
                        listaMedA.Add(new Agendamento(cn.dr[0].ToString(),
                            cn.dr[1].ToString(),
                            new Medico(Convert.ToInt32(cn.dr[2]),
                            cn.dr[3].ToString(),
                            cn.dr[4].ToString(),
                            Convert.ToInt32(cn.dr[5]),
                            cn.dr[6].ToString())));
                    }
                }
                return listaMedA;
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
        public static List<Agendamento> BuscaHisto(int id_paciente)
        {
            List<Agendamento> listaHisto = new List<Agendamento>();
            string query = "SELECT a.id_agenda, a.data, a.hora, a.descricao, m.nome, m.sobrenome, m.crm, m.especialidade FROM agendamento AS a INNER JOIN medico as m ON a.id_medico = m.id_medico WHERE m.ativo = 1 AND a.id_paciente="+id_paciente+"";
            Conexao cn = new Conexao(query);
            try
            {
                cn.AbreConexao();
                cn.dr = cn.cmd.ExecuteReader();
                if (cn.dr.HasRows)
                {
                    while (cn.dr.Read())
                    {
                        listaHisto.Add(new Agendamento(Convert.ToInt32(cn.dr[0]),
                            cn.dr[1].ToString(),
                            cn.dr[2].ToString(),
                            cn.dr[3].ToString(),
                            new Medico(cn.dr[4].ToString(),
                            cn.dr[5].ToString(),
                            Convert.ToInt32(cn.dr[6]),
                            cn.dr[7].ToString())));
                    }
                }
                return listaHisto;
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
        public static List<Agendamento> BuscaMed()
        {
            List<Agendamento> listaMedA = new List<Agendamento>();
            string query = "SELECT a.id_agenda, a.data, a.hora, a.descricao, m.id_medico, m.nome, m.sobrenome, m.crm, m.especialidade FROM agendamento AS a INNER JOIN medico as m ON a.id_medico = m.id_medico WHERE m.ativo = 1";
            Conexao cn = new Conexao(query);
            try
            {
                cn.AbreConexao();
                cn.dr = cn.cmd.ExecuteReader();
                if (cn.dr.HasRows)
                {
                    while (cn.dr.Read())
                    {
                        listaMedA.Add(new Agendamento(Convert.ToInt32(cn.dr[0]),
                            cn.dr[1].ToString(),
                            cn.dr[2].ToString(),
                            cn.dr[3].ToString(),
                            new Medico(Convert.ToInt32(cn.dr[4]),
                            cn.dr[5].ToString(),
                            cn.dr[6].ToString(),
                            Convert.ToInt32(cn.dr[7]),
                            cn.dr[8].ToString())));
                    }
                }
                return listaMedA;
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

        public void CadastraConsulta()
        {
            string query = "SELECT * FROM agendamento WHERE data='" + Data + "'AND hora='" + Hora + "'";
            Conexao cn = new Conexao(query);
            try
            {
                cn.AbreConexao();
                cn.dr = cn.cmd.ExecuteReader();
                if (!cn.dr.HasRows)
                {
                    cn.FecharConexao();
                    query = string.Format("INSERT INTO agendamento (id_paciente, id_medico, data, hora, descricao) VALUES ('{0}','{1}','{2}','{3}','{4}')", Id_paciente, Id_medico, Data, Hora, Descricao);
                    cn = new Conexao(query);
                    cn.AbreConexao();
                    cn.cmd.ExecuteNonQuery();
                }
                else
                {
                    throw new Exception("já cadastrado");
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
        public void RemarcarConsulta()
        {
            string query = "SELECT * FROM agendamento WHERE data='" + Data + "'AND hora='" + Hora + "'";
            Conexao cn = new Conexao(query);
            try
            {
                cn.AbreConexao();
                cn.dr = cn.cmd.ExecuteReader();
                if (!cn.dr.HasRows)
                {
                    cn.FecharConexao();
                    query = string.Format("UPDATE agendamento SET id_paciente='{0}', id_medico='{1}', data='{2}', hora='{3}', descricao='{4}' WHERE id_agenda='{5}'", Id_paciente, Id_medico, Data, Hora, Descricao, Id_agenda);
                    cn = new Conexao(query);
                    cn.AbreConexao();
                    cn.cmd.ExecuteNonQuery();
                }
                else
                {
                    throw new Exception("Impossivel remarcar");
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
        public void DesmarcaConsulta(int id_agenda)
        {

            string query = "DELETE FROM agendamento WHERE id_agenda='" +id_agenda+"'";
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
            finally
            {
                cn.FecharConexao();
            }
        }
    }
}
