using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace piClinica.Classes
{
    class Endereco
    {
        private int id_endereco;
        private string estado;
        private string cidade;
        private string rua;
        private int numero;
        private string comple;
        private string cep;

        public int Id_endereco
        {
            get { return id_endereco; }
            set { id_endereco = value; }
        }
        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }
        public string Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }
        public string Rua
        {
            get { return rua; }
            set { rua = value; }
        }
        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        public string Comple
        {
            get { return comple; }
            set { comple = value; }
        }
        public string Cep
        {
            get { return cep; }
            set { cep = value; }
        }

        public Endereco() { }
        //Construtor geral(Geralmente usado para buscar)
        public Endereco(int id_endereco, string estado, string cidade, string rua, int numero, string comple, string cep)
        {
            Id_endereco = id_endereco;
            Estado = estado;
            Cidade = cidade;
            Rua = rua;
            Numero = numero;
            Comple = comple;
            Cep = cep;
        }
        //Usado para cadastrar
        public Endereco(string estado, string cidade, string rua, int numero, string comple, string cep)
        {
            Estado = estado;
            Cidade = cidade;
            Rua = rua;
            Numero = numero;
            Comple = comple;
            Cep = cep;
        }
        public int BuscaEndereco(string cep, int numero)
        {
            List<Endereco> listaEndereco = new List<Endereco>();
            string query = "SELECT * FROM endereco WHERE cep='" + cep + "' AND numero='" + numero + "'";
            Conexao cn = new Conexao(query);
            try
            {
                cn.AbreConexao();
                cn.dr = cn.cmd.ExecuteReader();
                if (cn.dr.HasRows)
                {
                    while (cn.dr.Read())
                    {
                        listaEndereco.Add(new Endereco(Convert.ToInt32(cn.dr[0]),
                            cn.dr[1].ToString(),
                            cn.dr[2].ToString(),
                            cn.dr[3].ToString(),
                            Convert.ToInt32(cn.dr[4]),
                            cn.dr[5].ToString(),
                            cn.dr[6].ToString()));
                    }
                }
                return Id_endereco = listaEndereco[0].Id_endereco;
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

        //Metodo para cadastrar o endereço
        public void CadastraEnder()
        {
            string query = "SELECT * FROM endereco WHERE rua='" + Cep + "' AND numero='" + Numero + "'";
            Conexao cn = new Conexao(query);
            try
            {
                cn.AbreConexao();
                cn.dr = cn.cmd.ExecuteReader();
                if (!cn.dr.HasRows)
                {
                    cn.FecharConexao();
                    query = string.Format("INSERT INTO endereco (estado, cidade, rua, numero, comple, cep) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}')", Estado, Cidade, Rua, Numero, Comple, Cep);
                    cn = new Conexao(query);
                    cn.AbreConexao();
                    cn.cmd.ExecuteNonQuery();
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
        public void AlteraEnder()
        {
            BuscaEndereco(Cep, Numero);
            string query = string.Format("UPDATE endereco SET estado='{0}', cidade='{1}', rua='{2}', numero='{3}', comple='{4}', cep='{5}' WHERE id_endereco='{6}'", Estado, Cidade, Rua, Numero, Comple, Cep, Id_endereco);
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

