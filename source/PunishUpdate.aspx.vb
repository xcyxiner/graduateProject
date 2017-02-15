
Partial Class PunishUpdate
    Inherits System.Web.UI.Page

    Protected Sub btnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim ht As Hashtable = New Hashtable
        ht.Add("StudentId", SqlStringConstructor.GetQuottedString(Me.TextBox1.Text.Trim()))
        ht.Add("PunishName", SqlStringConstructor.GetQuottedString(Me.TextBox2.Text.Trim()))
        ht.Add("PunishReason", SqlStringConstructor.GetQuottedString(Me.TextBox3.Text.Trim()))
        ht.Add("PunishDateTime", SqlStringConstructor.GetQuottedString(Me.TextBox4.Text.Trim()))
        Dim where As String = "Where PunishId=" + SqlStringConstructor.GetQuottedString(Request.QueryString("login_name").ToString())
        PunishLogic.Update(ht, where)
        Response.Redirect("PunishManager.aspx")
    End Sub

    Protected Sub btnReturn_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnReturn.Click
        Response.Redirect("PunishManager.aspx")
    End Sub

    Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
        InitData()
    End Sub
    Private Sub InitData()
        Dim loginName As String = Request.QueryString("login_name").ToString
        Dim user As PunishLogic = New PunishLogic
        user.LoadData(loginName)

        If user.Exist Then
            Me.TextBox1.Text = user.StudentId
            Me.TextBox2.Text = user.PunishName
            Me.TextBox3.Text = user.PunishReason
            Me.TextBox4.Text = user.PunishDateTime
        End If

    End Sub
End Class
