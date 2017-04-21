Public Class InsertarPertenece
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Dim insertarPertenece As New InsertarRegistro
        insertarPertenece.Show()
        Me.Hide()
    End Sub
End Class