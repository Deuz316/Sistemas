<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmOpciones
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
        Me.ComboBoxEdit1 = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.btnExportar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnImportar = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.ComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBoxEdit1
        '
        Me.ComboBoxEdit1.Location = New System.Drawing.Point(12, 12)
        Me.ComboBoxEdit1.Name = "ComboBoxEdit1"
        Me.ComboBoxEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ComboBoxEdit1.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ComboBoxEdit1.Properties.NullValuePrompt = "Tables Of DataBase"
        Me.ComboBoxEdit1.Properties.NullValuePromptShowForEmptyValue = True
        Me.ComboBoxEdit1.Size = New System.Drawing.Size(406, 20)
        Me.ComboBoxEdit1.TabIndex = 3
        '
        'btnExportar
        '
        Me.btnExportar.Location = New System.Drawing.Point(179, 38)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(75, 23)
        Me.btnExportar.TabIndex = 1
        Me.btnExportar.Text = "Exportar"
        Me.btnExportar.Visible = False
        '
        'btnImportar
        '
        Me.btnImportar.Location = New System.Drawing.Point(179, 38)
        Me.btnImportar.Name = "btnImportar"
        Me.btnImportar.Size = New System.Drawing.Size(75, 23)
        Me.btnImportar.TabIndex = 2
        Me.btnImportar.Text = "Importar"
        Me.btnImportar.Visible = False
        '
        'FrmOpciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(430, 68)
        Me.Controls.Add(Me.btnImportar)
        Me.Controls.Add(Me.btnExportar)
        Me.Controls.Add(Me.ComboBoxEdit1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmOpciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.ComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ComboBoxEdit1 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents btnExportar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnImportar As DevExpress.XtraEditors.SimpleButton
End Class
