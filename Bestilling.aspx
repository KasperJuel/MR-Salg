<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Bestilling.aspx.cs" Inherits="Bestilling" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <h3 id="bestil-del-headline">Dine oplysninger:</h3>

    <div id="bestilling-oversigt">
        <div id="bestilling-form">
            <h2 style="margin-bottom: 10px;">Udfyld venligst:</h2>

            <asp:TextBox ID="txtNavn"
                runat="server"
                placeholder="Navn"
                CssClass="input-gen"></asp:TextBox><br />

            <asp:TextBox ID="txtAdresse"
                runat="server"
                placeholder="Adresse"
                CssClass="input-gen"></asp:TextBox><br />

            <asp:TextBox ID="txtPostnr"
                runat="server"
                placeholder="Postnummer"
                CssClass="input-bestilling-postnr"
                ValidationGroup="opretOrder"></asp:TextBox>

            <asp:TextBox ID="txtBy"
                runat="server"
                placeholder="By"
                CssClass="input-bestilling-by"></asp:TextBox><br />

            <asp:TextBox ID="txtMail"
                runat="server"
                placeholder="E-mail"
                CssClass="input-gen"
                ValidationGroup="opretOrder"></asp:TextBox><br />

            <asp:TextBox ID="txtAntal"
                runat="server"
                placeholder="Antal"
                CssClass="input-gen"
                ValidationGroup="opretOrder"></asp:TextBox>

            <asp:Button ID="btnBestil"
                runat="server"
                Text="Send"
                OnClick="btnBestil_Click"
                CssClass="btn-send" ValidationGroup="test"
                style="margin-bottom: 5px;" />

            <asp:Literal ID="litMsg" runat="server" />
        </div>
            <h2>Dit Valgte Produkt:</h2>

        <div id="bestilling-info">
            <asp:Literal ID="litBestilling" runat="server" />
        </div>
    </div>

</asp:Content>

