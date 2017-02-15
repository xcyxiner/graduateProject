Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Public Class StudentLogic
    Private _StudentId As String
    Public Property StudentId() As String
        Get
            Return _StudentId
        End Get
        Set(ByVal value As String)
            _StudentId = value
        End Set
    End Property
    Private _StudentPassword As String
    Public Property StudentPassword() As String
        Get
            Return _StudentPassword
        End Get
        Set(ByVal value As String)
            _StudentPassword = value
        End Set
    End Property
    Private _StudentName As String
    Public Property StudentName() As String
        Get
            Return _StudentName
        End Get
        Set(ByVal value As String)
            _StudentName = value
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
    Private _StudentSex As String
    Public Property StudentSex() As String
        Get
            Return _StudentSex
        End Get
        Set(ByVal value As String)
            _StudentSex = value
        End Set
    End Property
    Private _DormitoryType As String
    Public Property DormitoryType() As String
        Get
            Return _DormitoryType
        End Get
        Set(ByVal value As String)
            _DormitoryType = value
        End Set
    End Property
    Private _FloorId As Integer
    Public Property FloorId() As Integer
        Get
            Return _FloorId
        End Get
        Set(ByVal value As Integer)
            _FloorId = value
        End Set
    End Property
    Private _DormitoryId As String
    Public Property DormitoryId() As String
        Get
            Return _DormitoryId
        End Get
        Set(ByVal value As String)
            _DormitoryId = value
        End Set
    End Property

    Public Sub LoadData(ByVal StudentId As String)
        Dim db As SQLDatabase = New SQLDatabase
        Dim SQLString As String = "select * from [StudentList] where StudentId=" + SqlStringConstructor.GetQuottedString(StudentId)
        Dim dr As DataRow = db.GetDataRow(SQLString)

        If dr Is Nothing = False Then
            Me._StudentId = GetSafeData.ValidateDataRow_S(dr, "StudentId")
            Me._StudentName = GetSafeData.ValidateDataRow_S(dr, "StudentName")
            Me._StudentPassword = GetSafeData.ValidateDataRow_S(dr, "StudentPassword")
            Me._StudentSex = GetSafeData.ValidateDataRow_S(dr, "StudentSex")
            Me._DormitoryType = GetSafeData.ValidateDataRow_S(dr, "DormitoryType")
            Me._FloorId = GetSafeData.ValidateDataRow_N(dr, "FloorId")
            Me._DormitoryId = GetSafeData.ValidateDataRow_S(dr, "DormitoryId")
            Me._exist = True
        Else
            Me._exist = False
        End If
    End Sub
    Public Shared Sub Add(ByVal userInfo As Hashtable)
        Dim db As SQLDatabase = New SQLDatabase
        db.Insert("[StudentList]", userInfo)
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
        db.Update("[StudentList]", newUserInfo, strCond)
    End Sub
    Public Shared Sub Delete(ByVal StudentId As String)
        Dim sqls As ArrayList = New ArrayList
        Dim SQLString As String
        SQLString = "Delete from [SubtractionIPQList] where StudentId=" + SqlStringConstructor.GetQuottedString(StudentId)
        sqls.Add(SQLString)
        SQLString = "Delete from [AddIPQList] where StudentId=" + SqlStringConstructor.GetQuottedString(StudentId)
        sqls.Add(SQLString)
        SQLString = "Delete from [AttendanceList] where StudentId=" + SqlStringConstructor.GetQuottedString(StudentId)
        sqls.Add(SQLString)
        SQLString = "Delete from [PunishList] where StudentId=" + SqlStringConstructor.GetQuottedString(StudentId)
        sqls.Add(SQLString)
        SQLString = "Delete from [StudentList] where StudentId=" + SqlStringConstructor.GetQuottedString(StudentId)
        sqls.Add(SQLString)
        Dim db As SQLDatabase = New SQLDatabase
        db.ExecuteSQL(sqls)
    End Sub

    Public Shared Function Query() As DataTable
        Dim SQL As String = "select * from [StudentList]"
        Dim db As SQLDatabase = New SQLDatabase
        Return db.GetDataTable(SQL)
    End Function
    Public Shared Function QueryUsers(ByVal queryItems As Hashtable) As DataTable
        Dim where As String = SqlStringConstructor.GetConditionClause(queryItems)
        Dim sql As String = "Select * from [StudentList] " + where
        Dim db As SQLDatabase = New SQLDatabase
        Return db.GetDataTable(sql)
    End Function
End Class
