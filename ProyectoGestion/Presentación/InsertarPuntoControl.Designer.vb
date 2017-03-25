<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InsertarPuntoControl
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnInsertar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.idPuntoControl = New System.Windows.Forms.Label()
        Me.idTramo = New System.Windows.Forms.Label()
        Me.txtIDPunto = New System.Windows.Forms.TextBox()
        Me.txtTramo = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnInsertar
        '
        Me.btnInsertar.Location = New System.Drawing.Point(320, 32)
        Me.btnInsertar.Name = "btnInsertar"
        Me.btnInsertar.Size = New System.Drawing.Size(123, 30)
        Me.btnInsertar.TabIndex = 0
        Me.btnInsertar.Text = "INSERTAR"
        Me.btnInsertar.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(320, 87)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(123, 30)
        Me.btnLimpiar.TabIndex = 1
        Me.btnLimpiar.Text = "LIMPIAR"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(320, 140)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(123, 29)
        Me.btnVolver.TabIndex = 2
        Me.btnVolver.Text = "VOLVER"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'idPuntoControl
        '
        Me.idPuntoControl.AutoSize = True
        Me.idPuntoControl.Location = New System.Drawing.Point(25, 49)
        Me.idPuntoControl.Name = "idPuntoControl"
        Me.idPuntoControl.Size = New System.Drawing.Size(98, 13)
        Me.idPuntoControl.TabIndex = 3
        Me.idPuntoControl.Text = "Id Punto de Control"
        '
        'idTramo
        '
        Me.idTramo.AutoSize = True
        Me.idTramo.Location = New System.Drawing.Point(25, 104)
        Me.idTramo.Name = "idTramo"
        Me.idTramo.Size = New System.Drawing.Size(60, 13)
        Me.idTramo.TabIndex = 4
        Me.idTramo.Text = "Id de tramo"
        '
        'txtIDPunto
        '
        Me.txtIDPunto.Location = New System.Drawing.Point(160, 42)
        Me.txtIDPunto.Name = "txtIDPunto"
        Me.txtIDPunto.Size = New System.Drawing.Size(100, 20)
        Me.txtIDPunto.TabIndex = 5
        '
        'txtTramo
        '
        Me.txtTramo.Location = New System.Drawing.Point(160, 97)
        Me.txtTramo.Name = "txtTramo"
        Me.txtTramo.Size = New System.Drawing.Size(100, 20)
        Me.txtTramo.TabIndex = 6
        '
        'InsertarPuntoControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(482, 200)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtTramo)
        Me.Controls.Add(Me.txtIDPunto)
        Me.Controls.Add(Me.idTramo)
        Me.Controls.Add(Me.idPuntoControl)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnInsertar)
        Me.Name = "InsertarPuntoControl"
        Me.Text = "InsertarPuntoControl"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnInsertar As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnVolver As Button
    Friend WithEvents idPuntoControl As Label
    Friend WithEvents idTramo As Label
    Friend WithEvents txtIDPunto As TextBox
    Friend WithEvents txtTramo As TextBox
End Class
