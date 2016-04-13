<%@ Page Title="" Language="C#" MasterPageFile="~/Adminstration/AdminMasterPage.master" AutoEventWireup="true" CodeFile="OpretMaerke.aspx.cs" Inherits="Adminstration_OpretMaerke" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <h2>Opret Bilmærke</h2>
    <p>Indtast Bil Mærke:</p>

    <asp:TextBox ID="txtinput" runat="server" CssClass="gen-input" />
    <asp:Button ID="btnsubmit" Text="Opret" runat="server" CssClass="btn-opret" OnClick="btnsubmit_Click" />
    <br />
    <asp:Literal ID="litMsg" runat="server"></asp:Literal>


</asp:Content>

