<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Stocks.WebForm1" %>

<!DOCTYPE html>
<script runat="server">

</script>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 374px;
        }
        .auto-style3 {
            width: 227px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <br />
        <br />
        <table class="auto-style1">
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style2">Welcome to the Automobile Stock Application!<br />
                    <br />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:DropDownList ID="lstAutomobileName" runat="server" AutoPostBack="True" OnSelectedIndexChanged="lstAutomobileName_SelectedIndexChanged" ToolTip="Select A Automobile to Reveal it's Info">
                    </asp:DropDownList>
                </td>
                <td class="auto-style2">Automobile Name</td>
                <td>
                    <asp:TextBox ID="txtAutomobileName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style2">Stock Symbol</td>
                <td>
                    <asp:TextBox ID="txtStockSymbol" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style2">Current Stock Price</td>
                <td>
                    <asp:TextBox ID="txtStockPrice" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style2">Market Cap</td>
                <td>
                    <asp:TextBox ID="txtMarketCap" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style2"># Employees</td>
                <td>
                    <asp:TextBox ID="txtNumEmployees" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style2">Headquarters</td>
                <td>
                    <asp:TextBox ID="txtHQ" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style2">
        <asp:Button ID="btnNewAutomobile" runat="server" Text="New Automobile" OnClick="btnNewAutomobile_Click" />
                </td>
                <td>
        <asp:Button ID="btnSubmitAutomobile" runat="server" Text="Submit Automobile" OnClick="btnSubmitAutomobile_Click" />
                </td>
            </tr>

        </table>
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
