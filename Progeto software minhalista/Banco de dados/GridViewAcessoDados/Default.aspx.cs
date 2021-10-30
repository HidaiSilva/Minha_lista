using System;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Configuration;
using System.Data.OleDb;

public partial class _Default : System.Web.UI.Page 
{
    private double valorTotal = 0;

    protected void btnAcessoDados_Click(object sender, EventArgs e)
    {
        gdvProdutos.AutoGenerateColumns = false;
        BoundField coluna1 = new BoundField();
        coluna1.DataField = "ProductID";
        coluna1.HeaderText = "Código";
        gdvProdutos.Columns.Add(coluna1);

        BoundField coluna2 = new BoundField();
        coluna2.DataField = "ProductName";
        coluna2.HeaderText = "Produto";
        gdvProdutos.Columns.Add(coluna2);

        BoundField coluna3 = new BoundField();
        coluna3.DataField = "UnitPrice";
        coluna3.HeaderText = "Preço Unitário";
        coluna3.HtmlEncode = false;
        //cpo3.DataFormatString = "{0:c}";
        gdvProdutos.Columns.Add(coluna3);
        populagrid();
    }
    private void populagrid()
    {
        //obtem a string de conexão do arquivo web.config
        string strConnectionString = ConfigurationManager.ConnectionStrings["OleDbConnectionString"].ConnectionString;
        //cria uma instância do objeto Connection
        OleDbConnection mConnection = new OleDbConnection(strConnectionString);
        // cria um objeto Command
        string strCommandText = "SELECT ProductID, ProductName,UnitPrice From Products";
        // abre a conexão com o banco de dados
        mConnection.Open();

        OleDbDataAdapter da = new OleDbDataAdapter();
        da.SelectCommand = new OleDbCommand(strCommandText, mConnection);

        DataTable dt = new DataTable();
        da.Fill(dt);
        // exibe os dados e fecha a conexão
        gdvProdutos.DataSource = dt;//ds

        gdvProdutos.DataBind();
        mConnection.Close();
    }
    protected void gdvProdutos_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gdvProdutos.PageIndex = e.NewPageIndex;
        populagrid();
    }
    protected void gdvProdutos_RowDataBound(object sender, GridViewRowEventArgs e)
    {

        //da um efeito zebrado ao grid colorindo linhas alternadamente 
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            if (((e.Row.RowIndex + 1) % 2) == 0)
            {
                e.Row.BackColor = System.Drawing.Color.LightSkyBlue;
            }
        }

        //colorindo uma linha com base no conteúdo de uma célula
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            switch (e.Row.Cells[1].Text)
            {
                case "Chai":
                    e.Row.BackColor = System.Drawing.Color.Yellow;
                    break;
                case "Ikura":
                    e.Row.BackColor = System.Drawing.Color.Crimson;
                    break;
            }
        } 

        //calculando o total de uma coluna por página
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            CalculaTotal(e.Row.Cells[2].Text);
            e.Row.Cells[2].Text = string.Format("{0:c}", Convert.ToDouble(e.Row.Cells[2].Text));
            e.Row.Cells[2].HorizontalAlign = HorizontalAlign.Right;
        }
        else if (e.Row.RowType == DataControlRowType.Footer)
        {
            e.Row.Cells[1].Text = "Total";
            e.Row.Cells[2].Text = string.Format("{0:c}", valorTotal);
            e.Row.Cells[2].HorizontalAlign = HorizontalAlign.Right;
        }
        }

        private void CalculaTotal(string _preco)
        {
            try
            {
                valorTotal += Double.Parse(_preco);
            }
            catch (Exception ex)
            {
                HttpContext.Current.Response.Write(ex.ToString());
            }
        }
  
}
