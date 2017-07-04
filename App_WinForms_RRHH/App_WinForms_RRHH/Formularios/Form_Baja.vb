Imports App_WinForms_RRHH.Modelo
Public Class Form_baja
    Private frmLista As Form_lista


    Public Sub AlActivarseFormulario(sender As Object, e As EventArgs) _
        Handles Me.Activated

        Me.MdiParent.Text = "Baja empleado"
    End Sub
    Public Sub AlDesactivarseFormulario(sender As Object, e As EventArgs) _
        Handles Me.Deactivate

        Me.MdiParent.Text = "Aplicación empleados"
    End Sub

    Private Sub btnDarBaja_Click(sender As Object, e As EventArgs) Handles btnDarBaja.Click
        EmpleadosCRUD.Eliminar(frmLista.listaEmpleados)

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        'frmLista.MdiParent = Me.MdiParent
        frmLista.ShowDialog(Me)
        lstEmpleados.Items.Clear()
        lstEmpleados.Items.AddRange(frmLista.lstListaEmpleados.Items)

    End Sub
End Class