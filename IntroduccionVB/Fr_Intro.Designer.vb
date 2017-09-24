<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fr_Intro
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
        Me.Btn_Hola = New System.Windows.Forms.Button()
        Me.Lbl_Hola = New System.Windows.Forms.Label()
        Me.Txt_Valor_uno = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Txt_Valor_Dos = New System.Windows.Forms.TextBox()
        Me.Btn_Suma = New System.Windows.Forms.Button()
        Me.Btn_Resta = New System.Windows.Forms.Button()
        Me.Btn_Multiplicacion = New System.Windows.Forms.Button()
        Me.Btn_Division = New System.Windows.Forms.Button()
        Me.Txt_Resultado = New System.Windows.Forms.TextBox()
        Me.Dgv_Datos = New System.Windows.Forms.DataGridView()
        Me.OperacionC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ResultadoC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.Dgv_Datos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Btn_Hola
        '
        Me.Btn_Hola.Location = New System.Drawing.Point(267, 102)
        Me.Btn_Hola.Name = "Btn_Hola"
        Me.Btn_Hola.Size = New System.Drawing.Size(144, 43)
        Me.Btn_Hola.TabIndex = 0
        Me.Btn_Hola.Text = "Presioname!"
        Me.Btn_Hola.UseVisualStyleBackColor = True
        '
        'Lbl_Hola
        '
        Me.Lbl_Hola.AutoSize = True
        Me.Lbl_Hola.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Hola.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Lbl_Hola.Location = New System.Drawing.Point(285, 53)
        Me.Lbl_Hola.Name = "Lbl_Hola"
        Me.Lbl_Hola.Size = New System.Drawing.Size(113, 23)
        Me.Lbl_Hola.TabIndex = 1
        Me.Lbl_Hola.Text = "Hola Mundo!"
        '
        'Txt_Valor_uno
        '
        Me.Txt_Valor_uno.Location = New System.Drawing.Point(233, 194)
        Me.Txt_Valor_uno.Name = "Txt_Valor_uno"
        Me.Txt_Valor_uno.Size = New System.Drawing.Size(132, 20)
        Me.Txt_Valor_uno.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(139, 194)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Ingresa el valor 1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(139, 244)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Ingresa el valor 2"
        '
        'Txt_Valor_Dos
        '
        Me.Txt_Valor_Dos.Location = New System.Drawing.Point(233, 237)
        Me.Txt_Valor_Dos.Name = "Txt_Valor_Dos"
        Me.Txt_Valor_Dos.Size = New System.Drawing.Size(132, 20)
        Me.Txt_Valor_Dos.TabIndex = 6
        '
        'Btn_Suma
        '
        Me.Btn_Suma.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Suma.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Btn_Suma.Location = New System.Drawing.Point(371, 210)
        Me.Btn_Suma.Name = "Btn_Suma"
        Me.Btn_Suma.Size = New System.Drawing.Size(40, 40)
        Me.Btn_Suma.TabIndex = 7
        Me.Btn_Suma.Text = "+"
        Me.Btn_Suma.UseVisualStyleBackColor = True
        '
        'Btn_Resta
        '
        Me.Btn_Resta.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Resta.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Btn_Resta.Location = New System.Drawing.Point(417, 210)
        Me.Btn_Resta.Name = "Btn_Resta"
        Me.Btn_Resta.Size = New System.Drawing.Size(40, 40)
        Me.Btn_Resta.TabIndex = 8
        Me.Btn_Resta.Text = "-"
        Me.Btn_Resta.UseVisualStyleBackColor = True
        '
        'Btn_Multiplicacion
        '
        Me.Btn_Multiplicacion.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Multiplicacion.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Btn_Multiplicacion.Location = New System.Drawing.Point(463, 210)
        Me.Btn_Multiplicacion.Name = "Btn_Multiplicacion"
        Me.Btn_Multiplicacion.Size = New System.Drawing.Size(40, 40)
        Me.Btn_Multiplicacion.TabIndex = 9
        Me.Btn_Multiplicacion.Text = "x"
        Me.Btn_Multiplicacion.UseVisualStyleBackColor = True
        '
        'Btn_Division
        '
        Me.Btn_Division.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Division.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Btn_Division.Location = New System.Drawing.Point(509, 210)
        Me.Btn_Division.Name = "Btn_Division"
        Me.Btn_Division.Size = New System.Drawing.Size(40, 40)
        Me.Btn_Division.TabIndex = 10
        Me.Btn_Division.Text = "/"
        Me.Btn_Division.UseVisualStyleBackColor = True
        '
        'Txt_Resultado
        '
        Me.Txt_Resultado.Location = New System.Drawing.Point(233, 289)
        Me.Txt_Resultado.Name = "Txt_Resultado"
        Me.Txt_Resultado.ReadOnly = True
        Me.Txt_Resultado.Size = New System.Drawing.Size(132, 20)
        Me.Txt_Resultado.TabIndex = 11
        '
        'Dgv_Datos
        '
        Me.Dgv_Datos.AllowUserToAddRows = False
        Me.Dgv_Datos.AllowUserToDeleteRows = False
        Me.Dgv_Datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_Datos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.OperacionC, Me.ResultadoC})
        Me.Dgv_Datos.Location = New System.Drawing.Point(657, 68)
        Me.Dgv_Datos.Name = "Dgv_Datos"
        Me.Dgv_Datos.ReadOnly = True
        Me.Dgv_Datos.Size = New System.Drawing.Size(497, 257)
        Me.Dgv_Datos.TabIndex = 12
        '
        'OperacionC
        '
        Me.OperacionC.HeaderText = "OperacionC"
        Me.OperacionC.Name = "OperacionC"
        Me.OperacionC.ReadOnly = True
        '
        'ResultadoC
        '
        Me.ResultadoC.HeaderText = "ResultadoC"
        Me.ResultadoC.Name = "ResultadoC"
        Me.ResultadoC.ReadOnly = True
        '
        'Fr_Intro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1251, 387)
        Me.Controls.Add(Me.Dgv_Datos)
        Me.Controls.Add(Me.Txt_Resultado)
        Me.Controls.Add(Me.Btn_Division)
        Me.Controls.Add(Me.Btn_Multiplicacion)
        Me.Controls.Add(Me.Btn_Resta)
        Me.Controls.Add(Me.Btn_Suma)
        Me.Controls.Add(Me.Txt_Valor_Dos)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Txt_Valor_uno)
        Me.Controls.Add(Me.Lbl_Hola)
        Me.Controls.Add(Me.Btn_Hola)
        Me.Name = "Fr_Intro"
        Me.Text = "Formulario Básico"
        CType(Me.Dgv_Datos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_Hola As Button
    Friend WithEvents Lbl_Hola As Label
    Friend WithEvents Txt_Valor_uno As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Txt_Valor_Dos As TextBox
    Friend WithEvents Btn_Suma As Button
    Friend WithEvents Btn_Resta As Button
    Friend WithEvents Btn_Multiplicacion As Button
    Friend WithEvents Btn_Division As Button
    Friend WithEvents Txt_Resultado As TextBox
    Friend WithEvents Dgv_Datos As DataGridView
    Friend WithEvents OperacionC As DataGridViewTextBoxColumn
    Friend WithEvents ResultadoC As DataGridViewTextBoxColumn
End Class
