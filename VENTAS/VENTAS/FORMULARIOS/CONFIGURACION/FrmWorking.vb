Public Class FrmWorking
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles btn_importar.Click
        If cbo_opciones_importacion.Text = "Catalogo de Productos" Then

            Recorrer_DGV(FrmImportar_Excell.Detalle_Importacion)
            btn_salir.Visible = True
            btn_importar.Visible = False
        End If
        If cbo_opciones_importacion.Text = "Historico de Ventas" Then

        End If
        If cbo_opciones_importacion.Text = "Historico de Importaciones" Then

        End If
        LabelControl2.Text = "Registro Importado Exitosamente"
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