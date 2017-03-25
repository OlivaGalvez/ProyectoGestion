<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuPrincipal
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
        Me.btnInsertarDatos = New System.Windows.Forms.Button()
        Me.btnBorrarDatos = New System.Windows.Forms.Button()
        Me.btnConsultas = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.lblInicio = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnInsertarDatos
        '
        Me.btnInsertarDatos.Location = New System.Drawing.Point(61, 84)
        Me.btnInsertarDatos.Name = "btnInsertarDatos"
        Me.btnInsertarDatos.Size = New System.Drawing.Size(113, 23)
        Me.btnInsertarDatos.TabIndex = 0
        Me.btnInsertarDatos.Text = "Insertar Datos"
        Me.btnInsertarDatos.UseVisualStyleBackColor = True
        '
        'btnBorrarDatos
        '
        Me.btnBorrarDatos.Location = New System.Drawing.Point(61, 126)
        Me.btnBorrarDatos.Name = "btnBorrarDatos"
        Me.btnBorrarDatos.Size = New System.Drawing.Size(113, 23)
        Me.btnBorrarDatos.TabIndex = 1
        Me.btnBorrarDatos.Text = "BorrarDatos"
        Me.btnBorrarDatos.UseVisualStyleBackColor = True
        '
        'btnConsultas
        '
        Me.btnConsultas.Location = New System.Drawing.Point(61, 169)
        Me.btnConsultas.Name = "btnConsultas"
        Me.btnConsultas.Size = New System.Drawing.Size(113, 23)
        Me.btnConsultas.TabIndex = 2
        Me.btnConsultas.Text = "Consultas"
        Me.btnConsultas.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(264, 126)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(113, 23)
        Me.btnSalir.TabIndex = 3
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'lblInicio
        '
        Me.lblInicio.AutoSize = True
        Me.lblInicio.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInicio.Location = New System.Drawing.Point(127, 35)
        Me.lblInicio.Name = "lblInicio"
        Me.lblInicio.Size = New System.Drawing.Size(186, 22)
        Me.lblInicio.TabIndex = 4
        Me.lblInicio.Text = "¿Qué desea hacer?"
        '
        'MenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(427, 219)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblInicio)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnConsultas)
        Me.Controls.Add(Me.btnBorrarDatos)
        Me.Controls.Add(Me.btnInsertarDatos)
        Me.Name = "MenuPrincipal"
        Me.Text = "Menu Principal"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnInsertarDatos As Button
    Friend WithEvents btnBorrarDatos As Button
    Friend WithEvents btnConsultas As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents lblInicio As Label
End Class
