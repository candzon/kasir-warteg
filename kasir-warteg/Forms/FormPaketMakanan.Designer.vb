<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPaketMakanan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblIdPaket = New System.Windows.Forms.Label()
        Me.txtIdPaketMakanan = New System.Windows.Forms.TextBox()
        Me.lblNama = New System.Windows.Forms.Label()
        Me.lblKeterangan = New System.Windows.Forms.Label()
        Me.txtKeteranganPaketMakanan = New System.Windows.Forms.RichTextBox()
        Me.lblHarga = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnInput = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.txtNamaPaketMakanan = New System.Windows.Forms.TextBox()
        Me.txtHargaPaketMakanan = New System.Windows.Forms.TextBox()
        Me.btnBuka = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(190, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(180, 22)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Form Paket Makanan"
        '
        'lblIdPaket
        '
        Me.lblIdPaket.AutoSize = True
        Me.lblIdPaket.Location = New System.Drawing.Point(61, 92)
        Me.lblIdPaket.Name = "lblIdPaket"
        Me.lblIdPaket.Size = New System.Drawing.Size(49, 13)
        Me.lblIdPaket.TabIndex = 5
        Me.lblIdPaket.Text = "ID Paket"
        '
        'txtIdPaketMakanan
        '
        Me.txtIdPaketMakanan.Location = New System.Drawing.Point(178, 85)
        Me.txtIdPaketMakanan.Name = "txtIdPaketMakanan"
        Me.txtIdPaketMakanan.Size = New System.Drawing.Size(199, 20)
        Me.txtIdPaketMakanan.TabIndex = 6
        '
        'lblNama
        '
        Me.lblNama.AutoSize = True
        Me.lblNama.Location = New System.Drawing.Point(59, 122)
        Me.lblNama.Name = "lblNama"
        Me.lblNama.Size = New System.Drawing.Size(66, 13)
        Me.lblNama.TabIndex = 5
        Me.lblNama.Text = "Nama Paket"
        '
        'lblKeterangan
        '
        Me.lblKeterangan.AutoSize = True
        Me.lblKeterangan.Location = New System.Drawing.Point(60, 148)
        Me.lblKeterangan.Name = "lblKeterangan"
        Me.lblKeterangan.Size = New System.Drawing.Size(62, 13)
        Me.lblKeterangan.TabIndex = 5
        Me.lblKeterangan.Text = "Keterangan"
        '
        'txtKeteranganPaketMakanan
        '
        Me.txtKeteranganPaketMakanan.Location = New System.Drawing.Point(179, 148)
        Me.txtKeteranganPaketMakanan.Name = "txtKeteranganPaketMakanan"
        Me.txtKeteranganPaketMakanan.Size = New System.Drawing.Size(199, 60)
        Me.txtKeteranganPaketMakanan.TabIndex = 7
        Me.txtKeteranganPaketMakanan.Text = ""
        '
        'lblHarga
        '
        Me.lblHarga.AutoSize = True
        Me.lblHarga.Location = New System.Drawing.Point(61, 233)
        Me.lblHarga.Name = "lblHarga"
        Me.lblHarga.Size = New System.Drawing.Size(36, 13)
        Me.lblHarga.TabIndex = 5
        Me.lblHarga.Text = "Harga"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(57, 314)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(445, 105)
        Me.DataGridView1.TabIndex = 8
        '
        'btnInput
        '
        Me.btnInput.Location = New System.Drawing.Point(61, 266)
        Me.btnInput.Name = "btnInput"
        Me.btnInput.Size = New System.Drawing.Size(75, 23)
        Me.btnInput.TabIndex = 9
        Me.btnInput.Text = "Simpan"
        Me.btnInput.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(142, 266)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnEdit.TabIndex = 9
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(223, 266)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 9
        Me.btnDelete.Text = "Hapus"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'txtNamaPaketMakanan
        '
        Me.txtNamaPaketMakanan.Location = New System.Drawing.Point(179, 119)
        Me.txtNamaPaketMakanan.Name = "txtNamaPaketMakanan"
        Me.txtNamaPaketMakanan.Size = New System.Drawing.Size(199, 20)
        Me.txtNamaPaketMakanan.TabIndex = 10
        '
        'txtHargaPaketMakanan
        '
        Me.txtHargaPaketMakanan.Location = New System.Drawing.Point(180, 230)
        Me.txtHargaPaketMakanan.Name = "txtHargaPaketMakanan"
        Me.txtHargaPaketMakanan.Size = New System.Drawing.Size(198, 20)
        Me.txtHargaPaketMakanan.TabIndex = 11
        '
        'btnBuka
        '
        Me.btnBuka.Location = New System.Drawing.Point(304, 266)
        Me.btnBuka.Name = "btnBuka"
        Me.btnBuka.Size = New System.Drawing.Size(75, 23)
        Me.btnBuka.TabIndex = 9
        Me.btnBuka.Text = "Buka"
        Me.btnBuka.UseVisualStyleBackColor = True
        '
        'FormPaketMakanan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(514, 431)
        Me.Controls.Add(Me.txtHargaPaketMakanan)
        Me.Controls.Add(Me.txtNamaPaketMakanan)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnBuka)
        Me.Controls.Add(Me.btnInput)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtKeteranganPaketMakanan)
        Me.Controls.Add(Me.txtIdPaketMakanan)
        Me.Controls.Add(Me.lblKeterangan)
        Me.Controls.Add(Me.lblHarga)
        Me.Controls.Add(Me.lblNama)
        Me.Controls.Add(Me.lblIdPaket)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormPaketMakanan"
        Me.Text = "Form Paket Makanan"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblIdPaket As System.Windows.Forms.Label
    Friend WithEvents txtIdPaketMakanan As System.Windows.Forms.TextBox
    Friend WithEvents lblNama As System.Windows.Forms.Label
    Friend WithEvents lblKeterangan As System.Windows.Forms.Label
    Friend WithEvents txtKeteranganPaketMakanan As System.Windows.Forms.RichTextBox
    Friend WithEvents lblHarga As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnInput As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents txtNamaPaketMakanan As System.Windows.Forms.TextBox
    Friend WithEvents txtHargaPaketMakanan As System.Windows.Forms.TextBox
    Friend WithEvents btnBuka As System.Windows.Forms.Button
End Class
