<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebFormsProject.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login Page</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f4f4f4;
            margin: 0;
            padding: 0;
            text-align: center;
        }

        #formWrapper {
            background-color: #fff;
            border: 1px solid #ccc;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
            width: 300px;
            margin: 100px auto;
            padding: 20px;
        }

        #form1 {
            text-align: left;
        }

        #form1 label {
            display: block;
            margin-bottom: 8px;
        }

        #form1 input[type="text"], #form1 input[type="password"] {
            width: 100%;
            padding: 10px;
            margin-bottom: 15px;
            box-sizing: border-box;
        }

        #form1 .btnLogin {
            background-color: #4caf50;
            color: #fff;
            padding: 10px;
            border: none;
            width: 100%;
            cursor: pointer;
        }

        #form1 .btnLogin:hover {
            background-color: #45a049;
        }

        #form1 .registrationLink {
            text-decoration: none;
            color: #007bff;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div id="formWrapper">
            <h2>Login</h2>
            <label for="txtUsername">Username:</label>
            <asp:TextBox runat="server" ID="txtUsername" placeholder="Enter your username" CssClass="form-control"></asp:TextBox>

            <label for="txtPassword">Password:</label>
            <asp:TextBox runat="server" ID="txtPassword" TextMode="Password" placeholder="Enter your password" CssClass="form-control"></asp:TextBox>

            <asp:Button runat="server" ID="btnLogin" Text="Login" CssClass="btnLogin" OnClick="btnLogin_Click" />

            <div>
                <a runat="server" href="~/Registration.aspx" class="registrationLink">Don't have an account? Register here.</a>
            </div>
        </div>
    </form>
</body>
</html>
