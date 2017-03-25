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

    'Método eliminar'
    Public Sub delete(det As Pasa)
        Dim num1 As String
        Dim num2 As String
        num1 = CStr(det.Vehiculo.matricula)
        num2 = CStr(det.PuntoControl.IDPunto)
        AgenteBD.getAgente.modificar("DELETE FROM Pasa WHERE Vehiculo = " & num1 & " And Puntocontrol= " & num2 & ";")
    End Sub

    'Método insertar'
    Public Sub insert(det As Pasa)
        AgenteBD.getAgente.modificar("INSERT INTO Pasa VALUES('" & det.Vehiculo.matricula & "','" & det.PuntoControl.IDPunto & "');")
    End Sub

    'Método leer'
    Public Sub read(det As Pasa)
        Dim rd As OleDbDataReader
        Dim veh As Vehiculo
        Dim pContr As PuntoControl
        Dim num1 As String
        Dim num2 As String
        num1 = CStr(det.Vehiculo.matricula)
        num2 = CStr(det.PuntoControl.IDPunto)
        rd = AgenteBD.getAgente.leer("SELECT * FROM Detalles_Recetas WHERE Vehiculo=" & num1 & " AND Puntocontrol= " & num2 & ";")
        While rd.Read()
            veh = New Vehiculo(rd(0))
            pContr = New PuntoControl(rd(1))
            ListaPasa.Add(New Pasa(veh, pContr))
        End While
    End Sub

    'Método leer2'
    Public Sub read2(det As Pasa)
        Dim rd As OleDbDataReader
        Dim veh As Vehiculo
        Dim pContr As PuntoControl
        Dim num1 As String
        num1 = CStr(det.Vehiculo.matricula)
        rd = AgenteBD.getAgente.leer("SELECT * FROM Pasa WHERE Vehiculo=" & num1 & ";")
        While rd.Read()
            veh = New Vehiculo(rd(0))
            pContr = New PuntoControl(rd(1))
            ListaPasa.Add(New Pasa(veh, pContr))
        End While
    End Sub

    'Método leerTodos'
    Public Sub readAll()
        Dim rd As OleDbDataReader
        Dim veh As Vehiculo
        Dim pContr As PuntoControl
        rd = AgenteBD.getAgente.leer("SELECT * FROM Pasa ORDER BY Vehiculo, Puntocontrol;")
        While rd.Read
            veh = New Vehiculo(rd(0))
            pContr = New PuntoControl(rd(1))
            ListaPasa.Add(New Pasa(veh, pContr))
        End While
    End Sub

    'Método modificar'
    Public Sub update(det As Pasa)
        Dim num1 As String
        Dim num2 As String
        num1 = CStr(det.Vehiculo.matricula)
        num2 = CStr(det.PuntoControl.IDPunto)
        AgenteBD.getAgente.modificar("UPDATE Pasa WHERE Vehiculo = " & num1 & " AND Puntocontrol= " & num2 & ";")
    End Sub
End Class
