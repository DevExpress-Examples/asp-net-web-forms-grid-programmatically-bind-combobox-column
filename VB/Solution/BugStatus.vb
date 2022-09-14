Imports System.Collections.Generic

Namespace Solution

    Public Class BugStatus

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

        Public Shared Function GetStatusesList() As List(Of BugStatus)
            Dim names As String() = New String() {"Accepted", "Rejected", "Fixed"}
            Dim result As List(Of BugStatus) = New List(Of BugStatus)(names.Length)
            For i As Integer = 0 To names.Length - 1
                Dim st As BugStatus = New BugStatus()
                st.Name = names(i)
                st.idField = i
                result.Add(st)
            Next

            Return result
        End Function
    End Class
End Namespace
