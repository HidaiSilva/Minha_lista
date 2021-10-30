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
    public partial class TelaInicial : Form
    {
        MySqlConnection conexao;
        MySqlDataAdapter DataAdapter1;
        MySqlDataAdapter DataAdapter2;
        MySqlDataAdapter DataAdapter3;
        MySqlDataAdapter DataAdapter4;
        MySqlDataAdapter DataAdapter5;
        DataSet dset;

        public TelaInicial()
        {
            InitializeComponent();
        }

        private void TelaInicial_Load(object sender, EventArgs e)
        {
            #region Conexão

            #region Adapter
          
            #endregion
            conexao = new MySqlConnection("server=localhost;User Id=root; password=anderson;database=minha_lista");
            string srtComando1 = "select * from funcionario";
            string srtComando2 = "select * from fornecedor";
            string srtComando3 = "select * from cliente";
            string srtComando4 = "select operadora from pedido";
            string srtComando5 = "select * from historico_pedido";
            #endregion
            #region grid




            DataAdapter1 = new MySqlDataAdapter(srtComando1, conexao);
            DataTable tabelaDeDados1 = new DataTable();
            DataAdapter1.Fill(tabelaDeDados1);
            dataGridView1.DataSource = tabelaDeDados1;
            dataGridView1.RowHeadersVisible = false;

                     
            DataAdapter2 = new MySqlDataAdapter(srtComando2, conexao);
            DataTable tabelaDeDados2 = new DataTable();
            DataAdapter2.Fill(tabelaDeDados2);
            dataGridView2.DataSource = tabelaDeDados2;
          
            DataAdapter3 = new MySqlDataAdapter(srtComando3, conexao);
            DataTable tabelaDeDados3 = new DataTable();
            DataAdapter3.Fill(tabelaDeDados3);
            dataGridView3.DataSource = tabelaDeDados3;

            DataAdapter4 = new MySqlDataAdapter(srtComando4, conexao);
            DataTable tabelaDeDados4 = new DataTable();
            DataAdapter4.Fill(tabelaDeDados4);
            dataGridView4.DataSource = tabelaDeDados4;

            
            /*string cellValue = dataGridView4["forma_pagamento", 1].Value.ToString();
            label2.Text = cellValue;*/

            DataAdapter5 = new MySqlDataAdapter(srtComando5, conexao);
            DataTable tabelaDeDados5 = new DataTable();
            DataAdapter5.Fill(tabelaDeDados5);
            dataGridView5.DataSource = tabelaDeDados5;
            //comboBox1.DataSource = tabelaDeDados;
            //comboBox1.DisplayMember = "titulo";

            #endregion



        }
        #region Outros
        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPagePedidos_Click(object sender, EventArgs e)
        {

        }

        private void buttonNovo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Não programado");
        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*if (comboBox3.Text == "ID")
            {
                DataAdapter3 = new MySqlDataAdapter("select * from autores where idAutores='" + textBox3.Text + "'", conexao);
            }
            if (comboBox3.Text == "Escritor")
            {
                DataAdapter3 = new MySqlDataAdapter("select * from autores where Escritor='" + textBox3.Text + "'", conexao);
            }
            if (comboBox3.Text == "Livro")
            {
                DataAdapter3 = new MySqlDataAdapter("select * from autores where Livro='" + textBox3.Text + "'", conexao);
            }*/

            

        }
        #endregion
        #region Cliente
        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                string atributo = "";
                if (textBox3.Text == string.Empty)
                {
                    MessageBox.Show("Preencha o campo");
                }
                if (comboBox3.SelectedItem.ToString() == "Selecione")
                {
                    
                    MessageBox.Show("Selecione um campo");
                }
                   
                if (comboBox3.SelectedItem.ToString() == "Identificação" )
                {
                    DataAdapter3 = new MySqlDataAdapter("select * from cliente where ID_cliente='" + textBox3.Text + "'", conexao);
                    atributo = "ID_cliente";
                }
                if (comboBox3.SelectedItem.ToString() == "Nome")
                {
                    DataAdapter3 = new MySqlDataAdapter("select * from cliente where Nome='" + textBox3.Text + "'", conexao);
                    atributo = "Nome";
                }
                if (comboBox3.SelectedItem.ToString() == "CPF")
                {
                    DataAdapter3 = new MySqlDataAdapter("select * from cliente where CPF='" + textBox3.Text + "'", conexao);
                    atributo = "CPF";
                }
                if (comboBox3.SelectedItem.ToString() == "Endereço")
                {
                    DataAdapter3 = new MySqlDataAdapter("select * from cliente where Endereco='" + textBox3.Text + "'", conexao);
                    atributo = "Endereço";
                }
                if (comboBox3.SelectedItem.ToString() == "Telefone")
                {
                    DataAdapter3 = new MySqlDataAdapter("select * from cliente where Telefone='" + textBox3.Text + "'", conexao);
                    atributo = "Telefone";
                }
                if (comboBox3.SelectedItem.ToString() == "Email")
                {
                    DataAdapter3 = new MySqlDataAdapter("select * from cliente where Email='" + textBox3.Text + "'", conexao);
                    atributo = "Email";
                }
                DataTable tabelaDeDados3 = new DataTable();
                dset = new DataSet();
                    DataAdapter3.Fill(tabelaDeDados3);
                    
                    //resul = dset.Tables["*"].ToString();
                //textBox3.DataBindings.Add("Text",dset,"Escritor");
                    string resultado = tabelaDeDados3.Rows[0][atributo].ToString();
                    //int resultadoID = Convert.ToInt32(tabelaDeDados3.Rows[0]["Identificação"]);

                    if (textBox3.Text == resultado)
                    {
                           dataGridView3.DataSource = tabelaDeDados3;
                      MessageBox.Show("Registro encontrado");
                    }
                 
                
                //label1.Text = dset.Tables["autores"].ToString();
                
            }
            catch (Exception)
            {
                MessageBox.Show("Registro não encontrado");

            }
           
          
        }
            #endregion

        #region Pedidos
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                string atributo = "";

                if (textBox1.Text == string.Empty)
                {
                    MessageBox.Show("Preencha o campo");
                }
                if (comboBox1.SelectedItem.ToString() == "Selecione")
                {
                    MessageBox.Show("Selecione um campo");
                }

                if (comboBox1.SelectedItem.ToString() == "Identificação")
                {
                    DataAdapter4 = new MySqlDataAdapter("select * from pedido where ID_pedido='" + textBox1.Text + "'", conexao);
                    atributo = "ID_pedido";
                }
                if (comboBox1.SelectedItem.ToString() == "Operadora")
                {
                    DataAdapter4 = new MySqlDataAdapter("select * from pedido where operadora='" + textBox1.Text + "'", conexao);
                    atributo = "operadora";

                }
                if (comboBox1.SelectedItem.ToString() == "Forma de pagamento")
                {
                    DataAdapter4 = new MySqlDataAdapter("select * from pedido where forma_pagamento='" + textBox1.Text + "'", conexao);
                    atributo = "forma_pagamento";
                }
                                
                DataTable tabelaDeDados4 = new DataTable();
                dset = new DataSet();
                DataAdapter4.Fill(tabelaDeDados4);

                string resultado = tabelaDeDados4.Rows[0][atributo].ToString();
                if (textBox1.Text == resultado)
                {
                    dataGridView4.DataSource = tabelaDeDados4;
                    MessageBox.Show("Registro encontrado");
                }

                
               /*this.dateTimePicker1.Value = DateTime.Now.Date;
                label2.Text = dateTimePicker1.Value.Date.ToString();

                if (label2.Text != string.Empty )
                {
                    textBox1.Text = label2.Text;
                    label2.Text = string.Empty;
                }*/


            }
            catch (Exception)
            {
                MessageBox.Show("Registro não encontrado");

            }
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            NovoFornecedor NvFornecedor = new NovoFornecedor();
            NvFornecedor.ShowDialog();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Informaçoes_do_cliente NvInf = new Informaçoes_do_cliente();
            NvInf.ShowDialog();

            string cellValue = dataGridView1["nome", 1].Value.ToString();
            
            
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //label2.Text = this.dataGridView4.CurrentRow.Cells["operadora"].Value.ToString(); 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Int32 selectedRowCount =
        dataGridView4.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                System.Text.StringBuilder sb = new System.Text.StringBuilder();

                for (int i = 0; i < selectedRowCount; i++)
                {
                    sb.Append("Row: ");
                    sb.Append(dataGridView4.SelectedRows[i].Index.ToString());
                    sb.Append(Environment.NewLine);
                }

                sb.Append("Total: " + selectedRowCount.ToString());
                MessageBox.Show(sb.ToString(), "Selected Rows");
            }
        }


    }
}
