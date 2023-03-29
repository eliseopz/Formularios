<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPrincipal))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.LblHora = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TmrAuxiliar = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TxtMotivo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtApellidos = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtNombres = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(620, 43)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(167, 127)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DtpFecha)
        Me.GroupBox1.Controls.Add(Me.LblHora)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 44)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(578, 126)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'DtpFecha
        '
        Me.DtpFecha.Location = New System.Drawing.Point(11, 62)
        Me.DtpFecha.Name = "DtpFecha"
        Me.DtpFecha.Size = New System.Drawing.Size(326, 20)
        Me.DtpFecha.TabIndex = 2
        '
        'LblHora
        '
        Me.LblHora.AutoSize = True
        Me.LblHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHora.Location = New System.Drawing.Point(516, 26)
        Me.LblHora.Name = "LblHora"
        Me.LblHora.Size = New System.Drawing.Size(56, 16)
        Me.LblHora.TabIndex = 1
        Me.LblHora.Text = "00:00:00"
        Me.LblHora.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(330, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Bienvenido al sistema de registro UCA"
        '
        'TmrAuxiliar
        '
        Me.TmrAuxiliar.Interval = 1000
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.Controls.Add(Me.BtnLimpiar)
        Me.GroupBox2.Controls.Add(Me.BtnAgregar)
        Me.GroupBox2.Controls.Add(Me.TxtMotivo)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.TxtApellidos)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.TxtNombres)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 177)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(775, 261)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos Generales"
        '
        'TxtMotivo
        '
        Me.TxtMotivo.Location = New System.Drawing.Point(117, 111)
        Me.TxtMotivo.Multiline = True
        Me.TxtMotivo.Name = "TxtMotivo"
        Me.TxtMotivo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtMotivo.Size = New System.Drawing.Size(346, 102)
        Me.TxtMotivo.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(11, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 15)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Motivo de visita:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtApellidos
        '
        Me.TxtApellidos.Location = New System.Drawing.Point(117, 66)
        Me.TxtApellidos.Name = "TxtApellidos"
        Me.TxtApellidos.Size = New System.Drawing.Size(346, 22)
        Me.TxtApellidos.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(44, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Apellidos:"
        '
        'TxtNombres
        '
        Me.TxtNombres.Location = New System.Drawing.Point(117, 22)
        Me.TxtNombres.Name = "TxtNombres"
        Me.TxtNombres.Size = New System.Drawing.Size(346, 22)
        Me.TxtNombres.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(43, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nombres:"
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAgregar.Location = New System.Drawing.Point(608, 29)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(75, 24)
        Me.BtnAgregar.TabIndex = 6
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLimpiar.Location = New System.Drawing.Point(608, 73)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.BtnLimpiar.TabIndex = 7
        Me.BtnLimpiar.Text = "Limpiar"
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximizeBox = False
        Me.Name = "FrmPrincipal"
        Me.Text = "Sistema de Registro UCA"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DtpFecha As DateTimePicker
    Friend WithEvents LblHora As Label
    Friend WithEvents TmrAuxiliar As Timer
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtNombres As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtApellidos As TextBox
    Friend WithEvents TxtMotivo As TextBox
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents BtnLimpiar As Button
End Class
