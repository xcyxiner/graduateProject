<%@ Control Language="VB" AutoEventWireup="false" CodeFile="Left.ascx.vb" Inherits="Left" %>
<asp:TreeView ID="Tree" runat="server" ImageSet="Arrows">
<DataBindings>
<asp:TreeNodeBinding DataMember="lev0" TextField="name" />
<asp:TreeNodeBinding DataMember="lev1" TextField="name"  NavigateUrlField="url"/>
<asp:TreeNodeBinding DataMember="lev2" TextField="name"  NavigateUrlField ="url" />
</DataBindings>
</asp:TreeView>
