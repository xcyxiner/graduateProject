<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="AddIPQAdd.aspx.vb" Inherits="AddIPQAdd" title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    &gt;&gt;添加IPQ加分信息<br />
    学 &nbsp; &nbsp; &nbsp; 号：<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
    加分原因：<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />
    所加分值：<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><br />
    <asp:Button ID="btnSave" runat="server" Text="保存" />
    <asp:Button ID="btnReturn" runat="server" Text="返回" /><br />
    <asp:Label ID="LabelWarningMessage" runat="server" Text="Label"></asp:Label>
</asp:Content>

