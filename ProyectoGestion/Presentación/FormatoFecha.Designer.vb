<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormatoFecha
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormatoFecha))
        Me.lblFormato = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblImagen = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblFormato
        '
        Me.lblFormato.AutoSize = True
        Me.lblFormato.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormato.Location = New System.Drawing.Point(72, 19)
        Me.lblFormato.Name = "lblFormato"
        Me.lblFormato.Size = New System.Drawing.Size(223, 24)
        Me.lblFormato.TabIndex = 0
        Me.lblFormato.Text = "Ayuda: Formato Fecha"
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.Location = New System.Drawing.Point(144, 64)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(75, 20)
        Me.lblFecha.TabIndex = 1
        Me.lblFecha.Text = "dd/mm/yy"
        '
        'lblImagen
        '
        Me.lblImagen.AutoSize = True
        Me.lblImagen.Image = CType(resources.GetObject("lblImagen.Image"), System.Drawing.Image)
        Me.lblImagen.Location = New System.Drawing.Point(0, 0)
        Me.lblImagen.Name = "lblImagen"
        Me.lblImagen.Size = New System.Drawing.Size(0, 13)
        Me.lblImagen.TabIndex = 2
        '
        'FormatoFecha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(387, 106)
        Me.Controls.Add(Me.lblImagen)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.lblFormato)
        Me.Name = "FormatoFecha"
        Me.Text = "FormatoFecha"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFormato As Label
    Friend WithEvents lblFecha As Label
    Friend WithEvents lblImagen As Label
End Class
