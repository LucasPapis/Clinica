using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace piClinica.Classes
{
    class Paciente : Endereco
    {
        private int id_paciente;
        private string nome;
        private string sobrenome;
        private string dt_nasc;
        private string rg;
        private string cpf;
        private string telefone;
        private string sexo;
        private string peso;
        private string altura;
        private string plano_saude;

        public int Id_paciente
        {
            get { return id_paciente; }
            set { id_paciente = value; }
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
        public string Dt_nasc
        {
            get { return dt_nasc; }
            set { dt_nasc = value; }
        }
        public string Rg
        {
            get { return rg; }
            set { rg = value; }
        }
        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }
        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }
        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }
        public string Peso
        {
            get { return peso; }
            set { peso = value; }
        }
        public string Altura
        {
            get { return altura; }
            set { altura = value; }
        }
        public string Plano_saude
        {
            get { return plano_saude; }
            set { plano_saude = value; }
        }

        public Paciente()
        {

        }

        public Paciente(string nome, string sobrenome, string dt_nasc, string sexo)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Dt_nasc = dt_nasc;
            Sexo = sexo;
        }
        //Busca na tela de agendamento
        public Paciente(int id_paciente ,string nome, string sobrenome, string cpf, string rg, string peso, string telefone, string plano_saude, string altura)
        {
            Id_paciente = id_paciente;
            Nome = nome;
            Sobrenome = sobrenome;
            Cpf = cpf;
            Rg = rg;
            Peso = peso;
            Telefone = telefone;
            Plano_saude = plano_saude;
            Altura = altura;
        }

        //Busca do paciente e endereco do mesmo
        public Paciente(int id_paciente, string nome, string sobrenome, string dt_nasc, string rg, string cpf, string telefone, string sexo, string peso, string altura, string plano_saude, int id_endereco, string estado, string cidade, string rua, int numero, string comple, string cep)
        {
            Id_paciente = id_paciente;
            Nome = nome;
            Sobrenome = sobrenome;
            Dt_nasc = dt_nasc;
            Rg = rg;
            Cpf = cpf;
            Telefone = telefone;
            Sexo = sexo;
            Peso = peso;
            Altura = altura;
            Plano_saude = plano_saude;
            Id_endereco = id_endereco;
            Estado = estado;
            Cidade = cidade;
            Rua = rua;
            Numero = numero;
            Comple = comple;
            Cep = cep;
        }

        //Cadastro do paciente
        public Paciente(string nome, string sobrenome, string dt_nasc, string rg, string cpf, string telefone, string sexo, string peso, string altura, string plano_saude)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Dt_nasc = dt_nasc;
            Rg = rg;
            Cpf = cpf;
            Telefone = telefone;
            Sexo = sexo;
            Peso = peso;
            Altura = altura;
            Plano_saude = plano_saude;
        }

        //Alteração dos dados do paciente
        public Paciente(int id_paciente ,string nome, string sobrenome, string dt_nasc, string rg, string cpf, string telefone, string sexo, string peso, string altura, string plano_saude)
        {
            Id_paciente = id_paciente;
            Nome = nome;
            Sobrenome = sobrenome;
            Dt_nasc = dt_nasc;
            Rg = rg;
            Cpf = cpf;
            Telefone = telefone;
            Sexo = sexo;
            Peso = peso;
            Altura = altura;
            Plano_saude = plano_saude;
        }

        //Método para retornar os pacientes ativos
        public static List<Paciente> BuscaPacientes()
        {
            List<Paciente> listaPacientes = new List<Paciente>();
            string query = " SELECT * FROM paciente p INNER JOIN endereco e ON p.id_endereco = e.id_endereco";
            Conexao cn = new Conexao(query);
            try
            {
                cn.AbreConexao();
                cn.dr = cn.cmd.ExecuteReader();
                if (cn.dr.HasRows)
                {
                    while (cn.dr.Read())
                    {
                        listaPacientes.Add(new Paciente(Convert.ToInt32(cn.dr[0]),
                            cn.dr[1].ToString(),
                            cn.dr[2].ToString(),
                            cn.dr[3].ToString(),
                            cn.dr[4].ToString(),
                            cn.dr[5].ToString(),
                            cn.dr[6].ToString(),
                            cn.dr[7].ToString(),
                            cn.dr[8].ToString(),
                            cn.dr[9].ToString(),
                            cn.dr[10].ToString(),
                            Convert.ToInt32(cn.dr[12]),
                            cn.dr[13].ToString(),
                            cn.dr[14].ToString(),
                            cn.dr[15].ToString(),
                            Convert.ToInt32(cn.dr[16]),
                            cn.dr[17].ToString(),
                            cn.dr[18].ToString()));
                    }
                }
                return listaPacientes;
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
        public static List<Paciente> BuscaPacientesEspe(string nome, string sobrenome, string cpf)
        {
            List<Paciente> listaPacientesEspec = new List<Paciente>();
            string query = "SELECT id_paciente, nome, sobrenome, cpf, rg, peso, telefone, plano_saude, altura FROM paciente WHERE nome LIKE '"+nome+"' OR sobrenome LIKE '"+sobrenome+"' OR cpf = '"+cpf+"'";
            Conexao cn = new Conexao(query);
            try
            {
                cn.AbreConexao();
                cn.dr = cn.cmd.ExecuteReader();
                if (cn.dr.HasRows)
                {
                    while (cn.dr.Read())
                    {
                        listaPacientesEspec.Add(new Paciente(Convert.ToInt32(cn.dr[0]),
                            cn.dr[1].ToString(),
                            cn.dr[2].ToString(),
                            cn.dr[3].ToString(),
                            cn.dr[4].ToString(),
                            cn.dr[5].ToString(),
                            cn.dr[6].ToString(),
                            cn.dr[7].ToString(),
                            cn.dr[8].ToString()));
                    }
                }
                return listaPacientesEspec;
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

        //Cadastra o paciente
        public void CadastraPaciente(string cep, int numero)
        {
            if (VerificaCadastro(Cpf, Rg))
            {
                BuscaEndereco(cep, numero);
                string query = string.Format("INSERT INTO paciente (nome, sobrenome, dt_nasc, rg, cpf, telefone, sexo, peso, altura, plano_saude, id_endereco) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')", Nome, Sobrenome, Dt_nasc, Rg, Cpf, Telefone, Sexo, Peso, Altura, plano_saude, Id_endereco);
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
            else
            {
                throw new Exception();
            }
            
           
        }
        public void AlteraPaciente()
        {
            string query = string.Format("UPDATE paciente SET nome='{0}', sobrenome='{1}', dt_nasc='{2}', rg='{3}', cpf='{4}', telefone='{5}', sexo='{6}', peso='{7}', altura='{8}', plano_saude='{9}' WHERE id_paciente='{10}'", Nome, Sobrenome, Dt_nasc, Rg, Cpf, Telefone, Sexo, Peso, Altura, Plano_saude, Id_paciente);
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
        public void DeletaPaciente(int id_paciente)
        {
            string query = "DELETE FROM paciente WHERE id_paciente='" + id_paciente + "'";
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
        /*public int BuscaPacienteCpf(string cpf, string rg)
        {
            string query = "SELECT id_paciente, ativo FROM paciente WHERE cpf='"+cpf+"' OR rg='"+rg+"'";
            List<Paciente> listaBusca = new List<Paciente>();
            Conexao cn = new Conexao(query);
            try
            {
                cn.AbreConexao();
                cn.dr = cn.cmd.ExecuteReader();
                if (cn.dr.HasRows)
                {
                    listaBusca.Add(new Paciente(Convert.ToInt32(cn.dr[0]),
                        Convert.ToInt32(cn.dr[1])));
                }
            }
            catch (Exception)
            {

                throw;
            }
        }*/
        public Boolean VerificaCadastro(string cpf, string rg)
        {
            string query = "SELECT * FROM paciente WHERE cpf='" + cpf + "' OR rg='" + rg + "'";
            Conexao cn = new Conexao(query);
            try
            {
                cn.AbreConexao();
                cn.dr = cn.cmd.ExecuteReader();
                if (cn.dr.HasRows)
                {
                    return false;
                }
                else
                {
                    return true;
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
    }
}
