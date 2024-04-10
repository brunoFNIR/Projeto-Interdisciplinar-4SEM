namespace ProjetoInter_Vidracaria
{
    partial class FrmSobre
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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(493, 291);
            label1.Name = "label1";
            label1.Size = new Size(80, 21);
            label1.TabIndex = 0;
            label1.Text = "Versão 1.0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(7, 127);
            label2.Name = "label2";
            label2.Size = new Size(581, 128);
            label2.TabIndex = 1;
            label2.Text = "Bruno Felipe Novelli Ivanaskas Rodrigues – 29295556\r\nKayky Candido Teixeira – 29239575\r\nMarcio José Inacio Junior – 29410568\r\nMatheus Orzanqui – 28775589";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(7, 72);
            label3.Name = "label3";
            label3.Size = new Size(361, 37);
            label3.TabIndex = 2;
            label3.Text = "Equipe de Desenvolvimento:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 21.75F, FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(37, 9);
            label4.Name = "label4";
            label4.Size = new Size(518, 40);
            label4.TabIndex = 3;
            label4.Text = "Sistema de Gerenciamento - Vidraçaria ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semilight", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(37, 296);
            label5.Name = "label5";
            label5.Size = new Size(198, 15);
            label5.TabIndex = 4;
            label5.Text = "Projeto Interdisciplinar - 4º Semestre";
            // 
            // FrmSobre
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(592, 321);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmSobre";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Informações";
            FormClosing += FrmCaixa_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}