
Partial Class HealthAdd
    Inherits System.Web.UI.Page
    Protected Sub btnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave.Click

            Me.LabelWarningMessage.Text = ""
            Dim ht As Hashtable = New Hashtable
        ht.Add("Week", SqlStringConstructor.GetQuottedString(Me.TextBox1.Text.Trim()))
        ht.Add("DormitoryType", SqlStringConstructor.GetQuottedString(Me.TextBox2.Text.Trim()))
        ht.Add("FloorId", SqlStringConstructor.GetQuottedString(Me.TextBox3.Text.Trim()))
        ht.Add("DormitoryId", SqlStringConstructor.GetQuottedString(Me.TextBox4.Text.Trim()))
        ht.Add("HealthScore", SqlStringConstructor.GetQuottedString(Me.TextBox5.Text.Trim()))
        ht.Add("HealthGrade", SqlStringConstructor.GetQuottedString(Me.TextBox6.Text.Trim()))
        HealthLogic.Add(ht)
        Response.Redirect("HealthManager.aspx")
    End Sub

    Protected Sub btnReturn_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnReturn.Click
        Response.Redirect("HealthManager.aspx")
    End Sub
End Class
