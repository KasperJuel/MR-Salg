<%@ Page Title="" Language="C#" MasterPageFile="~/Adminstration/AdminMasterPage.master" AutoEventWireup="true" CodeFile="OpretDel.aspx.cs" Inherits="Adminstration_OpretDel" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <h2>Opret Del</h2>

    <p>Vælg mærke:</p>
    <asp:DropDownList ID="ddlmaerke"
        runat="server"
        OnSelectedIndexChanged="ddlmaerke_SelectedIndexChanged"
        AutoPostBack="true"
        CssClass="form-control">
    </asp:DropDownList>



    <asp:Panel ID="pnlselectedmaerke" runat="server" Visible="false">
        <p>Vælg model:</p>
        <asp:DropDownList ID="ddlmodel"
            runat="server"
            OnSelectedIndexChanged="ddlmodel_SelectedIndexChanged"
            AutoPostBack="true"
            CssClass="form-control">
        </asp:DropDownList>
    </asp:Panel>



    <asp:Panel ID="pnlselectedModel" runat="server" Visible="false">
        <p>Vælg motor størrelse:</p>
        <asp:DropDownList ID="ddlStoerelse"
            runat="server"
            OnSelectedIndexChanged="ddlStoerelse_SelectedIndexChanged"
            AutoPostBack="true"
            CssClass="form-control">
        </asp:DropDownList>
    </asp:Panel>



    <asp:Panel ID="pnlSelectedMotorStoerelse" runat="server" Visible="false">
        <p>Vælg årgang</p>
        <asp:DropDownList ID="ddlAargang"
            runat="server"
            AutoPostBack="true"
            OnSelectedIndexChanged="ddlAargang_SelectedIndexChanged"
            CssClass="form-control">
        </asp:DropDownList>
    </asp:Panel>



    <asp:Panel ID="pnlselectedAargang" runat="server" Visible="false">    
        <br />
        <asp:Panel ID="pnlCreateEvent" runat="server" DefaultButton="btnCreate">
                <div class="col-md-12">
                    <div class="panel panel-primary">
                        <div class="panel-heading">
                            <h3 class="panel-title">dele</h3>
                        </div>
                        <table class="table table-hover" id="Table1">
                            <thead>
                                <tr>
                                    <th>del</th>
                                    <th></th>
                                </tr>
                            </thead>
                            <tbody>
                                <asp:Panel ID="pan_content" runat="server"></asp:Panel>


                                <tr>
                                    <td>
                                        <asp:Button ID="btnminus" CssClass="btn btn-default" Text="remove row" runat="server" OnClick="btnminus_Click" />
                                        <asp:Button ID="btnplus" CssClass="btn btn-default" Text="Add row" runat="server" OnClick="btnplus_Click" /></td>
                                    <td></td>
                                    <td></td>
                                    <td></td>
                                    <td>
                                        <asp:Literal ID="litmsgcreate" runat="server"></asp:Literal><asp:Button ID="btnCreate" CssClass="btn btn-primary pull-right" ValidationGroup="validate" runat="server" OnClick="btnCreate_Click" Text="Create" /></td>
                               </tr>
                            </tbody>
                        </table>
                    </div>
                </div>
             <asp:Literal ID="litMsg" runat="server"></asp:Literal>
            </asp:Panel>
            <asp:HiddenField runat="server" ID="hfPosition" Value="" />

            <!--Create table end-->
<%--        <p>Vælg Kategori</p>
        <asp:DropDownList ID="ddlKat"
            runat="server"
            AutoPostBack="true"
            OnSelectedIndexChanged="ddlKat_SelectedIndexChanged"
            CssClass="form-control">
        </asp:DropDownList>--%>

    </asp:Panel>

    <asp:Panel ID="pnlselectedKategori" runat="server" Visible="false">

    </asp:Panel>
    <div class="clear"></div>


</asp:Content>

