using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoInter_Vidracaria
{
    public partial class FrmProdutos : Form
    {
        private string valorIdParaEdicao;

        public FrmProdutos()
        {
            InitializeComponent();
        }
        public FrmProdutos(string id)
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
            txtProduto.Text = "";
            txtTipoProduto.Text = "";
            txtQuantidade.Text = "";
            txtFornecedor.Text = "";
        }

        private void FrmProdutos_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            conectar();

            //Validação da inserção de um Nº inteiro em txtQuatidade
            if (!int.TryParse(txtQuantidade.Text, out int quantidade))
            {
                MessageBox.Show("Quantidade inválida. Insira um valor numérico inteiro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Atualzação de Dados
            if (!string.IsNullOrEmpty(valorIdParaEdicao))
            {
                MySqlCommand command = new MySqlCommand("UPDATE Produto SET produto = '" +
                                                         txtProduto.Text + "', tipo_produto = '" +
                                                         txtTipoProduto.Text + "', quantidade = '" +
                                                         quantidade + "', fornecedor = '" +
                                                         txtFornecedor.Text + "' WHERE id = " + valorIdParaEdicao + ";", mConn);
                command.ExecuteNonQuery();
                MessageBox.Show("Alterado com Sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            //Inserção de Dados
            else
            {

                MySqlCommand command = new MySqlCommand("INSERT INTO Produto (produto,tipo_produto,quantidade,fornecedor)" +
                                                        "VALUES ('" + txtProduto.Text + "','" +
                                                                      txtTipoProduto.Text + "','" +
                                                                      quantidade + "','" +
                                                                      txtFornecedor.Text + "')", mConn);
                command.ExecuteNonQuery();
                MessageBox.Show("Gravado com Sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            limpar();
            mConn.Close();
        }

        private void FrmProdutos_Load(object sender, EventArgs e)
        {
            conectar();

            if (!string.IsNullOrEmpty(valorIdParaEdicao))
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM Produto WHERE id= " + valorIdParaEdicao, mConn);
                MySqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    txtProduto.Text = reader["produto"].ToString();
                    txtTipoProduto.Text = reader["tipo_produto"].ToString();
                    txtQuantidade.Text = reader["quantidade"].ToString();
                    txtFornecedor.Text = reader["fornecedor"].ToString();


                    reader.Close();
                    mConn.Close();
                }
            }

        }
    }
}
