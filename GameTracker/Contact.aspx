<%@ Page Title="Contacts" Language="C#" MasterPageFile="~/ContactMain.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="GameTracker.Pages.Contact" %>


<asp:Content ID="Content2" ContentPlaceHolderID="ContactContent" runat="server">
	<div class="container">
		<div class="row">
			<div class="row">
				<div class="col-md-offset-1 col-md-11">
					<h1>Contact</h1>
				</div>
			</div>
			<div class="row">
                <div class="col-md-offset-1 col-md-6">
                <div class="row">
				<div class="col-md-offset-1 col-md-6">
					<h3>Contact Information</h3>
					<div class="containerDecoration">
                       
						Address:<br>
						9 Crescent Place<br>
						Toronto,ON M4C5L8<br>
						<br>
						Phone:<br>
						<a href="tel:1-647-447-3215">+1 (647) 447-3215</a><br>
						<br>
						Email:
						<br>
						mamun131@gmail.com<br>
                    </div>
                            

					</div>
                    
			    <div class="col-md-5">
					<h3>Keep Connected</h3>
					<div class="containerDecoration">
						Face Book:<br>
						<a href="https://www.facebook.com/md.mamunur.rahman" target="_blank"><i class="fa fa-facebook fa-lg"></i>My Facebook</a><br>
						<br>
						Twitter:<br>
						<a href="https://twitter.com/mamun_131" target="_blank"><i class="fa fa-twitter fa-lg"></i>My Twitter</a><br>
						<br>
						Linkdin:<br>
						<a href="https://www.linkedin.com/in/md-mamunur-rahman-31a6375?trk=nav_responsive_tab_profile_pic" 
                            target="_blank"><i class="fa fa-linkedin fa-lg"></i>My Linkedin</a><br>
						<br>
					</div>
 
                    </div>
				</div>
                    <br>
                   
            <div class="row">
                
                <div class="col-md-offset-1 col-md-11">
					<div class="containerDecoration">
                        <div class="row">
                        <div class="col-md-offset-1 col-md-9">
                        <a href="https://www.google.ca/maps/place/
                            9+Crescent+Place,+Crescent+Town+Rd,+East+York,+ON+M4C+5L8/@43.695606,
                            -79.2999923,15z/data=!4m5!3m4!1s0x89d4cc279a2d14f7:0x23d4f1e4f6d62aa0!
                            8m2!3d43.6956021!4d-79.2912322" target="_blank">
                            <img src='../Assets/map.jpg' class='mamunImage responsive-width'></a>
                            </div>
                        <div class="col-md-2">
                        <h3>Map</h3>
                            </div>
                        </div>
                    </div>
             </div>
                </div>
               </div>

                
			
			<br>
			

			

				<div class="col-md-5">

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
				</div>



			




		</div>
	</div>
	</div>
</asp:Content>
