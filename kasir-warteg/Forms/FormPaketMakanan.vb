Imports System.Data.Odbc
Public Class FormPaketMakanan


    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call FormLoginVisible()
        Me.Hide()
        If FormLogin.Visible = True Or FormLogin.Enabled = True Then
            FormLogin.txtUsernameLogin.Text = ""
            FormLogin.txtPasswordLogin.Text = ""
            FormLogin.txtUsernameLogin.Focus()
        Else
            'Ketika FormLogin.Visible = False Atau FormLogin.Enabled = False maka keluar pesan "Karena Kondisi tidak terpenuhi!"
            MessageBox.Show("Karena Kondisi tidak terpenuhi!")
        End If

    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FormLogin.Close()
    End Sub

    Private Sub BackToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call FormMenuUtamaVisible()
        Me.Hide()
    End Sub

    Private Sub FormPaketMakanan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call KondisiAwal()
        txtIdPaketMakanan.Enabled = False
        txtNamaPaketMakanan.Enabled = False
        txtKeteranganPaketMakanan.Enabled = False
        txtHargaPaketMakanan.Enabled = False
        btnInput.Enabled = False
        btnDelete.Enabled = False
        btnEdit.Enabled = False
    End Sub



    Sub KondisiAwal()
        txtIdPaketMakanan.Text = ""
        txtNamaPaketMakanan.Text = ""
        txtKeteranganPaketMakanan.Text = ""
        txtHargaPaketMakanan.Text = ""
        'btnInput.Text = "INPUT"
        'btnEdit.Text = "EDIT"
        'btnDelete.Text = "HAPUS"


        Call KoneksiDb()
        Da = New OdbcDataAdapter("SELECT id_paket AS KODE_PAKET, nama_paket AS NAMA_PAKET, keterangan AS KETERANGAN_PAKET, harga AS HARGA  FROM paket_makanan", Conn)
        Ds = New DataSet
        Ds.Clear()
        Da.Fill(Ds, "paket_makanan")
        DataGridView1.DataSource = (Ds.Tables("paket_makanan"))
    End Sub

    Private Sub btnInput_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInput.Click
        If txtIdPaketMakanan.Text = "" Or txtNamaPaketMakanan.Text = "" Or txtKeteranganPaketMakanan.Text = "" Or txtHargaPaketMakanan.Text = "" Then
            MsgBox("pastikan semua field terisi!")
        Else
            Call KoneksiDb()
            Dim InputData As String = "INSERT INTO paket_makanan values ('" & txtIdPaketMakanan.Text & "', '" & txtNamaPaketMakanan.Text & "', '" & txtKeteranganPaketMakanan.Text & "', '" & txtHargaPaketMakanan.Text & "')"
            Cmd = New OdbcCommand(InputData, Conn)
            Cmd.ExecuteNonQuery()
            MsgBox("Input Data Berhasil")
            Call KondisiAwal()
        End If
    End Sub

    Private Sub btnBuka_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuka.Click
        txtIdPaketMakanan.Enabled = True
        txtNamaPaketMakanan.Enabled = True
        txtKeteranganPaketMakanan.Enabled = True
        txtHargaPaketMakanan.Enabled = True
        btnInput.Enabled = True
        btnEdit.Enabled = True
        btnDelete.Enabled = True
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If txtIdPaketMakanan.Text = "" Then
            MsgBox("pastikan field ID terisi!")
        Else
            Call KoneksiDb()
            Dim DeleteData As String = "DELETE FROM paket_makanan where id_paket =('" & txtIdPaketMakanan.Text & "')"
            Cmd = New OdbcCommand(DeleteData, Conn)
            Cmd.ExecuteNonQuery()
            MsgBox("Delete Data Berhasil")
            Call KondisiAwal()
        End If
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If txtHargaPaketMakanan.Text = "" Then
            MsgBox("pastikan field HARGA terisi!")
        Else
            Call KoneksiDb()
            Dim EditData As String = "UPDATE paket_makanan SET harga =('" & txtHargaPaketMakanan.Text & "') WHERE id_paket =('" & txtIdPaketMakanan.Text & "') "
            Cmd = New OdbcCommand(EditData, Conn)
            Cmd.ExecuteNonQuery()
            MsgBox("Edit Data Berhasil")
            Call KondisiAwal()
        End If
    End Sub

End Class