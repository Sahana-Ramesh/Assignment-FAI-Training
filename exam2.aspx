<%@ Master Language="C#" AutoEventWireup="true" CodeBehind="Site.master.cs" Inherits="Assessment2.SiteMaster" %>

<!DOCTYPE html>

<html lang="en">
<head runat="server">
    <link href="Common/MainStyle.css" rel="stylesheet" />
    <title>My Words</title>

</head>
<body>
    <form runat="server">
        <h1>My words</h1>
        <table style="place-content: center">
            <tr>
                <td style="width: 250px">English Word </td>
                <td style="width: 250px">
                    <asp:TextBox runat="server" ID="txtWord" Width="500px" Height="50px" />
                </td>
                <td style="width: 250px">
                    <asp:Button runat="server" Text="Search" Font-Size="Large" OnClick="searchOperation"  />
                </td>
            </tr>

        </table>
        <hr />
        <hr />
        <hr />

        <div>
            <table style="place-content: center">
        <tr>
            <td style="width: 250px; text-align:center">Word </td>
            <td style="width: 250px;text-align:center">Translation </td>
            <td style="width: 250px;text-align:center">Action </td>
        </tr>
        <tr>
            <td>
                <asp:Label runat="server" ID="lblWord" />
            </td>
            <td style="width: 250px">
                <asp:TextBox runat="server" ID="txtWord2" Width="500px" Height="50px" />
            </td>
            <td style="width: 250px">
                <asp:Button runat="server" Text="Add to my words" Font-Size="Large" OnClick="Unnamed1_Click" />
            </td>
        </tr>

    </table>
        </div>


    </form>
</body>
</html>
