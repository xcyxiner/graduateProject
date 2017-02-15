
Partial Class Left
    Inherits System.Web.UI.UserControl

    Protected Sub Tree_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Tree.Init
        InitData()
    End Sub
    Private Sub InitData()
        Dim privilegeFile As String = ""


        If Session("student") Is Nothing = False Then
            privilegeFile = "Student.xml"
        Else
            If Session("manager") Is Nothing = False Then
                privilegeFile = "Manager.xml"
            Else
                If Session("admin") Is Nothing = False Then
                    privilegeFile = "Admin.xml"
                End If
            End If
        End If

        Dim xmlSrc As XmlDataSource = New XmlDataSource
        xmlSrc.DataFile = privilegeFile
        xmlSrc.DataBind()
        Me.Tree.DataSource = xmlSrc
        Tree.DataBind()
    End Sub
End Class
