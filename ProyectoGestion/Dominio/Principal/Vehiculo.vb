Public Class Vehiculo
    Dim _matricula As String
    Dim _color As String
    Dim _modelo As String
    Dim gestor As GestorVehiculo

    Public Sub New(matricula As String, color As String, modelo As String)
        Me._matricula = matricula
        Me._color = color
        Me._modelo = modelo
        Me.gestor = New GestorVehiculo
    End Sub

    Public Sub New(matricula As String)
        Me._matricula = matricula
    End Sub

    Public Sub New()
        gestor = New GestorVehiculo
    End Sub

    Public Property matricula
        Get
            Return _matricula
        End Get
        Set(value)
            Me._matricula = value
        End Set
    End Property

    Public Property color

        Get
            Return _color
        End Get
        Set(value)
            Me._color = value
        End Set
    End Property

    Public Property modelo

        Get
            Return _modelo
        End Get
        Set(value)
            Me._modelo = value
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
    Public Sub leerVehiculo()
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

    Public Property getGestor As GestorVehiculo
        Get
            Return gestor
        End Get
        Set(value As GestorVehiculo)
        End Set
    End Property

End Class
