Public Class FrmWorking
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Recorrer_DGV(FrmImportar_Excell.Detalle_Importacion)
    End Sub
    Private Sub FrmWorking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox(maximo)
        ProgressBarControl1.Properties.Maximum = maximo
    End Sub
End Class