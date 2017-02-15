Imports System.Data
Imports System.Data.SqlClient
Partial Class AttendanceQuery
    Inherits System.Web.UI.Page
    Shared username As String
    Protected Sub btnQuery_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnQuery.Click
        Me.username = Me.TextBox1.Text.Trim
        Query()
        Me.TextBox1.Text = ""
    End Sub
    Private Sub Query()
        Dim queryItems As Hashtable = New Hashtable
        queryItems.Add("Week", AttendanceQuery.username)
        Dim dt As DataTable = AttendanceLogic.QueryUsers(queryItems)
        GV.DataSource = dt
        GV.DataBind()
    End Sub
    Private Sub QueryALL()
        Me.TextBox1.Text = ""
        AttendanceQuery.username = ""
        Dim dt As DataTable = AttendanceLogic.Query
        GV.DataSource = dt
        GV.DataBind()
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click

        QueryALL()
    End Sub

    Protected Sub GV_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles GV.PageIndexChanging
        GV.PageIndex = e.NewPageIndex
        If AttendanceQuery.username = "" Then
            QueryALL()
        Else
            Query()
        End If
    End Sub
End Class
