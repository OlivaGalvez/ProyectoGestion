Imports System.Data.OleDb
Public Class GestorTramo
    Public listaTramos As New Collection

    Public Property ListaTramo As Collection
        Get
            Return listaTramos
        End Get
        Set(value As Collection)
        End Set
    End Property

    'Método eliminar'
    Public Sub delete(per As Tramo)
        AgenteBD.getAgente.modificar("DELETE FROM Tramo WHERE Id_tramo = '" & per.idTramo & "';")
    End Sub

    'Método insertar'
    Public Sub insert(per As Tramo)
        AgenteBD.getAgente.modificar("INSERT INTO Tramo VALUES('" & per.idTramo & "','" & per.tipoTramo & "',
        '" & per.longitud & "','" & per.velocidadMax & "','" & per.velocidadMin & "','" & per.velocidadAprox & "');")
    End Sub

    'Método leer'
    Public Sub read(per As Tramo)
        Dim rd As OleDbDataReader
        rd = AgenteBD.getAgente.leer("SELECT * FROM Tramo WHERE Id_tramo ='" & per.idTramo & "';")
        While rd.Read
            ListaTramo.Add(New Tramo(rd(0), rd(1), rd(2), rd(3), rd(4), rd(5)))
        End While
    End Sub

    'Método leerTodos'
    Public Sub readAll()
        Dim rd As OleDbDataReader
        rd = AgenteBD.getAgente.leer("SELECT * FROM Tramo ORDER BY ID_TRAMO;")
        While rd.Read
            ListaTramo.Add(New Tramo(rd(0), rd(1), rd(2), rd(3), rd(4), rd(5)))
        End While
    End Sub

    'Método modificar'
    Public Sub update(per As Tramo)
        AgenteBD.getAgente.modificar("UPDATE Tramo SET Tipo_tramo='" & per.tipoTramo &
                                    "'AND Longitud ='" & per.longitud & "'AND Velocidad_max ='" & per.velocidadMax &
                                    "'AND Velocidad_min ='" & per.velocidadMin & "'AND Velocidad_aprox ='" & per.velocidadAprox &
                                     "'WHERE Id_tramo='" & per.idTramo & "';")
    End Sub
End Class
