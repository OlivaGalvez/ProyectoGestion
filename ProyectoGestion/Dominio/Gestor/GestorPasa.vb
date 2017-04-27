Imports System.Data.OleDb

Public Class GestorPasa

    Public _lista As New Collection

    Public Property ListaPasa As Collection
        Get
            Return _lista
        End Get
        Set(value As Collection)
        End Set
    End Property


End Class
