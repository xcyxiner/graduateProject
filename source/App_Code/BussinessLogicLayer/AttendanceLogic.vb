Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Public Class AttendanceLogic
    Private _StudentId As String
    Public Property StudentId() As String
        Get
            Return _StudentId
        End Get
        Set(ByVal value As String)
            _StudentId = value
        End Set
    End Property
    Private _AttendanceId As String
    Public Property AttendanceId() As String
        Get
            Return _AttendanceId
        End Get
        Set(ByVal value As String)
            _AttendanceId = value
        End Set
    End Property
    Private _Week As String
    Public Property Week() As String
        Get
            Return _Week
        End Get
        Set(ByVal value As String)
            _Week = value
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
    Private _Semester As String
    Public Property Semester() As String
        Get
            Return _Semester
        End Get
        Set(ByVal value As String)
            _Semester = value
        End Set
    End Property
    Private _StayAway As String
    Public Property StayAway() As String
        Get
            Return _StayAway
        End Get
        Set(ByVal value As String)
            _StayAway = value
        End Set
    End Property
    Private _DesertExercises As String
    Public Property DesertExercises() As String
        Get
            Return _DesertExercises
        End Get
        Set(ByVal value As String)
            _DesertExercises = value
        End Set
    End Property
    Public Sub LoadData(ByVal AttendanceId As String)
        Dim db As SQLDatabase = New SQLDatabase
        Dim SQLString As String = "select * from [AttendanceList] where AttendanceId=" + SqlStringConstructor.GetQuottedString(AttendanceId)
        Dim dr As DataRow = db.GetDataRow(SQLString)

        If dr Is Nothing = False Then
            Me._StudentId = GetSafeData.ValidateDataRow_S(dr, "StudentId")
            Me._AttendanceId = GetSafeData.ValidateDataRow_S(dr, "AttendanceId")
            Me._Week = GetSafeData.ValidateDataRow_S(dr, "Week")
            Me._Semester = GetSafeData.ValidateDataRow_S(dr, "Semester")
            Me._StayAway = GetSafeData.ValidateDataRow_S(dr, "StayAway")
            Me._DesertExercises = GetSafeData.ValidateDataRow_S(dr, "DesertExercises")
            Me._exist = True
        Else
            Me._exist = False
        End If
    End Sub
    Public Shared Sub Add(ByVal userInfo As Hashtable)
        Dim db As SQLDatabase = New SQLDatabase
        db.Insert("[AttendanceList]", userInfo)
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
        db.Update("[AttendanceList]", newUserInfo, strCond)
    End Sub
    Public Shared Sub Delete(ByVal AttendanceId As String)
        Dim sqls As ArrayList = New ArrayList
        Dim SQLString As String
        SQLString = "Delete from [AttendanceList] where AttendanceId=" + SqlStringConstructor.GetQuottedString(AttendanceId)
        sqls.Add(SQLString)
        Dim db As SQLDatabase = New SQLDatabase
        db.ExecuteSQL(sqls)
    End Sub

    Public Shared Function Query() As DataTable
        Dim SQL As String = "select * from [AttendanceList]"
        Dim db As SQLDatabase = New SQLDatabase
        Return db.GetDataTable(SQL)
    End Function
    Public Shared Function QueryUsers(ByVal queryItems As Hashtable) As DataTable
        Dim where As String = SqlStringConstructor.GetConditionClause(queryItems)
        Dim sql As String = "Select * from [AttendanceList] " + where
        Dim db As SQLDatabase = New SQLDatabase
        Return db.GetDataTable(sql)
    End Function
End Class
