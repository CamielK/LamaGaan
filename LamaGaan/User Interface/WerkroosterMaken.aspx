<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/LamaGaan.Master" AutoEventWireup="true" CodeBehind="WerkroosterMaken.aspx.cs" Inherits="LamaGaan.User_Interface.WerkroosterMaken" %>

<%--
    Deze pagina is onderdeel van use case 'Werkrooster maken' en vormt de UI voor het aanmaken van een werkrooster.
    De CC die bij deze pagina hoort is te vinden in de map CC met als naam 'CCWerkroosterMaken.cs'
    Auteur: Camiel Kerkhofs
--%>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpMainContent" runat="server">
    <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
    <br />
    <asp:Button ID="BtZoekpersoon" runat="server" Text="zoek persoon" OnClick="BtZoekpersoon_Click" />
    <br />
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
</asp:Content>
