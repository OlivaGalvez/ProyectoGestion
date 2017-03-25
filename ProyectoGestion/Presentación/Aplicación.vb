Public Class Aplicación

    Private Sub btnRutaBD_Click(sender As Object, e As EventArgs) Handles btnRutaBD.Click
        'Botón Ruta BD. Desde aquí seleccionamos la ruta para luego poder conectarnos con la BBDD.'
        OpenFileDialog1.Filter = "access |*.accdb| ALL Files | *.*"
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            textRuta.Text = OpenFileDialog1.FileName
            textRuta.Enabled = True
            AgenteBD.mRutaBBDD = textRuta.Text
            btnConectarBD.Enabled = True
        End If
    End Sub

    Private Sub btnConectarBD_Click(sender As Object, e As EventArgs) Handles btnConectarBD.Click
        Try
            Dim vehiculo As Vehiculo
            vehiculo = New Vehiculo
            vehiculo.leerTodos()
            lblConectar.ForeColor = Color.Green
            lblConectar.Text = "Conectado."
            btnEntrar.Enabled = True
        Catch ex As Exception
            AgenteBD.getAgente.desconectar()
            MsgBox("Error al conectar con la base de datos. " & ex.Message)
        End Try
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click

        Dim Msg As MsgBoxResult
        Msg = MsgBox("¿Desea salir de la aplicación?", vbYesNo, "Menú de Conexión")
        If Msg = MsgBoxResult.Yes Then
            Application.ExitThread()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub btnEntrar_Click(sender As Object, e As EventArgs) Handles btnEntrar.Click
        'Boton usado para llamar al formulario Menu Principal'
        Dim menu As New MenuPrincipal
        menu.Show()
        Me.Hide()
    End Sub

End Class
