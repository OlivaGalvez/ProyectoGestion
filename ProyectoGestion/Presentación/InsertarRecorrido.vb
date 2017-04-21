Public Class InsertarRecorrido
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Dim insertarRecorrido As New InsertarRegistro
        insertarRecorrido.Show()
        Me.Hide()
    End Sub
End Class