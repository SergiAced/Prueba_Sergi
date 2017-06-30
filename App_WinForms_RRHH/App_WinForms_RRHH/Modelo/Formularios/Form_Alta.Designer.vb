<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Alta
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtApellidos = New System.Windows.Forms.TextBox()
        Me.cmbGenero = New System.Windows.Forms.ComboBox()
        Me.domCategoria = New System.Windows.Forms.DomainUpDown()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.numRetribucion = New System.Windows.Forms.DomainUpDown()
        Me.REt = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(71, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(71, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Apellidos:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(71, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Genero:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(71, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Categoria"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(184, 43)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(241, 20)
        Me.txtNombre.TabIndex = 4
        '
        'txtApellidos
        '
        Me.txtApellidos.Location = New System.Drawing.Point(184, 83)
        Me.txtApellidos.Name = "txtApellidos"
        Me.txtApellidos.Size = New System.Drawing.Size(241, 20)
        Me.txtApellidos.TabIndex = 5
        '
        'cmbGenero
        '
        Me.cmbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGenero.FormattingEnabled = True
        Me.cmbGenero.Items.AddRange(New Object() {"Varón", "Mujer", "Hermafrodita"})
        Me.cmbGenero.Location = New System.Drawing.Point(184, 116)
        Me.cmbGenero.Name = "cmbGenero"
        Me.cmbGenero.Size = New System.Drawing.Size(241, 21)
        Me.cmbGenero.TabIndex = 6
        '
        'domCategoria
        '
        Me.domCategoria.Items.Add("Jefe Equipo")
        Me.domCategoria.Items.Add("Tecnico")
        Me.domCategoria.Items.Add("Administrativo")
        Me.domCategoria.Location = New System.Drawing.Point(184, 152)
        Me.domCategoria.Name = "domCategoria"
        Me.domCategoria.Size = New System.Drawing.Size(241, 20)
        Me.domCategoria.TabIndex = 7
        '
        'btnGuardar
        '
        Me.btnGuardar.Enabled = False
        Me.btnGuardar.Location = New System.Drawing.Point(350, 234)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 10
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(184, 234)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpiar.TabIndex = 9
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'numRetribucion
        '
        Me.numRetribucion.Items.Add("Jefe Equipo")
        Me.numRetribucion.Items.Add("Tecnico")
        Me.numRetribucion.Items.Add("Administrativo")
        Me.numRetribucion.Location = New System.Drawing.Point(184, 183)
        Me.numRetribucion.Name = "numRetribucion"
        Me.numRetribucion.Size = New System.Drawing.Size(241, 20)
        Me.numRetribucion.TabIndex = 11
        '
        'REt
        '
        Me.REt.AutoSize = True
        Me.REt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REt.Location = New System.Drawing.Point(71, 183)
        Me.REt.Name = "REt"
        Me.REt.Size = New System.Drawing.Size(90, 20)
        Me.REt.TabIndex = 12
        Me.REt.Text = "Retribucion"
        '
        'Form_Alta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(491, 269)
        Me.Controls.Add(Me.REt)
        Me.Controls.Add(Me.numRetribucion)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.domCategoria)
        Me.Controls.Add(Me.cmbGenero)
        Me.Controls.Add(Me.txtApellidos)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form_Alta"
        Me.Text = "Alta_de_empleado"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtApellidos As TextBox
    Friend WithEvents cmbGenero As ComboBox
    Friend WithEvents domCategoria As DomainUpDown
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents numRetribucion As DomainUpDown
    Friend WithEvents REt As Label
End Class
