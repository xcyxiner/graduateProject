
Partial Class AdminAdd
    Inherits System.Web.UI.Page

    Protected Sub btnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave.Click

        If UserLogic.HasUser(Me.TextBox1.Text.Trim()) Then
            Me.LabelWarningMessage.Text = "<font color=red>警告:用户名[" + Me.TextBox1.Text.Trim + "]已存在!</font>"
            Me.TextBox1.Text = ""
        Else
            Me.LabelWarningMessage.Text = ""
            Dim ht As Hashtable = New Hashtable
            ht.Add("UserName", SqlStringConstructor.GetQuottedString(Me.TextBox1.Text.Trim()))
            ht.Add("Password", SqlStringConstructor.GetQuottedString(Me.TextBox2.Text.Trim()))
            ht.Add("Role", SqlStringConstructor.GetQuottedString(Me.TextBox3.Text.Trim()))
            UserLogic.Add(ht)
            Response.Redirect("AdminManger.aspx")
        End If
    End Sub

    Protected Sub btnReturn_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnReturn.Click
        Response.Redirect("AdminManger.aspx")
    End Sub
End Class
