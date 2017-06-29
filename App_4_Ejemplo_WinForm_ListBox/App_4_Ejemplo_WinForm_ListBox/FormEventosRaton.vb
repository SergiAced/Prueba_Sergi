Public Class FormEventosRaton




    Private Sub AlPulsarRaton(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        Dim nuevoBoton As New Button
        nuevoBoton.Size = New Size(20, 20)
        nuevoBoton.Text = "X"

        ' Dim posicionBoton As Point = New Point()

        nuevoBoton.Parent = Me
        nuevoBoton.Location = e.Location




    End Sub

End Class