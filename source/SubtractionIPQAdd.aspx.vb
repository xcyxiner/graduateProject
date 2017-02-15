
Partial Class SubtractionIPQAdd
    Inherits System.Web.UI.Page
    Protected Sub btnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave.Click

        If StudentLogic.HasUser(Me.TextBox1.Text.Trim()) Then
            Me.LabelWarningMessage.Text = ""
            Dim ht As Hashtable = New Hashtable
            ht.Add("StudentId", SqlStringConstructor.GetQuottedString(Me.TextBox1.Text.Trim()))
            ht.Add("SubtractionReason", SqlStringConstructor.GetQuottedString(Me.TextBox2.Text.Trim()))
            ht.Add("SubtractionScore", SqlStringConstructor.GetQuottedString(Me.TextBox3.Text.Trim()))
            SubtractionIPQLogic.Add(ht)
            Response.Redirect("SubtractionIPQManager.aspx")
        Else
            Me.LabelWarningMessage.Text = "<font color=red>警告:学号[" + Me.TextBox1.Text.Trim + "]不存在!</font>"
            Me.TextBox1.Text = ""
        End If
    End Sub

    Protected Sub btnReturn_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnReturn.Click
        Response.Redirect("SubtractionIPQManager.aspx")
    End Sub
End Class
