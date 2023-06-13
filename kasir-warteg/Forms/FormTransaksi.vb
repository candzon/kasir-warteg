Imports System.Data.Odbc
Public Class FormTransaksi

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


    Sub TransaksiSelanjutnyaTextBoxKosong()
        txtIdKasir.Text = ""
        txtIdTransaksi.Text = ""
    End Sub


    Private Sub btnTransaksiSelanjutnya_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTransaksiSelanjutnya.Click
        Dim DateFormTransaksi As String
        DateFormTransaksi = dtpFormTransaksi.Value.Year.ToString + "-" + dtpFormTransaksi.Value.Month.ToString + "-" + dtpFormTransaksi.Value.Day.ToString + "-" + dtpFormTransaksi.Value.TimeOfDay.ToString
        If txtIdTransaksi.Text = "" Or dtpFormTransaksi.Text = "" Or txtIdKasir.Text = "" Then
            MsgBox("Pastikan Semua Field Terisi!")
        Else
            Call KoneksiDb()
            Cmd = New OdbcCommand("INSERT INTO transaksi values ('" & txtIdTransaksi.Text & "', '" & txtIdKasir.Text & "', '" & DateFormTransaksi & "')", Conn)
            Cmd.ExecuteNonQuery()
            MsgBox("Transaksi selanjutnya!")
            cbIdPaket.Enabled = True
            btnBuy.Enabled = True
            btnDelete.Enabled = True
            txtJumlah.Enabled = True
        End If
           
    End Sub
    Sub MunculIdPaket()
        Call KoneksiDb()
        cbIdPaket.Items.Clear()
        Cmd = New OdbcCommand("SELECT * FROM paket_makanan", Conn)
        Rd = Cmd.ExecuteReader
        Do While Rd.Read
            cbIdPaket.Items.Add(Rd.Item("id_paket"))
        Loop
    End Sub

    Sub MunculGridDetail()
        Call KoneksiDb()
        Da = New OdbcDataAdapter("SELECT id_transaksi AS NOMOR, id_paket AS KODE_PAKET, harga AS HARGA, jumlah AS DIBELI, total_harga AS TOTAL FROM detail_transaksi", Conn)
        Ds = New DataSet
        Ds.Clear()
        Da.Fill(Ds, "detail_transaksi")
        DataGridView1.DataSource = (Ds.Tables("detail_transaksi"))
    End Sub


    Sub DefaultComboBox()
        cbIdPaket.Text = "Pilih Paket"
    End Sub


    Sub LockTextBoxTransaksi()
        cbIdPaket.Enabled = False
        btnBuy.Enabled = False
        btnTransaksiSelanjutnya.Enabled = False
        txtJumlah.Enabled = False
        txtIdKasir.Enabled = False
        dtpFormTransaksi.Enabled = False
        txtIdTransaksi.Enabled = False
        btnDelete.Enabled = False

        cbIdPaket.ResetText()
        txtNamaPaket.Clear()
        txtHarga.Clear()
        txtJumlah.Clear()
    End Sub

    Private Sub FormTransaksi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call MunculIdPaket()
        Call KondisiAwal()
        Call MunculGridDetail()
        Call LockTextBoxTransaksi()
    End Sub


    Private Sub cbIdPaket_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbIdPaket.SelectedIndexChanged
        Call KoneksiDb()
        Cmd = New OdbcCommand("SELECT * FROM paket_makanan where id_paket='" & cbIdPaket.Text & "'", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows Then
            txtNamaPaket.Text = Rd.Item(1)
            txtHarga.Text = Rd.Item(3)
        End If
    End Sub


    Sub KondisiAwal()
        cbIdPaket.Text = ""
        txtJumlah.Text = 0
        txtNamaPaket.Text = ""
        txtHarga.Text = 0
        txtTotal.Text = 0
    End Sub


    Sub SumTotal()
        Dim result = Val(txtHarga.Text) * Val(txtJumlah.Text)
        txtTotal.Text = result
    End Sub


    Private Sub btnBuy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuy.Click


        If cbIdPaket.Text = "" Or txtJumlah.Text = "" Then
            MsgBox("pastikan semua field terisi!")
        Else
            Call KoneksiDb()
            Dim InputData As String = "INSERT INTO detail_transaksi (`id_transaksi`, `id_paket`, `harga`, `jumlah`, `total_harga`) VALUES ('" & txtIdTransaksi.Text & "', '" & cbIdPaket.Text & "', '" & txtHarga.Text & "', '" & txtJumlah.Text & "', '" & txtTotal.Text & "')"
            Cmd = New OdbcCommand(InputData, Conn)
            Cmd.ExecuteNonQuery()
            MsgBox("Input Data Berhasil")
            Call LockTextBoxTransaksi()
            MunculGridDetail()
        End If
    End Sub

    Private Sub txtTotal_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTotal.TextChanged
    End Sub

    Private Sub txtJumlah_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtJumlah.TextChanged
        Call SumTotal()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Call KoneksiDb()
        Dim DeleteData As String = "DELETE FROM transaksi where id_transaksi =('" & txtIdTransaksi.Text & "')"
        Cmd = New OdbcCommand(DeleteData, Conn)
        Cmd.ExecuteNonQuery()
        MsgBox("Delete Data Berhasil")
        Call KondisiAwal()
        Call MunculGridDetail()
    End Sub


    Private Sub btnBuka_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuka.Click
        txtIdKasir.Enabled = True
        dtpFormTransaksi.Enabled = True
        txtIdTransaksi.Enabled = True
        btnTransaksiSelanjutnya.Enabled = True
        btnDelete.Enabled = True
    End Sub
End Class