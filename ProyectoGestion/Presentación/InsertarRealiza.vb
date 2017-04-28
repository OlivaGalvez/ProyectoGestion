Public Class InsertarRealiza
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Dim insertarRealiza As New InsertarRegistro
        insertarRealiza.Show()
        Me.Hide()
    End Sub

    Private Sub btnHabilitar_Click(sender As Object, e As EventArgs) Handles btnHabilitar.Click
        'Método usado para seleccionar el id de los medicamentos'
        Try
            Dim vehiculo As New Vehiculo()
            Dim elemento As Vehiculo
            vehiculo.leerTodos()

            Dim recorrido As New Recorrido()
            Dim elemento2 As Recorrido

            recorrido.leerTodos()

            For Each elemento In vehiculo.getGestor.ListaVehiculo
                ListBox1.Items.Add(elemento.matricula.ToString)
            Next

            For Each elemento2 In recorrido.getGestor.ListaRecorrido
                ListBox3.Items.Add(elemento2.idRecorrido.ToString)
            Next

            btn1.Enabled = True
            btn2.Enabled = True
            btnHabilitar.Enabled = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtHoraLlegada.Text = " "
        txtHoraSalida.Text = " "
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        ListBox3.Items.Clear()
        btnHabilitar.Enabled = True
        btn1.Enabled = False
        btn2.Enabled = False
        btn3.Enabled = False
        btn4.Enabled = False
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
            btn3.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        Try

            Dim b As Integer
            b = ListBox3.SelectedItem

            ListBox2.Items.Add(b.ToString)

            btn4.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        Try
            Dim a As String
            a = ListBox2.SelectedItem

            If IsNumeric(a) = True Then
                MsgBox("No se puede coger el idRecorrido para este botón")
            Else
                ListBox2.Items.Remove(a)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        Try
            Dim b As Integer
            b = ListBox2.SelectedItem

            If TypeName(b) = "String" Then
                MsgBox("No se puede coger la matricula para este botón")
            Else
                ListBox2.Items.Remove(CStr(b))

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class