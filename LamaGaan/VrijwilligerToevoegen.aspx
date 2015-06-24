<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VrijwilligerToevoegen.aspx.cs" Inherits="LamaGaan.VrijwilligerToevoegen" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        
        <%--formulier voor invullen persoons gegevens--%>

        naam:
        <asp:TextBox ID="TbNaam" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="BtOpslaan" runat="server" Text="Opslaan" OnClick="BtOpslaan_Click" />

    </div>
    </form>
</body>
</html>
