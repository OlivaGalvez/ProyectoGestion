Public Class InsertarPasa
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Dim insertarPasa As New InsertarRegistro
        insertarPasa.Show()
        Me.Hide()
    End Sub
End Class