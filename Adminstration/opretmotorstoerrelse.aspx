<%@ Page Title="" Language="C#" MasterPageFile="~/Adminstration/AdminMasterPage.master" AutoEventWireup="true" CodeFile="opretmotorstoerrelse.aspx.cs" Inherits="Adminstration_opretmotorstoerrelse" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <h2>Opret Motor Størrelse</h2>

    <p>Vælg Mærke:</p>

    <asp:DropDownList ID="ddlmaerke"
        runat="server"
        OnSelectedIndexChanged="ddlmaerke_SelectedIndexChanged"
        AutoPostBack="true"
        CssClass="form-control">
    </asp:DropDownList>

    <asp:Panel ID="pnlselectedmaerke" runat="server" Visible="false">

        <p style="margin-top: 5px">Vælg model:</p>
        <asp:DropDownList ID="ddlmodel"
            runat="server"
            OnSelectedIndexChanged="ddlmodel_SelectedIndexChanged"
            AutoPostBack="true"
            CssClass="form-control">
        </asp:DropDownList>

    </asp:Panel>

    <asp:Panel ID="pnlSelectedModel" runat="server" Visible="false">

        <asp:TextBox ID="txtstoerrelse" Style="margin-top: 15px" runat="server" CssClass="gen-input"></asp:TextBox>
        <asp:Button ID="btnstoerrelsesubmit" runat="server" CssClass="btn-opret" Text="Opret" OnClick="btnstoerrelsesubmit_Click" /><br />
        <asp:Literal ID="litMsg" runat="server"></asp:Literal>

    </asp:Panel>

</asp:Content>

