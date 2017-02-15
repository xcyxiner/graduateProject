Imports System.Data
Imports System.Data.SqlClient
Partial Class IPQQuery
    Inherits System.Web.UI.Page
    Shared username As String
    Shared username2 As String
    Protected Sub btnQuery_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnQuery.Click
        IPQQuery.username = Me.TextBox1.Text.Trim
        Query()
        Me.TextBox1.Text = ""
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click

        QueryALL()
    End Sub

    Protected Sub btnFind_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnFind.Click
        IPQQuery.username2 = Me.TextBox2.Text.Trim
        Query2()
        Me.TextBox2.Text = ""
    End Sub

    Protected Sub Button3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.Click

        QueryALL2()
    End Sub
    Private Sub QueryALL()
        Me.TextBox1.Text = ""
        IPQQuery.username = ""
        Dim dt As DataTable = AddIPQLogic.Query
        GV.DataSource = dt
        GV.DataBind()
    End Sub
    Private Sub Query()
        Dim queryItems As Hashtable = New Hashtable
        queryItems.Add("StudentId", IPQQuery.username)
        Dim dt As DataTable = AddIPQLogic.QueryUsers(queryItems)
        GV.DataSource = dt
        GV.DataBind()
    End Sub
    Private Sub QueryALL2()
        Me.TextBox2.Text = ""
        IPQQuery.username2 = ""
        Dim dt As DataTable = SubtractionIPQLogic.Query
        GV2.DataSource = dt
        GV2.DataBind()
    End Sub
    Private Sub Query2()
        Dim queryItems As Hashtable = New Hashtable
        queryItems.Add("StudentId", IPQQuery.username2)
        Dim dt As DataTable = SubtractionIPQLogic.QueryUsers(queryItems)
        GV2.DataSource = dt
        GV2.DataBind()
    End Sub

    Protected Sub GV_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles GV.PageIndexChanging
        GV.PageIndex = e.NewPageIndex
        If IPQQuery.username = "" Then
            QueryALL()
        Else
            Query()
        End If
    End Sub

    Protected Sub GV2_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles GV2.PageIndexChanging
        GV2.PageIndex = e.NewPageIndex
        If IPQQuery.username2 = "" Then
            QueryALL2()
        Else
            Query2()
        End If
    End Sub
End Class
