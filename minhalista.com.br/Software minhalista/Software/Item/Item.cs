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
    public partial class Item : Form
    {
        MySqlConnection conexao;
        MySqlDataAdapter DataAdapter1;
        MySqlDataAdapter DataAdapter2;
        string atributo;
        string sDate;
        public Item()
        {
            InitializeComponent();
        }

        private void Item_Load(object sender, EventArgs e)
        {
            PreencherGrid();
            PreencherComboBoxfornecedor();
            PreencherComboBoxproduto();
            
        }
        private void PreencherGrid()
        {
            conexao = new MySqlConnection("server=localhost;User Id=root;password=123456;database=minhalista");

            string srtComando1 = "select * from item";
            
            try
            {
                DataAdapter1 = new MySqlDataAdapter(srtComando1, conexao);
                DataTable tabelaDeDados1 = new DataTable();
                DataAdapter1.Fill(tabelaDeDados1);
                dataGridView1.DataSource = tabelaDeDados1;
                dataGridView1.Columns[3].DefaultCellStyle.Format = "C";
                
                dataGridView1.RowHeadersVisible = false;

             

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro ao tentar preencher as células, verifique a conexão com o banco: " + ex.Message);
            }


        }

        private void PreencherComboBoxfornecedor()
        {
            //Preencher combobox nome fornecedor
           

            DataAdapter1 = new MySqlDataAdapter("select * from fornecedor", conexao);
            DataTable tabelaDeDados1 = new DataTable();
            DataAdapter1.Fill(tabelaDeDados1);

            comboBox1.DataSource = tabelaDeDados1;
            comboBox1.DisplayMember = "Nome_Fornecedor";

        }
        private void PreencherComboBoxproduto()
         {
            //Preencher combobox nome intem
            DataAdapter1 = new MySqlDataAdapter("select * from produto", conexao);
            DataTable tabelaDeDados2 = new DataTable();
            DataAdapter1.Fill(tabelaDeDados2);

            comboBox2.DataSource = tabelaDeDados2;
            comboBox2.DisplayMember = "Nome_Produto";
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

            if (textBox4.Text == string.Empty)
                return false;
            if (textBox5.Text == string.Empty)
                return false;
            return true;
        }
        //Alterar item
        private void AlterarDados()
        {
            //define a instrução MySQL para atualizar os dados da tabela produto - UPDATE tabela SET campos
            MySqlCommand cmdAlterarI = new MySqlCommand("UPDATE item SET ID_Item ='" + textBox3.Text + "', ID_Produto='" + textBox2.Text + "', Preco='" + textBox4.Text + "', Disponibilidade='" + textBox5.Text + "', Quantidade='" + textBox6.Text + "' WHERE ID_Item=" + textBox1.Text + "", conexao);

            try
            {
                conexao.Open();
                // executa a instrução MySQL
                cmdAlterarI.ExecuteNonQuery();

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
        //Novo intem
        private void SalvaDados()
        {


            //define instrução MySQL para incluir dados na tabela CLientes - INSERT INTO tabela VALUES (campos)
            //                                                                              nome produto              marca                   imagem                 id categoria 
            MySqlCommand cmdIncluirI = new MySqlCommand("INSERT INTO item VALUES(0,'" + textBox1.Text + "','" + textBox3.Text + "','" + textBox2.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')", conexao);

            /*/selecionar o ID do responsavel o ultimo ID
            DataAdapter1 = new MySqlDataAdapter("select max(ID_Produto) as resp from produto", conexao);
            DataTable tabelaDeDados = new DataTable();
            DataAdapter1.Fill(tabelaDeDados);
            string resultado = tabelaDeDados.Rows[0]["resp"].ToString();

            MySqlCommand cmdIncluirC = new MySqlCommand("INSERT INTO categoria VALUES(0,'" + comboBox4.Text + "','" + resultado + "')", conexao);*/


            try
            {
                // abre o banco
                conexao.Open();
                // executa a query
                cmdIncluirI.ExecuteNonQuery();
                //cmdIncluirC.ExecuteNonQuery();
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
        //Excluir Produto
        private void ExcluirDados()
        {


            //define instrução SQL para excluir dados da tabela Clientes - DELETE FROM tabela Where <criterio>
            MySqlCommand cmdExcluirI = new MySqlCommand("DELETE FROM item WHERE ID_Item=" + textBox1.Text + "", conexao);
            //MySqlCommand cmdExcluirC = new MySqlCommand("DELETE FROM categoria WHERE ID_produto=" + textBox4.Text + "", conexao);

            try
            {
                // abre o banco de dados
                conexao.Open();
                // executa a instrução MySQL
                cmdExcluirI.ExecuteNonQuery();
                //cmdExcluirC.ExecuteNonQuery();
                //
                MessageBox.Show("Dados Excluídos com sucesso.");
                PreencherGrid();
            }
            //Trata a exceção
            catch (MySqlException ex)
            {
                MessageBox.Show("Error ao tentar excluir produto: " + ex.Message);
            }
            finally
            {
                //fecha a conexao 
                conexao.Close();
            }

        }

        //Selecionar combox produto
        //Selecionar nome para chamar id produto
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string srtComando2 = " select * from produto where Nome_Produto='" + comboBox2.Text + "'";

            DataAdapter2 = new MySqlDataAdapter(srtComando2, conexao);
            DataTable tabelaDeDados1 = new DataTable();
            DataAdapter2.Fill(tabelaDeDados1);

            if (comboBox2.Text != "System.Data.DataRowView")
            {

                textBox2.Text = tabelaDeDados1.Rows[0]["ID_Produto"].ToString();

            }
        }
        //Selecionar combox fornecedor
        //Selecionar nome para chamar id fornecedor
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string srtComando1 = "select * from fornecedor where Nome_Fornecedor='" + comboBox1.Text + "'";

            DataAdapter1 = new MySqlDataAdapter(srtComando1, conexao);
            DataTable tabelaDeDados1 = new DataTable();
            DataAdapter1.Fill(tabelaDeDados1);

            if (comboBox1.Text != "System.Data.DataRowView")
            {

                textBox3.Text = tabelaDeDados1.Rows[0]["ID_Fornecedor"].ToString();

            }
        }
        //pesquisa 
        private void button2_Click(object sender, EventArgs e)
        {
            //Pesuqisar
            try
            {
                if (textBox13.Text == string.Empty)
                {
                    MessageBox.Show("Campo de pesquisa vazio ", "Pesquisar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    textBox13.Focus();
                }
                if (comboBox3.SelectedItem.ToString() == "Identificação Item")
                {
                    DataAdapter1 = new MySqlDataAdapter("select * from item where ID_Item like '%" + textBox13.Text + "%'", conexao);
                    atributo = "ID_Item";
                }
               
                if (comboBox3.SelectedItem.ToString() == "Identificação Produto")
                {
                    DataAdapter1 = new MySqlDataAdapter("select * from item where ID_Produto like '%" + textBox13.Text + "%'", conexao);
                    atributo = "ID_Produto";
                }
                if (comboBox3.SelectedItem.ToString() == "Disponibilidade")
                {
                    DataAdapter1 = new MySqlDataAdapter("select * from item where Disponibilidade like '%" + textBox13.Text + "%'", conexao);
                    atributo = "Disponibilidade";
                }
                //enviar pra o intem
                if (comboBox3.SelectedItem.ToString() == "Identificação Fornecedor")
                {
                    DataAdapter1 = new MySqlDataAdapter("select fornecedor.ID_Fornecedor,fornecedor.Nome_Fornecedor,item.* from item,fornecedor where item.ID_Fornecedor=fornecedor.ID_Fornecedor and fornecedor.ID_Fornecedor like '%" + textBox13.Text + "%'", conexao);
                    DataTable tabelaDeDados2 = new DataTable();
                    DataAdapter1.Fill(tabelaDeDados2);
                    dataGridView1.DataSource = tabelaDeDados2;
                    MessageBox.Show("Registro encontrado");
                    return;
                }
                               
                if (comboBox3.SelectedItem.ToString() == "Nome Fornecedor")
                {                  //chamar NOME do FORNECEDOR
                    DataAdapter1 = new MySqlDataAdapter("select fornecedor.Nome_Fornecedor,item.* from item,fornecedor where item.ID_Fornecedor=fornecedor.ID_Fornecedor and fornecedor.Nome_Fornecedor like'%" + textBox13.Text + "%'", conexao);
                    DataTable tabelaDeDados2 = new DataTable();
                    DataAdapter1.Fill(tabelaDeDados2);
                    dataGridView1.DataSource = tabelaDeDados2;
                    MessageBox.Show("Registro encontrado");
                    return;
                }
                if (comboBox3.SelectedItem.ToString() == "Quantidade")
                {
                    DataAdapter1 = new MySqlDataAdapter("select * from item where Quantidade like '%" + textBox13.Text + "%'", conexao);
                    atributo = "Quantidade";
                }
                if (comboBox1.SelectedItem.ToString() == "Data Alteração")
                {

                    DateTime date = dateTimePicker1.Value.Date;
                    sDate = date.ToString("yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
                    // DateTime dateInsert = Convert.ToDateTime(sDate);
                    DataAdapter1 = new MySqlDataAdapter("select * from item where Data_Ultima_Alteração='" + sDate + "'", conexao);
                    DataTable tabelaDeDados2 = new DataTable();
                    DataAdapter1.Fill(tabelaDeDados2);
                    dataGridView1.DataSource = tabelaDeDados2;

                    MessageBox.Show("Registro encontrado");
                    return;
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
            catch
            {
                MessageBox.Show("Selecione uma opção no combo para realizar a pesquisa ", "Pesquisar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                // pega o indice da linha selecionada.
                int linhaSelec = dataGridView1.CurrentRow.Index;

                //Campo fornecedor 

                textBox1.Text = dataGridView1[0, linhaSelec].Value.ToString();
                textBox2.Text = dataGridView1[2, linhaSelec].Value.ToString();
                textBox3.Text = dataGridView1[1, linhaSelec].Value.ToString();
                textBox4.Text = dataGridView1[3, linhaSelec].Value.ToString();
                textBox5.Text = dataGridView1[4, linhaSelec].Value.ToString();
                textBox6.Text = dataGridView1[6, linhaSelec].Value.ToString();
               


            }
            catch (Exception)
            {

                MessageBox.Show("Atenção sequencia das células motificada");
            }  
        }
        //botão alterar item
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (validaDados())
            {
                if (MessageBox.Show("Deseja fazer a alteração nos dados do item? ", "Alterar Produto", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    AlterarDados();
                }
            }
            else
            {
                MessageBox.Show("Produto não alterado verifique todos os campos");
            }
        }
        //botão Novo item
        private void button3_Click(object sender, EventArgs e)
        {
            if (validaDados())
            {
                  if (MessageBox.Show("Deseja adicionar um novo item? ", "Adicionar item", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {

                        SalvaDados();

                    }

                }

                            
            else
            {
                MessageBox.Show("Item não adicionado verifique todos os campos");
            }
        }
        //botao excluir item
        private void button4_Click(object sender, EventArgs e)
        {
           

            //solicitação confirmação para excluir
            if (validaDados())
            {
                if (MessageBox.Show("Deseja excluir o item? ", "Excluir item", MessageBoxButtons.YesNo) == DialogResult.Yes)
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
