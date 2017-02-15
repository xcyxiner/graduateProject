
Partial Class StudentUpdate
    Inherits System.Web.UI.Page

    Protected Sub btnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim ht As Hashtable = New Hashtable
        ht.Add("StudentName", SqlStringConstructor.GetQuottedString(Me.TextBox2.Text.Trim()))
        ht.Add("StudentPassword", SqlStringConstructor.GetQuottedString(Me.TextBox3.Text.Trim()))
        ht.Add("StudentSex", SqlStringConstructor.GetQuottedString(Me.TextBox4.Text.Trim()))
        ht.Add("DormitoryType", SqlStringConstructor.GetQuottedString(Me.TextBox5.Text.Trim()))
        ht.Add("FloorId", SqlStringConstructor.GetQuottedString(Me.TextBox6.Text.Trim()))
        ht.Add("DormitoryId", SqlStringConstructor.GetQuottedString(Me.TextBox7.Text.Trim()))
        Dim where As String = "Where StudentId=" + SqlStringConstructor.GetQuottedString(Request.QueryString("login_name").ToString())
        StudentLogic.Update(ht, where)
        Response.Redirect("StudentManager.aspx")
    End Sub

    Protected Sub btnReturn_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnReturn.Click
        Response.Redirect("StudentManager.aspx")
    End Sub

    Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
        InitData()
    End Sub
    Private Sub InitData()
        Dim loginName As String = Request.QueryString("login_name").ToString
        Dim user As StudentLogic = New StudentLogic
        user.LoadData(loginName)

        If user.Exist Then
            Me.TextBox1.Text = user.StudentId
            Me.TextBox2.Text = user.StudentName
            Me.TextBox3.Text = user.StudentPassword
            Me.TextBox4.Text = user.StudentSex
            Me.TextBox5.Text = user.DormitoryType
            Me.TextBox6.Text = user.FloorId
            Me.TextBox7.Text = user.DormitoryId
        End If

    End Sub
End Class
