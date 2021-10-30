using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace MinhaLista
{
    public partial class Pedido : Form
    {
        MySqlConnection conexao;
        MySqlDataAdapter DataAdapter1;
        string resultado;
        string sDate;
        string atributo;
        private string ID_pedido,data_entrada,horario_entrada,operadora,forma_pagamento,data_saida,horario_saida,status,ID_funcionario,ID_cliente;
        public Pedido()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // obtemDadosGrid();
            VisualizarPedido verpedido = new VisualizarPedido();

            verpedido.ID_pedido = ID_pedido;
            verpedido.data_entrada = data_entrada;
            verpedido.horario_entrada = horario_entrada;
            verpedido.operadora = operadora;
            verpedido.forma_pagamento = forma_pagamento;
            verpedido.data_saida = data_saida;
            verpedido.horario_saida = horario_saida;
            verpedido.status = status;
            verpedido.ID_funcionario = ID_funcionario;
            verpedido.ID_cliente = ID_cliente;
            
            verpedido.ShowDialog();

        }
        private void PreencherGrid()
        {
            conexao = new MySqlConnection("server=localhost;User Id=root;password=123456;database=minhalista");

            string srtComando1 = "select * from pedido";

            DataAdapter1 = new MySqlDataAdapter(srtComando1, conexao);
            DataTable tabelaDeDados1 = new DataTable();
            DataAdapter1.Fill(tabelaDeDados1);
            dataGridView1.DataSource = tabelaDeDados1;
            dataGridView1.RowHeadersVisible = false;


        }
        private void PedidoPendente_Load(object sender, EventArgs e)
        {
            PreencherGrid();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Pesuqisar


            if (comboBox1.SelectedItem.ToString() == "Numero Pedido")
            {
                DataAdapter1 = new MySqlDataAdapter("select * from historico_pedido where ID_pedido like '%" + textBox13.Text + "%'", conexao);
                atributo = "ID_pedido";
            }
            if (comboBox1.SelectedItem.ToString() == "Identificação Funcionario")
            {
                DataAdapter1 = new MySqlDataAdapter("select * from pedido where ID_funcionario like '%" + textBox13.Text + "%'", conexao);
                atributo = "ID_funcionario";
            }
            if (comboBox1.SelectedItem.ToString() == "Identificação Cliente")
            {
                DataAdapter1 = new MySqlDataAdapter("select * from pedido where ID_cliente like '%" + textBox13.Text + "%'", conexao);
                atributo = "ID_cliente";
            }
            if (comboBox1.SelectedItem.ToString() == "Forma Pagamento")
            {
                DataAdapter1 = new MySqlDataAdapter("select * from pedido where forma_pagamento like '%" + textBox13.Text + "%'", conexao);
                atributo = "forma_pagamento";
            }
            if (comboBox1.SelectedItem.ToString() == "Operadora")
            {
                DataAdapter1 = new MySqlDataAdapter("select * from pedido where operadora like '%" + textBox13.Text + "%'", conexao);
                atributo = "operadora";
            }
            if (comboBox1.SelectedItem.ToString() == "Status")
            {
                DataAdapter1 = new MySqlDataAdapter("select * from pedido where status_pedido like '%" + textBox13.Text + "%'", conexao);
                atributo = "status_pedido";
            }
            if (comboBox1.SelectedItem.ToString() == "Data Entrada")
            {

                DateTime date = dateTimePicker1.Value.Date;
                sDate = date.ToString("yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
                // DateTime dateInsert = Convert.ToDateTime(sDate);
                DataAdapter1 = new MySqlDataAdapter("select * from pedido where data_entrada='" + sDate + "'", conexao);
                DataTable tabelaDeDados2 = new DataTable();
                DataAdapter1.Fill(tabelaDeDados2);
                dataGridView1.DataSource = tabelaDeDados2;

                MessageBox.Show("Registro encontrado");
                return;
            }
            if (comboBox1.SelectedItem.ToString() == "Data Saida")
            {

                DateTime date = dateTimePicker1.Value.Date;
                sDate = date.ToString("yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
                // DateTime dateInsert = Convert.ToDateTime(sDate);
                DataAdapter1 = new MySqlDataAdapter("select * from pedido where data_saida='" + sDate + "'", conexao);
                DataTable tabelaDeDados2 = new DataTable();
                DataAdapter1.Fill(tabelaDeDados2);
                dataGridView1.DataSource = tabelaDeDados2;

                MessageBox.Show("Registro encontrado");
                return;
            }

            DataTable tabelaDeDados1 = new DataTable();
            DataAdapter1.Fill(tabelaDeDados1);

            resultado = tabelaDeDados1.Rows[0][atributo].ToString();

            if (resultado != string.Empty)
            {
                dataGridView1.DataSource = tabelaDeDados1;
                MessageBox.Show("Registro encontrado");

            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            obtemDadosGrid();
        }
        private void obtemDadosGrid()
        {
            int linhaSelec = dataGridView1.CurrentRow.Index;

            //selecionar o campo na grid que sera enviado para outra tela
            ID_pedido = dataGridView1[0, linhaSelec].Value.ToString();
            data_entrada = dataGridView1[1, linhaSelec].Value.ToString();
            horario_entrada = dataGridView1[2, linhaSelec].Value.ToString();
            operadora = dataGridView1[3, linhaSelec].Value.ToString();
            forma_pagamento = dataGridView1[4, linhaSelec].Value.ToString();
            data_saida = dataGridView1[5, linhaSelec].Value.ToString();
            horario_saida = dataGridView1[6, linhaSelec].Value.ToString();
            status = dataGridView1[7, linhaSelec].Value.ToString();
            ID_funcionario = dataGridView1[8, linhaSelec].Value.ToString();
            ID_cliente = dataGridView1[9, linhaSelec].Value.ToString();
        }

    }
}
