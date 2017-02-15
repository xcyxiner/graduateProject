Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient

Public Class SqlStringConstructor
    Public Shared Function GetQuottedString(ByVal pstr As String) As String
        Return ("'" + pstr.Replace("'", "''") + "'")
    End Function
    Public Shared Function GetConditionClause(ByVal queryItems As Hashtable) As String
        Dim count As Integer = 0
        Dim Where As String = ""
        For Each Item As DictionaryEntry In queryItems

            If count = 0 Then
                Where = " Where "
            Else
                Where = " And "
            End If
            If Item.Value.GetType.ToString().Equals("System.String") = True OrElse Item.Value.GetType.ToString().Equals("System.DateTime") = True Then
                Where += "[" + Item.Key.ToString + "]"
                Where += " Like "
                Where += SqlStringConstructor.GetQuottedString("%" + Item.Value.ToString + "%")
            Else
                Where += "[" + Item.Key.ToString + "]" + "=" + Item.Value.ToString

            End If
            count += 1
        Next
        Return Where
    End Function
    Public Shared Function GetAndConditionClause(ByVal queryItems As Hashtable, ByVal type As String) As String
        Dim count As Integer = 0
        Dim Where As String = ""
        For Each Item As DictionaryEntry In queryItems

            If count = 0 Then
                Where = " Where "
            Else
                Where = " " + type + " "
            End If
            If Item.Value.GetType.ToString().Equals("System.String") = True OrElse Item.Value.GetType.ToString().Equals("System.DateTime") = True Then
                Where += "[" + Item.Key.ToString + "]"
                Where += +" Like "
                Where += +SqlStringConstructor.GetQuottedString("%" + Item.Value.ToString + "%")
            Else
                Where += Item.Key.ToString + "=" + Item.Value.ToString

            End If
            count += 1
        Next
        Return Where
    End Function
End Class
