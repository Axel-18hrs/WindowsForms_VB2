Imports System.Diagnostics.Eventing
Imports System.IO
Imports System.Windows.Forms.LinkLabel

Public Class Form1

    Private nn As Integer
    Private personas(999) As Contacto
    Private leerArchivo As StreamReader
    Private escribirArchivo As StreamWriter
    Private ruta As SaveFileDialog

    ' constructor de clase
    Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        'form1.designer
        nn = 0
    End Sub

    ' destructor de clase
    Protected Overrides Sub Finalize()
        leerArchivo.Close()

        escribirArchivo.Close()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' demasiado claro para explicar
        If Not File.Exists(My.Settings.Archivo) Then
            pnlFormularioOrganizado.Visible = False
            Return
        End If
        Using leerArchivo = New StreamReader(My.Settings.Archivo)
            While Not leerArchivo.EndOfStream
                Dim line As String = leerArchivo.ReadLine()
                Dim values() As String = line.Split(vbTab)
                dgvDatosFormulario.Rows.Add(values)
            End While

        End Using
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        ' si el archivo no existe o mas bien no se a creado en una sesion anterior, lo vamos a crear
        If Not File.Exists(My.Settings.Archivo) Then
            ruta = New SaveFileDialog With {
                .Filter = "txt files (*.txt) | *.txt | All files (*.*) | *.*",
                .Title = "Guardando tus datos"
            }

            If (ruta.ShowDialog() = DialogResult.Cancel) Then
                MessageBox.Show("Error al escoger la ruta de archivo. ", "Error", MessageBoxButtons.OK)
                Return
            End If

            ' conservamos la ruta del archivo haciendo uso de las propiedades personalizadas y la clase settings
            My.Settings.Archivo = ruta.FileName
            My.Settings.Save()
        End If

        Using escribirArchivo = New StreamWriter(My.Settings.Archivo)

            For Each fila As DataGridViewRow In dgvDatosFormulario.Rows
                For Each celda As DataGridViewCell In fila.Cells
                    escribirArchivo.Write(celda.Value.ToString() & vbTab)
                Next
                escribirArchivo.WriteLine()
            Next
            escribirArchivo.Close()
        End Using
    End Sub

    ' este boton es el que envia los datos al datagridview
    Private Sub btnEnviarDatos_Click(sender As Object, e As EventArgs) Handles btnEnviarDatos.Click

        ' validaciones que generan un ErrorProvider
        If String.IsNullOrEmpty(txtNombre.Text) Or txtNombre.Text = Nothing Then
            ErrorProvider1.SetError(txtNombre, "Debe ingresar un nombre.")
        Else
            ErrorProvider1.Clear()
        End If
        If String.IsNullOrEmpty(txtApPaterno.Text) Or txtApPaterno.Text = Nothing Then
            ErrorProvider2.SetError(txtApPaterno, "Debe ingresar un apellido P.")
        Else
            ErrorProvider2.Clear()
        End If
        If String.IsNullOrEmpty(txtApMaterno.Text) Or txtApMaterno.Text = Nothing Then
            ErrorProvider3.SetError(txtApMaterno, "Debe ingresar un apellido M.")
        Else
            ErrorProvider3.Clear()
        End If
        If String.IsNullOrEmpty(txtNumeroTelefono.Text) Or txtNumeroTelefono.Text = Nothing Then
            ErrorProvider4.SetError(txtNumeroTelefono, "Debe ingresar un numero.")
        Else
            ErrorProvider4.Clear()
        End If

        Dim regex As New Text.RegularExpressions.Regex("^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$")
        If String.IsNullOrEmpty(txtCorreo.Text) Or txtCorreo.Text = Nothing Or Not regex.IsMatch(txtCorreo.Text) Then
            ErrorProvider5.SetError(txtCorreo, "Debe ingresar un numero.")
        Else
            ErrorProvider5.Clear()
        End If
        If String.IsNullOrWhiteSpace(txtNombre.Text) OrElse String.IsNullOrWhiteSpace(txtApPaterno.Text) OrElse String.IsNullOrWhiteSpace(txtApMaterno.Text) OrElse String.IsNullOrWhiteSpace(txtNumeroTelefono.Text) OrElse Not regex.IsMatch(txtCorreo.Text) OrElse String.IsNullOrWhiteSpace(txtCorreo.Text) Then
            MessageBox.Show("Debe ingresar todos los datos correctamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            MessageBox.Show(personas(nn).ToString(), "Ultimo contacto registrado correctamente.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        pnlFormularioOrganizado.Visible = True

        ' le doy memoria a la persona (contacto) desde el primer indice 
        personas(nn) = New Contacto With {
            .Nombre = txtNombre.Text,
            .APPaterno = txtApPaterno.Text,
            .APMaterno = txtApMaterno.Text,
            .Telefono = txtNumeroTelefono.Text,
            .Correo = txtCorreo.Text,
            .FechaNacimiento = dtpFechaNacimiento.Value
        }
        Edad1(personas(nn).Edad)
        Edad1()
        ' parte del programa que se encarga de imprimir los datos en el datagridview
        dgvDatosFormulario.Rows.Add(nn + 1, UCase(personas(nn).Nombre), UCase(personas(nn).APPaterno), UCase(personas(nn).APMaterno), personas(nn).Telefono, personas(nn).Correo, personas(nn).FechaNacimiento, personas(nn).Edad)
        nn += 1

        txtNombre.Clear()
        txtApPaterno.Clear()
        txtApMaterno.Clear()
        txtNumeroTelefono.Clear()
        txtCorreo.Clear()
        dtpFechaNacimiento.ResetText()
    End Sub

    ' este boton eliina la celda seleccionada
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        ' si la cantidad de filas dentro del DGV es mayor que cero se puede seguir eliminando
        If dgvDatosFormulario.Rows.Count > 0 Then

            'Eliminar cada fila seleccionada
            For Each fila As DataGridViewRow In dgvDatosFormulario.SelectedRows
                dgvDatosFormulario.Rows.Remove(fila)
            Next
        Else

            MessageBox.Show("No hay mas elementos que eliminar en este apartado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        ' Verificar si se ha presionado la tecla "Enter".
        If e.KeyCode = Keys.Enter Then
            ' Verificar si el control activo es un TextBox.
            If TypeOf Me.ActiveControl Is TextBox Then
                ' Establecer el enfoque en el siguiente TextBox.
                Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
            End If
        End If

        'If e.KeyCode = Keys.pr Then
    End Sub

    Public Function Edad1(ByVal x As Integer) As Integer
        If x >= 18 Then
            MessageBox.Show("Eres mayor de edad", "Edad", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        If x < 18 Then
            MessageBox.Show("Eres menor de edad", "Edad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Function
    Public Sub Edad1()
        MessageBox.Show("El ser mayor de edad deja menos sospechas en cuanto los datos que proporciones")
    End Sub
End Class