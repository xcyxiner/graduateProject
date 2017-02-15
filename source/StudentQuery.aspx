<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="StudentQuery.aspx.vb" Inherits="StudentQuery" title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    &gt;&gt;查询用户<br />
    学号：<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><asp:Button ID="btnQuery"
        runat="server" Text="查询" />
    <asp:Button ID="Button1" runat="server" Text="显示所有" /><br />
    <asp:GridView ID="GV" runat="server" AllowPaging ="true" AutoGenerateColumns="false"  PageSize="5" OnPageIndexChanging="GV_PageIndexChanging">
    <Columns>
    <asp:BoundField DataField="StudentId" HeaderText="学号" />
    <asp:BoundField DataField="StudentName" HeaderText="姓名" />
    <asp:BoundField DataField="StudentSex" HeaderText="性别" />
    <asp:BoundField DataField="DormitoryType" HeaderText="宿舍类型" />
    <asp:BoundField DataField="FloorId" HeaderText="宿舍楼号" />
    <asp:BoundField DataField="DormitoryId" HeaderText="宿舍号" />
    </Columns>
    </asp:GridView>
</asp:Content>

