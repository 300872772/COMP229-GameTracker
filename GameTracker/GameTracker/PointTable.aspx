<%@ Page Title="PointTable" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PointTable.aspx.cs" Inherits="GameTracker.PointTable" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    

    <div class="containerDecorationMatchTitle">
       <br> <h1>Point Tables</h1>
            <div id="PointTableDIV" runat="server">

                <asp:GridView ID='PointTableGridView' runat='server' AutoGenerateColumns='true' 
                    CssClass='table table-bordered table-striped' ForeColor="Black">
                 


            </asp:GridView>
</div></div>
</asp:Content>
