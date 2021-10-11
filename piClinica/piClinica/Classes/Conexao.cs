using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace piClinica.Classes
{
    class Conexao
    {
        #region Variáveis
        public static string _conexao = @"Server=localhost;Database=db_clinica;Uid=clinica;Pwd='dbClinicapi';Sslmode=none;";
        public MySqlConnection conexao = new MySqlConnection(_conexao);
        public MySqlCommand cmd;
        public MySqlDataReader dr;
        public MySqlDataAdapter da;
        public DataSet ds;
        #endregion

        public Conexao(string query)
        {
            cmd = new MySqlCommand(query, conexao);
            da = new MySqlDataAdapter(query, conexao);
            ds = new DataSet();
        }
        #region Métodos
        public void AbreConexao()
        {
            if(conexao.State == ConnectionState.Open)
            {
                conexao.Close();
            }
            conexao.Open();
        }
        public void FecharConexao()
        {
            conexao.Close();
        }
        #endregion
    }
}
