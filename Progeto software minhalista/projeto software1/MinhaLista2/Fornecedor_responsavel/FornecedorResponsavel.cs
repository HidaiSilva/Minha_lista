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
    public partial class FornecedorResponsavel : Form
    {
        MySqlConnection conexao;
        MySqlDataAdapter DataAdapter1;
        MySqlDataAdapter DataAdapter2;
        
        string atributo = "";
        
        public FornecedorResponsavel()
        {
            InitializeComponent();


        }
        #region preencher grid
        private void AlterarFornecedorResponsavel_Load(object sender, EventArgs e)
        {
            PreencherGrid();

            
        }
#endregion

        //Boatão Alterar Dados
        private void button1_Click(object sender, EventArgs e)
        {
            if (validaDados())
                AlterarDados();
            else
                MessageBox.Show("Dados Inválidos verifique os campos");
            textBox2.Focus(); 

            return;
        }

        #region Botão pesquisar
        private void button2_Click(object sender, EventArgs e)
        {
            //Pesuqisar

            
                 if (comboBox1.SelectedItem.ToString() == "Razão social")
                 {
                     DataAdapter1 = new MySqlDataAdapter("select * from fornecedor where Nome_Fornecedor like '%"+textBox13.Text+"%'", conexao);
                     atributo = "Nome_Fornecedor"; //SELECT campos FROM tabela WHERE nome LIKE criterio
                 }
                if (comboBox1.SelectedItem.ToString() == "Endereço")
                 {
                     DataAdapter1 = new MySqlDataAdapter("select * from fornecedor where Endereco like '%" + textBox13.Text + "%'", conexao);
                     atributo = "Endereco";
                 }
                if (comboBox1.SelectedItem.ToString() == "CNPJ")
                 {
                     DataAdapter1 = new MySqlDataAdapter("select * from fornecedor where CNPJ like '%" + textBox13.Text + "%'", conexao);
                     atributo = "CNPJ";
                 }
                if (comboBox1.SelectedItem.ToString() == "Identicação Fornecedor")
                 {
                     DataAdapter1 = new MySqlDataAdapter("select * from fornecedor where ID_fornecedor like '%" + textBox13.Text + "%'", conexao);
                     atributo = "ID_fornecedor";
                 }
                if (comboBox1.SelectedItem.ToString() == "Identicação Responsavel")
                 {
                     DataAdapter1 = new MySqlDataAdapter("select * from fornecedor where ID_Responsavel like '%" + textBox13.Text + "%'", conexao);
                     atributo = "ID_Responsavel";
                 }

                DataTable tabelaDeDados1 = new DataTable();
                DataAdapter1.Fill(tabelaDeDados1);

                string resultado = tabelaDeDados1.Rows[0][atributo].ToString();
                
                if (resultado != string.Empty )
	           {
		           dataGridView1.DataSource = tabelaDeDados1;
                   MessageBox.Show("Registro encontrado");

	           }
                
	 
	        

        }
        #endregion
        //nada
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //dataGridView1.ColumnHeaderMouseDoubleClick
        }
        //nada
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {            
          
        }

        #region Preencher os textbox fornecedor
        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            /*/fornecedor
            string srtComando1 = "select * from fornecedor";


            DataAdapter1 = new MySqlDataAdapter(srtComando1, conexao);
            DataTable tabelaDeDados1 = new DataTable();
            DataAdapter1.Fill(tabelaDeDados1);*/

            
            /*/Campo fornecedor 
            textBox1.Text = tabelaDeDados1.Rows[e.RowIndex]["ID_fornecedor"].ToString();
            textBox2.Text = tabelaDeDados1.Rows[e.RowIndex]["Nome_Fornecedor"].ToString();
            textBox3.Text = tabelaDeDados1.Rows[e.RowIndex]["Nome_Fornecedor"].ToString();
            textBox4.Text = tabelaDeDados1.Rows[e.RowIndex]["Endereco"].ToString();
            textBox5.Text = tabelaDeDados1.Rows[e.RowIndex]["CNPJ"].ToString();
            textBox12.Text = tabelaDeDados1.Rows[e.RowIndex]["ID_Responsavel"].ToString();

            //Responsavel
            string srtComando2 = "select * from responsavel";


            DataAdapter2 = new MySqlDataAdapter(srtComando2, conexao);
            DataTable tabelaDeDados2 = new DataTable();
            DataAdapter2.Fill(tabelaDeDados2);
            //Campo Responsavel
            textBox11.Text = tabelaDeDados2.Rows[e.RowIndex]["Nome"].ToString();
            textBox10.Text = tabelaDeDados2.Rows[e.RowIndex]["Cargo"].ToString();
            textBox9.Text = tabelaDeDados2.Rows[e.RowIndex]["CPF"].ToString();
            textBox8.Text = tabelaDeDados2.Rows[e.RowIndex]["Telefone"].ToString();
            textBox7.Text = tabelaDeDados2.Rows[e.RowIndex]["Email"].ToString();
            textBox12.Text = tabelaDeDados2.Rows[e.RowIndex]["ID_Responsavel"].ToString();
           
            /*System.Text.StringBuilder messageBoxCS = new System.Text.StringBuilder();
            messageBoxCS.AppendFormat("{0} = {1}", "ColumnIndex", e.ColumnIndex);
            messageBoxCS.AppendLine();
            messageBoxCS.AppendFormat("{0} = {1}", "RowIndex", e.RowIndex);
            messageBoxCS.AppendLine();
            messageBoxCS.AppendFormat("{0} = {1}", "Button", e.Button);
            messageBoxCS.AppendLine();
            messageBoxCS.AppendFormat("{0} = {1}", "Clicks", e.Clicks);
            messageBoxCS.AppendLine();
            messageBoxCS.AppendFormat("{0} = {1}", "X", e.X);
            messageBoxCS.AppendLine();
            messageBoxCS.AppendFormat("{0} = {1}", "Y", e.Y);
            messageBoxCS.AppendLine();
            messageBoxCS.AppendFormat("{0} = {1}", "Delta", e.Delta);
            messageBoxCS.AppendLine();
            messageBoxCS.AppendFormat("{0} = {1}", "Location", e.Location);
            messageBoxCS.AppendLine();
            MessageBox.Show(messageBoxCS.ToString(), "CellMouseDoubleClick Event");*/
        }
        #endregion

        #region Preencher os textbox responsavel
        private void dataGridView2_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            /*/Pesquisar Responsavel
            string srtComando2 = "select * from responsavel";


            DataAdapter2 = new MySqlDataAdapter(srtComando2, conexao);
            DataTable tabelaDeDados2 = new DataTable();
            DataAdapter2.Fill(tabelaDeDados2);
            //Preencher Campo Responsavel
            textBox11.Text = tabelaDeDados2.Rows[e.RowIndex]["Nome"].ToString();
            textBox10.Text = tabelaDeDados2.Rows[e.RowIndex]["Cargo"].ToString();
            textBox9.Text = tabelaDeDados2.Rows[e.RowIndex]["CPF"].ToString();
            textBox8.Text = tabelaDeDados2.Rows[e.RowIndex]["Telefone"].ToString();
            textBox7.Text = tabelaDeDados2.Rows[e.RowIndex]["Email"].ToString();
            textBox12.Text = tabelaDeDados2.Rows[e.RowIndex]["ID_Responsavel"].ToString();
            
            //Pesquisar fornecedor
            string srtComando1 = "select * from fornecedor";


            DataAdapter1 = new MySqlDataAdapter(srtComando1, conexao);
            DataTable tabelaDeDados1 = new DataTable();
            DataAdapter1.Fill(tabelaDeDados1);

            //Preencher Campo fornecedor 
            textBox1.Text = tabelaDeDados1.Rows[e.RowIndex]["ID_Fornecedor"].ToString();
            textBox2.Text = tabelaDeDados1.Rows[e.RowIndex]["Nome"].ToString();
            textBox3.Text = tabelaDeDados1.Rows[e.RowIndex]["Nome"].ToString();
            textBox4.Text = tabelaDeDados1.Rows[e.RowIndex]["Endereco"].ToString();
            textBox5.Text = tabelaDeDados1.Rows[e.RowIndex]["CNPJ"].ToString();
            textBox12.Text = tabelaDeDados1.Rows[e.RowIndex]["ID_Responsavel"].ToString();*/
        }
        #endregion

        private Boolean validaDados()
        {
            if (textBox2.Text == string.Empty)
                return false;

            /*if (textBox3.Text == string.Empty)
                return false;*/

            if (textBox4.Text == string.Empty)
                return false;

            if (textBox5.Text == string.Empty)
                return false;

            if (textBox7.Text == string.Empty)
                return false;

            if (textBox8.Text == string.Empty)
                return false;

            if (textBox9.Text == string.Empty)
                return false;

            if (textBox10.Text == string.Empty)
                return false;

            if (textBox11.Text == string.Empty)
                return false;

           
            return true;
        }
        private void PreencherGrid()
        {
            conexao = new MySqlConnection("server=localhost;User Id=root;password=anderson;database=minhalista");

            string srtComando1 = "select * from fornecedor";
            string srtComando2 = "select * from responsavel";

            DataAdapter1 = new MySqlDataAdapter(srtComando1, conexao);
            DataTable tabelaDeDados1 = new DataTable();
            DataAdapter1.Fill(tabelaDeDados1);
            dataGridView1.DataSource = tabelaDeDados1;
            dataGridView1.RowHeadersVisible = false;

            DataAdapter2 = new MySqlDataAdapter(srtComando2, conexao);
            DataTable tabelaDeDados2 = new DataTable();
            DataAdapter2.Fill(tabelaDeDados2);
            dataGridView2.DataSource = tabelaDeDados2;
        }
        private void AlterarDados()
        {
            //define a instrução MySQL para atualizar os dados da tabela Clientes - UPDATE tabela SET campos
            MySqlCommand cmdAlterarF = new MySqlCommand("UPDATE fornecedor SET Nome_Fornecedor ='" + textBox2.Text + "', Endereco='" + textBox4.Text + "', CNPJ='" + textBox5.Text + "' WHERE ID_Fornecedor=" + textBox1.Text + "", conexao);
            MySqlCommand cmdAlterarR = new MySqlCommand("UPDATE responsavel SET Nome ='" + textBox11.Text + "', Cargo='" + textBox10.Text + "', CPF='" + textBox9.Text + "', Telefone='" + textBox8.Text + "', Email='" + textBox7.Text + "' WHERE ID_responsavel=" + textBox12.Text + "", conexao);



            try
            {
                conexao.Open();
                // executa a instrução MySQL
                cmdAlterarR.ExecuteNonQuery();
                cmdAlterarF.ExecuteNonQuery();
                //
                MessageBox.Show("Dados Alterados com sucesso.");
                PreencherGrid();
                
            }
            //Trata a exceção
            catch (MySqlException ex)
            {
                MessageBox.Show("Error ao alterar o fornecedor: " + ex.Message);
            }
            finally
            {
                //fecha a conexao 
                conexao.Close();
            }
        }
        private void ExcluirDados()
         {


                //define instrução MySQL para excluir dados da tabela Clientes - DELETE FROM tabela Where <criterio>
                //Tabela Pai
                MySqlCommand cmdExcluirR = new MySqlCommand("DELETE FROM responsavel WHERE ID_Responsavel=" + textBox12.Text + "", conexao);
                //Tabela Filho
                MySqlCommand cmdExcluirF = new MySqlCommand("DELETE FROM fornecedor WHERE ID_fornecedor=" + textBox1.Text + "", conexao); 

                try
                {
                    // abre o banco de dados
                    conexao.Open();
                    // executa a instrução SQL
                    cmdExcluirF.ExecuteNonQuery();
                    cmdExcluirR.ExecuteNonQuery();
                    //
                    MessageBox.Show("Dados Excluídos com sucesso.");
                    PreencherGrid();
                }
                //Trata a exceção
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error ao tentar excluir: " + ex.Message);
                }
                finally
                {
                    //fecha a conexao 
                    conexao.Close();
                }
            
        }
        private void SalvaDados()
        {
           

            //define instrução MySQL para incluir dados na tabela CLientes - INSERT INTO tabela VALUES (campos)

            MySqlCommand cmdIncluirR = new MySqlCommand("INSERT INTO responsavel VALUES(0,'"+ textBox11.Text + "','" + textBox10.Text + "','" + textBox9.Text + "','" + textBox8.Text + "','" + textBox7.Text + "')", conexao);

            //selecionar o ID do responsavel o ultimo ID
            DataAdapter1 = new MySqlDataAdapter("select max(ID_Responsavel) as resp from responsavel", conexao);
            DataTable tabelaDeDados = new DataTable();
            DataAdapter1.Fill(tabelaDeDados);
            string resultado = tabelaDeDados.Rows[0]["resp"].ToString();

            MySqlCommand cmdIncluirF = new MySqlCommand("INSERT INTO fornecedor VALUES(0,'" + textBox2.Text + "','" + textBox4.Text + "','" + textBox5.Text + "'," + resultado + ",'sao jose do campos','satelite',1234)", conexao);

            
            try
            {
                // abre o banco
                conexao.Open();
                // executa a query
                cmdIncluirR.ExecuteNonQuery();
                cmdIncluirF.ExecuteNonQuery();
                //
                MessageBox.Show("Dados Salvos com sucesso.");
                PreencherGrid();
                if (MessageBox.Show("Deseja adicionar produtos ao novo fornecedor agora? ", "Excluir", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Produto altprod = new Produto();
                    altprod.ShowDialog();
                }
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

        //Botão Excluir Dados 
        private void button3_Click(object sender, EventArgs e)
        {
            //solicitação confirmação para excluir
            if (MessageBox.Show("Confirma exclusão? ", "Excluir", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ExcluirDados();
                

            }
        }

        //Botão add Fornecedor/Responsavel 
        private void button4_Click(object sender, EventArgs e)
        {
            if (validaDados())
            {
                SalvaDados();
                
            }
            else
            {
                MessageBox.Show("Dados Inválidos...");
            }
            return;
        }
        //Preencher campos fornecedor B
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            

            // pega o indice da linha selecionada.
            int linhaSelec = dataGridView1.CurrentRow.Index;
           
            //Campo fornecedor 

            textBox1.Text = dataGridView1[0, linhaSelec].Value.ToString();
            textBox2.Text = dataGridView1[1, linhaSelec].Value.ToString();
            textBox3.Text = dataGridView1[1, linhaSelec].Value.ToString();
            textBox4.Text = dataGridView1[2, linhaSelec].Value.ToString();
            textBox5.Text = dataGridView1[3, linhaSelec].Value.ToString();
            textBox12.Text = dataGridView1[4, linhaSelec].Value.ToString();

           
         }
        //Preencher campos responsavel B 
        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            // pega o indice da linha selecionada.
            int linhaSelec2 = dataGridView2.CurrentRow.Index;

            //Preencher Campo Responsavel
            textBox12.Text = dataGridView2[0, linhaSelec2].Value.ToString();
            textBox11.Text = dataGridView2[1, linhaSelec2].Value.ToString();
            textBox10.Text = dataGridView2[2, linhaSelec2].Value.ToString();
            textBox9.Text = dataGridView2[3, linhaSelec2].Value.ToString();
            textBox8.Text = dataGridView2[4, linhaSelec2].Value.ToString();
            textBox7.Text = dataGridView2[5, linhaSelec2].Value.ToString();
        }
    }
}
