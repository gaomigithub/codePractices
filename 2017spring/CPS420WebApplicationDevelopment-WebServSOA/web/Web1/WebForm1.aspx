﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="WebForm1.aspx.cs" Inherits="WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Label ID="lblbooks" runat="server" Text=""></asp:Label>
        <asp:Button ID="btnBooks" runat="server" Text="Button" OnClick="btnBooks_Click" />
    </div>
    </form>
</body>
</html>
