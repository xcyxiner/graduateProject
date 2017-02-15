<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="IPQQuery2.aspx.vb" Inherits="IPQQuery2" title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class="left">
    &gt;&gt;我的IPQ加分<br />
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
    &gt;&gt;我的IPQ扣分<br />
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

