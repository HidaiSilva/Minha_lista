using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using MySql.Data.MySqlClient;
using MySql.Data;
using System.Data;


public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button5_Click(object sender, EventArgs e)
    {
        //1-String de conexão server=localhost;User Id=root;password=123456;Persist Security Info=True;database=minhalista
        String conexao = "server=localhost;User Id=root;password=minhalista;Persist Security Info=True;database=minhalista";

        //2-Criando a conexão 
        MySqlConnection conn = new MySqlConnection(conexao);

        //3-String de comando
        String comando = "select * from cliente where Email = '" + TextBox14.Text + "'";
        String comando2 = "select * from cliente where Senha = '" + TextBox15.Text + "'";
        
        //Verifica se o campo esta vazio 
        if (TextBox14.Text == string.Empty || TextBox15.Text == string.Empty)
            {
                Label12.Text = "Prencha os campos";

            }
            else
            {
                //4 Cria o adaptador                                 pesquisa conexdão
                MySqlDataAdapter DataAdapter1 = new MySqlDataAdapter(comando, conexao);
                MySqlDataAdapter DataAdapter2 = new MySqlDataAdapter(comando2, conexao);

                // 5 - Cria o dataset ...em forma de objeto...tem metodos e propriedades
                DataSet ds = new DataSet();
                DataSet ds2 = new DataSet();

                /* 6 - Realiza a pesquisa no banco de dados
                       e preenche a tabela adm do datatable com os resultados obtidos */
                DataAdapter1.Fill(ds,"Email");
                DataAdapter2.Fill(ds2, "Senha");

                // 7- Pega  uma referência da tabela criada dentro do dataset
                DataTable tabelaDeDados = ds.Tables["Email"];
                DataTable tabelaDeDados2 = ds2.Tables["Senha"];

                //Colocar a pesquisa na varialvel e verificar
                string resultado = tabelaDeDados.Rows[0]["Email"].ToString();
                string resultado2 = tabelaDeDados.Rows[0]["Senha"].ToString();

                if (TextBox14.Text == resultado && TextBox15.Text == resultado2)
                {
                    //se resultados for igual aos campos textbox... 
                    Response.Redirect("Default.aspx");
                }
                else
                {
                    Label12.Text = "Dados invalidos";
                }
            }

        
      

            
        
    }
}