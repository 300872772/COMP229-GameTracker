<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Statistics.aspx.cs" Inherits="GameTracker.Statistics" %>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
        <div class="container">
        <div class="row">
            
                
 
        <div class="containerDecorationMatchTitle">
            <h1>Match Statistics</h1>
            <div id="StatisticsData" runat="server">

                <asp:GridView ID='StatisticsGridView' runat='server' AutoGenerateColumns='true' 
                    CssClass='table table-bordered table-striped' ForeColor="Black">
                 


            </asp:GridView>


            </div>
            

    


           </div>                  
        </div>
   </div>
</asp:Content>
