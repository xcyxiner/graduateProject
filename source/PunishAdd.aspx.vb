
Partial Class PunishAdd
    Inherits System.Web.UI.Page

    Protected Sub btnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave.Click

        If StudentLogic.HasUser(Me.TextBox1.Text.Trim()) Then
            Me.LabelWarningMessage.Text = ""
            Dim ht As Hashtable = New Hashtable
            ht.Add("StudentId", SqlStringConstructor.GetQuottedString(Me.TextBox1.Text.Trim()))
            ht.Add("PunishName", SqlStringConstructor.GetQuottedString(Me.TextBox2.Text.Trim()))
            ht.Add("PunishReason", SqlStringConstructor.GetQuottedString(Me.TextBox3.Text.Trim()))
            ht.Add("PunishDateTime", SqlStringConstructor.GetQuottedString(Me.TextBox4.Text.Trim()))
            PunishLogic.Add(ht)
            Response.Redirect("PunishManager.aspx")
        Else
            Me.LabelWarningMessage.Text = "<font color=red>警告:学号[" + Me.TextBox1.Text.Trim + "]不存在!</font>"
            Me.TextBox1.Text = ""
        End If
    End Sub

    Protected Sub btnReturn_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnReturn.Click
        Response.Redirect("PunishManager.aspx")
    End Sub
End Class
