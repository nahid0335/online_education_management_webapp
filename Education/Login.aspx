<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Education.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <meta charset="UTF-8"/>
        <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
        <meta http-equiv="X-UA-Compatible" content="ie=edge"/>
        <title>Sign In</title>

        <!-- Font Icon -->
        <link rel="stylesheet" href="~/fonts/Login/material-icon/css/material-design-iconic-font.min.css" />

        <!-- Main css -->
        <link rel="stylesheet" href="~/contents/Login/css/style.css" />
    </head>
    <body>
        <form id="form1" runat="server">
             <div class="main">
                <h1>Sign In</h1>
                <div class="container">
                    <div class="sign-up-content">
                        <h2 class="form-title">What type of user are you ?</h2>
                            <div class="form-radio">
                                <asp:RadioButton ID="newbie" runat="server" Text="Student" GroupName="member_level" Checked="true"/> 

                                <asp:RadioButton ID="average" runat="server" Text="Teacher" GroupName="member_level" /> 
                            </div>

                            <div class="form-textbox">
                                <label for="name">User name</label>
                                <asp:TextBox ID="txtUserName" runat="server"  required=""></asp:TextBox>
                            </div>

                            <div class="form-textbox">
                                <label for="email">Email</label>
                                <asp:TextBox ID="txtEmail" runat="server" required=""></asp:TextBox>
                            </div>

                            <div class="form-textbox">
                                <label for="pass">Password</label>
                                <asp:TextBox ID="txtPassword" runat="server"  required="" TextMode="Password"></asp:TextBox>
                            </div>

                            <div class="form-group">
                                <input type="checkbox" name="agree-term" id="agree-term" class="agree-term" />
                                <label for="agree-term" class="label-agree-term"><span><span></span></span>Remember me..</label>
                                <asp:CheckBox ID="Check1" runat="server" />
                            </div>

                            <div class="form-textbox">
                                <asp:Button ID="submit" runat="server" Text="Login" OnClick="btnSubmit_Click" CssClass="submit" />
                            </div>

                        <p class="loginhere">
                            Don't have an account ?<a href="Registration.aspx" class="loginhere-link"> Sign Up</a>
                        </p>
                    </div>
                </div>

            </div>
        </form>

        <!-- JS -->
            <script src="~/contents/Login/vendor/jquery/jquery.min.js"></script>
            <script src="~/contents/Login/js/main.js"></script>
    </body>
</html>
