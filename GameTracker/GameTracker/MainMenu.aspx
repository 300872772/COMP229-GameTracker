<%@ Page Title="MainMenu" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MainMenu.aspx.cs" Inherits="GameTracker.MainMenu" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<div class="container">

        <div class="row">
            <div class="col-md-offset-3 col-md-6">
                <h1>Main Menu</h1>
                <div class="well">
                    <h3><i class="fa fa-leanpub fa-lg"></i> Team Data Add Form</h3>
                    <div class="list-group">
                        <a class="list-group-item" href="TeamDataAddForm.aspx"><i class="fa fa-th-list"></i> Team List</a>
                        <a class="list-group-item" href="TeamDataAddForm.aspx"><i class="fa fa-plus-circle"></i> Add Team</a>
                    </div>
                </div>
                <div class="well">
                    <h3><i class="fa fa-leanpub fa-lg"></i> Match Data Add Form</h3>
                    <div class="list-group">
                        <a class="list-group-item" href="MatchDataAddForm.aspx"><i class="fa fa-th-list"></i> Match List</a>
                        <a class="list-group-item"  href="MatchDataAddForm.aspx"><i class="fa fa-plus-circle"></i> Add Match</a>
                    </div>
                </div>
                 <div class="well">
                    <h3><i class="fa fa-leanpub fa-lg"></i> Match Data Add Form</h3>
                    <div class="list-group">
                        <a class="list-group-item" href="MatchStatistics.aspx"><i class="fa fa-th-list"></i> Match List</a>
                        <a class="list-group-item"  href="MatchStatistics.aspx"><i class="fa fa-plus-circle"></i> Add Match</a>
                    </div>
                </div>


            </div>
        </div>
    </div>

</asp:Content>
