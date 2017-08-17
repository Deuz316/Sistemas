Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports Microsoft.Office.Interop
Module FUNCIONES
    Public server = "Data Source='192.168.10.223';Initial Catalog=Ventas;Persist Security Info=True;User ID=sa;Password=SO.DEBDC"
    Public conteo = 0
    Public maximo = 0
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
    Public Function Cargar_Formularios(padre As Form, hijo As Form) As Boolean
        Try
            Cargar_Formularios = True
            With hijo
                .MdiParent = padre
                .Show()
                .Focus()
            End With
        Catch ex As Exception
            Cargar_Formularios = False
            MsgBox(ex.Message)
        End Try
        Return Cargar_Formularios
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
    Public Function Importar_Excel_to_datagridview(ByRef path As String, name As String, ByVal grid As DataGridView) As Boolean
        Try
            Importar_Excel_to_datagridview = True
            Dim stConexion As String = ("Provider=Microsoft.ACE.OLEDB.12.0;" & ("Data Source=" & (path & ";Extended Properties=""Excel 12.0;Xml;HDR=YES;IMEX=2"";")))
            Dim cnConex As New OleDbConnection(stConexion)
            Dim Cmd As New OleDbCommand("Select * From [" + name + "$]")
            Dim Ds As New DataSet
            Dim Da As New OleDbDataAdapter
            Dim Dt As New DataTable
            cnConex.Open()
            Cmd.Connection = cnConex
            Da.SelectCommand = Cmd
            Da.Fill(Ds)
            Dt = Ds.Tables(0)
            grid.Columns.Clear()
            grid.DataSource = Dt
            maximo = Dt.Rows.Count()
        Catch ex As Exception
            Importar_Excel_to_datagridview = False
            MsgBox(ex.Message)
        End Try
        Return Importar_Excel_to_datagridview
    End Function
    Public Function Obtener_Nombre_Hoja_Activa(ByVal rutaLibro As String) As String
        Dim app As Excel.Application = Nothing
        Try
            app = New Excel.Application()
            Dim wb As Excel.Workbook = app.Workbooks.Open(rutaLibro)
            Dim ws As Excel.Worksheet = CType(wb.Worksheets.Item(1), Excel.Worksheet)
            Dim name As String = ws.Name
            ws = Nothing
            wb.Close()
            wb = Nothing
            Return name
        Catch ex As Exception
            Throw
        Finally
            If (Not app Is Nothing) Then _
                app.Quit()
            Runtime.InteropServices.Marshal.ReleaseComObject(app)
            app = Nothing
        End Try
    End Function
    Public Function GridAExcel(ByVal ElGrid As DataGridView) As Boolean
        Dim exApp As New Microsoft.Office.Interop.Excel.Application
        Dim exLibro As Microsoft.Office.Interop.Excel.Workbook
        Dim exHoja As Microsoft.Office.Interop.Excel.Worksheet
        Try
            exLibro = exApp.Workbooks.Add
            exHoja = exLibro.Worksheets.Add()
            Dim NCol As Integer = ElGrid.ColumnCount
            Dim NRow As Integer = ElGrid.RowCount
            For i As Integer = 1 To NCol
                exHoja.Cells.Item(1, i) = ElGrid.Columns(i - 1).Name.ToString
            Next

            For Fila As Integer = 0 To NRow - 1
                For Col As Integer = 0 To NCol - 1
                    exHoja.Cells.Item(Fila + 2, Col + 1) = ElGrid.Rows(Fila).Cells(Col).Value
                Next
            Next
            exHoja.Rows.Item(1).Font.Bold = 1
            exHoja.Columns.AutoFit()
            exApp.Application.Visible = True
            exHoja = Nothing
            exLibro = Nothing
            exApp = Nothing
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al exportar a Excel")
            Return False
        End Try
        Return True
    End Function
    Public Function Recorrer_DGV(grid As DataGridView) As Boolean
        Try
            Recorrer_DGV = True
            Using cnn = New SqlConnection(server)
                cnn.Open()
                Dim sql As String = "INSERT MIGRAR_INVENTARIO VALUES(@BODEGA,@CODIGO,@CODIGO_BARRA,@PRODUCTO,@MARCA,@CATEGORIA,@TIPO,@UDM,@FOB,@CIF,@PRECIO,@EXISTENCIAS,@RACK,@COLUMNA,@FILA,@MINIMO,@MAXIMO,@CLASIFICACION,@SERVICIO,@IMPUESTO,@ACTIVO,@LOCAL)"
                Dim command As New SqlCommand(sql, cnn)
                For Each row As DataGridViewRow In grid.Rows
                    command.Parameters.Clear()
                    command.Parameters.AddWithValue("@BODEGA", Convert.ToString(row.Cells("BODEGA").Value))
                    command.Parameters.AddWithValue("@CODIGO", Convert.ToString(row.Cells("CODIGO").Value))
                    command.Parameters.AddWithValue("@CODIGO_BARRA", Convert.ToString(row.Cells("CODIGO_BARRA").Value))
                    command.Parameters.AddWithValue("@PRODUCTO", Convert.ToString(row.Cells("PRODUCTO").Value))
                    command.Parameters.AddWithValue("@MARCA", Convert.ToString(row.Cells("MARCA").Value))
                    command.Parameters.AddWithValue("@CATEGORIA", Convert.ToString(row.Cells("CATEGORIA").Value))
                    command.Parameters.AddWithValue("@TIPO", Convert.ToString(row.Cells("TIPO").Value))
                    command.Parameters.AddWithValue("@UDM", Convert.ToString(row.Cells("UDM").Value))
                    command.Parameters.AddWithValue("@FOB", Convert.ToDecimal(row.Cells("FOB").Value))
                    command.Parameters.AddWithValue("@CIF", Convert.ToDecimal(row.Cells("CIF").Value))
                    command.Parameters.AddWithValue("@PRECIO", Convert.ToDecimal(row.Cells("PRECIO").Value))
                    command.Parameters.AddWithValue("@EXISTENCIAS", Convert.ToDecimal(row.Cells("EXISTENCIAS").Value))
                    command.Parameters.AddWithValue("@RACK", Convert.ToString(row.Cells("RACK").Value))
                    command.Parameters.AddWithValue("@COLUMNA", Convert.ToString(row.Cells("COLUMNA").Value))
                    command.Parameters.AddWithValue("@FILA", Convert.ToString(row.Cells("FILA").Value))
                    command.Parameters.AddWithValue("@MINIMO", Convert.ToDecimal(row.Cells("MINIMO").Value))
                    command.Parameters.AddWithValue("@MAXIMO", Convert.ToDecimal(row.Cells("MAXIMO").Value))
                    command.Parameters.AddWithValue("@CLASIFICACION", Convert.ToString(row.Cells("CLASIFICACION").Value))
                    command.Parameters.AddWithValue("@SERVICIO", Convert.ToString(row.Cells("SERVICIO").Value))
                    command.Parameters.AddWithValue("@IMPUESTO", Convert.ToString(row.Cells("IMPUESTO").Value))
                    command.Parameters.AddWithValue("@ACTIVO", Convert.ToString(row.Cells("ACTIVO").Value))
                    command.Parameters.AddWithValue("@LOCAL", Convert.ToString(row.Cells("LOCAL").Value))
                    conteo = conteo + 1
                    command.ExecuteNonQuery()
                    FrmWorking.barra_estado_importacion.Value = conteo
                Next
                cnn.Close()
            End Using
        Catch ex As Exception
            Recorrer_DGV = False
            MsgBox(ex.Message)
        End Try
        Return Recorrer_DGV
    End Function
    Public Function Llenar_Combobox(query As String, campo As String, cbo As DevExpress.XtraEditors.ComboBoxEdit) As Boolean
        Try
            Llenar_Combobox = True
            Using cnn As New SqlConnection(server)
                cnn.Open()
                Dim enunciado = New SqlCommand(query, cnn)
                Dim respuesta As SqlDataReader
                respuesta = enunciado.ExecuteReader
                While respuesta.Read
                    cbo.Properties.Items.Add(respuesta.Item(campo))
                End While
                respuesta.Close()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
            Llenar_Combobox = False
        End Try
        Return Llenar_Combobox
    End Function
    Public Function Llenar_Datagridview(ByVal tabla As String, grid As DataGridView) As Boolean
        Try
            Llenar_Datagridview = True
            Dim tb As New DataTable
            Dim strSql As String = "select top 0 * from " + tabla + ""
            Using cnn As New SqlConnection(server)
                cnn.Open()
                Using dad As New SqlDataAdapter(strSql, cnn)
                    dad.Fill(tb)
                End Using
                cnn.Close()
            End Using
            grid.DataSource = tb
        Catch ex As Exception
            Llenar_Datagridview = False
            MsgBox(ex.Message)
        End Try
        Return Llenar_Datagridview
    End Function
    Public Function Exportar_Doc(tabla As String, grid As DataGridView)
        Try
            Exportar_Doc = True
            Dim app As Microsoft.Office.Interop.Excel._Application = New Microsoft.Office.Interop.Excel.Application()
            Dim workbook As Microsoft.Office.Interop.Excel._Workbook = app.Workbooks.Add(Type.Missing)
            Dim worksheet As Microsoft.Office.Interop.Excel._Worksheet = Nothing
            worksheet = workbook.Sheets("Hoja1")
            worksheet = workbook.ActiveSheet
            For i As Integer = 1 To grid.Columns.Count
                worksheet.Cells(1, i) = grid.Columns(i - 1).HeaderText
            Next
            For i As Integer = 0 To grid.Rows.Count - 1
                For j As Integer = 0 To grid.Columns.Count - 1
                    worksheet.Cells(i + 2, j + 1) = grid.Rows(i).Cells(j).Value.ToString()
                Next
            Next
            worksheet.Rows.Item(1).Font.Bold = 1
            worksheet.Rows.Item(1).HorizontalAlignment = 3
            worksheet.Columns.AutoFit()
            worksheet.Columns.HorizontalAlignment = 2
            app.Visible = True
            app = Nothing
            workbook = Nothing
            worksheet = Nothing
            FileClose(1)
            GC.Collect()
        Catch ex As Exception
            MsgBox(ex.Message)
            Exportar_Doc = False
        End Try
        Return Exportar_Doc
    End Function
    Public Function Importar_Doc(tabla As String, grid As DataGridView) As Boolean
        Try
            Importar_Doc = True
            Dim myFileDialog As New OpenFileDialog()
            Dim xSheet As String = ""

            With myFileDialog
                .Filter = “Archivos Excel(*.xls;*.xlsx)|*.xls;*xlsx|Todos los archivos(*.*)|*.*”
                .Title = "Open File"
                .ShowDialog()
            End With
            If myFileDialog.FileName.ToString <> "" Then
                Dim ExcelFile As String = myFileDialog.FileName.ToString
                xSheet = Obtener_Nombre_Hoja_Activa(ExcelFile)
                Dim cadena As String = ("Provider=Microsoft.ACE.OLEDB.12.0;" & ("Data Source=" & (ExcelFile & ";Extended Properties=""Excel 12.0;Xml;HDR=YES;IMEX=2"";")))
                Dim cadenaorigen As OleDbConnection
                cadenaorigen = New OleDbConnection(cadena)
                Dim cmdselect As OleDbCommand
                cmdselect = New OleDbCommand("select * from [" & xSheet & "$]", cadenaorigen)
                Dim adaptador As New OleDbDataAdapter
                adaptador.SelectCommand = cmdselect
                Dim ds As DataSet
                ds = New DataSet
                adaptador.Fill(ds)
                grid.DataSource = ds.Tables(0)
                maximo = grid.RowCount()
                cadenaorigen.Close()
                Dim cadenadestino As New SqlConnection
                cadenadestino.ConnectionString = (server)
                cadenadestino.Open()
                Dim importar As SqlBulkCopy
                importar = New SqlBulkCopy(cadenadestino)
                importar.DestinationTableName = "" + tabla + ""
                importar.WriteToServer(ds.Tables(0))
                cadenadestino.Close()
            End If
        Catch ex As Exception
            Importar_Doc = False
            MsgBox(ex.Message)
        End Try
        Return Importar_Doc
    End Function
    Public Function Ejecutar_Procedure(procedure As String) As Boolean
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader
        Try
            Ejecutar_Procedure = True
            Using cnn As New SqlConnection(server)
                cnn.Open()
                cmd = New SqlCommand(procedure)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Connection = cnn
                If cmd.ExecuteNonQuery Then
                    Dim dt As New DataTable
                    Dim da As New SqlDataAdapter(cmd)
                    da.Fill(dt)
                Else
                    Return Nothing
                End If
                cnn.Close()
            End Using
        Catch ex As Exception
            Ejecutar_Procedure = False
            MsgBox(ex.Message)
        End Try
    End Function
    Public Function txt_autocomplete(consulta As String, campo As String, result As DevExpress.XtraEditors.TextEdit) As Boolean
        Try
            txt_autocomplete = True
            Using cnn As New SqlConnection(server)
                Dim cmd As New SqlCommand(consulta, cnn)
                Dim ds As New DataSet
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(ds, "lista")
                Dim col As New AutoCompleteStringCollection
                Dim i As Integer
                For i = 0 To ds.Tables("lista").Rows.Count - 1
                    col.Add(ds.Tables("lista").Rows(i)(campo).ToString())
                Next
                result.MaskBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend
                result.MaskBox.AutoCompleteSource = AutoCompleteSource.CustomSource
                result.MaskBox.AutoCompleteCustomSource = col
                cnn.Close()
            End Using
        Catch ex As Exception
            txt_autocomplete = False
            MsgBox(ex.Message)
        End Try
        Return txt_autocomplete
    End Function
End Module
