<%@ Page Title="" Language="C#" MasterPageFile="~/Adminstration/AdminMasterPage.master" AutoEventWireup="true" CodeFile="DeleteAargang.aspx.cs" Inherits="Adminstration_DeleteAargang" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <h1>SLET ÅRGANG</h1>
    <p>vælgmærke:</p>
    <asp:DropDownList ID="ddlmaerke" runat="server" OnSelectedIndexChanged="ddlmaerke_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
    <hr />

    <asp:Panel ID="pnlselectedmaerke" runat="server" Visible="false">
        <p>Vælg model:</p>
        <asp:DropDownList ID="ddlmodel" runat="server" OnSelectedIndexChanged="ddlmodel_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
    </asp:Panel>
    <hr />
    <asp:Panel ID="pnlselectedModel" runat="server" Visible="false">
        <p>vælg størrelse:</p>
        <asp:DropDownList ID="ddlStoerelse" runat="server" OnSelectedIndexChanged="ddlStoerelse_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
    </asp:Panel>
    <hr />
    <asp:Panel ID="pnlSelectedMotorStoerelse" runat="server" Visible="false">
        <p>vælg Årgang:</p>
        <asp:DropDownList ID="ddlAargang" runat="server" AutoPostBack="true"></asp:DropDownList>
        <asp:Button ID="btnRedigerAargangSubmit" runat="server" Text="send" OnClick="btnRedigerAargangSubmit_Click" />
        <asp:Literal ID="litmsg" runat="server"></asp:Literal>
    </asp:Panel>
</asp:Content>

