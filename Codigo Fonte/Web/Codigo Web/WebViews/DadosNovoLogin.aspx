<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DadosNovoLogin.aspx.cs" Inherits="Web.WebViews.DadosNovoLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />

    <title>Dados do Login</title>
      <link rel="stylesheet" href="../Teste.css" media="screen">
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Informações Gerais" Font-Size="Larger"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Nome Completo" Font-Size="Large"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td colspan ="5">
                        <asp:TextBox ID="txtNmHospede" runat="server" CssClass="txtBox" Font-Size="Large"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text="CPF" Font-Size="Large"></asp:Label>
                    </td>
                    <td></td>
                    <td>
                        <asp:Label ID="Label4" runat="server" Text="Telefone" Font-Size="Large"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="txtCPF" runat="server" CssClass="txtBox" Font-Size="Large"></asp:TextBox>
                    </td>
                    <td></td>
                    <td>
                        <asp:TextBox ID="TxtTelefone" runat="server" CssClass="txtBox" Font-Size="Large"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label5" runat="server" Text="Endereço" Font-Size="Larger"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label6" runat="server" Text="UF" Font-Size="Large"></asp:Label>
                    </td>
                    <td></td>
                    <td>
                        <asp:Label ID="Label7" runat="server" Text="Cidade" Font-Size="Large"></asp:Label>
                    </td>
                    <td></td>
                    <td>
                        <asp:Label ID="Label8" runat="server" Text="Bairro" Font-Size="Large"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:DropDownList ID="dropUF" runat="server" CssClass="txtBox" Font-Size="Large"></asp:DropDownList>
                    </td>
                    <td></td>
                    <td>
                        <asp:TextBox ID="txtCidade" runat="server" CssClass="txtBox" Font-Size="Large"></asp:TextBox>
                    </td>
                    <td></td>
                    <td>
                        <asp:TextBox ID="txtBairro" runat="server" CssClass="txtBox" Font-Size="Large"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label9" runat="server" Text="Rua" Font-Size="Large"></asp:Label>
                    </td>
                    <td></td>
                    <td>
                        <asp:Label ID="Label10" runat="server" Text="Nº" Font-Size="Large"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="txtRua" runat="server" CssClass="txtBox" Font-Size="Large"></asp:TextBox>
                    </td>
                    <td></td>
                    <td>
                        <asp:TextBox ID="txtNrEndereco" runat="server" CssClass="txtBox" Font-Size="Large"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan ="5">
                        <asp:Label ID="lblDs_Msg" runat="server" Text="Label" Font-Bold="True" ForeColor="Red" Visible="False" Font-Size="Large"></asp:Label>
                    </td>

                </tr>
                <tr>
                    <td colspan ="5">
                        <asp:Button ID="txtCadastrar" runat="server" Text="Cadastrar" OnClick="txtCadastrar_Click" CssClass="btnLog" Font-Bold="True" Font-Size="Large" ForeColor="White" Height="30px" Width="150px" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
