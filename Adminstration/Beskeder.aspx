<%@ Page Title="" Language="C#" MasterPageFile="~/Adminstration/AdminMasterPage.master" AutoEventWireup="true" CodeFile="Beskeder.aspx.cs" Inherits="Adminstration_Beskeder" %>

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

    <h1>Beskeder</h1>

    <p>Her kan du læse beskeder sendt fra Kontakt siden.
        <br />
        OBS, slet beskeder når de er læst, indtil jeg finder en løsning på hvordan man kan markere dem læst og ulæst ;-)</p>

        <table id="oversigt" class="display" cellspacing="0">
        <thead>
            <tr>
                <th>Dato for modtagelse</th>
                <th>Afsenders navn</th>
                <th>E-Mail</th>
                <th>Besked</th>
                <th>Slet Besked</th>
            </tr>
        </thead>

        <tbody>
            <asp:Literal ID="litResult" runat="server" />
        </tbody>


</asp:Content>

