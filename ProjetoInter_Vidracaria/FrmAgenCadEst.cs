using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql;
using MySql.Data;
using MySql.Data.MySqlClient;
using ClosedXML.Excel;
using System.Globalization;
using System.Reflection;

namespace ProjetoInter_Vidracaria
{
    public partial class FrmAgenCadEst : Form
    {
        public FrmAgenCadEst()
        {
            InitializeComponent();
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

        private void mostrarResultados()
        {
            conectar();
            if (mConn.State == ConnectionState.Open)
            {
                if (cmbOpcoes.Text.ToString().Equals("Agendamento Instalações"))
                {
                    mAdapter = new MySqlDataAdapter("SELECT id AS ID, nome AS Nome, numero_celular AS 'Número do Celular', endereco AS Endereço, ordem_servico AS 'Ordem de Serviço', data_medicao AS 'Data da Medição', status_medicao AS 'Status da Medição', data_instalacao AS 'Data da Instalação', status_instalacao AS 'Status da Instalação', pagamento_total_concluido AS 'Pagamento Final Concluído', valor_total AS 'Valor Final' FROM Agendamento", mConn);
                    mAdapter.Fill(mDataSet, "Agendamento");
                    dgvResultado.DataSource = mDataSet;
                    dgvResultado.DataMember = "Agendamento";

                }
                else if (cmbOpcoes.Text.ToString().Equals("Clientes"))
                {
                    mAdapter = new MySqlDataAdapter("SELECT id AS ID, nome AS Nome, rg AS RG, cpf AS CPF, data_nascimento AS 'Data de Nascimento', numero_celular AS 'Número do Celular', endereco AS Endereço FROM Cliente", mConn);
                    mAdapter.Fill(mDataSet, "Cliente");
                    dgvResultado.DataSource = mDataSet;
                    dgvResultado.DataMember = "Cliente";

                }
                else if (cmbOpcoes.Text.ToString().Equals("Estoque"))
                {
                    mAdapter = new MySqlDataAdapter("SELECT id AS ID, produto AS Produto, tipo_produto AS Classificação, quantidade AS Quantidade, fornecedor AS Fornecedor FROM Produto", mConn);
                    mAdapter.Fill(mDataSet, "Produto");
                    dgvResultado.DataSource = mDataSet;
                    dgvResultado.DataMember = "Produto";

                }
            }
            mConn.Close();
        }

        private void FrmAgenCadEst_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void FrmAgenCadEst_Load(object sender, EventArgs e)
        {
            //conectar();
        }

        private void cmbOpcoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            mostrarResultados();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (cmbOpcoes.Text.ToString().Equals("Agendamento Instalações"))
            {
                FrmAgendamento frmAgendamento = new FrmAgendamento();
                frmAgendamento.Show();

                frmAgendamento.FormClosing += (s, args) => { mostrarResultados(); };

            }
            else if (cmbOpcoes.Text.ToString().Equals("Clientes"))
            {
                FrmClientes frmClientes = new FrmClientes();
                frmClientes.Show();

                frmClientes.FormClosing += (s, args) => { mostrarResultados(); };
            }
            else if (cmbOpcoes.Text.ToString().Equals("Estoque"))
            {
                FrmProdutos frmProdutos = new FrmProdutos();
                frmProdutos.Show();

                frmProdutos.FormClosing += (s, args) => { mostrarResultados(); };
            }
            else
            {
                MessageBox.Show("Selecione o tipo de inclusão de registro desejada (Agendamento Instalações, Cadastro Clientes, Estoque)", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dgvResultado.CurrentRow;
            if (selectedRow != null && selectedRow.Cells["id"].Value != null && !string.IsNullOrEmpty(selectedRow.Cells["id"].Value.ToString()))
            {
                string valor_id = this.dgvResultado.CurrentRow.Cells["id"].Value.ToString();

                DialogResult yesOrNo = MessageBox.Show("Confirmar remoção do registro selecionado?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (yesOrNo == DialogResult.Yes)
                {
                    conectar();
                    if (cmbOpcoes.Text.ToString().Equals("Agendamento Instalações"))
                    {
                        MySqlCommand command = new MySqlCommand("DELETE FROM Agendamento WHERE id ='" +
                                                                valor_id + "';", mConn);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Registro Excluído!");
                        mostrarResultados();
                    }
                    else if (cmbOpcoes.Text.ToString().Equals("Clientes"))
                    {
                        bool clienteSemInstEmAndamento = verificarInstalacoesParaRemocaoCliente(valor_id);
                        if (clienteSemInstEmAndamento)
                        {
                            MySqlCommand command = new MySqlCommand("DELETE FROM Cliente WHERE id ='" +
                                                                    valor_id + "';", mConn);
                            command.ExecuteNonQuery();
                            MessageBox.Show("Registro Excluído!");
                            mostrarResultados();
                        }
                        else
                        {
                            MessageBox.Show("O Cliente tem um processo de instalação em aberto, portanto não pode ter seu registro excluído");
                        }

                    }
                    else if (cmbOpcoes.Text.ToString().Equals("Estoque"))
                    {
                        MySqlCommand command = new MySqlCommand("DELETE FROM Produto WHERE id ='" +
                                                                valor_id + "';", mConn);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Registro Excluído!");
                        mostrarResultados();
                    }
                    else
                    {
                        MessageBox.Show("Selecione um registro para efetuar a exclusão!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
            }
            else
            {
                MessageBox.Show("Selecione o tipo de remoção desejada (Agendamento Instalações, Cadastro Clientes, Estoque)", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private bool verificarInstalacoesParaRemocaoCliente(string clienteId)
        {
            conectar();

            MySqlCommand comand1 = new MySqlCommand("SELECT nome FROM Cliente WHERE id = " + clienteId, mConn);
            string nomeCliente = comand1.ExecuteScalar()?.ToString().Trim();

            MySqlCommand comand2 = new MySqlCommand("SELECT status_instalacao FROM Agendamento WHERE nome = '" + nomeCliente + "'", mConn);
            string statusInsatalacaoVericacao = comand2.ExecuteScalar()?.ToString();

            if (statusInsatalacaoVericacao.Equals("Concluído")) { return true; }

            return false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dgvResultado.CurrentRow;
            if (selectedRow != null && selectedRow.Cells["id"].Value != null && !string.IsNullOrEmpty(selectedRow.Cells["id"].Value.ToString()))
            {
                string valor_id = this.dgvResultado.CurrentRow.Cells["id"].Value.ToString();

                if (cmbOpcoes.Text.ToString().Equals("Agendamento Instalações"))
                {
                    FrmAgendamento frmAgendamento = new FrmAgendamento(valor_id);
                    frmAgendamento.Show();

                    frmAgendamento.FormClosing += (s, args) => { mostrarResultados(); };
                }
                else if (cmbOpcoes.Text.ToString().Equals("Clientes"))
                {
                    FrmClientes frmClientes = new FrmClientes(valor_id);
                    frmClientes.Show();

                    frmClientes.FormClosing += (s, args) => { mostrarResultados(); };
                }
                else if (cmbOpcoes.Text.ToString().Equals("Estoque"))
                {
                    FrmProdutos frmProdutos = new FrmProdutos(valor_id);
                    frmProdutos.Show();

                    frmProdutos.FormClosing += (s, args) => { mostrarResultados(); };
                }
                else
                {
                    MessageBox.Show("Selecione um registro para efetuar a edição!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Selecione o tipo de edição desejada (Agendamento Instalações, Cadastro Clientes, Estoque)", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dataTable = new DataTable();

                foreach (DataGridViewColumn column in dgvResultado.Columns)
                {
                    dataTable.Columns.Add(column.HeaderText);
                }
                foreach (DataGridViewRow row in dgvResultado.Rows)
                {
                    if (dgvResultado.Rows.Count - 1 > row.Index)
                    {
                        dataTable.Rows.Add();
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            dataTable.Rows[dataTable.Rows.Count - 1][cell.ColumnIndex] = cell.Value.ToString();
                        }
                    }
                }

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Title = "Escolha o diretório para salvar seus relatórios";
                saveFileDialog.Filter = "Arquivos Excel (*.xlsx)|*.xlsx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string folderPath = saveFileDialog.FileName;

                    using (XLWorkbook workbook = new XLWorkbook())
                    {
                        workbook.Worksheets.Add(dataTable, "Relatório");

                        for (int i = 0; i < dataTable.Rows.Count; i++)
                        {
                            for (int j = 0; j < dataTable.Columns.Count; j++)
                            {
                                object cellVal = dataTable.Rows[i][j];
                                Type dataType = cellVal.GetType();

                                if (dataType == typeof(int) || dataType == typeof(double))
                                {
                                    workbook.Worksheet(1).Cell(i + 2, j + 1).Value = Convert.ToDouble(cellVal);
                                }
                                else if (dataType == typeof(string))
                                {
                                    string strCellVal = cellVal.ToString();
                                    if (DateTime.TryParseExact(strCellVal, "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime date))
                                    {
                                        workbook.Worksheet(1).Cell(i + 2, j + 1).Value = date;
                                        workbook.Worksheet(1).Cell(i + 2, j + 1).Style.DateFormat.Format = "dd/MM/yyyy";

                                    }
                                    else
                                    {
                                        workbook.Worksheet(1).Cell(i + 2, j + 1).Value = cellVal.ToString();
                                    }
                                }
                            }
                        }

                        workbook.Worksheet(1).Columns().AdjustToContents();
                        workbook.Worksheet(1).Rows().AdjustToContents();
                        workbook.Worksheet(1).Cells().Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                        workbook.Worksheet(1).Cells().Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                        workbook.SaveAs(folderPath);
                        MessageBox.Show("Relatório de " + cmbOpcoes.SelectedText.ToString() + " exportado com sucesso! Você pode encontrá-lo em " + folderPath, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Selecione uma das opções de Registros para efetuar a exportação", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
