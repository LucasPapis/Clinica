using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using piClinica.Classes;
using System.IO;

namespace piClinica
{
    public partial class frmLogin : Form
    {
        Usuario usuLogado = new Usuario();

        public Usuario UsuLogado
        {
            set { usuLogado = value; }
            get { return usuLogado; }
        }

        public frmLogin(Usuario usu)
        {
            InitializeComponent();
            usuLogado = usu;
        }

        public frmLogin()
        {
            InitializeComponent();
        }

        private Boolean VerificaVazio()
        {
            if (txtUser.Text == string.Empty)
            {
                MessageBox.Show("Campo Usuário vazio! ", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUser.Focus();
                return false;
            }
            if (txtSenha.Text == string.Empty)
            {
                MessageBox.Show("Campo Senha vazio!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSenha.Focus();
                return false;
            }
            return true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (VerificaVazio())
            {
                try
                {
                    string senhaCrypto = Crypto.sha256encrypt(txtSenha.Text);
                    senhaCrypto = senhaCrypto.ToUpper();
                    usuLogado = Usuario.FazLogin(txtUser.Text, senhaCrypto);
                    frmPrincipal p = new frmPrincipal(usuLogado);
                    p.Show();
                   
                }
                catch (Exception erro)
                {

                    MessageBox.Show(erro.Message, "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
