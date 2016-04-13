<%@ Page Title="" Language="C#" MasterPageFile="~/Adminstration/AdminMasterPage.master" AutoEventWireup="true" CodeFile="OpretKategori.aspx.cs" Inherits="Adminstration_OpretKategori" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">

    <!-- DataTables CSS -->
    <link rel="stylesheet" type="text/css" href="//cdn.datatables.net/1.10.4/css/jquery.dataTables.css">

    <!-- jQuery -->
    <script type="text/javascript" charset="utf8" src="//code.jquery.com/jquery-1.10.2.min.js"></script>

    <!-- DataTables -->
    <script type="text/javascript" charset="utf8" src="//cdn.datatables.net/1.10.4/js/jquery.dataTables.js"></script>

    <script type="text/javascript">

        $(document).ready(function () {

            $('#oversigt').dataTable({
            });
        });

    </script>


</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <h1>Opret Kategori</h1>

    <p>Opret dine kategorier her:</p>

    <asp:TextBox ID="txtKat" runat="server" placeholder="Kategori" CssClass="gen-input"></asp:TextBox>
    <asp:Button ID="btnOpret" runat="server" Text="Opret" OnClick="btnOpret_Click" CssClass="btn-opret" /><br />

    <asp:Literal ID="litMsg" runat="server" />
    <hr />

    <h1>Kategori Oversigt</h1>

    <p>Rediger og slet dine kategorier her:</p>

    <table id="oversigt" class="display" cellspacing="0">
        <thead>
            <tr>
                <th>Kategori</th>
                <th>Rediger</th>
                <th>Slet</th>
            </tr>
        </thead>

        <tbody>
            <asp:Literal ID="litResult" runat="server" />
        </tbody>

    </table>

</asp:Content>

