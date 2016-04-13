<%@ Page Title="" Language="C#" MasterPageFile="~/Adminstration/AdminMasterPage.master" AutoEventWireup="true" CodeFile="OpretModel.aspx.cs" Inherits="Adminstration_OpretModel" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <h2>Opret Model</h2>

    <asp:DropDownList ID="ddlmearke"
        Style="margin-bottom: 5px"
        runat="server"
        OnSelectedIndexChanged="ddlmearke_SelectedIndexChanged"
        AutoPostBack="true"
        CssClass="form-control">
    </asp:DropDownList>
    <asp:Panel ID="pnlSelectedeMaerke" Visible="false" runat="server">

        <p>Indtast Model</p>

        <asp:TextBox ID="txtModel" PlaceHolder="model" runat="server" CssClass="gen-input"></asp:TextBox>
        <asp:Button ID="btnSubmitModel" Text="Opret" runat="server" OnClick="btnSubmitModel_Click" CssClass="btn-opret" />
        <br />
        <asp:Literal ID="litmsg" runat="server"></asp:Literal>


    </asp:Panel>


</asp:Content>

