Imports System.Data
Imports MySql.Data.MySqlClient
Module Module1
    Public id As Integer
    Public id_carro As Integer
    Public conex As New MySqlConnection("server=localhost;user id=root;password=;database=sergioposse2")
    Public login_empresa As New DataTable
    Public importe As Decimal
    Public Class producto
        Public Function obtenertodo()
            Dim todo As New MySqlDataAdapter("SELECT mode_nomb,prod_id,prod_gara,prod_prec,prod_stoc,inst_tipo,marc_nomb FROM producto INNER JOIN modelo ON modelo.mode_id=producto.mode_id INNER JOIN instrumento ON instrumento.inst_id=producto.inst_id INNER JOIN marca ON modelo.marc_id=marca.marc_id", conex)
            Dim dataset As New DataSet
            conex.Open()
            todo.Fill(dataset, "producto")
            conex.Close()
            Dim tabla As New DataTable
            tabla = dataset.Tables("producto")
            Return tabla
        End Function
        Public Sub actualizargrid(ByVal tabla As DataTable, ByVal grilla As AxMSFlexGridLib.AxMSFlexGrid)
            Dim fila As DataRow
            With grilla
                .Clear()
                .Cols = 7
                .Rows = 2
                .FixedRows = 1
                .Row = 0
                .Col = 0
                .set_ColWidth(0, 500)
                .Text = "ID"
                .Col = 1
                .set_ColWidth(1, 1000)
                .Text = "Marca"
                .Col = 2
                .set_ColWidth(2, 1100)
                .Text = "Modelo"
                .Col = 3
                .set_ColWidth(3, 1100)
                .Text = "Tipo"
                .Col = 4
                .set_ColWidth(4, 700)
                .Text = "Garantia"
                .Col = 5
                .set_ColWidth(5, 1600)
                .Text = "Precio"
                .Col = 6
                .set_ColWidth(6, 1500)
                .Text = "Stock"
            End With
            Dim contador As Integer = 0
            For Each fila In tabla.Rows
                contador = contador + 1
            Next
            If contador > 0 Then
                For Each fila In tabla.Rows

                    Dim idd As String = fila.Item("prod_id").ToString
                    Dim precio As String = fila.Item("prod_prec").ToString
                    Dim garantia As String = fila.Item("prod_gara").ToString
                    Dim cantidad As String = fila.Item("prod_stoc").ToString
                    Dim modelo As String = fila.Item("mode_nomb").ToString
                    Dim marca As String = fila.Item("marc_nomb").ToString
                    Dim instrumento As String = fila.Item("inst_tipo").ToString

                    grilla.AddItem(idd + Chr(9) + marca + Chr(9) + modelo + Chr(9) + instrumento + Chr(9) + garantia + Chr(9) + precio + Chr(9) + cantidad)
                Next
                grilla.RemoveItem(1)
            End If
        End Sub
    End Class
    Public Class ventas
        Public Sub agregar_detalle()
            For x = 0 To main.lst_id.Items.Count - 1
                Dim vent_id As New MySqlParameter("@vent_id", MySqlDbType.Int32)
                Dim prod_id As New MySqlParameter("@prod_id", MySqlDbType.Int32)
                prod_id.Value = main.lst_id.Items.Item(x)
                Dim ultimaventa As New MySqlCommand("SELECT LAST_INSERT_ID() FROM venta", conex)
                conex.Open()
                vent_id.Value = ultimaventa.ExecuteScalar
                conex.Close()

                Dim insertar As New MySqlCommand("INSERT INTO detalleventa (vent_id,prod_id) values (@vent_id,@prod_id)", conex)

                insertar.Parameters.Add(prod_id)
                insertar.Parameters.Add(vent_id)
                Try
                    conex.Open()
                    insertar.ExecuteNonQuery()
                    conex.Close()
                Catch ex As Exception
                    MsgBox("ERROR")
                End Try
            Next
        End Sub
        Public Sub agregar()
            Dim clie_id As Integer
            Dim form_pago_id As Integer
            Dim emp_id As Integer
            Dim vent_impo As New MySqlParameter("@vent_impo", MySqlDbType.Decimal)

            Dim vent_fech As New MySqlParameter("@vent_fech", MySqlDbType.Date)
            Dim vent_tipo_fact As New MySqlParameter("@vent_tipo_fact", MySqlDbType.Text)
            Dim empr_id As New MySqlParameter("@emp_id", MySqlDbType.Int32)
            Dim clien_id As New MySqlParameter("@clie_id", MySqlDbType.Int32)
            Dim forma_pago_id As New MySqlParameter("@form_pago_id", MySqlDbType.Int32)

            For Each fila In login_empresa.Rows
                emp_id = fila.item("emp_id")
            Next

            vent_impo.Value = config_factura.txt_importe.Text
            vent_fech.Value = Now
            If config_factura.rbt_a.Checked Then
                vent_tipo_fact.Value = "A"
            ElseIf config_factura.rbt_b.Checked Then
                vent_tipo_fact.Value = "B"
            Else
                vent_tipo_fact.Value = "C"
            End If

            Dim dni As New MySqlParameter("@dni", MySqlDbType.Text)
            Dim forma_pago_desc As New MySqlParameter("@desc", MySqlDbType.Text)
            dni.Value = config_factura.cbo_dni.SelectedItem
            forma_pago_desc.Value = config_factura.cbo_pago.SelectedItem

            Dim cliente As New MySqlCommand("SELECT clie_id FROM cliente WHERE clie_dni=@dni", conex)
            Dim forma_pago As New MySqlCommand("SELECT form_pago_id FROM forma_pago WHERE form_pago_desc=@desc", conex)

            cliente.Parameters.Add(dni)
            forma_pago.Parameters.Add(forma_pago_desc)

            conex.Open()
            clie_id = cliente.ExecuteScalar
            form_pago_id = forma_pago.ExecuteScalar
            conex.Close()

            clien_id.Value = clie_id
            forma_pago_id.Value = form_pago_id
            empr_id.Value = emp_id

            Dim insertar As New MySqlCommand("INSERT INTO venta (clie_id,vent_impo,vent_fech,form_pago_id,emp_id,vent_tipo_fact) values (@clie_id,@vent_impo,@vent_fech,@form_pago_id,@emp_id,@vent_tipo_fact)", conex)

            insertar.Parameters.Add(empr_id)
            insertar.Parameters.Add(clien_id)
            insertar.Parameters.Add(forma_pago_id)
            insertar.Parameters.Add(vent_impo)
            insertar.Parameters.Add(vent_fech)
            insertar.Parameters.Add(vent_tipo_fact)
            conex.Open()
            insertar.ExecuteNonQuery()
            conex.Close()
        End Sub
        Public Function detalle(ByVal id As Integer)
            Dim ventaid As New MySqlParameter("@id", MySqlDbType.Text)
            ventaid.Value = id
            Dim buscar As New MySqlCommand("SELECT mode_nomb,prod_prec FROM detalleventa INNER JOIN venta ON detalleventa.vent_id=venta.vent_id INNER JOIN producto ON detalleventa.prod_id=producto.prod_id INNER JOIN modelo ON producto.mode_id=modelo.mode_id WHERE venta.vent_id=@id", conex)
            buscar.Parameters.Add(ventaid)
            conex.Open()
            Dim adapter As New MySqlDataAdapter(buscar)
            conex.Close()

            Dim dataset As New DataSet
            adapter.Fill(dataset, "detalle")
            conex.Close()
            Dim tabla As New DataTable
            tabla = dataset.Tables("detalle")
            Return tabla

        End Function
        Public Function factura()
            Dim ultimaventa As Integer
            Dim ultimo_id As New MySqlCommand("SELECT LAST_INSERT_ID FROM venta", conex)
            conex.Open()
            ultimaventa = ultimo_id.ExecuteScalar
            conex.Close()
            Dim adapter As New MySqlDataAdapter("SELECT clie_nomb,clie_apel,clie_domi,loc_nomb,emp_cuit,emp_tele,emp_nomb,form_pago_desc,emp_dire,vent_impo,vent_fech,vent_tipo_fact,mode_id,prod_id,prod_prec,prod_gara FROM venta INNER JOIN detalleventa ON venta.vent_id=detalleventa.vent_id INNER JOIN producto ON producto.prod_id=detalleventa.prod_id INNER JOIN modelo ON producto.mode_id=modelo.mode_id INNER JOIN intrumento ON producto.inst_id=instrumento.inst_id INNER JOIN marca ON modelo.marc_id=marca.marc_id INNER JOIN empresa ON venta.emp_id=empresa.emp_id INNER JOIN forma_pago ON venta.form_pago_id=forma_pago.form_pago_id INNER JOIN localidad cliente ON venta.clie_id=cliente.clie_id INNER JOIN localidad ON localidad.loca_id=cliente.loca_id WHERE venta.vent_id=" & ultimaventa, conex)
            conex.Open()
            Dim dataset As New DataSet
            adapter.Fill(dataset, "modelo")
            conex.Close()
            Dim tabla As New DataTable
            tabla = dataset.Tables("modelo")
            Return tabla
        End Function
        Public Function obtenertodo()
            Dim todo As New MySqlDataAdapter("SELECT vent_impo,vent_fech,vent_id,clie_nomb,clie_apel FROM venta INNER JOIN cliente ON venta.clie_id=cliente.clie_id", conex)
            Dim dataset As New DataSet

            conex.Open()
            todo.Fill(dataset, "venta")
            conex.Close()

            Dim tabla As New DataTable
            tabla = dataset.Tables("venta")
            Return tabla
        End Function
        Public Sub actualizargrid(ByVal tabla As DataTable, ByVal grilla As AxMSFlexGridLib.AxMSFlexGrid)
            Dim fila As DataRow
            With grilla
                .Clear()
                .Cols = 5
                .Rows = 2
                .FixedRows = 1
                .Row = 0
                .Col = 0
                .set_ColWidth(0, 500)
                .Text = "ID"

                .Col = 1
                .set_ColWidth(1, 1000)
                .Text = "Nombre"

                .Col = 2
                .set_ColWidth(2, 1100)
                .Text = "Apellido"

                .Col = 3
                .set_ColWidth(3, 1100)
                .Text = "Fecha"

                .Col = 4
                .set_ColWidth(4, 1100)
                .Text = "Importe"

            End With
            Dim contador As Integer = 0
            For Each fila In tabla.Rows
                contador = contador + 1
            Next
            If contador > 0 Then
                For Each fila In tabla.Rows
                    Dim id As String
                    Dim Nombre As String
                    Dim fecha As String
                    Dim importe As String
                    Dim apellido As String

                    id = fila.Item("vent_id").ToString
                    fecha = fila.Item("vent_fech").ToString
                    importe = fila.Item("vent_impo").ToString
                    Nombre = fila.Item("clie_nomb").ToString
                    apellido = fila.Item("clie_apel").ToString

                    grilla.AddItem(id + Chr(9) + Nombre + Chr(9) + apellido + Chr(9) + fecha + Chr(9) + importe)
                Next
                grilla.RemoveItem(1)
            End If
        End Sub
        Public Sub actualizargrid_detalle(ByVal tabla As DataTable, ByVal grilla As AxMSFlexGridLib.AxMSFlexGrid)
            Dim fila As DataRow
            With grilla
                .Clear()
                .Cols = 2
                .Rows = 2
                .FixedRows = 1
                .FixedCols = 0
                .Row = 0
                .Col = 0
                .set_ColWidth(0, 1000)
                .Text = "Producto"
                .Col = 1
                .set_ColWidth(1, 1000)
                .Text = "Precio"
            End With
            Dim contador As Integer = 0
            For Each fila In tabla.Rows
                contador = contador + 1
            Next
            If contador > 0 Then
                For Each fila In tabla.Rows
                    Dim producto As String
                    Dim precio As String
                    producto = fila.Item("mode_nomb").ToString
                    precio = fila.Item("prod_prec").ToString

                    grilla.AddItem(producto + Chr(9) + precio)
                Next
                grilla.RemoveItem(1)
            End If
        End Sub
    End Class
    Public Class Modelo
        Public Sub obtenernombre(ByVal combobox As ComboBox)
            Dim buscar_nombre_mod As New MySqlDataAdapter("SELECT mode_nomb FROM modelo", conex)
            Dim dataset As New DataSet
            ComboBox.Items.Clear()
            conex.Open()
            buscar_nombre_mod.Fill(dataset, "modelo")
            conex.Close()
            Dim tabla As New DataTable
            tabla = dataset.Tables("modelo")

            Dim fila As DataRow

            For Each fila In tabla.Rows
                combobox.Items.Add(fila.Item("mode_nomb"))
            Next
        End Sub
        Public Function filtro()
            Dim modelo As New MySqlParameter("@modelo", MySqlDbType.Text)
            modelo.Value = main.cbo_filtro.SelectedItem
            Dim buscar_nombre_mod As New MySqlCommand("SELECT mode_nomb,prod_id,prod_gara,prod_prec,prod_stoc,inst_tipo,marc_nomb FROM producto INNER JOIN modelo ON modelo.mode_id=producto.mode_id INNER JOIN instrumento ON instrumento.inst_id=producto.inst_id INNER JOIN marca ON modelo.marc_id=marca.marc_id where modelo.mode_nomb=@modelo", conex)
            buscar_nombre_mod.Parameters.Add(modelo)
            Dim dataset As New DataSet
            Dim adapter As New MySqlDataAdapter(buscar_nombre_mod)
            conex.Open()
            adapter.Fill(dataset, "modelo")
            conex.Close()
            Dim tabla As New DataTable
            tabla = dataset.Tables("modelo")
            Return tabla
        End Function
    End Class
    Public Class Marca
        Public Sub obtenernombre(ByVal combobox As ComboBox)
            Dim buscar_nombre_marc As New MySqlDataAdapter("SELECT marc_nomb FROM marca", conex)
            Dim dataset As New DataSet
            combobox.Items.Clear()
            conex.Open()
            buscar_nombre_marc.Fill(dataset, "marca")
            conex.Close()
            Dim tabla As New DataTable
            tabla = dataset.Tables("marca")

            Dim fila As DataRow

            For Each fila In tabla.Rows
                combobox.Items.Add(fila.Item("marc_nomb"))
            Next
        End Sub
        Public Function filtro()
            Dim marca As New MySqlParameter("@marca", MySqlDbType.Text)
            marca.Value = main.cbo_filtro.SelectedItem
            Dim buscar As New MySqlCommand("SELECT mode_nomb,prod_id,prod_gara,prod_prec,prod_stoc,inst_tipo,marc_nomb FROM producto INNER JOIN modelo ON modelo.mode_id=producto.mode_id INNER JOIN instrumento ON instrumento.inst_id=producto.inst_id INNER JOIN marca ON modelo.marc_id=marca.marc_id where marca.marc_nomb=@marca", conex)
            buscar.Parameters.Add(marca)
            Dim dataset As New DataSet
            Dim adapter As New MySqlDataAdapter(buscar)
            conex.Open()
            adapter.Fill(dataset, "marca")
            conex.Close()
            Dim tabla As New DataTable
            tabla = dataset.Tables("marca")
            Return tabla
        End Function
    End Class
    Public Class cliente
        Public Sub obtenernombre(ByVal combobox As ComboBox)
            Dim buscar_nombre_marc As New MySqlDataAdapter("SELECT clie_dni FROM cliente", conex)
            Dim dataset As New DataSet
            combobox.Items.Clear()
            conex.Open()
            buscar_nombre_marc.Fill(dataset, "marca")
            conex.Close()
            Dim tabla As New DataTable
            tabla = dataset.Tables("marca")

            Dim fila As DataRow

            For Each fila In tabla.Rows
                combobox.Items.Add(fila.Item("clie_dni"))
            Next
        End Sub
    End Class
    Public Class forma_pago
        Public Sub obtenernombre(ByVal combobox As ComboBox)
            Dim buscar_nombre_marc As New MySqlDataAdapter("SELECT form_pago_desc FROM forma_pago", conex)
            Dim dataset As New DataSet
            combobox.Items.Clear()
            conex.Open()
            buscar_nombre_marc.Fill(dataset, "marca")
            conex.Close()
            Dim tabla As New DataTable
            tabla = dataset.Tables("marca")

            Dim fila As DataRow

            For Each fila In tabla.Rows
                combobox.Items.Add(fila.Item("form_pago_desc"))
            Next
        End Sub
    End Class
    Public Class empresa
        Public Sub obtenernombre(ByVal combobox As ComboBox)
            Dim buscar_nombre_mod As New MySqlDataAdapter("SELECT emp_nomb FROM empresa", conex)
            Dim dataset As New DataSet
            combobox.Items.Clear()
            conex.Open()
            buscar_nombre_mod.Fill(dataset, "modelo")
            conex.Close()
            Dim tabla As New DataTable
            tabla = dataset.Tables("modelo")

            Dim fila As DataRow

            For Each fila In tabla.Rows
                combobox.Items.Add(fila.Item("emp_nomb"))
            Next
        End Sub
    End Class

    Public Class instrumento
        Public Sub obtenernombre(ByVal combobox As ComboBox)
            Dim buscar_nombre_inst As New MySqlDataAdapter("SELECT inst_tipo FROM instrumento", conex)
            Dim dataset As New DataSet
            combobox.Items.Clear()
            conex.Open()
            buscar_nombre_inst.Fill(dataset, "instrumento")
            conex.Close()
            Dim tabla As New DataTable
            tabla = dataset.Tables("instrumento")

            Dim fila As DataRow

            For Each fila In tabla.Rows
                combobox.Items.Add(fila.Item("inst_tipo"))
            Next
        End Sub
        Public Function filtro()
            Dim marca As New MySqlParameter("@marca", MySqlDbType.Text)
            marca.Value = main.cbo_filtro.SelectedItem
            Dim buscar As New MySqlCommand("SELECT mode_nomb,prod_id,prod_gara,prod_prec,prod_stoc,inst_tipo,marc_nomb FROM producto INNER JOIN modelo ON modelo.mode_id=producto.mode_id INNER JOIN instrumento ON instrumento.inst_id=producto.inst_id INNER JOIN marca ON modelo.marc_id=marca.marc_id where instrumento.inst_tipo=@marca", conex)
            buscar.Parameters.Add(marca)
            Dim dataset As New DataSet
            Dim adapter As New MySqlDataAdapter(buscar)
            conex.Open()
            adapter.Fill(dataset, "marca")
            conex.Close()
            Dim tabla As New DataTable
            tabla = dataset.Tables("marca")
            Return tabla
        End Function
    End Class

    Public Sub pintar_fila(ByRef listado As AxMSFlexGridLib.AxMSFlexGrid)
        listado.SelectionMode = MSFlexGridLib.SelectionModeSettings.flexSelectionByRow
        listado.HighLight = MSFlexGridLib.HighLightSettings.flexHighlightAlways
        listado.Col = 0
        listado.ColSel = listado.Cols - 1
    End Sub
    Public Sub solonumeros(ByVal caracter As KeyPressEventArgs)
        If Not (Char.IsNumber(caracter.KeyChar) Or caracter.KeyChar = Chr(8)) Then
            caracter.Handled = True
        End If
    End Sub
    Public Sub sololetras(ByVal caracter As KeyPressEventArgs)
        If Not (Char.IsLetter(caracter.KeyChar) Or caracter.KeyChar = Chr(8) Or
        caracter.KeyChar = Chr(32)) Then
            caracter.Handled = True
        End If
    End Sub
    Public Sub alfanumerico(ByVal caracter As KeyPressEventArgs)
        If Not (Char.IsLetter(caracter.KeyChar) Or Char.IsNumber(caracter.KeyChar) Or
        caracter.KeyChar = Chr(8) Or caracter.KeyChar = Chr(32)) Then
            caracter.Handled = True
        End If
    End Sub
End Module
