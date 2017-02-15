<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="PunishUpdate.aspx.vb" Inherits="PunishUpdate" title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    &gt;&gt;编辑处分信息<br />
    学 &nbsp; &nbsp; &nbsp; 号：<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
    处分名称：<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />
    处分原因：<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><br />
    处分时间：<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox><br />
    <asp:Button ID="btnSave" runat="server" Text="保存" />
    <asp:Button ID="btnReturn" runat="server" Text="返回" /><br />
    <asp:Label ID="LabelWarningMessage" runat="server" Text="Label"></asp:Label>
</asp:Content>

