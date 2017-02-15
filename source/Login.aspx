<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Login.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
        <link rel="stylesheet" type="text/css" href="StyleSheet.css" />
</head>
<body style="background-color: #9999ff; text-align: center;">
    <form id="form1" runat="server">
        <div id="wrap">
        <div id="top">
                    <div id="header">
                            <div id="logo">
                                    <a href="/" title="返回网站主页"> </a></div>
                        学生德育评价系统</div> 
        </div>
        <div id="left">
        
        </div>
        <div id="right">
                        用户名：
                        <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtUserName"
                            ErrorMessage="不能为空！"></asp:RequiredFieldValidator><br />
                        密  码：
                        <asp:TextBox ID="txtPwd" runat="server" TextMode="Password"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPwd"
                            ErrorMessage="不能为空！"></asp:RequiredFieldValidator> <br />
                        <asp:RadioButtonList ID="rblClass" runat="server" RepeatDirection="Horizontal">
                            <asp:ListItem Selected="True" Value="1">学生</asp:ListItem>
                            <asp:ListItem Value="2">管理员</asp:ListItem>
                            <asp:ListItem Value="3">辅导员</asp:ListItem>
                        </asp:RadioButtonList><br />
                        <asp:Label ID="lblMessage" runat="server"></asp:Label><br />
                        <asp:Button ID="btnLogin" runat="server" Text="登录" />
                        <asp:Button ID="btnClose" runat="server" Text="重置" />
        </div>
        <div id="bottom">
      &copy; 北方民族大学计算机系软件工程07级1班 版权所有   </div>
    </div>
           
    </form>
</body>
</html>
