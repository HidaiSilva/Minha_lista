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
    public partial class Produto : Form
    {
        MySqlConnection conexao;
        MySqlDataAdapter DataAdapter1;
        string atributo = "";

        public Produto()
        {
            InitializeComponent();
        }
        private void AlterraProduto_Load(object sender, EventArgs e)
        {
            PreencherGrid();
            PreencherComboBox();
        }
        
       
        //Verificar campos em brancos
        private Boolean validaDados()
        {
            if (textBox1.Text == string.Empty)
                return false;

            if (textBox2.Text == string.Empty)
                return false;

            if (textBox3.Text == string.Empty)
                return false;
           
            return true;
        }

        private void PreencherGrid()
        {
            conexao = new MySqlConnection("server=localhost;User Id=root;password=anderson;database=minhalista");

            string srtComando1 = "select * from produto";

            DataAdapter1 = new MySqlDataAdapter(srtComando1, conexao);
            DataTable tabelaDeDados1 = new DataTable();
            DataAdapter1.Fill(tabelaDeDados1);
            dataGridView1.DataSource = tabelaDeDados1;
            dataGridView1.RowHeadersVisible = false;

            
        }

        private void PreencherComboBox()
        {
            //Preencher combobox nome fornecedor
            string srtComando1 = "select * from fornecedor";

            DataAdapter1 = new MySqlDataAdapter(srtComando1, conexao);
            DataTable tabelaDeDados1 = new DataTable();
            DataAdapter1.Fill(tabelaDeDados1);
            
            comboBox1.DataSource = tabelaDeDados1;
            comboBox1.DisplayMember = "Nome_Fornecedor";

            //Preencher combobox categoria
            DataAdapter1 = new MySqlDataAdapter("select * from categoria", conexao);
            DataTable tabelaDeDados2 = new DataTable();
            DataAdapter1.Fill(tabelaDeDados2);
           
            comboBox4.DataSource = tabelaDeDados2;
            comboBox4.DisplayMember = "tipo";

           
        }
        //Alterar produto
        private void AlterarDados()
        {
            //define a instrução MySQL para atualizar os dados da tabela Clientes - UPDATE tabela SET campos
            MySqlCommand cmdAlterarP = new MySqlCommand("UPDATE produto SET Nome_Produto ='" + textBox1.Text + "', Marca='" + textBox2.Text + "' WHERE ID_produto=" + textBox4.Text + "", conexao);
            MySqlCommand cmdAlterarC = new MySqlCommand("UPDATE categoria SET tipo ='" + comboBox4.Text + "' WHERE ID_Produto=" + textBox4.Text + "", conexao);
            
            try
            {
                conexao.Open();
                // executa a instrução MySQL
                cmdAlterarP.ExecuteNonQuery();
                cmdAlterarC.ExecuteNonQuery();
                //
                MessageBox.Show("Dados Alterados com sucesso.");
                PreencherGrid();

            }
            //Trata a exceção
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                //fecha a conexao 
                conexao.Close();
            }
        }
        //Excluir Produto
        private void ExcluirDados()
        {


            //define instrução SQL para excluir dados da tabela Clientes - DELETE FROM tabela Where <criterio>
            MySqlCommand cmdExcluirP = new MySqlCommand("DELETE FROM produto WHERE ID_produto=" + textBox4.Text + "", conexao);
            MySqlCommand cmdExcluirC = new MySqlCommand("DELETE FROM categoria WHERE ID_produto=" + textBox4.Text + "", conexao);

            try
            {
                // abre o banco de dados
                conexao.Open();
                // executa a instrução MySQL
                cmdExcluirP.ExecuteNonQuery();
                cmdExcluirC.ExecuteNonQuery();
                //
                MessageBox.Show("Dados Excluídos com sucesso.");
                PreencherGrid();
            }
            //Trata a exceção
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                //fecha a conexao 
                conexao.Close();
            }

        }
        
        //Selecionar nome para chamar id fornecedor
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            
            string srtComando1 = " select * from fornecedor where Nome_Fornecedor='" + comboBox1.Text + "'";

            DataAdapter1 = new MySqlDataAdapter(srtComando1, conexao);
            DataTable tabelaDeDados1 = new DataTable();
            DataAdapter1.Fill(tabelaDeDados1);
           
            if (comboBox1.Text != "System.Data.DataRowView")
            {

                textBox3.Text = tabelaDeDados1.Rows[0]["ID_fornecedor"].ToString();

            }

            

        }
        //Botão Pesquisar 
        private void button2_Click(object sender, EventArgs e)
        {
            //Pesuqisar
          

            if (comboBox3.SelectedItem.ToString() == "Identificação Produto")
            {
                DataAdapter1 = new MySqlDataAdapter("select * from produto where ID_produto like '%" + textBox13.Text + "%'", conexao);
                atributo = "Nome"; 
            }
            if (comboBox3.SelectedItem.ToString() == "Nome Produto")
            {
                DataAdapter1 = new MySqlDataAdapter("select * from produto where Nome_Produto like '%" + textBox13.Text + "%'", conexao);
                atributo = "Nome_Produto";
            }
            if (comboBox3.SelectedItem.ToString() == "Marca")
            {
                DataAdapter1 = new MySqlDataAdapter("select * from produto where Marca like '%" + textBox13.Text + "%'", conexao);
                atributo = "Marca";
            }
            if (comboBox3.SelectedItem.ToString() == "Identificação Fornecedor")
            {
                DataAdapter1 = new MySqlDataAdapter("select fornecedor.ID_fornecedor,fornecedor.Nome_Fornecedor,produto.* from produto,fornecedor where produto.ID_fornecedor=fornecedor.ID_fornecedor and fornecedor.ID_fornecedor like '%" + textBox13.Text + "%'", conexao);
                DataTable tabelaDeDados2 = new DataTable();
                DataAdapter1.Fill(tabelaDeDados2);
                dataGridView1.DataSource = tabelaDeDados2;
                MessageBox.Show("Registro encontrado");
                return;
            }
            if (comboBox3.SelectedItem.ToString() == "Nome Fornecedor")
            {                  //chamar NOME do FORNECEDOR
                DataAdapter1 = new MySqlDataAdapter("select fornecedor.Nome_Fornecedor,produto.* from produto,fornecedor where produto.ID_fornecedor=fornecedor.ID_fornecedor and fornecedor.Nome_Fornecedor like'%" + textBox13.Text + "%'", conexao);
                DataTable tabelaDeDados2 = new DataTable();
                DataAdapter1.Fill(tabelaDeDados2);
                dataGridView1.DataSource = tabelaDeDados2;
                MessageBox.Show("Registro encontrado");
                return;
            }
            if (comboBox3.SelectedItem.ToString() == "Tipo Categoria")
            {      //Chamar o TIPO da categoria  
                DataAdapter1 = new MySqlDataAdapter("select categoria.tipo,produto.Nome_Produto,fornecedor.Nome_Fornecedor from categoria,produto,fornecedor where categoria.ID_Produto=produto.ID_produto and tipo like '%" + textBox13.Text + "%'", conexao);
                 // verificar a tabela atribuida 
                atributo = "tipo";
            }

            DataTable tabelaDeDados1 = new DataTable();
            DataAdapter1.Fill(tabelaDeDados1);

            string resultado = tabelaDeDados1.Rows[0][atributo].ToString();

            if (resultado != string.Empty)
            {
                dataGridView1.DataSource = tabelaDeDados1;
                MessageBox.Show("Registro encontrado");

            }
                
        }
        //Novo produto
        private void SalvaDados()
        {


            //define instrução MySQL para incluir dados na tabela CLientes - INSERT INTO tabela VALUES (campos)
            //                                                                              nome produto              marca              id fornecedor 
            MySqlCommand cmdIncluirP = new MySqlCommand("INSERT INTO produto VALUES(0,'" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')", conexao);
            
            //selecionar o ID do responsavel o ultimo ID
            DataAdapter1 = new MySqlDataAdapter("select max(ID_Produto) as resp from produto", conexao);
            DataTable tabelaDeDados = new DataTable();
            DataAdapter1.Fill(tabelaDeDados);
            string resultado = tabelaDeDados.Rows[0]["resp"].ToString();

            MySqlCommand cmdIncluirC = new MySqlCommand("INSERT INTO categoria VALUES(0,'" + comboBox4.Text + "','" + resultado + "')", conexao);


            try
            {
                // abre o banco
                conexao.Open();
                // executa a query
                cmdIncluirP.ExecuteNonQuery();
                cmdIncluirC.ExecuteNonQuery();
                //
                MessageBox.Show("Produto adicionado com sucesso.");
                PreencherGrid();
            }
            //Trata a exceção
            catch (MySqlException ex)
            {
                MessageBox.Show("Error ao adicionar produto: " + ex.Message);
            }
            finally
            {
                //fecha a conexao 
                conexao.Close();
            }
        }
        //Botão ADD produto
        private void button4_Click(object sender, EventArgs e)
        {
            if (validaDados())
            {
                SalvaDados();
                
            }
            else
            {
                MessageBox.Show("Produto não adicionado verifique todos os campos");
            }
        }
        //Botão Alterar produto
        private void button1_Click(object sender, EventArgs e)
        {
            if (validaDados())
            {
                AlterarDados();
            }
            else
            {
                MessageBox.Show("Produto não alterado verifique todos os campos");
            }
        }
        //Preencher campos do produto
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            // pega o indice da linha selecionada.
            int linhaSelec = dataGridView1.CurrentRow.Index;

            //Campo fornecedor 

            textBox1.Text = dataGridView1[1, linhaSelec].Value.ToString();
            textBox2.Text = dataGridView1[2, linhaSelec].Value.ToString();
            textBox3.Text = dataGridView1[3, linhaSelec].Value.ToString();
            textBox4.Text = dataGridView1[0, linhaSelec].Value.ToString();
            
        }
        //Botão Excluir produto
        private void button3_Click(object sender, EventArgs e)
        {
            //solicitação confirmação para excluir
            if (validaDados())
            {
                if (MessageBox.Show("Confirma exclusão? ", "Excluir", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    ExcluirDados();
                    

                }
            }
            else
            {
                MessageBox.Show("Verifique todos os campos para efetuar a exclusão");
            }
            
        }
        

    }
}
