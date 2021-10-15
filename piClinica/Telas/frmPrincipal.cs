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
        private List<Agendamento> listaAgenda;
        private BindingList<Agendamento> listaAgendaDgv;
        public frmPrincipal(Usuario usu)
        {
            InitializeComponent();
            usuLogado = usu;
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
            lblUsuLogado.Text = usuLogado.User.ToUpper();
            lblUsuLogado.Visible = true;
            if (usuLogado.Admin == 1)
            {
                usuáriosToolStripMenuItem.Visible = true;
                usuáriosToolStripMenuItem.Enabled = true;
            }
        }
        private void pacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPacientes p = new frmPacientes(usuLogado);
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
            frmAgendamentos a = new frmAgendamentos(usuLogado);
            a.ShowDialog();
        }

        private void dtpPrincipal_ValueChanged(object sender, EventArgs e)
        {
            buscaBanco();
        }

        private void históricoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHistorico h = new frmHistorico(usuLogado);
            h.ShowDialog();
        }
    }
}
