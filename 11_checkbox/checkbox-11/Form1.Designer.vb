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
        Me.lblPregunta = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.checkOtros = New System.Windows.Forms.CheckBox()
        Me.checkReggaeton = New System.Windows.Forms.CheckBox()
        Me.checkClasica = New System.Windows.Forms.CheckBox()
        Me.checkPop = New System.Windows.Forms.CheckBox()
        Me.checkRock = New System.Windows.Forms.CheckBox()
        Me.btnEnviar = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblPregunta
        '
        Me.lblPregunta.AutoSize = True
        Me.lblPregunta.Location = New System.Drawing.Point(13, 13)
        Me.lblPregunta.Name = "lblPregunta"
        Me.lblPregunta.Size = New System.Drawing.Size(161, 13)
        Me.lblPregunta.TabIndex = 4
        Me.lblPregunta.Text = "Qué género de musica te gusta?"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ListBox1)
        Me.GroupBox1.Controls.Add(Me.checkOtros)
        Me.GroupBox1.Controls.Add(Me.checkReggaeton)
        Me.GroupBox1.Controls.Add(Me.checkClasica)
        Me.GroupBox1.Controls.Add(Me.checkPop)
        Me.GroupBox1.Controls.Add(Me.checkRock)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 48)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(256, 154)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleccione una opción"
        '
        'checkOtros
        '
        Me.checkOtros.AutoSize = True
        Me.checkOtros.Location = New System.Drawing.Point(6, 115)
        Me.checkOtros.Name = "checkOtros"
        Me.checkOtros.Size = New System.Drawing.Size(51, 17)
        Me.checkOtros.TabIndex = 10
        Me.checkOtros.Text = "Otros"
        Me.checkOtros.UseVisualStyleBackColor = True
        '
        'checkReggaeton
        '
        Me.checkReggaeton.AutoSize = True
        Me.checkReggaeton.Location = New System.Drawing.Point(6, 91)
        Me.checkReggaeton.Name = "checkReggaeton"
        Me.checkReggaeton.Size = New System.Drawing.Size(79, 17)
        Me.checkReggaeton.TabIndex = 9
        Me.checkReggaeton.Text = "Reggaeton"
        Me.checkReggaeton.UseVisualStyleBackColor = True
        '
        'checkClasica
        '
        Me.checkClasica.AutoSize = True
        Me.checkClasica.Location = New System.Drawing.Point(6, 67)
        Me.checkClasica.Name = "checkClasica"
        Me.checkClasica.Size = New System.Drawing.Size(60, 17)
        Me.checkClasica.TabIndex = 8
        Me.checkClasica.Text = "Clasica"
        Me.checkClasica.UseVisualStyleBackColor = True
        '
        'checkPop
        '
        Me.checkPop.AutoSize = True
        Me.checkPop.Location = New System.Drawing.Point(6, 43)
        Me.checkPop.Name = "checkPop"
        Me.checkPop.Size = New System.Drawing.Size(45, 17)
        Me.checkPop.TabIndex = 7
        Me.checkPop.Text = "Pop"
        Me.checkPop.UseVisualStyleBackColor = True
        '
        'checkRock
        '
        Me.checkRock.AutoSize = True
        Me.checkRock.Location = New System.Drawing.Point(6, 19)
        Me.checkRock.Name = "checkRock"
        Me.checkRock.Size = New System.Drawing.Size(52, 17)
        Me.checkRock.TabIndex = 6
        Me.checkRock.Text = "Rock"
        Me.checkRock.UseVisualStyleBackColor = True
        '
        'btnEnviar
        '
        Me.btnEnviar.Location = New System.Drawing.Point(197, 217)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(75, 23)
        Me.btnEnviar.TabIndex = 7
        Me.btnEnviar.Text = "Enviar"
        Me.btnEnviar.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Items.AddRange(New Object() {"Falta añadirle el código a este lixbox"})
        Me.ListBox1.Location = New System.Drawing.Point(116, 13)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(134, 134)
        Me.ListBox1.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btnEnviar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblPregunta)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPregunta As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents checkOtros As System.Windows.Forms.CheckBox
    Friend WithEvents checkReggaeton As System.Windows.Forms.CheckBox
    Friend WithEvents checkClasica As System.Windows.Forms.CheckBox
    Friend WithEvents checkPop As System.Windows.Forms.CheckBox
    Friend WithEvents checkRock As System.Windows.Forms.CheckBox
    Friend WithEvents btnEnviar As System.Windows.Forms.Button
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox

End Class
