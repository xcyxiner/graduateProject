Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient

Public Class GetSafeData
    Public Shared Function ValidateDataRow_S(ByVal row As DataRow, ByVal colname As String) As String

        If row(colname).Equals(DBNull.Value) = False Then
            Return row(colname).ToString
        Else
            Return System.String.Empty
        End If
    End Function
    Public Shared Function ValidateDataRow_N(ByVal row As DataRow, ByVal colname As String) As Integer

        If row(colname.ToString).Equals(DBNull.Value) = False Then
            Return row(colname.ToString).ToString
        Else
            Return System.Int32.MinValue
        End If
    End Function
    Public Shared Function ValidateDataRow_F(ByVal row As DataRow, ByVal colname As String) As Double

        If row(colname.ToString).Equals(DBNull.Value) = False Then
            Return row(colname.ToString).ToString
        Else
            Return System.Double.MinValue
        End If
    End Function
    Public Shared Function ValidateDataRow_T(ByVal row As DataRow, ByVal colname As String) As Date

        If row(colname.ToString).Equals(DBNull.Value) = False Then
            Return row(colname.ToString).ToString
        Else
            Return System.DateTime.MinValue
        End If
    End Function
    Public Shared Function ValidateDataReader_S(ByVal reader As SqlDataReader, ByVal colname As String) As String

        If reader.GetValue(reader.GetOrdinal(colname)).Equals(DBNull.Value) = False Then
            Return reader.GetString(reader.GetOrdinal(colname))
        Else
            Return System.String.Empty
        End If
    End Function
    Public Shared Function ValidateDataReader_N(ByVal reader As SqlDataReader, ByVal colname As String) As String

        If reader.GetValue(reader.GetOrdinal(colname.ToString)).Equals(DBNull.Value) = False Then
            Return reader.GetString(reader.GetOrdinal(colname.ToString))
        Else
            Return System.Int32.MinValue.ToString
        End If
    End Function
    Public Shared Function ValidateDataReader_F(ByVal reader As SqlDataReader, ByVal colname As String) As String

        If reader.GetValue(reader.GetOrdinal(colname)).Equals(DBNull.Value) = False Then
            Return reader.GetString(reader.GetOrdinal(colname.ToString))
        Else
            Return System.Double.MinValue.ToString
        End If
    End Function
    Public Shared Function ValidateDataReader_T(ByVal reader As SqlDataReader, ByVal colname As String) As String

        If reader.GetValue(reader.GetOrdinal(colname.ToString)).Equals(DBNull.Value) = False Then
            Return reader.GetString(reader.GetOrdinal(colname.ToString))
        Else
            Return System.DateTime.MinValue
        End If
    End Function
End Class
