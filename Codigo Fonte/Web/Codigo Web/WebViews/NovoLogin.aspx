<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NovoLogin.aspx.cs" Inherits="Web.WebViews.NovoLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>NovoLogin</title>
    <link rel="stylesheet" href="../Teste.css" media="screen">
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="E-mail" Font-Size="Large"></asp:Label>
                         <asp:Label ID="Label5" runat="server" Text="*" ForeColor="Red" Font-Bold="True"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="txtEmail" runat="server" CssClass="txtBox" Font-Size="Large"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Usuário" Font-Size="Large"></asp:Label>
                         <asp:Label ID="Label6" runat="server" Text="*" ForeColor="Red" Font-Bold="True"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="txtUser" runat="server" CssClass="txtBox" Font-Size="Large"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text="Senha" Font-Size="Large"></asp:Label>
                         <asp:Label ID="Label7" runat="server" Text="*" ForeColor="Red" Font-Bold="True"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="txtSenha" runat="server" TextMode="Password" OnTextChanged="txtSenha_TextChanged" AutoPostBack="True" CssClass="txtBox" Font-Size="Large"></asp:TextBox>
                       
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label4" runat="server" Text="Confirmar Senha" Font-Size="Large"></asp:Label>
                         <asp:Label ID="Label9" runat="server" Text="*" ForeColor="Red" Font-Bold="True"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="txtSenha1" runat="server" TextMode="Password" OnTextChanged="txtSenha1_TextChanged" AutoPostBack="True" CssClass="txtBox" Font-Size="Large"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblDs_Msg" runat="server" Text="Label" Font-Bold="True" ForeColor="Red" Visible="False" Font-Size="Large"></asp:Label>

                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnContinuar" runat="server" Text="Continuar" OnClick="btnContinuar_Click" CssClass="btnLog" Font-Size="Large" ForeColor="White" />
                    </td>
                </tr>

            </table>
        </div>
    </form>
</body>
</html>
