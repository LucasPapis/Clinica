﻿
namespace piClinica
{
    partial class frmAgendamentos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvAgenda = new System.Windows.Forms.DataGridView();
            this.gpbDados = new System.Windows.Forms.GroupBox();
            this.btnPesqP = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtIdP = new System.Windows.Forms.TextBox();
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
            this.btnCnacelaP = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbHora = new System.Windows.Forms.ComboBox();
            this.mskData = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtIdM = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPesqC = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.txtTipoConsul = new System.Windows.Forms.TextBox();
            this.btnCadastra = new System.Windows.Forms.Button();
            this.btnRemarcar = new System.Windows.Forms.Button();
            this.btnDesmarcar = new System.Windows.Forms.Button();
            this.txtIdA = new System.Windows.Forms.TextBox();
            this.IdA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idMed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SobrenomeM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Crm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Espec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgenda)).BeginInit();
            this.gpbDados.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(476, 42);
            this.label1.TabIndex = 24;
            this.label1.Text = "Agendamento de consulta";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvAgenda
            // 
            this.dgvAgenda.AllowUserToAddRows = false;
            this.dgvAgenda.AllowUserToDeleteRows = false;
            this.dgvAgenda.AllowUserToResizeColumns = false;
            this.dgvAgenda.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvAgenda.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvAgenda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAgenda.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAgenda.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvAgenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdA,
            this.DataA,
            this.HoraA,
            this.idMed,
            this.NomeM,
            this.SobrenomeM,
            this.Crm,
            this.Espec,
            this.descricao});
            this.dgvAgenda.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAgenda.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvAgenda.Location = new System.Drawing.Point(7, 275);
            this.dgvAgenda.MultiSelect = false;
            this.dgvAgenda.Name = "dgvAgenda";
            this.dgvAgenda.ReadOnly = true;
            this.dgvAgenda.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvAgenda.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAgenda.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvAgenda.RowHeadersVisible = false;
            this.dgvAgenda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAgenda.Size = new System.Drawing.Size(705, 313);
            this.dgvAgenda.TabIndex = 26;
            this.dgvAgenda.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAgenda_RowEnter);
            // 
            // gpbDados
            // 
            this.gpbDados.Controls.Add(this.btnPesqP);
            this.gpbDados.Controls.Add(this.label10);
            this.gpbDados.Controls.Add(this.txtIdP);
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
            this.gpbDados.Location = new System.Drawing.Point(12, 54);
            this.gpbDados.Name = "gpbDados";
            this.gpbDados.Size = new System.Drawing.Size(302, 215);
            this.gpbDados.TabIndex = 27;
            this.gpbDados.TabStop = false;
            this.gpbDados.Text = "Dados do Paciente";
            // 
            // btnPesqP
            // 
            this.btnPesqP.Location = new System.Drawing.Point(213, 186);
            this.btnPesqP.Name = "btnPesqP";
            this.btnPesqP.Size = new System.Drawing.Size(75, 23);
            this.btnPesqP.TabIndex = 42;
            this.btnPesqP.Text = "Pesquisar";
            this.btnPesqP.UseVisualStyleBackColor = true;
            this.btnPesqP.Click += new System.EventHandler(this.btnPesqP_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 156);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 32;
            this.label10.Text = "Convênio:";
            // 
            // txtIdP
            // 
            this.txtIdP.Enabled = false;
            this.txtIdP.Location = new System.Drawing.Point(95, 23);
            this.txtIdP.Name = "txtIdP";
            this.txtIdP.Size = new System.Drawing.Size(37, 20);
            this.txtIdP.TabIndex = 40;
            this.txtIdP.Visible = false;
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
            // btnCnacelaP
            // 
            this.btnCnacelaP.Location = new System.Drawing.Point(634, 240);
            this.btnCnacelaP.Name = "btnCnacelaP";
            this.btnCnacelaP.Size = new System.Drawing.Size(75, 23);
            this.btnCnacelaP.TabIndex = 43;
            this.btnCnacelaP.Text = "Cancelar";
            this.btnCnacelaP.UseVisualStyleBackColor = true;
            this.btnCnacelaP.Click += new System.EventHandler(this.btnCnacelaP_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbbHora);
            this.groupBox1.Controls.Add(this.mskData);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtDescricao);
            this.groupBox1.Controls.Add(this.txtIdM);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnPesqC);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.txtTipoConsul);
            this.groupBox1.Location = new System.Drawing.Point(380, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(192, 215);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados da Consulta";
            // 
            // cbbHora
            // 
            this.cbbHora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbHora.FormattingEnabled = true;
            this.cbbHora.Items.AddRange(new object[] {
            "Selecione",
            "07:00",
            "08:00",
            "09:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00",
            "18:00",
            "19:00"});
            this.cbbHora.Location = new System.Drawing.Point(104, 81);
            this.cbbHora.Name = "cbbHora";
            this.cbbHora.Size = new System.Drawing.Size(77, 21);
            this.cbbHora.TabIndex = 53;
            // 
            // mskData
            // 
            this.mskData.Location = new System.Drawing.Point(6, 82);
            this.mskData.Mask = "00/00/0000";
            this.mskData.Name = "mskData";
            this.mskData.Size = new System.Drawing.Size(65, 20);
            this.mskData.TabIndex = 51;
            this.mskData.ValidatingType = typeof(System.DateTime);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 111);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 13);
            this.label13.TabIndex = 50;
            this.label13.Text = "Motivo da consulta:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(6, 127);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(175, 53);
            this.txtDescricao.TabIndex = 49;
            // 
            // txtIdM
            // 
            this.txtIdM.Enabled = false;
            this.txtIdM.Location = new System.Drawing.Point(124, 13);
            this.txtIdM.Name = "txtIdM";
            this.txtIdM.Size = new System.Drawing.Size(47, 20);
            this.txtIdM.TabIndex = 48;
            this.txtIdM.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(101, 65);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 13);
            this.label11.TabIndex = 47;
            this.label11.Text = "Hora:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "Data:";
            // 
            // btnPesqC
            // 
            this.btnPesqC.Location = new System.Drawing.Point(111, 186);
            this.btnPesqC.Name = "btnPesqC";
            this.btnPesqC.Size = new System.Drawing.Size(75, 23);
            this.btnPesqC.TabIndex = 42;
            this.btnPesqC.Text = "Pesquisar";
            this.btnPesqC.UseVisualStyleBackColor = true;
            this.btnPesqC.Click += new System.EventHandler(this.btnPesqC_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(3, 23);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(89, 13);
            this.label18.TabIndex = 17;
            this.label18.Text = "Tipo de consulta:";
            // 
            // txtTipoConsul
            // 
            this.txtTipoConsul.Location = new System.Drawing.Point(6, 39);
            this.txtTipoConsul.Name = "txtTipoConsul";
            this.txtTipoConsul.Size = new System.Drawing.Size(175, 20);
            this.txtTipoConsul.TabIndex = 14;
            // 
            // btnCadastra
            // 
            this.btnCadastra.Location = new System.Drawing.Point(578, 59);
            this.btnCadastra.Name = "btnCadastra";
            this.btnCadastra.Size = new System.Drawing.Size(75, 23);
            this.btnCadastra.TabIndex = 45;
            this.btnCadastra.Text = "Cadastrar";
            this.btnCadastra.UseVisualStyleBackColor = true;
            this.btnCadastra.Click += new System.EventHandler(this.btnCadastra_Click);
            // 
            // btnRemarcar
            // 
            this.btnRemarcar.Location = new System.Drawing.Point(578, 96);
            this.btnRemarcar.Name = "btnRemarcar";
            this.btnRemarcar.Size = new System.Drawing.Size(75, 23);
            this.btnRemarcar.TabIndex = 46;
            this.btnRemarcar.Text = "Remarcar";
            this.btnRemarcar.UseVisualStyleBackColor = true;
            this.btnRemarcar.Click += new System.EventHandler(this.btnRemarcar_Click);
            // 
            // btnDesmarcar
            // 
            this.btnDesmarcar.Location = new System.Drawing.Point(578, 133);
            this.btnDesmarcar.Name = "btnDesmarcar";
            this.btnDesmarcar.Size = new System.Drawing.Size(75, 23);
            this.btnDesmarcar.TabIndex = 47;
            this.btnDesmarcar.Text = "Desmarcar";
            this.btnDesmarcar.UseVisualStyleBackColor = true;
            this.btnDesmarcar.Click += new System.EventHandler(this.btnDesmarcar_Click);
            // 
            // txtIdA
            // 
            this.txtIdA.Enabled = false;
            this.txtIdA.Location = new System.Drawing.Point(327, 67);
            this.txtIdA.Name = "txtIdA";
            this.txtIdA.Size = new System.Drawing.Size(47, 20);
            this.txtIdA.TabIndex = 54;
            this.txtIdA.Visible = false;
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
            // frmAgendamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 596);
            this.Controls.Add(this.txtIdA);
            this.Controls.Add(this.btnDesmarcar);
            this.Controls.Add(this.btnRemarcar);
            this.Controls.Add(this.btnCnacelaP);
            this.Controls.Add(this.btnCadastra);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gpbDados);
            this.Controls.Add(this.dgvAgenda);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAgendamentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agendamentos";
            this.Load += new System.EventHandler(this.frmAgendamentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgenda)).EndInit();
            this.gpbDados.ResumeLayout(false);
            this.gpbDados.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvAgenda;
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
        private System.Windows.Forms.TextBox txtIdP;
        private System.Windows.Forms.Button btnCnacelaP;
        private System.Windows.Forms.Button btnPesqP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPesqC;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtTipoConsul;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnCadastra;
        private System.Windows.Forms.TextBox txtIdM;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.MaskedTextBox mskData;
        private System.Windows.Forms.ComboBox cbbHora;
        private System.Windows.Forms.Button btnRemarcar;
        private System.Windows.Forms.Button btnDesmarcar;
        private System.Windows.Forms.TextBox txtIdA;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdA;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataA;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraA;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMed;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeM;
        private System.Windows.Forms.DataGridViewTextBoxColumn SobrenomeM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Crm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Espec;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
    }
}