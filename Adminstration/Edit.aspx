<%@ Page Title="" Language="C#" MasterPageFile="~/Adminstration/AdminMasterPage.master" AutoEventWireup="true" CodeFile="Edit.aspx.cs" Inherits="Adminstration_Edit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <h1>Ret Del</h1>

    <div id="left-column">
        <asp:TextBox ID="txtMaerkeID" runat="server" Visible="false" />

        <asp:TextBox ID="txtModelID" runat="server" Visible="false" />

        Mærke:
    <br />
        <asp:TextBox ID="txtMaerke" runat="server" Enabled="false" CssClass="gen-input" /><br />

        Model:
    <br />
        <asp:TextBox ID="txtModel" runat="server" Enabled="false" CssClass="gen-input" /><br />

        Motor Størelse:
    <br />
        <asp:TextBox ID="txtMotorStoerlse" runat="server" Enabled="false" CssClass="gen-input" /><br />

        Årgang:
    <br />
        <asp:TextBox ID="txtAargang" runat="server" Enabled="false" CssClass="gen-input" /><br />
        <br />
        <p>OBS. Disse felter kan IKKE redigeres her! </p>
        <p>Brug navigationen "Rediger Diverse" og rediger felterne individuelt.</p>
    </div>

    <div id="right-column">
        Dele:
    <br />
        <asp:TextBox ID="txtDelNavn" runat="server" CssClass="gen-input" /><br />

        Tekst:
    <br />
        <asp:TextBox ID="txtDelTekst" runat="server" TextMode="MultiLine" CssClass="gen-input" Height="200px" /><br />

        Antal:
    <br />
        <asp:TextBox ID="txtDelAntal" runat="server" CssClass="gen-input" /><br />

        Pris:
    <br />
        <asp:TextBox ID="txtDelPris" runat="server" CssClass="gen-input" /><br />

        Nuværende billede:
    <br />
        <asp:Image ID="currentImg" runat="server" />

        <asp:FileUpload ID="fuImg" runat="server" AllowMultiple="false" /><br />

        <asp:Button ID="btnEdit" runat="server" Text="Rediger" OnClick="btnEdit_Click" />

        <asp:Literal ID="litResult" runat="server" />

        <asp:HyperLink NavigateUrl="~/Adminstration/DeleOversigt.aspx" runat="server" Text="Tilbage til oversigt" />
    </div>
    <div class="clear"></div>
</asp:Content>

