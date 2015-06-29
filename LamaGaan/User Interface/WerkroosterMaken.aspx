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
            width: 300px;
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
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldDatum" runat="server" ControlToValidate="TbDatum" CssClass="ErrorMessage" ErrorMessage="Vul een datum in">*</asp:RequiredFieldValidator>
                <asp:RangeValidator ID="RangeValidatorDatum" runat="server" ControlToValidate="TbDatum" CssClass="ErrorMessage" ErrorMessage="Kies een datum tussen vandaag en +10 jaar" MaximumValue="12/31/9999" MinimumValue="DateTimeNow" Type="Date">*</asp:RangeValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Selecteer de vrijwilliger voor dit werkrooster:</td>
            <td class="auto-style4"><asp:DropDownList ID="DropDownListNamen" runat="server" Width="200px" AppendDataBoundItems="True"><asp:ListItem Text="Kies een vrijwilliger.." Value="" /></asp:DropDownList></td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidatorVrijwilliger" runat="server" ControlToValidate="DropDownListNamen" CssClass="ErrorMessage" ErrorMessage="Kies een vrijwilliger">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Selecteer de taak voor dit werkrooster:</td>
            <td class="auto-style4"><asp:DropDownList ID="DropDownListTaken" runat="server" Width="200px" AppendDataBoundItems="True"><asp:ListItem Text="Kies een taak.." Value="" /></asp:DropDownList></td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidatorTaak" runat="server" ControlToValidate="DropDownListTaken" CssClass="ErrorMessage" ErrorMessage="Kies een taak">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Geef de begintijd:</td>
            <td class="auto-style4"><asp:TextBox ID="TbBegintijd" runat="server" TextMode="Time" Width="195px"></asp:TextBox></td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidatorBegintijd" runat="server" ControlToValidate="TbBegintijd" CssClass="ErrorMessage" ErrorMessage="Vul een begintijd in">*</asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidatorBegintijd" runat="server" ControlToValidate="TbBegintijd" CssClass="ErrorMessage" ErrorMessage="Geef een tijd tussen 00:00 en 23:59" ValidationExpression="^([0-1]?[0-9]|2[0-3]):[0-5][0-9]$">*</asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Geef de eindtijd:</td>
            <td class="auto-style4"><asp:TextBox ID="TbEindtijd" runat="server" TextMode="Time" Width="195px"></asp:TextBox></td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidatorEindtijd" runat="server" ControlToValidate="TbEindtijd" CssClass="ErrorMessage" ErrorMessage="Vul een eindtijd in">*</asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidatorEindtijd" runat="server" ControlToValidate="TbEindtijd" CssClass="ErrorMessage" ErrorMessage="Geef een tijd tussen 00:00 en 23:59" ValidationExpression="^([0-1]?[0-9]|2[0-3]):[0-5][0-9]$">*</asp:RegularExpressionValidator>
                <asp:CompareValidator ID="CompareValidatorTijd" runat="server" ControlToCompare="TbBegintijd" ControlToValidate="TbEindtijd" CssClass="ErrorMessage" ErrorMessage="Begintijd moet voor eindtijd zijn" Operator="GreaterThan">*</asp:CompareValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style4"><asp:Button ID="BtAanmaken" runat="server" Text="Werkrooster aanmaken" OnClick="BtAanmaken_Click" Width="200px" /></td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3" colspan="3">
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" CssClass="ErrorMessage" HeaderText="Los aub de volgende fouten op:" ShowMessageBox="True" ShowSummary="False" />
            </td>
        </tr>
    </table>

    <br />

    <asp:Label ID="Label1" runat="server" Text="" CssClass="ErrorMessage"></asp:Label>

</asp:Content>
