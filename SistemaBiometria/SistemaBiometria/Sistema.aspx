<%@ Page Title="" Language="C#" MasterPageFile="~/BiometriaSite.Master" AutoEventWireup="true" CodeBehind="Sistema.aspx.cs" Inherits="SistemaBiometria.Sistema" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Conteudo" runat="server">
    <br />
    <br />
    <asp:Label ID="Lbl_Sistema" runat="server" Text="Cadastro de sistemas" Font-Bold="true" Font-Size="XX-Large" ForeColor="Black"></asp:Label>
    <br />
    <br />
    <asp:TextBox ID="Txt_Nome_Sistema" runat="server" placeholder="Sistema" Width="100%" Font-Size="X-Large"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="Btn_Cadastrar" runat="server" Text="Cadastrar" Font-Bold="true" Font-Size="X-Large" OnClick="Btn_Cadastrar_Click" />
</asp:Content>
