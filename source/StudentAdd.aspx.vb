
Partial Class StudentAdd
    Inherits System.Web.UI.Page

    Protected Sub btnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave.Click

        If StudentLogic.HasUser(Me.TextBox1.Text.Trim()) Then
            Me.LabelWarningMessage.Text = "<font color=red>警告:登录名[" + Me.TextBox1.Text.Trim + "]已存在!</font>"
            Me.TextBox1.Text = ""
        Else
            Me.LabelWarningMessage.Text = ""
            Dim ht As Hashtable = New Hashtable
            ht.Add("StudentId", SqlStringConstructor.GetQuottedString(Me.TextBox1.Text.Trim()))
            ht.Add("StudentName", SqlStringConstructor.GetQuottedString(Me.TextBox2.Text.Trim()))
            ht.Add("StudentPassword", SqlStringConstructor.GetQuottedString(Me.TextBox3.Text.Trim()))
            ht.Add("StudentSex", SqlStringConstructor.GetQuottedString(Me.TextBox4.Text.Trim()))
            ht.Add("DormitoryType", SqlStringConstructor.GetQuottedString(Me.TextBox5.Text.Trim()))
            ht.Add("FloorId", SqlStringConstructor.GetQuottedString(Me.TextBox6.Text.Trim()))
            ht.Add("DormitoryId", SqlStringConstructor.GetQuottedString(Me.TextBox7.Text.Trim()))
            StudentLogic.Add(ht)
            Response.Redirect("StudentManager.aspx")
        End If
    End Sub

    Protected Sub btnReturn_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnReturn.Click
        Response.Redirect("StudentManager.aspx")
    End Sub
End Class
