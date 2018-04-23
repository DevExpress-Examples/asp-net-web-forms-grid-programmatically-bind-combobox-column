Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Configuration
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls
Imports System.Collections.Generic

Namespace BindToList
	Public Class Bug
		Private id_Renamed As Integer

		Public Property Id() As Integer
			Get
				Return id_Renamed
			End Get
			Set(ByVal value As Integer)
				id_Renamed = value
			End Set
		End Property

		Private name_Renamed As String

		Public Property Name() As String
			Get
				Return name_Renamed
			End Get
			Set(ByVal value As String)
				name_Renamed = value
			End Set
		End Property

		Private status_Renamed As Integer

		Public Property Status() As Integer
			Get
				Return status_Renamed
			End Get
			Set(ByVal value As Integer)
				status_Renamed = value
			End Set
		End Property

		Private Const count As Integer = 10
		Public Shared Function GetBugList() As List(Of Bug)
			Dim result As List(Of Bug) = New List(Of Bug)(count)
			For i As Integer = 0 To count - 1
				Dim st As New Bug()
				st.Name = "Bug" & i.ToString()
				st.id = i
				st.Status = i Mod 3
				result.Add(st)
			Next i
			Return result
		End Function

	End Class
End Namespace
