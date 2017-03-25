Public Class Pasa
    Dim _Matricula As Vehiculo
    Dim _IDPunto As PuntoControl
    Dim _gestor As GestorPasa

    Public Property Vehiculo As Vehiculo
        Get
            Return _Matricula
        End Get
        Set(value As Vehiculo)
            _Matricula = value
        End Set
    End Property

    Public Property PuntoControl As PuntoControl
        Get
            Return _IDPunto
        End Get
        Set(value As PuntoControl)
            _IDPunto = value
        End Set
    End Property

    Public Property getGestor As GestorPasa
        Get
            Return _gestor
        End Get
        Set(value As GestorPasa)
        End Set
    End Property

    Sub New(ByVal a As Vehiculo)
        _Matricula = a
        _gestor = New GestorPasa
    End Sub

    Sub New(ByVal a As PuntoControl)
        _IDPunto = a
        _gestor = New GestorPasa
    End Sub

    Sub New(ByVal a As Vehiculo, ByVal b As PuntoControl)
        _Matricula = a
        _IDPunto = b
        _gestor = New GestorPasa
    End Sub

    Sub New()
        _gestor = New GestorPasa
    End Sub


    Public Sub eliminar()
        _gestor.delete(Me)
    End Sub


    Public Sub insertar()
        _gestor.insert(Me)
    End Sub


    Public Sub leerPasa()
        _gestor.read(Me)
    End Sub

    Public Sub leerPasa2()
        _gestor.read2(Me)
    End Sub


    Public Sub leerTodos()
        _gestor.readAll()
    End Sub


    Public Sub modificar()
        _gestor.update(Me)
    End Sub
End Class
