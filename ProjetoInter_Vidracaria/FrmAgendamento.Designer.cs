namespace ProjetoInter_Vidracaria
{
    partial class FrmAgendamento
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            txtNome = new TextBox();
            txtNumeroCelular = new TextBox();
            txtEndereco = new TextBox();
            txtOrdemServico = new TextBox();
            txtDataMedicao = new TextBox();
            txtDataInstalacao = new TextBox();
            txtValorTotal = new TextBox();
            cmbConclusaoPagamentoTotal = new ComboBox();
            cmbStatusInstalacao = new ComboBox();
            cmbStatusMedicao = new ComboBox();
            btnSalvar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(75, 30);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 49);
            label2.Name = "label2";
            label2.Size = new Size(164, 30);
            label2.TabIndex = 1;
            label2.Text = "Número Celular:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 89);
            label3.Name = "label3";
            label3.Size = new Size(104, 30);
            label3.TabIndex = 2;
            label3.Text = "Endereço:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 128);
            label4.Name = "label4";
            label4.Size = new Size(183, 30);
            label4.TabIndex = 3;
            label4.Text = "Ordem de Serviço:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 167);
            label5.Name = "label5";
            label5.Size = new Size(148, 30);
            label5.TabIndex = 4;
            label5.Text = "Data Medição:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(12, 208);
            label6.Name = "label6";
            label6.Size = new Size(160, 30);
            label6.TabIndex = 5;
            label6.Text = "Status Medição:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(12, 247);
            label7.Name = "label7";
            label7.Size = new Size(162, 30);
            label7.TabIndex = 6;
            label7.Text = "Data Instalação:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(12, 287);
            label8.Name = "label8";
            label8.Size = new Size(174, 30);
            label8.TabIndex = 7;
            label8.Text = "Status Instalação:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(12, 326);
            label9.Name = "label9";
            label9.Size = new Size(275, 30);
            label9.TabIndex = 8;
            label9.Text = "Conclusão Pagamento Total:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(12, 370);
            label10.Name = "label10";
            label10.Size = new Size(114, 30);
            label10.TabIndex = 9;
            label10.Text = "Valor Total:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(93, 16);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(711, 23);
            txtNome.TabIndex = 10;
            txtNome.Leave += txtNome_Leave;
            // 
            // txtNumeroCelular
            // 
            txtNumeroCelular.Location = new Point(182, 56);
            txtNumeroCelular.Name = "txtNumeroCelular";
            txtNumeroCelular.Size = new Size(622, 23);
            txtNumeroCelular.TabIndex = 11;
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(122, 96);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(682, 23);
            txtEndereco.TabIndex = 12;
            // 
            // txtOrdemServico
            // 
            txtOrdemServico.Location = new Point(201, 135);
            txtOrdemServico.Name = "txtOrdemServico";
            txtOrdemServico.Size = new Size(603, 23);
            txtOrdemServico.TabIndex = 13;
            // 
            // txtDataMedicao
            // 
            txtDataMedicao.Location = new Point(166, 174);
            txtDataMedicao.Name = "txtDataMedicao";
            txtDataMedicao.Size = new Size(638, 23);
            txtDataMedicao.TabIndex = 14;
            // 
            // txtDataInstalacao
            // 
            txtDataInstalacao.Location = new Point(180, 254);
            txtDataInstalacao.Name = "txtDataInstalacao";
            txtDataInstalacao.Size = new Size(624, 23);
            txtDataInstalacao.TabIndex = 16;
            // 
            // txtValorTotal
            // 
            txtValorTotal.Location = new Point(132, 377);
            txtValorTotal.Name = "txtValorTotal";
            txtValorTotal.Size = new Size(672, 23);
            txtValorTotal.TabIndex = 19;
            // 
            // cmbConclusaoPagamentoTotal
            // 
            cmbConclusaoPagamentoTotal.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbConclusaoPagamentoTotal.FormattingEnabled = true;
            cmbConclusaoPagamentoTotal.Items.AddRange(new object[] { "Sim", "Não" });
            cmbConclusaoPagamentoTotal.Location = new Point(293, 333);
            cmbConclusaoPagamentoTotal.Name = "cmbConclusaoPagamentoTotal";
            cmbConclusaoPagamentoTotal.Size = new Size(121, 23);
            cmbConclusaoPagamentoTotal.TabIndex = 20;
            // 
            // cmbStatusInstalacao
            // 
            cmbStatusInstalacao.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatusInstalacao.FormattingEnabled = true;
            cmbStatusInstalacao.Items.AddRange(new object[] { "Concluído", "Pendente" });
            cmbStatusInstalacao.Location = new Point(192, 294);
            cmbStatusInstalacao.Name = "cmbStatusInstalacao";
            cmbStatusInstalacao.Size = new Size(222, 23);
            cmbStatusInstalacao.TabIndex = 21;
            // 
            // cmbStatusMedicao
            // 
            cmbStatusMedicao.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatusMedicao.FormattingEnabled = true;
            cmbStatusMedicao.Items.AddRange(new object[] { "Concluído", "Pendente" });
            cmbStatusMedicao.Location = new Point(178, 215);
            cmbStatusMedicao.Name = "cmbStatusMedicao";
            cmbStatusMedicao.Size = new Size(236, 23);
            cmbStatusMedicao.TabIndex = 22;
            // 
            // btnSalvar
            // 
            btnSalvar.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalvar.Location = new Point(362, 417);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(115, 54);
            btnSalvar.TabIndex = 23;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += button1_Click;
            // 
            // FrmAgendamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(816, 483);
            Controls.Add(btnSalvar);
            Controls.Add(cmbStatusMedicao);
            Controls.Add(cmbStatusInstalacao);
            Controls.Add(cmbConclusaoPagamentoTotal);
            Controls.Add(txtValorTotal);
            Controls.Add(txtDataInstalacao);
            Controls.Add(txtDataMedicao);
            Controls.Add(txtOrdemServico);
            Controls.Add(txtEndereco);
            Controls.Add(txtNumeroCelular);
            Controls.Add(txtNome);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmAgendamento";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agendamento";
            FormClosing += FrmAdicionarAgendamento_FormClosing;
            Load += FrmAdicionarAgendamento_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox txtNome;
        private TextBox txtNumeroCelular;
        private TextBox txtEndereco;
        private TextBox txtOrdemServico;
        private TextBox txtDataMedicao;
        private TextBox txtDataInstalacao;
        private TextBox txtValorTotal;
        private ComboBox cmbConclusaoPagamentoTotal;
        private ComboBox cmbStatusInstalacao;
        private ComboBox cmbStatusMedicao;
        private Button btnSalvar;
    }
}