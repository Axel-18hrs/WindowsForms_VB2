<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnEnviar = New System.Windows.Forms.Button()
        Me.nudCantidadContactos = New System.Windows.Forms.NumericUpDown()
        Me.lblTitulo1 = New System.Windows.Forms.Label()
        Me.pnlEsscrituraDatos = New System.Windows.Forms.Panel()
        Me.btnEnviarDatos = New System.Windows.Forms.Button()
        Me.dtpFechaNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.txtNumeroTelefono = New System.Windows.Forms.TextBox()
        Me.txtApMaterno = New System.Windows.Forms.TextBox()
        Me.txtApPaterno = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlFormularioOrganizado = New System.Windows.Forms.Panel()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.dgvDatosFormulario = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumeroTelefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaNacimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Edad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider2 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider3 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider4 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.nudCantidadContactos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlEsscrituraDatos.SuspendLayout()
        Me.pnlFormularioOrganizado.SuspendLayout()
        CType(Me.dgvDatosFormulario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.btnEnviar)
        Me.Panel1.Controls.Add(Me.nudCantidadContactos)
        Me.Panel1.Controls.Add(Me.lblTitulo1)
        Me.Panel1.Location = New System.Drawing.Point(-3, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1490, 716)
        Me.Panel1.TabIndex = 0
        '
        'btnEnviar
        '
        Me.btnEnviar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnviar.Location = New System.Drawing.Point(676, 396)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(174, 56)
        Me.btnEnviar.TabIndex = 2
        Me.btnEnviar.Text = "Enviar"
        Me.btnEnviar.UseVisualStyleBackColor = True
        '
        'nudCantidadContactos
        '
        Me.nudCantidadContactos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nudCantidadContactos.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudCantidadContactos.Location = New System.Drawing.Point(631, 344)
        Me.nudCantidadContactos.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudCantidadContactos.Name = "nudCantidadContactos"
        Me.nudCantidadContactos.Size = New System.Drawing.Size(257, 32)
        Me.nudCantidadContactos.TabIndex = 1
        Me.nudCantidadContactos.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblTitulo1
        '
        Me.lblTitulo1.AutoSize = True
        Me.lblTitulo1.BackColor = System.Drawing.Color.Transparent
        Me.lblTitulo1.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo1.ForeColor = System.Drawing.Color.White
        Me.lblTitulo1.Location = New System.Drawing.Point(441, 237)
        Me.lblTitulo1.Name = "lblTitulo1"
        Me.lblTitulo1.Size = New System.Drawing.Size(636, 37)
        Me.lblTitulo1.TabIndex = 0
        Me.lblTitulo1.Text = "Ingrese la cantidad de usuarios que desea"
        '
        'pnlEsscrituraDatos
        '
        Me.pnlEsscrituraDatos.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.pnlEsscrituraDatos.Controls.Add(Me.btnEnviarDatos)
        Me.pnlEsscrituraDatos.Controls.Add(Me.dtpFechaNacimiento)
        Me.pnlEsscrituraDatos.Controls.Add(Me.txtNumeroTelefono)
        Me.pnlEsscrituraDatos.Controls.Add(Me.txtApMaterno)
        Me.pnlEsscrituraDatos.Controls.Add(Me.txtApPaterno)
        Me.pnlEsscrituraDatos.Controls.Add(Me.txtNombre)
        Me.pnlEsscrituraDatos.Controls.Add(Me.Label5)
        Me.pnlEsscrituraDatos.Controls.Add(Me.Label4)
        Me.pnlEsscrituraDatos.Controls.Add(Me.Label3)
        Me.pnlEsscrituraDatos.Controls.Add(Me.Label2)
        Me.pnlEsscrituraDatos.Controls.Add(Me.Label1)
        Me.pnlEsscrituraDatos.Location = New System.Drawing.Point(907, 0)
        Me.pnlEsscrituraDatos.Name = "pnlEsscrituraDatos"
        Me.pnlEsscrituraDatos.Size = New System.Drawing.Size(583, 654)
        Me.pnlEsscrituraDatos.TabIndex = 1
        '
        'btnEnviarDatos
        '
        Me.btnEnviarDatos.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnviarDatos.Location = New System.Drawing.Point(380, 260)
        Me.btnEnviarDatos.Name = "btnEnviarDatos"
        Me.btnEnviarDatos.Size = New System.Drawing.Size(174, 56)
        Me.btnEnviarDatos.TabIndex = 10
        Me.btnEnviarDatos.Text = "Enviar"
        Me.btnEnviarDatos.UseVisualStyleBackColor = True
        '
        'dtpFechaNacimiento
        '
        Me.dtpFechaNacimiento.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaNacimiento.Location = New System.Drawing.Point(255, 205)
        Me.dtpFechaNacimiento.Name = "dtpFechaNacimiento"
        Me.dtpFechaNacimiento.Size = New System.Drawing.Size(299, 32)
        Me.dtpFechaNacimiento.TabIndex = 9
        Me.dtpFechaNacimiento.Value = New Date(2023, 2, 28, 0, 0, 0, 0)
        '
        'txtNumeroTelefono
        '
        Me.txtNumeroTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNumeroTelefono.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumeroTelefono.Location = New System.Drawing.Point(256, 166)
        Me.txtNumeroTelefono.Name = "txtNumeroTelefono"
        Me.txtNumeroTelefono.Size = New System.Drawing.Size(298, 32)
        Me.txtNumeroTelefono.TabIndex = 8
        '
        'txtApMaterno
        '
        Me.txtApMaterno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtApMaterno.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApMaterno.Location = New System.Drawing.Point(256, 127)
        Me.txtApMaterno.Name = "txtApMaterno"
        Me.txtApMaterno.Size = New System.Drawing.Size(298, 32)
        Me.txtApMaterno.TabIndex = 7
        '
        'txtApPaterno
        '
        Me.txtApPaterno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtApPaterno.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApPaterno.Location = New System.Drawing.Point(256, 87)
        Me.txtApPaterno.Name = "txtApPaterno"
        Me.txtApPaterno.Size = New System.Drawing.Size(298, 32)
        Me.txtApPaterno.TabIndex = 6
        '
        'txtNombre
        '
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombre.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(256, 48)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(298, 32)
        Me.txtNombre.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(25, 214)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(220, 23)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Fecha de nacimiento"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(25, 175)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(209, 23)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Numero de telefono"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(27, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(182, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Apellido materno"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(25, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(177, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Apellido paterno"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(27, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'pnlFormularioOrganizado
        '
        Me.pnlFormularioOrganizado.BackColor = System.Drawing.Color.Transparent
        Me.pnlFormularioOrganizado.Controls.Add(Me.btnGuardar)
        Me.pnlFormularioOrganizado.Controls.Add(Me.btnEliminar)
        Me.pnlFormularioOrganizado.Controls.Add(Me.dgvDatosFormulario)
        Me.pnlFormularioOrganizado.Location = New System.Drawing.Point(-3, 48)
        Me.pnlFormularioOrganizado.Name = "pnlFormularioOrganizado"
        Me.pnlFormularioOrganizado.Size = New System.Drawing.Size(904, 547)
        Me.pnlFormularioOrganizado.TabIndex = 2
        '
        'btnGuardar
        '
        Me.btnGuardar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Location = New System.Drawing.Point(7, 474)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(174, 56)
        Me.btnGuardar.TabIndex = 12
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.Transparent
        Me.btnEliminar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Location = New System.Drawing.Point(201, 474)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(174, 56)
        Me.btnEliminar.TabIndex = 11
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'dgvDatosFormulario
        '
        Me.dgvDatosFormulario.AllowUserToAddRows = False
        Me.dgvDatosFormulario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvDatosFormulario.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvDatosFormulario.BackgroundColor = System.Drawing.Color.MediumSeaGreen
        Me.dgvDatosFormulario.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvDatosFormulario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDatosFormulario.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvDatosFormulario.ColumnHeadersHeight = 60
        Me.dgvDatosFormulario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvDatosFormulario.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Nombre, Me.NumeroTelefono, Me.FechaNacimiento, Me.Edad})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.LawnGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Goldenrod
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDatosFormulario.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvDatosFormulario.EnableHeadersVisualStyles = False
        Me.dgvDatosFormulario.GridColor = System.Drawing.Color.YellowGreen
        Me.dgvDatosFormulario.Location = New System.Drawing.Point(7, 24)
        Me.dgvDatosFormulario.Name = "dgvDatosFormulario"
        Me.dgvDatosFormulario.ReadOnly = True
        Me.dgvDatosFormulario.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDatosFormulario.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvDatosFormulario.RowHeadersVisible = False
        Me.dgvDatosFormulario.RowHeadersWidth = 51
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.CadetBlue
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkKhaki
        Me.dgvDatosFormulario.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvDatosFormulario.RowTemplate.Height = 24
        Me.dgvDatosFormulario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDatosFormulario.Size = New System.Drawing.Size(873, 444)
        Me.dgvDatosFormulario.TabIndex = 0
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.MinimumWidth = 6
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Width = 55
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.MinimumWidth = 6
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        Me.Nombre.Width = 108
        '
        'NumeroTelefono
        '
        Me.NumeroTelefono.HeaderText = "Numero de telefono"
        Me.NumeroTelefono.MinimumWidth = 6
        Me.NumeroTelefono.Name = "NumeroTelefono"
        Me.NumeroTelefono.ReadOnly = True
        Me.NumeroTelefono.Width = 197
        '
        'FechaNacimiento
        '
        Me.FechaNacimiento.HeaderText = "Fecha de nacimiento"
        Me.FechaNacimiento.MinimumWidth = 6
        Me.FechaNacimiento.Name = "FechaNacimiento"
        Me.FechaNacimiento.ReadOnly = True
        Me.FechaNacimiento.Width = 207
        '
        'Edad
        '
        Me.Edad.HeaderText = "Edad"
        Me.Edad.MinimumWidth = 6
        Me.Edad.Name = "Edad"
        Me.Edad.ReadOnly = True
        Me.Edad.Width = 83
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'ErrorProvider2
        '
        Me.ErrorProvider2.ContainerControl = Me
        '
        'ErrorProvider3
        '
        Me.ErrorProvider3.ContainerControl = Me
        '
        'ErrorProvider4
        '
        Me.ErrorProvider4.ContainerControl = Me
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1484, 641)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlFormularioOrganizado)
        Me.Controls.Add(Me.pnlEsscrituraDatos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Formulario generico"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.nudCantidadContactos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlEsscrituraDatos.ResumeLayout(False)
        Me.pnlEsscrituraDatos.PerformLayout()
        Me.pnlFormularioOrganizado.ResumeLayout(False)
        CType(Me.dgvDatosFormulario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblTitulo1 As Label
    Friend WithEvents btnEnviar As Button
    Friend WithEvents nudCantidadContactos As NumericUpDown
    Friend WithEvents pnlEsscrituraDatos As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpFechaNacimiento As DateTimePicker
    Friend WithEvents txtNumeroTelefono As TextBox
    Friend WithEvents txtApMaterno As TextBox
    Friend WithEvents txtApPaterno As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents btnEnviarDatos As Button
    Friend WithEvents pnlFormularioOrganizado As Panel
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents NumeroTelefono As DataGridViewTextBoxColumn
    Friend WithEvents FechaNacimiento As DataGridViewTextBoxColumn
    Friend WithEvents Edad As DataGridViewTextBoxColumn
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents ErrorProvider2 As ErrorProvider
    Friend WithEvents ErrorProvider3 As ErrorProvider
    Friend WithEvents ErrorProvider4 As ErrorProvider
    Friend WithEvents dgvDatosFormulario As DataGridView
End Class
