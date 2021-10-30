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
            

            PictureBox imgPhoto = new PictureBox();
            OpenFileDialog dlg = new OpenFileDialog () ;

            /*dlg.Title = "Open Image" ;
            dlg.Filter = "jpg files (*.jpg)|*.jpg|All files (*.*)|*.*" ;

            if ( dlg.ShowDialog () == DialogResult.OK )
            {
            imgPhoto.Image = new Bitmap ( dlg.OpenFile ()) ;
            pictureBox1.Image = imgPhoto.Image;
            }

            dlg.Dispose () ;*/

            
            //pictureBox1.Image = Image.FromFile(@"F:\MinhaLista2\Imagens\login.jpg");
            //Image imagem = Image.FromFile("F:\\MinhaLista2\\Imagens\\login.jpg");
            //pictureBox1.Image = imagem;
            
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            string srtComando1 = " select * from categoria where Tipo_Categoria='" + comboBox4.Text + "'";

            DataAdapter1 = new MySqlDataAdapter(srtComando1, conexao);
            DataTable tabelaDeDados1 = new DataTable();
            DataAdapter1.Fill(tabelaDeDados1);

            if (comboBox4.Text != "System.Data.DataRowView")
            {

                textBox3.Text = tabelaDeDados1.Rows[0]["ID_Categoria"].ToString();

            }
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

            if (textBox5.Text == string.Empty)
                return false;
            return true;
        }

        private void PreencherGrid()
        {
            conexao = new MySqlConnection("server=localhost;User Id=root;password=123456;database=minhalista");

            string srtComando1 = "select * from produto";

            DataAdapter1 = new MySqlDataAdapter(srtComando1, conexao);
            DataTable tabelaDeDados1 = new DataTable();
            DataAdapter1.Fill(tabelaDeDados1);
            dataGridView1.DataSource = tabelaDeDados1;
            dataGridView1.RowHeadersVisible = false;

            
        }
        //Preencher combobox categoria
        private void PreencherComboBox()
        {
            
            //Preencher combobox categoria
            DataAdapter1 = new MySqlDataAdapter("select * from categoria", conexao);
            DataTable tabelaDeDados2 = new DataTable();
            DataAdapter1.Fill(tabelaDeDados2);
           
            comboBox4.DataSource = tabelaDeDados2;
            comboBox4.DisplayMember = "Tipo_Categoria";

           
        }
        //Alterar produto
        private void AlterarDados()
        {
            //define a instrução MySQL para atualizar os dados da tabela produto - UPDATE tabela SET campos
            MySqlCommand cmdAlterarP = new MySqlCommand("UPDATE produto SET Nome_Produto ='" + textBox1.Text + "', Marca='" + textBox2.Text + "', Imagem='" + textBox5.Text + "' WHERE ID_produto=" + textBox4.Text + "", conexao);
            
            try
            {
                conexao.Open();
                // executa a instrução MySQL
                cmdAlterarP.ExecuteNonQuery();
               
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
            MySqlCommand cmdExcluirP = new MySqlCommand("DELETE FROM produto WHERE ID_Produto=" + textBox4.Text + "", conexao);
            //MySqlCommand cmdExcluirC = new MySqlCommand("DELETE FROM categoria WHERE ID_produto=" + textBox4.Text + "", conexao);

            try
            {
                // abre o banco de dados
                conexao.Open();
                // executa a instrução MySQL
                cmdExcluirP.ExecuteNonQuery();
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
        
        //Botão Pesquisar 
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
                //enviar pra o intem
                if (comboBox3.SelectedItem.ToString() == "Identificação Fornecedor")
                {
                    DataAdapter1 = new MySqlDataAdapter("select fornecedor.ID_fornecedor,fornecedor.Nome_Fornecedor,produto.* from produto,fornecedor where produto.ID_fornecedor=fornecedor.ID_fornecedor and fornecedor.ID_fornecedor like '%" + textBox13.Text + "%'", conexao);
                    DataTable tabelaDeDados2 = new DataTable();
                    DataAdapter1.Fill(tabelaDeDados2);
                    dataGridView1.DataSource = tabelaDeDados2;
                    MessageBox.Show("Registro encontrado");
                    return;
                }

                //SAir ...enviar para item 
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
                {      //Chamar o TIPO da categoria OK 
                    DataAdapter1 = new MySqlDataAdapter("select produto.*,categoria.Tipo_Categoria from categoria,produto where categoria.ID_categoria=produto.ID_categoria and Tipo_Categoria like '%" + textBox13.Text + "%'", conexao);
                    // verificar a tabela atribuida 
                    atributo = "Tipo_Categoria";
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
        //Novo produto
        private void SalvaDados()
        {


            //define instrução MySQL para incluir dados na tabela CLientes - INSERT INTO tabela VALUES (campos)
            //                                                                              nome produto              marca                   imagem                 id categoria 
            MySqlCommand cmdIncluirP = new MySqlCommand("INSERT INTO produto VALUES(0,'" + textBox1.Text + "','" + textBox2.Text + "','" + textBox5.Text + "','" + textBox3.Text + "')", conexao);
            
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
                cmdIncluirP.ExecuteNonQuery();
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
        //Autenticar Verificar se existe produto
        private Boolean AutenticarProduto()
        {
            DataAdapter1 = new MySqlDataAdapter("select * from produto where Nome_Produto='" + textBox1.Text + "'", conexao);
            DataTable tabelaDeDados1 = new DataTable();
            DataAdapter1.Fill(tabelaDeDados1);
            try
            {
                string resultado = tabelaDeDados1.Rows[0]["Nome_Produto"].ToString();

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

        //Botão ADD produto
        private void button4_Click(object sender, EventArgs e)
        {
            if (validaDados())
            {
                if (AutenticarProduto())
                {
                    MessageBox.Show("O produto " + textBox1.Text + " ja esta cadastrado no banco", "Adicionar Produto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else 
                { 
                    if (MessageBox.Show("Deseja adicionar um novo produto? ", "Adicionar Produto", MessageBoxButtons.YesNo) == DialogResult.Yes)
                   {
                    
                    SalvaDados();

                   }

                }
                
                
                         
                
            }
            else
            {
                MessageBox.Show("Produto não adicionado verifique todos os campos");
            }
        }
        //Botão Alterar produto
        private void button1_Click(object sender, EventArgs e)
        {
            DataAdapter1 = new MySqlDataAdapter("select * from produto where ID_Produto= '" + textBox4.Text + "'", conexao);
            DataTable tabelaDeDados2 = new DataTable();
            DataAdapter1.Fill(tabelaDeDados2);
            
            string resultado = tabelaDeDados2.Rows[0]["Nome_Produto"].ToString();

            if (validaDados())
            {
                if (MessageBox.Show("Deseja fazer a alteração nos dados do produto " + resultado + "? ", "Alterar Produto", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    AlterarDados();
                }
            }
            else
            {
                MessageBox.Show("Produto não alterado verifique todos os campos");
            }
        }
        //Preencher campos textebox do produto
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                // pega o indice da linha selecionada.
                int linhaSelec = dataGridView1.CurrentRow.Index;

                //Campo fornecedor 

                textBox1.Text = dataGridView1[1, linhaSelec].Value.ToString();
                textBox2.Text = dataGridView1[2, linhaSelec].Value.ToString();
                textBox3.Text = dataGridView1[4, linhaSelec].Value.ToString();
                textBox5.Text = dataGridView1[3, linhaSelec].Value.ToString();
                textBox4.Text = dataGridView1[0, linhaSelec].Value.ToString();

                //pictureBox1.Image = new Bitmap(@"F:\projeto software\MinhaLista2\Imagens\Inverno.jpg");
                //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

                try
                {
                    pictureBox1.Image = new Bitmap(@"" + textBox5.Text + "");
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;



                }
                catch (Exception)
                {
                    if (textBox4.Text != string.Empty)
                    {
                        //Variavel recebe likn para preencher campos sem imagens
                        string imgReserva = @"F:\\projeto software\\MinhaLista2\\Imagens\\login.bmp";
                        MySqlCommand cmdAlterarP = new MySqlCommand("UPDATE produto SET Imagem='" + imgReserva + "' WHERE ID_produto=" + textBox4.Text + "", conexao);

                        conexao.Open();
                        // executa a instrução MySQL
                        cmdAlterarP.ExecuteNonQuery();
                        textBox5.Focus();
                        MessageBox.Show("Imagem padrão adicionada ao produto" + textBox1.Text + ".");

                        PreencherGrid();
                        linhaSelec = 0;
                        conexao.Close();

                    }
                    else
                    {
                        return;
                    }

                }
            }
            catch
            {

            }
        }
       
        //Botão Excluir produto
        private void button3_Click(object sender, EventArgs e)
        {
            DataAdapter1 = new MySqlDataAdapter("select * from produto where ID_Produto= '" + textBox4.Text + "'", conexao);
            DataTable tabelaDeDados2 = new DataTable();
            DataAdapter1.Fill(tabelaDeDados2);
            string resultado2 = tabelaDeDados2.Rows[0]["Nome_Produto"].ToString();

            //solicitação confirmação para excluir
            if (validaDados())
            {
                if (MessageBox.Show("Deseja excluir o produto "+ resultado2 +"? ", "Excluir Produto", MessageBoxButtons.YesNo) == DialogResult.Yes)
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
