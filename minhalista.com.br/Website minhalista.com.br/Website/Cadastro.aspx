<%@ Page Title="" Language="C#" MasterPageFile="~/CadastroDefault.master" AutoEventWireup="true" CodeFile="Cadastro.aspx.cs" Inherits="Cadastro" %>

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
               <td align="center" class="style8">
                   &nbsp;
               </td>
               <td class="style10">
                   &nbsp;
               </td>
           </tr>
           <tr>
               <td align="center" class="style7">
                   <asp:Label ID="Label3" runat="server" Text="Nome"></asp:Label>
               </td>
               <td class="style5">
                   <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
               </td>
               <td align="center" class="style9">
                   CPF</td>
               <td class="style11">
                   <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
               </td>
           </tr>
           <tr>
               <td align="center" class="style7">
                   &nbsp;&nbsp;&nbsp;&nbsp; Endereço</td>
               <td class="style5">
                   <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
               </td>
               <td align="center" class="style9">
                   Bairro</td>
               <td class="style11">
                   <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
               </td>
           </tr>
           <tr>
               <td align="center" class="style7">
                   Cidade</td>
               <td class="style5">
                   <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
               </td>
               <td align="center" class="style9">
                   CEP</td>
               <td class="style11">
                   <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
               </td>
           </tr>
           <tr>
               <td align="center" class="style7">
                   E-mail</td>
               <td class="style5">
                   <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
               </td>
               <td align="center" class="style9">
                   Telefone</td>
               <td class="style11">
                   <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox>
               </td>
           </tr>
           <tr>
               <td align="center" class="style7">
                   Senha</td>
               <td class="style5">
                   <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
               </td>
               <td align="center" class="style9">
                   Confirme a senha</td>
               <td class="style11">
                   <asp:TextBox ID="TextBox12" runat="server"></asp:TextBox>
               </td>
           </tr>
           <tr>
               <td align="center" class="style12">
               </td>
               <td class="style13">
               </td>
               <td align="center" class="style14">
               </td>
               <td class="style15">
               </td>
           </tr>
           <tr>
               <td align="center" class="style12">
                   &nbsp;</td>
               <td align="right" class="style13">
                   <asp:Button ID="Button5" runat="server" Text="Cadastrar" />
               </td>
               <td align="right" class="style14">
                   <input id="Reset1" type="reset" value="Limpar" /></td>
               <td align="center" class="style15">
                   &nbsp;</td>
           </tr>
       </table>
</asp:Content>

