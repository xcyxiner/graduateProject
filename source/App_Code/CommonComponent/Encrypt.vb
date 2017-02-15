Imports Microsoft.VisualBasic

Public Class Encrypt
    Public Shared Function EncryptString(ByVal str As String, ByVal key As String) As String
        Dim bStr As Byte() = (New UnicodeEncoding()).GetBytes(str)
        Dim bkey As Byte() = (New UnicodeEncoding()).GetBytes(key)

        For i As Integer = 0 To bStr.Length Step +2

            For j As Integer = 0 To bkey.Length Step +2
                bStr(i) = Convert.ToByte(bStr(i) ^ bkey(j))
            Next

        Next
        Return (New UnicodeEncoding()).GetString(bStr).TrimEnd("'\0'")
    End Function
    Public Shared Function DecrytString(ByVal str As String, ByVal key As String) As String
        Return EncryptString(str, key)
    End Function
End Class
