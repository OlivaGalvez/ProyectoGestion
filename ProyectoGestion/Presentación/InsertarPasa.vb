Imports System.Globalization

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

            btn1.Enabled = True
            btn2.Enabled = True
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

            'Revisar'

            'Dim puntoControl As New PuntoControl(b)
            'Dim elemento2 As PuntoControl
            'PuntoControl.leerPuntoControl()
            'For Each elemento2 In puntoControl.getGestor.ListaPuntoControl
            'ListBox2.Items.Add(elemento2.IDPunto.ToString)
            'Next

            btn4.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening

    End Sub

    Private Sub txtMomento_TextChanged(sender As Object, e As EventArgs) Handles txtMomento.TextChanged

    End Sub

    Private Sub txtMomento_Enter(sender As Object, e As EventArgs) Handles txtMomento.Enter
        Dim dt As DateTime

        Dim bln As Boolean = DateTime.TryParse(txtMomento.Text, dt)

        If (bln) Then
            txtMomento.Text = String.Format("{0:ddMMyy}", dt)

        Else
            txtMomento.Clear()
        End If
    End Sub

    Private Sub txtMomento_Leave(sender As Object, e As EventArgs) Handles txtMomento.Leave
        ' Obtenemos la configuración regional del usuario
        '
        Dim ci As CultureInfo =
          Threading.Thread.CurrentThread.CurrentCulture

        Dim dt As DateTime

        ' Verificamos si la fecha es correcta y cumple con el
        ' modelo de fecha especificado.
        '
        Dim bln As Boolean = DateTime.TryParseExact(
            txtMomento.Text, "dd/MM/yy", ci, DateTimeStyles.None, dt)

        If (bln) Then
            txtMomento.Text = String.Format("{0:dd/MM/yy}", dt)

        Else
            MessageBox.Show("Fecha incorrecta.")

        End If
    End Sub

    Private Sub btnAyuda_Click(sender As Object, e As EventArgs) Handles btnAyuda.Click
        Dim formatoFecha As New FormatoFecha
        formatoFecha.Show()
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        Try
            Dim a As String
            a = ListBox2.SelectedItem

            If IsNumeric(a) = True Then
                MsgBox("No se puede coger el idPunto para este botón")
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