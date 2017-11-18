<%@ Page Language="C#" AutoEventWireup="true" CodeFile="WebForm4.aspx.cs" Inherits="WebForm4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <asp:ListView ID="lstBooks" runat="server" >            
  <LayoutTemplate>
    <div class="PrettyGrid">
      <table cellpadding="1" cellspacing="1" summary="">
        <thead>
          <tr>
            <th scope="col">ID</th>
            <th scope="col">Title</th>
            <th scope="col">Price</th>
              <th scope="col">DateOfRelease</th>
          </tr>
        </thead>
        <tbody>
          <asp:PlaceHolder ID="itemPlaceholder" runat="server" />  
        </tbody>
      </table>
    </div>
  </LayoutTemplate>

  <AlternatingItemTemplate>
    <tr class="Alternate">
      <td><asp:Label ID="IDLabel" runat="server" 
        Text='<%# Eval("ID") %>' /></td>
      <td><asp:Label ID="TitleLabel" runat="server" 
        Text='<%# Eval("Title") %>' /></td>
      <td><asp:Label ID="PriceLabel" runat="server" 
        Text='<%# Eval("Price") %>' />  </td>
        <td><asp:Label ID="DateOfReleaseLabel" runat="server" 
        Text='<%# Eval("DateOfRelease") %>' />  </td>
    </tr>
  </AlternatingItemTemplate>  

  <ItemTemplate>
     <tr class="Alternate">
      <td><asp:Label ID="IDLabel" runat="server" 
        Text='<%# Eval("ID") %>' /></td>
      <td><asp:Label ID="TitleLabel" runat="server" 
        Text='<%# Eval("Title") %>' /></td>
      <td><asp:Label ID="PriceLabel" runat="server" 
        Text='<%# Eval("Price") %>' />  </td>
        <td><asp:Label ID="DateOfReleaseLabel" runat="server" 
        Text='<%# Eval("DateOfRelease") %>' />  </td>
    </tr>
  </ItemTemplate>
</asp:ListView>
    </div>
    </form>
</body>
</html>
