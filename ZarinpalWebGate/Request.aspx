<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Request.aspx.vb" Inherits="ZarinpalWebGate.RequestForm" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="frmRequest" runat="server">
    <div>
    
        مبلغ<asp:TextBox ID="txtAmount" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label1" runat="server" Text="توضيحات"></asp:Label>
        <asp:TextBox ID="txtDescription" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="btnOk" runat="server" Height="25px" Text="Button" />
    
    </div>
    </form>
</body>
</html>
