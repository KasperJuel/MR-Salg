<%@ Page Title="" Language="C#" MasterPageFile="~/Adminstration/AdminMasterPage.master" AutoEventWireup="true" CodeFile="EditAargang.aspx.cs" Inherits="Adminstration_EditAargang" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <h2>Rediger Årgang</h2>

    <p>Vælg mærke:</p>

    <asp:DropDownList ID="ddlmaerke" runat="server" OnSelectedIndexChanged="ddlmaerke_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>

    <asp:Panel ID="pnlselectedmaerke" runat="server" Visible="false">

        <p>Vælg model:</p>
        <asp:DropDownList ID="ddlmodel" runat="server" OnSelectedIndexChanged="ddlmodel_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>

    </asp:Panel>

    <asp:Panel ID="pnlselectedModel" runat="server" Visible="false">

        <p>Vælg størrelse:</p>
        <asp:DropDownList ID="ddlStoerelse" runat="server" OnSelectedIndexChanged="ddlStoerelse_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>

    </asp:Panel>

    <asp:Panel ID="pnlSelectedMotorStoerelse" runat="server" Visible="false">

        <p>Vælg Årgang:</p>
        <asp:DropDownList ID="ddlAargang" runat="server" OnSelectedIndexChanged="ddlAargang_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>

    </asp:Panel>

    <asp:Panel ID="pnlSelectedAargang" runat="server" Visible="false">

        <p>Indtast hvad årgang skal ændres til:</p>
        <asp:TextBox ID="txtRedigerAargang" runat="server" CssClass="gen-input"></asp:TextBox>
        <asp:Button ID="btnRedigerAargangSubmit" runat="server" Text="send" OnClick="btnRedigerAargangSubmit_Click" CssClass="btn-opret" /><br />
        <asp:Literal ID="litmsg" runat="server"></asp:Literal>

    </asp:Panel>


</asp:Content>

