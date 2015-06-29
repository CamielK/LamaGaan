<%@ Page Language="C#" MasterPageFile="~/MasterPages/LamaGaan.Master" AutoEventWireup="true" CodeBehind="Kassa.aspx.cs" Inherits="LamaGaan.User_Interface.Kassa" %>

<asp:Content ID="Content1" runat="server" contentplaceholderid="cpMainContent">
    
    <asp:Label ID="Entree" runat="server" Text="Entree:"></asp:Label>
    <br />
    <asp:Label ID="Label1" runat="server" Text="Aantal personen:"></asp:Label>
    <asp:TextBox ID="HoeveleheidPersoon" runat="server"></asp:TextBox>
    <asp:Label ID="AantalPersonen" runat="server" Text="x 10 euro"></asp:Label>
    <br />
    <br />
    <br />


    <asp:Label ID="SoortenDrinken" runat="server" Text="Dranken:"></asp:Label>
    <br />
    <asp:Label ID="Fanta" runat="server" Text="Aantal Fanta:"></asp:Label>
    <asp:TextBox ID="HoeveelheidFanta" runat="server"></asp:TextBox>
    <asp:Label ID="AantalFanta" runat="server" Text="x 1 euro 50"></asp:Label>
    <br />
    <br />
    <asp:Label ID="Cola" runat="server" Text="Aantal Cola:"></asp:Label>
    <asp:TextBox ID="HoeveelheidCola" runat="server"></asp:TextBox>
    <asp:Label ID="AantalCola" runat="server" Text="x 1 euro 50"></asp:Label>

    <br />
    <br />
    <asp:Label ID="Koffie" runat="server" Text="Aantal koffie:"></asp:Label>
    <asp:TextBox ID="HoeveelheidKoffie" runat="server"></asp:TextBox>
    <asp:Label ID="AantalKoffie" runat="server" Text="x 1 euro 50"></asp:Label>

    <br />
    <br />
    <asp:Label ID="Thee" runat="server" Text="Aantal thee:"></asp:Label>
    <asp:TextBox ID="HoeveelheidThee" runat="server"></asp:TextBox>
    <asp:Label ID="AantalThee" runat="server" Text="x 1 euro 50"></asp:Label>

    <br />
    <br />
    <asp:Label ID="Ijsje" runat="server" Text="Aantal ijsjes:"></asp:Label>
    <asp:TextBox ID="HoeveelheidIjsje" runat="server"></asp:TextBox>
    <asp:Label ID="AantalIjs" runat="server" Text="x 1 euro"></asp:Label>

    <br />
    <br />
    <br />
    <asp:Label ID="Merchandise" runat="server" Text="Merchandise:"></asp:Label>
    
    <br />
    <br />
    <asp:Label ID="Sleutelhanger" runat="server" Text="Aantal Sleutelhangers:"></asp:Label>
    <asp:TextBox ID="HoeveelheidSleutelhangers" runat="server"></asp:TextBox>
    <asp:Label ID="AantalSleutelhangers" runat="server" Text="x 3 euro"></asp:Label>

    <br />
    <br />
    <asp:Label ID="Tshirt" runat="server" Text="Aantal T-shirts:"></asp:Label>
    <asp:TextBox ID="HoeveelheidTshirts" runat="server"></asp:TextBox>
    <asp:Label ID="AantalTshirts" runat="server" Text="x 5 euro"></asp:Label>
    
    <br />
    <br />
    <asp:Label ID="Petjes" runat="server" Text="Aantal Petjes"></asp:Label>
    <asp:TextBox ID="HoeveelheidPetjes" runat="server"></asp:TextBox>
    <asp:Label ID="AantalPetjes" runat="server" Text="x 5 euro"></asp:Label>
    
    <br />
    <br />
    <asp:Label ID="PlucheLamas" runat="server" Text="Aantal Pluche Lama's"></asp:Label>
    <asp:TextBox ID="Hoeveelheidlamas" runat="server"></asp:TextBox>
    <asp:Label ID="AantalLamas" runat="server" Text="x 10 euro"></asp:Label>



</asp:Content>


