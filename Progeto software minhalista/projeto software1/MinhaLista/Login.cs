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
                conexao = new MySqlConnection("server=localhost;User Id=root;password=ALUNOS;database=minha_lista");
                conexao.Open();

                if (textBox1.Text == string.Empty)
                {
                    MessageBox.Show("Preencha os campos","Minha Lista",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                }
                else
                {
                    DataAdapter1 = new MySqlDataAdapter("select * from funcionario where nome = '" + textBox1.Text + "'", conexao);
                    DataTable tabelaDeDados = new DataTable();
                    DataAdapter1.Fill(tabelaDeDados);

                    string resultado = tabelaDeDados.Rows[0]["nome"].ToString();
                    
                   if(textBox1.Text ==  resultado)
                    {
                        TelaInicial tl = new TelaInicial();
                        tl.Show();
                        MessageBox.Show("ok", "Login autenticado", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
