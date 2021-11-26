<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Web.Login"  %>


<!DOCTYPE html>
<html style="font-size: 16px;">
  <head>
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta charset="utf-8">
    <meta name="keywords" content="$10 Off withEmail Signup">
    <meta name="description" content="">
    <meta name="page_type" content="np-template-header-footer-from-plugin">
    <title>Login</title>
    <link rel="stylesheet" href="../nicepage.css" media="screen">
<link rel="stylesheet" href="Login.css" media="screen">
<link rel="stylesheet" href="../Teste.css" media="screen">
      <link rel="stylesheet" href="../nicepage.css" media="screen">
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
  <body class="u-body"><header class="u-clearfix u-custom-color-1 u-header u-header" id="sec-4d90"><div class="u-clearfix u-sheet u-sheet-1">
        <a href="https://localhost" class="u-image u-logo u-image-1" data-image-width="1600" data-image-height="1412">
          <img src="../images/PNG-JAPA-2.png" class="u-logo-image u-logo-image-1" data-image-width="100px">
        </a>
        <nav class="u-align-center u-menu u-menu-dropdown u-offcanvas u-menu-1" data-submenu-level="on-click" data-responsive-from="MD">
          <div class="menu-collapse" style="font-size: 1rem; letter-spacing: 0px; text-transform: uppercase; font-weight: 700; font-style: italic;">
            <a class="u-button-style u-custom-active-color u-custom-border u-custom-border-color u-custom-border-radius u-custom-hover-color u-custom-left-right-menu-spacing u-custom-padding-bottom u-custom-text-active-color u-custom-text-color u-custom-text-decoration u-custom-text-hover-color u-custom-top-bottom-menu-spacing u-nav-link u-text-active-palette-1-base u-text-hover-palette-2-base" href="#" style="padding: 4px 8px; font-size: calc(1em + 8px);">
              <svg><use xmlns:xlink="http://www.w3.org/1999/xlink" xlink:href="#menu-hamburger"></use></svg>
              <svg version="1.1" xmlns="http://www.w3.org/2000/svg" xmlns:xlink="http://www.w3.org/1999/xlink"><defs><symbol id="menu-hamburger" viewBox="0 0 16 16" style="width: 16px; height: 16px;"><rect y="1" width="16" height="2"></rect><rect y="7" width="16" height="2"></rect><rect y="13" width="16" height="2"></rect>
</symbol>
</defs></svg>
            </a>
          </div>
          <div class="u-custom-menu u-nav-container">
            <ul class="u-nav u-spacing-2 u-unstyled u-nav-1"><li class="u-nav-item"><a class="u-active-palette-1-base u-border-1 u-border-grey-75 u-button-style u-hover-palette-1-light-1 u-nav-link u-radius-50 u-text-active-white u-text-hover-white u-text-white" href="Página-Inicial.aspx" style="padding: 10px 38px;">Página Inicial</a>
</li><li class="u-nav-item"><a class="u-active-palette-1-base u-border-1 u-border-grey-75 u-button-style u-hover-palette-1-light-1 u-nav-link u-radius-50 u-text-active-white u-text-hover-white u-text-white" href="Quartos.aspx" style="padding: 10px 38px;">Quartos</a>
</li><li class="u-nav-item"><a class="u-active-palette-1-base u-border-1 u-border-grey-75 u-button-style u-hover-palette-1-light-1 u-nav-link u-radius-50 u-text-active-white u-text-hover-white u-text-white" href="Contato.aspx" style="padding: 10px 38px;">Contato</a>
</li><li class="u-nav-item"><a class="u-active-palette-1-base u-border-1 u-border-grey-75 u-button-style u-hover-palette-1-light-1 u-nav-link u-radius-50 u-text-active-white u-text-hover-white u-text-white" href="Login.aspx" style="padding: 10px 38px;">Login</a>
</li></ul>
          </div>
          <div class="u-custom-menu u-nav-container-collapse">
            <div class="u-container-style u-custom-color-1 u-inner-container-layout u-sidenav">
              <div class="u-sidenav-overflow">
                <div class="u-menu-close"></div>
                <ul class="u-align-left u-nav u-popupmenu-items u-spacing-13 u-unstyled u-nav-2"><li class="u-nav-item"><a class="u-button-style u-nav-link" href="Página-Inicial.aspx" style="padding: 10px 38px;">Página Inicial</a>
</li><li class="u-nav-item"><a class="u-button-style u-nav-link" href="Quartos.aspx" style="padding: 10px 38px;">Quartos</a>
</li><li class="u-nav-item"><a class="u-button-style u-nav-link" href="Contato.aspx" style="padding: 10px 38px;">Contato</a>
</li><li class="u-nav-item"><a class="u-button-style u-nav-link" href="Login.aspx" style="padding: 10px 38px;">Login</a>
</li></ul>
              </div>
            </div>
            <div class="u-black u-menu-overlay u-opacity u-opacity-70"></div>
          </div>
        </nav>
      </div></header>
    <section class="u-align-center u-clearfix u-section-1" id="sec-9467">
      <div class="u-clearfix u-sheet u-sheet-1">
        <div class="u-clearfix u-expanded-width u-layout-wrap u-layout-wrap-1">
          <div class="u-layout">
            <div class="u-layout-row">
              <div class="u-container-style u-layout-cell u-size-23 u-layout-cell-1">
             
              </div>

                 <form id="form1" runat="server">
        <div>
            <table runat="server" >
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Login" Font-Size="Large"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="txtLogin" CssClass="txtBox" runat="server" Font-Size="Large" Width="180px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server"  Text="Senha" Font-Size="Large"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="txtSenha" runat="server"  CssClass="txtBox" Font-Size="Large" Width="180px" TextMode="Password"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:LinkButton ID="lblNovaSenha" runat="server" OnClick="lblNovaSenha_Click" >Esqueci minha Senha</asp:LinkButton>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblDs_Msg" runat="server" Text="Label" Font-Bold="True" ForeColor="Red" Visible="False" Font-Size="Large"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnLogar" CssClass="btnLog" runat="server"  Text="Logar" OnClick="btnLogar_Click" Font-Size="Large" ForeColor="White" Width="200px" Font-Bold="True" />
                    </td>
                </tr>
                <tr>
                    <td>
                         <asp:LinkButton ID="NovoLogin" runat="server" OnClick="NovoLogin_Click"  >Criar uma conta</asp:LinkButton>
                    </td>

                </tr>
            </table>
        </div>
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
                                                                                 <!--block_content-->
                                                                <div class="u-block-content u-text">
                                                                    <!--block_content_content-->
                                                                    Obrigado por acessar o site da Hydra Hotel , tenha um bom dia<!--/block_content_content-->
                                                                </div>
                                                                <!--/block_content-->
                                                            </div>
                                                        </div>
                                                        <!--/block-->
                                                    </div>
                                                    <!--/position-->
                                                </div>
                                            </div>
                                            <div class="u-align-center u-container-style u-layout-cell u-right-cell u-size-20 u-layout-cell-3">
                                                <div class="u-container-layout u-valign-top u-container-layout-3">
                                                    <!--position-->
                                                    <div data-position="" class="u-position u-position-3">
                                                        <!--block-->
                                                        <div class="u-block">
                                                            <div class="u-block-container u-clearfix">
                                                                <!--block_header-->
                                                                <h5 class="u-block-header u-text">
                                                                    <!--block_header_content-->
                                                                    forma de Pagamento
                                                <!--/block_header_content-->
                                                                </h5>
                                                                <!--/block_header-->
                                                                <!--block_content-->
                                                                <div class="u-block-content u-text">
                                                                    <!--block_content_content-->
                                                                    Aceitamos pagamento com:<br>
                                                                    Debito<br>
                                                                    Credito<br>
                                                                    DInheiro<br>
                                                                    PIx<!--/block_content_content-->
                                                                </div>
                                                                <!--/block_content-->
                                                            </div>
                                                        </div>
                                                        <!--/block-->
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


