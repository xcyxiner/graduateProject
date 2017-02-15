
Partial Class AttendanceUpdate
    Inherits System.Web.UI.Page

    Protected Sub btnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim ht As Hashtable = New Hashtable
        ht.Add("StudentId", SqlStringConstructor.GetQuottedString(Me.TextBox1.Text.Trim()))
        ht.Add("Week", SqlStringConstructor.GetQuottedString(Me.TextBox2.Text.Trim()))
        ht.Add("Semester", SqlStringConstructor.GetQuottedString(Me.TextBox3.Text.Trim()))
        ht.Add("StayAway", SqlStringConstructor.GetQuottedString(Me.TextBox4.Text.Trim()))
        ht.Add("DesertExercises", SqlStringConstructor.GetQuottedString(Me.TextBox5.Text.Trim()))
        Dim where As String = "Where AttendanceId=" + SqlStringConstructor.GetQuottedString(Request.QueryString("login_name").ToString())
        AttendanceLogic.Update(ht, where)
        Response.Redirect("AttendanceManager.aspx")
    End Sub

    Protected Sub btnReturn_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnReturn.Click
        Response.Redirect("AttendanceManager.aspx")
    End Sub

    Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
        InitData()
    End Sub
    Private Sub InitData()
        Dim loginName As String = Request.QueryString("login_name").ToString
        Dim user As AttendanceLogic = New AttendanceLogic
        user.LoadData(loginName)

        If user.Exist Then
            Me.TextBox1.Text = user.StudentId
            Me.TextBox2.Text = user.Week
            Me.TextBox3.Text = user.Semester
            Me.TextBox4.Text = user.StayAway
            Me.TextBox5.Text = user.DesertExercises
        End If

    End Sub
End Class
