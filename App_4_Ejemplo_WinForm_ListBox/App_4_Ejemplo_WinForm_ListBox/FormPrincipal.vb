Public Class FormPrincipal
    Private miFormComboListas As FormComboListas
    Private Sub FormPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        miFormComboListas = New FormComboListas()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnMostrarLongitud.Click
        MessageBox.Show("longitud de texto multilena: " & txtMultilinea.TextLength.ToString() &
                        vbCrLf & "longitud texto 2: " & txtDiezCaracteres.TextLength.ToString())
    End Sub
    Private Sub TextBox1_2_TextChanged(sender As Object, e As EventArgs) Handles txtMultilinea.TextChanged, txtDiezCaracteres.TextChanged
        lblLongitudes.Text = "longitud de texto multilena: " & txtMultilinea.TextLength.ToString() &
                        vbCrLf & "longitud texto 2: " & txtDiezCaracteres.TextLength.ToString()
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        lstListaDatos.Items.Add(txtMultilinea.Text)
    End Sub
    Private Sub btnAdd2_Click(sender As Object, e As EventArgs) Handles btnAdd2.Click
        lstListaDatos.Items.Add(txtDiezCaracteres.Text)
        txtDiezCaracteres.Clear()
    End Sub
    Private Sub btnEliminarDeLista_Click(sender As Object, e As EventArgs) Handles btnEliminarDeLista.Click
        lstListaDatos.Items.RemoveAt(lstListaDatos.SelectedIndex)
    End Sub
    Private Sub lstListaDatos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstListaDatos.SelectedIndexChanged

        btnEliminarDeLista.Enabled = (lstListaDatos.SelectedIndex >= 0)
    End Sub
    Private Sub btnAbrirForm_Click(sender As Object, e As EventArgs) Handles btnAbrirForm.Click
        If miFormComboListas Is Nothing Or miFormComboListas.IsDisposed Then
            miFormComboListas = New FormComboListas()
        End If
        miFormComboListas.ShowDialog()
    End Sub
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        miFormComboListas.Hide()  'nuevoFormComboListas.Close()
    End Sub

    Private Sub btnCambiar_Click(sender As Object, e As EventArgs) Handles btnCambiar.Click, btnMostrarLongitud.Click
        Dim tipoFuente As Integer
        'tipoFuente = System.Drawing.FontStyle.Bold + System.Drawing.FontStyle.Strikeout     ' 1001 = 9
        tipoFuente = System.Drawing.FontStyle.Italic + System.Drawing.FontStyle.Underline   ' 0110 = 6
        'tipoFuente = System.Drawing.FontStyle.Bold + System.Drawing.FontStyle.Italic        ' 0011 = 3

        Me.lblLongitudes.Font = New Font("Microsoft Sans Serif", 16, tipoFuente,
                                         System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ' Ampliar el tamaño de txtMultilinea
        Me.txtMultilinea.Multiline = True
        Dim tamañoTxtMult As Size = Me.txtMultilinea.Size
        tamañoTxtMult.Height += 100
        Me.txtMultilinea.Size = tamañoTxtMult
        ' Mover a la derecha el boton pulsado
        Dim esteBoton As Button = CType(sender, Button)
        esteBoton.Location = New Point(esteBoton.Location.X + 20, esteBoton.Location.Y)

        ' Poner btnAbrirForm a la izquierda del boton Cerrar
        btnAbrirForm.Location = New Point(btnCerrar.Location.X - btnAbrirForm.Size.Width - 10,
                                            btnCerrar.Location.Y)

        ' Cambiar las propiedades del propio formulario
        Me.Text = "Nuevo titulo ventana"
        Me.BackColor = Color.BurlyWood
        Me.BackColor = Color.FromArgb(255, 255, 255, 0) '32 bits. 8 bit por color, 1 byte por color

        '417; 45 / 245; 184
        lstListaDatos.SetBounds(417, 45, 245, 185)
        'lstListaDatos.BringToFront()
        Label5.SendToBack()

        '       Dim nuevoBoton As Button
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Dim fecha As Date = DateTimePicker1.Value
        fecha = fecha.AddDays(1)

        Me.Text = "Ventana: " & fecha.ToString()

        If fecha.Year = 2017 Then
            Me.Text += "¡Este mismo año!"
        End If
    End Sub

    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        Dim nuevoBoton As Button
        nuevoBoton = New Button()
        nuevoBoton.Size = New Size(200, 200)
        nuevoBoton.Location = New Point(100, 100)
        nuevoBoton.Text = "Pulsa para eliminar"
        nuevoBoton.Parent = Me
        nuevoBoton.BringToFront()
        AddHandler nuevoBoton.Click, AddressOf EliminarComponente
    End Sub
    Private Sub EliminarComponente(sender As Button, e As EventArgs)
        sender.Dispose()
    End Sub

    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateChanged

        DateTimePicker1.Value = MonthCalendar1.SelectionRange.Start

        Dim fechaFin As Date = MonthCalendar1.SelectionEnd
        DateTimePicker2.Value = fechaFin



    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged

    End Sub

    Private Sub MostrarDiaSemana(dateTime As DateTimePicker, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Select Case dateTime.Value.DayOfWeek
            Case DayOfWeek.Monday
                lblDiaSemana.Text = "Lunes"
            Case DayOfWeek.Tuesday
                lblDiaSemana.Text = "Ma"
            Case DayOfWeek.Wednesday
                lblDiaSemana.Text = "Mi"
            Case DayOfWeek.Thursday
                lblDiaSemana.Text = "Ju"
            Case DayOfWeek.Friday
                lblDiaSemana.Text = "Vi"
            Case DayOfWeek.Saturday
                lblDiaSemana.Text = "Sa"
            Case DayOfWeek.Sunday
                lblDiaSemana.Text = "Do"
        End Select
    End Sub

    Private Sub MostrarComparativa(dateTime As DateTimePicker, e As EventArgs) Handles DateTimePicker1.ValueChanged, DateTimePicker2.ValueChanged
        If DateTimePicker1.Value.CompareTo(DateTimePicker2.Value) < 0 Then
            lblComparacion.Text = "La primera fecha es menor"
        ElseIf DateTimePicker1.Value.CompareTo(DateTimePicker2.Value) > 0 Then
            lblComparacion.Text = "La primera fecha es mayor"
        Else
            lblComparacion.Text = "Las fechas son iguales"
        End If

    End Sub

    Private Sub btnComparar_Click(sender As Object, e As EventArgs) Handles btnComparar.Click

        Dim resultadoComparacion As Integer = txtTextoA.Text.CompareTo(txtTextoB.Text)

        If DateTimePicker1.Value.CompareTo(DateTimePicker2.Value) < 0 Then
            lblCompTxt.Text = "La primera fecha es menor"
        ElseIf DateTimePicker1.Value.CompareTo(DateTimePicker2.Value) > 0 Then
            lblCompTxt.Text = "La primera fecha es mayor"
        Else
            lblCompTxt.Text = "Las fechas son iguales"
        End If

    End Sub

    Private Sub btnProvocador_Click(sender As Object, e As EventArgs) Handles btnProvocador.Click
        txtTextoA.BackColor = Color.Chartreuse
    End Sub

    Private Sub EventoProvocado(sender As Object, e As EventArgs) Handles btnProvocador.BackColorChanged, txtTextoA.BackColorChanged, txtTextoA.Enter
        MessageBox.Show(Me,
                        "Evento" & e.ToString() & vbCrLf &
                        "desde" & sender.ToString(),
                        "Evento provocado")



    End Sub

    Private Sub TextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress

        If Not (Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar)) Then
            'Ignorar la tecla
            e.Handled = True

        End If
        ' Char.ToUpper / String.ToUpper
        ' Ejercicio: Convertir a mayusculas los caracteres de txtTextoB usando KeyPress
    End Sub



End Class
