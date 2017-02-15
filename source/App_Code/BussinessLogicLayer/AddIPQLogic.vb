Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Public Class AddIPQLogic
    Private _StudentId As String
    Public Property StudentId() As String
        Get
            Return _StudentId
        End Get
        Set(ByVal value As String)
            _StudentId = value
        End Set
    End Property
    Private _AddId As String
    Public Property AddId() As String
        Get
            Return _AddId
        End Get
        Set(ByVal value As String)
            _AddId = value
        End Set
    End Property
    Private _AddReason As String
    Public Property AddReason() As String
        Get
            Return _AddReason
        End Get
        Set(ByVal value As String)
            _AddReason = value
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
    Private _AddScore As String
    Public Property AddScore() As String
        Get
            Return _AddScore
        End Get
        Set(ByVal value As String)
            _AddScore = value
        End Set
    End Property

    Public Sub LoadData(ByVal AddId As String)
        Dim db As SQLDatabase = New SQLDatabase
        Dim SQLString As String = "select * from [AddIPQList] where AddId=" + SqlStringConstructor.GetQuottedString(AddId)
        Dim dr As DataRow = db.GetDataRow(SQLString)

        If dr Is Nothing = False Then
            Me._StudentId = GetSafeData.ValidateDataRow_S(dr, "StudentId")
            Me._AddId = GetSafeData.ValidateDataRow_S(dr, "AddId")
            Me._AddReason = GetSafeData.ValidateDataRow_S(dr, "AddReason")
            Me._AddScore = GetSafeData.ValidateDataRow_S(dr, "AddScore")
            Me._exist = True
        Else
            Me._exist = False
        End If
    End Sub
    Public Shared Sub Add(ByVal userInfo As Hashtable)
        Dim db As SQLDatabase = New SQLDatabase
        db.Insert("[AddIPQList]", userInfo)
    End Sub
    Public Shared Function HasUser(ByVal StudentId As String) As Boolean
        Dim db As SQLDatabase = New SQLDatabase
        Dim SQLString As String = "select * from [StudentList] where StudentId=" + SqlStringConstructor.GetQuottedString(StudentId)
        Dim dr As DataRow = db.GetDataRow(SQLString)

        If dr Is Nothing = False Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Shared Sub Update(ByVal newUserInfo As Hashtable, ByVal strCond As String)
        Dim db As SQLDatabase = New SQLDatabase
        'strCond = "Where UserName=" + SqlStringConstructor.GetQuottedString(Me._StudentId)
        db.Update("[AddIPQList]", newUserInfo, strCond)
    End Sub
    Public Shared Sub Delete(ByVal AddId As String)
        Dim sqls As ArrayList = New ArrayList
        Dim SQLString As String
        SQLString = "Delete from [AddIPQList] where AddId=" + SqlStringConstructor.GetQuottedString(AddId)
        sqls.Add(SQLString)
        Dim db As SQLDatabase = New SQLDatabase
        db.ExecuteSQL(sqls)
    End Sub

    Public Shared Function Query() As DataTable
        Dim SQL As String = "select * from [AddIPQList]"
        Dim db As SQLDatabase = New SQLDatabase
        Return db.GetDataTable(SQL)
    End Function
    Public Shared Function QueryUsers(ByVal queryItems As Hashtable) As DataTable
        Dim where As String = SqlStringConstructor.GetConditionClause(queryItems)
        Dim sql As String = "Select * from [AddIPQList] " + where
        Dim db As SQLDatabase = New SQLDatabase
        Return db.GetDataTable(sql)
    End Function
End Class
