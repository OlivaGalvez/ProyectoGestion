Public Class InsertarPertenece
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Dim insertarPertenece As New InsertarRegistro
        insertarPertenece.Show()
        Me.Hide()
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        ListBox3.Items.Clear()
        btnHabilitar.Enabled = True
        btn1.Enabled = False
        btn2.Enabled = False
        btn3.Enabled = False
        btn4.Enabled = False
    End Sub

    Private Sub btnHabilitar_Click(sender As Object, e As EventArgs) Handles btnHabilitar.Click
        'Método usado para seleccionar el id de los medicamentos'
        Try
            Dim recorrido As New Recorrido()
            Dim elemento As Recorrido
            recorrido.leerTodos()

            Dim tramo As New Tramo()
            Dim elemento2 As Tramo

            tramo.leerTodos()

            For Each elemento In recorrido.getGestor.ListaRecorrido
                ListBox1.Items.Add(elemento.idRecorrido.ToString)
            Next

            For Each elemento2 In tramo.getGestor.ListaTramo
                ListBox3.Items.Add(elemento2.idTramo.ToString)
            Next

            btn1.Enabled = True
            btn2.Enabled = True
            btnHabilitar.Enabled = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        Try
            Dim a As Integer
            a = ListBox1.SelectedItem

            ' Dim recorrido As New Recorrido(a)
            'Dim elemento As Recorrido
            ' Recorrido.leerRecorrido()
            ' For Each elemento In recorrido.getGestor.ListaRecorrido
            ListBox2.Items.Add(a)
            ' Next
            btn3.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        Try
            Dim a As Integer
            a = ListBox3.SelectedItem

            'Dim tramo As New Tramo(a)
            'Dim elemento As Tramo
            'Tramo.leerTramo()
            'For Each elemento In tramo.getGestor.ListaTramo
            ListBox2.Items.Add(a)
            'Next
            btn4.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        Try
            Dim a As Integer
            a = ListBox2.SelectedItem

            ListBox2.Items.Remove(a)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        Try
            Dim a As Integer
            a = ListBox2.SelectedItem

            ListBox2.Items.Remove(a)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class