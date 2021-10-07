using piClinica.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace piClinica
{
    public partial class frmPacientes : Form
    {
        //Declaração da lista de pacientes
        private List<Paciente> listaPacientes = new List<Paciente>();
        //Declaração do bindingList para o dataGrid
        private BindingList<Paciente> listaPacientesDgv;
        //Passando sessão do usu logado
        private Usuario usuLogado;
        public frmPacientes(Usuario usu)
        {
            InitializeComponent();
            usuLogado = usu;
        }
        private void frmPacientes_Load(object sender, EventArgs e)
        {
            cbbSexoP.SelectedIndex = 0;
            cbbEstado.SelectedIndex = 24;
            buscaBanco();
        }

        //Buscar lista no banco
        private void buscaBanco()
        {
            listaPacientes = Paciente.BuscaPacientes();
            //Carregando o Binding para passar pro DataGrid
            listaPacientesDgv = new BindingList<Paciente>(listaPacientes);
            alimentaDgv(listaPacientesDgv);
            LimpaCampos();

        }
        //Metodo para alimentar o dataGrid, recebe a BindingList como parâmetro
        private void alimentaDgv(BindingList<Paciente> listaPacientesDgv)
        {
            dgvPacientes.DataSource = listaPacientesDgv;
            dgvPacientes.Columns[0].HeaderText = "ID do paciente";
            dgvPacientes.Columns[1].HeaderText = "Nome";
            dgvPacientes.Columns[2].HeaderText = "Sobrenome";
            dgvPacientes.Columns[3].Visible = false;
            dgvPacientes.Columns[4].Visible = false;
            dgvPacientes.Columns[5].Visible = false;
            dgvPacientes.Columns[6].Visible = false;
            dgvPacientes.Columns[7].Visible = false;
            dgvPacientes.Columns[8].Visible = false;
            dgvPacientes.Columns[9].Visible = false;
            dgvPacientes.Columns[10].Visible = false;
            dgvPacientes.Columns[11].Visible = false;
            dgvPacientes.Columns[12].Visible = false;
            dgvPacientes.Columns[13].Visible = false;
            dgvPacientes.Columns[14].Visible = false;
            dgvPacientes.Columns[15].Visible = false;
            dgvPacientes.Columns[16].Visible = false;
            dgvPacientes.Columns[17].Visible = false;
            dgvPacientes.Columns[18].Visible = false;
        }
        private Boolean ValidaCampos()
        {
            if (txtNomeP.Text == string.Empty)
            {
                MessageBox.Show("Campo nome não foi preenchido!",string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtNomeP.Text == string.Empty)
            {
                MessageBox.Show("Campo Nome não foi preenchido!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtSobrenomeP.Text == string.Empty)
            {
                MessageBox.Show("Campo Sobrenome não foi preenchido!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (mskNascP.Text == string.Empty)
            {
                MessageBox.Show("Campo Nascimento não foi preenchido!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (mskRgP.Text == string.Empty)
            {
                MessageBox.Show("Campo RG não foi preenchido!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (mskCpfP.Text == string.Empty)
            {
                MessageBox.Show("Campo CPF não foi preenchido!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (mskTelP.Text == string.Empty)
            {
                MessageBox.Show("Campo Telefone não foi preenchido!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtCep.Text == string.Empty)
            {
                MessageBox.Show("Campo Cep não foi preenchido!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtCidade.Text == string.Empty)
            {
                MessageBox.Show("Campo Cidade não foi preenchido!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtRua.Text == string.Empty)
            {
                MessageBox.Show("Campo Rua não foi preenchido!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtNumero.Text == string.Empty)
            {
                MessageBox.Show("Campo Numero não foi preenchido!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private void LimpaCampos()
        {
            txtNomeP.Text = string.Empty;
            txtSobrenomeP.Text = string.Empty;
            mskNascP.Text = string.Empty;
            mskRgP.Text = string.Empty;
            mskCpfP.Text = string.Empty;
            mskTelP.Text = string.Empty;
            txtPesoP.Text = string.Empty;
            txtAlturaP.Text = string.Empty;
            txtConvenioP.Text = string.Empty;
            txtCep.Text = string.Empty;
            txtCidade.Text = string.Empty;
            txtNumero.Text = string.Empty;
            txtRua.Text = string.Empty;
            txtComple.Text = string.Empty;
        }
    
        private void preencheCampos(int index)
        {
            txtIdP.Text = listaPacientes[index].Id_paciente.ToString();
            txtNomeP.Text = listaPacientes[index].Nome;
            txtSobrenomeP.Text = listaPacientes[index].Sobrenome;
            mskNascP.Text = listaPacientes[index].Dt_nasc;
            mskRgP.Text = listaPacientes[index].Rg;
            mskCpfP.Text = listaPacientes[index].Cpf;
            mskTelP.Text = listaPacientes[index].Telefone;
            cbbSexoP.Text = listaPacientes[index].Sexo;
            txtPesoP.Text = listaPacientes[index].Peso;
            txtAlturaP.Text = listaPacientes[index].Altura;
            txtConvenioP.Text = listaPacientes[index].Plano_saude;
            txtCep.Text = listaPacientes[index].Cep;
            txtCidade.Text = listaPacientes[index].Cidade;
            cbbEstado.Text = listaPacientes[index].Estado;
            txtNumero.Text = listaPacientes[index].Numero.ToString();
            txtRua.Text = listaPacientes[index].Rua;
            txtComple.Text = listaPacientes[index].Comple;
        }
        

        private void btnIserir_Click(object sender, EventArgs e)
        {
            if (ValidaCampos())
            {
                try
                {
                    Endereco en = new Endereco(cbbEstado.Text, txtCidade.Text, txtRua.Text, Convert.ToInt32(txtNumero.Text), txtComple.Text, txtCep.Text);
                    Paciente p = new Paciente(txtNomeP.Text, txtSobrenomeP.Text, mskNascP.Text, mskRgP.Text, mskCpfP.Text, mskTelP.Text, cbbSexoP.Text, txtPesoP.Text, txtAlturaP.Text, txtConvenioP.Text, 1);
                    en.CadastraEnder();
                    p.CadastraPaciente(txtCep.Text, Convert.ToInt32(txtNumero.Text));
                    MessageBox.Show("Paciente cadastrado com sucesso", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNomeP.Focus();
                    buscaBanco();
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro: " + erro, string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void dgvPacientes_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            preencheCampos(e.RowIndex);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (ValidaCampos())
            {
                try
                {
                    Endereco en = new Endereco(cbbEstado.Text, txtCidade.Text, txtRua.Text, Convert.ToInt32(txtNumero.Text), txtComple.Text, txtCep.Text);
                    Paciente p = new Paciente(Convert.ToInt32(txtIdP.Text), txtNomeP.Text, txtSobrenomeP.Text, mskNascP.Text, mskRgP.Text, mskCpfP.Text, mskTelP.Text, cbbSexoP.Text, txtPesoP.Text, txtAlturaP.Text, txtConvenioP.Text);
                    en.AlteraEnder();
                    p.AlteraPaciente();
                    MessageBox.Show("Paciente Alterado com sucesso", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNomeP.Focus();
                    buscaBanco();
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro: " + erro, string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult question = MessageBox.Show("Realmente deseja que o paciente seja excluido?","Pacientes", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (question == DialogResult.Yes)
            {
                try
                {
                    Paciente p = new Paciente();
                    p.DesativaAtivaPaciente(Convert.ToInt32(txtIdP.Text), 0);
                    MessageBox.Show("Paciente excluido com sucesso", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNomeP.Focus();
                    buscaBanco();
                }
                catch (Exception error)
                {

                    MessageBox.Show("Erro: " + error, string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscaC.Text != string.Empty)
            {

            }
            else
            {

            }
        }
    }
}
