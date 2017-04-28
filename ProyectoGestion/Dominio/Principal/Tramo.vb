Public Class Tramo
    Dim _IdTramo As Integer
    Dim _tipoTramo As String
    Dim _longitud As Integer
    Dim _velocidadMax As Integer
    Dim _velocidadMin As Integer
    Dim _velocidadAprox As Integer

    Dim _gestor As GestorTramo

    Public Sub New(idTramo As Integer, tipoTramo As String, longitud As Integer,
                   velocidadMax As Integer, velocidadMin As Integer, velocidadAprox As Integer)
        Me._IdTramo = idTramo
        Me._tipoTramo = tipoTramo
        Me._longitud = longitud
        Me._velocidadMax = velocidadMax
        Me._velocidadMin = velocidadMin
        Me._velocidadAprox = _velocidadAprox
        Me._gestor = New GestorTramo
    End Sub

    Sub New(ByVal a As Integer)
        _IdTramo = a
        _gestor = New GestorTramo
    End Sub

    Public Sub New()
        _gestor = New GestorTramo
    End Sub

    Public Property idTramo
        Get
            Return _IdTramo
        End Get
        Set(value)
            Me._IdTramo = value
        End Set
    End Property

    Public Property tipoTramo
        Get
            Return _tipoTramo
        End Get
        Set(value)
            Me._tipoTramo = value
        End Set
    End Property


    Public Property longitud
        Get
            Return _longitud
        End Get
        Set(value)
            Me._longitud = value
        End Set
    End Property


    Public Property velocidadMax
        Get
            Return _velocidadMax
        End Get
        Set(value)
            Me._velocidadMax = value
        End Set
    End Property


    Public Property velocidadMin
        Get
            Return _velocidadMin
        End Get
        Set(value)
            Me._velocidadMin = value
        End Set
    End Property


    Public Property velocidadAprox
        Get
            Return _velocidadAprox
        End Get
        Set(value)
            Me._velocidadAprox = value
        End Set
    End Property

    Public Property getGestor As GestorTramo
        Get
            Return _gestor
        End Get
        Set(value As GestorTramo)
        End Set
    End Property



    Public Sub eliminar()
        _gestor.delete(Me)
    End Sub


    Public Sub insertar()
        _gestor.insert(Me)
    End Sub


    Public Sub leerTramo()
        _gestor.read(Me)
    End Sub


    Public Sub leerTodos()
        _gestor.readAll()
    End Sub


    Public Sub modificar()
        _gestor.update(Me)
    End Sub
End Class
