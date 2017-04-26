Imports System.Data.OleDb

Public Class InsertarTramo
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Dim insertarTramo As New InsertarRegistro
        insertarTramo.Show()
        Me.Hide()
    End Sub

    Private Sub btnInsertar_Click(sender As Object, e As EventArgs) Handles btnInsertar.Click
        Try

            Dim _IdTramo As String
            Dim _tipoTramo As String
            Dim _longitud As Integer
            Dim _velocidadMax As Integer
            Dim _velocidadMin As Integer
            Dim _velocidadAprox As Integer

            Dim tramo As New Tramo()
            Dim elemento As Tramo
            tramo.leerTodos()

            Dim guardarElemento As New ListBox



            If txtIDTramo.Text = "" And txtLongitud.Text = "" And txtVelocAprox.Text = "" And txtVelocMax.Text = "" And
               txtVelocMin.Text = "" And
                txtIDTramo.Text = "" Or txtLongitud.Text = "" Or txtVelocAprox.Text = "" Or txtVelocMax.Text = "" Or
                txtVelocMin.Text = "" Then

                MsgBox("Ningún campo puede estar vacío")
            Else
                _IdTramo = txtIDTramo.Text
                _tipoTramo = comBoxTramo.Text
                _longitud = txtLongitud.Text
                _velocidadMax = txtVelocMax.Text
                _velocidadMin = txtVelocMin.Text
                _velocidadAprox = txtVelocAprox.Text


                For Each elemento In tramo.getGestor.ListaTramo
                    guardarElemento.Items.Add(elemento.idTramo.ToString())
                Next


                If guardarElemento.Items.Contains(_IdTramo.ToString) Then
                    MsgBox("No puede haber dos id Tramo iguales")
                Else

                    Dim tm As Tramo = New Tramo(_IdTramo, _tipoTramo, _longitud, _velocidadMax, _velocidadMin, _velocidadAprox)
                    Try
                        tm.insertar()
                        MsgBox("Tramo insertado correctamente")
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
        txtIDTramo.Text = " "
        txtLongitud.Text = " "
        txtVelocMax.Text = " "
        txtVelocMin.Text = " "
        txtVelocAprox.Text = " "
        comBoxTramo.Text = " "
    End Sub
End Class