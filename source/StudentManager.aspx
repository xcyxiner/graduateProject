<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="StudentManager.aspx.vb" Inherits="StudentManager" title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
&gt;&gt;学生信息管理<br />
    学号：<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><asp:Button ID="btnQuery"
        runat="server" Text="查询" />
    <asp:Button ID="Button1" runat="server" Text="显示所有" /><br />
    <asp:GridView ID="GV" runat="server" AllowPaging ="true" AutoGenerateColumns="false"  PageSize="5" OnPageIndexChanging="GV_PageIndexChanging">
    <Columns>
    <asp:TemplateField>
    <ItemTemplate>
    <asp:CheckBox ID="chkSelected" runat="server" Checked="false"  Visible="true" />
    </ItemTemplate></asp:TemplateField>
    <asp:BoundField DataField="StudentId" HeaderText="学号" />
    <asp:BoundField DataField="StudentName" HeaderText="姓名" />
    <asp:BoundField DataField="StudentPassword" HeaderText="密码" />
    <asp:BoundField DataField="StudentSex" HeaderText="性别" />
    <asp:BoundField DataField="DormitoryType" HeaderText="宿舍类型" />
    <asp:BoundField DataField="FloorId" HeaderText="宿舍楼号" />
    <asp:BoundField DataField="DormitoryId" HeaderText="宿舍号" />
    </Columns>
    </asp:GridView>
    &nbsp;
    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/StudentAdd.aspx">添加</asp:HyperLink>
    <asp:Button ID="btnUpdate" runat="server" Text="修改" />
    <asp:Button ID="btnDelete" runat="server" Text="删除" />
</asp:Content>

