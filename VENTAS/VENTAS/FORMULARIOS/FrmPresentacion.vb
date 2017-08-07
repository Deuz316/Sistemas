Public Class FrmPresentacion
    Sub New
        InitializeComponent()
        Me.progressPanel1.AutoHeight = True
    End Sub

    Public Overrides Sub SetCaption(ByVal caption As String)
        MyBase.SetCaption(caption)
        Me.progressPanel1.Caption = caption
    End Sub

    Public Overrides Sub SetDescription(ByVal description As String)
        MyBase.SetDescription(description)
        Me.progressPanel1.Description = description
    End Sub

    Public Overrides Sub ProcessCommand(ByVal cmd As System.Enum, ByVal arg As Object)
        MyBase.ProcessCommand(cmd, arg)
    End Sub

    Public Enum WaitFormCommand
        SomeCommandId
    End Enum

    Private Sub FrmPresentacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If FrmImportar_Excell.Detalle_Importacion.RowCount <> 0 Then
                Recorrer_DGV(FrmImportar_Excell.Detalle_Importacion)
            Else
                MessageBox.Show("Lo sentimos, aparentemente no existen datos que guardar", "Modulo de Importacion & Exportacion de Datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
        End Try
    End Sub
End Class
