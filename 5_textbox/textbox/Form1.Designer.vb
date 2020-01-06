<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.etiqueta = New System.Windows.Forms.Label()
        Me.texto = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'etiqueta
        '
        Me.etiqueta.AutoSize = True
        Me.etiqueta.Location = New System.Drawing.Point(12, 43)
        Me.etiqueta.Name = "etiqueta"
        Me.etiqueta.Size = New System.Drawing.Size(98, 13)
        Me.etiqueta.TabIndex = 0
        Me.etiqueta.Text = "Introduzca un texto"
        '
        'texto
        '
        Me.texto.Location = New System.Drawing.Point(116, 40)
        Me.texto.Name = "texto"
        Me.texto.Size = New System.Drawing.Size(100, 20)
        Me.texto.TabIndex = 1
        Me.texto.Text = "Hola mundo"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.texto)
        Me.Controls.Add(Me.etiqueta)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents etiqueta As System.Windows.Forms.Label
    Friend WithEvents texto As System.Windows.Forms.TextBox

End Class
