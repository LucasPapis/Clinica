
namespace piClinica.Telas
{
    partial class frmHistorico
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gpbDados = new System.Windows.Forms.GroupBox();
            this.txtIdP = new System.Windows.Forms.TextBox();
            this.btnPesqP = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtConvenioP = new System.Windows.Forms.TextBox();
            this.txtAlturaP = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPesoP = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.mskTelP = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.mskRgP = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.mskCpfP = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSobrenomeP = new System.Windows.Forms.TextBox();
            this.txtNomeP = new System.Windows.Forms.TextBox();
            this.dgvHistorico = new System.Windows.Forms.DataGridView();
            this.IdA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idMed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SobrenomeM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Crm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Espec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblUsuLogado = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gpbDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorico)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbDados
            // 
            this.gpbDados.Controls.Add(this.txtIdP);
            this.gpbDados.Controls.Add(this.btnPesqP);
            this.gpbDados.Controls.Add(this.label10);
            this.gpbDados.Controls.Add(this.txtConvenioP);
            this.gpbDados.Controls.Add(this.txtAlturaP);
            this.gpbDados.Controls.Add(this.label9);
            this.gpbDados.Controls.Add(this.txtPesoP);
            this.gpbDados.Controls.Add(this.label8);
            this.gpbDados.Controls.Add(this.mskTelP);
            this.gpbDados.Controls.Add(this.label7);
            this.gpbDados.Controls.Add(this.mskRgP);
            this.gpbDados.Controls.Add(this.label6);
            this.gpbDados.Controls.Add(this.mskCpfP);
            this.gpbDados.Controls.Add(this.label5);
            this.gpbDados.Controls.Add(this.label3);
            this.gpbDados.Controls.Add(this.label2);
            this.gpbDados.Controls.Add(this.txtSobrenomeP);
            this.gpbDados.Controls.Add(this.txtNomeP);
            this.gpbDados.Location = new System.Drawing.Point(12, 56);
            this.gpbDados.Name = "gpbDados";
            this.gpbDados.Size = new System.Drawing.Size(355, 204);
            this.gpbDados.TabIndex = 38;
            this.gpbDados.TabStop = false;
            this.gpbDados.Text = "Dados do Paciente";
            // 
            // txtIdP
            // 
            this.txtIdP.Enabled = false;
            this.txtIdP.Location = new System.Drawing.Point(286, 39);
            this.txtIdP.Name = "txtIdP";
            this.txtIdP.Size = new System.Drawing.Size(39, 20);
            this.txtIdP.TabIndex = 44;
            this.txtIdP.Visible = false;
            // 
            // btnPesqP
            // 
            this.btnPesqP.Location = new System.Drawing.Point(250, 168);
            this.btnPesqP.Name = "btnPesqP";
            this.btnPesqP.Size = new System.Drawing.Size(75, 23);
            this.btnPesqP.TabIndex = 43;
            this.btnPesqP.Text = "Pesquisar";
            this.btnPesqP.UseVisualStyleBackColor = true;
            this.btnPesqP.Click += new System.EventHandler(this.btnPesqP_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 156);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 32;
            this.label10.Text = "Convênio:";
            // 
            // txtConvenioP
            // 
            this.txtConvenioP.Enabled = false;
            this.txtConvenioP.Location = new System.Drawing.Point(6, 172);
            this.txtConvenioP.Name = "txtConvenioP";
            this.txtConvenioP.Size = new System.Drawing.Size(109, 20);
            this.txtConvenioP.TabIndex = 31;
            // 
            // txtAlturaP
            // 
            this.txtAlturaP.Enabled = false;
            this.txtAlturaP.Location = new System.Drawing.Point(144, 171);
            this.txtAlturaP.Name = "txtAlturaP";
            this.txtAlturaP.Size = new System.Drawing.Size(63, 20);
            this.txtAlturaP.TabIndex = 30;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(143, 155);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Altura:";
            // 
            // txtPesoP
            // 
            this.txtPesoP.Enabled = false;
            this.txtPesoP.Location = new System.Drawing.Point(6, 127);
            this.txtPesoP.Name = "txtPesoP";
            this.txtPesoP.Size = new System.Drawing.Size(63, 20);
            this.txtPesoP.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Peso:";
            // 
            // mskTelP
            // 
            this.mskTelP.Enabled = false;
            this.mskTelP.Location = new System.Drawing.Point(144, 127);
            this.mskTelP.Mask = "(00) 00000-0000";
            this.mskTelP.Name = "mskTelP";
            this.mskTelP.Size = new System.Drawing.Size(88, 20);
            this.mskTelP.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(143, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Telefone:";
            // 
            // mskRgP
            // 
            this.mskRgP.Enabled = false;
            this.mskRgP.Location = new System.Drawing.Point(146, 82);
            this.mskRgP.Mask = "00.000.000-0";
            this.mskRgP.Name = "mskRgP";
            this.mskRgP.Size = new System.Drawing.Size(70, 20);
            this.mskRgP.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(141, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "RG:";
            // 
            // mskCpfP
            // 
            this.mskCpfP.Location = new System.Drawing.Point(6, 82);
            this.mskCpfP.Mask = "000.000.000-00";
            this.mskCpfP.Name = "mskCpfP";
            this.mskCpfP.Size = new System.Drawing.Size(82, 20);
            this.mskCpfP.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(141, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Sobrenome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "CPF:";
            // 
            // txtSobrenomeP
            // 
            this.txtSobrenomeP.Location = new System.Drawing.Point(144, 39);
            this.txtSobrenomeP.Name = "txtSobrenomeP";
            this.txtSobrenomeP.Size = new System.Drawing.Size(109, 20);
            this.txtSobrenomeP.TabIndex = 15;
            // 
            // txtNomeP
            // 
            this.txtNomeP.Location = new System.Drawing.Point(6, 39);
            this.txtNomeP.Name = "txtNomeP";
            this.txtNomeP.Size = new System.Drawing.Size(83, 20);
            this.txtNomeP.TabIndex = 14;
            // 
            // dgvHistorico
            // 
            this.dgvHistorico.AllowUserToAddRows = false;
            this.dgvHistorico.AllowUserToDeleteRows = false;
            this.dgvHistorico.AllowUserToResizeColumns = false;
            this.dgvHistorico.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvHistorico.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHistorico.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHistorico.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHistorico.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHistorico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdA,
            this.DataA,
            this.HoraA,
            this.idMed,
            this.NomeM,
            this.SobrenomeM,
            this.Crm,
            this.Espec,
            this.descricao});
            this.dgvHistorico.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHistorico.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvHistorico.Location = new System.Drawing.Point(5, 266);
            this.dgvHistorico.MultiSelect = false;
            this.dgvHistorico.Name = "dgvHistorico";
            this.dgvHistorico.ReadOnly = true;
            this.dgvHistorico.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvHistorico.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHistorico.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvHistorico.RowHeadersVisible = false;
            this.dgvHistorico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHistorico.Size = new System.Drawing.Size(526, 252);
            this.dgvHistorico.TabIndex = 45;
            this.dgvHistorico.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHistorico_RowEnter);
            // 
            // IdA
            // 
            this.IdA.HeaderText = "Id Agenda";
            this.IdA.Name = "IdA";
            this.IdA.ReadOnly = true;
            this.IdA.Visible = false;
            // 
            // DataA
            // 
            this.DataA.HeaderText = "Data";
            this.DataA.Name = "DataA";
            this.DataA.ReadOnly = true;
            // 
            // HoraA
            // 
            this.HoraA.HeaderText = "Hora";
            this.HoraA.Name = "HoraA";
            this.HoraA.ReadOnly = true;
            // 
            // idMed
            // 
            this.idMed.HeaderText = "Id";
            this.idMed.Name = "idMed";
            this.idMed.ReadOnly = true;
            this.idMed.Visible = false;
            // 
            // NomeM
            // 
            this.NomeM.HeaderText = "Nome do medico";
            this.NomeM.Name = "NomeM";
            this.NomeM.ReadOnly = true;
            // 
            // SobrenomeM
            // 
            this.SobrenomeM.HeaderText = "Sobrenome do médico";
            this.SobrenomeM.Name = "SobrenomeM";
            this.SobrenomeM.ReadOnly = true;
            // 
            // Crm
            // 
            this.Crm.HeaderText = "CRM";
            this.Crm.Name = "Crm";
            this.Crm.ReadOnly = true;
            // 
            // Espec
            // 
            this.Espec.HeaderText = "Especialidade";
            this.Espec.Name = "Espec";
            this.Espec.ReadOnly = true;
            // 
            // descricao
            // 
            this.descricao.HeaderText = "Descrição";
            this.descricao.Name = "descricao";
            this.descricao.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 33);
            this.label1.TabIndex = 46;
            this.label1.Text = "Historico de consultas";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(370, 191);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(116, 13);
            this.label13.TabIndex = 52;
            this.label13.Text = "Descrição da consulta:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(373, 207);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(158, 53);
            this.txtDescricao.TabIndex = 51;
            // 
            // lblUsuLogado
            // 
            this.lblUsuLogado.AutoSize = true;
            this.lblUsuLogado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuLogado.Location = new System.Drawing.Point(406, 92);
            this.lblUsuLogado.Name = "lblUsuLogado";
            this.lblUsuLogado.Size = new System.Drawing.Size(68, 24);
            this.lblUsuLogado.TabIndex = 54;
            this.lblUsuLogado.Text = "name:";
            this.lblUsuLogado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(405, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 29);
            this.label4.TabIndex = 53;
            this.label4.Text = "Usuário:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmHistorico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 524);
            this.Controls.Add(this.lblUsuLogado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvHistorico);
            this.Controls.Add(this.gpbDados);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(553, 563);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(553, 563);
            this.Name = "frmHistorico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historico";
            this.Load += new System.EventHandler(this.frmHistorico_Load);
            this.gpbDados.ResumeLayout(false);
            this.gpbDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gpbDados;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtConvenioP;
        private System.Windows.Forms.TextBox txtAlturaP;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPesoP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox mskTelP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox mskRgP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mskCpfP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSobrenomeP;
        private System.Windows.Forms.TextBox txtNomeP;
        private System.Windows.Forms.Button btnPesqP;
        private System.Windows.Forms.TextBox txtIdP;
        private System.Windows.Forms.DataGridView dgvHistorico;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdA;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataA;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraA;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMed;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeM;
        private System.Windows.Forms.DataGridViewTextBoxColumn SobrenomeM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Crm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Espec;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblUsuLogado;
        private System.Windows.Forms.Label label4;
    }
}