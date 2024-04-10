using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoInter_Vidracaria
{
    public partial class FrmClientes : Form
    {
        private string valorIdParaEdicao;

        public FrmClientes()
        {
            InitializeComponent();
        }
        public FrmClientes(string id)
        {
            InitializeComponent();
            valorIdParaEdicao = id;
        }

        private MySqlConnection mConn;
        private MySqlDataAdapter mAdapter;
        private DataSet mDataSet;

        private void conectar()
        {
            mDataSet = new DataSet();
            mConn = new MySqlConnection(" Persist Security Info=False;" +
                                        "server=localhost; " +
                                        "database=VidracariaAgvan; " +
                                        "uid=root; pwd=root");

            try
            {
                mConn.Open();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void limpar()
        {
            txtNome.Text = "";
            txtDocumento.Text = "";
            txtCpf.Text = "";
            txtDataNascimento.Text = "";
            txtNumeroCelular.Text = "";
            txtEndereco.Text = "";
        }

        private void FrmClientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            conectar();
            if (!DateTime.TryParseExact(txtDataNascimento.Text, "dd/MM/yy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dataNascimentoInserida))
            {
                MessageBox.Show("Data de nascimento inválida. Insira uma data válida no formato dd/MM/yy", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string dataNascimentoFormatoMySQL = dataNascimentoInserida.ToString("yyyy-MM-dd");

            if (!string.IsNullOrEmpty(valorIdParaEdicao))
            {
                MySqlCommand command = new MySqlCommand("UPDATE Cliente SET nome = '" +
                                                         txtNome.Text.Trim() + "', rg = '" +
                                                         txtDocumento.Text.Trim() + "', cpf = '" +
                                                         txtCpf.Text.Trim() + "', data_nascimento = '" +
                                                         dataNascimentoFormatoMySQL + "', numero_celular = '" +
                                                         txtNumeroCelular.Text.Trim() + "', endereco = '" +
                                                         txtEndereco.Text.Trim() + "' WHERE id = " + valorIdParaEdicao + ";", mConn);
                command.ExecuteNonQuery();
                MessageBox.Show("Alterado com Sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MySqlCommand command = new MySqlCommand("INSERT INTO Cliente (nome,rg,cpf,data_nascimento,numero_celular,endereco)" +
                                                        "VALUES ('" + txtNome.Text.Trim() + "','" +
                                                                      txtDocumento.Text.Trim() + "','" +
                                                                      txtCpf.Text.Trim() + "','" +
                                                                      dataNascimentoFormatoMySQL + "','" +
                                                                      txtNumeroCelular.Text.Trim() + "','" +
                                                                      txtEndereco.Text.Trim() + "')", mConn);
                command.ExecuteNonQuery();
                MessageBox.Show("Gravado com Sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            limpar();
            mConn.Close();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            conectar();

            if (!string.IsNullOrEmpty(valorIdParaEdicao))
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM Cliente WHERE id= " + valorIdParaEdicao, mConn);
                MySqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    txtNome.Text = reader["nome"].ToString();
                    txtDocumento.Text = reader["rg"].ToString();
                    txtCpf.Text = reader["cpf"].ToString();

                    DateTime dataNascimento = DateTime.Parse(reader["data_nascimento"].ToString());
                    txtDataNascimento.Text = dataNascimento.ToString("dd/MM/yy");

                    txtNumeroCelular.Text = reader["numero_celular"].ToString();
                    txtEndereco.Text = reader["endereco"].ToString();

                    reader.Close();
                    mConn.Close();
                }
            }

        }
    }
}
