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
        string radio;
        string recebeIDfornecedor;
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
            {
                if (textBox1.Text == recebeIDfornecedor)
                {
                    if (MessageBox.Show("Deseja fazer a alteração nos registros do fornecedor " + textBox2.Text + "? ", "Alterar Registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        AlterarDados();
                    }
                   
                }
                else
                {
                    MessageBox.Show("Verifique se os campos são correspondentes");
                    textBox2.Focus(); 
                }
                
            }
            else
            {
                MessageBox.Show("Dados Inválidos verifique os campos");
                textBox2.Focus();
            }

            return;
        }

        #region Botão pesquisar
        private void button2_Click(object sender, EventArgs e)
        {

           
            DataGridView grid2 = new DataGridView();
            DataGridView grid = new DataGridView();
            //Pesuqisar pelo fornecedor

            try
            {
                if (textBox13.Text == string.Empty)
                {
                    MessageBox.Show("Campo de pesquisa vazio ", "Pesquisar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    textBox13.Focus();
                }
                if (comboBox1.SelectedItem.ToString() == "Razão social")
                {
                    DataAdapter1 = new MySqlDataAdapter("select * from fornecedor where Nome_Fornecedor like '%" + textBox13.Text + "%'", conexao);
                    atributo = "Nome_Fornecedor"; //SELECT campos FROM tabela WHERE nome LIKE criterio
                    grid = dataGridView1;
                }
                if (comboBox1.SelectedItem.ToString() == "Endereço")
                {
                    DataAdapter1 = new MySqlDataAdapter("select * from fornecedor where Endereco like '%" + textBox13.Text + "%'", conexao);
                    atributo = "Endereco";
                    grid = dataGridView1;
                }
                if (comboBox1.SelectedItem.ToString() == "CNPJ")
                {
                    DataAdapter1 = new MySqlDataAdapter("select * from fornecedor where CNPJ like '%" + textBox13.Text + "%'", conexao);
                    atributo = "CNPJ";
                    grid = dataGridView1;
                }
                if (comboBox1.SelectedItem.ToString() == "Identicação Fornecedor")
                {
                    DataAdapter1 = new MySqlDataAdapter("select * from fornecedor where ID_fornecedor like '%" + textBox13.Text + "%'", conexao);
                    atributo = "ID_fornecedor";
                    grid = dataGridView1;
                }


                // Pesquisar pelo responsavel
                if (comboBox1.SelectedItem.ToString() == "Identicação Fornecedor")
                {
                    DataAdapter2 = new MySqlDataAdapter("select * from responsavel where ID_fornecedor like '%" + textBox13.Text + "%'", conexao);
                    atributo = "ID_fornecedor";
                    grid2 = dataGridView2;
                }
                if (comboBox1.SelectedItem.ToString() == "Identicação Responsavel")
                {
                    DataAdapter1 = new MySqlDataAdapter("select * from responsavel where ID_Responsavel like '%" + textBox13.Text + "%'", conexao);
                    atributo = "ID_responsavel";
                    grid = dataGridView2;
                }
                if (comboBox1.SelectedItem.ToString() == "Nome Responsavel")
                {
                    DataAdapter1 = new MySqlDataAdapter("select * from responsavel where Nome_Responsavel like '%" + textBox13.Text + "%'", conexao);
                    atributo = "Nome_Responsavel";
                    grid = dataGridView2;
                }
                if (comboBox1.SelectedItem.ToString() == "Cargo")
                {
                    DataAdapter1 = new MySqlDataAdapter("select * from responsavel where Cargo like '%" + textBox13.Text + "%'", conexao);
                    atributo = "Cargo";
                    grid = dataGridView2;
                }
                if (comboBox1.SelectedItem.ToString() == "CPF")
                {
                    DataAdapter1 = new MySqlDataAdapter("select * from responsavel where CPF like '%" + textBox13.Text + "%'", conexao);
                    atributo = "CPF";
                    grid = dataGridView2;
                }
                if (comboBox1.SelectedItem.ToString() == "Telefone")
                {
                    DataAdapter1 = new MySqlDataAdapter("select * from responsavel where Telefone like '%" + textBox13.Text + "%'", conexao);
                    atributo = "Telefone";
                    grid = dataGridView2;
                }

                DataTable tabelaDeDados1 = new DataTable();
                DataAdapter1.Fill(tabelaDeDados1);
                DataTable tabelaDeDados2 = new DataTable();
                DataAdapter2.Fill(tabelaDeDados2);
                try
                {
                    string resultado = tabelaDeDados1.Rows[0][atributo].ToString();

                    if (resultado != string.Empty)
                    {
                        grid.DataSource = tabelaDeDados1;
                        grid2.DataSource = tabelaDeDados2;
                        MessageBox.Show("Registro encontrado", "Pesquisa");

                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("Dados invalidos, não foi possivel encontrar esse registro ", "Pesquisar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Selecione uma opção para efetuar a pesquisa ", "Pesquisar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); 
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

            if (textBox6.Text == string.Empty)
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

            if (textBox14.Text == string.Empty)
                return false;

            if (textBox15.Text == string.Empty)
                return false;
           
            return true;
        }
        private void PreencherGrid()
        {
            conexao = new MySqlConnection("server=localhost;User Id=root;password=123456;database=minhalista");

            string srtComando1 = "select * from fornecedor";
            string srtComando2 = "select * from responsavel";
            try
            {
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
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro ao tentar preencher as células, verifique a conexão com o banco: " + ex.Message);
            }
            
            
        }
        private void AlterarDados()
        {
            //define a instrução MySQL para atualizar os dados da tabela Clientes - UPDATE tabela SET campos
            MySqlCommand cmdAlterarF = new MySqlCommand("UPDATE fornecedor SET Nome_Fornecedor ='" + textBox2.Text + "', Endereco='" + textBox4.Text + "', CNPJ='" + textBox5.Text + "', NumeroR='" + textBox6.Text + "', Bairro='" + textBox14.Text + "', Cidade='" + textBox15.Text + "' WHERE ID_Fornecedor=" + textBox1.Text + "", conexao);
            MySqlCommand cmdAlterarR = new MySqlCommand("UPDATE responsavel SET Nome_Responsavel ='" + textBox11.Text + "', Cargo='" + textBox10.Text + "', CPF='" + textBox9.Text + "', Telefone='" + textBox8.Text + "', Email='" + textBox7.Text + "' WHERE ID_responsavel=" + textBox12.Text + "", conexao);



            try
            {
                conexao.Open();
                // executa a instrução MySQL
                cmdAlterarF.ExecuteNonQuery();
                cmdAlterarR.ExecuteNonQuery();                
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
        private void ExcluirDadosR()
         {


                //define instrução MySQL para excluir dados da tabela Clientes - DELETE FROM tabela Where <criterio>
                //Tabela Filho
                MySqlCommand cmdExcluirR = new MySqlCommand("DELETE FROM responsavel WHERE ID_Responsavel=" + textBox12.Text + "", conexao);
               

                try
                {
                    // abre o banco de dados
                    conexao.Open();
                    // executa a instrução SQL
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
        private void ExcluirDadosRF()
        {


            //define instrução MySQL para excluir dados da tabela Clientes - DELETE FROM tabela Where <criterio>
            //Tabela Filho
            MySqlCommand cmdExcluirR = new MySqlCommand("DELETE FROM responsavel WHERE ID_responsavel=" + textBox12.Text + "", conexao);
            //Tabela Pai
            MySqlCommand cmdExcluirF = new MySqlCommand("DELETE FROM fornecedor WHERE ID_fornecedor=" + textBox1.Text + "", conexao);

            try
            {
                // abre o banco de dados
                conexao.Open();
                // executa a instrução SQL
                cmdExcluirR.ExecuteNonQuery();
                cmdExcluirF.ExecuteNonQuery();
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
        private void SalvaDadosFR()
        {
           

            //define instrução MySQL para incluir dados na tabela CLientes - INSERT INTO tabela VALUES (campos)

            MySqlCommand cmdIncluirF = new MySqlCommand("INSERT INTO fornecedor VALUES(0,'" + textBox2.Text + "','" + textBox4.Text + "','" + textBox5.Text + "'," + textBox6.Text + ",'" + textBox14.Text + "','" + textBox15.Text + "')", conexao);
            
            //selecionar o ID do responsavel o ultimo ID
            DataAdapter1 = new MySqlDataAdapter("select max(ID_fornecedor) as resp from fornecedor", conexao);
            DataTable tabelaDeDados = new DataTable();
            DataAdapter1.Fill(tabelaDeDados);
            string resultado = tabelaDeDados.Rows[0]["resp"].ToString();

            MySqlCommand cmdIncluirR = new MySqlCommand("INSERT INTO responsavel VALUES(0,'" + textBox11.Text + "','" + textBox10.Text + "','" + textBox9.Text + "','" + textBox8.Text + "','" + textBox7.Text + "'," + resultado + " )", conexao);
           

            
            try
            {
                // abre o banco
                conexao.Open();
                // executa a query
                cmdIncluirF.ExecuteNonQuery();
                cmdIncluirR.ExecuteNonQuery();
                //
                MessageBox.Show("Dados Salvos com sucesso.");
                PreencherGrid();
                if (MessageBox.Show("Deseja adicionar itens ao novo fornecedor agora? ", "Novo Fornecedor", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Item it = new Item();
                    it.ShowDialog();
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
        private void SalvaDadosR()
        {
            //selecionar o ID do responsavel o ultimo ID
            DataAdapter1 = new MySqlDataAdapter("select ID_fornecedor from fornecedor where ID_fornecedor="+ textBox1.Text +" ", conexao);
            DataTable tabelaDeDados = new DataTable();
            DataAdapter1.Fill(tabelaDeDados);
            string resultado = tabelaDeDados.Rows[0]["ID_fornecedor"].ToString();

            MySqlCommand cmdIncluirR = new MySqlCommand("INSERT INTO responsavel VALUES(0,'" + textBox11.Text + "','" + textBox10.Text + "','" + textBox9.Text + "','" + textBox8.Text + "','" + textBox7.Text + "'," + resultado + " )", conexao);

            try
            {
                // abre o banco
                conexao.Open();
                // executa a query
                cmdIncluirR.ExecuteNonQuery();
                //
                MessageBox.Show("Responsavel "+ textBox11.Text + " foi vinculado com sucesso ao fornecedor " + textBox2.Text +" ");
                PreencherGrid();
                
            }
            //Trata a exceção
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro ao tentar adicionar um novo responsavel: " + ex.Message);
            }
            finally
            {
                //fecha a conexao 
                conexao.Close();
            }
        }
        private Boolean AutenticarFornecedor()
        {
            conexao.Open();
            DataAdapter1 = new MySqlDataAdapter("select * from fornecedor where Nome_Fornecedor = '" + textBox2.Text + "'", conexao);
            DataTable tabelaDeDados1 = new DataTable();
            DataAdapter1.Fill(tabelaDeDados1);
            try
            {
                string resultado = tabelaDeDados1.Rows[0]["Nome_Fornecedor"].ToString();

                if (resultado != string.Empty)

                    return true;

                else
                    return false;
            }
            catch
            {
                
                return false;

            }
            finally
            {
                conexao.Close();
            }
           
        }
        private Boolean AutenticarResponsavel()
        {
            DataAdapter1 = new MySqlDataAdapter("select * from responsavel where Nome_Responsavel='" + textBox11.Text + "'", conexao);
            DataTable tabelaDeDados1 = new DataTable();
            DataAdapter1.Fill(tabelaDeDados1);
            try
            {
                string resultado = tabelaDeDados1.Rows[0]["Nome_Responsavel"].ToString();

                if (resultado != string.Empty)

                    return true;

                else
                    return false;
            }
            catch
            {
               
                return false;

            }
        }

        //Botão Excluir Dados 
        private void button3_Click(object sender, EventArgs e)
        {

            SelecionarExclusao se = new SelecionarExclusao();
            se.ShowDialog();
            radio = se.radio;

            if (radio == "er")
            {
                //solicitação confirmação para excluir do responsavel
                if (MessageBox.Show("Confirma exclusão do responsavel? ", "Excluir", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    ExcluirDadosR();
                }

            }
            if (radio == "erf")
            {
                //solicitação confirmação para excluir do responsavel e fornecedor
                if (MessageBox.Show("Confirma exclusão do fornecedor e responsavel? ", "Excluir", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    ExcluirDadosRF();
                }
            }

            
        }

        //Botão add Fornecedor/Responsavel 
        private void button4_Click(object sender, EventArgs e)
        {    //validar campos 
            if (validaDados())
            {     
                //verifica se existe fornecedor e responsavel no banco
                if (AutenticarFornecedor() && AutenticarResponsavel())
                {
                    MessageBox.Show("Os dados ja estão cadastrados no banco", "Adicionar registro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);            
                }
                else 
                {   //Se responsavel não existe no banco.. 
                    if (AutenticarFornecedor() && AutenticarResponsavel() == false)
                    {
                        if (MessageBox.Show("Deseja cadastrar um novo resposavel no fornecedor " + textBox2.Text +"? ", "Adicionar Responsavel", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            SalvaDadosR();
                        }
                    }
                    else
                    {
                        if (MessageBox.Show("Dados ainda não existentes, Deseja adicionar novo fornecedor e responsavel no banco? ", "Adicionar registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            SalvaDadosFR();
                        }

                      
                    }
                    
                    
                }
                
                
              
                
            }
            else
            {
                MessageBox.Show("Preencha todos os campos.");
            }
            return;
        }
        //Preencher campos fornecedor 
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                // pega o indice da linha selecionada.
                int linhaSelec = dataGridView1.CurrentRow.Index;
           
                //Campo fornecedor 

                textBox1.Text = dataGridView1[0, linhaSelec].Value.ToString();
                textBox2.Text = dataGridView1[1, linhaSelec].Value.ToString();
                textBox3.Text = dataGridView1[1, linhaSelec].Value.ToString();
                textBox4.Text = dataGridView1[2, linhaSelec].Value.ToString();
                textBox5.Text = dataGridView1[3, linhaSelec].Value.ToString();
                textBox6.Text = dataGridView1[4, linhaSelec].Value.ToString();
                textBox14.Text = dataGridView1[5, linhaSelec].Value.ToString();
                textBox15.Text = dataGridView1[6, linhaSelec].Value.ToString();


            }
            catch (Exception)
            {

                MessageBox.Show("Atenção sequencia das células motificada");
            }        

            
           
         }
        //Preencher campos responsavel 
        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            try
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
                recebeIDfornecedor = dataGridView2[6, linhaSelec2].Value.ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("Atenção sequencia das células motificada");
            }
           
        }
    }
}
