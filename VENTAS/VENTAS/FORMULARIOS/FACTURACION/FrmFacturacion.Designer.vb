<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmFacturacion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmFacturacion))
        Dim SuperToolTip6 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem6 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem6 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem1 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip2 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem2 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem2 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip3 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem3 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem3 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip4 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem4 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem4 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Me.detalle_facturacion = New System.Windows.Forms.GroupBox()
        Me.detalle_busqueda = New System.Windows.Forms.DataGridView()
        Me.btn_buscar = New DevExpress.XtraEditors.SimpleButton()
        Me.detalle_factura = New System.Windows.Forms.DataGridView()
        Me.c_cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c_codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c_descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c_precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c_bodega = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c_costo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c_descuento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c_iva = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c_total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtbusqueda = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.detalle_total = New System.Windows.Forms.GroupBox()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.txtfactor = New DevExpress.XtraEditors.SpinEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.txtutildiad = New DevExpress.XtraEditors.SpinEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.txtcosto = New DevExpress.XtraEditors.SpinEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.txttotal = New DevExpress.XtraEditors.SpinEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txtretencion = New DevExpress.XtraEditors.SpinEdit()
        Me.btn_exonerar_iva = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtiva = New DevExpress.XtraEditors.SpinEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtdescuento = New DevExpress.XtraEditors.SpinEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtsubtotal = New DevExpress.XtraEditors.SpinEdit()
        Me.detalle_cliente = New System.Windows.Forms.GroupBox()
        Me.txtdireccion = New System.Windows.Forms.TextBox()
        Me.btn_buscar_cliente = New DevExpress.XtraEditors.SimpleButton()
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.txtcorreo = New DevExpress.XtraEditors.TextEdit()
        Me.txttelefono = New DevExpress.XtraEditors.TextEdit()
        Me.txtidentificacion = New DevExpress.XtraEditors.TextEdit()
        Me.detalle_facturacion.SuspendLayout()
        CType(Me.detalle_busqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.detalle_factura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtbusqueda.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.detalle_total.SuspendLayout()
        CType(Me.txtfactor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtutildiad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtcosto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txttotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtretencion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtiva.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtdescuento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtsubtotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.detalle_cliente.SuspendLayout()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtcorreo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txttelefono.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtidentificacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'detalle_facturacion
        '
        Me.detalle_facturacion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.detalle_facturacion.Controls.Add(Me.detalle_busqueda)
        Me.detalle_facturacion.Controls.Add(Me.btn_buscar)
        Me.detalle_facturacion.Controls.Add(Me.detalle_factura)
        Me.detalle_facturacion.Controls.Add(Me.txtbusqueda)
        Me.detalle_facturacion.Controls.Add(Me.LabelControl1)
        Me.detalle_facturacion.Location = New System.Drawing.Point(12, 12)
        Me.detalle_facturacion.Name = "detalle_facturacion"
        Me.detalle_facturacion.Size = New System.Drawing.Size(402, 538)
        Me.detalle_facturacion.TabIndex = 7
        Me.detalle_facturacion.TabStop = False
        '
        'detalle_busqueda
        '
        Me.detalle_busqueda.AllowUserToAddRows = False
        Me.detalle_busqueda.AllowUserToDeleteRows = False
        Me.detalle_busqueda.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.detalle_busqueda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.detalle_busqueda.BackgroundColor = System.Drawing.SystemColors.Info
        Me.detalle_busqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.detalle_busqueda.GridColor = System.Drawing.SystemColors.Info
        Me.detalle_busqueda.Location = New System.Drawing.Point(6, 64)
        Me.detalle_busqueda.Name = "detalle_busqueda"
        Me.detalle_busqueda.ReadOnly = True
        Me.detalle_busqueda.RowHeadersVisible = False
        Me.detalle_busqueda.Size = New System.Drawing.Size(390, 468)
        Me.detalle_busqueda.TabIndex = 6
        '
        'btn_buscar
        '
        Me.btn_buscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_buscar.Image = CType(resources.GetObject("btn_buscar.Image"), System.Drawing.Image)
        Me.btn_buscar.Location = New System.Drawing.Point(321, 36)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(75, 23)
        Me.btn_buscar.TabIndex = 1
        Me.btn_buscar.Text = "Busqueda"
        Me.btn_buscar.ToolTip = "Buscar Producto"
        '
        'detalle_factura
        '
        Me.detalle_factura.AllowUserToAddRows = False
        Me.detalle_factura.AllowUserToDeleteRows = False
        Me.detalle_factura.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.detalle_factura.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.detalle_factura.BackgroundColor = System.Drawing.SystemColors.Info
        Me.detalle_factura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.detalle_factura.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.c_cantidad, Me.c_codigo, Me.c_descripcion, Me.c_precio, Me.c_bodega, Me.c_costo, Me.c_descuento, Me.c_iva, Me.c_total})
        Me.detalle_factura.GridColor = System.Drawing.SystemColors.Info
        Me.detalle_factura.Location = New System.Drawing.Point(6, 64)
        Me.detalle_factura.Name = "detalle_factura"
        Me.detalle_factura.ReadOnly = True
        Me.detalle_factura.RowHeadersVisible = False
        Me.detalle_factura.Size = New System.Drawing.Size(390, 468)
        Me.detalle_factura.TabIndex = 3
        '
        'c_cantidad
        '
        Me.c_cantidad.HeaderText = "Cantidad"
        Me.c_cantidad.Name = "c_cantidad"
        Me.c_cantidad.ReadOnly = True
        '
        'c_codigo
        '
        Me.c_codigo.HeaderText = "Codigo"
        Me.c_codigo.Name = "c_codigo"
        Me.c_codigo.ReadOnly = True
        '
        'c_descripcion
        '
        Me.c_descripcion.HeaderText = "Producto"
        Me.c_descripcion.Name = "c_descripcion"
        Me.c_descripcion.ReadOnly = True
        '
        'c_precio
        '
        Me.c_precio.HeaderText = "Precio"
        Me.c_precio.Name = "c_precio"
        Me.c_precio.ReadOnly = True
        '
        'c_bodega
        '
        Me.c_bodega.HeaderText = "Bodega"
        Me.c_bodega.Name = "c_bodega"
        Me.c_bodega.ReadOnly = True
        '
        'c_costo
        '
        Me.c_costo.HeaderText = "Costo"
        Me.c_costo.Name = "c_costo"
        Me.c_costo.ReadOnly = True
        '
        'c_descuento
        '
        Me.c_descuento.HeaderText = "Descuento"
        Me.c_descuento.Name = "c_descuento"
        Me.c_descuento.ReadOnly = True
        '
        'c_iva
        '
        Me.c_iva.HeaderText = "Iva"
        Me.c_iva.Name = "c_iva"
        Me.c_iva.ReadOnly = True
        '
        'c_total
        '
        Me.c_total.HeaderText = "Total"
        Me.c_total.Name = "c_total"
        Me.c_total.ReadOnly = True
        '
        'txtbusqueda
        '
        Me.txtbusqueda.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtbusqueda.EditValue = ""
        Me.txtbusqueda.Location = New System.Drawing.Point(6, 38)
        Me.txtbusqueda.Name = "txtbusqueda"
        Me.txtbusqueda.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtbusqueda.Properties.NullValuePrompt = "Busqueda Producto"
        Me.txtbusqueda.Properties.NullValuePromptShowForEmptyValue = True
        Me.txtbusqueda.Size = New System.Drawing.Size(309, 20)
        ToolTipTitleItem6.Text = "Facturacion"
        ToolTipItem6.LeftIndent = 6
        ToolTipItem6.Text = "Busqueda de Producto"
        SuperToolTip6.Items.Add(ToolTipTitleItem6)
        SuperToolTip6.Items.Add(ToolTipItem6)
        Me.txtbusqueda.SuperTip = SuperToolTip6
        Me.txtbusqueda.TabIndex = 2
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(6, 19)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(83, 13)
        Me.LabelControl1.TabIndex = 5
        Me.LabelControl1.Text = "&Buscar Productos"
        '
        'detalle_total
        '
        Me.detalle_total.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.detalle_total.Controls.Add(Me.LabelControl9)
        Me.detalle_total.Controls.Add(Me.txtfactor)
        Me.detalle_total.Controls.Add(Me.LabelControl8)
        Me.detalle_total.Controls.Add(Me.txtutildiad)
        Me.detalle_total.Controls.Add(Me.LabelControl7)
        Me.detalle_total.Controls.Add(Me.txtcosto)
        Me.detalle_total.Controls.Add(Me.LabelControl6)
        Me.detalle_total.Controls.Add(Me.txttotal)
        Me.detalle_total.Controls.Add(Me.LabelControl5)
        Me.detalle_total.Controls.Add(Me.txtretencion)
        Me.detalle_total.Controls.Add(Me.btn_exonerar_iva)
        Me.detalle_total.Controls.Add(Me.LabelControl4)
        Me.detalle_total.Controls.Add(Me.txtiva)
        Me.detalle_total.Controls.Add(Me.LabelControl3)
        Me.detalle_total.Controls.Add(Me.txtdescuento)
        Me.detalle_total.Controls.Add(Me.LabelControl2)
        Me.detalle_total.Controls.Add(Me.txtsubtotal)
        Me.detalle_total.Location = New System.Drawing.Point(420, 315)
        Me.detalle_total.Name = "detalle_total"
        Me.detalle_total.Size = New System.Drawing.Size(352, 235)
        Me.detalle_total.TabIndex = 6
        Me.detalle_total.TabStop = False
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(92, 205)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(38, 13)
        Me.LabelControl9.TabIndex = 27
        Me.LabelControl9.Text = "&Factor :"
        '
        'txtfactor
        '
        Me.txtfactor.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtfactor.Location = New System.Drawing.Point(136, 202)
        Me.txtfactor.Name = "txtfactor"
        Me.txtfactor.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.txtfactor.Properties.Appearance.Options.UseForeColor = True
        Me.txtfactor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtfactor.Size = New System.Drawing.Size(120, 20)
        Me.txtfactor.TabIndex = 26
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(88, 179)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(42, 13)
        Me.LabelControl8.TabIndex = 25
        Me.LabelControl8.Text = "&Utilidad :"
        '
        'txtutildiad
        '
        Me.txtutildiad.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtutildiad.Location = New System.Drawing.Point(136, 176)
        Me.txtutildiad.Name = "txtutildiad"
        Me.txtutildiad.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.txtutildiad.Properties.Appearance.Options.UseForeColor = True
        Me.txtutildiad.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtutildiad.Size = New System.Drawing.Size(120, 20)
        Me.txtutildiad.TabIndex = 24
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(95, 153)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(35, 13)
        Me.LabelControl7.TabIndex = 23
        Me.LabelControl7.Text = "&Costo :"
        '
        'txtcosto
        '
        Me.txtcosto.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtcosto.Location = New System.Drawing.Point(136, 150)
        Me.txtcosto.Name = "txtcosto"
        Me.txtcosto.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.txtcosto.Properties.Appearance.Options.UseForeColor = True
        Me.txtcosto.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtcosto.Size = New System.Drawing.Size(120, 20)
        Me.txtcosto.TabIndex = 22
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(99, 100)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(31, 13)
        Me.LabelControl6.TabIndex = 21
        Me.LabelControl6.Text = "&Total :"
        '
        'txttotal
        '
        Me.txttotal.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txttotal.Location = New System.Drawing.Point(136, 97)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.txttotal.Properties.Appearance.Options.UseForeColor = True
        Me.txttotal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txttotal.Size = New System.Drawing.Size(120, 20)
        Me.txttotal.TabIndex = 20
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(75, 127)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(55, 13)
        Me.LabelControl5.TabIndex = 19
        Me.LabelControl5.Text = "&Retención :"
        '
        'txtretencion
        '
        Me.txtretencion.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtretencion.Location = New System.Drawing.Point(136, 124)
        Me.txtretencion.Name = "txtretencion"
        Me.txtretencion.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.txtretencion.Properties.Appearance.Options.UseForeColor = True
        Me.txtretencion.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtretencion.Size = New System.Drawing.Size(120, 20)
        Me.txtretencion.TabIndex = 18
        '
        'btn_exonerar_iva
        '
        Me.btn_exonerar_iva.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_exonerar_iva.Image = CType(resources.GetObject("btn_exonerar_iva.Image"), System.Drawing.Image)
        Me.btn_exonerar_iva.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btn_exonerar_iva.Location = New System.Drawing.Point(262, 72)
        Me.btn_exonerar_iva.Name = "btn_exonerar_iva"
        Me.btn_exonerar_iva.Size = New System.Drawing.Size(39, 23)
        Me.btn_exonerar_iva.TabIndex = 16
        Me.btn_exonerar_iva.ToolTip = "Exoneracion de Impuestos"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(107, 74)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(23, 13)
        Me.LabelControl4.TabIndex = 12
        Me.LabelControl4.Text = "&Iva :"
        '
        'txtiva
        '
        Me.txtiva.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtiva.Location = New System.Drawing.Point(136, 71)
        Me.txtiva.Name = "txtiva"
        Me.txtiva.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.txtiva.Properties.Appearance.Options.UseForeColor = True
        Me.txtiva.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtiva.Size = New System.Drawing.Size(120, 20)
        Me.txtiva.TabIndex = 11
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(67, 48)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(63, 13)
        Me.LabelControl3.TabIndex = 9
        Me.LabelControl3.Text = "&Descuentos :"
        '
        'txtdescuento
        '
        Me.txtdescuento.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtdescuento.Location = New System.Drawing.Point(136, 45)
        Me.txtdescuento.Name = "txtdescuento"
        Me.txtdescuento.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.txtdescuento.Properties.Appearance.Options.UseForeColor = True
        Me.txtdescuento.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtdescuento.Size = New System.Drawing.Size(120, 20)
        Me.txtdescuento.TabIndex = 8
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(71, 22)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(59, 13)
        Me.LabelControl2.TabIndex = 6
        Me.LabelControl2.Text = "&Sub - Total :"
        '
        'txtsubtotal
        '
        Me.txtsubtotal.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtsubtotal.Location = New System.Drawing.Point(136, 19)
        Me.txtsubtotal.Name = "txtsubtotal"
        Me.txtsubtotal.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.txtsubtotal.Properties.Appearance.Options.UseForeColor = True
        Me.txtsubtotal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtsubtotal.Size = New System.Drawing.Size(120, 20)
        Me.txtsubtotal.TabIndex = 0
        '
        'detalle_cliente
        '
        Me.detalle_cliente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.detalle_cliente.Controls.Add(Me.txtdireccion)
        Me.detalle_cliente.Controls.Add(Me.btn_buscar_cliente)
        Me.detalle_cliente.Controls.Add(Me.TextEdit1)
        Me.detalle_cliente.Controls.Add(Me.txtcorreo)
        Me.detalle_cliente.Controls.Add(Me.txttelefono)
        Me.detalle_cliente.Controls.Add(Me.txtidentificacion)
        Me.detalle_cliente.Location = New System.Drawing.Point(420, 12)
        Me.detalle_cliente.Name = "detalle_cliente"
        Me.detalle_cliente.Size = New System.Drawing.Size(352, 297)
        Me.detalle_cliente.TabIndex = 5
        Me.detalle_cliente.TabStop = False
        '
        'txtdireccion
        '
        Me.txtdireccion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtdireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdireccion.Location = New System.Drawing.Point(6, 120)
        Me.txtdireccion.Multiline = True
        Me.txtdireccion.Name = "txtdireccion"
        Me.txtdireccion.Size = New System.Drawing.Size(289, 171)
        Me.txtdireccion.TabIndex = 15
        '
        'btn_buscar_cliente
        '
        Me.btn_buscar_cliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_buscar_cliente.Image = CType(resources.GetObject("btn_buscar_cliente.Image"), System.Drawing.Image)
        Me.btn_buscar_cliente.ImageLocation = DevExpress.XtraEditors.ImageLocation.BottomCenter
        Me.btn_buscar_cliente.Location = New System.Drawing.Point(301, 16)
        Me.btn_buscar_cliente.Name = "btn_buscar_cliente"
        Me.btn_buscar_cliente.Size = New System.Drawing.Size(39, 23)
        Me.btn_buscar_cliente.TabIndex = 10
        Me.btn_buscar_cliente.ToolTip = "Busqueda del Cliente"
        '
        'TextEdit1
        '
        Me.TextEdit1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextEdit1.EnterMoveNextControl = True
        Me.TextEdit1.Location = New System.Drawing.Point(6, 16)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextEdit1.Properties.NullValuePrompt = "Cliente"
        Me.TextEdit1.Size = New System.Drawing.Size(289, 20)
        ToolTipTitleItem1.Text = "Facturacion"
        ToolTipItem1.LeftIndent = 6
        ToolTipItem1.Text = "Nombre del Cliente"
        SuperToolTip1.Items.Add(ToolTipTitleItem1)
        SuperToolTip1.Items.Add(ToolTipItem1)
        Me.TextEdit1.SuperTip = SuperToolTip1
        Me.TextEdit1.TabIndex = 11
        '
        'txtcorreo
        '
        Me.txtcorreo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtcorreo.EnterMoveNextControl = True
        Me.txtcorreo.Location = New System.Drawing.Point(6, 94)
        Me.txtcorreo.Name = "txtcorreo"
        Me.txtcorreo.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcorreo.Properties.NullValuePrompt = "Correo"
        Me.txtcorreo.Size = New System.Drawing.Size(289, 20)
        ToolTipTitleItem2.Text = "Facturacion"
        ToolTipItem2.LeftIndent = 6
        ToolTipItem2.Text = "Correo Electronico"
        SuperToolTip2.Items.Add(ToolTipTitleItem2)
        SuperToolTip2.Items.Add(ToolTipItem2)
        Me.txtcorreo.SuperTip = SuperToolTip2
        Me.txtcorreo.TabIndex = 14
        '
        'txttelefono
        '
        Me.txttelefono.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txttelefono.EnterMoveNextControl = True
        Me.txttelefono.Location = New System.Drawing.Point(6, 68)
        Me.txttelefono.Name = "txttelefono"
        Me.txttelefono.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txttelefono.Properties.NullValuePrompt = "Teléfono"
        Me.txttelefono.Size = New System.Drawing.Size(157, 20)
        ToolTipTitleItem3.Text = "Facturacion"
        ToolTipItem3.LeftIndent = 6
        ToolTipItem3.Text = "Telefono Convencional o Celular"
        SuperToolTip3.Items.Add(ToolTipTitleItem3)
        SuperToolTip3.Items.Add(ToolTipItem3)
        Me.txttelefono.SuperTip = SuperToolTip3
        Me.txttelefono.TabIndex = 13
        '
        'txtidentificacion
        '
        Me.txtidentificacion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtidentificacion.EnterMoveNextControl = True
        Me.txtidentificacion.Location = New System.Drawing.Point(6, 42)
        Me.txtidentificacion.Name = "txtidentificacion"
        Me.txtidentificacion.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtidentificacion.Properties.NullValuePrompt = "Identificación"
        Me.txtidentificacion.Size = New System.Drawing.Size(289, 20)
        ToolTipTitleItem4.Text = "Facturacion"
        ToolTipItem4.LeftIndent = 6
        ToolTipItem4.Text = "RUC o Cedula"
        SuperToolTip4.Items.Add(ToolTipTitleItem4)
        SuperToolTip4.Items.Add(ToolTipItem4)
        Me.txtidentificacion.SuperTip = SuperToolTip4
        Me.txtidentificacion.TabIndex = 12
        '
        'FrmFacturacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.detalle_facturacion)
        Me.Controls.Add(Me.detalle_total)
        Me.Controls.Add(Me.detalle_cliente)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmFacturacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Facturacion"
        Me.detalle_facturacion.ResumeLayout(False)
        Me.detalle_facturacion.PerformLayout()
        CType(Me.detalle_busqueda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.detalle_factura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtbusqueda.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.detalle_total.ResumeLayout(False)
        Me.detalle_total.PerformLayout()
        CType(Me.txtfactor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtutildiad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtcosto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txttotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtretencion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtiva.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtdescuento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtsubtotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.detalle_cliente.ResumeLayout(False)
        Me.detalle_cliente.PerformLayout()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtcorreo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txttelefono.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtidentificacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents detalle_facturacion As GroupBox
    Friend WithEvents detalle_busqueda As DataGridView
    Friend WithEvents btn_buscar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents detalle_factura As DataGridView
    Friend WithEvents c_cantidad As DataGridViewTextBoxColumn
    Friend WithEvents c_codigo As DataGridViewTextBoxColumn
    Friend WithEvents c_descripcion As DataGridViewTextBoxColumn
    Friend WithEvents c_precio As DataGridViewTextBoxColumn
    Friend WithEvents c_bodega As DataGridViewTextBoxColumn
    Friend WithEvents c_costo As DataGridViewTextBoxColumn
    Friend WithEvents c_descuento As DataGridViewTextBoxColumn
    Friend WithEvents c_iva As DataGridViewTextBoxColumn
    Friend WithEvents c_total As DataGridViewTextBoxColumn
    Friend WithEvents txtbusqueda As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents detalle_total As GroupBox
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtfactor As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtutildiad As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtcosto As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txttotal As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtretencion As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents btn_exonerar_iva As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtiva As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtdescuento As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtsubtotal As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents detalle_cliente As GroupBox
    Friend WithEvents txtdireccion As TextBox
    Friend WithEvents btn_buscar_cliente As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtcorreo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txttelefono As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtidentificacion As DevExpress.XtraEditors.TextEdit
End Class
