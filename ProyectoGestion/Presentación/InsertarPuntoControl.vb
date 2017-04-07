Imports System.Data.OleDb

Public Class InsertarPuntoControl
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Dim insertarRegistro As New InsertarRegistro
        insertarRegistro.Show()
        Me.Hide()
    End Sub

    Private Sub btnInsertar_Click(sender As Object, e As EventArgs) Handles btnInsertar.Click

        Try
            Dim idPunto As Integer
            Dim idTramo As Integer

            Dim puntoControl As New PuntoControl()
            Dim elemento As PuntoControl
            puntoControl.leerTodos()

            Dim guardarElemento As New ListBox

            If txtIDPunto.Text = "" And txtTramo.Text = "" Or txtIDPunto.Text = "" Or txtTramo.Text = "" Then
                MsgBox("Ningún campo puede estar vacío")
            Else
                idPunto = txtIDPunto.Text
                idTramo = txtTramo.Text

                For Each elemento In puntoControl.getGestor.lista
                    guardarElemento.Items.Add(elemento.IDPunto.ToString())
                Next

                If IsNumeric(idPunto) = False Or IsNumeric(idTramo) = False Then
                    MsgBox("Algún campos se ha introducido de manera incorrecta")
                ElseIf guardarElemento.Items.Contains(idPunto.ToString) Then
                    MsgBox("El punto de control ya existe.Por favor, inserte otro punto")
                Else

                    Dim ptControl As PuntoControl = New PuntoControl(idPunto, idTramo)
                    Try
                        ptControl.insertar()
                        MsgBox("Punto de Control insertado correctamente")
                    Catch ex As OleDbException
                        MsgBox("Acción incorrecta" & ex.Message)
                    End Try
                End If


            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub limpiar()
        txtIDPunto.Text = " "
        txtTramo.Text = " "

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        limpiar()

    End Sub
End Class