<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVentaAutos
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtOrigen = New System.Windows.Forms.TextBox()
        Me.txtDestino = New System.Windows.Forms.TextBox()
        Me.chkActivar = New System.Windows.Forms.CheckBox()
        Me.btnTraspasar = New System.Windows.Forms.Button()
        Me.tmrTemporizador = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1, 405)
        Me.Panel1.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(80, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Texto Origen"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(80, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Texto Destino"
        '
        'txtOrigen
        '
        Me.txtOrigen.Location = New System.Drawing.Point(157, 66)
        Me.txtOrigen.Name = "txtOrigen"
        Me.txtOrigen.Size = New System.Drawing.Size(268, 20)
        Me.txtOrigen.TabIndex = 7
        '
        'txtDestino
        '
        Me.txtDestino.Location = New System.Drawing.Point(157, 93)
        Me.txtDestino.Name = "txtDestino"
        Me.txtDestino.Size = New System.Drawing.Size(268, 20)
        Me.txtDestino.TabIndex = 8
        '
        'chkActivar
        '
        Me.chkActivar.AutoSize = True
        Me.chkActivar.Location = New System.Drawing.Point(327, 152)
        Me.chkActivar.Name = "chkActivar"
        Me.chkActivar.Size = New System.Drawing.Size(90, 17)
        Me.chkActivar.TabIndex = 9
        Me.chkActivar.Text = "Cambiar color"
        Me.chkActivar.UseVisualStyleBackColor = True
        '
        'btnTraspasar
        '
        Me.btnTraspasar.Location = New System.Drawing.Point(157, 146)
        Me.btnTraspasar.Name = "btnTraspasar"
        Me.btnTraspasar.Size = New System.Drawing.Size(137, 23)
        Me.btnTraspasar.TabIndex = 10
        Me.btnTraspasar.Text = "Traspasar texto"
        Me.btnTraspasar.UseVisualStyleBackColor = True
        '
        'tmrTemporizador
        '
        '
        'FrmVentaAutos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Aqua
        Me.ClientSize = New System.Drawing.Size(530, 405)
        Me.Controls.Add(Me.btnTraspasar)
        Me.Controls.Add(Me.chkActivar)
        Me.Controls.Add(Me.txtDestino)
        Me.Controls.Add(Me.txtOrigen)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "FrmVentaAutos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Venta Autos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtOrigen As System.Windows.Forms.TextBox
    Friend WithEvents txtDestino As System.Windows.Forms.TextBox
    Friend WithEvents chkActivar As System.Windows.Forms.CheckBox
    Friend WithEvents btnTraspasar As System.Windows.Forms.Button
    Friend WithEvents tmrTemporizador As System.Windows.Forms.Timer
End Class
