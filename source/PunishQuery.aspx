<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="PunishQuery.aspx.vb" Inherits="PunishQuery" title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    &gt;&gt;查询处分<br />
    学号：<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><asp:Button ID="btnQuery"
        runat="server" Text="查询" />
        <asp:Button ID="Button1" runat="server" Text="显示所有" /><br />
    <asp:GridView ID="GV" runat="server" AllowPaging ="true" AutoGenerateColumns="false"  PageSize="5" OnPageIndexChanging="GV_PageIndexChanging">
    <Columns>
    <asp:BoundField DataField="PunishId" HeaderText="处分编号" />
    <asp:BoundField DataField="StudentId" HeaderText="学号" />
    <asp:BoundField DataField="PunishName" HeaderText="处分名称" />
    <asp:BoundField DataField="PunishReason" HeaderText="处分原因" />
    <asp:BoundField DataField="PunishDateTime" HeaderText="处分时间" />
    </Columns>
    </asp:GridView>
</asp:Content>

