﻿Imports System.Net
Imports System.Web.Http
'Handles all HTTP request from users for CRUD (create, read, update, delete)
Namespace Controllers
    Public Class UsersController
        Inherits ApiController

        ' GET: api/Users
        Public Function GetValues() As IEnumerable(Of String)
            Return New String() {"value1", "value2"}
        End Function

        ' GET: api/Users/5
        Public Function GetValue(ByVal id As Integer) As String
            Return "value"
        End Function

        ' POST: api/Users
        Public Sub PostValue(<FromBody()> ByVal value As String)

        End Sub

        ' PUT: api/Users/5
        Public Sub PutValue(ByVal id As Integer, <FromBody()> ByVal value As String)

        End Sub

        ' DELETE: api/Users/5
        Public Sub DeleteValue(ByVal id As Integer)

        End Sub
    End Class
End Namespace