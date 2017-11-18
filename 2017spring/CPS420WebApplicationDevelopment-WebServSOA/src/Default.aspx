<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PizzaApp._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Pizza App</title>
</head>
<body>
    <form id="id_order" runat="server" style="width:800px;margin-left:auto;margin-right:auto;">
        <asp:Label ID="id_heading" runat="server" style="margin-left:280px;height:80px; line-height:80px;" Text="Mi's Pizza Joint"  
            ForeColor="#000066" Font-Bold="True" Font-Names="Comic Sans MS" Font-Size="XX-Large"></asp:Label><br />

        <div style="width:40%;float:left;">
            <asp:DropDownList style="width:200px;height:25px;margin-left:6px;" ID="id_size" runat="server" AutoPostBack="True">
                <asp:ListItem>Small</asp:ListItem>
                <asp:ListItem>Medium</asp:ListItem>
                <asp:ListItem>Large</asp:ListItem>
                <asp:ListItem>Extra Large</asp:ListItem>
            </asp:DropDownList><br />

            <table>
                <tr>
                    <td>
                        <div style="margin-top:5px;">
                            <asp:CheckBox ID="id_sausage" runat="server" AutoPostBack="True" Text="Sausage" OnCheckedChanged="on_updating_detail"/><br />
                            <asp:CheckBox ID="id_mushrooms" runat="server" AutoPostBack="True" Text="Mushrooms" OnCheckedChanged="on_updating_detail"/><br />
                            <asp:CheckBox ID="id_peppers" runat="server" AutoPostBack="True" Text="Peppers" OnCheckedChanged="on_updating_detail"/><br />
                            <asp:CheckBox ID="id_onions" runat="server" AutoPostBack="True" Text="Onions" OnCheckedChanged="on_updating_detail"/><br />
                        </div>
                    </td>

                    <td align="left">
                        <div style="margin-top:5px;">
                            <asp:RadioButton ID="id_thin_crust" runat="server" GroupName="g_kind" AutoPostBack="True" Text="Thin Crust" OnCheckedChanged="on_updating_detail"/><br />
                            <asp:RadioButton ID="id_deep_fish" runat="server" GroupName="g_kind" AutoPostBack="True" Text="Deep Fish" OnCheckedChanged="on_updating_detail"/><br />
                            <asp:RadioButton ID="id_pan_pizza" runat="server" GroupName="g_kind" AutoPostBack="True" Text="Pan Pizza" OnCheckedChanged="on_updating_detail"/><br />
                            <asp:RadioButton style="visibility:hidden" runat="server" Text=""/><br />
                        </div>
                    </td>
                </tr>
            </table>
            <br /><br />

            <asp:CheckBox style="margin-top:5px;margin-left:4px;" ID="id_delivery" runat="server" AutoPostBack="True" Text="Delivery($3.00)" OnCheckedChanged="on_updating_detail"/><br />
            <asp:Label style="margin-top:5px;margin-left:8px;" runat="server" Text="Tip Amount($): "></asp:Label>
            <asp:TextBox ID="id_tip" runat="server" Width="80px"></asp:TextBox><br /><br /><br />

            <asp:Button style="margin-left:10px;width:90px;" ID="id_add" runat="server" Text="Add to Pizza" OnClick="on_updating_detail" />
            <asp:Button style="margin-left:70px;width:90px;" ID="id_clear" runat="server" Text="Clear" OnClick="id_clear_Click" /><br />
        </div>

        <div style="width:60%;float:left;">
            <asp:Label runat="server" Text="Pizza Detail: "></asp:Label><br />
            <asp:TextBox ID="id_detail" runat="server" Height="28px" ReadOnly="True" TextMode="MultiLine" Width="465px"></asp:TextBox><br /><br />

            <asp:Button ID="id_invoice" runat="server" Text="Invoice" OnClick="id_invoice_Click" /><br /><br />
            <asp:TextBox ID="id_invoice_text" runat="server" Height="139px" TextMode="MultiLine" Width="465px"></asp:TextBox>
        </div>
    </form>
</body>
</html>
