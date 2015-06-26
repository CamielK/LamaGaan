<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WerkroosterMaken.aspx.cs" Inherits="LamaGaan.VrijwilligerToevoegen" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
        <br />
        <asp:Button ID="BtZoekpersoon" runat="server" Text="zoek persoon" OnClick="BtZoekpersoon_Click" />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </div>
    </form>
</body>
</html>
