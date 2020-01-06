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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radioSumar = New System.Windows.Forms.RadioButton()
        Me.radioRestar = New System.Windows.Forms.RadioButton()
        Me.radioMultiplicar = New System.Windows.Forms.RadioButton()
        Me.radioDividir = New System.Windows.Forms.RadioButton()
        Me.txtNum1 = New System.Windows.Forms.TextBox()
        Me.txtNum2 = New System.Windows.Forms.TextBox()
        Me.btnEjecutar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnEjecutar)
        Me.GroupBox1.Controls.Add(Me.txtNum2)
        Me.GroupBox1.Controls.Add(Me.txtNum1)
        Me.GroupBox1.Controls.Add(Me.radioDividir)
        Me.GroupBox1.Controls.Add(Me.radioMultiplicar)
        Me.GroupBox1.Controls.Add(Me.radioRestar)
        Me.GroupBox1.Controls.Add(Me.radioSumar)
        Me.GroupBox1.Location = New System.Drawing.Point(44, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 149)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Operaciones"
        '
        'radioSumar
        '
        Me.radioSumar.AutoSize = True
        Me.radioSumar.Location = New System.Drawing.Point(6, 58)
        Me.radioSumar.Name = "radioSumar"
        Me.radioSumar.Size = New System.Drawing.Size(55, 17)
        Me.radioSumar.TabIndex = 0
        Me.radioSumar.TabStop = True
        Me.radioSumar.Text = "Sumar"
        Me.radioSumar.UseVisualStyleBackColor = True
        '
        'radioRestar
        '
        Me.radioRestar.AutoSize = True
        Me.radioRestar.Location = New System.Drawing.Point(6, 82)
        Me.radioRestar.Name = "radioRestar"
        Me.radioRestar.Size = New System.Drawing.Size(56, 17)
        Me.radioRestar.TabIndex = 1
        Me.radioRestar.TabStop = True
        Me.radioRestar.Text = "Restar"
        Me.radioRestar.UseVisualStyleBackColor = True
        '
        'radioMultiplicar
        '
        Me.radioMultiplicar.AutoSize = True
        Me.radioMultiplicar.Location = New System.Drawing.Point(6, 106)
        Me.radioMultiplicar.Name = "radioMultiplicar"
        Me.radioMultiplicar.Size = New System.Drawing.Size(72, 17)
        Me.radioMultiplicar.TabIndex = 2
        Me.radioMultiplicar.TabStop = True
        Me.radioMultiplicar.Text = "Multiplicar"
        Me.radioMultiplicar.UseVisualStyleBackColor = True
        '
        'radioDividir
        '
        Me.radioDividir.AutoSize = True
        Me.radioDividir.Location = New System.Drawing.Point(6, 130)
        Me.radioDividir.Name = "radioDividir"
        Me.radioDividir.Size = New System.Drawing.Size(54, 17)
        Me.radioDividir.TabIndex = 3
        Me.radioDividir.TabStop = True
        Me.radioDividir.Text = "Dividir"
        Me.radioDividir.UseVisualStyleBackColor = True
        '
        'txtNum1
        '
        Me.txtNum1.Location = New System.Drawing.Point(6, 32)
        Me.txtNum1.Name = "txtNum1"
        Me.txtNum1.Size = New System.Drawing.Size(87, 20)
        Me.txtNum1.TabIndex = 4
        '
        'txtNum2
        '
        Me.txtNum2.Location = New System.Drawing.Point(100, 32)
        Me.txtNum2.Name = "txtNum2"
        Me.txtNum2.Size = New System.Drawing.Size(94, 20)
        Me.txtNum2.TabIndex = 5
        '
        'btnEjecutar
        '
        Me.btnEjecutar.Location = New System.Drawing.Point(100, 82)
        Me.btnEjecutar.Name = "btnEjecutar"
        Me.btnEjecutar.Size = New System.Drawing.Size(75, 23)
        Me.btnEjecutar.TabIndex = 6
        Me.btnEjecutar.Text = "Ejecutar"
        Me.btnEjecutar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnEjecutar As System.Windows.Forms.Button
    Friend WithEvents txtNum2 As System.Windows.Forms.TextBox
    Friend WithEvents txtNum1 As System.Windows.Forms.TextBox
    Friend WithEvents radioDividir As System.Windows.Forms.RadioButton
    Friend WithEvents radioMultiplicar As System.Windows.Forms.RadioButton
    Friend WithEvents radioRestar As System.Windows.Forms.RadioButton
    Friend WithEvents radioSumar As System.Windows.Forms.RadioButton

End Class
