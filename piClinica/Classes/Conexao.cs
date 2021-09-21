using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace piClinica.Classes
{
    class Conexao
    {
        #region Variáveis
        public static string _conexao = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\dbTeste.mdf;Integrated Security=True";
        SqlConnection conexao = new SqlConnection(_conexao);
        public SqlCommand cmd;
        public SqlDataReader dr;
        public SqlDataAdapter da;
        public DataSet ds;
        #endregion

        public Conexao(string query)
        {
            cmd = new SqlCommand(query, conexao);
            da = new SqlDataAdapter(query, conexao);
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
