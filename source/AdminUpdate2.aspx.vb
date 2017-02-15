
Partial Class AdminUpdate2
    Inherits System.Web.UI.Page
    Protected Sub btnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim ht As Hashtable = New Hashtable
        ht.Add("Password", SqlStringConstructor.GetQuottedString(Me.TextBox2.Text.Trim()))
        Dim where As String = "Where UserName=" + SqlStringConstructor.GetQuottedString(Me.TextBox1.Text.Trim)
        UserLogic.Update(ht, where)
    End Sub

    Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
        InitData()
    End Sub
    Private Sub InitData()
        Dim loginName As String
            loginName = Session("manager").ToString
            Dim user As UserLogic = New UserLogic
            user.LoadData(loginName)

            If user.Exist Then
                Me.TextBox1.Text = user.UserName
                Me.TextBox2.Text = user.Password
                Me.TextBox3.Text = user.Role
            End If

    End Sub
End Class
