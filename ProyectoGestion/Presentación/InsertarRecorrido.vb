Imports System.Data.OleDb
Public Class InsertarRecorrido
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Dim insertarRecorrido As New InsertarRegistro
        insertarRecorrido.Show()
        Me.Hide()
    End Sub

    Private Sub btnInsertar_Click(sender As Object, e As EventArgs) Handles btnInsertar.Click
        Try

            Dim _idRecorrido As Integer

            Dim recorrido As New Recorrido()
            Dim elemento As Recorrido
            recorrido.leerTodos()

            Dim guardarElemento As New ListBox

            If txtRecorrido.Text = " " Then

                MsgBox("Ningún campo puede estar vacío")
            Else
                _idRecorrido = txtRecorrido.Text


                For Each elemento In recorrido.getGestor.ListaRecorrido
                    guardarElemento.Items.Add(elemento.idRecorrido.ToString())
                Next


                If guardarElemento.Items.Contains(_idRecorrido.ToString) Then
                    MsgBox("No puede haber dos id Recorrido iguales")
                Else

                    Dim tm As Recorrido = New Recorrido(_idRecorrido)
                    Try
                        tm.insertar()
                        MsgBox("Recorrido insertado correctamente")
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

    Private Sub limpiar()
        txtRecorrido.Text = " "
    End Sub
End Class