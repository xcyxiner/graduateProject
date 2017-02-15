<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="HealthUpdate.aspx.vb" Inherits="HealthUpdate" title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    &gt;&gt;编辑每周卫生检查信息<br />
    周 &nbsp; &nbsp; &nbsp;&nbsp; 数：<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
    宿舍类型：<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />
    宿舍楼号：<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><br />
    宿舍 &nbsp;&nbsp; 号：<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox><br />
    得 &nbsp; &nbsp; &nbsp; &nbsp;分：<asp:TextBox ID="TextBox5" runat="server"></asp:TextBox><br />
    评价等级：<asp:TextBox ID="TextBox6" runat="server"></asp:TextBox><br />
    <asp:Button ID="btnSave" runat="server" Text="保存" />
    <asp:Button ID="btnReturn" runat="server" Text="返回" /><br />
    <asp:Label ID="LabelWarningMessage" runat="server" Text="Label"></asp:Label>
</asp:Content>

