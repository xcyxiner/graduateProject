Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient

Public Class UserLogic

    Private _Password As String
    Public Property Password() As String
        Get
            Return _Password
        End Get
        Set(ByVal value As String)
            _Password = value
        End Set
    End Property
    Private _UserName As String
    Public Property UserName() As String
        Get
            Return _UserName
        End Get
        Set(ByVal value As String)
            _UserName = value
        End Set
    End Property
    Private _Role As String
    Public Property Role() As String
        Get
            Return _Role
        End Get
        Set(ByVal value As String)
            _Role = value
        End Set
    End Property
    Private _exist As Boolean
    Public Property Exist() As Boolean
        Get
            Return _exist
        End Get
        Set(ByVal value As Boolean)
            _exist = value
        End Set
    End Property

    Public Sub LoadData(ByVal UserName As String)
        Dim db As SQLDatabase = New SQLDatabase
        Dim SQLString As String = "select * from [UserList] where UserName=" + SqlStringConstructor.GetQuottedString(UserName)
        Dim dr As DataRow = db.GetDataRow(SQLString)

        If dr Is Nothing = False Then
            Me._UserName = GetSafeData.ValidateDataRow_S(dr, "UserName")
            Me._Password = GetSafeData.ValidateDataRow_S(dr, "Password")
            Me._Role = GetSafeData.ValidateDataRow_S(dr, "Role")
            Me._exist = True
        Else
            Me._exist = False
        End If
    End Sub
    Public Shared Sub Add(ByVal userInfo As Hashtable)
        Dim db As SQLDatabase = New SQLDatabase
        db.Insert("[UserList]", userInfo)
    End Sub
    Public Shared Function HasUser(ByVal loginName As String) As Boolean
        Dim db As SQLDatabase = New SQLDatabase
        Dim SQLString As String = "select * from [UserList] where [UserName]=" + SqlStringConstructor.GetQuottedString(loginName)
        Dim dr As DataRow = db.GetDataRow(SQLString)

        If dr Is Nothing = False Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Shared Sub Update(ByVal newUserInfo As Hashtable, ByVal strCond As String)
        Dim db As SQLDatabase = New SQLDatabase
        'strCond = "Where UserName=" + SqlStringConstructor.GetQuottedString(Me._UserName)
        db.Update("[UserList]", newUserInfo, strCond)
    End Sub
    Public Shared Sub Delete(ByVal UserName As String)
        Dim db As SQLDatabase = New SQLDatabase
        Dim SQLString As String = "Delete from [UserList] where UserName=" + UserName
        db.ExecuteSQL(SQLString)
    End Sub
    Public Shared Function Query() As DataTable
        Dim SQL As String = "select * from [UserList]"
        Dim db As SQLDatabase = New SQLDatabase
        Return db.GetDataTable(SQL)
    End Function
    Public Shared Function QueryUsers(ByVal queryItems As Hashtable) As DataTable
        Dim where As String = SqlStringConstructor.GetConditionClause(queryItems)
        Dim sql As String = "Select * from [UserList] " + where
        Dim db As SQLDatabase = New SQLDatabase
        Return db.GetDataTable(sql)
    End Function
End Class
