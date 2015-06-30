<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/LamaGaan.Master" AutoEventWireup="true" CodeBehind="Evenementen.aspx.cs" Inherits="LamaGaan.User_Interface.Evenementen" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
        }
        .auto-style4 {
            height: 25px;
        }
        .auto-style5 {
            height: 30px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpMainContent" runat="server">
    <%--<asp:Label ID="Label1" runat="server"></asp:Label>--%>
    <br />
    <table class="auto-style1">
        <tr>
            <td class="auto-style2" colspan="3">Vul de onderstaande gegevens in om een evenement te plannen en een reservering aan te maken:</td>
        </tr>
        <tr>
            <td>Naam:</td>
            <td>
    <asp:TextBox ID="tbNaam" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="tbNaam" CssClass="ErrorMessage" ErrorMessage="Vul uw naam in.">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">Soort:</td>
            <td class="auto-style4">
    <asp:DropDownList ID="ddlSoort" runat="server">
        <asp:ListItem>Selecteer een actie...</asp:ListItem>
        <asp:ListItem>Kortingsactie</asp:ListItem>
        <asp:ListItem>Afhuren Park</asp:ListItem>
        <asp:ListItem>Bedrijfsuitje</asp:ListItem>
    </asp:DropDownList>
            </td>
            <td class="auto-style4">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="ddlSoort" CssClass="ErrorMessage" ErrorMessage="Selecteer een soort kortingsactie">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>Datum:</td>
            <td> <asp:TextBox ID="tbDatum" runat="server" TextMode="Date"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFielddatum" runat="server" ControlToValidate="tbDatum" CssClass="ErrorMessage" ErrorMessage="Vul een datum in.">*</asp:RequiredFieldValidator>
                <asp:RangeValidator ID="RangeValidatorDatum" runat="server" ControlToValidate="tbDatum" CssClass="ErrorMessage" ErrorMessage="Kies een datum tussen vandaag en +10 jaar." MaximumValue="12/31/9999" Type="Date" MinimumValue="DateTimeNow">*</asp:RangeValidator>
                
            </td>
        </tr>
        <tr>
            <td>Aantal Personen:</td>
            <td>
    <asp:TextBox ID="tbAantalPersonen" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="tbAantalPersonen" CssClass="ErrorMessage" ErrorMessage="Vul een aantal personen in.">*</asp:RequiredFieldValidator>
                <asp:RangeValidator ID="RangeValidator2" runat="server" ControlToValidate="tbAantalPersonen" CssClass="ErrorMessage" ErrorMessage="Vul een aantal personen in tussen 1 en 170." MaximumValue="170" MinimumValue="1">*</asp:RangeValidator>
            </td>
        </tr>
        <tr>
            <td>Korting:</td>
            <td>
    <asp:TextBox ID="tbKorting" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="tbKorting" CssClass="ErrorMessage" ErrorMessage="Vul een kortingspercentage in tussen 0 en 100.">*</asp:RequiredFieldValidator>
                <asp:RangeValidator ID="RangeValidator3" runat="server" ControlToValidate="tbKorting" CssClass="ErrorMessage" ErrorMessage="Vul een getal tussen 0 en 100 in." MaximumValue="100" MinimumValue="0">*</asp:RangeValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style5"></td>
            <td class="auto-style5">
    <asp:Button ID="tbOpslaan" runat="server" OnClick="tbOpslaan_Click" Text="Opslaan" />

            </td>
            <td class="auto-style5"></td>
        </tr>
        <tr>
            <td colspan="3">
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" CssClass="ErrorMessage" HeaderText="U heet de volgende foutmeldingen:" />
            </td>
        </tr>
    </table>
    <br />
    &nbsp; &nbsp;
    <br />
    <br />
    
</asp:Content>
