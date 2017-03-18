Imports System.Data.OleDb

Public Class AgenteBD
    Private Shared CadConexion = “Provider=Microsoft.ACE.OLEDB.12.0; Data Source="
    Private Shared mConexion As OleDbConnection
    Private Shared mInstancia As AgenteBD 'Instancia que utilizaremos para comunicarnos con la base de datos'
    Public Shared mRutaBBDD As String 'Ruta donde se encuentra la base de datos'

    Private Sub New()
        mConexion = New OleDbConnection(CadConexion & mRutaBBDD) 'Pasamos el CadConexion por parámetros'
        mConexion.Open()
    End Sub

    Public Sub desconectar()
        mConexion.Close()
    End Sub

    Public Shared Function getAgente() As AgenteBD
        If mInstancia Is Nothing Then 'Si la instancia está vacía: '
            mInstancia = New AgenteBD()
        End If 'Si no está vacía llamamos a la instancia '
        Return mInstancia

    End Function

    Public Function leer(ByVal sql As String) As OleDbDataReader
        Dim com As New OleDbCommand(sql, mConexion)
        Return com.ExecuteReader()
    End Function

    Public Function modificar(ByVal sql As String) As Integer
        Dim com As New OleDbCommand(sql, mConexion)
        Return com.ExecuteNonQuery()
    End Function
End Class
