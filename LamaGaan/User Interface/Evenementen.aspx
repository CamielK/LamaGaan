<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/LamaGaan.Master" AutoEventWireup="true" CodeBehind="Evenementen.aspx.cs" Inherits="LamaGaan.User_Interface.Evenementen" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpMainContent" runat="server">
    <%--<asp:Label ID="Label1" runat="server"></asp:Label>--%>Naam:&nbsp;
    <asp:TextBox ID="tbNaam" runat="server"></asp:TextBox>
    <br />
    Soort:&nbsp;
    <asp:DropDownList ID="ddlSoort" runat="server">
        <asp:ListItem>Kortingsactie</asp:ListItem>
        <asp:ListItem>Afhuren Park</asp:ListItem>
        <asp:ListItem>Bedrijfsuitje</asp:ListItem>
    </asp:DropDownList>
    <br />
    Datum: <asp:TextBox ID="tbDatum" runat="server"></asp:TextBox>
    <br />
    Aantal Personen:&nbsp;
    <asp:TextBox ID="tbAantalPersonen" runat="server"></asp:TextBox>
    <br />
    Korting:&nbsp;
    <asp:TextBox ID="tbKorting" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="tbOpslaan" runat="server" OnClick="tbOpslaan_Click" Text="Opslaan" />

</asp:Content>
