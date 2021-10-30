using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

//classes para MySql
using MySql.Data.MySqlClient;
using MySql.Data;


public partial class _Default : System.Web.UI.MasterPage
{

    MySqlConnection conexao,conexao2;
    MySqlDataAdapter DataAdapter1,DataAdapter2;
    


    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void LinkButton4_Click(object sender, EventArgs e)
    {
        Response.Redirect("Cadastro.aspx");
    }
    protected void Button5_Click(object sender, EventArgs e)
    {

        try
        {
            conexao = new MySqlConnection("server=localhost;User Id=root;password=minhalista;database=minhalista");
            conexao.Open();

            if (txtUsuario.Text == string.Empty && txtSenha.Text==string.Empty)
            {
               lblResposta.Text="Preencha o Login.";
            }
            else
            {
                DataAdapter1 = new MySqlDataAdapter("select * from cliente where Email = '" + txtUsuario.Text + "'", conexao);
                DataAdapter2 = new MySqlDataAdapter("select * from cliente where Senha = '" + txtSenha.Text + "'", conexao2);
                DataTable tabelaDeDados = new DataTable();
                DataTable tabelaDeDados2 = new DataTable();
                DataAdapter1.Fill(tabelaDeDados);
                DataAdapter2.Fill(tabelaDeDados2);

                string login = tabelaDeDados.Rows[0]["Email"].ToString();
                string senha = tabelaDeDados2.Rows[0]["Senha"].ToString();

                if (txtUsuario.Text == login && txtSenha.Text==senha)
                {
                    Response.Redirect("Default.aspx");
                    Label10.Text = login;
                    lblResposta.Text="Login autenticado";
                    conexao.Close();
                    this.Visible = false;
                }
            }

        }
        catch (Exception)
        {

            lblResposta.Text="Usuário ou Senha incorretos";
        }
          
        
    }

 
    
}







