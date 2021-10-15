
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAtivar = new System.Windows.Forms.Button();
            this.btnDesativar = new System.Windows.Forms.Button();
            this.dgvMedicos = new System.Windows.Forms.DataGridView();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnIserir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gpbDados = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCrm = new System.Windows.Forms.TextBox();
            this.txtEspec = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCpfM = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSenhaM = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSobrenomeM = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNomeM = new System.Windows.Forms.TextBox();
            this.txtIdM = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblUsuLogado = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicos)).BeginInit();
            this.gpbDados.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAtivar
            // 
            this.btnAtivar.Location = new System.Drawing.Point(289, 237);
            this.btnAtivar.Name = "btnAtivar";
            this.btnAtivar.Size = new System.Drawing.Size(100, 23);
            this.btnAtivar.TabIndex = 39;
            this.btnAtivar.Text = "Ativar";
            this.btnAtivar.UseVisualStyleBackColor = true;
            this.btnAtivar.Click += new System.EventHandler(this.btnAtivar_Click);
            // 
            // btnDesativar
            // 
            this.btnDesativar.Location = new System.Drawing.Point(395, 208);
            this.btnDesativar.Name = "btnDesativar";
            this.btnDesativar.Size = new System.Drawing.Size(100, 23);
            this.btnDesativar.TabIndex = 38;
            this.btnDesativar.Text = "Desativar";
            this.btnDesativar.UseVisualStyleBackColor = true;
            this.btnDesativar.Click += new System.EventHandler(this.btnDesativar_Click);
            // 
            // dgvMedicos
            // 
            this.dgvMedicos.AllowUserToAddRows = false;
            this.dgvMedicos.AllowUserToDeleteRows = false;
            this.dgvMedicos.AllowUserToResizeColumns = false;
            this.dgvMedicos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvMedicos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMedicos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMedicos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMedicos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMedicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicos.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMedicos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMedicos.Location = new System.Drawing.Point(7, 286);
            this.dgvMedicos.MultiSelect = false;
            this.dgvMedicos.Name = "dgvMedicos";
            this.dgvMedicos.ReadOnly = true;
            this.dgvMedicos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvMedicos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMedicos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvMedicos.RowHeadersVisible = false;
            this.dgvMedicos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMedicos.Size = new System.Drawing.Size(509, 170);
            this.dgvMedicos.TabIndex = 36;
            this.dgvMedicos.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMedicos_RowEnter);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(289, 208);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(100, 23);
            this.btnExcluir.TabIndex = 35;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(395, 181);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(100, 23);
            this.btnAlterar.TabIndex = 34;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnIserir
            // 
            this.btnIserir.Location = new System.Drawing.Point(289, 181);
            this.btnIserir.Name = "btnIserir";
            this.btnIserir.Size = new System.Drawing.Size(100, 23);
            this.btnIserir.TabIndex = 33;
            this.btnIserir.Text = "Inserir";
            this.btnIserir.UseVisualStyleBackColor = true;
            this.btnIserir.Click += new System.EventHandler(this.btnIserir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 42);
            this.label1.TabIndex = 32;
            this.label1.Text = "Cadastro de Médicos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gpbDados
            // 
            this.gpbDados.Controls.Add(this.label7);
            this.gpbDados.Controls.Add(this.txtCrm);
            this.gpbDados.Controls.Add(this.txtEspec);
            this.gpbDados.Controls.Add(this.label6);
            this.gpbDados.Controls.Add(this.txtCpfM);
            this.gpbDados.Controls.Add(this.label4);
            this.gpbDados.Controls.Add(this.txtSenhaM);
            this.gpbDados.Controls.Add(this.label2);
            this.gpbDados.Controls.Add(this.txtSobrenomeM);
            this.gpbDados.Controls.Add(this.label9);
            this.gpbDados.Controls.Add(this.label5);
            this.gpbDados.Controls.Add(this.label3);
            this.gpbDados.Controls.Add(this.txtNomeM);
            this.gpbDados.Controls.Add(this.txtIdM);
            this.gpbDados.Location = new System.Drawing.Point(7, 67);
            this.gpbDados.Name = "gpbDados";
            this.gpbDados.Size = new System.Drawing.Size(271, 213);
            this.gpbDados.TabIndex = 31;
            this.gpbDados.TabStop = false;
            this.gpbDados.Text = "Dados do Médico";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(143, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "CRM:";
            // 
            // txtCrm
            // 
            this.txtCrm.Location = new System.Drawing.Point(146, 39);
            this.txtCrm.Name = "txtCrm";
            this.txtCrm.Size = new System.Drawing.Size(70, 20);
            this.txtCrm.TabIndex = 38;
            // 
            // txtEspec
            // 
            this.txtEspec.Location = new System.Drawing.Point(6, 177);
            this.txtEspec.Name = "txtEspec";
            this.txtEspec.Size = new System.Drawing.Size(109, 20);
            this.txtEspec.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Especialidade:";
            // 
            // txtCpfM
            // 
            this.txtCpfM.Location = new System.Drawing.Point(146, 130);
            this.txtCpfM.Name = "txtCpfM";
            this.txtCpfM.Size = new System.Drawing.Size(109, 20);
            this.txtCpfM.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(143, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "CPF:";
            // 
            // txtSenhaM
            // 
            this.txtSenhaM.Location = new System.Drawing.Point(146, 83);
            this.txtSenhaM.Name = "txtSenhaM";
            this.txtSenhaM.PasswordChar = '•';
            this.txtSenhaM.Size = new System.Drawing.Size(109, 20);
            this.txtSenhaM.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Senha:";
            // 
            // txtSobrenomeM
            // 
            this.txtSobrenomeM.Location = new System.Drawing.Point(6, 130);
            this.txtSobrenomeM.Name = "txtSobrenomeM";
            this.txtSobrenomeM.Size = new System.Drawing.Size(109, 20);
            this.txtSobrenomeM.TabIndex = 30;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Sobrenome:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "ID do médico:";
            // 
            // txtNomeM
            // 
            this.txtNomeM.Location = new System.Drawing.Point(6, 82);
            this.txtNomeM.Name = "txtNomeM";
            this.txtNomeM.Size = new System.Drawing.Size(109, 20);
            this.txtNomeM.TabIndex = 15;
            // 
            // txtIdM
            // 
            this.txtIdM.Enabled = false;
            this.txtIdM.Location = new System.Drawing.Point(6, 39);
            this.txtIdM.Name = "txtIdM";
            this.txtIdM.Size = new System.Drawing.Size(52, 20);
            this.txtIdM.TabIndex = 14;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(395, 237);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 23);
            this.btnCancel.TabIndex = 40;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblUsuLogado
            // 
            this.lblUsuLogado.AutoSize = true;
            this.lblUsuLogado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuLogado.Location = new System.Drawing.Point(347, 107);
            this.lblUsuLogado.Name = "lblUsuLogado";
            this.lblUsuLogado.Size = new System.Drawing.Size(68, 24);
            this.lblUsuLogado.TabIndex = 42;
            this.lblUsuLogado.Text = "name:";
            this.lblUsuLogado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(346, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 29);
            this.label8.TabIndex = 41;
            this.label8.Text = "Usuário:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 462);
            this.Controls.Add(this.lblUsuLogado);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAtivar);
            this.Controls.Add(this.btnDesativar);
            this.Controls.Add(this.dgvMedicos);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnIserir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gpbDados);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(539, 501);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(539, 501);
            this.Name = "frmMedico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Medicos";
            this.Load += new System.EventHandler(this.frmMedico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicos)).EndInit();
            this.gpbDados.ResumeLayout(false);
            this.gpbDados.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAtivar;
        private System.Windows.Forms.Button btnDesativar;
        private System.Windows.Forms.DataGridView dgvMedicos;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnIserir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gpbDados;
        private System.Windows.Forms.TextBox txtSobrenomeM;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNomeM;
        private System.Windows.Forms.TextBox txtIdM;
        private System.Windows.Forms.TextBox txtSenhaM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEspec;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCpfM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCrm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblUsuLogado;
        private System.Windows.Forms.Label label8;
    }
}