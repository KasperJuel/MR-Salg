<%@ Page Title="" Language="C#" MasterPageFile="~/Adminstration/AdminMasterPage.master" AutoEventWireup="true" CodeFile="editmaerke.aspx.cs" Inherits="Adminstration_editmaerke" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <h2>Rediger Mærke</h2>

    <p>Vælg mærke:</p>

    <asp:DropDownList ID="ddlmearke" runat="server" OnSelectedIndexChanged="ddlmearke_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>

    <asp:Panel ID="pnlSelectedeMaerke" Visible="false" runat="server">

        <p>Indtast hvad mærke skal ændres til:</p>
        <asp:TextBox ID="txtredigermaerke" PlaceHolder="Ret mærke" runat="server" CssClass="gen-input"></asp:TextBox>
        <asp:Button ID="btnSubmitMaerke" Text="Rediger" runat="server" OnClick="btnSubmitMaerke_Click" CssClass="btn-opret" /><br />
        <asp:Literal ID="litmsg" runat="server"></asp:Literal>

    </asp:Panel>

    <p style="margin-top: 5px"><a href="Default.aspx" target="_blank">Åben oversigt <b>(i nyt vindue)</b></a></p>


</asp:Content>

