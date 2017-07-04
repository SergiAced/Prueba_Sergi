Imports A
Public Class Form_lista
    Private Sub cmbNombre_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbNombre.SelectedIndexChanged
        BuscarEmpleado()
    End Sub

    Private Sub cmbNombre_TextChanged(sender As Object, e As EventArgs) _
        Handles cmbNombre.TextChanged, cmbAplellidos.TextChanged
        BuscarEmpleado()

    End Sub

    Private Sub BuscarEmpleado()

        Dim numEmpleado As Integer

        If (cmbNombre.Text <> "") Then
            numEmpleado = EmpleadosCRUD.BuscarPorCampoEmpleado(cmbNombre.Text,
            TipoCampoEmpleado.Nombre)

        ElseIf
                (cmbAplellidos.Text <> "") Then
            numEmpleado = EmpleadosCRUD.BuscarPorCampoEmpleado(cmbAplellidos.Text
            TipoCampoEmpleado.NoApellidosmbre)
        End If
        MessageBox.Show("Indice encontrado = " & numEmpleado)
    End Sub

End Class
