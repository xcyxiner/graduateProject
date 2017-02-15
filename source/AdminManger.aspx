<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="AdminManger.aspx.vb" Inherits="AdminManger" title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
&gt;&gt;管理员信息管理<br />
    用户名：<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><asp:Button ID="btnQuery"
        runat="server" Text="查询" />
    <asp:Button ID="Button1" runat="server" Text="显示所有" /><br />
    <asp:GridView ID="GV" runat="server" AllowPaging ="true" AutoGenerateColumns="false"  PageSize="5" OnPageIndexChanging="GV_PageIndexChanging" >
    <Columns>
    <asp:TemplateField>
    <ItemTemplate>
    <asp:CheckBox ID="chkSelected" runat="server" Checked="false"  Visible="true" />
    </ItemTemplate></asp:TemplateField>
    <asp:BoundField DataField="UserName" HeaderText="用户名" />
    <asp:BoundField DataField="Password" HeaderText="密码" />
    <asp:BoundField DataField="Role" HeaderText="权限" />
    </Columns>
    </asp:GridView>
    &nbsp;
    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/AdminAdd.aspx">添加</asp:HyperLink>
    <asp:Button ID="btnUpdate" runat="server" Text="修改" />
    <asp:Button ID="btnDelete" runat="server" Text="删除" />
</asp:Content>

