namespace ProjetoInter_Vidracaria
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAgenCadEst = new Button();
            btnSobre = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnAgenCadEst
            // 
            btnAgenCadEst.Anchor = AnchorStyles.Bottom;
            btnAgenCadEst.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgenCadEst.Location = new Point(454, 359);
            btnAgenCadEst.MaximumSize = new Size(408, 221);
            btnAgenCadEst.Name = "btnAgenCadEst";
            btnAgenCadEst.Size = new Size(408, 221);
            btnAgenCadEst.TabIndex = 1;
            btnAgenCadEst.Text = "Agendamento de Instalações\r\n\r\nCadastro de Clientes\r\n\r\nEstoque";
            btnAgenCadEst.UseVisualStyleBackColor = true;
            btnAgenCadEst.Click += btnAgenCadEst_Click;
            // 
            // btnSobre
            // 
            btnSobre.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSobre.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSobre.Location = new Point(1195, 562);
            btnSobre.Name = "btnSobre";
            btnSobre.Size = new Size(82, 71);
            btnSobre.TabIndex = 2;
            btnSobre.Text = "Sobre";
            btnSobre.UseVisualStyleBackColor = true;
            btnSobre.Click += btnSobre_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = SystemColors.AppWorkspace;
            label1.Font = new Font("Castellar", 60F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(404, 9);
            label1.Name = "label1";
            label1.Size = new Size(497, 96);
            label1.TabIndex = 4;
            label1.Text = "A G V A N";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.BackColor = SystemColors.AppWorkspace;
            label2.Font = new Font("Castellar", 48F, FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(12, 172);
            label2.Name = "label2";
            label2.Size = new Size(198, 77);
            label2.TabIndex = 6;
            label2.Text = "S.G.V";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.BackColor = SystemColors.AppWorkspace;
            label3.Font = new Font("Castellar", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(12, 275);
            label3.Margin = new Padding(3, 0, 3, 5);
            label3.Name = "label3";
            label3.Size = new Size(940, 44);
            label3.TabIndex = 7;
            label3.Text = "Sistema de Gerenciamento - Vidraçaria";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1289, 645);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSobre);
            Controls.Add(btnAgenCadEst);
            IsMdiContainer = true;
            Name = "Form1";
            Text = "Vidraçaria Agvan";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgenCadEst;
        private Button btnSobre;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}