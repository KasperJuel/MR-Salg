<%@ Page Title="" Language="C#" MasterPageFile="~/Adminstration/AdminMasterPage.master" AutoEventWireup="true" CodeFile="opretAargang.aspx.cs" Inherits="Adminstration_opretAargang" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <script type="text/javascript">

        //script til datatables
        $(document).ready(function () {
            $('#DataTable').DataTable();
        });



    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <h2>Opret Årgang</h2>

    <p>Vælg Mærke:</p>
    <asp:DropDownList ID="ddlmaerke"
        runat="server"
        OnSelectedIndexChanged="ddlmaerke_SelectedIndexChanged"
        AutoPostBack="true"
        CssClass="form-control">
    </asp:DropDownList>

    <asp:Panel ID="pnlselectedmaerke" runat="server" Visible="false">
        <p>Vælg Model:</p>
        <asp:DropDownList ID="ddlmodel"
            runat="server"
            OnSelectedIndexChanged="ddlmodel_SelectedIndexChanged"
            AutoPostBack="true"
            CssClass="form-control">
        </asp:DropDownList>
    </asp:Panel>

    <asp:Panel ID="pnlselectedModel" runat="server" Visible="false">
        <p>Vælg Motor Størrelse:</p>
        <asp:DropDownList ID="ddlStoerelse"
            runat="server"
            OnSelectedIndexChanged="ddlStoerelse_SelectedIndexChanged"
            AutoPostBack="true"
            CssClass="form-control">
        </asp:DropDownList>
    </asp:Panel>
    <br />
    <asp:Panel ID="pnlSelectedMotorStoerelse" runat="server" Visible="false">
        <!--Create table start-->
        <asp:Panel ID="pnlCreateEvent" runat="server" DefaultButton="btnCreate">
            <div class="col-md-6">
                <div class="panel panel-primary">
                    <div class="panel-heading">
                        <h3 class="panel-title">Årgang</h3>
                    </div>
                    <table class="table table-hover" id="Table1">
                        <thead>
                            <tr>
                                <th>Årgang</th>
                                <th></th>
                            </tr>
                        </thead>
                        <tbody>
                            <asp:Panel ID="pan_content" runat="server"></asp:Panel>


                            <tr>
                                <td>
                                    <asp:Button ID="btnminus" CssClass="btn btn-default" Text="remove row" runat="server" OnClick="btnminus_Click" />
                                    <asp:Button ID="btnplus" CssClass="btn btn-default" Text="Add row" runat="server" OnClick="btnplus_Click" /></td>

                                <td>
                                    <asp:Literal ID="litmsgcreate" runat="server"></asp:Literal><asp:Button ID="btnCreate" CssClass="btn btn-primary pull-right" ValidationGroup="validate" runat="server" OnClick="btnCreate_Click" Text="Create" /></td>
                            </tr>
                        </tbody>
                    </table>
                </div>
            </div>

        </asp:Panel>
        <!--Create table end-->
    </asp:Panel>
    <div class="clear"></div>


</asp:Content>

