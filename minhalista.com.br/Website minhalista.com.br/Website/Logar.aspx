<%@ Page Title="" Language="C#" MasterPageFile="~/CadastroDefault.master" AutoEventWireup="true" CodeFile="Logar.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width: 94%; margin-left: 24px;" align="center">
           <tr>
               <td class="style4" align="center">
                   &nbsp;</td>
               <td class="style4" align="center">
         <table style="width:100%;">
             <tr>
                 <td>
                     &nbsp;</td>
                 <td align="center">
                     <asp:Label ID="Label10" runat="server" Text="Login"></asp:Label>
                 </td>
                 <td>
                     &nbsp;</td>
             </tr>
             <tr>
                 <td>
                     &nbsp;</td>
                 <td align="center">
                     <asp:TextBox ID="TextBox14" runat="server"></asp:TextBox>
                 </td>
                 <td>
                     &nbsp;</td>
             </tr>
             <tr>
                 <td>
                     &nbsp;</td>
                 <td align="center">
                     <asp:Label ID="Label11" runat="server" Text="Senha"></asp:Label>
                 </td>
                 <td>
                     &nbsp;</td>
             </tr>
             <tr>
                 <td>
                     &nbsp;</td>
                 <td align="center">
                     <asp:TextBox ID="TextBox15" runat="server" TextMode="Password"></asp:TextBox>
                 </td>
                 <td>
                     &nbsp;</td>
             </tr>
             <tr>
                 <td>
                     &nbsp;</td>
                 <td align="center">
                     <table style="width:100%;">
                         <tr>
                             <td align="center">
                                 <asp:Button ID="Button5" runat="server" onclick="Button5_Click" Text="Enviar" />
                             </td>
                         </tr>
                     </table>
                 </td>
                 <td>
                     &nbsp;</td>
             </tr>
             <tr>
                 <td>
                     &nbsp;</td>
                 <td align="center">
                     <asp:Label ID="Label12" runat="server" Text="Label"></asp:Label>
                 </td>
                 <td>
                     &nbsp;</td>
             </tr>
         </table>
               </td>
               <td class="style4" align="center">
                   &nbsp;</td>
           </tr>
           </table>
</asp:Content>

