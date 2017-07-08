Public Class FrmPlantillas
    Private Sub FrmPlantillas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        obtener_intervalos_fecha(Me.txtf_ini, Me.txtf_fin)
    End Sub
End Class