<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Aplicación
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnRutaBD = New System.Windows.Forms.Button()
        Me.textRuta = New System.Windows.Forms.TextBox()
        Me.btnConectarBD = New System.Windows.Forms.Button()
        Me.lblConectar = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnEntrar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnRutaBD
        '
        Me.btnRutaBD.Location = New System.Drawing.Point(25, 63)
        Me.btnRutaBD.Name = "btnRutaBD"
        Me.btnRutaBD.Size = New System.Drawing.Size(109, 25)
        Me.btnRutaBD.TabIndex = 10
        Me.btnRutaBD.Text = "Ruta "
        Me.btnRutaBD.UseVisualStyleBackColor = True
        '
        'textRuta
        '
        Me.textRuta.Enabled = False
        Me.textRuta.Location = New System.Drawing.Point(159, 42)
        Me.textRuta.Multiline = True
        Me.textRuta.Name = "textRuta"
        Me.textRuta.Size = New System.Drawing.Size(288, 46)
        Me.textRuta.TabIndex = 13
        '
        'btnConectarBD
        '
        Me.btnConectarBD.Enabled = False
        Me.btnConectarBD.Location = New System.Drawing.Point(25, 150)
        Me.btnConectarBD.Name = "btnConectarBD"
        Me.btnConectarBD.Size = New System.Drawing.Size(109, 25)
        Me.btnConectarBD.TabIndex = 14
        Me.btnConectarBD.Text = "Conectar "
        Me.btnConectarBD.UseVisualStyleBackColor = True
        '
        'lblConectar
        '
        Me.lblConectar.AutoSize = True
        Me.lblConectar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConectar.ForeColor = System.Drawing.Color.Red
        Me.lblConectar.Location = New System.Drawing.Point(156, 158)
        Me.lblConectar.Name = "lblConectar"
        Me.lblConectar.Size = New System.Drawing.Size(103, 17)
        Me.lblConectar.TabIndex = 15
        Me.lblConectar.Text = "Desconectado."
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(283, 154)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(74, 25)
        Me.btnSalir.TabIndex = 16
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnEntrar
        '
        Me.btnEntrar.Enabled = False
        Me.btnEntrar.Location = New System.Drawing.Point(373, 154)
        Me.btnEntrar.Name = "btnEntrar"
        Me.btnEntrar.Size = New System.Drawing.Size(74, 25)
        Me.btnEntrar.TabIndex = 17
        Me.btnEntrar.Text = "Entrar"
        Me.btnEntrar.UseVisualStyleBackColor = True
        '
        'Aplicación
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(465, 196)
        Me.Controls.Add(Me.btnEntrar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.lblConectar)
        Me.Controls.Add(Me.btnConectarBD)
        Me.Controls.Add(Me.textRuta)
        Me.Controls.Add(Me.btnRutaBD)
        Me.Name = "Aplicación"
        Me.Text = "Menú de Conexión"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnRutaBD As Button
    Friend WithEvents textRuta As TextBox
    Friend WithEvents btnConectarBD As Button
    Friend WithEvents lblConectar As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnEntrar As Button
End Class
