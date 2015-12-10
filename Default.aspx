<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>IIO13200 .NET-ohjelmointi</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>

        <div id="navigation">
                        <ul id="nav">
                            <li><a href="default.aspx">Home</a></li>
                            <li><a href="Tehtavat/G2968_T1/G2968_Tehtava1c.aspx">Tehtävä1</a></li>
                            <li><a href="Tehtavat/G2968_T2/G2968_Tehtava2ASP.aspx">Tehtävä2</a></li>
                            <li><a href="Tehtavat/G2968_T3/G2968_Default.aspx">Tehtävä3</a></li>              
                        </ul>
            </div>
    <h1>IIO13200 .NET-ohjelmointikoe</h1>
        <p>Tee websitellä uusi index-sivu, ja tee tehtäville kullekin oma sivu. Nimeä sivut ohjeiden mukaan. Kaikki tarvittavat tehtävissä tarvittavat tiedostot on tallennettava websiten alikansioihin.<br /> Onnea ja menestystä kokeeseen.</p>
    <h2>Kokeeseen osallistuvat</h2>
        <p>Testataan yhteys Eight-palvelimelle:</p>
        <asp:SqlDataSource ID="srcIlmot" 
      ConnectionString="<%$ ConnectionStrings:Ilmot%>"
      SelectCommand="SELECT DISTINCT asioid, lastname, firstname FROM vLasnaolot_IIO13200  ORDER BY lastname "
       runat="server"></asp:SqlDataSource>
        <asp:GridView ID="myGridView" runat="server" DataSourceID="srcIlmot"></asp:GridView>


    </div>
    </form>
</body>
</html>
