Public Class FrmPeb
    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub

    Private Sub CheckEdit1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEdit1.CheckedChanged
        activar_checkbox(Me.CheckEdit1, Me.txtimpuesto)
    End Sub

    Private Sub CheckEdit2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEdit2.CheckedChanged
        activar_checkbox(Me.CheckEdit2, Me.txtdescuento)
    End Sub
End Class