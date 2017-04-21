<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InsertarTramo
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
        Me.lbIdTramo = New System.Windows.Forms.Label()
        Me.lbTipoTramo = New System.Windows.Forms.Label()
        Me.lbLongitud = New System.Windows.Forms.Label()
        Me.lbVelocidadMax = New System.Windows.Forms.Label()
        Me.lbVelocidadMin = New System.Windows.Forms.Label()
        Me.lblVelocidadAprx = New System.Windows.Forms.Label()
        Me.txtIDTramo = New System.Windows.Forms.TextBox()
        Me.txtLongitud = New System.Windows.Forms.TextBox()
        Me.txtVelocMax = New System.Windows.Forms.TextBox()
        Me.txtVelocMin = New System.Windows.Forms.TextBox()
        Me.txtVelocAprox = New System.Windows.Forms.TextBox()
        Me.comBoxTramo = New System.Windows.Forms.ComboBox()
        Me.btnInsertar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbIdTramo
        '
        Me.lbIdTramo.AutoSize = True
        Me.lbIdTramo.Location = New System.Drawing.Point(78, 26)
        Me.lbIdTramo.Name = "lbIdTramo"
        Me.lbIdTramo.Size = New System.Drawing.Size(51, 13)
        Me.lbIdTramo.TabIndex = 0
        Me.lbIdTramo.Text = "ID Tramo"
        '
        'lbTipoTramo
        '
        Me.lbTipoTramo.AutoSize = True
        Me.lbTipoTramo.Location = New System.Drawing.Point(68, 66)
        Me.lbTipoTramo.Name = "lbTipoTramo"
        Me.lbTipoTramo.Size = New System.Drawing.Size(61, 13)
        Me.lbTipoTramo.TabIndex = 1
        Me.lbTipoTramo.Text = "Tipo Tramo"
        '
        'lbLongitud
        '
        Me.lbLongitud.AutoSize = True
        Me.lbLongitud.Location = New System.Drawing.Point(81, 104)
        Me.lbLongitud.Name = "lbLongitud"
        Me.lbLongitud.Size = New System.Drawing.Size(48, 13)
        Me.lbLongitud.TabIndex = 2
        Me.lbLongitud.Text = "Longitud"
        '
        'lbVelocidadMax
        '
        Me.lbVelocidadMax.AutoSize = True
        Me.lbVelocidadMax.Location = New System.Drawing.Point(36, 139)
        Me.lbVelocidadMax.Name = "lbVelocidadMax"
        Me.lbVelocidadMax.Size = New System.Drawing.Size(93, 13)
        Me.lbVelocidadMax.TabIndex = 3
        Me.lbVelocidadMax.Text = "Velocidad Máxima"
        '
        'lbVelocidadMin
        '
        Me.lbVelocidadMin.AutoSize = True
        Me.lbVelocidadMin.Location = New System.Drawing.Point(37, 178)
        Me.lbVelocidadMin.Name = "lbVelocidadMin"
        Me.lbVelocidadMin.Size = New System.Drawing.Size(92, 13)
        Me.lbVelocidadMin.TabIndex = 4
        Me.lbVelocidadMin.Text = "Velocidad Mínima"
        '
        'lblVelocidadAprx
        '
        Me.lblVelocidadAprx.AutoSize = True
        Me.lblVelocidadAprx.Location = New System.Drawing.Point(17, 213)
        Me.lblVelocidadAprx.Name = "lblVelocidadAprx"
        Me.lblVelocidadAprx.Size = New System.Drawing.Size(112, 13)
        Me.lblVelocidadAprx.TabIndex = 5
        Me.lblVelocidadAprx.Text = "Velocidad Aproximada"
        '
        'txtIDTramo
        '
        Me.txtIDTramo.Location = New System.Drawing.Point(173, 19)
        Me.txtIDTramo.Name = "txtIDTramo"
        Me.txtIDTramo.Size = New System.Drawing.Size(113, 20)
        Me.txtIDTramo.TabIndex = 6
        '
        'txtLongitud
        '
        Me.txtLongitud.Location = New System.Drawing.Point(173, 97)
        Me.txtLongitud.Name = "txtLongitud"
        Me.txtLongitud.Size = New System.Drawing.Size(113, 20)
        Me.txtLongitud.TabIndex = 7
        '
        'txtVelocMax
        '
        Me.txtVelocMax.Location = New System.Drawing.Point(173, 132)
        Me.txtVelocMax.Name = "txtVelocMax"
        Me.txtVelocMax.Size = New System.Drawing.Size(113, 20)
        Me.txtVelocMax.TabIndex = 8
        '
        'txtVelocMin
        '
        Me.txtVelocMin.Location = New System.Drawing.Point(173, 171)
        Me.txtVelocMin.Name = "txtVelocMin"
        Me.txtVelocMin.Size = New System.Drawing.Size(113, 20)
        Me.txtVelocMin.TabIndex = 9
        '
        'txtVelocAprox
        '
        Me.txtVelocAprox.Location = New System.Drawing.Point(173, 210)
        Me.txtVelocAprox.Name = "txtVelocAprox"
        Me.txtVelocAprox.Size = New System.Drawing.Size(113, 20)
        Me.txtVelocAprox.TabIndex = 10
        '
        'comBoxTramo
        '
        Me.comBoxTramo.FormattingEnabled = True
        Me.comBoxTramo.Items.AddRange(New Object() {"CURVA" & Global.Microsoft.VisualBasic.ChrW(9), "POBLADO", "RECTA"})
        Me.comBoxTramo.Location = New System.Drawing.Point(173, 60)
        Me.comBoxTramo.Name = "comBoxTramo"
        Me.comBoxTramo.Size = New System.Drawing.Size(112, 21)
        Me.comBoxTramo.TabIndex = 11
        '
        'btnInsertar
        '
        Me.btnInsertar.Location = New System.Drawing.Point(329, 50)
        Me.btnInsertar.Name = "btnInsertar"
        Me.btnInsertar.Size = New System.Drawing.Size(95, 30)
        Me.btnInsertar.TabIndex = 12
        Me.btnInsertar.Text = "Insertar"
        Me.btnInsertar.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(329, 122)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(95, 30)
        Me.btnLimpiar.TabIndex = 13
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(329, 200)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(95, 30)
        Me.btnVolver.TabIndex = 14
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'InsertarTramo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(441, 260)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnInsertar)
        Me.Controls.Add(Me.comBoxTramo)
        Me.Controls.Add(Me.txtVelocAprox)
        Me.Controls.Add(Me.txtVelocMin)
        Me.Controls.Add(Me.txtVelocMax)
        Me.Controls.Add(Me.txtLongitud)
        Me.Controls.Add(Me.txtIDTramo)
        Me.Controls.Add(Me.lblVelocidadAprx)
        Me.Controls.Add(Me.lbVelocidadMin)
        Me.Controls.Add(Me.lbVelocidadMax)
        Me.Controls.Add(Me.lbLongitud)
        Me.Controls.Add(Me.lbTipoTramo)
        Me.Controls.Add(Me.lbIdTramo)
        Me.Name = "InsertarTramo"
        Me.Text = "InsertarTramo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbIdTramo As Label
    Friend WithEvents lbTipoTramo As Label
    Friend WithEvents lbLongitud As Label
    Friend WithEvents lbVelocidadMax As Label
    Friend WithEvents lbVelocidadMin As Label
    Friend WithEvents lblVelocidadAprx As Label
    Friend WithEvents txtIDTramo As TextBox
    Friend WithEvents txtLongitud As TextBox
    Friend WithEvents txtVelocMax As TextBox
    Friend WithEvents txtVelocMin As TextBox
    Friend WithEvents txtVelocAprox As TextBox
    Friend WithEvents comBoxTramo As ComboBox
    Friend WithEvents btnInsertar As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnVolver As Button
End Class
