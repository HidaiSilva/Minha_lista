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
    public partial class VerCliente : Form
    {
        MySqlConnection conexao;
        MySqlDataAdapter DataAdapter1;
        string resultado;
        string atributo;
        public VerCliente()
        {
            InitializeComponent();
        }
        #region Outros
        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {

        }

        private void VerCliente_Load(object sender, EventArgs e)
        {
            PreencherGrid();
            

        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        #endregion

        private void PreencherGrid()
        {
            conexao = new MySqlConnection("server=localhost;User Id=root;password=anderson;database=minhalista");

            string srtComando1 = "select ID_cliente,Nome,CPF,Endereco,Telefone,Email,Telcelular,Bairro,CEP,NumeroR,Cidade from cliente";

            DataAdapter1 = new MySqlDataAdapter(srtComando1, conexao);
            DataTable tabelaDeDados1 = new DataTable();
            DataAdapter1.Fill(tabelaDeDados1);
            dataGridView1.DataSource = tabelaDeDados1;
            dataGridView1.RowHeadersVisible = false;


        }
        //botão pesquisa
        private void button2_Click(object sender, EventArgs e)
        {
            //Pesuqisar


            if (comboBox1.SelectedItem.ToString() == "Identicação Cliente")
            {
                DataAdapter1 = new MySqlDataAdapter("select * from cliente where ID_cliente like '%" + textBox13.Text + "%'", conexao);
                atributo = "ID_cliente";
            }
            if (comboBox1.SelectedItem.ToString() == "Nome Cliente")
            {
                DataAdapter1 = new MySqlDataAdapter("select * from cliente where Nome like '%" + textBox13.Text + "%'", conexao);
                atributo = "Nome";
            }
            if (comboBox1.SelectedItem.ToString() == "CPF")
            {
                DataAdapter1 = new MySqlDataAdapter("select * from cliente where CPF like '%" + textBox13.Text + "%'", conexao);
                atributo = "CPF";
            }
            if (comboBox1.SelectedItem.ToString() == "Endereço")
            {
                DataAdapter1 = new MySqlDataAdapter("select * from cliente where Endereco like '%" + textBox13.Text + "%'", conexao);
                atributo = "Endereco";
            }
            if (comboBox1.SelectedItem.ToString() == "Telefone")
            {
                DataAdapter1 = new MySqlDataAdapter("select * from cliente where Telefone like '%" + textBox13.Text + "%'", conexao);
                atributo = "Telefone";
            }
            if (comboBox1.SelectedItem.ToString() == "E-mail")
            {
                DataAdapter1 = new MySqlDataAdapter("select * from cliente where Email like '%" + textBox13.Text + "%'", conexao);
                atributo = "Email";
            }
            if (comboBox1.SelectedItem.ToString() == "Celular")
            {
                DataAdapter1 = new MySqlDataAdapter("select * from cliente where Telcelular like '%" + textBox13.Text + "%'", conexao);
                atributo = "Telcelular";
            }
            if (comboBox1.SelectedItem.ToString() == "Bairro")
            {
                DataAdapter1 = new MySqlDataAdapter("select * from cliente where Bairro like '%" + textBox13.Text + "%'", conexao);
                atributo = "Bairro";
            }
            if (comboBox1.SelectedItem.ToString() == "CEP")
            {
                DataAdapter1 = new MySqlDataAdapter("select * from cliente where CEP like '%" + textBox13.Text + "%'", conexao);
                atributo = "CEP";
            }
            if (comboBox1.SelectedItem.ToString() == "Numero Endereço")
            {
                DataAdapter1 = new MySqlDataAdapter("select * from cliente where NumeroR like '%" + textBox13.Text + "%'", conexao);
                atributo = "NumeroR";
            }
            if (comboBox1.SelectedItem.ToString() == "Cidade")
            {
                DataAdapter1 = new MySqlDataAdapter("select * from cliente where Cidade like '%" + textBox13.Text + "%'", conexao);
                atributo = "Cidade";
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

      

        private void dataGridView1_SelectionChanged_1(object sender, EventArgs e)
        {
            // pega o indice da linha selecionada.
            int linhaSelec2 = dataGridView1.CurrentRow.Index;

            //Preencher Campo Responsavel
            textBox1.Text = dataGridView1[0, linhaSelec2].Value.ToString();
            textBox2.Text = dataGridView1[1, linhaSelec2].Value.ToString();
            textBox3.Text = dataGridView1[2, linhaSelec2].Value.ToString();
            textBox4.Text = dataGridView1[3, linhaSelec2].Value.ToString();
            textBox5.Text = dataGridView1[4, linhaSelec2].Value.ToString();
            textBox6.Text = dataGridView1[5, linhaSelec2].Value.ToString();

            textBox7.Text = dataGridView1[6, linhaSelec2].Value.ToString();
            textBox8.Text = dataGridView1[7, linhaSelec2].Value.ToString();
            textBox9.Text = dataGridView1[8, linhaSelec2].Value.ToString();
            textBox10.Text = dataGridView1[9, linhaSelec2].Value.ToString();
            textBox11.Text = dataGridView1[10, linhaSelec2].Value.ToString();
        }


    }
}
