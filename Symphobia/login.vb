Imports MySql.Data.MySqlClient
Imports System.Data
Public Class login

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim nombre As New MySqlParameter("@nombre", MySqlDbType.Text)
        nombre.Value = cbo_empresa.SelectedItem
        Dim buscar As New MySqlCommand("SELECT * FROM empresa WHERE emp_nomb=@nombre", conex)
        buscar.Parameters.Add(nombre)
        conex.Open()
        Dim adapter As New MySqlDataAdapter(buscar)
        conex.Close()
        Dim dataset As New DataSet
        adapter.Fill(dataset, "empresa")
        login_empresa = dataset.Tables("empresa")
        Me.Hide()
        main.Show()
    End Sub

    Private Sub login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim empresaa As New Empresa
        empresaa.obtenernombre(cbo_empresa)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Application.Exit()
    End Sub
End Class