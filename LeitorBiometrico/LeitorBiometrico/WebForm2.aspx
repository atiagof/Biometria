<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="LeitorBiometrico.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registraion</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Lbl_Id" runat="server" Text="ID"></asp:Label>
            <br />
            <asp:TextBox ID="Txt_Id" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Lbl_Nome" runat="server" Text="Nome"></asp:Label>
            <br />
            <asp:TextBox ID="Txt_Nome" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Image ID="Img_Sample" runat="server" Height="258px" Width="208px" />
            <br />
            <asp:Label ID="Lbl_Samples" runat="server" Text="Samples Needed"></asp:Label>
        </div>
        <div>
            <br />
            <asp:Button ID="Btn_Iniciar" runat="server" Text="Iniciar" />
            <br />
            <asp:Button ID="Btn_Cancelar" runat="server" Text="Cancelar" Enabled="false" />
        </div>
    </form>
</body>
</html>
