Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Public Class SubtractionIPQLogic
    Private _StudentId As String
    Public Property StudentId() As String
        Get
            Return _StudentId
        End Get
        Set(ByVal value As String)
            _StudentId = value
        End Set
    End Property
    Private _SubtractionId As String
    Public Property SubtractionId() As String
        Get
            Return _SubtractionId
        End Get
        Set(ByVal value As String)
            _SubtractionId = value
        End Set
    End Property
    Private _SubtractionReason As String
    Public Property SubtractionReason() As String
        Get
            Return _SubtractionReason
        End Get
        Set(ByVal value As String)
            _SubtractionReason = value
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
    Private _SubtractionScore As String
    Public Property SubtractionScore() As String
        Get
            Return _SubtractionScore
        End Get
        Set(ByVal value As String)
            _SubtractionScore = value
        End Set
    End Property

    Public Sub LoadData(ByVal SubtractionId As String)
        Dim db As SQLDatabase = New SQLDatabase
        Dim SQLString As String = "select * from [SubtractionIPQList] where  SubtractionId=" + SqlStringConstructor.GetQuottedString(SubtractionId)
        Dim dr As DataRow = db.GetDataRow(SQLString)

        If dr Is Nothing = False Then
            Me._StudentId = GetSafeData.ValidateDataRow_S(dr, "StudentId")
            Me._SubtractionId = GetSafeData.ValidateDataRow_S(dr, "SubtractionId")
            Me._SubtractionReason = GetSafeData.ValidateDataRow_S(dr, "SubtractionReason")
            Me._SubtractionScore = GetSafeData.ValidateDataRow_S(dr, "SubtractionScore")
            Me._exist = True
        Else
            Me._exist = False
        End If
    End Sub
    Public Shared Sub Add(ByVal userInfo As Hashtable)
        Dim db As SQLDatabase = New SQLDatabase
        db.Insert("[SubtractionIPQList]", userInfo)
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
        db.Update("[SubtractionIPQList]", newUserInfo, strCond)
    End Sub
    Public Shared Sub Delete(ByVal SubtractionId As String)
        Dim sqls As ArrayList = New ArrayList
        Dim SQLString As String
        SQLString = "Delete from [SubtractionIPQList] where SubtractionId=" + SqlStringConstructor.GetQuottedString(SubtractionId)
        sqls.Add(SQLString)
        Dim db As SQLDatabase = New SQLDatabase
        db.ExecuteSQL(sqls)
    End Sub

    Public Shared Function Query() As DataTable
        Dim SQL As String = "select * from [SubtractionIPQList]"
        Dim db As SQLDatabase = New SQLDatabase
        Return db.GetDataTable(SQL)
    End Function
    Public Shared Function QueryUsers(ByVal queryItems As Hashtable) As DataTable
        Dim where As String = SqlStringConstructor.GetConditionClause(queryItems)
        Dim sql As String = "Select * from [SubtractionIPQList] " + where
        Dim db As SQLDatabase = New SQLDatabase
        Return db.GetDataTable(sql)
    End Function
End Class
