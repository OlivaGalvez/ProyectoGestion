<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class InsertarPasa
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InsertarPasa))
        Me.btn1 = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.lbVehiculos = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbPasa = New System.Windows.Forms.Label()
        Me.lbPuntoControl = New System.Windows.Forms.Label()
        Me.lblVelocidad = New System.Windows.Forms.Label()
        Me.lblMomento = New System.Windows.Forms.Label()
        Me.txtVelocidad = New System.Windows.Forms.TextBox()
        Me.lblKm = New System.Windows.Forms.Label()
        Me.btnInsertar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.txtMomento = New System.Windows.Forms.TextBox()
        Me.btnHabilitar = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.btnAyuda = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn1
        '
        Me.btn1.Enabled = False
        Me.btn1.Location = New System.Drawing.Point(180, 119)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(49, 23)
        Me.btn1.TabIndex = 0
        Me.btn1.Text = "> >"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'btn3
        '
        Me.btn3.Enabled = False
        Me.btn3.Location = New System.Drawing.Point(180, 171)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(49, 23)
        Me.btn3.TabIndex = 1
        Me.btn3.Text = "< <"
        Me.btn3.UseVisualStyleBackColor = True
        '
        'btn2
        '
        Me.btn2.Enabled = False
        Me.btn2.Location = New System.Drawing.Point(382, 119)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(49, 23)
        Me.btn2.TabIndex = 2
        Me.btn2.Text = "< <"
        Me.btn2.UseVisualStyleBackColor = True
        '
        'btn4
        '
        Me.btn4.Enabled = False
        Me.btn4.Location = New System.Drawing.Point(382, 171)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(49, 23)
        Me.btn4.TabIndex = 3
        Me.btn4.Text = "> >"
        Me.btn4.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(50, 73)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(114, 147)
        Me.ListBox1.TabIndex = 4
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(246, 73)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(114, 147)
        Me.ListBox2.TabIndex = 5
        '
        'ListBox3
        '
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.Location = New System.Drawing.Point(452, 73)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(114, 147)
        Me.ListBox3.TabIndex = 6
        '
        'lbVehiculos
        '
        Me.lbVehiculos.AutoSize = True
        Me.lbVehiculos.Location = New System.Drawing.Point(74, 37)
        Me.lbVehiculos.Name = "lbVehiculos"
        Me.lbVehiculos.Size = New System.Drawing.Size(68, 13)
        Me.lbVehiculos.TabIndex = 7
        Me.lbVehiculos.Text = "VEHICULOS"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(263, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 8
        '
        'lbPasa
        '
        Me.lbPasa.AutoSize = True
        Me.lbPasa.Location = New System.Drawing.Point(284, 37)
        Me.lbPasa.Name = "lbPasa"
        Me.lbPasa.Size = New System.Drawing.Size(35, 13)
        Me.lbPasa.TabIndex = 9
        Me.lbPasa.Text = "PASA"
        '
        'lbPuntoControl
        '
        Me.lbPuntoControl.AutoSize = True
        Me.lbPuntoControl.Location = New System.Drawing.Point(449, 37)
        Me.lbPuntoControl.Name = "lbPuntoControl"
        Me.lbPuntoControl.Size = New System.Drawing.Size(118, 13)
        Me.lbPuntoControl.TabIndex = 10
        Me.lbPuntoControl.Text = "PUNTO DE CONTROL"
        '
        'lblVelocidad
        '
        Me.lblVelocidad.AutoSize = True
        Me.lblVelocidad.Location = New System.Drawing.Point(124, 250)
        Me.lblVelocidad.Name = "lblVelocidad"
        Me.lblVelocidad.Size = New System.Drawing.Size(54, 13)
        Me.lblVelocidad.TabIndex = 11
        Me.lblVelocidad.Text = "Velocidad"
        '
        'lblMomento
        '
        Me.lblMomento.AutoSize = True
        Me.lblMomento.Location = New System.Drawing.Point(124, 291)
        Me.lblMomento.Name = "lblMomento"
        Me.lblMomento.Size = New System.Drawing.Size(51, 13)
        Me.lblMomento.TabIndex = 12
        Me.lblMomento.Text = "Momento"
        '
        'txtVelocidad
        '
        Me.txtVelocidad.Location = New System.Drawing.Point(219, 247)
        Me.txtVelocidad.Name = "txtVelocidad"
        Me.txtVelocidad.Size = New System.Drawing.Size(100, 20)
        Me.txtVelocidad.TabIndex = 13
        '
        'lblKm
        '
        Me.lblKm.AutoSize = True
        Me.lblKm.Location = New System.Drawing.Point(334, 254)
        Me.lblKm.Name = "lblKm"
        Me.lblKm.Size = New System.Drawing.Size(32, 13)
        Me.lblKm.TabIndex = 14
        Me.lblKm.Text = "Km/s"
        '
        'btnInsertar
        '
        Me.btnInsertar.Location = New System.Drawing.Point(487, 239)
        Me.btnInsertar.Name = "btnInsertar"
        Me.btnInsertar.Size = New System.Drawing.Size(80, 24)
        Me.btnInsertar.TabIndex = 16
        Me.btnInsertar.Text = "Insertar"
        Me.btnInsertar.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(486, 269)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(80, 24)
        Me.btnLimpiar.TabIndex = 17
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(487, 299)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(80, 24)
        Me.btnVolver.TabIndex = 18
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'txtMomento
        '
        Me.txtMomento.Location = New System.Drawing.Point(219, 288)
        Me.txtMomento.Name = "txtMomento"
        Me.txtMomento.Size = New System.Drawing.Size(100, 20)
        Me.txtMomento.TabIndex = 19
        '
        'btnHabilitar
        '
        Me.btnHabilitar.Location = New System.Drawing.Point(12, 247)
        Me.btnHabilitar.Name = "btnHabilitar"
        Me.btnHabilitar.Size = New System.Drawing.Size(75, 76)
        Me.btnHabilitar.TabIndex = 20
        Me.btnHabilitar.Text = "Habilitar"
        Me.btnHabilitar.UseVisualStyleBackColor = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'btnAyuda
        '
        Me.btnAyuda.Image = CType(resources.GetObject("btnAyuda.Image"), System.Drawing.Image)
        Me.btnAyuda.Location = New System.Drawing.Point(337, 282)
        Me.btnAyuda.Name = "btnAyuda"
        Me.btnAyuda.Size = New System.Drawing.Size(48, 41)
        Me.btnAyuda.TabIndex = 22
        Me.btnAyuda.UseVisualStyleBackColor = True
        '
        'InsertarPasa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(612, 335)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnAyuda)
        Me.Controls.Add(Me.btnHabilitar)
        Me.Controls.Add(Me.txtMomento)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnInsertar)
        Me.Controls.Add(Me.lblKm)
        Me.Controls.Add(Me.txtVelocidad)
        Me.Controls.Add(Me.lblMomento)
        Me.Controls.Add(Me.lblVelocidad)
        Me.Controls.Add(Me.lbPuntoControl)
        Me.Controls.Add(Me.lbPasa)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbVehiculos)
        Me.Controls.Add(Me.ListBox3)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.btn4)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btn1)
        Me.Name = "InsertarPasa"
        Me.Text = "InsertarPasa"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn1 As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents ListBox3 As ListBox
    Friend WithEvents lbVehiculos As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lbPasa As Label
    Friend WithEvents lbPuntoControl As Label
    Friend WithEvents lblVelocidad As Label
    Friend WithEvents lblMomento As Label
    Friend WithEvents txtVelocidad As TextBox
    Friend WithEvents lblKm As Label
    Friend WithEvents btnInsertar As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnVolver As Button
    Friend WithEvents txtMomento As TextBox
    Friend WithEvents btnHabilitar As Button
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents btnAyuda As Button
End Class
