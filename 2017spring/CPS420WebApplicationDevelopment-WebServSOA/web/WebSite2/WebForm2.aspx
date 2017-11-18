<%@ Page Language="C#" AutoEventWireup="true" CodeFile="WebForm2.aspx.cs" Inherits="WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Panel ID="Panel1" runat="server" BackColor="#0066FF" Height="79px">
            <br />
            <br />
            Student ID
            <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
            &nbsp;<asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            </asp:DropDownList>
        </asp:Panel>
        <asp:Panel ID="Panel2" runat="server" BackColor="Aqua" Height="102px">
            <asp:ListBox ID="ListBox1" runat="server" Height="65px" Width="68px"></asp:ListBox>
        </asp:Panel>
        <br />
    </div>
    </form>
</body>
</html>
