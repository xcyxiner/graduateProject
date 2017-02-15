<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="HealthQuery.aspx.vb" Inherits="HealthQuery" title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    &gt;&gt;查询每周卫生检查结果<br />
        周数：<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><asp:Button ID="btnQuery"
        runat="server" Text="查询" />
    <asp:Button ID="Button1" runat="server" Text="显示所有" /><br />
    <asp:GridView ID="GV" runat="server" AllowPaging ="true" AutoGenerateColumns="false"  PageSize="5" OnPageIndexChanging="GV_PageIndexChanging">
    <Columns>
    <asp:BoundField DataField="HealthId" HeaderText="编号" />
    <asp:BoundField DataField="Week" HeaderText="周数" />
    <asp:BoundField DataField="DormitoryType" HeaderText="宿舍类型" />
    <asp:BoundField DataField="FloorId" HeaderText="宿舍楼号" />
    <asp:BoundField DataField="DormitoryId" HeaderText="宿舍号" />
    <asp:BoundField DataField="HealthScore" HeaderText="得分" />
    <asp:BoundField DataField="HealthGrade" HeaderText="评价等级" />
    </Columns>
    </asp:GridView>
</asp:Content>

