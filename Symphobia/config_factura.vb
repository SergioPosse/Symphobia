Public Class config_factura

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub config_factura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim clientes As New cliente
        clientes.obtenernombre(cbo_dni)
        Dim pago As New forma_pago
        pago.obtenernombre(cbo_pago)
        txt_importe.Text = importe
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If cbo_dni.SelectedIndex = -1 Then
            MsgBox("Seleccione un cliente")
        ElseIf cbo_pago.SelectedIndex = -1 Then
            MsgBox("Seleccione una forma de pago")
        ElseIf txt_importe.Text = "" Then
            MsgBox("Ingrese el importe")
        ElseIf rbt_a.Checked = False And rbt_b.Checked = False And rbt_c.Checked = False Then
            MsgBox("Seleccione un tipo de factura")
        Else
            Dim ventas As New ventas
            ventas.agregar()
            ventas.agregar_detalle()
        End If
    End Sub
End Class