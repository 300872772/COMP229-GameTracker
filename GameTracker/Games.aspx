<%@ Page Title="Games" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Games.aspx.cs" Inherits="GameTracker.Pages.Games" %>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
        <div class="container">
        <div class="row" >
            
                <h1>Matches</h1>
 
<div class="containerDecorationMatch" >
    <div class="row">        
        
        <div class="col-sm-4"><h4 id="matchDate" runat ="server"></h4></div>
        <div class="col-sm-4"> <h4 id="tournament" runat ="server"></h4></div>
        <div class="col-sm-4"> <h4 id="matchWeek" runat ="server"> </h4></div>
        </div>
     <br>
           <div class="containerDecorationMatchTitle">
    <div class="row">        
 
        <div class="col-sm-4 coltitle"><h4 id="Span1" runat ="server">Team1</h4></div>
        <div class="col-sm-4 coltitle"> <h4 id="Span2" runat ="server">Result</h4></div>
        <div class="col-sm-4 coltitle"> <h4 id="Span3" runat ="server"> Team2</h4></div>
        
     </div>   

             
                  <div id ="gameData" runat ="server">


                  </div> 

            </div>
           </div>

                   <div id ="Div1" runat ="server">


                  </div> 
        </div>
   </div>
</asp:Content>
