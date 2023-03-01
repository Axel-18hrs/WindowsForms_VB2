Imports System.IO

Public Class Form1

    Private nn As Integer = 0
    Private personas(999) As Contacto
    Private cuentasUsuarioL As StreamReader
    Private cuentasUsuario As StreamWriter
    Private ruta As SaveFileDialog
    Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        nn = 0


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlFormularioOrganizado.Visible = False
    End Sub

    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click

        Panel1.Visible = False
    End Sub

    Private Sub btnEnviarDatos_Click(sender As Object, e As EventArgs) Handles btnEnviarDatos.Click
        ' desactivar el boton que envia los datos (en el que estoy ahora comentando) si las filas del DGV son menores a
        ' la cantidad de contactos que deberian existir segun el usuario
        If dgvDatosFormulario.Rows.Count = nudCantidadContactos.Value Then
            btnEnviarDatos.Enabled = False
            Return
        End If

        pnlFormularioOrganizado.Visible = True

        ' le doy memoria a la persona (contacto) desde el primer indice 
        personas(nn) = New Contacto With {
            .Nombre = txtNombre.Text,
            .APPaterno = txtApPaterno.Text,
            .APMaterno = txtApMaterno.Text,
            .Telefono = txtNumeroTelefono.Text,
            .FechaNacimiento = dtpFechaNacimiento.Value
        }

        ' validaciones que generan un ErrorProvider
        If String.IsNullOrEmpty(txtNombre.Text) Or txtNombre.Text = Nothing Then
            ErrorProvider1.SetError(txtNombre, "Debe ingresar un nombre.")
        End If
        If String.IsNullOrEmpty(txtApPaterno.Text) Or txtApPaterno.Text = Nothing Then
            ErrorProvider2.SetError(txtApPaterno, "Debe ingresar un apellido P.")
        End If
        If String.IsNullOrEmpty(txtApMaterno.Text) Or txtApMaterno.Text = Nothing Then
            ErrorProvider3.SetError(txtApMaterno, "Debe ingresar un apellido M.")
        End If
        If String.IsNullOrEmpty(txtNumeroTelefono.Text) Or txtNumeroTelefono.Text = Nothing Then
            ErrorProvider4.SetError(txtNumeroTelefono, "Debe ingresar un numero.")
        End If
        If String.IsNullOrWhiteSpace(txtNombre.Text) OrElse String.IsNullOrWhiteSpace(txtApPaterno.Text) OrElse String.IsNullOrWhiteSpace(txtApMaterno.Text) OrElse String.IsNullOrWhiteSpace(txtNumeroTelefono.Text) Then
            MessageBox.Show("Debe ingresar todos los datos correctamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            ' validaciones para remover los ErrorProvider y desactivar boton txtEnviarDatos
            If Not String.IsNullOrWhiteSpace(txtNombre.Text) Then
                ErrorProvider1.Clear()
            End If
            If Not String.IsNullOrWhiteSpace(txtApPaterno.Text) Then
                ErrorProvider2.Clear()
            End If
            If Not String.IsNullOrWhiteSpace(txtApMaterno.Text) Then
                ErrorProvider3.Clear()
            End If
            If Not String.IsNullOrWhiteSpace(txtNumeroTelefono.Text) Then
                ErrorProvider4.Clear()
            End If
        End If

        ' parte del programa que se encarga de imprimir los datos en el datagridview
        dgvDatosFormulario.Rows.Add(nn + 1, UCase(personas(nn).Nombre & " " & personas(nn).APPaterno & " " & personas(nn).APMaterno), personas(nn).Telefono, personas(nn).FechaNacimiento, personas(nn).Edad)
        nn += 1

        txtNombre.Clear()
        txtApPaterno.Clear()
        txtApMaterno.Clear()
        txtNumeroTelefono.Clear()
        dtpFechaNacimiento.ResetText()
    End Sub

    ' este boton eliina la celda seleccionada
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        ' si la cantidad de filas dentro del DGV es menor que la cantidad de contactos segun el usuario el boton de Enviar datos se reactivara
        If dgvDatosFormulario.Rows.Count < nudCantidadContactos.Value Then
            btnEnviarDatos.Enabled = True
        End If

        ' si la cantidad de filas dentro del DGV es mayor que cero se puede seguir eliminando
        If dgvDatosFormulario.Rows.Count > 0 Then

            dgvDatosFormulario.Rows.RemoveAt(dgvDatosFormulario.CurrentCell.RowIndex)
            Dim firstCellIndex As Integer = dgvDatosFormulario.SelectedRows(0).Cells(0).ColumnIndex
            personas(firstCellIndex) = Nothing
        Else

            MessageBox.Show("No hay mas elementos que eliminar en este apartado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

    End Sub
End Class
