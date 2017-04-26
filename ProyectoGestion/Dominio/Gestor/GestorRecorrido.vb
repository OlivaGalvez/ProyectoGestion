Imports System.Data.OleDb
Public Class GestorRecorrido
    Public listaRecorridos As New Collection

    Public Property ListaRecorrido As Collection
        Get
            Return listaRecorridos
        End Get
        Set(value As Collection)
        End Set
    End Property

    'Método eliminar'
    Public Sub delete(per As Recorrido)
        AgenteBD.getAgente.modificar("DELETE FROM Recorrido WHERE Id_Recorrido = '" & per.idRecorrido & "';")
    End Sub

    'Método insertar'
    Public Sub insert(per As Recorrido)
        AgenteBD.getAgente.modificar("INSERT INTO Recorrido VALUES('" & per.idRecorrido & "');")
    End Sub

    'Método leer'
    Public Sub read(per As Recorrido)
        Dim rd As OleDbDataReader
        rd = AgenteBD.getAgente.leer("SELECT * FROM Recorrido WHERE Id_Recorrido ='" & per.idRecorrido & "';")
        While rd.Read
            ListaRecorrido.Add(New Recorrido(rd(0)))
        End While
    End Sub

    'Método leerTodos'
    Public Sub readAll()
        Dim rd As OleDbDataReader
        rd = AgenteBD.getAgente.leer("SELECT * FROM Recorrido ORDER BY ID_RECORRIDO;")
        While rd.Read
            ListaRecorrido.Add(New Recorrido(rd(0)))
        End While
    End Sub

    'Método modificar'
    Public Sub update(per As Recorrido)
        AgenteBD.getAgente.modificar("UPDATE Recorrido SET Id_Recorrido='" & per.idRecorrido & "';")
    End Sub
End Class
