<%@ Page Title="" Language="C#" MasterPageFile="~/Adminstration/AdminMasterPage.master" AutoEventWireup="true" CodeFile="EditHandelsbetingelser.aspx.cs" Inherits="Adminstration_EditHandelsbetingelser" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <h2>Handelsbetingelser</h2>

    <asp:TextBox ID="txtBetingelser" runat="server" TextMode="MultiLine" CssClass="gen-input" style="height: 400px; width: 800px;"></asp:TextBox><br />
    <asp:Button ID="btnEdit" runat="server" Text="Rediger" OnClick="btnEdit_Click" />

</asp:Content>

