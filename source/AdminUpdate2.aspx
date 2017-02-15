<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="AdminUpdate2.aspx.vb" Inherits="AdminUpdate2" title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    &gt;&gt;修改密码<br />
    用户名：<asp:TextBox ID="TextBox1" runat="server" ReadOnly="True"></asp:TextBox><br />
    密 &nbsp; &nbsp;码：<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />
     权 &nbsp;&nbsp; 限：<asp:TextBox ID="TextBox3" runat="server" ReadOnly="True"></asp:TextBox><br />
    <asp:Button ID="btnSave" runat="server" Text="保存" />
    <asp:Label ID="LabelWarningMessage" runat="server" Text="Label"></asp:Label>
</asp:Content>

