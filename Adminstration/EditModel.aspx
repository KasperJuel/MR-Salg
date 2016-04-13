<%@ Page Title="" Language="C#" MasterPageFile="~/Adminstration/AdminMasterPage.master" AutoEventWireup="true" CodeFile="EditModel.aspx.cs" Inherits="Adminstration_EditModel" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <h2>Rediger Model</h2>

    <p>Vælg mærke:</p>

    <asp:DropDownList ID="ddlmaerke" runat="server" OnSelectedIndexChanged="ddlmaerke_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>

    <asp:Panel ID="pnlselectedmaerke" runat="server" Visible="false">

        <p>Vælg model:</p>
        <asp:DropDownList ID="ddlmodel" runat="server" OnSelectedIndexChanged="ddlmodel_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
    </asp:Panel>

    <asp:Panel ID="pnlSelectedModel" runat="server" Visible="false">

        <p>Indtast hvad model skal ændre til:</p>
        <asp:TextBox ID="txtRedigerModel" runat="server" CssClass="gen-input"></asp:TextBox>
        <asp:Button ID="btnRedigerModelSubmit" runat="server" Text="Rediger" CssClass="btn-opret" OnClick="btnRedigerModelSubmit_Click" /><br />
        <asp:Literal ID="litmsg" runat="server"></asp:Literal>

    </asp:Panel>

    <p style="margin-top: 5px"><a href="Default.aspx" target="_blank">Åben oversigt <b>(i nyt vindue)</b></a></p>


</asp:Content>

