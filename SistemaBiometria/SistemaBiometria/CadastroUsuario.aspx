<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CadastroUsuario.aspx.cs" Inherits="SistemaBiometria.CadastroUsuario" %>

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
            <a href="Login.aspx"><i class="fa fa-times fa-pencil"></i></a> 
            <div class="tooltip">LOGIN</div>
        </div>
        <div class="form">
            <h2>CASTRAR NOVO USUÁRIO</h2>
            <form name="Form_Cadastro" id="Form_cadastro" runat="server">
                <%--<input type="text" name="txt_Nome" id="txt_Nome" placeholder="NOME" />--%>
                <asp:TextBox ID="txt_Nome" runat="server" placeholder="NOME"></asp:TextBox>
                <%--<input type="number" name="txt_CPF" id="txt_CPF" placeholder="CPF" />--%>
                <asp:TextBox ID="txt_Cpf" runat="server" placeholder="CPF"></asp:TextBox>
                <%--<input type="text" name="txt_Codigo" id="txt_Codigo" placeholder="COD. BIOMETRIA" />--%>
                <asp:TextBox ID="txt_Codigo" runat="server" placeholder="COD. BIOMETRIA"></asp:TextBox>
                <%--<button>CADASTRAR</button>--%>
                <asp:Button ID="Btn_CadastrarUsuario" runat="server" Text="Cadastrar" OnClick="Btn_CadastrarUsuario_Click" />
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


