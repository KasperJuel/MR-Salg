<%@ Page Title="" Language="C#" MasterPageFile="~/Adminstration/AdminMasterPage.master" AutoEventWireup="true" CodeFile="DeleteMaerke.aspx.cs" Inherits="Adminstration_DeleteMaerke" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h1>SLET MÆRKE</h1>
    <asp:DropDownList id="ddlmearke" runat="server" AutoPostBack="true"></asp:DropDownList>                    
    <asp:Button ID="btnSubmitModel" Text="send" runat="server" OnClick="btnSubmitModel_Click" />
        <asp:Literal ID="litmsg" runat="server"></asp:Literal>
      
</asp:Content>

