
Partial Class AddIPQUpdate
    Inherits System.Web.UI.Page
    Protected Sub btnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim ht As Hashtable = New Hashtable
        ht.Add("StudentId", SqlStringConstructor.GetQuottedString(Me.TextBox1.Text.Trim()))
        ht.Add("AddReason", SqlStringConstructor.GetQuottedString(Me.TextBox2.Text.Trim()))
        ht.Add("AddScore", SqlStringConstructor.GetQuottedString(Me.TextBox3.Text.Trim()))
        Dim where As String = "Where AddId=" + SqlStringConstructor.GetQuottedString(Request.QueryString("login_name").ToString())
        AddIPQLogic.Update(ht, where)
        Response.Redirect("AddIPQManager.aspx")
    End Sub

    Protected Sub btnReturn_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnReturn.Click
        Response.Redirect("AddIPQManager.aspx")
    End Sub

    Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
        InitData()
    End Sub
    Private Sub InitData()
        Dim loginName As String = Request.QueryString("login_name").ToString
        Dim user As AddIPQLogic = New AddIPQLogic
        user.LoadData(loginName)

        If user.Exist Then
            Me.TextBox1.Text = user.StudentId
            Me.TextBox2.Text = user.AddReason
            Me.TextBox3.Text = user.AddScore
        End If

    End Sub
End Class
