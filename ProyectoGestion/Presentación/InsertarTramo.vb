Public Class InsertarTramo
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Dim insertarTramo As New InsertarRegistro
        insertarTramo.Show()
        Me.Hide()
    End Sub
End Class