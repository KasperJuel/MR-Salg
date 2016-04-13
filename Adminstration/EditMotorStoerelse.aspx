<%@ Page Title="" Language="C#" MasterPageFile="~/Adminstration/AdminMasterPage.master" AutoEventWireup="true" CodeFile="EditMotorStoerelse.aspx.cs" Inherits="Adminstration_EditMotorStoerelse" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <h2>Rediger Motorstørrelse</h2>

    <p>vælg mærke:</p>

    <asp:DropDownList ID="ddlmaerke" runat="server" OnSelectedIndexChanged="ddlmaerke_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>

    <asp:Panel ID="pnlselectedmaerke" runat="server" Visible="false">

        <p>Vælg model:</p>
        <asp:DropDownList ID="ddlmodel" runat="server" OnSelectedIndexChanged="ddlmodel_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>

    </asp:Panel>

    <asp:Panel ID="pnlselectedModel" runat="server" Visible="false">

        <p>Vælg størrelse som skal ændres:</p>
        <asp:DropDownList ID="ddlStoerelse" runat="server" OnSelectedIndexChanged="ddlStoerelse_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>

    </asp:Panel>

    <asp:Panel ID="pnlSelectedMotorStoerelse" runat="server" Visible="false">

        <p>Indtast hvad størrelsen skal ændres til</p>
        <asp:TextBox ID="txtRedigerMotorstoerelse" runat="server" CssClass="gen-input"></asp:TextBox>
        <asp:Button ID="btnRedigerMotorstoerelseSubmit" runat="server" Text="Rediger" OnClick="btnRedigerMotorstoerelseSubmit_Click" CssClass="btn-opret" /><br />
        <asp:Literal ID="litmsg" runat="server"></asp:Literal>

    </asp:Panel>

    <p style="margin-top: 5px"><a href="Default.aspx" target="_blank">Åben oversigt <b>(i nyt vindue)</b></a></p>


</asp:Content>

