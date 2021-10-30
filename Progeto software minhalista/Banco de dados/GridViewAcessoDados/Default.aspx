<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>GridView - Acesso a dados com paginação, formatação e sumarização </title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="gdvProdutos" runat="server" AllowPaging="True" Height="106px" 
            onpageindexchanging="gdvProdutos_PageIndexChanging" 
            onrowdatabound="gdvProdutos_RowDataBound" ShowFooter="True" Width="304px" 
           >
        </asp:GridView>
        <br />
        <asp:Button ID="btnAcessoDados" runat="server" onclick="btnAcessoDados_Click" 
            Text="Acessar dados MsAccess" Width="305px" />
    
    </div>
    </form>
</body>
</html>
