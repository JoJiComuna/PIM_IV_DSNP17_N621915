<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Reservar.aspx.cs" Inherits="Web.WebViews.Reservar" %>

<!DOCTYPE html>
<html style="font-size: 16px;">
<head>
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta charset="utf-8">
    <meta name="keywords" content="$10 Off withEmail Signup">
    <meta name="description" content="">
    <meta name="page_type" content="np-template-header-footer-from-plugin">
    <title>Minha Conta</title>

    <link rel="stylesheet" href="../nicepage.css" media="screen">
    <link rel="stylesheet" href="Login.css" media="screen">
    <link rel="stylesheet" href="../Teste.css" media="screen">
    <script class="u-script" type="text/javascript" src="../jquery.js" defer=""></script>
    <script class="u-script" type="text/javascript" src="../nicepage.js" defer=""></script>
    <meta name="generator" content="Nicepage 3.17.2, nicepage.com">
    <link id="u-theme-google-font" rel="stylesheet" href="https://fonts.googleapis.com/css?family=Roboto:100,100i,300,300i,400,400i,500,500i,700,700i,900,900i|Open+Sans:300,300i,400,400i,600,600i,700,700i,800,800i">





    <script type="application/ld+json">{
		"@context": "http://schema.org",
		"@type": "Organization",
		"name": "",
		"logo": "../images/PNG-JAPA-2.png"
}</script>
    <meta property="og:title" content="Login">
    <meta property="og:type" content="website">
    <meta name="theme-color" content="#478ac9">
    </head>
</head>
<body class="u-body">
    <header class="u-clearfix u-custom-color-1 u-header u-header" id="sec-4d90">
        <div class="u-clearfix u-sheet u-sheet-1">
            <a href="https://localhost" class="u-image u-logo u-image-1" data-image-width="1600" data-image-height="1412">
                <img src="../images/PNG-JAPA-2.png" class="u-logo-image u-logo-image-1" data-image-width="100px">
            </a>
            <nav class="u-align-center u-menu u-menu-dropdown u-offcanvas u-menu-1" data-submenu-level="on-click" data-responsive-from="MD">
                <div class="menu-collapse" style="font-size: 1rem; letter-spacing: 0px; text-transform: uppercase; font-weight: 700; font-style: italic;">
                    <a class="u-button-style u-custom-active-color u-custom-border u-custom-border-color u-custom-border-radius u-custom-hover-color u-custom-left-right-menu-spacing u-custom-padding-bottom u-custom-text-active-color u-custom-text-color u-custom-text-decoration u-custom-text-hover-color u-custom-top-bottom-menu-spacing u-nav-link u-text-active-palette-1-base u-text-hover-palette-2-base" href="#" style="padding: 4px 8px; font-size: calc(1em + 8px);">
                        <svg>
                            <use xmlns:xlink="http://www.w3.org/1999/xlink" xlink:href="#menu-hamburger"></use></svg>
                        <svg version="1.1" xmlns="http://www.w3.org/2000/svg" xmlns:xlink="http://www.w3.org/1999/xlink">
                            <defs>
                                <symbol id="menu-hamburger" viewBox="0 0 16 16" style="width: 16px; height: 16px;">
                                    <rect y="1" width="16" height="2"></rect>
                                    <rect y="7" width="16" height="2"></rect>
                                    <rect y="13" width="16" height="2"></rect>
                                </symbol>
                            </defs></svg>
                    </a>
                </div>
                <div class="u-custom-menu u-nav-container">
                    <ul class="u-nav u-spacing-2 u-unstyled u-nav-1">
                        <li class="u-nav-item"><a class="u-active-palette-1-base u-border-1 u-border-grey-75 u-button-style u-hover-palette-1-light-1 u-nav-link u-radius-50 u-text-active-white u-text-hover-white u-text-white" href="Página-Inicial.aspx" style="padding: 10px 38px;">Página Inicial</a>
                        </li>
                        <li  class="u-nav-item"><a class="u-active-palette-1-base u-border-1 u-border-grey-75 u-button-style u-hover-palette-1-light-1 u-nav-link u-radius-50 u-text-active-white u-text-hover-white u-text-white" href="Quartos.aspx" style="padding: 10px 38px;">Quartos</a>
                        </li>
                        <li class="u-nav-item"><a class="u-active-palette-1-base u-border-1 u-border-grey-75 u-button-style u-hover-palette-1-light-1 u-nav-link u-radius-50 u-text-active-white u-text-hover-white u-text-white" href="Contato.aspx" style="padding: 10px 38px;">Contato</a>
                        </li>
                        <li class="u-nav-item"><a class="u-active-palette-1-base u-border-1 u-border-grey-75 u-button-style u-hover-palette-1-light-1 u-nav-link u-radius-50 u-text-active-white u-text-hover-white u-text-white" href="InfoHospede.aspx" style="padding: 10px 38px;">Minha Conta</a>
                        </li>
                    </ul>
                </div>
                <div class="u-custom-menu u-nav-container-collapse">
                    <div class="u-container-style u-custom-color-1 u-inner-container-layout u-sidenav">
                        <div class="u-sidenav-overflow">
                            <div class="u-menu-close"></div>
                            <ul class="u-align-left u-nav u-popupmenu-items u-spacing-13 u-unstyled u-nav-2">
                                <li class="u-nav-item"><a class="u-button-style u-nav-link" href="Página-Inicial.aspx" style="padding: 10px 38px;">Página Inicial</a>
                                </li>
                                <li class="u-nav-item"><a class="u-button-style u-nav-link" href="Quartos.aspx" style="padding: 10px 38px;">Quartos</a>
                                </li>
                                <li class="u-nav-item"><a class="u-button-style u-nav-link" href="Contato.aspx" style="padding: 10px 38px;">Contato</a>
                                </li>
                                <li class="u-nav-item"><a class="u-button-style u-nav-link" href="InfoHospede.aspx" style="padding: 10px 38px;">Minha Conta</a>
                                </li>
                            </ul>
                        </div>
                    </div>
                    <div class="u-black u-menu-overlay u-opacity u-opacity-70"></div>
                </div>
            </nav>
        </div>
    </header>
    <section class="u-align-center u-clearfix u-section-1" id="sec-9467">
        <div class="u-clearfix u-sheet u-sheet-1">
            <div class="u-clearfix u-expanded-width u-layout-wrap u-layout-wrap-1">
                <div class="u-layout">
                    <div class="u-layout-row">


                        <form id="form1" runat="server">
                            <table cellspacing="6" style="text-align: left;" >
                                 <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Check-In" Font-Size="Large" Font-Bold="True" ForeColor="#666666"></asp:Label>
                    </td>
                    <td></td>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Check-Out" Font-Size="Large" Font-Bold="True" ForeColor="#666666"></asp:Label>
                        <asp:Image ID="imgDisponivel" runat="server" Width="16px" />
                    </td>
                    <td></td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="Checkin" runat="server" TextMode="Date" AutoPostBack="True" OnTextChanged="Checkin_TextChanged" CssClass=" txtBox"></asp:TextBox>
                    </td>
                    <td></td>
                    <td colspan="2">
                         <asp:TextBox ID="Checkout" runat="server" TextMode="Date" AutoPostBack="True" OnTextChanged="Checkout_TextChanged" CssClass="txtBox"></asp:TextBox>
                    </td>
                    <td></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text="Tipo de Quarto" Font-Size="Large" Font-Bold="True" ForeColor="#666666"></asp:Label>
                    </td>
                    <td></td>
                    <td>
                        <asp:Label ID="Label4" runat="server" Text="Adultos Extras" Font-Size="Large" Font-Bold="True" ForeColor="#666666"></asp:Label>
                    </td>
                    <td></td>
                    <td>
                        <asp:Label ID="Label5" runat="server" Text="Crianças Extras" Font-Size="Large" Font-Bold="True" ForeColor="#666666"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:DropDownList ID="dropTipoQuarto" runat="server" AutoPostBack="True" CssClass="txtBox" Font-Size="Large" OnTextChanged="dropTipoQuarto_TextChanged"></asp:DropDownList>
                    </td>

                    <td></td>
                    <td>
                        <asp:DropDownList ID="dropAdultos"  runat="server"  CssClass="txtBox" Font-Size="Large"></asp:DropDownList>
                    </td>
                    <td></td>
                    <td>
                        <asp:DropDownList ID="dropCriancas" runat="server"  CssClass="txtBox" Font-Size="Large"></asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label6" runat="server" Text="Identificação do Quarto" Font-Size="Large" Font-Bold="True" ForeColor="#666666"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td colspan="5">
                        <asp:DropDownList ID="dropNmQuarto" runat="server" AutoPostBack="True" CssClass="txtBox" Font-Size="Large" Width="520px"></asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td colspan="5" class="imgAlign">
                        <asp:Image ID="imgQuarto" runat="server" Width="300px" ImageUrl="~/Images/a9ace596_y.jpg" CssClass="imgCenter" style="margin-left: 105px" />
                        </td>
                </tr>
                <tr>
                    <td >
                        <asp:Label ID="Label7" runat="server" Text="Descrição do Quarto" Font-Size="Large" Font-Bold="True" ForeColor="#666666"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td colspan="5">
                        <asp:Label ID="txtDsInfoQuarto" runat="server" Text="DS" Font-Size="Large" Font-Bold="True" ForeColor="#666666"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblTotalTexto" runat="server" Text="Total" Font-Size="Large" Visible="False"></asp:Label>
                    </td>
                    <td colspan="5">
                        <asp:Label ID="lblTotal" runat="server" Font-Size="Large" Font-Bold="True" ForeColor="#009933"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td colspan="6">
                        <asp:Label ID="lblDs_Msg" runat="server" Text="Label" Font-Bold="True" ForeColor="Red" Visible="False" Font-Size="Large"></asp:Label>
                    </td>
                   
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnReservar"  runat="server" Text="Reservar" OnClick="btnReservar_Click" CssClass="btnLog" Font-Bold="True" Font-Names="Comic Sans MS" Font-Size="Large" ForeColor="White" />
                    </td>
                </tr>

                            </table>
                        </form>


                    </div>
                </div>
            </div>
        </div>
        <div class="u-form u-form-1"></div>

    </section>





    <footer class="u-clearfix u-custom-color-1 u-footer" id="sec-f6be">
        <div class="u-clearfix u-sheet u-sheet-1">
            <a href="https://localhost" class="u-image u-logo u-image-1" data-image-width="6595" data-image-height="1252">
                <img src="../images/PNG-JAPA-1.png" class="u-logo-image u-logo-image-1" data-image-width="372.3406">
            </a>
            <div class="u-align-left u-border-1 u-border-white u-expanded-width u-line u-line-horizontal u-opacity u-opacity-30 u-line-1"></div>
            <div class="u-clearfix u-expanded-width u-gutter-30 u-layout-wrap u-layout-wrap-1">
                <div class="u-gutter-0 u-layout">
                    <div class="u-layout-row">
                        <div class="u-align-center u-container-style u-layout-cell u-size-20 u-layout-cell-1">
                            <div class="u-container-layout u-valign-top u-container-layout-1">
                                <!--position-->
                                <div data-position="" class="u-position u-position-1">
                                    <!--block-->
                                    <div class="u-block">
                                        <div class="u-block-container u-clearfix">
                                            <!--block_header-->
                                            <h5 class="u-block-header u-text">
                                                <!--block_header_content-->
                                                Contato<!--/block_header_content--></h5>
                                            <!--/block_header-->
                                            <!--block_content-->
                                            <div class="u-block-content u-text">
                                                <!--block_content_content-->
                                                Centro ,Sorocaba-SP
                                                <br>
                                                (15)3232-1265
                                                                                 class="u-block-container u-clearfix">
                                                                              </div>
                                    <!--/position-->
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
    </footer>
    <span style="height: 64px; width: 64px; margin-left: 0px; margin-right: auto; margin-top: 0px; background-image: none; right: 80px; bottom: 10px;" class="u-back-to-top u-border-2 u-border-custom-color-3 u-icon u-icon-circle u-opacity u-opacity-85 u-spacing-7 u-text-palette-1-base" data-href="#">
        <svg class="u-svg-link" preserveAspectRatio="xMidYMin slice" viewBox="0 0 551.13 551.13">
            <use xmlns:xlink="http://www.w3.org/1999/xlink" xlink:href="#svg-1d98"></use></svg>
        <svg class="u-svg-content" enable-background="new 0 0 551.13 551.13" viewBox="0 0 551.13 551.13" xmlns="http://www.w3.org/2000/svg" id="svg-1d98">
            <path d="m275.565 189.451 223.897 223.897h51.668l-275.565-275.565-275.565 275.565h51.668z"></path></svg>
    </span>
</body>
</html>


