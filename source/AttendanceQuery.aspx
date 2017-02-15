<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="AttendanceQuery.aspx.vb" Inherits="AttendanceQuery" title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    &gt;&gt;查询每周考勤信息<br />
        周数：<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><asp:Button ID="btnQuery"
        runat="server" Text="查询" />
    <asp:Button ID="Button1" runat="server" Text="显示所有" /><br />
    <asp:GridView ID="GV" runat="server" AllowPaging ="true" AutoGenerateColumns="false"  PageSize="5" OnPageIndexChanging="GV_PageIndexChanging">
    <Columns>
    <asp:BoundField DataField="AttendanceId" HeaderText="编号" />
    <asp:BoundField DataField="StudentId" HeaderText="学号" />
    <asp:BoundField DataField="Week" HeaderText="周数" />
    <asp:BoundField DataField="Semester" HeaderText="学期" />
    <asp:BoundField DataField="StayAway" HeaderText="旷课次数" />
    <asp:BoundField DataField="DesertExercises" HeaderText="旷早操次数" />
    </Columns>
    </asp:GridView>
</asp:Content>

