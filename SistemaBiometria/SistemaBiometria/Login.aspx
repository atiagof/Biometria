<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="SistemaBiometria.Login" %>

<!DOCTYPE html>
<html>
<head>
    <meta charset="UTF-8">
    <title>Biometria login</title>

    <link rel="stylesheet" href="css/reset.css">
    <link rel='stylesheet prefetch' href='http://fonts.googleapis.com/css?family=Roboto:400,100,300,500,700,900|RobotoDraft:400,100,300,500,700,900'>
    <link rel='stylesheet prefetch' href='http://maxcdn.bootstrapcdn.com/font-awesome/4.3.0/css/font-awesome.min.css'>
    <link rel="stylesheet" href="css/style.css">
</head>

<body>
    <!-- Form Mixin-->
    <!-- Input Mixin-->
    <!-- Button Mixin-->
    <!-- Pen Title-->
    <div class="pen-title">
        <h1>BIOMETRIA LOGIN</h1>
        <%--<span>Pen <i class='fa fa-paint-brush'></i>+ <i class='fa fa-code'></i>by <a href='http://andytran.me'>Andy Tran</a></span>--%>
    </div>
    <!-- Form Module-->
    <div class="module form-module">
        <div class="toggle">
            <a href="CadastroUsuario.aspx"><i class="fa fa-times fa-pencil"></i></a>
            <div class="tooltip">CADASTRO</div>
        </div>
        <div class="form">
            <h2>ACESSO</h2>
            <form name="Form_Login" id="Form_Login" runat="server">
                <asp:TextBox ID="txt_Cpf" runat="server" placeholder="CPF"></asp:TextBox>
                <%--<button>LOGIN</button>--%>
                <asp:Button ID="Btn_Login" runat="server" Text="Login" OnClick="Btn_login_Click" />
            </form>
        </div>
        <div class="form">
            <%--<h2>CASTRAR NOVO USUÁRIO</h2>--%>
            <form>
            </form>
        </div>
        <%--<div class="cta"><a href="http://andytran.me">Esqueceu sua senha?</a></div>--%>
    </div>
    <script src='http://cdnjs.cloudflare.com/ajax/libs/jquery/2.1.3/jquery.min.js'></script>
    <script src='http://codepen.io/andytran/pen/vLmRVp.js'></script>
    <script src="js/index.js"></script>
</body>
</html>

