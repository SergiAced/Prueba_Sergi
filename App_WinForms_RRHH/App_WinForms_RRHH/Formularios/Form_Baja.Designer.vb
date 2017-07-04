<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_baja
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
        Me.btnDarBaja = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.lstEmpleados = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnDarBaja
        '
        Me.btnDarBaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDarBaja.ForeColor = System.Drawing.Color.OrangeRed
        Me.btnDarBaja.Location = New System.Drawing.Point(263, 180)
        Me.btnDarBaja.Name = "btnDarBaja"
        Me.btnDarBaja.Size = New System.Drawing.Size(153, 36)
        Me.btnDarBaja.TabIndex = 1
        Me.btnDarBaja.Text = "Dar de Baja"
        Me.btnDarBaja.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(46, 180)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'lstEmpleados
        '
        Me.lstEmpleados.FormattingEnabled = True
        Me.lstEmpleados.Location = New System.Drawing.Point(46, 63)
        Me.lstEmpleados.Name = "lstEmpleados"
        Me.lstEmpleados.Size = New System.Drawing.Size(370, 95)
        Me.lstEmpleados.TabIndex = 3
        '
        'Form_baja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(449, 383)
        Me.Controls.Add(Me.lstEmpleados)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnDarBaja)
        Me.Name = "Form_baja"
        Me.Text = "Baja de empleado"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnDarBaja As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents lstEmpleados As ListBox
End Class
