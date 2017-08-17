Public Class FrmFacturacion
    Private Sub FrmFacturacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FrmMenu.RibbonPageGroup2.Visible = True
        txt_autocomplete("SELECT P.PRODUCTO + ' - ' +M.NOMBRE'PRODUCTO' FROM PRODUCTOS P INNER JOIN MARCA M ON P.MARCA = M.ID_MARCA", "PRODUCTO", txtbusqueda)
    End Sub

    Private Sub FrmFacturacion_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        FrmMenu.RibbonPageGroup2.Visible = False
    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        cargar_formulario(FrmPeb, 1)
    End Sub

    Private Sub txtbusqueda_KeyDown(sender As Object, e As KeyEventArgs) Handles txtbusqueda.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                cargar_formulario(FrmPeb, 1)
        End Select
    End Sub

    Private Sub btn_exonerar_iva_Click(sender As Object, e As EventArgs) Handles btn_exonerar_iva.Click
        cargar_formulario(FrmExonerarImpuesto, 1)
    End Sub

    Private Sub btn_buscar_cliente_Click(sender As Object, e As EventArgs) Handles btn_buscar_cliente.Click
        cargar_formulario(FrmClientes, 1)
    End Sub
End Class