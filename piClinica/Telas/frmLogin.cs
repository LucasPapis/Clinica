using piClinica.Classes;
using System;
using System.Windows.Forms;

namespace piClinica
{
    public partial class frmLogin : Form
    {
        Usuario usuLogado = new Usuario();
        Medico medLogado = new Medico();
        public Usuario UsuLogado
        {
            set { usuLogado = value; }
            get { return usuLogado; }
        }

        public Medico MedLogado
        {
            set { medLogado = value; }
            get { return medLogado; }
        }

        public frmLogin(Usuario usu, Medico med)
        {
            InitializeComponent();
            usuLogado = usu;
            medLogado = med;
        }

        public frmLogin()
        {
            InitializeComponent();
        }

        private Boolean VerificaVazio()
        {
            if (ckbMedico.Checked)
            {
                if (txtCrm.Text == string.Empty)
                {
                    MessageBox.Show("Campo CRM vazio! ", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCrm.Focus();
                    return false;
                }
            }
            else
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
            }
            return true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (ckbMedico.Checked)
            {
                if (VerificaVazio())
                {
                    try
                    {
                        string senhaCrypto = Crypto.sha256encrypt(txtSenha.Text);
                        senhaCrypto = senhaCrypto.ToUpper();
                        medLogado = Medico.FazLogin(Convert.ToInt32(txtCrm.Text), senhaCrypto);
                        this.Hide();
                        frmPrincipal p = new frmPrincipal(usuLogado, medLogado);
                        p.Show();
                    }
                    catch (Exception erro)
                    {

                        MessageBox.Show(erro.Message, "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                if (VerificaVazio())
                {
                    try
                    {
                        string senhaCrypto = Crypto.sha256encrypt(txtSenha.Text);
                        senhaCrypto = senhaCrypto.ToUpper();
                        usuLogado = Usuario.FazLogin(txtUser.Text, senhaCrypto);
                        this.Hide();
                        frmPrincipal p = new frmPrincipal(usuLogado, medLogado);
                        p.Show();
                    }
                    catch (Exception erro)
                    {

                        MessageBox.Show(erro.Message, "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void ckbMedico_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbMedico.Checked)
            {
                lblUsu.Visible = false;
                lblCrm.Visible = true;
                txtCrm.Visible = true;
                txtUser.Visible = false;
            }
            else
            {
                lblUsu.Visible = true;
                lblCrm.Visible = false;
                txtCrm.Visible = false;
                txtUser.Visible = true;
            }
        }
    }
}