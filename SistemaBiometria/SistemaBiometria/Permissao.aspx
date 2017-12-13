<%@ Page Title="" Language="C#" MasterPageFile="~/BiometriaSite.Master" AutoEventWireup="true" CodeBehind="Permissao.aspx.cs" Inherits="SistemaBiometria.Permissao" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Conteudo" runat="server">
    <br />
    <br />
    <asp:Label ID="Lbl_Sistema" runat="server" Text="Permissão de acesso aos sistemas" Font-Bold="true" Font-Size="XX-Large" ForeColor="Black"></asp:Label>
    <br />
    <br />
    <asp:Label ID="Lbl_Check" runat="server" CssClass="class_font_rotulo" Text="Sistemas:" Font-Size="20px" ForeColor="Black"></asp:Label>
    <asp:CheckBoxList ID="CBL_Sistemas"  runat="server" Font-Size="Large" ForeColor="Black"></asp:CheckBoxList>
    <div id="Div_Erro_CBL_Sistemas" class="class_error"></div>
    
    <asp:Label ID="Lbl_ComboUsuraio" runat="server" Text="Usuários:" CssClass="class_font_rotulo" Font-Size="20px" ForeColor="Black"></asp:Label>
    <asp:DropDownList ID="DDL_Usuarios" runat="server" Font-Size="Large" ForeColor="Black">
        <asp:ListItem Text="Selecione" Value="0"></asp:ListItem>
    </asp:DropDownList>
    <div id="Div_Erro_DDL_Usuarios" class="class_error"></div>

    <br />
    <asp:Button ID="Btn_Cadastro" runat="server" Text="CADASTRAR" OnClick="Btn_Cadastro_Click" Font-Bold="true" Font-Size="X-Large" />
</asp:Content>
