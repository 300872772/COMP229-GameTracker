<%@ Page Title="Contacts" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="GameTracker.Contact" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container">
        <div class="row">
           
            <h1>Contact</h1>


            

					<h4>CONTACT ME SENDING MESSAGE BY BELOW FORM</h4>
					<div class="containerDecoration">


						<div class="form-group">
							<label for="firstName">First Name</label>

							<asp:TextBox runat="server" placeholder="Enter First Name" CssClass="form-control" ID="firstName"></asp:TextBox>
 
						</div>
						<div class="form-group">
							<label for="lastName">Last Name</label>
							<asp:TextBox runat="server" placeholder="Enter Last Name" CssClass="form-control" ID="lastName"></asp:TextBox>
						   
						</div>
						<div class="form-group">
							<label for="email">Email</label>


							<asp:TextBox runat="server" placeholder="Enter Email" CssClass="form-control" ID="email"></asp:TextBox>
						   

						</div>
						<div class="form-group">
							<label for="contactNumber">Contact Number</label>
							<asp:TextBox runat="server" placeholder="Enter Contact Number" CssClass="form-control" ID="contactNumber"></asp:TextBox>
						   
						</div>
						<div class="form-group">
							<label for="message">Your Message</label>
							 <asp:TextBox runat="server" placeholder="Enter Your Message here..." CssClass="form-control" TextMode="MultiLine" ID="message"></asp:TextBox>
						   

						</div>

						<div class="text-right">
						   <asp:Label id="emailConfirmation" runat="server"></asp:Label>
						<asp:Button ID="sendButton" OnClick="sendButton_Click" CssClass="btn btn-primary" runat="server" Text="Submit" />
							</div>
					</div>
				









        </div><!--Row -->
    </div><!--Container -->




</asp:Content>
