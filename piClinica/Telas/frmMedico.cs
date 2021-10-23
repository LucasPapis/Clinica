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
    public partial class frmMedico : Form
    {
        //Declaração da lista de pacientes
        private List<Medico> listaMed = new List<Medico>();
        //Declaração do bindingList para o dataGrid
        private BindingList<Medico> listaMedDgv;
        //Passando sessão do usu logado
        private Usuario usuLogado;
        public frmMedico(Usuario usu)
        {
            InitializeComponent();
            usuLogado = usu;
        }
        private void frmMedico_Load(object sender, EventArgs e)
        {
            buscaBanco();
            lblUsuLogado.Text = usuLogado.User.ToUpper();
        }
        private void buscaBanco()
        {
            listaMed = Medico.BuscaMed();
            //Carregando o Binding para passar pro DataGrid
            listaMedDgv = new BindingList<Medico>(listaMed);
            alimentaDgv(listaMedDgv);
            LimpaCampos();
        }
        private void alimentaDgv(BindingList<Medico> listaMedDgv)
        {
            dgvMedicos.DataSource = listaMedDgv;
            dgvMedicos.Columns[0].Visible = false;
            dgvMedicos.Columns[1].HeaderText = "Nome";
            dgvMedicos.Columns[2].HeaderText = "Sobrenome";
            dgvMedicos.Columns[3].HeaderText = "CRM";
            dgvMedicos.Columns[4].Visible = false;
            dgvMedicos.Columns[5].HeaderText = "Especialidade";
            dgvMedicos.Columns[6].Visible = false;
            dgvMedicos.Columns[7].Visible = false;
            dgvMedicos.Columns[8].Visible = false;
            dgvMedicos.Columns[9].Visible = false;
        }
        private Boolean ValidaCampos()
        {
            if (txtNomeM.Text == string.Empty)
            {
                MessageBox.Show("Campo ome não foi preenchido!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtSobrenomeM.Text == string.Empty)
            {
                MessageBox.Show("Campo Sobrenome não foi preenchido!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtEspec.Text == string.Empty)
            {
                MessageBox.Show("Campo Especialidade não foi preenchido!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtCrm.Text == string.Empty)
            {
                MessageBox.Show("Campo CRM não foi preenchido!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtSenhaM.Text == string.Empty)
            {
                MessageBox.Show("Campo Senha não foi preenchido!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (mskCpfM.Text == string.Empty)
            {
                MessageBox.Show("Campo CPF não foi preenchido!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private void LimpaCampos()
        {
            txtIdM.Text = string.Empty;
            txtNomeM.Text = string.Empty;
            txtSobrenomeM.Text = string.Empty;
            txtEspec.Text = string.Empty;
            txtCrm.Text = string.Empty;
            txtSenhaM.Text = string.Empty;
            txtSenhaM.Enabled = true;
            mskCpfM.Text = string.Empty;
            dgvMedicos.ClearSelection();
        }
        private void preencheCampos(int index)
        {
            txtIdM.Text = listaMed[index].Id_medico.ToString();
            txtNomeM.Text = listaMed[index].Nome;
            txtSobrenomeM.Text = listaMed[index].Sobrenome;
            txtCrm.Text = listaMed[index].Crm.ToString();
            txtEspec.Text = listaMed[index].Espec;
            txtSenhaM.Enabled = false;
            txtSenhaM.Text = listaMed[index].Senha;
            mskCpfM.Text = listaMed[index].Cpf;
        }

        private void btnIserir_Click(object sender, EventArgs e)
        {
            if (ValidaCampos())
            {
                try
                {
                    string senhaCrypto = Crypto.sha256encrypt(txtSenhaM.Text);
                    senhaCrypto = senhaCrypto.ToUpper();
                    Medico m = new Medico(txtNomeM.Text, txtSobrenomeM.Text, Convert.ToInt32(txtCrm.Text), senhaCrypto, txtEspec.Text, mskCpfM.Text, 1);
                    m.CadastraMed();
                    MessageBox.Show("Médico cadastrado", "Médicos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNomeM.Focus();
                    LimpaCampos();
                    buscaBanco();
                }
                catch (Exception error)
                {
                    MessageBox.Show("Erro: " + error, "Usuários", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (ValidaCampos())
            {
                try
                {
                    string senhaCrypto = Crypto.sha256encrypt(txtSenhaM.Text);
                    senhaCrypto = senhaCrypto.ToUpper();
                    Medico m = new Medico(Convert.ToInt32(txtIdM.Text), txtNomeM.Text, txtSobrenomeM.Text, Convert.ToInt32(txtCrm.Text), senhaCrypto, txtEspec.Text, mskCpfM.Text);
                    m.AlteraMed();
                    MessageBox.Show("Médico alterado", "Médicos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNomeM.Focus();
                    LimpaCampos();
                    buscaBanco();
                }
                catch (Exception error)
                {
                    MessageBox.Show("Erro: " + error, string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult question = MessageBox.Show("Realmente deseja que esse médico seja excluido?", "Médicos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (question == DialogResult.Yes)
            {
                try
                {
                    Medico m = new Medico();
                    m.DeletaUso(Convert.ToInt32(txtIdM.Text));
                    MessageBox.Show("Médico excluido", "Médicos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNomeM.Focus();
                    LimpaCampos();
                    buscaBanco();
                }
                catch (Exception error)
                {

                    MessageBox.Show("Erro: " + error, string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAtivar_Click(object sender, EventArgs e)
        {
            try
            {
                Medico m = new Medico();
                m.DesativaAtivaMed(Convert.ToInt32(txtIdM.Text), 1);
                MessageBox.Show("Médico reativado", "Médicos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNomeM.Focus();
                LimpaCampos();
                buscaBanco();
            }
            catch (Exception error)
            {

                MessageBox.Show("Erro: " + error, string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDesativar_Click(object sender, EventArgs e)
        {
            try
            {
                Medico m = new Medico();
                m.DesativaAtivaMed(Convert.ToInt32(txtIdM.Text), 0);
                MessageBox.Show("Médico destivado", "Médicos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNomeM.Focus();
                LimpaCampos();
                buscaBanco();
            }
            catch (Exception error)
            {

                MessageBox.Show("Erro: " + error, string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvMedicos_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            preencheCampos(e.RowIndex);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            LimpaCampos();
        }
    }
}
