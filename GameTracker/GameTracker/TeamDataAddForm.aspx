<%@ Page Title="TeamDataAddForm" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TeamDataAddForm.aspx.cs" Inherits="GameTracker.TeamDataAddForm" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="row">
 
        <h1 >Add Team Data</h1>
          
   <div >

					
					<div class="containerDecoration">


						<div class="form-group">
							<label for="teamname">Team Name</label>

							<asp:TextBox runat="server" placeholder="Enter Team Name" CssClass="form-control" ID="teamname"></asp:TextBox>
 
						</div>
						
                        <div class="form-group">
							<label for="teamshortname">Team Short Name</label>

							<asp:TextBox runat="server" placeholder="Enter Team Short Name" CssClass="form-control" ID="teamshortname"></asp:TextBox>
 
						</div>

						<div class="form-group">
							<label for="flag">Flag</label>

							<asp:TextBox runat="server" placeholder="Enter Flag" CssClass="form-control" ID="flag"></asp:TextBox>
 
						</div>

                       <div class="form-group">
							<label for="playername1">Player Name</label>

							<asp:TextBox runat="server" placeholder="Enter Player Name" CssClass="form-control" ID="playername1"></asp:TextBox>
 
						</div>
                                               <div class="form-group">
							<label for="playername2">Player Name</label>

							<asp:TextBox runat="server" placeholder="Enter Player Name" CssClass="form-control" ID="playername2"></asp:TextBox>
 
						</div>
                                               <div class="form-group">
							<label for="playername3">Player Name</label>

							<asp:TextBox runat="server" placeholder="Enter Player Name" CssClass="form-control" ID="playername3"></asp:TextBox>
 
						</div>
                                               <div class="form-group">
							<label for="playername4">Player Name</label>

							<asp:TextBox runat="server" placeholder="Enter Player Name" CssClass="form-control" ID="playername4"></asp:TextBox>
 
						</div>
                                               <div class="form-group">
							<label for="playername5">Player Name</label>

							<asp:TextBox runat="server" placeholder="Enter Player Name" CssClass="form-control" ID="playername5"></asp:TextBox>
 
						</div>
                                               <div class="form-group">
							<label for="playername6">Player Name</label>

							<asp:TextBox runat="server" placeholder="Enter Player Name" CssClass="form-control" ID="playername6"></asp:TextBox>
 
						</div>
                                               <div class="form-group">
							<label for="playername7">Player Name</label>

							<asp:TextBox runat="server" placeholder="Enter Player Name" CssClass="form-control" ID="playername7"></asp:TextBox>
 
						</div>
                                               <div class="form-group">
							<label for="playername8">Player Name</label>

							<asp:TextBox runat="server" placeholder="Enter Player Name" CssClass="form-control" ID="playername8"></asp:TextBox>
 
						</div>
                                               <div class="form-group">
							<label for="playername9">Player Name</label>

							<asp:TextBox runat="server" placeholder="Enter Player Name" CssClass="form-control" ID="playername9"></asp:TextBox>
 
						</div>
                                               <div class="form-group">
							<label for="playername10">Player Name</label>

							<asp:TextBox runat="server" placeholder="Enter Player Name" CssClass="form-control" ID="playername10"></asp:TextBox>
 
						</div>
                                               <div class="form-group">
							<label for="playername11">Player Name</label>

							<asp:TextBox runat="server" placeholder="Enter Player Name" CssClass="form-control" ID="playername11"></asp:TextBox>
 
						</div>
                                               <div class="form-group">
							<label for="playername12">Player Name</label>

							<asp:TextBox runat="server" placeholder="Enter Player Name" CssClass="form-control" ID="playername12"></asp:TextBox>
 
						</div>
                                               <div class="form-group">
							<label for="playername13">Player Name</label>

							<asp:TextBox runat="server" placeholder="Enter Player Name" CssClass="form-control" ID="playername13"></asp:TextBox>
 
						</div>
                                               <div class="form-group">
							<label for="playername14">Player Name</label>

							<asp:TextBox runat="server" placeholder="Enter Player Name" CssClass="form-control" ID="playername14"></asp:TextBox>
 
						</div>
                                               <div class="form-group">
							<label for="playername15">Player Name</label>

							<asp:TextBox runat="server" placeholder="Enter Player Name" CssClass="form-control" ID="playername15"></asp:TextBox>
 
						</div>
						
                        <div class="text-right">
                        <asp:Button Text="Cancel" ID="CancelButton" CssClass="btn btn-warning btn-lg" runat="server"
                        UseSubmitBehavior="false" CausesValidation="false" OnClick="CancelButton_Click" />
						   <asp:Label id="emailConfirmation" runat="server"></asp:Label>
                        <asp:Button Text="Save" ID="SaveButton" CssClass="btn btn-primary btn-lg" runat="server"
                            OnClick="SaveButton_Click" />							</div>
					</div>
				</div><!--col-md-5 -->









        </div><!--Row -->
    </div><!--Container -->


</asp:Content>

