using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace MinhaLista
{
    public partial class NovoFornecedor : Form
    {
        MySqlConnection conexao;
        
        MySqlCommand comando;
        MySqlDataAdapter DataAdapter;
        public NovoFornecedor()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TelaInicial.ActiveForm.Refresh();
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
          
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox5.Text = string.Empty;
            textBox6.Text = string.Empty;
            textBox7.Text = string.Empty;
            textBox8.Text = string.Empty;
            textBox9.Text = string.Empty;
            textBox10.Text = string.Empty;
            textBox11.Text = string.Empty;
            textBox12.Text = string.Empty;
            
            textBox14.Text = string.Empty;
            textBox15.Text = string.Empty;
            textBox16.Text = string.Empty;
            comboBox1.Text = string.Empty;
           
        }

        private void NovoFornecedor_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conexao = new MySqlConnection("server=localhost;User Id=root password=minhalista;Persist Security Info=True;database=minhalista");
            try
            {
                conexao.Open();

                if (textBox16.Text != string.Empty && textBox15.Text != string.Empty && textBox14.Text != string.Empty && textBox10.Text != string.Empty && textBox12.Text != string.Empty &&
                     textBox1.Text != string.Empty && textBox4.Text != string.Empty && textBox5.Text != string.Empty)
                {
                 //     responsavel                                       ID          Nome                   Cargo                    CPF                    Telefone                  Email
                comando = new MySqlCommand("insert into responsavel value (0,'" + textBox16.Text + "','" + textBox15.Text + "','" + textBox14.Text + "','" + textBox10.Text + "','" + textBox12.Text + "') ", conexao);
                //fazer a consulta sem retorno
                comando.ExecuteNonQuery();
 
                    //selecionar o ID do responsavel o ultimo ID
                DataAdapter = new MySqlDataAdapter ("select max(ID_Responsavel) as resp from responsavel", conexao);
                DataTable tabelaDeDados = new DataTable();
                DataAdapter.Fill(tabelaDeDados);
                string resultado = tabelaDeDados.Rows[0]["resp"].ToString();
                

                //          fornecedor                                   ID            Nome                 END                       CNPJ                 ID_R            
                comando = new MySqlCommand("insert into fornecedor value(0,'" + textBox1.Text + "','" + textBox4.Text + "','" + textBox5.Text + "'," + resultado + ")", conexao);

                //fazer a consulta sem retorno
                comando.ExecuteNonQuery();

                
                conexao.Close();
                MessageBox.Show("Cadastro realizado", "Cadastro de fornecedor", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
	             {
                    MessageBox.Show("Preencha todos os campos","Cadastro De Fornecedor",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
	              }
              

            }
            catch (MySqlException)
            {

                MessageBox.Show("Erro ao efetura o cadastro ","Cadastro De Fornecedor",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);

            }
            finally
            {
               
                button3_Click(sender, e);
            }
            
            
         
        }
    }
}
