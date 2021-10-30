using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;

namespace acessoBD_incluir
{
    public partial class Form3 : Form
    {
        public string nome, endereco, cidade, estado, cep, telefone;
        public string codigoID;

        public Form3()
        {
            InitializeComponent();
        }
        private void Form3_Load(object sender, EventArgs e)
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

        private void AlterarDados()
        {
            //define string de conexão - Provedor + fonte de dados (caminho do banco de dados e seu nome)
            string strConnection = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=c:\\dados\\Cadastro.mdb";

            //define a instrução SQL para atualizar os dados da tabela Clientes - UPDATE tabela SET campos
            string strSQL = "UPDATE Clientes SET nome ='" + txtNome.Text.Replace("'", "''") + "', endereco='" + txtEndereco.Text + "', cidade='" + txtCidade.Text + "', estado='" + txtEstado.Text + "', cep='" + txtCep.Text + "', telefone='" + txtTelefone.Text + "' WHERE codigo=" + int.Parse(codigoID) + "";

            //cria a conexão com o banco de dados
            OleDbConnection dbConnection = new OleDbConnection(strConnection);
            //Cria o comando que inicia a instrução SQL para alteração
            OleDbCommand cmdAlterar = new OleDbCommand(strSQL, dbConnection);
            try
            {
                // abre o banco de dados
                dbConnection.Open();
                // executa a instrução SQL
                cmdAlterar.ExecuteNonQuery();
                //
                MessageBox.Show("Dados Alterados com sucesso.");
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
        private Boolean validaDados()
        {
            if (txtNome.Text == string.Empty)
                return false;

            if (txtEndereco.Text == string.Empty)
                return false;

            if (txtCidade.Text == string.Empty)
                return false;

            if (txtEstado.Text == string.Empty)
                return false;

            if (txtCep.Text == string.Empty)
                return false;

            return true;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (validaDados())
                AlterarDados();
            else
                MessageBox.Show("Dados Inválidos...");
                txtNome.Focus();

            return;
        }

       
    }
}
