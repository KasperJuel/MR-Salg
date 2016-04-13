<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Login.ascx.cs" Inherits="login" %>
<h1>Login</h1>
<asp:Panel ID="panLog" DefaultButton="btnSubmit" runat="server">
<asp:TextBox ID="txtUsername" PlaceHolder="Brugernavn" runat="server" CssClass="input-style-gen"></asp:TextBox>
<br />
<asp:TextBox ID="txtPassword" PlaceHolder="Password" TextMode="Password" runat="server" CssClass="input-style-gen"></asp:TextBox>
<br />
    <br />
<asp:Button ID="btnSubmit" runat="server" Text="Login" OnClick="btnSubmit_Click" CssClass="btn-style-gen" />
<br />
<asp:Literal ID="litMsg" runat="server"></asp:Literal>

</asp:Panel>

