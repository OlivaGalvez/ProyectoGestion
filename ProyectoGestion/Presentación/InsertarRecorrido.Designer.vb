<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InsertarRecorrido
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
        Me.lbIdRecorrido = New System.Windows.Forms.Label()
        Me.txtRecorrido = New System.Windows.Forms.TextBox()
        Me.btnInsertar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbIdRecorrido
        '
        Me.lbIdRecorrido.AutoSize = True
        Me.lbIdRecorrido.Location = New System.Drawing.Point(34, 94)
        Me.lbIdRecorrido.Name = "lbIdRecorrido"
        Me.lbIdRecorrido.Size = New System.Drawing.Size(67, 13)
        Me.lbIdRecorrido.TabIndex = 0
        Me.lbIdRecorrido.Text = "ID Recorrido"
        '
        'txtRecorrido
        '
        Me.txtRecorrido.Location = New System.Drawing.Point(131, 87)
        Me.txtRecorrido.Name = "txtRecorrido"
        Me.txtRecorrido.Size = New System.Drawing.Size(100, 20)
        Me.txtRecorrido.TabIndex = 1
        '
        'btnInsertar
        '
        Me.btnInsertar.Location = New System.Drawing.Point(279, 12)
        Me.btnInsertar.Name = "btnInsertar"
        Me.btnInsertar.Size = New System.Drawing.Size(88, 38)
        Me.btnInsertar.TabIndex = 2
        Me.btnInsertar.Text = "Insertar"
        Me.btnInsertar.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(279, 66)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(88, 41)
        Me.btnLimpiar.TabIndex = 3
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(279, 128)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(88, 36)
        Me.btnVolver.TabIndex = 4
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'InsertarRecorrido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(394, 196)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnInsertar)
        Me.Controls.Add(Me.txtRecorrido)
        Me.Controls.Add(Me.lbIdRecorrido)
        Me.Name = "InsertarRecorrido"
        Me.Text = "InsertarRecorrido"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbIdRecorrido As Label
    Friend WithEvents txtRecorrido As TextBox
    Friend WithEvents btnInsertar As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnVolver As Button
End Class
