<%@ Page Language="C#" AutoEventWireup="true" CodeFile="G2968_Tehtava2ASP.aspx.cs" Inherits="Tehtavat_G2968_T2_G2968_Tehtava2ASP" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>    
        <asp:Button ID="btnVakituiset" runat="server" Text="Vakituiset" OnClick="btnVakituiset_Click" />
        <asp:Button ID="btnMaaraaikaiset" runat="server" Text="Määräaikaiset" OnClick="btnMaaraaikaiset_Click" />
        <asp:Button ID="btnMuut" runat="server" Text="Muut" OnClick="btnMuut_Click" />
        <asp:GridView ID="GridView1" runat="server"></asp:GridView>
         <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
    </div>
    </form>
</body>
</html>
