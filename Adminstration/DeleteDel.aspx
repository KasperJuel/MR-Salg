<%@ Page Title="" Language="C#" MasterPageFile="~/Adminstration/AdminMasterPage.master" AutoEventWireup="true" CodeFile="DeleteDel.aspx.cs" Inherits="DeleteDel" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h1>SLET DEL</h1>
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
        <asp:DropDownList ID="ddlAargang" runat="server" OnSelectedIndexChanged="ddlAargang_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
    </asp:Panel>
    <hr />
    <asp:Panel ID="pnlSelectedAargang" runat="server" Visible="false">
        <p>Vælg Del</p>
        <asp:DropDownList ID="ddlDel" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlDel_SelectedIndexChanged"></asp:DropDownList>
        <p>Indtast hvad du vil ændre del til:</p>
        
        <asp:Literal ID="litmsg" runat="server" />
        <asp:Button ID="btnRedigerDelSubmit" runat="server" Text="slet" OnClick="btnRedigerDelSubmit_Click" />
    </asp:Panel>
</asp:Content>

