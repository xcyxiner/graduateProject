Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient


Public Class Tree
    Private _dataTable As DataTable
    Public Property dataTable() As DataTable
        Get
            Return _dataTable
        End Get
        Set(ByVal value As DataTable)
            _dataTable = value
        End Set
    End Property
    Private _treeHtml As String
    Public Property treeHtml() As String
        Get
            Return _treeHtml
        End Get
        Set(ByVal value As String)
            _treeHtml = value
        End Set
    End Property
    Public Function CreateTree(ByVal dataTable As DataTable) As String
        Me.dataTable = dataTable
        Me.CreateSubTree(0)
        Return _treeHtml
    End Function
    Private Sub CreateSubTree(ByVal nodeId As Integer)
        Dim childNodes As DataTable = Me.GetChilds(nodeId)
        Dim childId As Integer = 0
        For Each dr As DataRow In childNodes.Rows
            childId = Convert.ToInt32(dr("节点编号"))
            Me.treeHtml += "<div id=div_" + childId.ToString() + ">"

            For i As Integer = 0 To GetLevel(childId) Step +1
                Me.treeHtml += "&nbsp;&nbsp;"

                If Me.IsLeaf(childId) Then
                    Me.treeHtml += "<a href=" + dr("节点URL") + ">" + dr("节点文字") + "</a></div>"
                Else
                    Me.treeHtml += "<a href=" + dr("节点URL") + ">" + dr("节点文字") + "</a></div>"
                    Me.CreateSubTree(childId)
                End If
            Next
        Next
    End Sub
    Private Function GetChilds(ByVal parentId As Integer) As DataTable
        Dim childNodes As DataTable = New DataTable
        childNodes = Me.dataTable.Clone()
        For Each dr As DataRow In Me.dataTable.Rows

            If Convert.ToInt32(dr("父节点编号")) = parentId Then
                childNodes.ImportRow(dr)
            End If
        Next
        Return childNodes
    End Function
    Private Function IsLeaf(ByVal nodeId As Integer) As Boolean
        For Each dr As DataRow In Me.dataTable.Rows

            If Convert.ToInt32(dr("父节点编号")) = nodeId Then
                Return False
            End If
            Return True
        Next

    End Function
    Private Function GetLevel(ByVal nodeId As Integer) As Integer
        Dim parentId As Integer = Me.GetParent(nodeId)

        If parentId = 0 Then
            Return 1
        Else
            Return Me.GetLevel(parentId) + 1
        End If

    End Function

    Private Function GetParent(ByVal nodeId As Integer) As Integer
        For Each dr As DataRow In Me.dataTable.Rows
            If Convert.ToInt32(dr("节点编号")) = nodeId Then
                Return Convert.ToInt32(dr("父节点编号"))
            End If
            Return -1
        Next

    End Function
End Class
