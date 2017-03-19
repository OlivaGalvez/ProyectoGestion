Imports System.Data.OleDb
Public Class InsertarVehiculo
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Dim insertarRegistro As New InsertarRegistro
        insertarRegistro.Show()
        Me.Hide()
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        limpiar()
    End Sub

    Private Sub limpiar()
        txtMatricula.Text = " "
        txtColor.Text = " "
        txtModelo.Text = " "
    End Sub

    Private Sub btnInsertar_Click(sender As Object, e As EventArgs) Handles btnInsertar.Click
        'Boton usado para insertar pacientes'
        Try
            Dim matricula As String
            Dim color As String
            Dim modelo As String

            Dim veh As New Vehiculo()
            Dim elemento As Vehiculo
            veh.leerTodos()

            Dim guardarElemento As New ListBox



            If txtMatricula.Text = "" And txtColor.Text = "" And txtModelo.Text = "" And
               txtMatricula.Text = "" Or txtColor.Text = "" Or txtModelo.Text = "" Then
                MsgBox("Ningún campo puede estar vacío")
            Else
                matricula = txtMatricula.Text
                color = txtColor.Text
                modelo = txtModelo.Text

                For Each elemento In veh.getGestor.ListaVehiculo
                    guardarElemento.Items.Add(elemento.matricula.ToString())
                Next

                If IsNumeric(matricula) Or IsNumeric(color) Or IsNumeric(modelo) Then
                    MsgBox("Algún campos se ha introducido de manera incorrecta")
                ElseIf guardarElemento.Items.Contains(matricula.ToString) Then
                    MsgBox("No puede haber dos matriculas iguales")
                Else

                    Dim vehiculo As Vehiculo = New Vehiculo(matricula, color, modelo)
                    Try
                        vehiculo.insertar()
                        MsgBox("Vehiculo insertado correctamente")
                    Catch ex As OleDbException
                        MsgBox("Acción incorrecta" & ex.Message)
                    End Try
                    limpiar()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class