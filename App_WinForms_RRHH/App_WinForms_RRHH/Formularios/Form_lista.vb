Imports App_WinForms_RRHH
Imports App_WinForms_RRHH.Modelo
Public Class Form_lista
    Public listaEmpleados As List(Of Empleado)
    Private Sub cmbNombre_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbNombre.SelectedIndexChanged
        BuscarEmpleado()
    End Sub

    Private Sub cmbNombre_TextChanged(sender As Object, e As EventArgs) _
        Handles cmbNombre.TextChanged, cmbAplellidos.TextChanged
        BuscarEmpleado()

    End Sub

    Private Sub BuscarEmpleado()


        lstListaEmpleados.Items.Clear()
        listaEmpleados = EmpleadosCRUD.BuscarEmpleados(cmbNombre.Text, cmbAplellidos.Text)

        For Each empleado As Empleado In listaEmpleados
            lstListaEmpleados.Items.Add(empleado.nombre & "" & empleado.apellidos)
        Next


    End Sub

    Private Sub Form_lista_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Shared Widening Operator CType(v As Form_lista) As Form_lista
        Throw New NotImplementedException()
    End Operator
End Class
