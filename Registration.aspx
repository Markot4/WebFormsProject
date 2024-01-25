<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="WebFormsProject.Registration" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="registration-container">
        <h2>Registracija</h2>
        <div class="form-group">
            <asp:Label ID="lblUserName" runat="server" Text="Korisničko ime:"></asp:Label>
            <asp:TextBox ID="txtUserName" runat="server" CssClass="form-control" placeholder="Unesite korisničko ime"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Label ID="lblPassword" runat="server" Text="Lozinka:"></asp:Label>
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" CssClass="form-control" placeholder="Unesite lozinku"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Label ID="lblRepeatPassword" runat="server" Text="Ponovite lozinku:"></asp:Label>
            <asp:TextBox ID="txtRepeatPassword" runat="server" TextMode="Password" CssClass="form-control" placeholder="Ponovite lozinku"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Label ID="lblFullName" runat="server" Text="Ime i Prezime:"></asp:Label>
            <asp:TextBox ID="txtFullName" runat="server" CssClass="form-control" placeholder="Unesite ime i prezime"></asp:TextBox>
        </div>
        <asp:Button ID="btnRegister" runat="server" Text="Registriraj se" CssClass="btn btn-primary" OnClick="btnRegister_Click" />
        <asp:Label ID="lblMessage" runat="server" Text="" ForeColor="Green" CssClass="registration-message" />
    </div>
</asp:Content>
