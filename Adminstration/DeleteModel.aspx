<%@ Page Title="" Language="C#" MasterPageFile="~/Adminstration/AdminMasterPage.master" AutoEventWireup="true" CodeFile="DeleteModel.aspx.cs" Inherits="DeleteModel" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h1>SLET MODEL</h1>
    <p>vælg mærke:</p>
    <asp:DropDownList id="ddlmaerke" runat="server" OnSelectedIndexChanged="ddlmaerke_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
    <asp:Panel ID="pnlselectedmaerke" runat="server" Visible="false">
        <hr />
        <p>Vælg model:</p>
    <asp:DropDownList ID="ddlmodel" runat="server" AutoPostBack="true"></asp:DropDownList>
    <asp:Button ID="btnRedigerModelSubmit" runat="server" Text="send" OnClick="btnRedigerModelSubmit_Click" />
    <asp:Literal ID="litmsg" runat="server"></asp:Literal>
        </asp:Panel>
</asp:Content>

