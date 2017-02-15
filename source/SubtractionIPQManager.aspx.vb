Imports System.Data
Imports System.Data.SqlClient
Partial Class SubtractionIPQManager
    Inherits System.Web.UI.Page
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not Page.IsPostBack Then
            QueryALL()
        End If
        Me.btnDelete.Attributes.Add("onclick", "javascript:return confirm('确定删除?');")
    End Sub
    Private Sub QueryALL()
        Me.TextBox1.Text = ""
        SubtractionIPQManager.username = ""
        Dim dt As DataTable = SubtractionIPQLogic.Query
        GV.DataSource = dt
        GV.DataBind()
    End Sub

    Protected Sub btnUpdate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Dim selectedUsers As ArrayList = GetSelected()

        If selectedUsers.Count <> 1 Then
            Response.Write("<script language=javascript>alert('请选择一个用户!');</script>")
            Exit Sub
        End If
        Dim loginName As String = selectedUsers(0).ToString
        Response.Redirect("SubtractionIPQUpdate.aspx?login_name=" + loginName)
    End Sub
    Private Function GetSelected() As ArrayList
        Dim selectedItems As ArrayList = New ArrayList
        For Each row As GridViewRow In GV.Rows

            If CType(row.FindControl("chkSelected"), CheckBox).Checked = True Then
                selectedItems.Add(Convert.ToString(row.Cells.Item(1).Text))
            End If
        Next
        Return selectedItems
    End Function

    Protected Sub btnDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim selectedUsers As ArrayList = GetSelected()
        For Each loginName As String In selectedUsers
            SubtractionIPQLogic.Delete(loginName)
        Next
        QueryALL()
    End Sub
    Private Sub Query()
        Dim queryItems As Hashtable = New Hashtable
        queryItems.Add("StudentId", SubtractionIPQManager.username)
        Dim dt As DataTable = SubtractionIPQLogic.QueryUsers(queryItems)
        GV.DataSource = dt
        GV.DataBind()
    End Sub
    Shared username As String
    Protected Sub btnQuery_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnQuery.Click
        SubtractionIPQManager.username = Me.TextBox1.Text.Trim
        Query()
        Me.TextBox1.Text = ""
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click

        QueryALL()
    End Sub

    Protected Sub GV_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles GV.PageIndexChanging
        GV.PageIndex = e.NewPageIndex
        If SubtractionIPQManager.username = "" Then
            QueryALL()
        Else
            Query()
        End If
    End Sub
End Class
