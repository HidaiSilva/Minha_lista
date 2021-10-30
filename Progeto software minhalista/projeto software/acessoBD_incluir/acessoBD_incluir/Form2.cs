using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;

namespace acessoBD_incluir
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            txtNome.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (validaDados())
                SalvaDados();
            else
                MessageBox.Show("Dados Inválidos...");
                txtNome.Focus();
                return;
        }
        private void SalvaDados()
        {
            //define string de conexão - Provedor + fonte de dados (caminho do banco de dados e seu nome)
            string strConnection = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=c:\\dados\\Cadastro.mdb";

            //define instrução SQL para incluir dados na tabela CLientes - INSERT INTO tabela VALUES (campos)
            string strSQL = "INSERT INTO Clientes(nome,endereco,cidade,estado,cep,telefone)"
            + " VALUES ('" + txtNome.Text + "','" + txtEndereco.Text + "','" + txtCidade.Text + "','" + txtEstado.Text + "','" + txtCep.Text + "','" + txtTelefone.Text + "')";

            //cria a conexão com o banco de dados
            OleDbConnection dbConnection = new OleDbConnection(strConnection);
            // executa a instrução SQL para incluir dados
            OleDbCommand cmdIncluir = new OleDbCommand(strSQL, dbConnection);
            try
            {
                // abre o banco
                dbConnection.Open();
                // executa a query
                cmdIncluir.ExecuteNonQuery();
                //
                MessageBox.Show("Dados Salvos com sucesso.");
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

    }
}
