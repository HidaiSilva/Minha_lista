using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;

namespace acessoBD_incluir
{
    public partial class Form4 : Form
    {
        public string nome, endereco, cidade, estado, cep, telefone;
        public string codigoID;

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            txtCodigo.Text = codigoID;
            txtNome.Text = nome;
            txtEndereco.Text = endereco;
            txtCidade.Text = cidade;
            txtEstado.Text = estado;
            txtCep.Text = cep;
            txtTelefone.Text = telefone;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ExcluirDados()
        {
            //define string de conexão - Provedor + fonte de dados (caminho do banco de dados e seu nome)
            string strConnection = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=c:\\dados\\Cadastro.mdb";

            //define instrução SQL para excluir dados da tabela Clientes - DELETE FROM tabela Where <criterio>
            string strSQL = "DELETE FROM clientes WHERE codigo=" + int.Parse(codigoID) +"";

            //cria a conexão com o banco de dados
            OleDbConnection dbConnection = new OleDbConnection(strConnection);
            //Cria o comando que inicia a instrução SQL para exclusão
            OleDbCommand cmdExcluir = new OleDbCommand(strSQL, dbConnection);
            try
            {
                // abre o banco de dados
                dbConnection.Open();
                // executa a instrução SQL
                cmdExcluir.ExecuteNonQuery();
                //
                MessageBox.Show("Dados Excluídos com sucesso.");
            }
            //Trata a exceção
            catch (OleDbException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                //fecha a conexao 
                dbConnection.Close();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //solicitação confirmação para excluir
            if (MessageBox.Show("Confirma exclusão? ", "Excluir", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ExcluirDados();
                this.Close();
            }
        }
    }
}
