<%@ Page Title="" Language="C#" MasterPageFile="~/Adminstration/AdminMasterPage.master" AutoEventWireup="true" CodeFile="DeleOversigt.aspx.cs" Inherits="Adminstration_DeleOversigt" %>

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

    <h2>Dele Oversigt</h2>

    <table id="oversigt" class="display" cellspacing="0">
        <thead>
            <tr>
                <th>Mærke</th>
                <th>Model</th>
                <th>Årgang</th>
                <th>Motor Størrelse</th>
                <th>Del navn</th>
                <th>Vis</th>
            </tr>
        </thead>

        <tbody>
            <asp:Literal ID="litResult" runat="server" />
        </tbody>

    </table>

</asp:Content>

