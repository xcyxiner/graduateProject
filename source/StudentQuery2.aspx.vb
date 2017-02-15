Imports System.Data
Imports System.Data.SqlClient
Partial Class StudentQuery2
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Query()
    End Sub
    Public Sub Query()
        Dim queryItems As Hashtable = New Hashtable
        queryItems.Add("StudentId", Session("student").ToString)
        Dim dt As DataTable = StudentLogic.QueryUsers(queryItems)
        GV.DataSource = dt
        GV.DataBind()
    End Sub
    Protected Sub GV_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles GV.PageIndexChanging
        GV.PageIndex = e.NewPageIndex
        Query()
    End Sub
End Class
