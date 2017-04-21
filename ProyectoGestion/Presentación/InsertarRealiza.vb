Public Class InsertarRealiza
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Dim insertarRealiza As New InsertarRegistro
        insertarRealiza.Show()
        Me.Hide()
    End Sub
End Class