Module FUNCIONES
    Public Function gestionar_formularios(control1 As DevExpress.XtraTabbedMdi.XtraTabbedMdiManager, control2 As DevExpress.XtraEditors.PanelControl) As Boolean
        Try
            gestionar_formularios = True
            If control1.Pages.Count = 0 Then
                control2.Visible = True
            Else
                control2.Visible = False
            End If
        Catch ex As Exception
            gestionar_formularios = False
            MsgBox(ex.Message)
        End Try
        Return gestionar_formularios
    End Function
    Public Function cargar_formularios(padre As Form, hijo As Form) As Boolean
        Try
            cargar_formularios = True
            With hijo
                .MdiParent = padre
                .Show()
                .Focus()
            End With
        Catch ex As Exception
            cargar_formularios = False
            MsgBox(ex.Message)
        End Try
        Return cargar_formularios
    End Function
    Public Function cargar_formulario(formulario As Form, tipo As Integer) As Boolean
        Try
            cargar_formulario = True
            If tipo = 0 Then
                formulario.Show()
            ElseIf tipo = 1 Then
                formulario.ShowDialog()
            End If
        Catch ex As Exception
            cargar_formulario = False
            MsgBox(ex.Message)
        End Try
        Return cargar_formulario
    End Function
    Public Function activar_checkbox(control1 As DevExpress.XtraEditors.CheckEdit, control2 As DevExpress.XtraEditors.SpinEdit) As Boolean
        Try
            activar_checkbox = True
            If control1.Checked = True Then
                control2.Enabled = True
            ElseIf control1.Checked = False Then
                control2.Enabled = False
            End If
        Catch ex As Exception
            activar_checkbox = False
            MsgBox(ex.Message)
        End Try
        Return activar_checkbox
    End Function
    Public Function obtener_intervalos_fecha(control1 As DevExpress.XtraBars.BarEditItem, control2 As DevExpress.XtraBars.BarEditItem) As Boolean
        Try
            obtener_intervalos_fecha = True
            control1.EditValue = DateSerial(Year(Date.Now), Month(Date.Now), 1)
            control2.EditValue = DateSerial(Year(Date.Now), Month(Date.Now) + 1, 0)
        Catch ex As Exception
            obtener_intervalos_fecha = False
            MsgBox(ex.Message)
        End Try
        Return obtener_intervalos_fecha
    End Function
    Public Function obtener_intervalos_fecha(control1 As DevExpress.XtraEditors.DateEdit, control2 As DevExpress.XtraEditors.DateEdit) As Boolean
        Try
            obtener_intervalos_fecha = True
            control1.EditValue = DateSerial(Year(Date.Now), Month(Date.Now), 1)
            control2.EditValue = DateSerial(Year(Date.Now), Month(Date.Now) + 1, 0)
        Catch ex As Exception
            obtener_intervalos_fecha = False
            MsgBox(ex.Message)
        End Try
        Return obtener_intervalos_fecha
    End Function
End Module
