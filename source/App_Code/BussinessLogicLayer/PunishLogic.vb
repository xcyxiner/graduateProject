Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Public Class PunishLogic
    Private _PunishId As String
    Public Property PunishId() As Integer
        Get
            Return _PunishId
        End Get
        Set(ByVal value As Integer)
            _PunishId = value
        End Set
    End Property
    Private _StudentId As String
    Public Property StudentId() As String
        Get
            Return _StudentId
        End Get
        Set(ByVal value As String)
            _StudentId = value
        End Set
    End Property
    Private _PunishName As String
    Public Property PunishName() As String
        Get
            Return _PunishName
        End Get
        Set(ByVal value As String)
            _PunishName = value
        End Set
    End Property
    Private _PunishReason As String
    Public Property PunishReason() As String
        Get
            Return _PunishReason
        End Get
        Set(ByVal value As String)
            _PunishReason = value
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
    Private _PunishDateTime As Date
    Public Property PunishDateTime() As Date
        Get
            Return _PunishDateTime
        End Get
        Set(ByVal value As Date)
            _PunishDateTime = value
        End Set
    End Property

    Public Sub LoadData(ByVal PunishId As String)
        Dim db As SQLDatabase = New SQLDatabase
        Dim SQLString As String = "select * from [PunishList] where PunishId=" + SqlStringConstructor.GetQuottedString(PunishId)
        Dim dr As DataRow = db.GetDataRow(SQLString)

        If dr Is Nothing = False Then
            Me._PunishId = GetSafeData.ValidateDataRow_N(dr, "PunishId")
            Me._StudentId = GetSafeData.ValidateDataRow_S(dr, "StudentId")
            Me._PunishName = GetSafeData.ValidateDataRow_S(dr, "PunishName")
            Me._PunishReason = GetSafeData.ValidateDataRow_S(dr, "PunishReason")
            Me._PunishDateTime = GetSafeData.ValidateDataRow_T(dr, "PunishDateTime")
            Me._exist = True
        Else
            Me._exist = False
        End If
    End Sub
    Public Shared Sub Add(ByVal userInfo As Hashtable)
        Dim db As SQLDatabase = New SQLDatabase
        db.Insert("[PunishList]", userInfo)
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
        db.Update("[PunishList]", newUserInfo, strCond)
    End Sub

    Public Shared Sub Delete(ByVal PunishId As String)
        Dim sqls As ArrayList = New ArrayList
        Dim SQLString As String
        SQLString = "Delete from [PunishList] where PunishId=" + SqlStringConstructor.GetQuottedString(PunishId)
        sqls.Add(SQLString)
        Dim db As SQLDatabase = New SQLDatabase
        db.ExecuteSQL(sqls)
    End Sub
    Public Shared Function Query() As DataTable
        Dim SQL As String = "select * from [PunishList]"
        Dim db As SQLDatabase = New SQLDatabase
        Return db.GetDataTable(SQL)
    End Function
    Public Shared Function QueryUsers(ByVal queryItems As Hashtable) As DataTable
        Dim where As String = SqlStringConstructor.GetConditionClause(queryItems)
        Dim sql As String = "Select * from [PunishList] " + where
        Dim db As SQLDatabase = New SQLDatabase
        Return db.GetDataTable(sql)
    End Function
End Class
