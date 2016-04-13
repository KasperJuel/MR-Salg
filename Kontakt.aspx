<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Kontakt.aspx.cs" Inherits="Kontakt" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <h2 id="kontakt-headliner">Kontakt</h2>

    <div id="kontakt-content">

        <p style="margin-bottom: 20px;">Hvis du har nogle spørgsmål, eller søger en bestemt del kan du kontakte mig her. Jeg kan skaffe dele hjem inden for 1-2 hverdage.<br /> Du er også velkommen til at kontakte mig via. telefon på <b>27857100</b>. Efterlad evt. dit telefonnummer i beskeden, hvis du vil have jeg ringer dig op.</p>

        <asp:TextBox ID="txtNavn" 
            runat="server"
            placeholder="Navn"
            CssClass="input-gen"></asp:TextBox><br />

        <asp:TextBox ID="txtMail" 
            runat="server"
            placeholder="E-Mail"
            CssClass="input-gen"
            TextMode="Email"></asp:TextBox><br />

        <asp:TextBox ID="txtBesked" 
            runat="server" 
            TextMode="MultiLine"
            placeholder="Din besked"
            CssClass="input-gen-multi"
            ></asp:TextBox><br />

        <asp:Button ID="btnSend" runat="server" Text="Send" OnClick="btnSend_Click" CssClass="btn-send" style="margin-bottom: 5px;" />
        <asp:Literal ID="litMsg" runat="server" />
    </div>

</asp:Content>

