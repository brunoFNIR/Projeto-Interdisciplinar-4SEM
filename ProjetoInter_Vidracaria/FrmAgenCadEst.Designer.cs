namespace ProjetoInter_Vidracaria
{
    partial class FrmAgenCadEst
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
            btnAdicionar = new Button();
            btnEditar = new Button();
            btnRemover = new Button();
            btnRelatorio = new Button();
            cmbOpcoes = new ComboBox();
            dgvResultado = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvResultado).BeginInit();
            SuspendLayout();
            // 
            // btnAdicionar
            // 
            btnAdicionar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdicionar.Location = new Point(219, 36);
            btnAdicionar.MaximumSize = new Size(193, 55);
            btnAdicionar.MinimumSize = new Size(150, 30);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(193, 55);
            btnAdicionar.TabIndex = 0;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnEditar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnEditar.Location = new Point(572, 36);
            btnEditar.MaximumSize = new Size(193, 55);
            btnEditar.MinimumSize = new Size(150, 30);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(193, 55);
            btnEditar.TabIndex = 1;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnRemover
            // 
            btnRemover.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnRemover.Location = new Point(916, 36);
            btnRemover.MaximumSize = new Size(193, 55);
            btnRemover.MinimumSize = new Size(150, 30);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(193, 55);
            btnRemover.TabIndex = 2;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += btnRemover_Click;
            // 
            // btnRelatorio
            // 
            btnRelatorio.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRelatorio.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRelatorio.Location = new Point(1173, 10);
            btnRelatorio.MaximumSize = new Size(101, 55);
            btnRelatorio.Name = "btnRelatorio";
            btnRelatorio.Size = new Size(101, 55);
            btnRelatorio.TabIndex = 3;
            btnRelatorio.Text = "Relatório";
            btnRelatorio.UseVisualStyleBackColor = true;
            btnRelatorio.Click += btnRelatorio_Click;
            // 
            // cmbOpcoes
            // 
            cmbOpcoes.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOpcoes.FormattingEnabled = true;
            cmbOpcoes.Items.AddRange(new object[] { "Agendamento Instalações", "Clientes", "Estoque" });
            cmbOpcoes.Location = new Point(12, 27);
            cmbOpcoes.Name = "cmbOpcoes";
            cmbOpcoes.Size = new Size(150, 23);
            cmbOpcoes.TabIndex = 4;
            cmbOpcoes.SelectedIndexChanged += cmbOpcoes_SelectedIndexChanged;
            // 
            // dgvResultado
            // 
            dgvResultado.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvResultado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvResultado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResultado.Location = new Point(12, 117);
            dgvResultado.Name = "dgvResultado";
            dgvResultado.ReadOnly = true;
            dgvResultado.RowTemplate.Height = 25;
            dgvResultado.Size = new Size(1272, 514);
            dgvResultado.TabIndex = 5;
            // 
            // FrmAgenCadEst
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1296, 643);
            Controls.Add(dgvResultado);
            Controls.Add(cmbOpcoes);
            Controls.Add(btnRelatorio);
            Controls.Add(btnRemover);
            Controls.Add(btnEditar);
            Controls.Add(btnAdicionar);
            MinimumSize = new Size(1259, 622);
            Name = "FrmAgenCadEst";
            Text = "Gerenciamento AGVAN";
            WindowState = FormWindowState.Maximized;
            FormClosing += FrmAgenCadEst_FormClosing_1;
            Load += FrmAgenCadEst_Load;
            ((System.ComponentModel.ISupportInitialize)dgvResultado).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAdicionar;
        private Button btnEditar;
        private Button btnRemover;
        private Button btnRelatorio;
        private ComboBox cmbOpcoes;
        private DataGridView dgvResultado;
    }
}