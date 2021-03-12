<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TempHome.aspx.cs" Inherits="Education.TempHome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <!-- The above 3 meta tags *must* come first in the head; any other head content must come *after* these tags -->

    <title>Welcome Home</title>

    <!-- Google font -->
    <link href="https://fonts.googleapis.com/css?family=Montserrat:400,700,900" rel="stylesheet" />

    <!-- Custom stlylesheet -->
    <link type="text/css" rel="stylesheet" href="~/contents/ErrorPage/css/style.css" />

    <!-- HTML5 shim and Respond.js for IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
          <script src="https://oss.maxcdn.com/html5shiv/3.7.3/html5shiv.min.js"></script>
          <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
        <![endif]-->
</head>
<body>
    <form id="form1" runat="server">
        <div id="notfound">
        <div class="notfound">
            <div class="notfound-404">
                <h1>Welcome Home</h1>
            </div>
            <h2>Temporary Home</h2>
            <p>Log out to go Login</p>
            <div class="form-textbox">
                <asp:Button ID="submit" runat="server" Text="Log out" OnClick="btnSubmit_Click" CssClass="submit" />
            </div>
        </div>
    </div>
    </form>
</body>
</html>
