Imports System.Data.Odbc
Public Class FormLogin

    Private Sub cbShowPass_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbShowPassLogin.CheckedChanged
        If cbShowPassLogin.CheckState = CheckState.Checked Then
            txtPasswordLogin.UseSystemPasswordChar = False
        Else
            txtPasswordLogin.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub txtPasswordLogin_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPasswordLogin.TextChanged
        txtPasswordLogin.UseSystemPasswordChar = True
    End Sub

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        Try
            Call KoneksiDb()
            MyDb = "SELECT * FROM kasir WHERE username='" & txtUsernameLogin.Text & "' AND password = '" & txtPasswordLogin.Text & "'"
            Cmd = New OdbcCommand(MyDb, Conn)
            Rd = Cmd.ExecuteReader
            If Rd.HasRows Then
                Call FormMenuUtamaVisible()
                Me.Hide()
                MdiUtama.MasterToolStripMenuItem.Visible = True
                MdiUtama.TransaksiToolStripMenuItem1.Visible = True
                MdiUtama.MakananToolStripMenuItem1.Visible = True
                MdiUtama.LogoutToolStripMenuItem.Visible = True
                MdiUtama.LoginToolStripMenuItem.Visible = False

            Else
                Rd.Close()
                MessageBox.Show("Login gagal, Username dan Password salah", "Informasi",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtPasswordLogin.Text = ""
                txtUsernameLogin.Text = ""
                txtUsernameLogin.Focus()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub FormLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
