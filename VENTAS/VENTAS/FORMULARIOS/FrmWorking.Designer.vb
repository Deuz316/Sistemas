<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmWorking
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btn_importar = New DevExpress.XtraEditors.SimpleButton()
        Me.barra_estado_importacion = New System.Windows.Forms.ProgressBar()
        Me.btn_salir = New DevExpress.XtraEditors.SimpleButton()
        Me.cbo_opciones_importacion = New DevExpress.XtraEditors.ComboBoxEdit()
        CType(Me.cbo_opciones_importacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_importar
        '
        Me.btn_importar.Location = New System.Drawing.Point(200, 61)
        Me.btn_importar.Name = "btn_importar"
        Me.btn_importar.Size = New System.Drawing.Size(75, 23)
        Me.btn_importar.TabIndex = 0
        Me.btn_importar.Text = "Importar"
        '
        'barra_estado_importacion
        '
        Me.barra_estado_importacion.Location = New System.Drawing.Point(12, 38)
        Me.barra_estado_importacion.Maximum = 999999999
        Me.barra_estado_importacion.Name = "barra_estado_importacion"
        Me.barra_estado_importacion.Size = New System.Drawing.Size(437, 17)
        Me.barra_estado_importacion.TabIndex = 1
        '
        'btn_salir
        '
        Me.btn_salir.Location = New System.Drawing.Point(200, 61)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(75, 23)
        Me.btn_salir.TabIndex = 3
        Me.btn_salir.Text = "Salir"
        Me.btn_salir.Visible = False
        '
        'cbo_opciones_importacion
        '
        Me.cbo_opciones_importacion.Location = New System.Drawing.Point(12, 12)
        Me.cbo_opciones_importacion.Name = "cbo_opciones_importacion"
        Me.cbo_opciones_importacion.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbo_opciones_importacion.Properties.Items.AddRange(New Object() {"Catalogo de Productos", "Historico de Ventas", "Historico de Importaciones"})
        Me.cbo_opciones_importacion.Properties.NullValuePrompt = "Seleccionar Tipo"
        Me.cbo_opciones_importacion.Properties.NullValuePromptShowForEmptyValue = True
        Me.cbo_opciones_importacion.Size = New System.Drawing.Size(437, 20)
        Me.cbo_opciones_importacion.TabIndex = 4
        '
        'FrmWorking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(461, 91)
        Me.Controls.Add(Me.cbo_opciones_importacion)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.barra_estado_importacion)
        Me.Controls.Add(Me.btn_importar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmWorking"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.cbo_opciones_importacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_importar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents barra_estado_importacion As ProgressBar
    Friend WithEvents btn_salir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cbo_opciones_importacion As DevExpress.XtraEditors.ComboBoxEdit
End Class
