<%@ Page Title="" Language="C#" MasterPageFile="~/Adminstration/AdminMasterPage.master" AutoEventWireup="true" CodeFile="Martin.aspx.cs" Inherits="Adminstration_Martin" %>

<%@ Register Src="~/Adminstration/Login.ascx" TagPrefix="uc1" TagName="Login" %>



<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <div id="login">
        <uc1:Login runat="server" ID="Login" />
    </div>

</asp:Content>

