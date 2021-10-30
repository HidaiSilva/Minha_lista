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
    public partial class Funcionario : Form
    {
        MySqlConnection conexao;
        MySqlDataAdapter DataAdapter1;
        string resultado;
        string sDate;
        
        string atributo;
        public Funcionario()
        {
            InitializeComponent();
        }
        //Prencher grid
        private void PreencherGrid()
        {
            conexao = new MySqlConnection("server=localhost;User Id=root;password=anderson;database=minhalista");

            string srtComando1 = "select * from funcionario";
           
            DataAdapter1 = new MySqlDataAdapter(srtComando1, conexao);
            DataTable tabelaDeDados1 = new DataTable();
            DataAdapter1.Fill(tabelaDeDados1);
            dataGridView1.DataSource = tabelaDeDados1;
            dataGridView1.RowHeadersVisible = false;

            
        }
        private void AlterarDados()
        {
            //define a instrução MySQL para atualizar os dados da tabela Clientes - UPDATE tabela SET campos
            MySqlCommand cmdAlterarF = new MySqlCommand("UPDATE funcionario SET nome ='" + textBox2.Text + "', senha='" + textBox3.Text + "', email='" + textBox4.Text + "'  WHERE ID_funcionario=" + textBox1.Text + "", conexao);
           

            try
            {
                conexao.Open();
                // executa a instrução MySQL
                cmdAlterarF.ExecuteNonQuery();
                
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
        //Verificar campos em brancos
        private Boolean validaDados()
        {

            if (textBox2.Text == string.Empty)
                return false;

            if (textBox3.Text == string.Empty)
                return false;

            if (textBox4.Text == string.Empty)
                return false;
            
            return true;
        }
        //Novo funcionario
        private void SalvaDados()
        {


            //define instrução MySQL para incluir dados na tabela CLientes - INSERT INTO tabela VALUES (campos)
            //                                                                              nome funcionario             telefone                                    email
            MySqlCommand cmdIncluirF = new MySqlCommand("INSERT INTO funcionario VALUES(0,'" + textBox2.Text + "','" + textBox3.Text + "','123456','" + textBox4.Text + "')", conexao);
            //                             0,     'maria',                 '39532546',       '123456',     'maria@mimhalista.com' 


            try
            {
                // abre o banco
                conexao.Open();
                // executa a query
                cmdIncluirF.ExecuteNonQuery();

                //
                MessageBox.Show("Funcionario adicionado com sucesso.");
                PreencherGrid();
            }
            //Trata a exceção
            catch (MySqlException ex)
            {
                MessageBox.Show("Error ao adicionar funcionario: " + ex.Message);
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
            MySqlCommand cmdExcluirF = new MySqlCommand("DELETE FROM funcionario WHERE ID_funcionario=" + textBox1.Text + "", conexao);
            

            try
            {
                // abre o banco de dados
                conexao.Open();
                // executa a instrução MySQL
                cmdExcluirF.ExecuteNonQuery();
               
                //
                MessageBox.Show("Dados Excluídos com sucesso.");
                PreencherGrid();
            }
            //Trata a exceção
            catch (MySqlException ex)
            {
                MessageBox.Show("Error ao tentar excluir funcionario: " + ex.Message);
            }
            finally
            {
                //fecha a conexao 
                conexao.Close();
            }

        }

        private void AlterarFuncionario_Load(object sender, EventArgs e)
        {
            PreencherGrid();
            
            
        }  
       

        #region Botão pesquisar
        private void button2_Click_1(object sender, EventArgs e)
        {
            //Pesuqisar


            if (comboBox3.SelectedItem.ToString() == "Identicação Funcionario")
            {
                DataAdapter1 = new MySqlDataAdapter("select * from funcionario where ID_funcionario like '%" + textBox13.Text + "%'", conexao);
                atributo = "ID_funcionario";
            }
            if (comboBox3.SelectedItem.ToString() == "Nome Funcionario")
            {
                DataAdapter1 = new MySqlDataAdapter("select ID_funcionario,nome,senha from funcionario where nome like '%" + textBox13.Text + "%'", conexao);
                atributo = "nome";
            }
            if (comboBox3.SelectedItem.ToString() == "Numero Pedido")
            {
                DataAdapter1 = new MySqlDataAdapter("select * from pedido where ID_pedido like '%" + textBox13.Text + "%'", conexao);
                atributo = "ID_pedido";
            }
            if (comboBox3.SelectedItem.ToString() == "Data Atendimento")
            {
                try
                {
                     DateTime date = dateTimePicker1.Value.Date;
                sDate = date.ToString("yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
                // DateTime dateInsert = Convert.ToDateTime(sDate);
                DataAdapter1 = new MySqlDataAdapter("select funcionario.nome,pedido.* from funcionario, pedido where funcionario.ID_funcionario=pedido.ID_funcionario and data_entrada='" + sDate + "'", conexao);
                DataTable tabelaDeDados2 = new DataTable();
                DataAdapter1.Fill(tabelaDeDados2);
                dataGridView1.DataSource = tabelaDeDados2;
                
               
                    MessageBox.Show("Registro encontrado");
                
                
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Registro não encontrado" + ex.Message);
                    
                }
               
                
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
        #endregion

        //Preencher campo
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            // pega o indice da linha selecionada.
            int linhaSelec = dataGridView1.CurrentRow.Index;

            //Campo fornecedor 

            textBox1.Text = dataGridView1[0, linhaSelec].Value.ToString();
            textBox2.Text = dataGridView1[1, linhaSelec].Value.ToString();
            textBox3.Text = dataGridView1[2, linhaSelec].Value.ToString();
            //textBox4.Text = dataGridView1[4, linhaSelec].Value.ToString();
        }
        //Botão alterar funcionario
        private void button1_Click(object sender, EventArgs e)
        {

            if (validaDados())
            {
                if (MessageBox.Show("Confirma alteração? ", "Alterar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    AlterarDados();
            }
            else
            {
                MessageBox.Show("Dados do funcionario não alterados, verifique todos os campos");
            }
        }
        //Botão add funcionario
        private void button4_Click(object sender, EventArgs e)
        {
            if (validaDados())
            {
                if (MessageBox.Show("Deseja adicionar funcionario? ", "Adicionar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    SalvaDados();
            }
            else
            {
                 MessageBox.Show("Funcionario não adicionado, verifique todos os campos"); 
            }
        }
        //Botão excluir
        private void button3_Click(object sender, EventArgs e)
        {
            if (validaDados())
            {
                if (MessageBox.Show("Deseja excluir funcionario? ", "Excluir", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    ExcluirDados();
            }
            else
            {
                MessageBox.Show("Funcionario não excluido, verifique todos os campos");
            }

        }

       
    }
}
