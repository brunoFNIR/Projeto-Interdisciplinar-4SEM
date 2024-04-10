namespace ProjetoInter_Vidracaria
{
    partial class FrmClientes
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
            btnSalvar = new Button();
            txtEndereco = new TextBox();
            txtNumeroCelular = new TextBox();
            txtDataNascimento = new TextBox();
            txtCpf = new TextBox();
            txtDocumento = new TextBox();
            txtNome = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnSalvar
            // 
            btnSalvar.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalvar.Location = new Point(352, 274);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(115, 54);
            btnSalvar.TabIndex = 44;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(122, 223);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(682, 23);
            txtEndereco.TabIndex = 39;
            // 
            // txtNumeroCelular
            // 
            txtNumeroCelular.Location = new Point(212, 182);
            txtNumeroCelular.Name = "txtNumeroCelular";
            txtNumeroCelular.Size = new Size(592, 23);
            txtNumeroCelular.TabIndex = 38;
            // 
            // txtDataNascimento
            // 
            txtDataNascimento.Location = new Point(226, 143);
            txtDataNascimento.Name = "txtDataNascimento";
            txtDataNascimento.Size = new Size(578, 23);
            txtDataNascimento.TabIndex = 37;
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(71, 104);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(733, 23);
            txtCpf.TabIndex = 36;
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(145, 64);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(659, 23);
            txtDocumento.TabIndex = 35;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(93, 24);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(711, 23);
            txtNome.TabIndex = 34;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(12, 216);
            label6.Name = "label6";
            label6.Size = new Size(104, 30);
            label6.TabIndex = 29;
            label6.Text = "Endereço:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 175);
            label5.Name = "label5";
            label5.Size = new Size(194, 30);
            label5.TabIndex = 28;
            label5.Text = "Número do Celular:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 136);
            label4.Name = "label4";
            label4.Size = new Size(208, 30);
            label4.TabIndex = 27;
            label4.Text = "Data de Nascimento:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 97);
            label3.Name = "label3";
            label3.Size = new Size(53, 30);
            label3.TabIndex = 26;
            label3.Text = "CPF:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 57);
            label2.Name = "label2";
            label2.Size = new Size(127, 30);
            label2.TabIndex = 25;
            label2.Text = "Documento:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 17);
            label1.Name = "label1";
            label1.Size = new Size(75, 30);
            label1.TabIndex = 24;
            label1.Text = "Nome:";
            // 
            // FrmClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(823, 345);
            Controls.Add(btnSalvar);
            Controls.Add(txtEndereco);
            Controls.Add(txtNumeroCelular);
            Controls.Add(txtDataNascimento);
            Controls.Add(txtCpf);
            Controls.Add(txtDocumento);
            Controls.Add(txtNome);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cliente";
            FormClosing += FrmClientes_FormClosing;
            Load += FrmClientes_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSalvar;
        private TextBox txtEndereco;
        private TextBox txtNumeroCelular;
        private TextBox txtDataNascimento;
        private TextBox txtCpf;
        private TextBox txtDocumento;
        private TextBox txtNome;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}