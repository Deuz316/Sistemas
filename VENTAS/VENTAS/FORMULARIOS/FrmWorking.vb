Public Class FrmWorking
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles btn_importar.Click
        If cbo_opciones_importacion.Text = "Catalogo de Productos" Then
            Recorrer_DGV(FrmImportar_Excell.Detalle_Importacion)
            btn_salir.Visible = True
            btn_importar.Visible = False
        Else
            If cbo_opciones_importacion.Text = "Historico de Ventas" Then

            Else
                If cbo_opciones_importacion.Text = "Historico de Importaciones" Then

                Else

                End If

            End If
            MessageBox.Show("Lo sentimos debe seleccionar un tipo de importacion valido", "Migracion & Exportacion de Datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btn_salir.Visible = False
            btn_importar.Visible = True
        End If
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