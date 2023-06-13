Imports System.Data.Odbc
Public Class FormDataTransaksi

    Private Sub FormDataTransaksi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call KoneksiDb()
        Da = New OdbcDataAdapter("SELECT id_transaksi AS NOMOR_TRANSAKSI, id_kasir AS ID_KASIR, tanggal AS TANGGAL FROM transaksi", Conn)
        Ds = New DataSet
        Ds.Clear()
        Da.Fill(Ds, "transaksi")
        DataGridView1.DataSource = (Ds.Tables("transaksi"))
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        Da = New OdbcDataAdapter("SELECT id_transaksi AS NOMOR_TRANSAKSI, id_kasir AS ID_KASIR, tanggal AS TANGGAL FROM transaksi", Conn)
        Ds = New DataSet
        Ds.Clear()
        Da.Fill(Ds, "transaksi")
        DataGridView1.DataSource = (Ds.Tables("transaksi"))
    End Sub
End Class