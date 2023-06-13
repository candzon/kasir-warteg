Imports System.Data.Odbc
Public Class FormDataKasir

    Private Sub FormDataKasir_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call KoneksiDb()
        Da = New OdbcDataAdapter("SELECT * FROM kasir", Conn)
        Ds = New DataSet
        Ds.Clear()
        Da.Fill(Ds, "kasir")
        DataGridView1.DataSource = (Ds.Tables("kasir"))
    End Sub
End Class