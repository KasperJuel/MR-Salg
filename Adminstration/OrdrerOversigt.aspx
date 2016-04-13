<%@ Page Title="" Language="C#" MasterPageFile="~/Adminstration/AdminMasterPage.master" AutoEventWireup="true" CodeFile="OrdrerOversigt.aspx.cs" Inherits="Adminstration_OrdrerOversigt" %>

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

    <h2>Ordrer Oversigt</h2>
    <br />
    <p>Tjek dine ordrer her. Klik på afslut når ordren er færdig - vær OBS, dette vil <b>slette</b> ordren!</p>

    <table id="oversigt" class="display" cellspacing="0">
        <thead>
            <tr>
                <th>Id</th>
                <th>Dato</th>
                <th>Kunde Navn</th>
                <th>Adresse</th>
                <th>Postnr</th>
                <th>By</th>
                <th>Mail</th>
                <th>Antal</th>
                <th>Del</th>
                <th>Afslut order</th>
            </tr>
        </thead>

        <tbody>
            <asp:Literal ID="litResult" runat="server" />
        </tbody>

    </table>


</asp:Content>

