<%@ Control Language="C#" AutoEventWireup="true" CodeFile="CreateUser.ascx.cs" Inherits="CreateUser" %>
<h1>Opret Bruger</h1>
<asp:Panel ID="panUser" DefaultButton="btnSubmit" runat="server">
    <asp:TextBox ID="txtUsername" PlaceHolder="Brugernavn" runat="server" CssClass="input-style-gen"></asp:TextBox>
    <br />
    <asp:TextBox ID="txtPassword" PlaceHolder="Password" TextMode="Password" runat="server" CssClass="input-style-gen"></asp:TextBox>
    <br />
    <asp:TextBox ID="txtCheckPassword" PlaceHolder="Gentag Password" TextMode="Password" runat="server" CssClass="input-style-gen"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="btnSubmit" TextMode="Password" runat="server" Text="Opret" OnClick="btnSubmit_Click"  CssClass="btn-style-gen"/>
    <asp:Literal ID="litMsg" runat="server"></asp:Literal>
    <hr />
</asp:Panel>



