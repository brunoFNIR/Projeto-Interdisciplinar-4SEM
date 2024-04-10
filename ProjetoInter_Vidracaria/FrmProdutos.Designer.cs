namespace ProjetoInter_Vidracaria
{
    partial class FrmProdutos
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
            txtFornecedor = new TextBox();
            txtQuantidade = new TextBox();
            txtTipoProduto = new TextBox();
            txtProduto = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnSalvar
            // 
            btnSalvar.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalvar.Location = new Point(353, 189);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(115, 54);
            btnSalvar.TabIndex = 57;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // txtFornecedor
            // 
            txtFornecedor.Location = new Point(134, 147);
            txtFornecedor.Name = "txtFornecedor";
            txtFornecedor.Size = new Size(664, 23);
            txtFornecedor.TabIndex = 54;
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(139, 108);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(659, 23);
            txtQuantidade.TabIndex = 53;
            // 
            // txtTipoProduto
            // 
            txtTipoProduto.Location = new Point(180, 68);
            txtTipoProduto.Name = "txtTipoProduto";
            txtTipoProduto.Size = new Size(618, 23);
            txtTipoProduto.TabIndex = 52;
            // 
            // txtProduto
            // 
            txtProduto.Location = new Point(104, 28);
            txtProduto.Name = "txtProduto";
            txtProduto.Size = new Size(694, 23);
            txtProduto.TabIndex = 51;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(6, 140);
            label4.Name = "label4";
            label4.Size = new Size(122, 30);
            label4.TabIndex = 48;
            label4.Text = "Fornecedor:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(6, 101);
            label3.Name = "label3";
            label3.Size = new Size(127, 30);
            label3.TabIndex = 47;
            label3.Text = "Quantidade:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(6, 61);
            label2.Name = "label2";
            label2.Size = new Size(168, 30);
            label2.TabIndex = 46;
            label2.Text = "Tipo do Produto:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(6, 21);
            label1.Name = "label1";
            label1.Size = new Size(92, 30);
            label1.TabIndex = 45;
            label1.Text = "Produto:";
            // 
            // FrmProdutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(816, 253);
            Controls.Add(btnSalvar);
            Controls.Add(txtFornecedor);
            Controls.Add(txtQuantidade);
            Controls.Add(txtTipoProduto);
            Controls.Add(txtProduto);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmProdutos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Produto";
            FormClosing += FrmProdutos_FormClosing;
            Load += FrmProdutos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSalvar;
        private TextBox txtFornecedor;
        private TextBox txtQuantidade;
        private TextBox txtTipoProduto;
        private TextBox txtProduto;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}