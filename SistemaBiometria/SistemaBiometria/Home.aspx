<%@ Page Title="" Language="C#" MasterPageFile="~/BiometriaSite.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="SistemaBiometria.Home" %>

<asp:Content ID="Conteudo" ContentPlaceHolderID="Conteudo" runat="server">
    <br />
    <br />
    <asp:Label ID="Lbl_Autorizados" runat="server" Text="Sistemas Autorizados" Font-Size="X-Large" ForeColor="Black"></asp:Label>
    <br />
    <asp:GridView ID="Gdw_Sistema" runat="server" Font-Size="X-Large" ForeColor="Black" CssClass="Grid" AutoGenerateColumns="False"
        AllowPaging="True"
        EnableModelValidation="True">
        <Columns>
            <asp:TemplateField>
                <ItemTemplate>
                    <%# Container.DataItemIndex + 1 %>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="Descricao" HeaderText="SISTEMA(S)" />
        </Columns>
        <HeaderStyle Font-Size="Smaller" />
        <PagerStyle Font-Size="Smaller" />
        <RowStyle Font-Size="Smaller" />
    </asp:GridView>
    <br />
    <asp:Label ID="Lbl_Aviso" runat="server" Visible="false" Text="Nenhum Sistemas Autorizados para esse usuário! Entre em contato com Adm." Font-Size="Large" ForeColor="Red"></asp:Label>
</asp:Content>
