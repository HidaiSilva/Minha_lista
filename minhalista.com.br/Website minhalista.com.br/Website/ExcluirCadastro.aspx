<%@ Page Title="" Language="C#" MasterPageFile="~/CadastroDefault.master" AutoEventWireup="true" CodeFile="ExcluirCadastro.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width: 100%; margin-left: 24px;" align="left">
           <tr>
               <td align="center" class="style6">
                   &nbsp;
               </td>
               <td class="style4">
                   &nbsp;
               </td>
           </tr>
           <tr>
               <td align="center" class="style16">
                   CPF</td>
               <td class="style17">
                   <asp:TextBox ID="TextBox3" runat="server" Width="354px"></asp:TextBox>
               </td>
           </tr>
           <tr>
               <td align="center" class="style7">
                   &nbsp;&nbsp;Senha</td>
               <td class="style5">
                   <asp:TextBox ID="TextBox4" runat="server" Width="355px"></asp:TextBox>
               </td>
           </tr>
           <tr>
               <td align="center" class="style12">
                   &nbsp;</td>
               <td align="center" class="style13">
                   <asp:Button ID="Button5" runat="server" Text="Excluir" Width="89px" />
               </td>
           </tr>
       </table>
</asp:Content>

