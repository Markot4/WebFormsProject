<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductManagement.aspx.cs" Inherits="WebFormsProject.ProductManagement" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <asp:Label ID="lblMessage" runat="server" Text="" ForeColor="Green" />
    </div>
    <div>
        <h3>Dodaj Novi Proizvod</h3>
        <asp:TextBox ID="txtProductName" runat="server" placeholder="Naziv proizvoda"></asp:TextBox>
        <asp:TextBox ID="txtProductDescription" runat="server" placeholder="Opis proizvoda"></asp:TextBox>
        <asp:Button ID="btnSaveProduct" runat="server" Text="Spremi" OnClick="btnSaveProduct_Click" />
    </div>
    <div>
        <h3>Popis Proizvoda</h3>
        <asp:GridView ID="gvProducts" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="ProductId" HeaderText="Product ID" ReadOnly="True" SortExpression="ProductId" />
                <asp:BoundField DataField="ProductName" HeaderText="Product Name" SortExpression="ProductName" />
                <asp:BoundField DataField="ProductDescription" HeaderText="Product Description" SortExpression="ProductDescription" />
            </Columns>
        </asp:GridView>

    </div>
</asp:Content>
