﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Actualizar
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.numRetribucion = New System.Windows.Forms.NumericUpDown()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.domCategoria = New System.Windows.Forms.DomainUpDown()
        Me.cmbGenero = New System.Windows.Forms.ComboBox()
        Me.txtApellidos = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.numRetribucion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoEllipsis = True
        Me.Label5.Location = New System.Drawing.Point(179, 264)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 26)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Retribución fija:"
        '
        'numRetribucion
        '
        Me.numRetribucion.Increment = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.numRetribucion.Location = New System.Drawing.Point(319, 264)
        Me.numRetribucion.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.numRetribucion.Name = "numRetribucion"
        Me.numRetribucion.Size = New System.Drawing.Size(248, 20)
        Me.numRetribucion.TabIndex = 22
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(319, 306)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(113, 36)
        Me.btnLimpiar.TabIndex = 21
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Enabled = False
        Me.btnGuardar.Location = New System.Drawing.Point(450, 306)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(117, 36)
        Me.btnGuardar.TabIndex = 20
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'domCategoria
        '
        Me.domCategoria.Items.Add("Jefe de equipo")
        Me.domCategoria.Items.Add("Técnico")
        Me.domCategoria.Items.Add("Administrativo")
        Me.domCategoria.Location = New System.Drawing.Point(319, 224)
        Me.domCategoria.Name = "domCategoria"
        Me.domCategoria.Size = New System.Drawing.Size(248, 20)
        Me.domCategoria.TabIndex = 19
        '
        'cmbGenero
        '
        Me.cmbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGenero.FormattingEnabled = True
        Me.cmbGenero.Items.AddRange(New Object() {"Varón", "Mujer", "Hermafrodita"})
        Me.cmbGenero.Location = New System.Drawing.Point(319, 180)
        Me.cmbGenero.Name = "cmbGenero"
        Me.cmbGenero.Size = New System.Drawing.Size(248, 21)
        Me.cmbGenero.TabIndex = 18
        '
        'txtApellidos
        '
        Me.txtApellidos.Location = New System.Drawing.Point(319, 141)
        Me.txtApellidos.Name = "txtApellidos"
        Me.txtApellidos.Size = New System.Drawing.Size(248, 20)
        Me.txtApellidos.TabIndex = 17
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(319, 103)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(248, 20)
        Me.txtNombre.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(179, 224)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 30)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Categoria:"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(179, 180)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 30)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Genero:"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(179, 141)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 30)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Apellidos:"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(179, 103)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 30)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Nombre:"
        '
        'Form_Actualizar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(746, 445)
        Me.Controls.Add(Me.Label5)
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
        Me.Name = "Form_Actualizar"
        Me.Text = "Form_Actualizar"
        CType(Me.numRetribucion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents numRetribucion As NumericUpDown
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents domCategoria As DomainUpDown
    Friend WithEvents cmbGenero As ComboBox
    Friend WithEvents txtApellidos As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
