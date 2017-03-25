Imports System.Data.OleDb

Public Class GestorVehiculo
    Public listaVehiculos As New Collection

    Public Property ListaVehiculo As Collection
        Get
            Return listaVehiculos
        End Get
        Set(value As Collection)
        End Set
    End Property

    'Método eliminar'
    Public Sub delete(per As Vehiculo)
        AgenteBD.getAgente.modificar("DELETE FROM Vehiculos WHERE Matricula = '" & per.matricula & "';")
    End Sub

    'Método insertar'
    Public Sub insert(per As Vehiculo)
        AgenteBD.getAgente.modificar("INSERT INTO Vehiculos VALUES('" & per.matricula & "','" & per.color & "','" & per.modelo & "');")
    End Sub

    'Método leer'
    Public Sub read(per As Vehiculo)
        Dim rd As OleDbDataReader
        rd = AgenteBD.getAgente.leer("SELECT * FROM Vehiculos WHERE Matricula ='" & per.matricula & "';")
        While rd.Read
            ListaVehiculo.Add(New Vehiculo(rd(0), rd(1), rd(2)))
        End While
    End Sub

    'Método leerTodos'
    Public Sub readAll()
        Dim rd As OleDbDataReader
        rd = AgenteBD.getAgente.leer("SELECT * FROM Vehiculos ORDER BY MATRICULA;")
        While rd.Read
            ListaVehiculo.Add(New Vehiculo(rd(0), rd(1), rd(2)))
        End While
    End Sub

    'Método modificar'
    Public Sub update(per As Vehiculo)
        AgenteBD.getAgente.modificar("UPDATE Vehiculos SET Color='" & per.color & "'AND Modelo ='" & per.modelo & "'WHERE Matricula='" & per.matricula & "';")
    End Sub
End Class
