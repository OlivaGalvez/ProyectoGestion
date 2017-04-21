Public Class InsertarRegistro

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Dim menu As New MenuPrincipal
        menu.Show()
        Me.Hide()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If cbTabla.Text = "VEHICULOS" Then
            Dim insertarVehiculo As New InsertarVehiculo
            insertarVehiculo.Show()
            Me.Hide()
        ElseIf cbTabla.Text = "PUNTO_CONTROL" Then
            Dim insertarPuntoControl As New InsertarPuntoControl
            insertarPuntoControl.Show()
            Me.Hide()
        ElseIf cbTabla.Text = "TRAMO" Then
            Dim insertarTramo As New InsertarTramo
            insertarTramo.Show()
            Me.Hide()
        ElseIf cbTabla.Text = "RECORRIDO" Then
            Dim insertarRecorrido As New InsertarRecorrido
            insertarRecorrido.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub cbTabla_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTabla.SelectedIndexChanged

    End Sub
End Class