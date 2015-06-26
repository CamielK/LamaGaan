<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/LamaGaan.Master" AutoEventWireup="true" CodeBehind="WerkroosterMaken.aspx.cs" Inherits="LamaGaan.User_Interface.WerkroosterMaken" %>

<%--
    Deze pagina is onderdeel van use case 'Werkrooster maken' en vormt de UI voor het aanmaken van een werkrooster.
    De CC die bij deze pagina hoort is te vinden in de map CC met als naam 'CCWerkroosterMaken.cs'
    Auteur: Camiel Kerkhofs
--%>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpMainContent" runat="server">
    Op deze pagina kunt u een nieuw werkrooster aanmaken.<br />Gebruik het formulier en doorloop de stappen.<br /><br />
    Selecteer de datum waarvoor u een werkrooster wilt toevoegen: <br />
    Selecteer de vrijwilliger voor dit werkrooster: <asp:DropDownList ID="DropDownListNamen" runat="server"></asp:DropDownList><br />
    <asp:Button ID="BtAanmaken" runat="server" Text="Werkrooster aanmaken" OnClick="BtAanmaken_Click" />
    <br />
    <br />
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
</asp:Content>
