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
    public partial class frmAgendamentos : Form
    {
        //Declaração da lista
        private List<Agendamento> listaMedA = new List<Agendamento>();
        private List<Paciente> listaPacientesEspec = new List<Paciente>();
        //Declaração do bindingList para o dataGrid
        private BindingList<Agendamento> listaMedADgv;
        //Passando sessão do usu logado
        private Usuario usuLogado;
        private string nome, sobrenome, cpf;
        public frmAgendamentos()
        {
            InitializeComponent();
        }
        private void frmAgendamentos_Load(object sender, EventArgs e)
        {
            buscaBanco();
            cbbHora.SelectedIndex = 0;
        }
        private Boolean ValidaBuscaP()
        {
            if (txtNomeP.Text == string.Empty && txtSobrenomeP.Text == string.Empty && mskCpfP.Text == string.Empty)
            {
                MessageBox.Show("Algum dos campos Nome, sobrenome ou cpf deve ser preenchidos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                if (mskCpfP.Text != "   ,   ,   -")
                {
                    cpf = mskCpfP.Text;  
                }
                if (txtNomeP.Text != string.Empty)
                {
                    nome = "%" + txtNomeP.Text + "%";
                }
                if (txtSobrenomeP.Text != string.Empty)
                {
                    sobrenome = "%" + txtSobrenomeP.Text + "%";
                }
                return true;
            }
            
        }
        private void PreencheCampoM(int index)
        {
            txtIdM.Text = listaMedA[index].DadosMedico.Id_medico.ToString();
            txtIdA.Text = listaMedA[index].Id_agenda.ToString();
            txtDescricao.Text = listaMedA[index].Descricao;
        }
        private void PreencheCamposP()
        {
            listaPacientesEspec = Paciente.BuscaPacientesEspe(nome, sobrenome, cpf);
            txtIdP.Text = listaPacientesEspec[0].Id_paciente.ToString();
            txtNomeP.Text = listaPacientesEspec[0].Nome;
            txtSobrenomeP.Text = listaPacientesEspec[0].Sobrenome;
            mskCpfP.Text = listaPacientesEspec[0].Cpf;
            mskRgP.Text = listaPacientesEspec[0].Rg;
            txtPesoP.Text = listaPacientesEspec[0].Peso;
            mskTelP.Text = listaPacientesEspec[0].Telefone;
            txtConvenioP.Text = listaPacientesEspec[0].Plano_saude;
            txtAlturaP.Text = listaPacientesEspec[0].Altura;
        }

        private void btnCadastra_Click(object sender, EventArgs e)
        {
            try
            {
                Agendamento a = new Agendamento(Convert.ToInt32(txtIdP.Text), Convert.ToInt32(txtIdM.Text), mskData.Text,cbbHora.Text, txtDescricao.Text);
                a.CadastraConsulta();
                MessageBox.Show("Consulta agendada", "Agendamento", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpaCampos();
                txtNomeP.Focus();
                buscaBanco();
            }
            catch (Exception)
            {
                MessageBox.Show("Consulta já agendada ", "Agendamento", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buscaBanco()
        {
            dgvAgenda.Rows.Clear();
            listaMedA.Clear();
            listaMedA = Agendamento.BuscaMed();
            //Carregando o Binding para passar pro DataGrid
            listaMedADgv = new BindingList<Agendamento>(listaMedA);
            alimentaDgv();
            LimpaCampos();
        }
        private void alimentaDgv()
        {

            for (int i = 0; i < listaMedA.Count; i++)
            {
                dgvAgenda.Rows.Add(listaMedA[i].Id_agenda, listaMedA[i].Data, listaMedA[i].Hora,
                    listaMedA[i].DadosMedico.Id_medico, listaMedA[i].DadosMedico.Nome, 
                    listaMedA[i].DadosMedico.Sobrenome, listaMedA[i].DadosMedico.Crm, 
                    listaMedA[i].DadosMedico.Espec, listaMedA[i].Descricao);
            }
        }

        private void dgvAgenda_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            PreencheCampoM(e.RowIndex);
        }
        private void LimpaCampos()
        {
            txtNomeP.Text = string.Empty;
            txtSobrenomeP.Text = string.Empty;
            mskRgP.Text = string.Empty;
            mskCpfP.Text = string.Empty;
            mskTelP.Text = string.Empty;
            txtPesoP.Text = string.Empty;
            txtAlturaP.Text = string.Empty;
            txtConvenioP.Text = string.Empty;
            txtTipoConsul.Text = string.Empty;
            mskData.Text = string.Empty;
            cbbHora.SelectedIndex = 0;
            txtDescricao.Text = string.Empty;
            dgvAgenda.ClearSelection();
        }
        private void btnCnacelaP_Click(object sender, EventArgs e)
        {
            LimpaCampos();
        }

        private void btnRemarcar_Click(object sender, EventArgs e)
        {
            try
            {
                Agendamento a = new Agendamento(Convert.ToInt32(txtIdA.Text),Convert.ToInt32(txtIdP.Text), Convert.ToInt32(txtIdM.Text), mskData.Text, cbbHora.Text, txtDescricao.Text);
                a.RemarcarConsulta();
                MessageBox.Show("Consulta Remarcada", "Remarcar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpaCampos();
                txtNomeP.Focus();
                buscaBanco();
            }
            catch (Exception error)
            {
                MessageBox.Show("Algo inesperado aconteceu " +error, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDesmarcar_Click(object sender, EventArgs e)
        {
            try
            {
                Agendamento a = new Agendamento();
                a.DesmarcaConsulta(Convert.ToInt32(txtIdA.Text));
                MessageBox.Show("Consulta Desmarcada", "Desmarcar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpaCampos();
                txtNomeP.Focus();
                buscaBanco();
            }
            catch (Exception error)
            {
                MessageBox.Show("Algo inesperado aconteceu " +error, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPesqC_Click(object sender, EventArgs e)
        {
            if (txtTipoConsul.Text == string.Empty)
            {
                dgvAgenda.Rows.Clear();
                buscaBanco();
            }
            else
            {
                try
                {
                    dgvAgenda.Rows.Clear();
                    listaMedA.Clear();
                    listaMedA = Agendamento.BuscaMedDispo(txtTipoConsul.Text);
                    listaMedADgv = new BindingList<Agendamento>(listaMedA);
                    alimentaDgv();
                }
                catch (Exception)
                {

                    MessageBox.Show("Não encontrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnPesqP_Click(object sender, EventArgs e)
        {
            if (ValidaBuscaP())
            {
                PreencheCamposP();
            }
        }
    }
}
