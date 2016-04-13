<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">


    <div id="top-content">
        <div id="ddl-content">
            <div id="list">

                <div class="dropdown">
                    <h3>Vælg din bil</h3>
                    <asp:Literal ID="litDdlError" runat="server" />
                    <asp:DropDownList ID="ddlMaerke"
                        AutoPostBack="true"
                        CssClass="form-control"
                        Style="margin-top: 10px"
                        runat="server"
                        OnSelectedIndexChanged="ddlMaerke_SelectedIndexChanged">
                    </asp:DropDownList>

                    <asp:Panel ID="pnlModel" runat="server" Visible="false">
                        <asp:DropDownList ID="ddlModel"
                            AutoPostBack="true"
                            CssClass="form-control"
                            Style="margin-top: 10px; margin-bottom: 10px;"
                            runat="server"
                            OnSelectedIndexChanged="ddlModel_SelectedIndexChanged">
                        </asp:DropDownList>
                    </asp:Panel>

                    <asp:Panel ID="pnlMotor" runat="server" Visible="false">
                        <asp:DropDownList ID="ddlMotorStoerelse"
                            AutoPostBack="true"
                            CssClass="form-control"
                            runat="server"
                            OnSelectedIndexChanged="ddlMotorStoerelse_SelectedIndexChanged">
                        </asp:DropDownList>
                    </asp:Panel>

                    <asp:Panel ID="pnlAargang" runat="server" Visible="false">
                        <asp:DropDownList ID="ddlAargang"
                            AutoPostBack="true"
                            Style="margin-top: 10px"
                            CssClass="form-control"
                            runat="server">
                        </asp:DropDownList>
                    </asp:Panel>
                </div>

                <asp:Button ID="btnSoeg"
                    Text="Søg"
                    CssClass="btn-find-del"
                    runat="server" OnClick="btnSoeg_Click" />
            </div>
        </div>

        <div id="slider">
            <img src="Images/slide-test.jpg" alt="Velkommen" width="650" />
        </div>
    </div>
    <div class="clear"></div>


    <asp:Panel ID="pnlSeneste" runat="server" Visible="true">

        <div id="seneste-prod-headline">
            <h3>Seneste tilføjede dele:</h3>
        </div>
        <asp:Literal ID="litSeneste" runat="server" />


    </asp:Panel>
</asp:Content>

