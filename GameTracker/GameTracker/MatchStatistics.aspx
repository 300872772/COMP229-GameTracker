<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MatchStatistics.aspx.cs" Inherits="GameTracker.MatchStatistics1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container">
        <div class="row">

            <h1>Add MatchStatistics Data</h1>

            <div>


                <div class="containerDecoration">

                    <a href="MainMenu.aspx">BACK</a>
                    <div class="form-group">
                        <label for="matchID">MatchID</label>

                        <asp:TextBox runat="server" placeholder="Enter Match ID" CssClass="form-control" ID="matchID"></asp:TextBox>

                    </div>

                    <div class="form-group">
                        <label for="t1goal">T1Goal</label>

                        <asp:TextBox runat="server" placeholder="Enter T1 Goal" CssClass="form-control" ID="t1goal"></asp:TextBox>

                    </div>

                    <div class="form-group">
                        <label for="t1totalshot">T1TotalShot</label>

                        <asp:TextBox runat="server" placeholder="Enter t1 Total Shot" CssClass="form-control" ID="t1totalshot"></asp:TextBox>

                    </div>

                    <div class="form-group">
                        <label for="t1shotinbox">T1 Shot Inbox</label>

                        <asp:TextBox runat="server" placeholder="Enter T1 Shot Inbox" CssClass="form-control" ID="t1shotinbox"></asp:TextBox>

                    </div>

                    <div class="form-group">
                        <label for="t1shotoutbox">t1 shot Outbox</label>

                        <asp:TextBox runat="server" placeholder="Enter t1 shot outbox" CssClass="form-control" ID="t1shotoutbox"></asp:TextBox>

                    </div>

                    <div class="form-group">
                        <label for="t1corner">t1corner</label>

                        <asp:TextBox runat="server" placeholder="Enter T1 Corner" CssClass="form-control" ID="t1corner"></asp:TextBox>

                    </div>

                    <div class="form-group">
                        <label for="t1shotaccuracy">t1 shot accuracy</label>

                        <asp:TextBox runat="server" placeholder="Enter T1 Shot Accuracy" CssClass="form-control" ID="t1shotaccuracy"></asp:TextBox>

                    </div>

                    <div class="form-group">
                        <label for="t1earningpoints">t1 learning points</label>

                        <asp:TextBox runat="server" placeholder="Enter t1 learning points" CssClass="form-control" ID="t1earningpoints"></asp:TextBox>

                    </div>

                    <div class="form-group">
                        <label for="t2goal">t2goal</label>

                        <asp:TextBox runat="server" placeholder="Enter t2goal" CssClass="form-control" ID="t2goal"></asp:TextBox>

                    </div>

                    <div class="form-group">
                        <label for="t2totalshot">t2totalshot</label>

                        <asp:TextBox runat="server" placeholder="Enter t2totalshot" CssClass="form-control" ID="t2totalshot"></asp:TextBox>

                    </div>

                    <div class="form-group">
                        <label for="t3shotinbox">t3shotinbox</label>

                        <asp:TextBox runat="server" placeholder="Enter t3shotinbox" CssClass="form-control" ID="t3shotinbox"></asp:TextBox>

                    </div>

                    <div class="form-group">
                        <label for="team1ID">MatchID</label>

                        <asp:TextBox runat="server" placeholder="Enter Match ID" CssClass="form-control" ID="TextBox9"></asp:TextBox>

                    </div>

                    <div class="form-group">
                        <label for="t4shotoutbox">t4shotoutbox</label>

                        <asp:TextBox runat="server" placeholder="Enter t4shotoutbox" CssClass="form-control" ID="t4shotoutbox"></asp:TextBox>

                    </div>

                    <div class="form-group">
                        <label for="t5corner">t5corner</label>

                        <asp:TextBox runat="server" placeholder="Enter t5corner" CssClass="form-control" ID="t5corner"></asp:TextBox>

                    </div>

                    <div class="form-group">
                        <label for="t6shotaccuracy">t6shotaccuracy</label>

                        <asp:TextBox runat="server" placeholder="Enter t6shotaccuracy" CssClass="form-control" ID="t6shotaccuracy"></asp:TextBox>

                    </div>

                    <div class="form-group">
                        <label for="t7earningpoints">t7earningpoints</label>

                        <asp:TextBox runat="server" placeholder="Enter t7earningpoints" CssClass="form-control" ID="t7earningpoints"></asp:TextBox>

                    </div>

                    <div class="form-group">
                        <label for="team1ID">MatchID</label>

                        <asp:TextBox runat="server" placeholder="Enter Match ID" CssClass="form-control" ID="TextBox14"></asp:TextBox>

                    </div>

                    

                    <div class="text-right">
                        <asp:Button Text="Cancel" ID="CancelButton" CssClass="btn btn-warning btn-lg" runat="server"
                            UseSubmitBehavior="false" CausesValidation="false" OnClick="CancelButton_Click" />
                        <asp:Label ID="emailConfirmation" runat="server"></asp:Label>
                        <asp:Button Text="Save" ID="SaveButton" CssClass="btn btn-primary btn-lg" runat="server"
                            OnClick="SaveButton_Click" />



                    </div>
                </div>
            </div>
            <!--col-md-5 -->









        </div>
        <!--Row -->
    </div>
    <!--Container -->

</asp:Content>
