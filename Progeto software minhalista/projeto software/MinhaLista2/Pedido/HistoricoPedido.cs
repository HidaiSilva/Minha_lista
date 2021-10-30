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
    public partial class HistóricoPedido : Form
    {
        MySqlConnection conexao;
        MySqlDataAdapter DataAdapter1;
        string resultado;
        string sDate;
        string atributo;
        public HistóricoPedido()
        {
            InitializeComponent();
        }
        //chamar tela
        private void button1_Click(object sender, EventArgs e)
        {
            VisualizarHistoricoPedido verhitped = new VisualizarHistoricoPedido();
            verhitped.ShowDialog();
            
            
        }

        private void PreencherGrid()
        {
            conexao = new MySqlConnection("server=localhost;User Id=root;password=anderson;database=minhalista");

            string srtComando1 = "select * from historico_pedido";

            DataAdapter1 = new MySqlDataAdapter(srtComando1, conexao);
            DataTable tabelaDeDados1 = new DataTable();
            DataAdapter1.Fill(tabelaDeDados1);
            dataGridView1.DataSource = tabelaDeDados1;
            dataGridView1.RowHeadersVisible = false;


        }

        private void HistóricoPedido_Load(object sender, EventArgs e)
        {
            PreencherGrid();
        }
        //Pesquisa
        private void button2_Click(object sender, EventArgs e)
        {
            //Pesuqisar


            if (comboBox1.SelectedItem.ToString() == "ID Histórico Pedido")
            {
                DataAdapter1 = new MySqlDataAdapter("select * from historico_pedido where ID_historico_pedido like '%" + textBox13.Text + "%'", conexao);
                atributo = "ID_historico_pedido";
            }
            if (comboBox1.SelectedItem.ToString() == "Numero Pedido")
            {
                DataAdapter1 = new MySqlDataAdapter("select * from historico_pedido where ID_pedido like '%" + textBox13.Text + "%'", conexao);
                atributo = "ID_pedido";
            }
            if (comboBox1.SelectedItem.ToString() == "Identificação Funcionario")
            {
                DataAdapter1 = new MySqlDataAdapter("select * from historico_pedido where ID_funcionario like '%" + textBox13.Text + "%'", conexao);
                atributo = "ID_funcionario";
            }
            if (comboBox1.SelectedItem.ToString() == "Identificação Cliente")
            {
                DataAdapter1 = new MySqlDataAdapter("select * from historico_pedido where ID_cliente like '%" + textBox13.Text + "%'", conexao);
                atributo = "ID_cliente";
            }
            if (comboBox1.SelectedItem.ToString() == "Forma Pagamento")
            {
                DataAdapter1 = new MySqlDataAdapter("select * from historico_pedido where forma_pagamento like '%" + textBox13.Text + "%'", conexao);
                atributo = "forma_pagamento";
            }
            if (comboBox1.SelectedItem.ToString() == "Operadora")
            {
                DataAdapter1 = new MySqlDataAdapter("select * from historico_pedido where operadora like '%" + textBox13.Text + "%'", conexao);
                atributo = "operadora";
            }
            if (comboBox1.SelectedItem.ToString() == "Status")
            {
                DataAdapter1 = new MySqlDataAdapter("select * from historico_pedido where status_pedido like '%" + textBox13.Text + "%'", conexao);
                atributo = "status_pedido";
            }
            if (comboBox1.SelectedItem.ToString() == "Data Entrada")
            {
                
                    DateTime date = dateTimePicker1.Value.Date;
                    sDate = date.ToString("yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
                    // DateTime dateInsert = Convert.ToDateTime(sDate);
                    DataAdapter1 = new MySqlDataAdapter("select * from historico_pedido where data_entrada='" + sDate + "'", conexao);
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
                DataAdapter1 = new MySqlDataAdapter("select * from historico_pedido where horario_saida='" + sDate + "'", conexao);
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
    }
}
