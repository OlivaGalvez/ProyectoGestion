<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InsertarVehiculo
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
        Me.lblMatricula = New System.Windows.Forms.Label()
        Me.lblColor = New System.Windows.Forms.Label()
        Me.lblModelo = New System.Windows.Forms.Label()
        Me.txtMatricula = New System.Windows.Forms.TextBox()
        Me.txtColor = New System.Windows.Forms.TextBox()
        Me.txtModelo = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnInsertar
        '
        Me.btnInsertar.Location = New System.Drawing.Point(293, 47)
        Me.btnInsertar.Name = "btnInsertar"
        Me.btnInsertar.Size = New System.Drawing.Size(101, 23)
        Me.btnInsertar.TabIndex = 0
        Me.btnInsertar.Text = "INSERTAR"
        Me.btnInsertar.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(293, 102)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(101, 23)
        Me.btnLimpiar.TabIndex = 1
        Me.btnLimpiar.Text = "LIMPIAR"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(293, 169)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(101, 23)
        Me.btnVolver.TabIndex = 2
        Me.btnVolver.Text = "VOLVER"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'lblMatricula
        '
        Me.lblMatricula.AutoSize = True
        Me.lblMatricula.Location = New System.Drawing.Point(37, 54)
        Me.lblMatricula.Name = "lblMatricula"
        Me.lblMatricula.Size = New System.Drawing.Size(52, 13)
        Me.lblMatricula.TabIndex = 3
        Me.lblMatricula.Text = "Matrícula"
        '
        'lblColor
        '
        Me.lblColor.AutoSize = True
        Me.lblColor.Location = New System.Drawing.Point(37, 111)
        Me.lblColor.Name = "lblColor"
        Me.lblColor.Size = New System.Drawing.Size(31, 13)
        Me.lblColor.TabIndex = 4
        Me.lblColor.Text = "Color"
        '
        'lblModelo
        '
        Me.lblModelo.AutoSize = True
        Me.lblModelo.Location = New System.Drawing.Point(37, 174)
        Me.lblModelo.Name = "lblModelo"
        Me.lblModelo.Size = New System.Drawing.Size(42, 13)
        Me.lblModelo.TabIndex = 5
        Me.lblModelo.Text = "Modelo"
        '
        'txtMatricula
        '
        Me.txtMatricula.Location = New System.Drawing.Point(124, 47)
        Me.txtMatricula.Name = "txtMatricula"
        Me.txtMatricula.Size = New System.Drawing.Size(111, 20)
        Me.txtMatricula.TabIndex = 6
        '
        'txtColor
        '
        Me.txtColor.Location = New System.Drawing.Point(124, 104)
        Me.txtColor.Name = "txtColor"
        Me.txtColor.Size = New System.Drawing.Size(111, 20)
        Me.txtColor.TabIndex = 7
        '
        'txtModelo
        '
        Me.txtModelo.Location = New System.Drawing.Point(124, 169)
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.Size = New System.Drawing.Size(111, 20)
        Me.txtModelo.TabIndex = 8
        '
        'InsertarVehiculo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(446, 214)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtModelo)
        Me.Controls.Add(Me.txtColor)
        Me.Controls.Add(Me.txtMatricula)
        Me.Controls.Add(Me.lblModelo)
        Me.Controls.Add(Me.lblColor)
        Me.Controls.Add(Me.lblMatricula)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnInsertar)
        Me.Name = "InsertarVehiculo"
        Me.Text = "Insertar Vehiculo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnInsertar As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnVolver As Button
    Friend WithEvents lblMatricula As Label
    Friend WithEvents lblColor As Label
    Friend WithEvents lblModelo As Label
    Friend WithEvents txtMatricula As TextBox
    Friend WithEvents txtColor As TextBox
    Friend WithEvents txtModelo As TextBox
End Class
