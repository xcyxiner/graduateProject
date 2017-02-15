Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Collections

Public Class SQLDatabase

    Private _conn As SqlConnection
    Public Property conn() As SqlConnection
        Get
            Return _conn
        End Get
        Set(ByVal value As SqlConnection)
            _conn = value
        End Set
    End Property
    Private connectionstring As String
    Sub New()
        '下面这个是使用的服务器连接()
        connectionstring = ConfigurationManager.AppSettings("DBConnectionString")
        '下面这个是使用的dypj.mdf连接()
        'connectionstring = ConfigurationManager.AppSettings("DBConnectionString2")
        '下面这个是使用的服务器连接, windows验证
        'connectionstring = ConfigurationManager.AppSettings("DBConnectionString3")
    End Sub
    Protected Sub Open()

        If conn Is Nothing = True Then
            conn = New SqlConnection(connectionstring)
        End If

        If conn.State.Equals(ConnectionState.Closed) Then
            conn.Open()
        End If
    End Sub
    Protected Sub Close()

        If conn Is Nothing = False Then
            conn.Close()
        End If
    End Sub
    Public Function ExecuteSQL(ByVal SQLString As String) As Boolean
        Dim success As Boolean = True
        Me.Open()
        Try
            Dim cmd As SqlCommand = New SqlCommand(SQLString, conn)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            success = False
        Finally
            Me.Close()
        End Try
        Return success
    End Function
    Public Function ExecuteSQL(ByVal SqlStrings As ArrayList) As Boolean
        Dim success As Boolean = True
        Me.Open()
        Dim cmd As SqlCommand = New SqlCommand
        Dim trans As SqlTransaction = Me.conn.BeginTransaction
        cmd.Connection = Me.conn
        cmd.Transaction = trans
        Try
            For Each str As String In SqlStrings
                cmd.CommandText = str
                cmd.ExecuteNonQuery()
            Next
            trans.Commit()
        Catch ex As Exception
            success = False
            trans.Rollback()
        Finally
            Me.Close()
        End Try
        Return success
    End Function
    Public Function GetDataReader(ByVal SqlString As String) As SqlDataReader
        Me.Open()
        Dim cmd As SqlCommand = New SqlCommand(SqlString, conn)
        Return cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection)
    End Function
    Public Function Insert(ByVal TableName As String, ByVal Cols As Hashtable) As Boolean
        Dim Count As Integer = 0

        If Cols.Count <= 0 Then
            Return True
        End If

        Dim Fields As String = " ("
        Dim Values As String = " Values("
        For Each Item As DictionaryEntry In Cols

            If Count <> 0 Then
                Fields += ","
                Values += ","
            End If
            Fields += Item.Key.ToString
            Values += Item.Value.ToString
            Count += 1
        Next
        Fields += ")"
        Values += ")"
        Dim SqlString As String = "Insert into " + TableName + Fields + Values
        Return Convert.ToBoolean(ExecuteSQL(SqlString))
    End Function
    Public Function Update(ByVal TableName As String, ByVal Cols As Hashtable, ByVal Where As String) As Boolean
        Dim Count As Integer = 0

        If Cols.Count <= 0 Then
            Return True
        End If

        Dim Fields As String = " "
        For Each Item As DictionaryEntry In Cols

            If Count <> 0 Then
                Fields += ","
            End If
            Fields += Item.Key.ToString
            Fields += " = "
            Fields += Item.Value.ToString
            Count += 1
        Next
        Fields += " "
        Dim SqlString As String = "Update " + TableName + " Set " + Fields + Where
        Return Convert.ToBoolean(ExecuteSQL(SqlString))
    End Function
    Public Function GetDataSet(ByVal SQLString As String) As DataSet
        Me.Open()
        Dim sda As SqlDataAdapter = New SqlDataAdapter(SQLString, conn)
        Dim ds As DataSet = New DataSet
        sda.Fill(ds)
        Me.Close()
        Return ds
    End Function
    Public Function GetDataTable(ByVal SQLString As String) As DataTable
        Me.Open()
        Dim sda As SqlDataAdapter = New SqlDataAdapter(SQLString, conn)
        Dim ds As DataSet = New DataSet
        sda.Fill(ds)
        Me.Close()
        Return ds.Tables.Item(0)
    End Function
    Public Function GetDataRow(ByVal SQLstring As String) As DataRow
        Dim ds As DataSet = Me.GetDataSet(SQLstring)
        ds.CaseSensitive = False

        If ds.Tables.Item(0).Rows.Count > 0 Then
            Return ds.Tables.Item(0).Rows.Item(0)
        Else
            Return Nothing
        End If

    End Function

End Class
