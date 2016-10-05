<%@ Page Title="Home" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="GameTracker.Default1" %>


 
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="row">
            <div class=" col-md-offset-1 col-md-11">
 <div class="jumbotron">
      <div class="container">
        <h1 >MD MAMUNUR RAHMAN</h1>
          <h3>Software Developer</h3>
          
         
        <p><a class="btn btn-primary btn-lg responsive-width" href="Biography.aspx" role="button">Learn more &raquo;</a></p>
           <h5>An innovative and passionate Software developer. 
          Like to play with logic, problems and different kind 
          of alternative solutions...........</h5>
           </div>
    </div>

    <div class="container">
      <!-- Example row of columns -->
      <div class="row">
        <div id="service" class="col-md-6">
          <h2>Services</h2>
            <a href="Services.aspx"><img src="Assets/service.jpg" alt="Alternate Text" class='responsive-width'/></a>
       
          <p>One-stop service for a complete business software solution............
               </p>
            <ul>
                <li>Desktop Application</li>
                <li>Web Application</li>
                <li>Mobile Application</li>
            </ul>
         
             <p><a class="btn btn-default" href="Services.aspx" role="button">View details &raquo;</a></p>
        </div>
        <div class="col-md-5">
          <h2>Projects</h2>
           <a href="Projects.aspx"> <img src="Assets/project.jpg" alt="Alternate Text" class='responsive-width'/></a>
          <p>Diversified developed project is for building your confidence......... </p>
            <ul>   
             <li>Online Grocery Sales Solution </li>
                <li>Online movie streaming solutionn</li>
                <li>Dynamic Portfolio Site</li></ul>
            <p><a class="btn btn-default" href="Projects.aspx" role="button">View details &raquo;</a></p>
       </div>

      </div>

            </div>
        </div>
            </div>
    </div>
</asp:Content>
