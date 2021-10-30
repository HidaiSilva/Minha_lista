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
    public partial class Login : Form
    {
        MySqlConnection conexao;
        MySqlDataAdapter DataAdapter1;
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection("server=localhost;User Id=root;password=123456;database=minhalista");
                conexao.Open();

                if (textBox1.Text == string.Empty)
                {
                    MessageBox.Show("Preencha os campos","Minha Lista",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                }
                else
                {
                    DataAdapter1 = new MySqlDataAdapter("select * from funcionario where Email = '" + textBox1.Text + "'", conexao);
                    DataTable tabelaDeDados = new DataTable();
                    DataAdapter1.Fill(tabelaDeDados);

                    string resultado = tabelaDeDados.Rows[0]["Email"].ToString();
                    string resultado2 = tabelaDeDados.Rows[0]["Senha"].ToString();
                    string resultado3 = tabelaDeDados.Rows[0]["Nome_Funcionario"].ToString();
                   if(textBox1.Text ==  resultado && textBox2.Text == resultado2)
                    {
                        MinhaLista tl = new MinhaLista();
                        tl.Show();
                        MessageBox.Show("Bem vindo "+ resultado3 +"", "Login autenticado", MessageBoxButtons.OK);
                        conexao.Close();
                        this.Visible = false;
                    }
                }
               
            }
            catch (Exception)
            {

                MessageBox.Show("Usuário ou Senha incorretos", "Login não autenticado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }
    }
}
