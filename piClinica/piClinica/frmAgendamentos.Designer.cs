
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nomeM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.especialidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.crm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpbDados = new System.Windows.Forms.GroupBox();
            this.txtCrmC = new System.Windows.Forms.TextBox();
            this.txtEspecCM = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNomeCM = new System.Windows.Forms.TextBox();
            this.mskNascimentoCP = new System.Windows.Forms.MaskedTextBox();
            this.mskCpfCP = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEnderecoCP = new System.Windows.Forms.TextBox();
            this.txtNomeCP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.mskDataC = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gpbDados.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeM,
            this.especialidade,
            this.crm,
            this.status});
            this.dataGridView1.Location = new System.Drawing.Point(12, 275);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(636, 311);
            this.dataGridView1.TabIndex = 26;
            // 
            // nomeM
            // 
            this.nomeM.HeaderText = "MEDICO";
            this.nomeM.Name = "nomeM";
            this.nomeM.ReadOnly = true;
            // 
            // especialidade
            // 
            this.especialidade.HeaderText = "ESPECIALIDADE";
            this.especialidade.Name = "especialidade";
            this.especialidade.ReadOnly = true;
            // 
            // crm
            // 
            this.crm.HeaderText = "CRM";
            this.crm.Name = "crm";
            this.crm.ReadOnly = true;
            // 
            // status
            // 
            this.status.HeaderText = "STATUS";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // gpbDados
            // 
            this.gpbDados.Controls.Add(this.button1);
            this.gpbDados.Controls.Add(this.maskedTextBox1);
            this.gpbDados.Controls.Add(this.mskDataC);
            this.gpbDados.Controls.Add(this.label6);
            this.gpbDados.Controls.Add(this.btnPesquisa);
            this.gpbDados.Controls.Add(this.txtCrmC);
            this.gpbDados.Controls.Add(this.txtEspecCM);
            this.gpbDados.Controls.Add(this.label7);
            this.gpbDados.Controls.Add(this.label8);
            this.gpbDados.Controls.Add(this.label9);
            this.gpbDados.Controls.Add(this.txtNomeCM);
            this.gpbDados.Controls.Add(this.mskNascimentoCP);
            this.gpbDados.Controls.Add(this.mskCpfCP);
            this.gpbDados.Controls.Add(this.label5);
            this.gpbDados.Controls.Add(this.label4);
            this.gpbDados.Controls.Add(this.label3);
            this.gpbDados.Controls.Add(this.label2);
            this.gpbDados.Controls.Add(this.txtEnderecoCP);
            this.gpbDados.Controls.Add(this.txtNomeCP);
            this.gpbDados.Location = new System.Drawing.Point(12, 54);
            this.gpbDados.Name = "gpbDados";
            this.gpbDados.Size = new System.Drawing.Size(636, 215);
            this.gpbDados.TabIndex = 25;
            this.gpbDados.TabStop = false;
            this.gpbDados.Text = "Dados da Consulta";
            // 
            // txtCrmC
            // 
            this.txtCrmC.Enabled = false;
            this.txtCrmC.Location = new System.Drawing.Point(352, 143);
            this.txtCrmC.Name = "txtCrmC";
            this.txtCrmC.Size = new System.Drawing.Size(89, 20);
            this.txtCrmC.TabIndex = 30;
            // 
            // txtEspecCM
            // 
            this.txtEspecCM.Enabled = false;
            this.txtEspecCM.Location = new System.Drawing.Point(353, 91);
            this.txtEspecCM.Name = "txtEspecCM";
            this.txtEspecCM.Size = new System.Drawing.Size(245, 20);
            this.txtEspecCM.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(349, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Especialidade:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(350, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Nome do Médico:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(352, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "CRM";
            // 
            // txtNomeCM
            // 
            this.txtNomeCM.Enabled = false;
            this.txtNomeCM.Location = new System.Drawing.Point(353, 39);
            this.txtNomeCM.Name = "txtNomeCM";
            this.txtNomeCM.Size = new System.Drawing.Size(245, 20);
            this.txtNomeCM.TabIndex = 22;
            // 
            // mskNascimentoCP
            // 
            this.mskNascimentoCP.Enabled = false;
            this.mskNascimentoCP.Location = new System.Drawing.Point(5, 91);
            this.mskNascimentoCP.Mask = "00/00/0000";
            this.mskNascimentoCP.Name = "mskNascimentoCP";
            this.mskNascimentoCP.Size = new System.Drawing.Size(100, 20);
            this.mskNascimentoCP.TabIndex = 21;
            this.mskNascimentoCP.ValidatingType = typeof(System.DateTime);
            // 
            // mskCpfCP
            // 
            this.mskCpfCP.Enabled = false;
            this.mskCpfCP.Location = new System.Drawing.Point(6, 143);
            this.mskCpfCP.Mask = "000.000.000-00";
            this.mskCpfCP.Name = "mskCpfCP";
            this.mskCpfCP.Size = new System.Drawing.Size(100, 20);
            this.mskCpfCP.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Endereço:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Nascimento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Nome do Paciente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "CPF:";
            // 
            // txtEnderecoCP
            // 
            this.txtEnderecoCP.Enabled = false;
            this.txtEnderecoCP.Location = new System.Drawing.Point(7, 189);
            this.txtEnderecoCP.Name = "txtEnderecoCP";
            this.txtEnderecoCP.Size = new System.Drawing.Size(244, 20);
            this.txtEnderecoCP.TabIndex = 15;
            // 
            // txtNomeCP
            // 
            this.txtNomeCP.Location = new System.Drawing.Point(6, 39);
            this.txtNomeCP.Name = "txtNomeCP";
            this.txtNomeCP.Size = new System.Drawing.Size(245, 20);
            this.txtNomeCP.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(476, 42);
            this.label1.TabIndex = 24;
            this.label1.Text = "Agendamento de consulta";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(349, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Data e Hora:";
            // 
            // mskDataC
            // 
            this.mskDataC.Enabled = false;
            this.mskDataC.Location = new System.Drawing.Point(352, 189);
            this.mskDataC.Mask = "00/00/0000";
            this.mskDataC.Name = "mskDataC";
            this.mskDataC.Size = new System.Drawing.Size(62, 20);
            this.mskDataC.TabIndex = 29;
            this.mskDataC.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Enabled = false;
            this.maskedTextBox1.Location = new System.Drawing.Point(420, 189);
            this.maskedTextBox1.Mask = "00:00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(30, 20);
            this.maskedTextBox1.TabIndex = 33;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.BackColor = System.Drawing.Color.Transparent;
            this.btnPesquisa.BackgroundImage = global::piClinica.Properties.Resources.lupaIco1;
            this.btnPesquisa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPesquisa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisa.FlatAppearance.BorderSize = 0;
            this.btnPesquisa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisa.Location = new System.Drawing.Point(257, 35);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(27, 26);
            this.btnPesquisa.TabIndex = 31;
            this.btnPesquisa.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::piClinica.Properties.Resources.lupaIco1;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(456, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 26);
            this.button1.TabIndex = 34;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // frmAgendamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 598);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gpbDados);
            this.Controls.Add(this.label1);
            this.Name = "frmAgendamentos";
            this.Text = "frmAgendamentos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gpbDados.ResumeLayout(false);
            this.gpbDados.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeM;
        private System.Windows.Forms.DataGridViewTextBoxColumn especialidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn crm;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.GroupBox gpbDados;
        private System.Windows.Forms.TextBox txtCrmC;
        private System.Windows.Forms.TextBox txtEspecCM;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNomeCM;
        private System.Windows.Forms.MaskedTextBox mskNascimentoCP;
        private System.Windows.Forms.MaskedTextBox mskCpfCP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEnderecoCP;
        private System.Windows.Forms.TextBox txtNomeCP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox mskDataC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
    }
}