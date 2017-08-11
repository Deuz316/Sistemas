Public Class FrmWorking
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles btn_importar.Click
        Recorrer_DGV(FrmImportar_Excell.Detalle_Importacion)
        btn_salir.Visible = True
        btn_importar.Visible = False
    End Sub

    Private Sub FrmWorking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        barra_estado_importacion.Maximum = maximo
        btn_salir.Visible = False
        btn_importar.Visible = True
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub
End Class