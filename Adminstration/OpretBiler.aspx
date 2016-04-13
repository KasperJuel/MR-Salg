<%@ Page Title="" Language="C#" MasterPageFile="~/Adminstration/AdminMasterPage.master" AutoEventWireup="true" CodeFile="OpretBiler.aspx.cs" Inherits="Adminstration_OpretBiler" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h1>OPRET BILMÆRKE</h1>
    <asp:Panel ID="pan_content" runat="server">

    </asp:Panel>
   
    <asp:Button ID="btnplus" Text="plus" runat="server" OnClick="btnplus_Click" />                      
    <asp:Button ID="btnsubmit" Text="send" ValidationGroup="test" runat="server" OnClick="btnsubmit_Click" />

    <asp:Literal ID="litmsg" runat="server"></asp:Literal>
</asp:Content>

 