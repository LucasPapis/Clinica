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

namespace piClinica.Telas
{
    public partial class frmHistorico : Form
    {
        //Declaração da lista
        private List<Agendamento> listaHisto = new List<Agendamento>();
        private List<Paciente> listaPacientesEspec = new List<Paciente>();
        //Declaração do bindingList para o dataGrid
        private BindingList<Agendamento> listaHistoDgv;
        //Passando sessão do usu logado
        private Usuario usuLogado;
        private Medico medLogado;
        private string nome, sobrenome, cpf;
        public frmHistorico(Medico med ,Usuario usu)
        {
            InitializeComponent();
            usuLogado = usu;
            medLogado = med;
        }
        private void alimentaDgv(BindingList<Agendamento> listaHistoDgv)
        {
            for (int i = 0; i < listaHisto.Count; i++)
            {
                dgvHistorico.Rows.Add(listaHisto[i].Id_agenda, listaHisto[i].Data, listaHisto[i].Hora,
                    listaHisto[i].DadosMedico.Id_medico, listaHisto[i].DadosMedico.Nome,
                    listaHisto[i].DadosMedico.Sobrenome, listaHisto[i].DadosMedico.Crm,
                    listaHisto[i].DadosMedico.Espec, listaHisto[i].Descricao);
            }
        }
        private void buscaBanco()
        {
            dgvHistorico.Rows.Clear();
            listaHisto.Clear();
            listaHisto = Agendamento.BuscaHisto(Convert.ToInt32(txtIdP.Text));
            //Carregando o Binding para passar pro DataGrid
            listaHistoDgv = new BindingList<Agendamento>(listaHisto);
            alimentaDgv(listaHistoDgv);
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
            dgvHistorico.ClearSelection();
        }
        private void btnPesqP_Click(object sender, EventArgs e)
        {
            if (ValidaBuscaP())
            {
                PreencheCamposP();
                buscaBanco();
            }
        }
        private void PreencheCampo(int index)
        {
            txtDescricao.Text = listaHisto[index].Descricao;
        }
        private void dgvHistorico_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            PreencheCampo(e.RowIndex);
        }

        private void frmHistorico_Load(object sender, EventArgs e)
        {
            if (usuLogado.User != null)
            {
                lblUsuLogado.Text = usuLogado.User.ToUpper();
            }
            else
            {
                lblUsuLogado.Text = "Dr/Dra. " + medLogado.Nome.ToUpper();
            }
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
    }
}
