Imports System.Data
Imports System.Data.SqlClient
Partial Class IPQQuery2
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Query()
        Query2()
    End Sub
    Private Sub Query()
        Dim queryItems As Hashtable = New Hashtable
        queryItems.Add("StudentId", Session("student").ToString)
        Dim dt As DataTable = AddIPQLogic.QueryUsers(queryItems)
        GV.DataSource = dt
        GV.DataBind()
    End Sub
    Private Sub Query2()
        Dim queryItems As Hashtable = New Hashtable
        queryItems.Add("StudentId", Session("student").ToString)
        Dim dt As DataTable = SubtractionIPQLogic.QueryUsers(queryItems)
        GV2.DataSource = dt
        GV2.DataBind()
    End Sub

    Protected Sub GV_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles GV.PageIndexChanging
        GV.PageIndex = e.NewPageIndex
        Query()
    End Sub

    Protected Sub GV2_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles GV2.PageIndexChanging
        GV2.PageIndex = e.NewPageIndex
        Query2()
    End Sub
End Class
