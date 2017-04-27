Public Class PuntoControl
    Dim _IDPunto As Integer
    Dim _IDTramo As Integer
    Dim gestor As GestorPuntoControl

    Public Sub New(IDPunto As Integer, IDTramo As Integer)
        Me._IDPunto = IDPunto
        Me._IDTramo = IDTramo
        Me.gestor = New GestorPuntoControl
    End Sub

    Sub New(ByVal b As Integer)
        _IDPunto = b
        gestor = New GestorPuntoControl
    End Sub

    Public Sub New()
        gestor = New GestorPuntoControl
    End Sub

    Public Property IDPunto
        Get
            Return _IDPunto
        End Get
        Set(value)
            Me._IDPunto = value
        End Set
    End Property

    Public Property IDTramo

        Get
            Return _IDTramo
        End Get
        Set(value)
            Me._IDTramo = value
        End Set
    End Property


    'Método eliminar los elementos de la tabla utilizando la clase gestorVehiculo'
    Public Sub eliminar()
        gestor.delete(Me)
    End Sub

    'Método insertar los elementos de la tabla utilizando la clase gestorVehiculo'
    Public Sub insertar()
        gestor.insert(Me)
    End Sub

    'Método  leer un elemento de la tabla utilizando la clase gestorVehiculo'
    Public Sub leerPuntoControl()
        gestor.read(Me)
    End Sub

    'Método  leer todos los elementos de la tabla utilizando la clase gestorVehiculo'
    Public Sub leerTodos()
        gestor.readAll()
    End Sub

    'Método  modificar los elementos de la tabla utilizando la clase gestorVehiculo'
    Public Sub modificar()
        gestor.update(Me)
    End Sub

    Public Property getGestor As GestorPuntoControl
        Get
            Return gestor
        End Get
        Set(value As GestorPuntoControl)
        End Set
    End Property
End Class
