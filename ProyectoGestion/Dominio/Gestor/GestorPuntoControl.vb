Imports System.Data.OleDb

Public Class GestorPuntoControl

    Public lista As New Collection

    Public Property ListaPuntoControl As Collection
        Get
            Return lista
        End Get
        Set(value As Collection)
        End Set
    End Property

    'Método eliminar'
    Public Sub delete(per As PuntoControl)
        AgenteBD.getAgente.modificar("DELETE FROM Puntocontrol WHERE Id_punto = '" & per.IDPunto & "';")
    End Sub

    'Método insertar'
    Public Sub insert(per As PuntoControl)
        AgenteBD.getAgente.modificar("INSERT INTO Puntocontrol VALUES('" & per.IDPunto & "','" & per.IDTramo & "');")
    End Sub

    'Método leer'
    Public Sub read(per As PuntoControl)
        Dim rd As OleDbDataReader
        rd = AgenteBD.getAgente.leer("SELECT * FROM Puntocontrol WHERE Id_punto ='" & per.IDPunto & "';")
        While rd.Read
            lista.Add(New PuntoControl(rd(0), rd(1)))
        End While
    End Sub

    'Método leerTodos'
    Public Sub readAll()
        Dim rd As OleDbDataReader
        rd = AgenteBD.getAgente.leer("SELECT * FROM Puntocontrol ORDER BY ID_PUNTO;")
        While rd.Read
            lista.Add(New PuntoControl(rd(0), rd(1)))
        End While
    End Sub

    'Método modificar'
    Public Sub update(per As PuntoControl)
        AgenteBD.getAgente.modificar("UPDATE Puntocontrol SET Id_tramo='" & per.IDTramo & "'WHERE Id_punto='" & per.IDPunto & "';")
    End Sub
End Class
