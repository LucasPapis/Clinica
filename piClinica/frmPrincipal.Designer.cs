
namespace piClinica
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.médicosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agendmentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblUsuLogado = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvAgenda = new System.Windows.Forms.DataGridView();
            this.id_agenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SobrenomeM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Crm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.espec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SobrenomeP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dt_nasc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexoP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgenda)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(1132, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome do usuário logado";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.agendmentosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1076, 24);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pacientesToolStripMenuItem,
            this.médicosToolStripMenuItem,
            this.usuáriosToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // pacientesToolStripMenuItem
            // 
            this.pacientesToolStripMenuItem.Name = "pacientesToolStripMenuItem";
            this.pacientesToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.pacientesToolStripMenuItem.Text = "Pacientes";
            this.pacientesToolStripMenuItem.Click += new System.EventHandler(this.pacientesToolStripMenuItem_Click);
            // 
            // médicosToolStripMenuItem
            // 
            this.médicosToolStripMenuItem.Name = "médicosToolStripMenuItem";
            this.médicosToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.médicosToolStripMenuItem.Text = "Médicos";
            this.médicosToolStripMenuItem.Click += new System.EventHandler(this.médicosToolStripMenuItem_Click);
            // 
            // usuáriosToolStripMenuItem
            // 
            this.usuáriosToolStripMenuItem.Enabled = false;
            this.usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            this.usuáriosToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.usuáriosToolStripMenuItem.Text = "Usuários";
            this.usuáriosToolStripMenuItem.Visible = false;
            this.usuáriosToolStripMenuItem.Click += new System.EventHandler(this.usuáriosToolStripMenuItem_Click);
            // 
            // agendmentosToolStripMenuItem
            // 
            this.agendmentosToolStripMenuItem.Name = "agendmentosToolStripMenuItem";
            this.agendmentosToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.agendmentosToolStripMenuItem.Text = "Agendamentos";
            this.agendmentosToolStripMenuItem.Click += new System.EventHandler(this.agendmentosToolStripMenuItem_Click_1);
            // 
            // lblUsuLogado
            // 
            this.lblUsuLogado.AutoSize = true;
            this.lblUsuLogado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuLogado.Location = new System.Drawing.Point(879, 24);
            this.lblUsuLogado.Name = "lblUsuLogado";
            this.lblUsuLogado.Size = new System.Drawing.Size(57, 20);
            this.lblUsuLogado.TabIndex = 24;
            this.lblUsuLogado.Text = "label2";
            this.lblUsuLogado.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblUsuLogado.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(834, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 24);
            this.label2.TabIndex = 25;
            this.label2.Text = "Sessão de:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dgvAgenda
            // 
            this.dgvAgenda.AllowUserToAddRows = false;
            this.dgvAgenda.AllowUserToDeleteRows = false;
            this.dgvAgenda.AllowUserToResizeColumns = false;
            this.dgvAgenda.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvAgenda.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAgenda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAgenda.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAgenda.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAgenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_agenda,
            this.data,
            this.hora,
            this.Descricao,
            this.NomeM,
            this.SobrenomeM,
            this.Crm,
            this.espec,
            this.NomeP,
            this.SobrenomeP,
            this.dt_nasc,
            this.sexoP});
            this.dgvAgenda.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAgenda.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAgenda.Location = new System.Drawing.Point(3, 47);
            this.dgvAgenda.MultiSelect = false;
            this.dgvAgenda.Name = "dgvAgenda";
            this.dgvAgenda.ReadOnly = true;
            this.dgvAgenda.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvAgenda.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAgenda.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAgenda.RowHeadersVisible = false;
            this.dgvAgenda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAgenda.Size = new System.Drawing.Size(1069, 430);
            this.dgvAgenda.TabIndex = 27;
            // 
            // id_agenda
            // 
            this.id_agenda.FillWeight = 111.6751F;
            this.id_agenda.HeaderText = "Agendamento(ID)";
            this.id_agenda.Name = "id_agenda";
            this.id_agenda.ReadOnly = true;
            // 
            // data
            // 
            this.data.FillWeight = 98.8325F;
            this.data.HeaderText = "Data";
            this.data.Name = "data";
            this.data.ReadOnly = true;
            // 
            // hora
            // 
            this.hora.FillWeight = 98.8325F;
            this.hora.HeaderText = "Hora";
            this.hora.Name = "hora";
            this.hora.ReadOnly = true;
            // 
            // Descricao
            // 
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            this.Descricao.Visible = false;
            // 
            // NomeM
            // 
            this.NomeM.FillWeight = 98.8325F;
            this.NomeM.HeaderText = "Nome do médico";
            this.NomeM.Name = "NomeM";
            this.NomeM.ReadOnly = true;
            // 
            // SobrenomeM
            // 
            this.SobrenomeM.FillWeight = 98.8325F;
            this.SobrenomeM.HeaderText = "Sobrenome do médico";
            this.SobrenomeM.Name = "SobrenomeM";
            this.SobrenomeM.ReadOnly = true;
            // 
            // Crm
            // 
            this.Crm.FillWeight = 98.8325F;
            this.Crm.HeaderText = "CRM";
            this.Crm.Name = "Crm";
            this.Crm.ReadOnly = true;
            // 
            // espec
            // 
            this.espec.FillWeight = 98.8325F;
            this.espec.HeaderText = "Especialidade";
            this.espec.Name = "espec";
            this.espec.ReadOnly = true;
            // 
            // NomeP
            // 
            this.NomeP.FillWeight = 98.8325F;
            this.NomeP.HeaderText = "Nome do Paciente";
            this.NomeP.Name = "NomeP";
            this.NomeP.ReadOnly = true;
            // 
            // SobrenomeP
            // 
            this.SobrenomeP.FillWeight = 98.8325F;
            this.SobrenomeP.HeaderText = "Sobrenome do paciente";
            this.SobrenomeP.Name = "SobrenomeP";
            this.SobrenomeP.ReadOnly = true;
            // 
            // dt_nasc
            // 
            this.dt_nasc.FillWeight = 98.8325F;
            this.dt_nasc.HeaderText = "Data de nascimento";
            this.dt_nasc.Name = "dt_nasc";
            this.dt_nasc.ReadOnly = true;
            // 
            // sexoP
            // 
            this.sexoP.FillWeight = 98.8325F;
            this.sexoP.HeaderText = "Sexo do paciente";
            this.sexoP.Name = "sexoP";
            this.sexoP.ReadOnly = true;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 535);
            this.Controls.Add(this.dgvAgenda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblUsuLogado);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pacientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem médicosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendmentosToolStripMenuItem;
        private System.Windows.Forms.Label lblUsuLogado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem usuáriosToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvAgenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_agenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
        private System.Windows.Forms.DataGridViewTextBoxColumn hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeM;
        private System.Windows.Forms.DataGridViewTextBoxColumn SobrenomeM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Crm;
        private System.Windows.Forms.DataGridViewTextBoxColumn espec;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeP;
        private System.Windows.Forms.DataGridViewTextBoxColumn SobrenomeP;
        private System.Windows.Forms.DataGridViewTextBoxColumn dt_nasc;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexoP;
    }
}

