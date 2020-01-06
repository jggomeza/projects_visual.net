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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtResul = New System.Windows.Forms.TextBox()
        Me.radioDividir = New System.Windows.Forms.RadioButton()
        Me.radioMultiplicar = New System.Windows.Forms.RadioButton()
        Me.radioRestar = New System.Windows.Forms.RadioButton()
        Me.radioSumar = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNum2 = New System.Windows.Forms.TextBox()
        Me.txtNum1 = New System.Windows.Forms.TextBox()
        Me.btnEjecutar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtResul)
        Me.GroupBox1.Controls.Add(Me.radioDividir)
        Me.GroupBox1.Controls.Add(Me.radioMultiplicar)
        Me.GroupBox1.Controls.Add(Me.radioRestar)
        Me.GroupBox1.Controls.Add(Me.radioSumar)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtNum2)
        Me.GroupBox1.Controls.Add(Me.txtNum1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(259, 164)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(119, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Resultado de la operación:"
        '
        'txtResul
        '
        Me.txtResul.Location = New System.Drawing.Point(119, 130)
        Me.txtResul.Name = "txtResul"
        Me.txtResul.ReadOnly = True
        Me.txtResul.Size = New System.Drawing.Size(129, 20)
        Me.txtResul.TabIndex = 8
        '
        'radioDividir
        '
        Me.radioDividir.AutoSize = True
        Me.radioDividir.Location = New System.Drawing.Point(23, 136)
        Me.radioDividir.Name = "radioDividir"
        Me.radioDividir.Size = New System.Drawing.Size(54, 17)
        Me.radioDividir.TabIndex = 7
        Me.radioDividir.TabStop = True
        Me.radioDividir.Text = "Dividir"
        Me.radioDividir.UseVisualStyleBackColor = True
        '
        'radioMultiplicar
        '
        Me.radioMultiplicar.AutoSize = True
        Me.radioMultiplicar.Location = New System.Drawing.Point(23, 112)
        Me.radioMultiplicar.Name = "radioMultiplicar"
        Me.radioMultiplicar.Size = New System.Drawing.Size(72, 17)
        Me.radioMultiplicar.TabIndex = 6
        Me.radioMultiplicar.TabStop = True
        Me.radioMultiplicar.Text = "Multiplicar"
        Me.radioMultiplicar.UseVisualStyleBackColor = True
        '
        'radioRestar
        '
        Me.radioRestar.AutoSize = True
        Me.radioRestar.Location = New System.Drawing.Point(23, 88)
        Me.radioRestar.Name = "radioRestar"
        Me.radioRestar.Size = New System.Drawing.Size(56, 17)
        Me.radioRestar.TabIndex = 5
        Me.radioRestar.TabStop = True
        Me.radioRestar.Text = "Restar"
        Me.radioRestar.UseVisualStyleBackColor = True
        '
        'radioSumar
        '
        Me.radioSumar.AutoSize = True
        Me.radioSumar.Location = New System.Drawing.Point(23, 64)
        Me.radioSumar.Name = "radioSumar"
        Me.radioSumar.Size = New System.Drawing.Size(55, 17)
        Me.radioSumar.TabIndex = 4
        Me.radioSumar.TabStop = True
        Me.radioSumar.Text = "Sumar"
        Me.radioSumar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(176, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Número 2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(42, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Número 1"
        '
        'txtNum2
        '
        Me.txtNum2.Location = New System.Drawing.Point(148, 37)
        Me.txtNum2.Name = "txtNum2"
        Me.txtNum2.Size = New System.Drawing.Size(100, 20)
        Me.txtNum2.TabIndex = 1
        '
        'txtNum1
        '
        Me.txtNum1.Location = New System.Drawing.Point(23, 37)
        Me.txtNum1.Name = "txtNum1"
        Me.txtNum1.Size = New System.Drawing.Size(100, 20)
        Me.txtNum1.TabIndex = 0
        '
        'btnEjecutar
        '
        Me.btnEjecutar.Location = New System.Drawing.Point(84, 182)
        Me.btnEjecutar.Name = "btnEjecutar"
        Me.btnEjecutar.Size = New System.Drawing.Size(105, 23)
        Me.btnEjecutar.TabIndex = 1
        Me.btnEjecutar.Text = "Ejecutar operación"
        Me.btnEjecutar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btnEjecutar)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtResul As System.Windows.Forms.TextBox
    Friend WithEvents radioDividir As System.Windows.Forms.RadioButton
    Friend WithEvents radioMultiplicar As System.Windows.Forms.RadioButton
    Friend WithEvents radioRestar As System.Windows.Forms.RadioButton
    Friend WithEvents radioSumar As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNum2 As System.Windows.Forms.TextBox
    Friend WithEvents txtNum1 As System.Windows.Forms.TextBox
    Friend WithEvents btnEjecutar As System.Windows.Forms.Button

End Class
