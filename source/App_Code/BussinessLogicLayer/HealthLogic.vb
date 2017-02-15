Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Public Class HealthLogic
    Private _HealthId As String
    Public Property HealthId() As String
        Get
            Return _HealthId
        End Get
        Set(ByVal value As String)
            _HealthId = value
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
    Private _FloorId As String
    Public Property FloorId() As String
        Get
            Return _FloorId
        End Get
        Set(ByVal value As String)
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
    Private _HealthScore As String
    Public Property HealthScore() As String
        Get
            Return _HealthScore
        End Get
        Set(ByVal value As String)
            _HealthScore = value
        End Set
    End Property
    Private _HealthGrade As String
    Public Property HealthGrade() As String
        Get
            Return _HealthGrade
        End Get
        Set(ByVal value As String)
            _HealthGrade = value
        End Set
    End Property
    Public Sub LoadData(ByVal HealthId As String)
        Dim db As SQLDatabase = New SQLDatabase
        Dim SQLString As String = "select * from [HealthList] where HealthId=" + SqlStringConstructor.GetQuottedString(HealthId)
        Dim dr As DataRow = db.GetDataRow(SQLString)

        If dr Is Nothing = False Then
            Me._HealthId = GetSafeData.ValidateDataRow_S(dr, "HealthId")
            Me._Week = GetSafeData.ValidateDataRow_S(dr, "Week")
            Me._DormitoryType = GetSafeData.ValidateDataRow_S(dr, "DormitoryType")
            Me._FloorId = GetSafeData.ValidateDataRow_S(dr, "FloorId")
            Me._DormitoryId = GetSafeData.ValidateDataRow_S(dr, "DormitoryId")
            Me._HealthScore = GetSafeData.ValidateDataRow_S(dr, "HealthScore")
            Me._HealthGrade = GetSafeData.ValidateDataRow_S(dr, "HealthGrade")
            Me._exist = True
        Else
            Me._exist = False
        End If
    End Sub
    Public Shared Sub Add(ByVal userInfo As Hashtable)
        Dim db As SQLDatabase = New SQLDatabase
        db.Insert("[HealthList]", userInfo)
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
        db.Update("[HealthList]", newUserInfo, strCond)
    End Sub
    Public Shared Sub Delete(ByVal HealthId As String)
        Dim sqls As ArrayList = New ArrayList
        Dim SQLString As String
        SQLString = "Delete from [HealthList] where HealthId=" + SqlStringConstructor.GetQuottedString(HealthId)
        sqls.Add(SQLString)
        Dim db As SQLDatabase = New SQLDatabase
        db.ExecuteSQL(sqls)
    End Sub

    Public Shared Function Query() As DataTable
        Dim SQL As String = "select * from [HealthList]"
        Dim db As SQLDatabase = New SQLDatabase
        Return db.GetDataTable(SQL)
    End Function
    Public Shared Function QueryUsers(ByVal queryItems As Hashtable) As DataTable
        Dim where As String = SqlStringConstructor.GetConditionClause(queryItems)
        Dim sql As String = "Select * from [HealthList] " + where
        Dim db As SQLDatabase = New SQLDatabase
        Return db.GetDataTable(sql)
    End Function
End Class
