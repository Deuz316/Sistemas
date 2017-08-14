Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports Microsoft.Office.Interop
Module Funciones_Optimizadas

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
                '.Filter = "Excel Files |*.xlsx"
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
End Module
