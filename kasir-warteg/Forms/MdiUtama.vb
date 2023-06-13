Public Class MdiUtama

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        FormLogin.txtUsernameLogin.Text = ""
        FormLogin.txtPasswordLogin.Text = ""


        FormDataKasir.Close()
        FormDataTransaksi.Close()
        FormLogin.Close()
        FormPaketMakanan.Close()
        FormTransaksi.Close()
        LoginToolStripMenuItem.Visible = True
        MasterToolStripMenuItem.Visible = False
        TransaksiToolStripMenuItem1.Visible = False
        MakananToolStripMenuItem1.Visible = False
        LogoutToolStripMenuItem.Visible = False
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub MakananToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MakananToolStripMenuItem1.Click
        'Call FormPaketMakananVisible()
        FormPaketMakanan.MdiParent = Me
        FormPaketMakanan.Show()
        FormPaketMakanan.Focus()
        'Me.Hide()
    End Sub

    Private Sub TransaksiToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TransaksiToolStripMenuItem1.Click
        'Call FormTransaksiVisible()
        'Me.Hide()

        FormTransaksi.MdiParent = Me
        FormTransaksi.Show()
        FormTransaksi.Focus()
    End Sub

    Private Sub MenuStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub KasirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KasirToolStripMenuItem.Click
        FormDataKasir.MdiParent = Me
        FormDataKasir.Focus()
        FormDataKasir.Show()
    End Sub

    Private Sub TransaksiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TransaksiToolStripMenuItem.Click
        FormDataTransaksi.MdiParent = Me
        FormDataTransaksi.Focus()
        FormDataTransaksi.Show()
    End Sub

    Private Sub LoginToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoginToolStripMenuItem.Click
        FormLogin.MdiParent = Me
        FormLogin.Focus()
        FormLogin.Show()
    End Sub

    Private Sub MdiUtama_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MasterToolStripMenuItem.Visible = False
        TransaksiToolStripMenuItem1.Visible = False
        MakananToolStripMenuItem1.Visible = False
        LogoutToolStripMenuItem.Visible = False
    End Sub
End Class