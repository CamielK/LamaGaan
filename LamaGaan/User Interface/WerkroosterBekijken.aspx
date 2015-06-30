<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/LamaGaan.Master" AutoEventWireup="true" CodeBehind="WerkroosterBekijken.aspx.cs" Inherits="LamaGaan.User_Interface.Werkrooster_bekijken" %>


<%--
    Deze pagina is onderdeel van use case 'Werkrooster bekijken' en vormt de UI voor het bekijken van een werkrooster.
    De CC die bij deze pagina hoort is te vinden in de map CC met als naam 'CCWerkroosterBekijken.cs'
    Auteur: Camiel Kerkhofs
--%>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 27px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpMainContent" runat="server">
    
    Selecteer de vrijwilliger waarvan u het werkrooster wilt bekijken: <br /> <asp:DropDownList ID="DropDownListNamen" runat="server" Width="200px" AppendDataBoundItems="True"><asp:ListItem Text="Kies een vrijwilliger.." Value="" /></asp:DropDownList>
    <asp:RequiredFieldValidator ID="RequiredFieldValidatorVrijwilliger" runat="server" ControlToValidate="DropDownListNamen" CssClass="ErrorMessage" ErrorMessage="Kies een vrijwilliger">*</asp:RequiredFieldValidator>
    <br /> <asp:Button ID="Button1" runat="server" Text="Werkrooster bekijken" Width="197px" OnClick="Button1_Click" />
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" CssClass="ErrorMessage" HeaderText="Los aub de volgende fouten op:" ShowMessageBox="True" ShowSummary="False" Height="88px" />
    
    <span id="werkroosterSpan" runat="server" Visible="False">
        <br /><br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label><br />
        <asp:GridView ID="GridView1" HeaderStyle-BackColor="#aaaaaa" HeaderStyle-ForeColor="White" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="Datum" HeaderText="Datum" ItemStyle-Width="150" />
                <asp:BoundField DataField="Begintijd" HeaderText="Begintijd" ItemStyle-Width="150" />
                <asp:BoundField DataField="Eindtijd" HeaderText="Eindtijd" ItemStyle-Width="150" />
                <asp:BoundField DataField="Taak" HeaderText="Taak" ItemStyle-Width="150" />
            </Columns>
        </asp:GridView>
    </span>
 
</asp:Content>
