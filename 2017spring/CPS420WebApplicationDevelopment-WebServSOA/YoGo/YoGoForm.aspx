<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="YoGoForm.aspx.cs" Inherits="YoGo.YoGoForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <title></title>
    <style type="text/css">
        table
        {
            background-color: yellow;
       
        }
        td#toppings
        {
            background-color: pink;

        }
        td#heading
        {
            background-color: orange;
            font-family: 'Segoe UI';
            font-size: 24px;
            font-style: oblique;
            font-weight:900;

        }
        td#icetype
        {
            background-color: lawngreen;

        }
        .auto-style1 {
            width: 57%;
        }
        .auto-style2 {
            width: 180px;
        }
        .auto-style3 {
            width: 180px;
            height: 67px;
        }
        .auto-style4 {
            height: 67px;
        }
        .auto-style5 {
            width: 293px;
        }
        .auto-style6 {
            height: 67px;
            width: 293px;
        }
        .auto-style7 {
            width: 175px;
        }
        .auto-style8 {
            height: 67px;
            width: 175px;
        }
    </style>
    
</head>
<body>
    <form id="form1" runat="server">
    <div id="yoGo">
    
        <table class="auto-style1" id="yoTable">
            <tr>
                <td class="auto-style2">
                    <br />
                </td>
                <td class="auto-style5" id="heading" colspan="2">Welcome to the YoGo Shop Order App</td>
                <td class="auto-style7">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2" id="toppings">
                    <asp:Label ID="lblSize0" runat="server" Text="Toppings"></asp:Label>
                    <br />
                    <asp:CheckBox ID="chkSprinkles" runat="server" Text="Sprinkles" />
                    <br />
                    <asp:CheckBox ID="chkWaffle" runat="server" Text="Waffle" />
                    <br />
                    <asp:CheckBox ID="chkFruit" runat="server" Text="Fruit" />
                    <br />
                    <asp:CheckBox ID="chkCoating" runat="server" Text="Coating" />
                </td>
                <td class="auto-style5" id="size">
                    <asp:Label ID="lblSize" runat="server" Text="Size"></asp:Label>
                    <br />
                    <asp:DropDownList ID="ddlSize" runat="server">
                    </asp:DropDownList>
                </td>
                <td class="auto-style7">
                    <asp:TextBox ID="txtMyOrder" runat="server" Height="99px" Width="250px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3" id="icetype">
                    <asp:RadioButton ID="rdoIceCream" runat="server" GroupName="froType" Text="Ice Cream" />
                    <br />
                    <asp:RadioButton ID="rdoFroYo" runat="server" GroupName="froType" Text="Frozen Yogurt" />
                    <br />
                    <asp:RadioButton ID="rdoSherbet" runat="server" GroupName="froType" Text="Sherbet" />
                </td>
                <td class="auto-style6">
                    <asp:Label ID="Label1" runat="server" Text="Tip Amount: "></asp:Label>
                    <asp:TextBox ID="txtTip" runat="server" Width="58px"></asp:TextBox>
                </td>
                <td class="auto-style8">
                    <asp:Button ID="cmdShowOrder" runat="server" OnClick="cmdShowOrder_Click" Text="Show Order" Width="98px" />
                </td>
                <td class="auto-style4"></td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
