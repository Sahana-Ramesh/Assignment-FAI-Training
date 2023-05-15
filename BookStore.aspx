<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BookStore.aspx.cs" Inherits="SampleWebApp.BookStore" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<link href="Common/MainStyle.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Book Search</h2>
            <asp:Label ID="lblSearchCriteria" runat="server" Text="Search Criteria:"></asp:Label>
            <asp:TextBox ID="txtSearchCriteria" runat="server"></asp:TextBox>
            <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" />
        </div>
        <hr />
        <div>
            <asp:Repeater ID="rptBooks" runat="server">
                <ItemTemplate>
                    <h3><%# Eval("Title") %></h3>
                    <p><strong>Author:</strong> <%# Eval("Author") %></p>
                    <p><strong>Genre:</strong> <%# Eval("Genre") %></p>
                    <p><strong>Publication Year:</strong> <%# Eval("PublicationYear") %></p>
                    <hr />
                </ItemTemplate>
            </asp:Repeater>

        </div>
    </form>
</body>
</html>
