<%@ Page Title="Team" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Team.aspx.cs" Inherits="GameTracker.Team" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">



    <div class="containerDecorationMatchTitle">
        <br>
        <h1>Teams Detail</h1>
        <div id="TeamView" runat="server" class="containerDecorationMatchTitle1">

            <asp:GridView ID='TeamGridView' runat='server' AutoGenerateColumns='true'
                CssClass='table table-bordered table-striped' ForeColor="Black">

            </asp:GridView>
            

        </div>
    </div>
</asp:Content>
