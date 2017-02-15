
Partial Class HealthUpdate
    Inherits System.Web.UI.Page

    Protected Sub btnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim ht As Hashtable = New Hashtable
        ht.Add("Week", SqlStringConstructor.GetQuottedString(Me.TextBox1.Text.Trim()))
        ht.Add("DormitoryType", SqlStringConstructor.GetQuottedString(Me.TextBox2.Text.Trim()))
        ht.Add("FloorId", SqlStringConstructor.GetQuottedString(Me.TextBox3.Text.Trim()))
        ht.Add("DormitoryId", SqlStringConstructor.GetQuottedString(Me.TextBox4.Text.Trim()))
        ht.Add("HealthScore", SqlStringConstructor.GetQuottedString(Me.TextBox5.Text.Trim()))
        ht.Add("HealthGrade", SqlStringConstructor.GetQuottedString(Me.TextBox6.Text.Trim()))
        Dim where As String = "Where HealthId=" + SqlStringConstructor.GetQuottedString(Request.QueryString("login_name").ToString())
        HealthLogic.Update(ht, where)
        Response.Redirect("HealthManager.aspx")
    End Sub

    Protected Sub btnReturn_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnReturn.Click
        Response.Redirect("HealthManager.aspx")
    End Sub

    Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
        InitData()
    End Sub
    Private Sub InitData()
        Dim loginName As String = Request.QueryString("login_name").ToString
        Dim user As HealthLogic = New HealthLogic
        user.LoadData(loginName)

        If user.Exist Then
            Me.TextBox1.Text = user.Week
            Me.TextBox2.Text = user.DormitoryType
            Me.TextBox3.Text = user.FloorId
            Me.TextBox4.Text = user.DormitoryId
            Me.TextBox5.Text = user.HealthScore
            Me.TextBox6.Text = user.HealthGrade
        End If

    End Sub

End Class
