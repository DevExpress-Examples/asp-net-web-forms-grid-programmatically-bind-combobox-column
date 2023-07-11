Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls
Imports System.Collections.Generic

Namespace BindToList

    Public Class Bug

        Private idField As Integer

        Public Property Id As Integer
            Get
                Return idField
            End Get

            Set(ByVal value As Integer)
                idField = value
            End Set
        End Property

        Private nameField As String

        Public Property Name As String
            Get
                Return nameField
            End Get

            Set(ByVal value As String)
                nameField = value
            End Set
        End Property

        Private statusField As Integer

        Public Property Status As Integer
            Get
                Return statusField
            End Get

            Set(ByVal value As Integer)
                statusField = value
            End Set
        End Property

        Const count As Integer = 10

        Public Shared Function GetBugList() As List(Of Bug)
            Dim result As List(Of Bug) = New List(Of Bug)(count)
            For i As Integer = 0 To count - 1
                Dim st As Bug = New Bug()
                st.Name = "Bug" & i.ToString()
                st.idField = i
                st.Status = i Mod 3
                result.Add(st)
            Next

            Return result
        End Function
    End Class
End Namespace
