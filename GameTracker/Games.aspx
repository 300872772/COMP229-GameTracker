<%@ Page Title="Games" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Games.aspx.cs" Inherits="GameTracker.Pages.Games" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="row">



            <div class="containerDecorationMatch">
                <h1>Matches</h1>
                <div class="row">

                    <div class="col-sm-4">
                        <h3 id="matchDate" runat="server">Today</h3>
                    </div>
                    <div class="col-sm-4">
                        <h3 id="tournament" runat="server"></h3>
                    </div>
                    <div class="col-sm-4">
                        <h3 id="matchWeek" runat="server"></h3>
                    </div>
                </div>
                <br>
                <div class="containerDecorationMatchTitle">



                    <div id="gameData" runat="server">
                        <asp:GridView ID='MatchGridView' runat='server' AutoGenerateColumns='false'
                            CssClass='table table-bordered table-striped table-hover' OnRowDataBound="MatchGridView_RowDataBound"
                            OnSelectedIndexChanging="GridView_OnSelectedIndexChanging">

                            <Columns>
                                <asp:BoundField HeaderText="Match ID" DataField="MatchId" ItemStyle-CssClass="hiddencol" HeaderStyle-CssClass="hiddencol"></asp:BoundField>

                                <asp:TemplateField HeaderStyle-HorizontalAlign='Center' />
                                <asp:BoundField DataField='MatchDate' HeaderText='Match Date' Visible='true' SortExpression='MatchDate' />
                                <asp:ImageField DataImageUrlField="Flag1">
                                    <ControlStyle CssClass="BotonDeImagen" />
                                    <ItemStyle HorizontalAlign="Center" />
                                </asp:ImageField>
                                <asp:BoundField DataField='TeamName1' HeaderText='Team 1' Visible='true' SortExpression='Team1' />


                                <asp:BoundField DataField='Result' HeaderText='Result' Visible='true' SortExpression='Result'></asp:BoundField>
                                <asp:BoundField DataField='TeamName2' HeaderText='Team 2' Visible='true' SortExpression='Team2' />
                                <asp:ImageField DataImageUrlField="Flag2">
                                    <ControlStyle CssClass="BotonDeImagen" />
                                </asp:ImageField>






                            </Columns>
                        </asp:GridView>

                    </div>

                </div>
            </div>

            <div id="Div1" runat="server">
            </div>
        </div>
    </div>
</asp:Content>
