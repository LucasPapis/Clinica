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
using piClinica.Telas;
using piClinica;

namespace piClinica
{
    public partial class frmPrincipal : Form
    {
        private Usuario usuLogado;
        private Medico medLogado;
        private List<Agendamento> listaAgenda;
        private BindingList<Agendamento> listaAgendaDgv;
        public frmPrincipal(Usuario usu, Medico med)
        {
            InitializeComponent();
            usuLogado = usu;
            medLogado = med;
        }
        private void alimentaDgv(BindingList<Agendamento> listaAgendaDgv)
        {
            for (int i = 0; i < listaAgenda.Count; i++)
            {
                dgvAgenda.Rows.Add(listaAgenda[i].Id_agenda, listaAgenda[i].Data,
                    listaAgenda[i].Hora, listaAgenda[i].Descricao, listaAgenda[i].DadosMedico.Nome,
                    listaAgenda[i].DadosMedico.Sobrenome, listaAgenda[i].DadosMedico.Crm,
                    listaAgenda[i].DadosMedico.Espec, listaAgenda[i].DadosPaciente.Nome,
                    listaAgenda[i].DadosPaciente.Sobrenome, listaAgenda[i].DadosPaciente.Dt_nasc,
                    listaAgenda[i].DadosPaciente.Sexo);
            }
        }
        private void buscaBanco()
        {
            listaAgenda = Agendamento.BuscaAgenda(dtpPrincipal.Text);
            //Carregando o Binding para passar pro DataGrid
            listaAgendaDgv = new BindingList<Agendamento>(listaAgenda);
            alimentaDgv(listaAgendaDgv);
            //LimpaCampos();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            buscaBanco();
            if (usuLogado.User != null)
            {
                lblUsuLogado.Text = usuLogado.User.ToUpper();
            }
            else
            {
                lblUsuLogado.Text = "Dr/Dra. " + medLogado.Nome.ToUpper();
            }
                lblUsuLogado.Visible = true;
            if (usuLogado.Admin == 1 && medLogado.Nome == null)
            {
                usuáriosToolStripMenuItem.Visible = true;
                usuáriosToolStripMenuItem.Enabled = true;
            }
            if (medLogado.Nome == null)
            {
                médicosToolStripMenuItem.Visible = true;
                médicosToolStripMenuItem.Enabled = true;
            }
        }
        private void pacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPacientes p = new frmPacientes(usuLogado, medLogado);
            p.ShowDialog();

        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuarios fu = new frmUsuarios(usuLogado);
            fu.ShowDialog();
        }

        private void médicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMedico m = new frmMedico(usuLogado);
            m.ShowDialog();
        }

        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void agendmentosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmAgendamentos a = new frmAgendamentos(medLogado,usuLogado);
            a.ShowDialog();
        }

        private void dtpPrincipal_ValueChanged(object sender, EventArgs e)
        {
            buscaBanco();
        }

        private void históricoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHistorico h = new frmHistorico(medLogado,usuLogado);
            h.ShowDialog();
        }
    }
}
