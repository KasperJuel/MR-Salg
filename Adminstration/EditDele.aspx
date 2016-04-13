<%@ Page Title="" Language="C#" MasterPageFile="~/Adminstration/AdminMasterPage.master" AutoEventWireup="true" CodeFile="EditDele.aspx.cs" Inherits="Adminstration_EditDele" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <h2>REDIGER DELE</h2>

    <p>Vælg mærke:</p>

    <asp:DropDownList ID="ddlmaerke" runat="server" 
        OnSelectedIndexChanged="ddlmaerke_SelectedIndexChanged" 
        AutoPostBack="true">
    </asp:DropDownList>

    <asp:Panel ID="pnlselectedmaerke" runat="server" Visible="false">

        <p>Vælg model:</p>
        <asp:DropDownList ID="ddlmodel" runat="server" 
            OnSelectedIndexChanged="ddlmodel_SelectedIndexChanged" 
            AutoPostBack="true">
        </asp:DropDownList>

    </asp:Panel>

    <asp:Panel ID="pnlselectedModel" runat="server" Visible="false">

        <p>Vælg størrelse:</p>
        <asp:DropDownList ID="ddlStoerelse" runat="server" 
            OnSelectedIndexChanged="ddlStoerelse_SelectedIndexChanged" 
            AutoPostBack="true">
        </asp:DropDownList>

    </asp:Panel>

    <asp:Panel ID="pnlSelectedMotorStoerelse" runat="server" Visible="false">

        <p>Vælg Årgang:</p>
        <asp:DropDownList ID="ddlAargang" runat="server" 
            OnSelectedIndexChanged="ddlAargang_SelectedIndexChanged" 
            AutoPostBack="true">
        </asp:DropDownList>

    </asp:Panel>

    <asp:Panel ID="pnlSelectedAargang" runat="server" Visible="false">

        <p>Vælg Del</p>
        <asp:DropDownList ID="ddlDel" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlDel_SelectedIndexChanged"></asp:DropDownList>
        <p>Indtast hvad du vil ændre del til:</p>

        <asp:TextBox ID="txtDelNavn" placeholder="Rediger Del Navn" runat="server" Style="margin-top: 5px" CssClass="gen-input"></asp:TextBox><br />
        <asp:TextBox ID="txtDelTekst" placeholder="Rediger Teksten" Style="height: 200px; margin-top: 5px" CssClass="gen-input" runat="server" TextMode="MultiLine"></asp:TextBox><br />
        <asp:TextBox ID="txtDelAntal" placeholder="Rediger Antallet" CssClass="gen-input" runat="server"></asp:TextBox><br />
        <asp:TextBox ID="txtDelPris" placeholder="Rediger Pris" Style="margin-top: 5px; margin-bottom: 5px" CssClass="gen-input" runat="server"></asp:TextBox><br />
        <asp:Image ID="currentImg" runat="server" />
        <p>
            Nuværende billede, vælg andet for at skifte billede
        <asp:FileUpload ID="fuImg" runat="server" AllowMultiple="false" />
        </p>
        <asp:Button ID="btnRedigerDelSubmit" runat="server" Text="send" OnClick="btnRedigerDelSubmit_Click" /><br />
        <asp:Literal ID="litmsg" runat="server" />

    </asp:Panel>


</asp:Content>

