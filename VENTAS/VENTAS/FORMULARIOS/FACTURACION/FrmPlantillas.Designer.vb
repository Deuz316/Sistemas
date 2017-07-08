<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPlantillas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPlantillas))
        Dim SuperToolTip2 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem2 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem2 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip3 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem3 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem3 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip4 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem4 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem4 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.btn_busqueda = New DevExpress.XtraEditors.SimpleButton()
        Me.txtf_fin = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtf_ini = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtestado_plantillas = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.detalle_plantillas_guardadas = New System.Windows.Forms.DataGridView()
        Me.SeparatorControl2 = New DevExpress.XtraEditors.SeparatorControl()
        Me.SeparatorControl1 = New DevExpress.XtraEditors.SeparatorControl()
        CType(Me.txtf_fin.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtf_fin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtf_ini.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtf_ini.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtestado_plantillas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.detalle_plantillas_guardadas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeparatorControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeparatorControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl5.Location = New System.Drawing.Point(674, 40)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(60, 13)
        Me.LabelControl5.TabIndex = 18
        Me.LabelControl5.Text = "0000000000"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(602, 40)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(66, 13)
        Me.LabelControl4.TabIndex = 17
        Me.LabelControl4.Text = "N° Plantillas : "
        '
        'btn_busqueda
        '
        Me.btn_busqueda.Image = CType(resources.GetObject("btn_busqueda.Image"), System.Drawing.Image)
        Me.btn_busqueda.Location = New System.Drawing.Point(422, 31)
        Me.btn_busqueda.Name = "btn_busqueda"
        Me.btn_busqueda.Size = New System.Drawing.Size(75, 23)
        ToolTipTitleItem2.Text = "Facturacion"
        ToolTipItem2.LeftIndent = 6
        ToolTipItem2.Text = "Estado "
        SuperToolTip2.Items.Add(ToolTipTitleItem2)
        SuperToolTip2.Items.Add(ToolTipItem2)
        Me.btn_busqueda.SuperTip = SuperToolTip2
        Me.btn_busqueda.TabIndex = 12
        Me.btn_busqueda.Text = "Buscar"
        Me.btn_busqueda.ToolTip = "Busqueda"
        '
        'txtf_fin
        '
        Me.txtf_fin.EditValue = New Date(2017, 5, 3, 14, 29, 6, 574)
        Me.txtf_fin.EnterMoveNextControl = True
        Me.txtf_fin.Location = New System.Drawing.Point(274, 8)
        Me.txtf_fin.Name = "txtf_fin"
        Me.txtf_fin.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtf_fin.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtf_fin.Size = New System.Drawing.Size(142, 20)
        ToolTipTitleItem3.Text = "Facturacion"
        ToolTipItem3.LeftIndent = 6
        ToolTipItem3.Text = "Periodo Final"
        SuperToolTip3.Items.Add(ToolTipTitleItem3)
        SuperToolTip3.Items.Add(ToolTipItem3)
        Me.txtf_fin.SuperTip = SuperToolTip3
        Me.txtf_fin.TabIndex = 10
        Me.txtf_fin.ToolTip = "Periodo Final"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(260, 11)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(8, 13)
        Me.LabelControl3.TabIndex = 19
        Me.LabelControl3.Text = "al"
        '
        'txtf_ini
        '
        Me.txtf_ini.EditValue = New Date(2017, 5, 3, 14, 29, 0, 230)
        Me.txtf_ini.EnterMoveNextControl = True
        Me.txtf_ini.Location = New System.Drawing.Point(112, 8)
        Me.txtf_ini.Name = "txtf_ini"
        Me.txtf_ini.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtf_ini.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtf_ini.Size = New System.Drawing.Size(142, 20)
        ToolTipTitleItem4.Text = "Facturacion"
        ToolTipItem4.LeftIndent = 6
        ToolTipItem4.Text = "Periodo Inicial"
        SuperToolTip4.Items.Add(ToolTipTitleItem4)
        SuperToolTip4.Items.Add(ToolTipItem4)
        Me.txtf_ini.SuperTip = SuperToolTip4
        Me.txtf_ini.TabIndex = 9
        Me.txtf_ini.ToolTip = "Periodo Inicial"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(18, 11)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(88, 13)
        Me.LabelControl2.TabIndex = 15
        Me.LabelControl2.Text = "Rango de Fecha : "
        '
        'txtestado_plantillas
        '
        Me.txtestado_plantillas.EnterMoveNextControl = True
        Me.txtestado_plantillas.Location = New System.Drawing.Point(112, 33)
        Me.txtestado_plantillas.Name = "txtestado_plantillas"
        Me.txtestado_plantillas.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtestado_plantillas.Properties.Items.AddRange(New Object() {"Guardado", "Facturado", "Pendiente de Facturar", "No Facturado", "Pendiente de Autorizar", "Vencido"})
        Me.txtestado_plantillas.Properties.NullValuePrompt = "Estado de Plantillas"
        Me.txtestado_plantillas.Size = New System.Drawing.Size(304, 20)
        Me.txtestado_plantillas.TabIndex = 11
        Me.txtestado_plantillas.ToolTip = "Estado de Plantillas"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(24, 37)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(82, 13)
        Me.LabelControl1.TabIndex = 13
        Me.LabelControl1.Text = "Estado Plantilla : "
        '
        'detalle_plantillas_guardadas
        '
        Me.detalle_plantillas_guardadas.AllowUserToAddRows = False
        Me.detalle_plantillas_guardadas.AllowUserToDeleteRows = False
        Me.detalle_plantillas_guardadas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.detalle_plantillas_guardadas.BackgroundColor = System.Drawing.SystemColors.Info
        Me.detalle_plantillas_guardadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.detalle_plantillas_guardadas.GridColor = System.Drawing.SystemColors.Info
        Me.detalle_plantillas_guardadas.Location = New System.Drawing.Point(10, 89)
        Me.detalle_plantillas_guardadas.Name = "detalle_plantillas_guardadas"
        Me.detalle_plantillas_guardadas.ReadOnly = True
        Me.detalle_plantillas_guardadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.detalle_plantillas_guardadas.Size = New System.Drawing.Size(760, 313)
        Me.detalle_plantillas_guardadas.TabIndex = 14
        '
        'SeparatorControl2
        '
        Me.SeparatorControl2.Location = New System.Drawing.Point(10, 408)
        Me.SeparatorControl2.Name = "SeparatorControl2"
        Me.SeparatorControl2.Size = New System.Drawing.Size(760, 23)
        Me.SeparatorControl2.TabIndex = 20
        '
        'SeparatorControl1
        '
        Me.SeparatorControl1.Location = New System.Drawing.Point(15, 60)
        Me.SeparatorControl1.Name = "SeparatorControl1"
        Me.SeparatorControl1.Size = New System.Drawing.Size(760, 23)
        Me.SeparatorControl1.TabIndex = 16
        '
        'FrmPlantillas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(784, 439)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.btn_busqueda)
        Me.Controls.Add(Me.txtf_fin)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.txtf_ini)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.txtestado_plantillas)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.detalle_plantillas_guardadas)
        Me.Controls.Add(Me.SeparatorControl2)
        Me.Controls.Add(Me.SeparatorControl1)
        Me.Name = "FrmPlantillas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listado Plantillas Administrativas"
        CType(Me.txtf_fin.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtf_fin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtf_ini.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtf_ini.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtestado_plantillas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.detalle_plantillas_guardadas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeparatorControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeparatorControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_busqueda As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtf_fin As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtf_ini As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtestado_plantillas As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents detalle_plantillas_guardadas As DataGridView
    Friend WithEvents SeparatorControl2 As DevExpress.XtraEditors.SeparatorControl
    Friend WithEvents SeparatorControl1 As DevExpress.XtraEditors.SeparatorControl
End Class
