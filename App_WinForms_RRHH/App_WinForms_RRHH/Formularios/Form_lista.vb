Imports App_WinForms_RRHH.Modelo

Public Class Form_Lista
    Public Form_Lista As List(Of Empleado)
    Private Sub cmbNombre_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbNombre.SelectedIndexChanged
        BuscarEmpleado()
    End Sub
    Private Sub cmbNombre_TextChanged(sender As Object, e As EventArgs) _
        Handles cmbNombre.TextChanged, cmbApellidos.TextChanged
        BuscarEmpleado()
    End Sub
    Private Sub BuscarEmpleado()
        lstListaEmpleados.Items.Clear()
        Form_Lista = EmpleadosCRUD.BuscarEmpleados(cmbNombre.Text, cmbApellidos.Text)

        For Each empleado As Empleado In Form_Lista
            lstListaEmpleados.Items.Add(empleado.nombre & " " & empleado.apellidos)
            indiceABorrar As Integer listaEmpleados.IndexOf(
            lstListaEmpleados As List of empleados (lstListaEmpleados.SelectedIndices(indice)))

        Next
    End Sub

    Private Function indiceABorrar() As Integer
        Throw New NotImplementedException()
    End Function

    Private Sub btnBaja_Click_1(sender As Object, e As EventArgs) Handles btnBaja.Click

        Dim listaEliminar As New List(Of Empleado)
        For i = 0 To lstListaEmpleados.SelectedIndices.Count - 1
            Dim indexEmpleado = lstListaEmpleados.SelectedIndices(i)
            Dim empleado As Empleado
            empleado = Form_Lista(indexEmpleado)
            listaEliminar.Add(empleado)

        Next
        While lstListaEmpleados.SelectedItems.Count > 0
            lstListaEmpleados.Items.Remove(lstListaEmpleados.SelectedItems(0))
        End While
        EmpleadosCRUD.Eliminar(listaEliminar)

    End Sub

    Private Sub btnAlta_Click(sender As Object, e As EventArgs) Handles btnAlta.Click
        Dim MdiPrincipal As MDI_Principal
        MdiPrincipal = CType(Me.MdiParent, MDI_Principal)
        MdiPrincipal.AbrirAlta()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim Form_Actualizar As MdiParent
        Form_Actualizar = CType(MDI_Principal)
        Form_Actualizar.AbrirModificar()

        Dim listamodificar As New List(Of Empleado)
        For i = 0 To lstListaEmpleados.SelectedIndices.Count - 1
            Dim indexEmpleado = lstListaEmpleados.SelectedIndices(i)
            Dim empleado As Empleado
            empleado = Form_Lista(indexEmpleado)


        Next
        While lstListaEmpleados.SelectedItems.Count > 0
            lstListaEmpleados.Items.Remove(lstListaEmpleados.SelectedItems(0))
        End While
        EmpleadosCRUD.Actualizar(listamodificar)

    End Sub
End Class

Friend Class MdiParent
    Friend Sub AbrirModificar()
        Throw New NotImplementedException()
    End Sub
End Class
