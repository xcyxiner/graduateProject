Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub btnLogin_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        Dim userName As String = Me.txtUserName.Text.ToString().Trim()
        Dim userPwd As String = Me.txtPwd.Text.ToString().Trim()
        Dim userRole As String = Me.rblClass.SelectedValue.Trim()
        Dim selectStr As String = ""

        Select Case userRole
            Case "1"
                Dim user As StudentLogic = New StudentLogic
                user.LoadData(userName)
                Session.Add("student", userName)

                If user.Exist Then
                    If user.StudentPassword.Equals(userPwd) Then
                        Response.Redirect("Main.aspx")
                    Else
                        Session.Clear()
                        Response.Write("<script language=javascript>alert('" + "验证失败，请重新登录!" + "')</script>")
                    End If
                Else
                    Session.Clear()
                    Response.Write("<script language=javascript>alert('" + "对不起，用户不存在!" + "')</script>")

                End If


                Exit Select
            Case "2"
                Dim user As UserLogic = New UserLogic
                user.LoadData(userName)

                If user.Exist Then
                    If user.Password.Equals(userPwd) Then
                        If user.Role.Equals("admin") Then
                            Session.Add("admin", userName)
                            Response.Redirect("Main.aspx")
                        Else
                            Session.Add("manager", userName)
                            Response.Redirect("Main.aspx")
                        End If
                    Else
                        Session.Clear()
                        Response.Write("<script language=javascript>alert('" + "验证失败，请重新登录!" + "')</script>")
                    End If
                Else
                    Session.Clear()
                    Response.Write("<script language=javascript>alert('" + "对不起，用户不存在!" + "')</script>")
                End If
            Case "3"
                Dim user As UserLogic = New UserLogic
                user.LoadData(userName)

                If user.Exist Then
                    If user.Password.Equals(userPwd) Then
                        If user.Role.Equals("admin") Then
                            Session.Add("admin", userName)
                            Response.Redirect("Main.aspx")
                        Else
                            Session.Add("manager", userName)
                            Response.Redirect("Main.aspx")
                        End If
                    Else
                        Session.Clear()
                        Response.Write("<script language=javascript>alert('" + "验证失败，请重新登录!" + "')</script>")
                    End If
                Else
                    Session.Clear()
                    Response.Write("<script language=javascript>alert('" + "对不起，用户不存在!" + "')</script>")
                End If
                Exit Select
        End Select
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Session.Clear()
    End Sub

    Protected Sub btnClose_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.txtUserName.Text = ""
        Me.txtPwd.Text = ""
    End Sub
End Class
