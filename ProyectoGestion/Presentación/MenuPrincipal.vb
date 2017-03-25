Public Class MenuPrincipal
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dim Msg As MsgBoxResult
        Msg = MsgBox("¿Desea salir de la aplicación?", vbYesNo, "Menú de Conexión")
        If Msg = MsgBoxResult.Yes Then
            Application.ExitThread()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub btnInsertarDatos_Click(sender As Object, e As EventArgs) Handles btnInsertarDatos.Click
        'Boton usado para llamar al formulario InsertarRegistro'
        Dim insertarRegistro As New InsertarRegistro
        insertarRegistro.Show()
        Me.Hide()
    End Sub
End Class