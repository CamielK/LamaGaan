<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/LamaGaan.Master" AutoEventWireup="true" CodeBehind="EvenementAanmaken.aspx.cs" Inherits="LamaGaan.User_Interface.Dennis.EvenementAanmaken" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpMainContent" runat="server">
    <p>
        Maak evenement aan:</p>
    <p>
        Naam:<asp:TextBox ID="tbName" runat="server"></asp:TextBox>
    </p>
    <p>
        Soort:<asp:DropDownList ID="ddlSoort" runat="server">
            <asp:ListItem Selected="True">Soort Evenement...</asp:ListItem>
            <asp:ListItem>Bedrijfsuitje</asp:ListItem>
            <asp:ListItem>Kinderdagen</asp:ListItem>
            <asp:ListItem>Familiedag</asp:ListItem>
        </asp:DropDownList>
    </p>
    <p>
        Datum:<asp:TextBox ID="tbDatum" runat="server"></asp:TextBox>
    </p>
    <p>
        Aantal Personen (max. 170):<asp:TextBox ID="tbAantalPersonen" runat="server"></asp:TextBox>
    </p>
    <p>
        Korting:
        <asp:DropDownList ID="ddlKorting" runat="server" AutoPostBack="True">
            <asp:ListItem>0</asp:ListItem>
            <asp:ListItem>10</asp:ListItem>
            <asp:ListItem>20</asp:ListItem>
            <asp:ListItem>25</asp:ListItem>
            <asp:ListItem>30</asp:ListItem>
            <asp:ListItem>35</asp:ListItem>
        </asp:DropDownList>
    </p>
    <p>
        &nbsp;</p>
    <p>
        <asp:Button ID="btAanmaken" runat="server" OnClick="btAanmaken_Click" Text="Evenement Aanmaken" />
    </p>
</asp:Content>
