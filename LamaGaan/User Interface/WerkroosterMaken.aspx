<%@ Page Title="Werkrooster maken" Language="C#" MasterPageFile="~/MasterPages/LamaGaan.Master" AutoEventWireup="true" CodeBehind="WerkroosterMaken.aspx.cs" Inherits="LamaGaan.User_Interface.WerkroosterMaken" %>

<%--
    Deze pagina is onderdeel van use case 'Werkrooster maken' en vormt de UI voor het aanmaken van een werkrooster.
    De CC die bij deze pagina hoort is te vinden in de map CC met als naam 'CCWerkroosterMaken.cs'
    Auteur: Camiel Kerkhofs
--%>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style3 {
            width: 250px;
        }
        .auto-style4 {
            width: 200px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpMainContent" runat="server">
    <table class="auto-style1">
        <tr>
            <td colspan="3">Op deze pagina kunt u een nieuw werkrooster aanmaken.<br />
                Gebruik het formulier en doorloop de stappen.<br />
                <br />
                <br />
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Selecteer de datum waarvoor u een werkrooster wilt toevoegen:</td>
            <td class="auto-style4">
                <asp:TextBox ID="TbDatum" runat="server" TextMode="Date" Width="195px"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">Selecteer de vrijwilliger voor dit werkrooster:</td>
            <td class="auto-style4"><asp:DropDownList ID="DropDownListNamen" runat="server" Width="200px"></asp:DropDownList></td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">Selecteer de taak voor dit werkrooster:</td>
            <td class="auto-style4"><asp:DropDownList ID="DropDownListTaken" runat="server" Width="200px"></asp:DropDownList></td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">Geef de begintijd:</td>
            <td class="auto-style4"><asp:TextBox ID="TbBegintijd" runat="server" TextMode="Time" Width="195px"></asp:TextBox></td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">Geef de eindtijd:</td>
            <td class="auto-style4"><asp:TextBox ID="TbEindtijd" runat="server" TextMode="Time" Width="195px"></asp:TextBox></td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style4"><asp:Button ID="BtAanmaken" runat="server" Text="Werkrooster aanmaken" OnClick="BtAanmaken_Click" Width="200px" /></td>
            <td>&nbsp;</td>
        </tr>
    </table>

    <br />

    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>

</asp:Content>
