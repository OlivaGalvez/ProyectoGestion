<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InsertarRealiza
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
        Me.txtHoraLlegada = New System.Windows.Forms.TextBox()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnInsertar = New System.Windows.Forms.Button()
        Me.txtHoraSalida = New System.Windows.Forms.TextBox()
        Me.lblHoraLlegada = New System.Windows.Forms.Label()
        Me.lblHoraDeSalida = New System.Windows.Forms.Label()
        Me.lblRecorrido = New System.Windows.Forms.Label()
        Me.lblRealiza = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbVehiculos = New System.Windows.Forms.Label()
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtHoraLlegada
        '
        Me.txtHoraLlegada.Location = New System.Drawing.Point(181, 269)
        Me.txtHoraLlegada.Name = "txtHoraLlegada"
        Me.txtHoraLlegada.Size = New System.Drawing.Size(100, 20)
        Me.txtHoraLlegada.TabIndex = 38
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(449, 280)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(80, 24)
        Me.btnVolver.TabIndex = 37
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(448, 250)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(80, 24)
        Me.btnLimpiar.TabIndex = 36
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnInsertar
        '
        Me.btnInsertar.Location = New System.Drawing.Point(449, 220)
        Me.btnInsertar.Name = "btnInsertar"
        Me.btnInsertar.Size = New System.Drawing.Size(80, 24)
        Me.btnInsertar.TabIndex = 35
        Me.btnInsertar.Text = "Insertar"
        Me.btnInsertar.UseVisualStyleBackColor = True
        '
        'txtHoraSalida
        '
        Me.txtHoraSalida.Location = New System.Drawing.Point(181, 228)
        Me.txtHoraSalida.Name = "txtHoraSalida"
        Me.txtHoraSalida.Size = New System.Drawing.Size(100, 20)
        Me.txtHoraSalida.TabIndex = 33
        '
        'lblHoraLlegada
        '
        Me.lblHoraLlegada.AutoSize = True
        Me.lblHoraLlegada.Location = New System.Drawing.Point(77, 276)
        Me.lblHoraLlegada.Name = "lblHoraLlegada"
        Me.lblHoraLlegada.Size = New System.Drawing.Size(86, 13)
        Me.lblHoraLlegada.TabIndex = 32
        Me.lblHoraLlegada.Text = "Hora de Llegada"
        '
        'lblHoraDeSalida
        '
        Me.lblHoraDeSalida.AutoSize = True
        Me.lblHoraDeSalida.Location = New System.Drawing.Point(86, 231)
        Me.lblHoraDeSalida.Name = "lblHoraDeSalida"
        Me.lblHoraDeSalida.Size = New System.Drawing.Size(77, 13)
        Me.lblHoraDeSalida.TabIndex = 31
        Me.lblHoraDeSalida.Text = "Hora de Salida"
        '
        'lblRecorrido
        '
        Me.lblRecorrido.AutoSize = True
        Me.lblRecorrido.Location = New System.Drawing.Point(431, 18)
        Me.lblRecorrido.Name = "lblRecorrido"
        Me.lblRecorrido.Size = New System.Drawing.Size(72, 13)
        Me.lblRecorrido.TabIndex = 30
        Me.lblRecorrido.Text = "RECORRIDO"
        '
        'lblRealiza
        '
        Me.lblRealiza.AutoSize = True
        Me.lblRealiza.Location = New System.Drawing.Point(231, 18)
        Me.lblRealiza.Name = "lblRealiza"
        Me.lblRealiza.Size = New System.Drawing.Size(52, 13)
        Me.lblRealiza.TabIndex = 29
        Me.lblRealiza.Text = "REALIZA"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(225, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 28
        '
        'lbVehiculos
        '
        Me.lbVehiculos.AutoSize = True
        Me.lbVehiculos.Location = New System.Drawing.Point(36, 18)
        Me.lbVehiculos.Name = "lbVehiculos"
        Me.lbVehiculos.Size = New System.Drawing.Size(68, 13)
        Me.lbVehiculos.TabIndex = 27
        Me.lbVehiculos.Text = "VEHICULOS"
        '
        'ListBox3
        '
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.Location = New System.Drawing.Point(414, 54)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(114, 147)
        Me.ListBox3.TabIndex = 26
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(208, 54)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(114, 147)
        Me.ListBox2.TabIndex = 25
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(12, 54)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(114, 147)
        Me.ListBox1.TabIndex = 24
        '
        'btn4
        '
        Me.btn4.Enabled = False
        Me.btn4.Location = New System.Drawing.Point(344, 152)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(49, 23)
        Me.btn4.TabIndex = 23
        Me.btn4.Text = "> >"
        Me.btn4.UseVisualStyleBackColor = True
        '
        'btn2
        '
        Me.btn2.Location = New System.Drawing.Point(344, 100)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(49, 23)
        Me.btn2.TabIndex = 22
        Me.btn2.Text = "< <"
        Me.btn2.UseVisualStyleBackColor = True
        '
        'btn3
        '
        Me.btn3.Enabled = False
        Me.btn3.Location = New System.Drawing.Point(142, 152)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(49, 23)
        Me.btn3.TabIndex = 21
        Me.btn3.Text = "< <"
        Me.btn3.UseVisualStyleBackColor = True
        '
        'btn1
        '
        Me.btn1.Location = New System.Drawing.Point(142, 100)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(49, 23)
        Me.btn1.TabIndex = 20
        Me.btn1.Text = "> >"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'InsertarRealiza
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(586, 327)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtHoraLlegada)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnInsertar)
        Me.Controls.Add(Me.txtHoraSalida)
        Me.Controls.Add(Me.lblHoraLlegada)
        Me.Controls.Add(Me.lblHoraDeSalida)
        Me.Controls.Add(Me.lblRecorrido)
        Me.Controls.Add(Me.lblRealiza)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbVehiculos)
        Me.Controls.Add(Me.ListBox3)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.btn4)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btn1)
        Me.Name = "InsertarRealiza"
        Me.Text = "InsertarRealiza"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtHoraLlegada As TextBox
    Friend WithEvents btnVolver As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnInsertar As Button
    Friend WithEvents txtHoraSalida As TextBox
    Friend WithEvents lblHoraLlegada As Label
    Friend WithEvents lblHoraDeSalida As Label
    Friend WithEvents lblRecorrido As Label
    Friend WithEvents lblRealiza As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lbVehiculos As Label
    Friend WithEvents ListBox3 As ListBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents btn4 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btn1 As Button
End Class
