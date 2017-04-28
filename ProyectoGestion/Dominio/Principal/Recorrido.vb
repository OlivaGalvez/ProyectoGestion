Public Class Recorrido
    Dim _idRecorrido As Integer
    Dim gestor As GestorRecorrido

    Public Sub New(idRecorrido As Integer)
        Me._idRecorrido = idRecorrido
        Me.gestor = New GestorRecorrido
    End Sub

    Public Sub New()
        gestor = New GestorRecorrido
    End Sub

    Public Property idRecorrido
        Get
            Return _idRecorrido
        End Get
        Set(value)
            Me._idRecorrido = value
        End Set
    End Property

    Public Sub eliminar()
        gestor.delete(Me)
    End Sub

    Public Sub insertar()
        gestor.insert(Me)
    End Sub


    Public Sub leerRecorrido()
        gestor.read(Me)
    End Sub

    Public Sub leerTodos()
        gestor.readAll()
    End Sub

    Public Sub modificar()
        gestor.update(Me)
    End Sub

    Public Property getGestor As GestorRecorrido
        Get
            Return gestor
        End Get
        Set(value As GestorRecorrido)
        End Set
    End Property
End Class
