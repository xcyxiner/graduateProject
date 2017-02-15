Imports System.Data
Imports System.Data.SqlClient
Partial Class PunishQuery
    Inherits System.Web.UI.Page
    Shared username As String
    Protected Sub btnQuery_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnQuery.Click
        PunishQuery.username = Me.TextBox1.Text.Trim
        Query()
        Me.TextBox1.Text = ""
    End Sub
    Private Sub Query()
        Dim queryItems As Hashtable = New Hashtable
        queryItems.Add("StudentId", PunishQuery.username)
        Dim dt As DataTable = PunishLogic.QueryUsers(queryItems)
        GV.DataSource = dt
        GV.DataBind()
    End Sub
    Private Sub QueryALL()
        Me.TextBox1.Text = ""
        PunishQuery.username = ""
        Dim dt As DataTable = PunishLogic.Query
        GV.DataSource = dt
        GV.DataBind()
    End Sub
    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click

        QueryALL()
    End Sub

    Protected Sub GV_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles GV.PageIndexChanging
        GV.PageIndex = e.NewPageIndex
        If PunishQuery.username = "" Then
            QueryALL()
        Else
            Query()
        End If
    End Sub
End Class
