<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="StudentQuery2.aspx.vb" Inherits="StudentQuery2" title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    &gt;&gt;我的基本信息<br />
    <asp:GridView ID="GV" runat="server" AllowPaging ="true" AutoGenerateColumns="false"  PageSize="5" OnPageIndexChanging="GV_PageIndexChanging" >
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

