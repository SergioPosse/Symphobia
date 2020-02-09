
Public Class main

    Private Sub RegistroToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub NuevoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoToolStripMenuItem.Click

    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim producto As New producto
        producto.actualizargrid(producto.obtenertodo, msg_producto)
        Dim fila_empresa As DataRow
        Dim nombre As String
        For Each fila_empresa In login_empresa.Rows
            nombre = fila_empresa.Item("emp_nomb")
        Next
        Me.Text = nombre
        lbl_empresa.text = nombre
    End Sub

    Private Sub msg_producto_ClickEvent(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles msg_producto.ClickEvent
        pintar_fila(msg_producto)
    End Sub

    Private Sub msg_producto_DblClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles msg_producto.DblClick
        If rbt_ventas.checked = True Then
            Dim venta As New ventas
            msg_producto.Col = 0
            venta.actualizargrid_detalle(venta.detalle(Val(msg_producto.Text)), detalleventa.msg_detalle)
            detalleventa.Show()
        Else
            Dim producto As String
            msg_producto.Col = 6
            If msg_producto.Text = 0 Then
                MsgBox("No hay stock")
            Else
                With msg_producto
                    .Col = 1
                    producto = .Text + " - "
                    .Col = 2
                    producto = producto + .Text + " - "
                    .Col = 3
                    producto = producto + .Text + " - "
                    .Col = 5
                    importe = importe + Val(.Text)
                    producto = producto + .Text + " - "
                    .Col = 6
                    .Text = (Val(.Text) - 1).ToString
                End With
                msg_producto.Col = 0
                lst_id.Items.Add(msg_producto.Text)
                lst_carro.Items.Add(producto)
                lbl_importe.text = importe
            End If
        End If
    End Sub

    Private Sub btn_quitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_quitar.Click
        If lst_carro.SelectedIndex = -1 Then
            MsgBox("No hay item seleccionado")
        Else
            For x = 0 To msg_producto.Rows - 1
                msg_producto.Row = x
                msg_producto.Col = 0
                If lst_id.SelectedItem = msg_producto.Text Then
                    msg_producto.Col = 5
                    importe = importe - Val(msg_producto.Text)
                    lbl_importe.Text = importe
                    msg_producto.Col = 6
                    msg_producto.Text = (Val(msg_producto.Text) + 1).ToString
                    lst_carro.Items.RemoveAt(lst_carro.SelectedIndex)
                    lst_id.Items.RemoveAt(lst_id.SelectedIndex)
                End If
            Next
        End If
    End Sub

    Private Sub SalirToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem1.Click
        End
    End Sub

    Private Sub msg_producto_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles msg_producto.Enter

    End Sub

    Private Sub lst_carro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lst_carro.Click
        lst_id.SelectedIndex = lst_carro.SelectedIndex
    End Sub

    Private Sub lst_id_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lst_id.Click
        lst_carro.SelectedIndex = lst_id.SelectedIndex
    End Sub

    Private Sub rbt_stock_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbt_stock.CheckedChanged
        btn_mercaderia.Visible = False
        lst_carro.Enabled = True
        lst_id.Enabled = True
        Dim producto As New producto
        producto.actualizargrid(producto.obtenertodo, msg_producto)
    End Sub

    Private Sub rbt_agotado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbt_ventas.CheckedChanged
        btn_mercaderia.Visible = False
        Dim ventas As New ventas
        ventas.actualizargrid(ventas.obtenertodo, msg_producto)
        lst_carro.Enabled = False
        lst_id.Enabled = False
    End Sub

    Private Sub rbt_todo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbt_compras.CheckedChanged
        btn_mercaderia.Visible = True
    End Sub

    Private Sub cbo_buscarpor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo_buscarpor.SelectedIndexChanged
        If cbo_buscarpor.SelectedIndex = 0 Then
            Dim modelo As New Modelo
            modelo.obtenernombre(cbo_filtro)
            cbo_filtro.Enabled = True
        End If
        If cbo_buscarpor.SelectedIndex = 1 Then
            Dim marca As New Marca
            marca.obtenernombre(cbo_filtro)
            cbo_filtro.Enabled = True
        End If
        If cbo_buscarpor.SelectedIndex = 2 Then
            Dim instrumento As New instrumento
            instrumento.obtenernombre(cbo_filtro)
            cbo_filtro.Enabled = True
        End If
    End Sub

    Private Sub cbo_filtro_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo_filtro.SelectedIndexChanged
        If cbo_buscarpor.SelectedIndex = 0 Then
            Dim modelo As New Modelo
            Dim producto As New producto
            producto.actualizargrid(modelo.filtro, msg_producto)
        End If
        If cbo_buscarpor.SelectedIndex = 1 Then
            Dim marca As New Marca
            Dim producto As New producto
            producto.actualizargrid(marca.filtro, msg_producto)
        End If
        If cbo_buscarpor.SelectedIndex = 2 Then
            Dim instrumento As New instrumento
            Dim producto As New producto
            producto.actualizargrid(instrumento.filtro, msg_producto)
        End If
    End Sub

    Private Sub btn_factura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_factura.Click
        config_factura.Show()
    End Sub
End Class
