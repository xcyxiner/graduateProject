<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="IPQQuery.aspx.vb" Inherits="IPQQuery" title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class="left">
    &gt;&gt;IPQ加分查询<br />
        学号：<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><asp:Button ID="btnQuery"
        runat="server" Text="查询" />
    <asp:Button ID="Button1" runat="server" Text="显示所有" /><br />
    <asp:GridView ID="GV" runat="server" AllowPaging ="true" AutoGenerateColumns="false"  PageSize="5" OnPageIndexChanging="GV_PageIndexChanging">
    <Columns>
    <asp:BoundField DataField="AddId" HeaderText="编号" />
    <asp:BoundField DataField="StudentId" HeaderText="学号" />
    <asp:BoundField DataField="AddReason" HeaderText="加分原因" />
    <asp:BoundField DataField="AddScore" HeaderText="所加分值" />
    </Columns>
    </asp:GridView>
</div>
<div class ="right">
    &gt;&gt;IPQ扣分查询<br />
        学号：<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><asp:Button ID="btnFind"
        runat="server" Text="查询" />
    <asp:Button ID="Button3" runat="server" Text="显示所有" /><br />
    <asp:GridView ID="GV2" runat="server" AllowPaging ="true" AutoGenerateColumns="false"  PageSize="5" OnPageIndexChanging="GV2_PageIndexChanging">
    <Columns>
    <asp:BoundField DataField="SubtractionId" HeaderText="编号" />
    <asp:BoundField DataField="StudentId" HeaderText="学号" />
    <asp:BoundField DataField="SubtractionReason" HeaderText="扣分原因" />
    <asp:BoundField DataField="SubtractionScore" HeaderText="所扣分值" />
    </Columns>
    </asp:GridView>
</div>
</asp:Content>

