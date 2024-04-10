namespace ProjetoInter_Vidracaria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgenCadEst_Click(object sender, EventArgs e)
        {
            FrmAgenCadEst frmAgenCadEst = new FrmAgenCadEst();
            frmAgenCadEst.MdiParent = this;

            btnAgenCadEst.Visible = false;
            btnSobre.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;

            frmAgenCadEst.FormClosing += (s, args) =>
            {
                if (frmAgenCadEst.DialogResult == DialogResult.OK)
                {
                    btnAgenCadEst.Visible = true;
                    btnSobre.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                }
            };

            frmAgenCadEst.Show();
        }

        private void btnSobre_Click(object sender, EventArgs e)
        {
            FrmSobre frmSobre = new FrmSobre();
            frmSobre.StartPosition = FormStartPosition.CenterScreen;
            frmSobre.MdiParent = this;

            btnAgenCadEst.Visible = false;
            btnSobre.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;

            frmSobre.FormClosing += (s, args) =>
            {
                if (frmSobre.DialogResult == DialogResult.OK)
                {
                    btnAgenCadEst.Visible = true;
                    btnSobre.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                }
            };

            frmSobre.Show();
        }
    }
}