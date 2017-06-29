<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormComboListas
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
        Me.txtTexto = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmbTextos = New System.Windows.Forms.ComboBox()
        Me.btnPasar = New System.Windows.Forms.Button()
        Me.btnQuitar = New System.Windows.Forms.Button()
        Me.chkListTextos = New System.Windows.Forms.CheckedListBox()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtTexto
        '
        Me.txtTexto.Location = New System.Drawing.Point(13, 33)
        Me.txtTexto.Name = "txtTexto"
        Me.txtTexto.Size = New System.Drawing.Size(215, 20)
        Me.txtTexto.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Texto a añadir"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(153, 59)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Agregar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cmbTextos
        '
        Me.cmbTextos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTextos.FormattingEnabled = True
        Me.cmbTextos.Location = New System.Drawing.Point(15, 101)
        Me.cmbTextos.Name = "cmbTextos"
        Me.cmbTextos.Size = New System.Drawing.Size(213, 21)
        Me.cmbTextos.TabIndex = 3
        '
        'btnPasar
        '
        Me.btnPasar.Location = New System.Drawing.Point(251, 59)
        Me.btnPasar.Name = "btnPasar"
        Me.btnPasar.Size = New System.Drawing.Size(75, 23)
        Me.btnPasar.TabIndex = 4
        Me.btnPasar.Text = "Pasar"
        Me.btnPasar.UseVisualStyleBackColor = True
        '
        'btnQuitar
        '
        Me.btnQuitar.Location = New System.Drawing.Point(251, 101)
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.Size = New System.Drawing.Size(75, 23)
        Me.btnQuitar.TabIndex = 5
        Me.btnQuitar.Text = "Quitar"
        Me.btnQuitar.UseVisualStyleBackColor = True
        '
        'chkListTextos
        '
        Me.chkListTextos.FormattingEnabled = True
        Me.chkListTextos.Location = New System.Drawing.Point(376, 59)
        Me.chkListTextos.Name = "chkListTextos"
        Me.chkListTextos.Size = New System.Drawing.Size(120, 109)
        Me.chkListTextos.TabIndex = 6
        '
        'TrackBar1
        '
        Me.TrackBar1.Location = New System.Drawing.Point(502, 59)
        Me.TrackBar1.Maximum = 8
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.TrackBar1.Size = New System.Drawing.Size(45, 109)
        Me.TrackBar1.TabIndex = 7
        Me.TrackBar1.TickFrequency = 2
        Me.TrackBar1.Value = 2
        '
        'FormComboListas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(559, 289)
        Me.Controls.Add(Me.TrackBar1)
        Me.Controls.Add(Me.chkListTextos)
        Me.Controls.Add(Me.btnQuitar)
        Me.Controls.Add(Me.btnPasar)
        Me.Controls.Add(Me.cmbTextos)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTexto)
        Me.Name = "FormComboListas"
        Me.Text = "FormComboListas"
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtTexto As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents cmbTextos As ComboBox
    Friend WithEvents btnPasar As Button
    Friend WithEvents btnQuitar As Button
    Friend WithEvents chkListTextos As CheckedListBox
    Friend WithEvents TrackBar1 As TrackBar
End Class
