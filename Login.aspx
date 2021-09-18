<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style>
        .card-body-custom {
            padding: 0 0rem;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        <div class="row card-body-custom bg-dark">
            <asp:Button ID="Button3" runat="server" Text="Login" class='bg-dark col-6 text-center text-white btn btn-outline-secondary' OnClick="Button3_Click" />
            <asp:Button ID="Button4" runat="server" Text="Sign up" class="bg-dark col-6 text-center text-white btn btn-outline-secondary" OnClick="Button4_Click"/>
        </div>
        
        <div class="row bg-dark">
            <asp:Panel ID="loginForm" runat="server" class="card-body row justify-content-center align-items-center col-6">
                <h1 class='fw-bold mb-2 text-center text-white'><strong>Login</strong></h1>
                <p class="text-white-50 text-center mb-5">Please enter your login username and password!</p>
                <div class="col-md-4">
                    <asp:TextBox ID="username" runat="server" class="form-control mb-4" placeholder="Username"></asp:TextBox>
                
                    <asp:TextBox ID="password" runat="server" class="form-control mb-4" placeholder="Password" TextMode="Password">Password</asp:TextBox>
                    <div class="d-flex justify-content-center">
                        <asp:Button ID="Button1" runat="server" Text="Login" class="btn btn-outline-light px-5" OnClick="Button1_Click" />
                    </div>
                </div>
            </asp:Panel>

            <asp:Panel ID="signupForm" runat="server" class="card-body row justify-content-center align-items-center col-6">
                <h1 class='fw-bold mb-2 text-center text-white'><strong>Sign Up</strong></h1>
                <p class="text-white-50 text-center mb-5">Please enter your username and password!</p>
                <div class="col-md-4">
                    <asp:TextBox ID="usernameSign" runat="server" class="form-control mb-4" placeholder="Username"></asp:TextBox>
                
                    <asp:TextBox ID="passwordSign" runat="server" class="form-control mb-4" placeholder="Password" TextMode="Password">Password</asp:TextBox>
                    <div class="d-flex justify-content-center">
                        <asp:Button ID="Button2" runat="server" Text="Sign Up" class="btn btn-outline-light px-5" OnClick="Button2_Click" />
                    </div>
                </div>
            </asp:Panel>

        </div>

</asp:Content>

