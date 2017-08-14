Public Class FrmOpciones
    Private Sub FrmOpciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Llenar_Combobox("SELECT CAST(table_name as varchar)'TABLAS' FROM INFORMATION_SCHEMA.TABLES", "TABLAS", Me.ComboBoxEdit1)
    End Sub

    Private Sub btnExportar_Click(sender As Object, e As EventArgs) Handles btnExportar.Click
        Cargar_Formularios(FrmMenu, FrmImportar_Excell)
        Llenar_Datagridview(Me.ComboBoxEdit1.EditValue, FrmImportar_Excell.Detalle_Importacion)
        Exportar_Doc(Me.ComboBoxEdit1.Text, FrmImportar_Excell.Detalle_Importacion)
        Me.Close()
    End Sub

    Private Sub FrmOpciones_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        btnImportar.Visible = False
        btnExportar.Visible = False
    End Sub

    Private Sub btnImportar_Click(sender As Object, e As EventArgs) Handles btnImportar.Click
        Importar_Doc(Me.ComboBoxEdit1.Text, FrmImportar_Excell.Detalle_Importacion)
        Cargar_Formularios(FrmMenu, FrmImportar_Excell)
    End Sub
End Class