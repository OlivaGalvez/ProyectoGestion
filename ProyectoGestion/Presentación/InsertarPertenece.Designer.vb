<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InsertarPertenece
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
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnInsertar = New System.Windows.Forms.Button()
        Me.lblTramos = New System.Windows.Forms.Label()
        Me.lblPertenece = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblRecorridos = New System.Windows.Forms.Label()
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(388, 248)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(80, 24)
        Me.btnVolver.TabIndex = 37
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(242, 248)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(80, 24)
        Me.btnLimpiar.TabIndex = 36
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnInsertar
        '
        Me.btnInsertar.Location = New System.Drawing.Point(115, 248)
        Me.btnInsertar.Name = "btnInsertar"
        Me.btnInsertar.Size = New System.Drawing.Size(80, 24)
        Me.btnInsertar.TabIndex = 35
        Me.btnInsertar.Text = "Insertar"
        Me.btnInsertar.UseVisualStyleBackColor = True
        '
        'lblTramos
        '
        Me.lblTramos.AutoSize = True
        Me.lblTramos.Location = New System.Drawing.Point(415, 29)
        Me.lblTramos.Name = "lblTramos"
        Me.lblTramos.Size = New System.Drawing.Size(53, 13)
        Me.lblTramos.TabIndex = 30
        Me.lblTramos.Text = "TRAMOS"
        '
        'lblPertenece
        '
        Me.lblPertenece.AutoSize = True
        Me.lblPertenece.Location = New System.Drawing.Point(250, 29)
        Me.lblPertenece.Name = "lblPertenece"
        Me.lblPertenece.Size = New System.Drawing.Size(72, 13)
        Me.lblPertenece.TabIndex = 29
        Me.lblPertenece.Text = "PERTENECE"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(229, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 28
        '
        'lblRecorridos
        '
        Me.lblRecorridos.AutoSize = True
        Me.lblRecorridos.Location = New System.Drawing.Point(40, 29)
        Me.lblRecorridos.Name = "lblRecorridos"
        Me.lblRecorridos.Size = New System.Drawing.Size(79, 13)
        Me.lblRecorridos.TabIndex = 27
        Me.lblRecorridos.Text = "RECORRIDOS"
        '
        'ListBox3
        '
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.Location = New System.Drawing.Point(418, 65)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(114, 147)
        Me.ListBox3.TabIndex = 26
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(212, 65)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(114, 147)
        Me.ListBox2.TabIndex = 25
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(16, 65)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(114, 147)
        Me.ListBox1.TabIndex = 24
        '
        'btn4
        '
        Me.btn4.Enabled = False
        Me.btn4.Location = New System.Drawing.Point(348, 163)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(49, 23)
        Me.btn4.TabIndex = 23
        Me.btn4.Text = "> >"
        Me.btn4.UseVisualStyleBackColor = True
        '
        'btn2
        '
        Me.btn2.Location = New System.Drawing.Point(348, 111)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(49, 23)
        Me.btn2.TabIndex = 22
        Me.btn2.Text = "< <"
        Me.btn2.UseVisualStyleBackColor = True
        '
        'btn3
        '
        Me.btn3.Enabled = False
        Me.btn3.Location = New System.Drawing.Point(146, 163)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(49, 23)
        Me.btn3.TabIndex = 21
        Me.btn3.Text = "< <"
        Me.btn3.UseVisualStyleBackColor = True
        '
        'btn1
        '
        Me.btn1.Location = New System.Drawing.Point(146, 111)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(49, 23)
        Me.btn1.TabIndex = 20
        Me.btn1.Text = "> >"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'InsertarPertenece
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(580, 301)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnInsertar)
        Me.Controls.Add(Me.lblTramos)
        Me.Controls.Add(Me.lblPertenece)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblRecorridos)
        Me.Controls.Add(Me.ListBox3)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.btn4)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btn1)
        Me.Name = "InsertarPertenece"
        Me.Text = "InsertarPertenece"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnVolver As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnInsertar As Button
    Friend WithEvents lblTramos As Label
    Friend WithEvents lblPertenece As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblRecorridos As Label
    Friend WithEvents ListBox3 As ListBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents btn4 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btn1 As Button
End Class
