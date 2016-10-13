<%@ Page Title="MatchDataAddForm" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MatchDataAddForm.aspx.cs" Inherits="GameTracker.MatchDataAddForm" %>


<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="row">

            <h1>Add Match Data</h1>

            <div>


                <div class="containerDecoration">


                    <div class="form-group">
                        <label for="team1ID">Team-1 ID</label>

                        <asp:TextBox runat="server" placeholder="Enter Team ID" CssClass="form-control" ID="team1ID"></asp:TextBox>

                    </div>

                    <div class="form-group">
                        <label for="team2ID">Team-2 ID</label>

                        <asp:TextBox runat="server" placeholder="Enter Team ID" CssClass="form-control" ID="team2ID"></asp:TextBox>

                    </div>
                    <div class="form-group">
                        <label for="tournamentID">Tournament ID</label>


                        <asp:TextBox runat="server" placeholder="Enter Tournament ID" CssClass="form-control" ID="tournamentID"></asp:TextBox>


                    </div>

                    <div class="form-group">
                        <label for="city">City</label>
                        <asp:TextBox runat="server" placeholder="Enter city" CssClass="form-control" ID="city"></asp:TextBox>

                    </div>
                    <div class="form-group">
                        <label for="venue">Venue</label>
                        <asp:TextBox runat="server" placeholder="Enter Venue" CssClass="form-control" ID="venue"></asp:TextBox>

                    </div>
                    <div class="form-group">
                        <label for="venuecapacity">Venue Capacity</label>
                        <asp:TextBox runat="server" placeholder="Enter Venue Capacity" CssClass="form-control" ID="venuecapacity"></asp:TextBox>

                    </div>


                    <div class="form-group">
                        <label for="matchdate">Match Date</label>
                        <asp:TextBox runat="server" placeholder="Enter Match Date" TextMode="Date" CssClass="form-control" ID="matchdate"></asp:TextBox>

                    </div>
                    <div class="form-group">
                        <label for="week">Week</label>
                        <asp:TextBox runat="server" placeholder="Enter Week" CssClass="form-control" ID="week"></asp:TextBox>

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
