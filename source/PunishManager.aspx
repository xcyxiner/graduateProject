<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="PunishManager.aspx.vb" Inherits="PunishManager" title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    &gt;&gt;学生处分信息管理<br />
        学号：<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><asp:Button ID="btnQuery"
        runat="server" Text="查询" />
    <asp:Button ID="Button1" runat="server" Text="显示所有" /><br />
    <asp:GridView ID="GV" runat="server" AllowPaging ="true" AutoGenerateColumns="false"  PageSize="5" OnPageIndexChanging="GV_PageIndexChanging">
    <Columns>
    <asp:TemplateField>
    <ItemTemplate>
    <asp:CheckBox ID="chkSelected" runat="server" Checked="false"  Visible="true" />
    </ItemTemplate></asp:TemplateField>
    <asp:BoundField DataField="PunishId" HeaderText="处分编号" />
    <asp:BoundField DataField="StudentId" HeaderText="学号" />
    <asp:BoundField DataField="PunishName" HeaderText="处分名称" />
    <asp:BoundField DataField="PunishReason" HeaderText="处分原因" />
    <asp:BoundField DataField="PunishDateTime" HeaderText="处分时间" />
    </Columns>
    </asp:GridView>
    &nbsp;
    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/PunishAdd.aspx">添加</asp:HyperLink>
    <asp:Button ID="btnUpdate" runat="server" Text="修改" />
    <asp:Button ID="btnDelete" runat="server" Text="删除" />
</asp:Content>

