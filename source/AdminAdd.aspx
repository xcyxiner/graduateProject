<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="AdminAdd.aspx.vb" Inherits="AdminAdd" title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    &gt;&gt;添加管理员<br />
    用户名：<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
    密 &nbsp; &nbsp;码：<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />
    权 &nbsp;&nbsp; 限：<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><br />
    <asp:Button ID="btnSave" runat="server" Text="保存" />
    <asp:Button ID="btnReturn" runat="server" Text="返回" /><br />
    <asp:Label ID="LabelWarningMessage" runat="server" Text="Label"></asp:Label>
</asp:Content>

