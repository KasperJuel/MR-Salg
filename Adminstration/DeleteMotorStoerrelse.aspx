<%@ Page Title="" Language="C#" MasterPageFile="~/Adminstration/AdminMasterPage.master" AutoEventWireup="true" CodeFile="DeleteMotorStoerrelse.aspx.cs" Inherits="Adminstration_DeleteMotorStoerrelse" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h1>SLET MOTORSTØRRELSE</h1>
    <p>vælg mærke:</p>
    <asp:DropDownList ID="ddlmaerke" runat="server" OnSelectedIndexChanged="ddlmaerke_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
    <hr />

    <asp:Panel ID="pnlselectedmaerke" runat="server" Visible="false">
        <p>Vælg model:</p>
        <asp:DropDownList ID="ddlmodel" runat="server" OnSelectedIndexChanged="ddlmodel_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
    </asp:Panel>
    <hr />

    <asp:Panel ID="pnlselectedModel" runat="server" Visible="false">
        <p>vælg størrelse:</p>
        <asp:DropDownList ID="ddlStoerelse" runat="server" AutoPostBack="true"></asp:DropDownList>
        <asp:Button ID="btnRedigerMotorstoerelseSubmit" runat="server" Text="slet" OnClick="btnRedigerMotorstoerelseSubmit_Click" />
    <asp:Literal ID="litmsg" runat="server"></asp:Literal>
    </asp:Panel>
    
 
        
        
        
</asp:Content>

