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
using MySql;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace ProjetoInter_Vidracaria
{
    public partial class FrmAgendamento : Form
    {
        private string valorIdParaEdicao;

        public FrmAgendamento()
        {
            InitializeComponent();
        }

        public FrmAgendamento(string id)
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
            txtNumeroCelular.Text = "";
            txtEndereco.Text = "";
            txtOrdemServico.Text = "";
            txtDataMedicao.Text = "";
            cmbStatusMedicao.SelectedIndex = 0;
            txtDataInstalacao.Text = "";
            cmbStatusInstalacao.SelectedIndex = 0;
            cmbConclusaoPagamentoTotal.SelectedIndex = 0;
            txtValorTotal.Text = "";
        }

        private bool verificarCliente(string nomeCliente)
        {
            try
            {
                MySqlCommand command = new MySqlCommand("SELECT nome FROM Cliente WHERE nome = @nomeCliente", mConn);
                command.Parameters.AddWithValue("@nomeCliente", nomeCliente);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("O cliente '" + nomeCliente + "' não está cadastrado no sistema. Efetue o cadastro do cliente para possibilitar um Agendamento em seu nome.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            conectar();

            //Verificação Data
            if (!DateTime.TryParseExact(txtDataMedicao.Text, "dd/MM/yy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dataMedicaoInserida))
            {
                MessageBox.Show("Data de medição inválida. Insira uma data válida no formato 'dd/MM/yy'", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string dataMedicaoFormatoMySQL = dataMedicaoInserida.ToString("yyyy-MM-dd");

            //Verificação Data
            if (!DateTime.TryParseExact(txtDataInstalacao.Text, "dd/MM/yy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dataInstalacaoInserida))
            {
                MessageBox.Show("Data de instalação inválida. Insira uma data válida no formato 'dd/MM/yy'", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string dataInstalacaoFormatoMySQL = dataInstalacaoInserida.ToString("yyyy-MM-dd");

            //Verificação Valor Total
            if (!double.TryParse(txtValorTotal.Text, out double valorTotalInserido))
            {
                MessageBox.Show("Valor Total inválido. Insira apenas valores numéricos utilizando '.' ao invés de ',' como separador decimal.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            //Atualzação de Dados
            if (!string.IsNullOrEmpty(valorIdParaEdicao))
            {
                try
                {
                    MySqlCommand command = new MySqlCommand("UPDATE Agendamento SET nome = '" +
                                                             txtNome.Text.Trim() + "', numero_celular = '" +
                                                             txtNumeroCelular.Text.Trim() + "', endereco = '" +
                                                             txtEndereco.Text.Trim() + "', ordem_servico = '" +
                                                             txtOrdemServico.Text.Trim() + "', data_medicao = '" +
                                                             dataMedicaoFormatoMySQL + "', status_medicao = '" +
                                                             cmbStatusMedicao.Text.ToString() + "', data_instalacao = '" +
                                                             dataInstalacaoFormatoMySQL + "', status_instalacao = '" +
                                                             cmbStatusInstalacao.Text.ToString() + "', pagamento_total_concluido = '" +
                                                             cmbConclusaoPagamentoTotal.Text.ToString() + "', valor_total = '" +
                                                             txtValorTotal.Text + "' WHERE id = " + valorIdParaEdicao + ";", mConn);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Alterado com Sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    mConn.Close();
                    this.Close();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Valor Total inválido. Insira apenas valores numéricos utilizando '.' ao invés de ',' como separador decimal.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Insira valores em todos os campos para efetuar atualização de um agendamento.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            //Inserção de Dados
            else
            {
                try
                {
                    //parar execução do código caso o cliente não esteja cadastrado
                    if (!verificarCliente(txtNome.Text.Trim()))
                    {
                        return;
                    }
                    MySqlCommand command = new MySqlCommand("INSERT INTO Agendamento (nome,numero_celular,endereco,ordem_servico,data_medicao,status_medicao,data_instalacao,status_instalacao,pagamento_total_concluido,valor_total)" +
                                                            "VALUES ('" + txtNome.Text.Trim() + "','" +
                                                                          txtNumeroCelular.Text.Trim() + "','" +
                                                                          txtEndereco.Text.Trim() + "','" +
                                                                          txtOrdemServico.Text.Trim() + "','" +
                                                                          dataMedicaoFormatoMySQL + "','" +
                                                                          cmbStatusMedicao.Text.ToString() + "','" +
                                                                          dataInstalacaoFormatoMySQL + "','" +
                                                                          cmbStatusInstalacao.Text.ToString() + "','" +
                                                                          cmbConclusaoPagamentoTotal.Text.ToString() + "','" +
                                                                          txtValorTotal.Text + "')", mConn);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Gravado com Sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    limpar();
                    mConn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Insira valores em todos os campos para efetuar inserção de um novo agendamento.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void FrmAdicionarAgendamento_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void FrmAdicionarAgendamento_Load(object sender, EventArgs e)
        {
            conectar();

            if (!string.IsNullOrEmpty(valorIdParaEdicao))
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM Agendamento WHERE id= " + valorIdParaEdicao, mConn);
                MySqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    txtNome.Text = reader["nome"].ToString();
                    txtNumeroCelular.Text = reader["numero_celular"].ToString();
                    txtEndereco.Text = reader["endereco"].ToString();
                    txtOrdemServico.Text = reader["ordem_servico"].ToString();

                    DateTime dataMedicao = DateTime.Parse(reader["data_medicao"].ToString());
                    txtDataMedicao.Text = dataMedicao.ToString("dd/MM/yy");

                    cmbStatusMedicao.SelectedItem = reader["status_medicao"].ToString();

                    DateTime dataInstalacao = DateTime.Parse(reader["data_instalacao"].ToString());
                    txtDataInstalacao.Text = dataInstalacao.ToString("dd/MM/yy");

                    cmbStatusInstalacao.SelectedItem = reader["status_instalacao"].ToString();
                    cmbConclusaoPagamentoTotal.SelectedItem = reader["pagamento_total_concluido"].ToString();
                    txtValorTotal.Text = reader["valor_total"].ToString();


                    reader.Close();
                    mConn.Close();
                }
            }
        }

        private void txtNome_Leave(object sender, EventArgs e)
        {
            //Verifica se é uma inserção de um novo Agendamento / se o campo txtNome não está vazio
            if (string.IsNullOrEmpty(valorIdParaEdicao) && !string.IsNullOrEmpty(txtNome.Text))
            {
                conectar();
                MySqlCommand command = new MySqlCommand("SELECT nome, numero_celular, endereco FROM Cliente WHERE nome= '" + txtNome.Text.Trim() + "'", mConn);
                MySqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    txtNumeroCelular.Text = reader["numero_celular"].ToString();
                    txtEndereco.Text = reader["endereco"].ToString();
                }

                txtNumeroCelular.ReadOnly = true;
                txtEndereco.ReadOnly = true;
            }
            //Se o usurio apagar o valor inserido no txtNome, os campos voltam a ser editaveis
            else if (string.IsNullOrEmpty(txtNome.Text))
            {
                txtNumeroCelular.Text = "";
                txtEndereco.Text = "";
                txtNumeroCelular.ReadOnly = false;
                txtEndereco.ReadOnly = false;
            }
        }
    }
}