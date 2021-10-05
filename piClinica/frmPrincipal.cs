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
using piClinica;

namespace piClinica
{
    public partial class frmPrincipal : Form
    {
        Usuario usuLogado;
        public frmPrincipal(Usuario usu)
        {
            InitializeComponent();
            usuLogado = usu;
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            lblUsuLogado.Text = usuLogado.User.ToUpper();
            lblUsuLogado.Visible = true;
        }
        private void pacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPacientes p = new frmPacientes();
            p.Show();


        }
        private void agendmentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgendamentos a = new frmAgendamentos();
            a.Show();
        }

        private void médicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMedico m = new frmMedico();
            m.Show();
        }

    }
}
