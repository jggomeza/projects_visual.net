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
        Me.tbcPrincipal = New System.Windows.Forms.TabControl()
        Me.tabInsertar = New System.Windows.Forms.TabPage()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.lblCorreo = New System.Windows.Forms.Label()
        Me.lblApellidos = New System.Windows.Forms.Label()
        Me.lblNombres = New System.Windows.Forms.Label()
        Me.lblIdentificacion = New System.Windows.Forms.Label()
        Me.btnInsertar = New System.Windows.Forms.Button()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.txtApellidos = New System.Windows.Forms.TextBox()
        Me.txtNombres = New System.Windows.Forms.TextBox()
        Me.txtIdentificacion = New System.Windows.Forms.TextBox()
        Me.tabActualizar = New System.Windows.Forms.TabPage()
        Me.lblDireccion2 = New System.Windows.Forms.Label()
        Me.lblCorreo2 = New System.Windows.Forms.Label()
        Me.lblApellidos2 = New System.Windows.Forms.Label()
        Me.lblNombres2 = New System.Windows.Forms.Label()
        Me.lblIdentificacion2 = New System.Windows.Forms.Label()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.txtDireccion2 = New System.Windows.Forms.TextBox()
        Me.txtCorreo2 = New System.Windows.Forms.TextBox()
        Me.txtApellidos2 = New System.Windows.Forms.TextBox()
        Me.txtNombres2 = New System.Windows.Forms.TextBox()
        Me.txtIdentificacion2 = New System.Windows.Forms.TextBox()
        Me.tabEliminar = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDireccion3 = New System.Windows.Forms.TextBox()
        Me.txtCorreo3 = New System.Windows.Forms.TextBox()
        Me.txtApellidos3 = New System.Windows.Forms.TextBox()
        Me.txtNombres3 = New System.Windows.Forms.TextBox()
        Me.lblIdentificacio3 = New System.Windows.Forms.Label()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.txtIdentificacion3 = New System.Windows.Forms.TextBox()
        Me.tbcPrincipal.SuspendLayout()
        Me.tabInsertar.SuspendLayout()
        Me.tabActualizar.SuspendLayout()
        Me.tabEliminar.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbcPrincipal
        '
        Me.tbcPrincipal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbcPrincipal.Controls.Add(Me.tabInsertar)
        Me.tbcPrincipal.Controls.Add(Me.tabActualizar)
        Me.tbcPrincipal.Controls.Add(Me.tabEliminar)
        Me.tbcPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.tbcPrincipal.Name = "tbcPrincipal"
        Me.tbcPrincipal.SelectedIndex = 0
        Me.tbcPrincipal.Size = New System.Drawing.Size(348, 289)
        Me.tbcPrincipal.TabIndex = 0
        '
        'tabInsertar
        '
        Me.tabInsertar.Controls.Add(Me.lblDireccion)
        Me.tabInsertar.Controls.Add(Me.lblCorreo)
        Me.tabInsertar.Controls.Add(Me.lblApellidos)
        Me.tabInsertar.Controls.Add(Me.lblNombres)
        Me.tabInsertar.Controls.Add(Me.lblIdentificacion)
        Me.tabInsertar.Controls.Add(Me.btnInsertar)
        Me.tabInsertar.Controls.Add(Me.txtDireccion)
        Me.tabInsertar.Controls.Add(Me.txtCorreo)
        Me.tabInsertar.Controls.Add(Me.txtApellidos)
        Me.tabInsertar.Controls.Add(Me.txtNombres)
        Me.tabInsertar.Controls.Add(Me.txtIdentificacion)
        Me.tabInsertar.Location = New System.Drawing.Point(4, 22)
        Me.tabInsertar.Name = "tabInsertar"
        Me.tabInsertar.Padding = New System.Windows.Forms.Padding(3)
        Me.tabInsertar.Size = New System.Drawing.Size(340, 263)
        Me.tabInsertar.TabIndex = 0
        Me.tabInsertar.Text = "Insertar"
        Me.tabInsertar.UseVisualStyleBackColor = True
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Location = New System.Drawing.Point(6, 164)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(52, 13)
        Me.lblDireccion.TabIndex = 11
        Me.lblDireccion.Text = "Dirección"
        '
        'lblCorreo
        '
        Me.lblCorreo.AutoSize = True
        Me.lblCorreo.Location = New System.Drawing.Point(8, 125)
        Me.lblCorreo.Name = "lblCorreo"
        Me.lblCorreo.Size = New System.Drawing.Size(38, 13)
        Me.lblCorreo.TabIndex = 10
        Me.lblCorreo.Text = "Correo"
        '
        'lblApellidos
        '
        Me.lblApellidos.AutoSize = True
        Me.lblApellidos.Location = New System.Drawing.Point(8, 86)
        Me.lblApellidos.Name = "lblApellidos"
        Me.lblApellidos.Size = New System.Drawing.Size(49, 13)
        Me.lblApellidos.TabIndex = 9
        Me.lblApellidos.Text = "Apellidos"
        '
        'lblNombres
        '
        Me.lblNombres.AutoSize = True
        Me.lblNombres.Location = New System.Drawing.Point(7, 45)
        Me.lblNombres.Name = "lblNombres"
        Me.lblNombres.Size = New System.Drawing.Size(49, 13)
        Me.lblNombres.TabIndex = 8
        Me.lblNombres.Text = "Nombres"
        '
        'lblIdentificacion
        '
        Me.lblIdentificacion.AutoSize = True
        Me.lblIdentificacion.Location = New System.Drawing.Point(8, 6)
        Me.lblIdentificacion.Name = "lblIdentificacion"
        Me.lblIdentificacion.Size = New System.Drawing.Size(70, 13)
        Me.lblIdentificacion.TabIndex = 7
        Me.lblIdentificacion.Text = "Identificación"
        '
        'btnInsertar
        '
        Me.btnInsertar.Location = New System.Drawing.Point(226, 220)
        Me.btnInsertar.Name = "btnInsertar"
        Me.btnInsertar.Size = New System.Drawing.Size(75, 23)
        Me.btnInsertar.TabIndex = 6
        Me.btnInsertar.Text = "Insertar"
        Me.btnInsertar.UseVisualStyleBackColor = True
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(6, 180)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(309, 20)
        Me.txtDireccion.TabIndex = 4
        '
        'txtCorreo
        '
        Me.txtCorreo.Location = New System.Drawing.Point(6, 141)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(307, 20)
        Me.txtCorreo.TabIndex = 3
        '
        'txtApellidos
        '
        Me.txtApellidos.Location = New System.Drawing.Point(11, 102)
        Me.txtApellidos.Name = "txtApellidos"
        Me.txtApellidos.Size = New System.Drawing.Size(309, 20)
        Me.txtApellidos.TabIndex = 2
        '
        'txtNombres
        '
        Me.txtNombres.Location = New System.Drawing.Point(10, 63)
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Size = New System.Drawing.Size(307, 20)
        Me.txtNombres.TabIndex = 1
        '
        'txtIdentificacion
        '
        Me.txtIdentificacion.Location = New System.Drawing.Point(10, 22)
        Me.txtIdentificacion.Name = "txtIdentificacion"
        Me.txtIdentificacion.Size = New System.Drawing.Size(100, 20)
        Me.txtIdentificacion.TabIndex = 0
        '
        'tabActualizar
        '
        Me.tabActualizar.Controls.Add(Me.lblDireccion2)
        Me.tabActualizar.Controls.Add(Me.lblCorreo2)
        Me.tabActualizar.Controls.Add(Me.lblApellidos2)
        Me.tabActualizar.Controls.Add(Me.lblNombres2)
        Me.tabActualizar.Controls.Add(Me.lblIdentificacion2)
        Me.tabActualizar.Controls.Add(Me.btnActualizar)
        Me.tabActualizar.Controls.Add(Me.txtDireccion2)
        Me.tabActualizar.Controls.Add(Me.txtCorreo2)
        Me.tabActualizar.Controls.Add(Me.txtApellidos2)
        Me.tabActualizar.Controls.Add(Me.txtNombres2)
        Me.tabActualizar.Controls.Add(Me.txtIdentificacion2)
        Me.tabActualizar.Location = New System.Drawing.Point(4, 22)
        Me.tabActualizar.Name = "tabActualizar"
        Me.tabActualizar.Padding = New System.Windows.Forms.Padding(3)
        Me.tabActualizar.Size = New System.Drawing.Size(340, 263)
        Me.tabActualizar.TabIndex = 1
        Me.tabActualizar.Text = "Actualizar"
        Me.tabActualizar.UseVisualStyleBackColor = True
        '
        'lblDireccion2
        '
        Me.lblDireccion2.AutoSize = True
        Me.lblDireccion2.Location = New System.Drawing.Point(13, 171)
        Me.lblDireccion2.Name = "lblDireccion2"
        Me.lblDireccion2.Size = New System.Drawing.Size(52, 13)
        Me.lblDireccion2.TabIndex = 22
        Me.lblDireccion2.Text = "Dirección"
        '
        'lblCorreo2
        '
        Me.lblCorreo2.AutoSize = True
        Me.lblCorreo2.Location = New System.Drawing.Point(15, 132)
        Me.lblCorreo2.Name = "lblCorreo2"
        Me.lblCorreo2.Size = New System.Drawing.Size(38, 13)
        Me.lblCorreo2.TabIndex = 21
        Me.lblCorreo2.Text = "Correo"
        '
        'lblApellidos2
        '
        Me.lblApellidos2.AutoSize = True
        Me.lblApellidos2.Location = New System.Drawing.Point(15, 93)
        Me.lblApellidos2.Name = "lblApellidos2"
        Me.lblApellidos2.Size = New System.Drawing.Size(49, 13)
        Me.lblApellidos2.TabIndex = 20
        Me.lblApellidos2.Text = "Apellidos"
        '
        'lblNombres2
        '
        Me.lblNombres2.AutoSize = True
        Me.lblNombres2.Location = New System.Drawing.Point(14, 52)
        Me.lblNombres2.Name = "lblNombres2"
        Me.lblNombres2.Size = New System.Drawing.Size(49, 13)
        Me.lblNombres2.TabIndex = 19
        Me.lblNombres2.Text = "Nombres"
        '
        'lblIdentificacion2
        '
        Me.lblIdentificacion2.AutoSize = True
        Me.lblIdentificacion2.Location = New System.Drawing.Point(15, 13)
        Me.lblIdentificacion2.Name = "lblIdentificacion2"
        Me.lblIdentificacion2.Size = New System.Drawing.Size(70, 13)
        Me.lblIdentificacion2.TabIndex = 18
        Me.lblIdentificacion2.Text = "Identificación"
        '
        'btnActualizar
        '
        Me.btnActualizar.Enabled = False
        Me.btnActualizar.Location = New System.Drawing.Point(233, 227)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(75, 23)
        Me.btnActualizar.TabIndex = 17
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'txtDireccion2
        '
        Me.txtDireccion2.Location = New System.Drawing.Point(13, 187)
        Me.txtDireccion2.Name = "txtDireccion2"
        Me.txtDireccion2.Size = New System.Drawing.Size(309, 20)
        Me.txtDireccion2.TabIndex = 16
        '
        'txtCorreo2
        '
        Me.txtCorreo2.Location = New System.Drawing.Point(13, 148)
        Me.txtCorreo2.Name = "txtCorreo2"
        Me.txtCorreo2.Size = New System.Drawing.Size(307, 20)
        Me.txtCorreo2.TabIndex = 15
        '
        'txtApellidos2
        '
        Me.txtApellidos2.Location = New System.Drawing.Point(18, 109)
        Me.txtApellidos2.Name = "txtApellidos2"
        Me.txtApellidos2.Size = New System.Drawing.Size(309, 20)
        Me.txtApellidos2.TabIndex = 14
        '
        'txtNombres2
        '
        Me.txtNombres2.Location = New System.Drawing.Point(17, 70)
        Me.txtNombres2.Name = "txtNombres2"
        Me.txtNombres2.Size = New System.Drawing.Size(307, 20)
        Me.txtNombres2.TabIndex = 13
        '
        'txtIdentificacion2
        '
        Me.txtIdentificacion2.Location = New System.Drawing.Point(17, 29)
        Me.txtIdentificacion2.Name = "txtIdentificacion2"
        Me.txtIdentificacion2.Size = New System.Drawing.Size(100, 20)
        Me.txtIdentificacion2.TabIndex = 12
        '
        'tabEliminar
        '
        Me.tabEliminar.Controls.Add(Me.Label1)
        Me.tabEliminar.Controls.Add(Me.Label2)
        Me.tabEliminar.Controls.Add(Me.Label3)
        Me.tabEliminar.Controls.Add(Me.Label4)
        Me.tabEliminar.Controls.Add(Me.txtDireccion3)
        Me.tabEliminar.Controls.Add(Me.txtCorreo3)
        Me.tabEliminar.Controls.Add(Me.txtApellidos3)
        Me.tabEliminar.Controls.Add(Me.txtNombres3)
        Me.tabEliminar.Controls.Add(Me.lblIdentificacio3)
        Me.tabEliminar.Controls.Add(Me.btnEliminar)
        Me.tabEliminar.Controls.Add(Me.txtIdentificacion3)
        Me.tabEliminar.Location = New System.Drawing.Point(4, 22)
        Me.tabEliminar.Name = "tabEliminar"
        Me.tabEliminar.Padding = New System.Windows.Forms.Padding(3)
        Me.tabEliminar.Size = New System.Drawing.Size(340, 263)
        Me.tabEliminar.TabIndex = 2
        Me.tabEliminar.Text = "Eliminar"
        Me.tabEliminar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 171)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Dirección"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 132)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Correo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Apellidos"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Nombres"
        '
        'txtDireccion3
        '
        Me.txtDireccion3.Enabled = False
        Me.txtDireccion3.Location = New System.Drawing.Point(23, 187)
        Me.txtDireccion3.Name = "txtDireccion3"
        Me.txtDireccion3.Size = New System.Drawing.Size(309, 20)
        Me.txtDireccion3.TabIndex = 26
        '
        'txtCorreo3
        '
        Me.txtCorreo3.Enabled = False
        Me.txtCorreo3.Location = New System.Drawing.Point(23, 148)
        Me.txtCorreo3.Name = "txtCorreo3"
        Me.txtCorreo3.Size = New System.Drawing.Size(307, 20)
        Me.txtCorreo3.TabIndex = 25
        '
        'txtApellidos3
        '
        Me.txtApellidos3.Enabled = False
        Me.txtApellidos3.Location = New System.Drawing.Point(28, 109)
        Me.txtApellidos3.Name = "txtApellidos3"
        Me.txtApellidos3.Size = New System.Drawing.Size(309, 20)
        Me.txtApellidos3.TabIndex = 24
        '
        'txtNombres3
        '
        Me.txtNombres3.Enabled = False
        Me.txtNombres3.Location = New System.Drawing.Point(27, 70)
        Me.txtNombres3.Name = "txtNombres3"
        Me.txtNombres3.Size = New System.Drawing.Size(307, 20)
        Me.txtNombres3.TabIndex = 23
        '
        'lblIdentificacio3
        '
        Me.lblIdentificacio3.AutoSize = True
        Me.lblIdentificacio3.Location = New System.Drawing.Point(24, 13)
        Me.lblIdentificacio3.Name = "lblIdentificacio3"
        Me.lblIdentificacio3.Size = New System.Drawing.Size(70, 13)
        Me.lblIdentificacio3.TabIndex = 21
        Me.lblIdentificacio3.Text = "Identificación"
        '
        'btnEliminar
        '
        Me.btnEliminar.Enabled = False
        Me.btnEliminar.Location = New System.Drawing.Point(242, 227)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 20
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'txtIdentificacion3
        '
        Me.txtIdentificacion3.Location = New System.Drawing.Point(26, 29)
        Me.txtIdentificacion3.Name = "txtIdentificacion3"
        Me.txtIdentificacion3.Size = New System.Drawing.Size(100, 20)
        Me.txtIdentificacion3.TabIndex = 19
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(346, 287)
        Me.Controls.Add(Me.tbcPrincipal)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.tbcPrincipal.ResumeLayout(False)
        Me.tabInsertar.ResumeLayout(False)
        Me.tabInsertar.PerformLayout()
        Me.tabActualizar.ResumeLayout(False)
        Me.tabActualizar.PerformLayout()
        Me.tabEliminar.ResumeLayout(False)
        Me.tabEliminar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tbcPrincipal As System.Windows.Forms.TabControl
    Friend WithEvents tabInsertar As System.Windows.Forms.TabPage
    Friend WithEvents lblDireccion As System.Windows.Forms.Label
    Friend WithEvents lblCorreo As System.Windows.Forms.Label
    Friend WithEvents lblApellidos As System.Windows.Forms.Label
    Friend WithEvents lblNombres As System.Windows.Forms.Label
    Friend WithEvents lblIdentificacion As System.Windows.Forms.Label
    Friend WithEvents btnInsertar As System.Windows.Forms.Button
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents txtCorreo As System.Windows.Forms.TextBox
    Friend WithEvents txtApellidos As System.Windows.Forms.TextBox
    Friend WithEvents txtNombres As System.Windows.Forms.TextBox
    Friend WithEvents txtIdentificacion As System.Windows.Forms.TextBox
    Friend WithEvents tabActualizar As System.Windows.Forms.TabPage
    Friend WithEvents lblDireccion2 As System.Windows.Forms.Label
    Friend WithEvents lblCorreo2 As System.Windows.Forms.Label
    Friend WithEvents lblApellidos2 As System.Windows.Forms.Label
    Friend WithEvents lblNombres2 As System.Windows.Forms.Label
    Friend WithEvents lblIdentificacion2 As System.Windows.Forms.Label
    Friend WithEvents btnActualizar As System.Windows.Forms.Button
    Friend WithEvents txtDireccion2 As System.Windows.Forms.TextBox
    Friend WithEvents txtCorreo2 As System.Windows.Forms.TextBox
    Friend WithEvents txtApellidos2 As System.Windows.Forms.TextBox
    Friend WithEvents txtNombres2 As System.Windows.Forms.TextBox
    Friend WithEvents txtIdentificacion2 As System.Windows.Forms.TextBox
    Friend WithEvents tabEliminar As System.Windows.Forms.TabPage
    Friend WithEvents lblIdentificacio3 As System.Windows.Forms.Label
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents txtIdentificacion3 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDireccion3 As System.Windows.Forms.TextBox
    Friend WithEvents txtCorreo3 As System.Windows.Forms.TextBox
    Friend WithEvents txtApellidos3 As System.Windows.Forms.TextBox
    Friend WithEvents txtNombres3 As System.Windows.Forms.TextBox

End Class
