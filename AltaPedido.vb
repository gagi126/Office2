Imports System.IO
Imports ExcelApp = Microsoft.Office.Interop.Excel
Public Class AltaPedido
    Dim eleccion As String
    Private Sub AltaPedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        If lvpedidos.Columns.Count > 2 Then
        Else
            lvpedidos.Columns.Add("Cdo Producto")
            lvpedidos.Columns.Add("Producto")
            lvpedidos.Columns.Add("Categoria")
            lvpedidos.Columns.Add("Fecha Vigente")
            lvpedidos.Columns.Add("Precio")
            lvpedidos.Columns.Add("Horario")
        End If
        lvpedidos.View = View.Details

        CMBCat.DropDownStyle = ComboBoxStyle.DropDownList
        CMBCat.Items.Add("Bebida")
        CMBCat.Items.Add("Carnes")
        CMBCat.Items.Add("Vegano")
        CMBCat.Items.Add("Ensaladas")
        CMBCat.Items.Add("Pastaas")
        CMBCat.SelectedIndex = 0
        datefecha.MinDate = Today
    End Sub


    Private Sub BTNRegistrar_Click(sender As Object, e As EventArgs) Handles BTNRegistrar.Click
        If esvalido() = True Then
            Dim sumador As Integer = 0
            lvpedidos.Items.Add(mskcod.Text)
            lvpedidos.Items(lvpedidos.Items.Count - 1).SubItems.Add(txtproducto.Text)
            lvpedidos.Items(lvpedidos.Items.Count - 1).SubItems.Add(CMBCat.Text)
            lvpedidos.Items(lvpedidos.Items.Count - 1).SubItems.Add(datefecha.Value.ToShortDateString)
            lvpedidos.Items(lvpedidos.Items.Count - 1).SubItems.Add(txtimporte.Text)
            lvpedidos.Items(lvpedidos.Items.Count - 1).SubItems.Add(eleccion)
            MessageBox.Show("Los datos se validaron con exito, se procedera a crear el archivo", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim excel As ExcelApp.Application
            Dim libro As ExcelApp.Workbook
            Dim hoja As ExcelApp.Worksheet
            Dim guardar As New SaveFileDialog
            guardar.Title = "Exportar listado"
            guardar.Filter = "Listados (*.xlsx)|*.xlsx"
            guardar.InitialDirectory = "%homepath%\Documents"
            guardar.DefaultExt = "otz"
            guardar.AddExtension = True
            Dim filename As String
            If guardar.ShowDialog = Windows.Forms.DialogResult.OK = True Then
                excel = New ExcelApp.Application
                libro = excel.Workbooks.Add()
                hoja = libro.Worksheets.Add()
                hoja.Range("A1").Value = "Cdo Producto"
                hoja.Range("B1").Value = "Producto"
                hoja.Range("C1").Value = "Categoria"
                hoja.Range("D1").Value = "Fecha Vigente"
                hoja.Range("E1").Value = "Precio"
                hoja.Range("F1").Value = "Horario"
                hoja.Range("A2").Value = mskcod.Text
                hoja.Range("B2").Value = txtproducto.Text
                hoja.Range("C2").Value = CMBCat.Text
                hoja.Range("D2").Value = datefecha.Value.ToShortDateString
                hoja.Range("E2").Value = txtimporte.Text
                hoja.Range("F2").Value = eleccion
                libro.SaveAs(guardar.FileName)
                libro.Close()
                MessageBox.Show("El archivo fue creado con exito", "Atencion")
            End If
        End If
    End Sub

    Private Function esvalido() As Boolean
        Dim afirmativo As Boolean = False
        Dim precio As Integer
        If mskcod.MaskCompleted = True Then
            If txtproducto.Text.Trim <> "" Then
                If Integer.TryParse(txtimporte.Text, precio) = True Then
                    If precio >= 0 Then
                        If (checkdesayuno.Checked And checkmerienda.Checked) = True Then
                            eleccion = "Desayuno y merienda"
                            afirmativo = True
                        ElseIf (checkdesayuno.Checked = True) Then
                            eleccion = "Desayuno"
                            afirmativo = True
                        ElseIf (checkmerienda.Checked = True) Then
                            eleccion = "Merienda"
                            afirmativo = True
                        ElseIf (checkalmuerzo.Checked And checkcena.Checked) = True Then
                            eleccion = "Almuerzo y Cena"
                            afirmativo = True
                        ElseIf (checkalmuerzo.Checked = True) Then
                            eleccion = "Almuerzo"
                            afirmativo = True
                        ElseIf (checkcena.Checked = True) Then
                            eleccion = "Cena"
                            afirmativo = True
                        ElseIf (checkdesayuno.Checked = False And checkmerienda.Checked = False And checkcena.Checked = False And checkalmuerzo.Checked = False) Then
                            MessageBox.Show("Debes elegir almenos un horario de ofrecimiento", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    Else
                        MessageBox.Show("El precio ingresado es menor a 0$", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    MessageBox.Show("El campo importe tiene letras", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("El campo producto no puede estar vacio", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("El codigo del producto no puede estar vacio", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Return afirmativo
    End Function

    Private Sub checkdesayuno_CheckedChanged(sender As Object, e As EventArgs) Handles checkdesayuno.CheckedChanged
        If checkdesayuno.Checked = True Or checkmerienda.Checked = True Then
            checkalmuerzo.Enabled = False
            checkcena.Enabled = False
        ElseIf checkdesayuno.Checked = False Or checkmerienda.Checked = False Then
            checkalmuerzo.Enabled = True
            checkcena.Enabled = True
        End If
    End Sub

    Private Sub checkalmuerzo_CheckedChanged(sender As Object, e As EventArgs) Handles checkalmuerzo.CheckedChanged
        If checkalmuerzo.Checked = True Or checkcena.Checked = True Then
            checkdesayuno.Enabled = False
            checkmerienda.Enabled = False
        ElseIf checkalmuerzo.Checked = False Or checkcena.Checked = False Then
            checkdesayuno.Enabled = True
            checkmerienda.Enabled = True
        End If
    End Sub

    Private Sub checkmerienda_CheckedChanged(sender As Object, e As EventArgs) Handles checkmerienda.CheckedChanged
        If checkmerienda.Checked = True Or checkdesayuno.Checked = True Then
            checkalmuerzo.Enabled = False
            checkcena.Enabled = False
        ElseIf checkmerienda.Checked = False Or checkdesayuno.Checked = False Then
            checkalmuerzo.Enabled = True
            checkcena.Enabled = True
        End If
    End Sub

    Private Sub checkcena_CheckedChanged(sender As Object, e As EventArgs) Handles checkcena.CheckedChanged
        If checkcena.Checked = True Or checkalmuerzo.Checked = True Then
            checkdesayuno.Enabled = False
            checkmerienda.Enabled = False
        ElseIf checkcena.Checked = False Or checkalmuerzo.Checked = False Then
            checkdesayuno.Enabled = True
            checkmerienda.Enabled = True
        End If
    End Sub

    Private Sub BTNImportar_Click(sender As Object, e As EventArgs) Handles BTNImportar.Click
        Dim excel As ExcelApp.Application
        Dim libro As ExcelApp.Workbook
        Dim hoja As ExcelApp.Worksheet
        Dim abrir As New OpenFileDialog
        Dim filename As String
        Dim combo As String
        Dim i As Integer = 2
        Dim f As Integer = 0
        excel = New ExcelApp.Application

        abrir.Filter = "Documento Excel (*.Xlsx|*.xlsx"
        abrir.FilterIndex = 2
        abrir.RestoreDirectory = True
        abrir.Title = "Seleccione un archivo"
        If abrir.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim sumador As Integer = 0
            filename = abrir.FileName
            libro = excel.Workbooks.Open(filename)
            hoja = libro.Worksheets(1)
            excel.Visible = False
            lvpedidos.View = View.Details
            lvpedidos.FullRowSelect = True
            lvpedidos.Items.Add(hoja.Range("A2").Value)
            lvpedidos.Items(lvpedidos.Items.Count - 1).SubItems.Add(hoja.Range("B2").Value)
            lvpedidos.Items(lvpedidos.Items.Count - 1).SubItems.Add(hoja.Range("C2").Value)
            lvpedidos.Items(lvpedidos.Items.Count - 1).SubItems.Add(hoja.Range("D2").Value)
            lvpedidos.Items(lvpedidos.Items.Count - 1).SubItems.Add(hoja.Range("E2").Value)
            lvpedidos.Items(lvpedidos.Items.Count - 1).SubItems.Add(hoja.Range("F2").Value)
            libro.Close()
        End If
        excel.Quit()
    End Sub

    Private Sub BTNCargar_Click(sender As Object, e As EventArgs) Handles BTNCargar.Click
        If esvalido() = True Then
            lvpedidos.Items.Add(mskcod.Text)
            lvpedidos.Items(lvpedidos.Items.Count - 1).SubItems.Add(txtproducto.Text)
            lvpedidos.Items(lvpedidos.Items.Count - 1).SubItems.Add(CMBCat.Text)
            lvpedidos.Items(lvpedidos.Items.Count - 1).SubItems.Add(datefecha.Value.ToShortDateString)
            lvpedidos.Items(lvpedidos.Items.Count - 1).SubItems.Add(txtimporte.Text)
            lvpedidos.Items(lvpedidos.Items.Count - 1).SubItems.Add(eleccion)
        End If
    End Sub

    Private Sub BTNExportar_Click(sender As Object, e As EventArgs) Handles BTNExportar.Click
        Dim excel As ExcelApp.Application
        Dim libro As ExcelApp.Workbook
        Dim hoja As ExcelApp.Worksheet
        Dim guardar As New SaveFileDialog
        guardar.Title = "Exportar ListView"
        guardar.Filter = "Listado (*.xlsx|*.xlsx"
        guardar.InitialDirectory = "%homepath&\Documents"
        guardar.DefaultExt = "otz"
        guardar.AddExtension = True
        Dim contador As Integer = 2
        If guardar.ShowDialog = Windows.Forms.DialogResult.OK Then
            excel = New ExcelApp.Application
            libro = excel.Workbooks.Add()
            hoja = excel.Worksheets.Add()
            hoja.Range("A1").Value = "CodProducto"
            hoja.Range("B1").Value = "Producto"
            hoja.Range("C1").Value = "Categoria"
            hoja.Range("D1").Value = "Fecha"
            hoja.Range("E1").Value = "Precio"
            hoja.Range("F1").Value = "Horario"
            For aux = 0 To lvpedidos.Items.Count - 1
                hoja.Range("A" + contador.ToString).Value = lvpedidos.Items(aux).SubItems(0).Text
                hoja.Range("B" + contador.ToString).Value = lvpedidos.Items(aux).SubItems(1).Text
                hoja.Range("C" + contador.ToString).Value = lvpedidos.Items(aux).SubItems(2).Text
                hoja.Range("D" + contador.ToString).Value = lvpedidos.Items(aux).SubItems(3).Text
                hoja.Range("E" + contador.ToString).Value = lvpedidos.Items(aux).SubItems(4).Text
                hoja.Range("F" + contador.ToString).Value = lvpedidos.Items(aux).SubItems(5).Text
                contador = contador + 1
            Next
            libro.SaveAs(guardar.FileName)
            libro.Close()
            MessageBox.Show("El archivo fue creado con exito", "Atencion")
        End If
    End Sub
End Class