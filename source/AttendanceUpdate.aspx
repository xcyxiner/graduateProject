<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="AttendanceUpdate.aspx.vb" Inherits="AttendanceUpdate" title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    &gt;&gt;编辑每周考勤信息<br />
    学 &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; 号：<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
    周 &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; 数：<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />
    学 &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; 期：<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><br />
    旷课次 &nbsp;&nbsp; 数：<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox><br />
    旷早操次数：<asp:TextBox ID="TextBox5" runat="server"></asp:TextBox><br />
    <asp:Button ID="btnSave" runat="server" Text="保存" />
    <asp:Button ID="btnReturn" runat="server" Text="返回" /><br />
    <asp:Label ID="LabelWarningMessage" runat="server" Text="Label"></asp:Label>
</asp:Content>

