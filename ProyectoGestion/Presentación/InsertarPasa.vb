Public Class InsertarPasa
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Dim insertarPasa As New InsertarRegistro
        insertarPasa.Show()
        Me.Hide()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub btnHabilitar_Click(sender As Object, e As EventArgs) Handles btnHabilitar.Click
        'Método usado para seleccionar el id de los medicamentos'
        Try
            Dim vehiculo As New Vehiculo()
            Dim elemento As Vehiculo
            vehiculo.leerTodos()

            Dim puntoControl As New PuntoControl()
            Dim elemento2 As PuntoControl

            puntoControl.leerTodos()

            For Each elemento In vehiculo.getGestor.ListaVehiculo
                ListBox1.Items.Add(elemento.matricula.ToString)
            Next

            For Each elemento2 In puntoControl.getGestor.ListaPuntoControl
                ListBox3.Items.Add(elemento2.IDPunto.ToString)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        Try
            Dim a As String
            a = ListBox1.SelectedItem

            Dim vehiculo As New Vehiculo(a)
            Dim elemento As Vehiculo
            vehiculo.leerVehiculo()
            For Each elemento In vehiculo.getGestor.ListaVehiculo
                ListBox2.Items.Add(elemento.matricula.ToString)
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class