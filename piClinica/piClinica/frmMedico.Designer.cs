
namespace piClinica
{
    partial class frmMedico
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
            this.gpbDados = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCrm = new System.Windows.Forms.TextBox();
            this.mskNascM = new System.Windows.Forms.MaskedTextBox();
            this.mskCpfM = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEspec = new System.Windows.Forms.TextBox();
            this.txtNomeM = new System.Windows.Forms.TextBox();
            this.btnAddM = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nomeM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.especialidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.crm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExcluirM = new System.Windows.Forms.Button();
            this.btnAlterarM = new System.Windows.Forms.Button();
            this.gpbDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbDados
            // 
            this.gpbDados.Controls.Add(this.label6);
            this.gpbDados.Controls.Add(this.txtCrm);
            this.gpbDados.Controls.Add(this.mskNascM);
            this.gpbDados.Controls.Add(this.mskCpfM);
            this.gpbDados.Controls.Add(this.label5);
            this.gpbDados.Controls.Add(this.label4);
            this.gpbDados.Controls.Add(this.label3);
            this.gpbDados.Controls.Add(this.label2);
            this.gpbDados.Controls.Add(this.txtEspec);
            this.gpbDados.Controls.Add(this.txtNomeM);
            this.gpbDados.Location = new System.Drawing.Point(7, 54);
            this.gpbDados.Name = "gpbDados";
            this.gpbDados.Size = new System.Drawing.Size(639, 215);
            this.gpbDados.TabIndex = 28;
            this.gpbDados.TabStop = false;
            this.gpbDados.Text = "Dados Pessoais";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(468, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "CRM:";
            // 
            // txtCrm
            // 
            this.txtCrm.Location = new System.Drawing.Point(471, 39);
            this.txtCrm.Name = "txtCrm";
            this.txtCrm.Size = new System.Drawing.Size(110, 20);
            this.txtCrm.TabIndex = 22;
            // 
            // mskNascM
            // 
            this.mskNascM.Location = new System.Drawing.Point(5, 91);
            this.mskNascM.Mask = "00/00/0000";
            this.mskNascM.Name = "mskNascM";
            this.mskNascM.Size = new System.Drawing.Size(100, 20);
            this.mskNascM.TabIndex = 21;
            this.mskNascM.ValidatingType = typeof(System.DateTime);
            // 
            // mskCpfM
            // 
            this.mskCpfM.Location = new System.Drawing.Point(6, 143);
            this.mskCpfM.Mask = "000.000.000-00";
            this.mskCpfM.Name = "mskCpfM";
            this.mskCpfM.Size = new System.Drawing.Size(100, 20);
            this.mskCpfM.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Especialidade";
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
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Nome:";
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
            // txtEspec
            // 
            this.txtEspec.Location = new System.Drawing.Point(7, 189);
            this.txtEspec.Name = "txtEspec";
            this.txtEspec.Size = new System.Drawing.Size(244, 20);
            this.txtEspec.TabIndex = 15;
            // 
            // txtNomeM
            // 
            this.txtNomeM.Location = new System.Drawing.Point(6, 39);
            this.txtNomeM.Name = "txtNomeM";
            this.txtNomeM.Size = new System.Drawing.Size(245, 20);
            this.txtNomeM.TabIndex = 14;
            // 
            // btnAddM
            // 
            this.btnAddM.Location = new System.Drawing.Point(7, 275);
            this.btnAddM.Name = "btnAddM";
            this.btnAddM.Size = new System.Drawing.Size(99, 23);
            this.btnAddM.TabIndex = 27;
            this.btnAddM.Text = "Inserir";
            this.btnAddM.UseVisualStyleBackColor = true;
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
            this.crm});
            this.dataGridView1.Location = new System.Drawing.Point(7, 304);
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
            this.dataGridView1.Size = new System.Drawing.Size(639, 282);
            this.dataGridView1.TabIndex = 26;
            // 
            // nomeM
            // 
            this.nomeM.HeaderText = "NOME";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(249, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 42);
            this.label1.TabIndex = 25;
            this.label1.Text = "Medicos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExcluirM
            // 
            this.btnExcluirM.Location = new System.Drawing.Point(547, 275);
            this.btnExcluirM.Name = "btnExcluirM";
            this.btnExcluirM.Size = new System.Drawing.Size(99, 23);
            this.btnExcluirM.TabIndex = 24;
            this.btnExcluirM.Text = "Excluir";
            this.btnExcluirM.UseVisualStyleBackColor = true;
            // 
            // btnAlterarM
            // 
            this.btnAlterarM.Location = new System.Drawing.Point(282, 275);
            this.btnAlterarM.Name = "btnAlterarM";
            this.btnAlterarM.Size = new System.Drawing.Size(99, 23);
            this.btnAlterarM.TabIndex = 23;
            this.btnAlterarM.Text = "Alterar";
            this.btnAlterarM.UseVisualStyleBackColor = true;
            // 
            // frmMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 598);
            this.Controls.Add(this.gpbDados);
            this.Controls.Add(this.btnAddM);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExcluirM);
            this.Controls.Add(this.btnAlterarM);
            this.Name = "frmMedico";
            this.Text = "frmMedico";
            this.gpbDados.ResumeLayout(false);
            this.gpbDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbDados;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCrm;
        private System.Windows.Forms.MaskedTextBox mskNascM;
        private System.Windows.Forms.MaskedTextBox mskCpfM;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEspec;
        private System.Windows.Forms.TextBox txtNomeM;
        private System.Windows.Forms.Button btnAddM;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeM;
        private System.Windows.Forms.DataGridViewTextBoxColumn especialidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn crm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExcluirM;
        private System.Windows.Forms.Button btnAlterarM;
    }
}