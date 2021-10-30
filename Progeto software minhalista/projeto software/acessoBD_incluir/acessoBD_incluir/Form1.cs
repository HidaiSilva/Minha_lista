using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;

namespace acessoBD_incluir
{
    public partial class Form1 : Form
    {
        private OleDbConnection Conn;
        private OleDbDataAdapter da;
        private DataSet ds;
        //nome do banco de dados
        private string bd = "Cadastro.mdb";
        private int linhaAtual = 0;
        //variáveis para os campos da tabela CLientes
        private string codigoID, nome, endereco, cidade, estado, cep, telefone;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //chama rotina para exibir os dados no datagridview
            iniciaAcesso();
        }
        private void iniciaAcesso()
        {
            //define o dataset
            ds = new DataSet();
            //cria uma conexão usando a string de conexão
            Conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\dados\\" + bd);
            try
            {
                //abre a conexao
                Conn.Open();
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
            if (Conn.State == ConnectionState.Open)
            {
                //se a conexão estiver aberta usa uma instrução SQL para selecionar os registros da tabela clientes
                //SELECT campos FROM tabela
                da = new OleDbDataAdapter("SELECT * from Clientes", Conn);
                da.Fill(ds, "Tabela");
                //exibe os dados no datagridview
                dgvDados.DataSource = ds;
                dgvDados.DataMember = "Tabela";
            }
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            //instancia o formulário para incluir e exibe-o de forma modal
            Form2 frm2 = new Form2();
            frm2.ShowDialog();
            iniciaAcesso();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            //solicitação confirmação para encerrar
            if (MessageBox.Show("Confirma encerramento ? ", "Encerrar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                //obtem o código do cliente a partir da linha selecionada no datagridview
                codigoID = dgvDados[0, linhaAtual].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro..." + ex.Message);
            }
            if (linhaAtual >= 0)
            {
                //obtem dados do datagridview e atribui as variáveis definidas no formulario f3
                obtemDadosGrid();
                Form3 f3 = new Form3();
                //
                f3.codigoID = codigoID;
                f3.nome = nome;
                f3.endereco = endereco;
                f3.cidade = cidade;
                f3.estado = estado;
                f3.cep = cep;
                f3.telefone = telefone;
                //exibe o formulário para alteração
                f3.ShowDialog();
                //atualiza o grid e reexibe os dados
                dgvDados.Update();
                iniciaAcesso();
            }
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                //obtem o código do cliente a partir da linha selecionada no datagridview
                codigoID = dgvDados[0, linhaAtual].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro..." + ex.Message);
            }
            if (linhaAtual >= 0)
            {
                //obtem dados do datagridview e atribui as variáveis definidas no formulario f4
                obtemDadosGrid();
                Form4 f4 = new Form4();
                //
                f4.codigoID = codigoID;
                f4.nome = nome;
                f4.endereco = endereco;
                f4.cidade = cidade;
                f4.estado = estado;
                f4.cep = cep;
                f4.telefone = telefone;
                //exibe o formulário para exclusão
                f4.ShowDialog();
                //atualiza o grid e reexibe os dados 
                dgvDados.Update();
                iniciaAcesso();
            }
        }

        private void dgvDados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            linhaAtual = int.Parse(e.RowIndex.ToString());
        }
        private void obtemDadosGrid()
        {
           //obtem os dados do datagridview da linha selecionada usando as posições das colunas
           //a primeira coluna é a coluna 0 a segunda é a coluna 1 , e , assim por diante
           nome = dgvDados[1, linhaAtual].Value.ToString();
           endereco = dgvDados[2, linhaAtual].Value.ToString();
           cidade = dgvDados[3, linhaAtual].Value.ToString();
           estado = dgvDados[4, linhaAtual].Value.ToString();
           cep = dgvDados[5, linhaAtual].Value.ToString();
           telefone = dgvDados[6, linhaAtual].Value.ToString();
         //
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            Form5 f5= new Form5();
            
            f5.ShowDialog();

            if (f5.sqlString != null && f5.sqlString != "")
                 carregaGrid(f5.sqlString);
        }

        private void carregaGrid(string criterioSQL)
        {
            //define o dataset
            ds = new DataSet();
            //cria uma conexão usando a string de conexão
            Conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\dados\\" + bd);
            try
            {
                //abre a conexao
                Conn.Open();
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
            if (Conn.State == ConnectionState.Open)
            {
                //se a conexão estiver aberta usa uma instrução SQL para selecionar os registros da tabela clientes
                //SELECT campos FROM tabela
                da = new OleDbDataAdapter(criterioSQL, Conn);
                da.Fill(ds, "Tabela");
                //exibe os dados no datagridview
                dgvDados.DataSource = ds;
                dgvDados.DataMember = "Tabela";
            }

        }      
    }
}
