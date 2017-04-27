Public Class Pasa
    Dim _Matricula As Vehiculo
    Dim _IDPunto As PuntoControl
    Dim _tiempo As Date
    Dim _velocidad As Integer
    Dim _gestor As GestorPasa

    Public Sub New(ByVal a As Vehiculo, ByVal b As PuntoControl, ByVal c As Date, ByVal d As Integer)
        _Matricula = a
        _IDPunto = b
        _tiempo = c
        _velocidad = d
        _gestor = New GestorPasa
    End Sub

    Sub New(ByVal a As Vehiculo, ByVal b As PuntoControl, ByVal c As Date)
        _Matricula = a
        _IDPunto = b
        _tiempo = c
        _gestor = New GestorPasa
    End Sub

    Sub New()
        _gestor = New GestorPasa
    End Sub

    Sub New(ByVal a As Vehiculo)
        _Matricula = a
        _gestor = New GestorPasa
    End Sub

    Sub New(ByVal a As PuntoControl)
        _IDPunto = a
        _gestor = New GestorPasa
    End Sub

    Sub New(ByVal a As Date)
        _tiempo = a
        _gestor = New GestorPasa
    End Sub

    Public Property Matricula As Vehiculo
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

    Public Property Tiempo As Date
        Get
            Return _tiempo
        End Get
        Set(value As Date)
            _tiempo = value
        End Set
    End Property

    Public Property Velocidad As Integer
        Get
            Return _velocidad
        End Get
        Set(value As Integer)
            _velocidad = value
        End Set
    End Property
End Class
