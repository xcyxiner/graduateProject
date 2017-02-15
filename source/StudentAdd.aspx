<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="StudentAdd.aspx.vb" Inherits="StudentAdd" title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    &gt;&gt;添加用户<br />
    学 &nbsp; &nbsp; &nbsp; 号：<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
    姓 &nbsp; &nbsp; &nbsp; 名：<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />
    密 &nbsp; &nbsp; &nbsp; 码：<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><br />
    性 &nbsp; &nbsp; &nbsp; 别：<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox><br />
    宿舍类型：<asp:TextBox ID="TextBox5" runat="server"></asp:TextBox><br />
    宿舍楼号：<asp:TextBox ID="TextBox6" runat="server"></asp:TextBox><br />
    宿舍 &nbsp;&nbsp; 号：<asp:TextBox ID="TextBox7" runat="server"></asp:TextBox><br />
    <asp:Button ID="btnSave" runat="server" Text="保存" />
    <asp:Button ID="btnReturn" runat="server" Text="返回" /><br />
    <asp:Label ID="LabelWarningMessage" runat="server" Text="Label"></asp:Label>
</asp:Content>

