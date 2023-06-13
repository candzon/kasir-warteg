<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTransaksi
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
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnBuy = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtJumlah = New System.Windows.Forms.TextBox()
        Me.txtIdTransaksi = New System.Windows.Forms.TextBox()
        Me.lblHarga = New System.Windows.Forms.Label()
        Me.lblJumlah = New System.Windows.Forms.Label()
        Me.lblIdTransaksi = New System.Windows.Forms.Label()
        Me.lblTanggal = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnTransaksiSelanjutnya = New System.Windows.Forms.Button()
        Me.txtHarga = New System.Windows.Forms.TextBox()
        Me.lblIdPaket = New System.Windows.Forms.Label()
        Me.cbIdPaket = New System.Windows.Forms.ComboBox()
        Me.lblNamaPaket = New System.Windows.Forms.Label()
        Me.txtNamaPaket = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtIdKasir = New System.Windows.Forms.TextBox()
        Me.dtpFormTransaksi = New System.Windows.Forms.DateTimePicker()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.lblRupiah = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.btnBuka = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(268, 321)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 20
        Me.btnDelete.Text = "Hapus"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnBuy
        '
        Me.btnBuy.Location = New System.Drawing.Point(183, 320)
        Me.btnBuy.Name = "btnBuy"
        Me.btnBuy.Size = New System.Drawing.Size(75, 23)
        Me.btnBuy.TabIndex = 21
        Me.btnBuy.Text = "Beli"
        Me.btnBuy.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(45, 349)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(372, 116)
        Me.DataGridView1.TabIndex = 19
        '
        'txtJumlah
        '
        Me.txtJumlah.Location = New System.Drawing.Point(218, 252)
        Me.txtJumlah.Name = "txtJumlah"
        Me.txtJumlah.Size = New System.Drawing.Size(199, 20)
        Me.txtJumlah.TabIndex = 16
        '
        'txtIdTransaksi
        '
        Me.txtIdTransaksi.Location = New System.Drawing.Point(217, 118)
        Me.txtIdTransaksi.Name = "txtIdTransaksi"
        Me.txtIdTransaksi.Size = New System.Drawing.Size(55, 20)
        Me.txtIdTransaksi.TabIndex = 17
        '
        'lblHarga
        '
        Me.lblHarga.AutoSize = True
        Me.lblHarga.Location = New System.Drawing.Point(42, 225)
        Me.lblHarga.Name = "lblHarga"
        Me.lblHarga.Size = New System.Drawing.Size(36, 13)
        Me.lblHarga.TabIndex = 12
        Me.lblHarga.Text = "Harga"
        '
        'lblJumlah
        '
        Me.lblJumlah.AutoSize = True
        Me.lblJumlah.Location = New System.Drawing.Point(42, 255)
        Me.lblJumlah.Name = "lblJumlah"
        Me.lblJumlah.Size = New System.Drawing.Size(40, 13)
        Me.lblJumlah.TabIndex = 11
        Me.lblJumlah.Text = "Jumlah"
        '
        'lblIdTransaksi
        '
        Me.lblIdTransaksi.AutoSize = True
        Me.lblIdTransaksi.Location = New System.Drawing.Point(42, 121)
        Me.lblIdTransaksi.Name = "lblIdTransaksi"
        Me.lblIdTransaksi.Size = New System.Drawing.Size(67, 13)
        Me.lblIdTransaksi.TabIndex = 14
        Me.lblIdTransaksi.Text = "ID Transaksi"
        '
        'lblTanggal
        '
        Me.lblTanggal.AutoSize = True
        Me.lblTanggal.Location = New System.Drawing.Point(42, 79)
        Me.lblTanggal.Name = "lblTanggal"
        Me.lblTanggal.Size = New System.Drawing.Size(46, 13)
        Me.lblTanggal.TabIndex = 13
        Me.lblTanggal.Text = "Tanggal"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(113, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(213, 22)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Form Transaksi Makanan"
        '
        'btnTransaksiSelanjutnya
        '
        Me.btnTransaksiSelanjutnya.Location = New System.Drawing.Point(278, 116)
        Me.btnTransaksiSelanjutnya.Name = "btnTransaksiSelanjutnya"
        Me.btnTransaksiSelanjutnya.Size = New System.Drawing.Size(138, 23)
        Me.btnTransaksiSelanjutnya.TabIndex = 21
        Me.btnTransaksiSelanjutnya.Text = "Transaksi Selanjutnya"
        Me.btnTransaksiSelanjutnya.UseVisualStyleBackColor = True
        '
        'txtHarga
        '
        Me.txtHarga.Enabled = False
        Me.txtHarga.Location = New System.Drawing.Point(218, 222)
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.Size = New System.Drawing.Size(199, 20)
        Me.txtHarga.TabIndex = 16
        '
        'lblIdPaket
        '
        Me.lblIdPaket.AutoSize = True
        Me.lblIdPaket.Location = New System.Drawing.Point(42, 157)
        Me.lblIdPaket.Name = "lblIdPaket"
        Me.lblIdPaket.Size = New System.Drawing.Size(49, 13)
        Me.lblIdPaket.TabIndex = 14
        Me.lblIdPaket.Text = "ID Paket"
        '
        'cbIdPaket
        '
        Me.cbIdPaket.FormattingEnabled = True
        Me.cbIdPaket.Location = New System.Drawing.Point(217, 154)
        Me.cbIdPaket.Name = "cbIdPaket"
        Me.cbIdPaket.Size = New System.Drawing.Size(200, 21)
        Me.cbIdPaket.TabIndex = 22
        '
        'lblNamaPaket
        '
        Me.lblNamaPaket.AutoSize = True
        Me.lblNamaPaket.Location = New System.Drawing.Point(42, 190)
        Me.lblNamaPaket.Name = "lblNamaPaket"
        Me.lblNamaPaket.Size = New System.Drawing.Size(66, 13)
        Me.lblNamaPaket.TabIndex = 14
        Me.lblNamaPaket.Text = "Nama Paket"
        '
        'txtNamaPaket
        '
        Me.txtNamaPaket.Enabled = False
        Me.txtNamaPaket.Location = New System.Drawing.Point(217, 187)
        Me.txtNamaPaket.Name = "txtNamaPaket"
        Me.txtNamaPaket.Size = New System.Drawing.Size(199, 20)
        Me.txtNamaPaket.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(345, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "IDKasir"
        '
        'txtIdKasir
        '
        Me.txtIdKasir.Location = New System.Drawing.Point(392, 37)
        Me.txtIdKasir.Name = "txtIdKasir"
        Me.txtIdKasir.Size = New System.Drawing.Size(48, 20)
        Me.txtIdKasir.TabIndex = 17
        '
        'dtpFormTransaksi
        '
        Me.dtpFormTransaksi.Location = New System.Drawing.Point(216, 79)
        Me.dtpFormTransaksi.Name = "dtpFormTransaksi"
        Me.dtpFormTransaksi.Size = New System.Drawing.Size(200, 20)
        Me.dtpFormTransaksi.TabIndex = 23
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(43, 288)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(63, 13)
        Me.lblTotal.TabIndex = 11
        Me.lblTotal.Text = "Total Harga"
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.SystemColors.Info
        Me.txtTotal.Enabled = False
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(219, 284)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(198, 20)
        Me.txtTotal.TabIndex = 16
        '
        'lblRupiah
        '
        Me.lblRupiah.AutoSize = True
        Me.lblRupiah.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRupiah.Location = New System.Drawing.Point(189, 288)
        Me.lblRupiah.Name = "lblRupiah"
        Me.lblRupiah.Size = New System.Drawing.Size(27, 13)
        Me.lblRupiah.TabIndex = 11
        Me.lblRupiah.Text = "Rp."
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(458, 488)
        Me.ShapeContainer1.TabIndex = 24
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 42
        Me.LineShape1.X2 = 422
        Me.LineShape1.Y1 = 145
        Me.LineShape1.Y2 = 145
        '
        'btnBuka
        '
        Me.btnBuka.Location = New System.Drawing.Point(350, 320)
        Me.btnBuka.Name = "btnBuka"
        Me.btnBuka.Size = New System.Drawing.Size(74, 23)
        Me.btnBuka.TabIndex = 25
        Me.btnBuka.Text = "Buka"
        Me.btnBuka.UseVisualStyleBackColor = True
        '
        'FormTransaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(458, 488)
        Me.Controls.Add(Me.btnBuka)
        Me.Controls.Add(Me.dtpFormTransaksi)
        Me.Controls.Add(Me.cbIdPaket)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnTransaksiSelanjutnya)
        Me.Controls.Add(Me.btnBuy)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtHarga)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.txtJumlah)
        Me.Controls.Add(Me.txtIdKasir)
        Me.Controls.Add(Me.txtIdTransaksi)
        Me.Controls.Add(Me.txtNamaPaket)
        Me.Controls.Add(Me.lblHarga)
        Me.Controls.Add(Me.lblRupiah)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblJumlah)
        Me.Controls.Add(Me.lblNamaPaket)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblIdPaket)
        Me.Controls.Add(Me.lblIdTransaksi)
        Me.Controls.Add(Me.lblTanggal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "FormTransaksi"
        Me.Text = "Form Transaksi Makanan"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnBuy As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txtJumlah As System.Windows.Forms.TextBox
    Friend WithEvents txtIdTransaksi As System.Windows.Forms.TextBox
    Friend WithEvents lblHarga As System.Windows.Forms.Label
    Friend WithEvents lblJumlah As System.Windows.Forms.Label
    Friend WithEvents lblIdTransaksi As System.Windows.Forms.Label
    Friend WithEvents lblTanggal As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnTransaksiSelanjutnya As System.Windows.Forms.Button
    Friend WithEvents txtHarga As System.Windows.Forms.TextBox
    Friend WithEvents lblIdPaket As System.Windows.Forms.Label
    Friend WithEvents cbIdPaket As System.Windows.Forms.ComboBox
    Friend WithEvents lblNamaPaket As System.Windows.Forms.Label
    Friend WithEvents txtNamaPaket As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtIdKasir As System.Windows.Forms.TextBox
    Friend WithEvents dtpFormTransaksi As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents lblRupiah As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents btnBuka As System.Windows.Forms.Button
End Class
