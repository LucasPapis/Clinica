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

namespace piClinica
{
    public partial class frmUsuarios : Form
    {  
        //Declaração da lista de pacientes
        private List<Usuario> listaUsuarios = new List<Usuario>();
        //Declaração do bindingList para o dataGrid
        private BindingList<Usuario> listaUsuariosDgv;
        //Passando sessão do usu logado
        private Usuario usuLogado;
        private int admin;
        public frmUsuarios(Usuario usu)
        {
            InitializeComponent();
            usuLogado = usu;
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            buscaBanco();
            lblUsuLogado.Text = usuLogado.User.ToUpper();
        }
        private void buscaBanco()
        {
            listaUsuarios = Usuario.BuscaUser();
            //Carregando o Binding para passar pro DataGrid
            listaUsuariosDgv = new BindingList<Usuario>(listaUsuarios);
            alimentaDgv(listaUsuariosDgv);
            LimpaCampos();
        }
        private void dgvUsuarios_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null && e.ColumnIndex == 4)
            {
                if (Convert.ToInt32(e.Value) == 1)
                {
                    e.Value = "Ativo";
                }
                else
                {
                    e.Value = "Inativo";
                }
                
            }

        }
        private void alimentaDgv(BindingList<Usuario> listaUsuariosDgv)
        {
            dgvUsuarios.DataSource = listaUsuariosDgv;
            dgvUsuarios.Columns[0].Visible = false;
            dgvUsuarios.Columns[1].HeaderText = "Usuário";
            dgvUsuarios.Columns[2].Visible = false;
            dgvUsuarios.Columns[3].Visible = false;
            dgvUsuarios.Columns[4].HeaderText = "Ativo";
        }
        private Boolean ValidaCampos()
        {
            if (txtUser.Text == string.Empty)
            {
                MessageBox.Show("Campo Usuário não foi preenchido!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtSenhaU.Text == string.Empty)
            {
                MessageBox.Show("Campo Senha não foi preenchido!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private void LimpaCampos()
        {
            txtIdU.Text = string.Empty;
            txtUser.Text = string.Empty;
            txtSenhaU.Text = string.Empty;
            ckbAdmin.Checked = false;
            dgvUsuarios.ClearSelection();
        }
        private void preencheCampos(int index)
        {
            txtIdU.Text = listaUsuarios[index].Id_usuario.ToString();
            txtUser.Text = listaUsuarios[index].User;
            if (listaUsuarios[index].Admin == 1)
            {
                ckbAdmin.Checked = true;
            }
            else
            {
                ckbAdmin.Checked = false;
            }
        }
        public int ValidaCkb()
        {
            if (ckbAdmin.Checked){ admin = 1; }
            else { admin = 0; }
            return admin;
        }
        private void btnIserirU_Click(object sender, EventArgs e)
        {
            if (ValidaCampos())
            {
                try
                {
                    string senhaCrypto = Crypto.sha256encrypt(txtSenhaU.Text);
                    senhaCrypto = senhaCrypto.ToUpper();
                    ValidaCkb();
                    Usuario u = new Usuario(txtUser.Text, senhaCrypto, Convert.ToInt32(admin),1);
                    u.Cadastrausu();
                    MessageBox.Show("Usuário cadastrado", "Usuários", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUser.Focus();
                    LimpaCampos();
                    buscaBanco();
                }
                catch (Exception error)
                {
                    MessageBox.Show("Erro: " + error, "Usuários", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAlterarU_Click(object sender, EventArgs e)
        {
            if (ValidaCampos())
            {
                try
                {
                    ValidaCkb();
                    string senhaCrypto = Crypto.sha256encrypt(txtSenhaU.Text);
                    senhaCrypto = senhaCrypto.ToUpper();
                    Usuario u = new Usuario(Convert.ToInt32(txtIdU.Text), txtUser.Text, senhaCrypto, Convert.ToInt32(ckbAdmin.Text));
                    MessageBox.Show("Usuário alterado", "Usuários", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    u.AlteraUsu();
                    txtUser.Focus();
                    LimpaCampos();
                    buscaBanco();
                }
                catch (Exception error)
                {
                    MessageBox.Show("Erro: " + error, string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnExcluirU_Click(object sender, EventArgs e)
        {
            DialogResult question = MessageBox.Show("Realmente deseja que esse usuário seja excluido?", "Usuários", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (question == DialogResult.Yes)
            {
                try
                {
                    Usuario u = new Usuario();
                    u.DeletaUso(Convert.ToInt32(txtIdU.Text));
                    MessageBox.Show("Usuário excluido", "Usuários", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUser.Focus();
                    LimpaCampos();
                    buscaBanco();
                }
                catch (Exception error)
                {

                    MessageBox.Show("Erro: " + error, string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvUsuarios_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            preencheCampos(e.RowIndex);
        }

        private void btnDesativar_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario u = new Usuario();
                u.DesativaAtivaUsu(Convert.ToInt32(txtIdU.Text), 0);
                MessageBox.Show("Usuário destivado", "Usuários", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUser.Focus();
                LimpaCampos();
                buscaBanco();
            }
            catch (Exception error)
            {

                MessageBox.Show("Erro: " + error, string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAtivar_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario u = new Usuario();
                u.DesativaAtivaUsu(Convert.ToInt32(txtIdU.Text), 1);
                MessageBox.Show("Usuário reativado", "Usuários", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUser.Focus();
                LimpaCampos();
                buscaBanco();
            }
            catch (Exception error)
            {

                MessageBox.Show("Erro: " + error, string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpaCampos();
        }
    }
}
