<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLogin
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
        Me.cbShowPassLogin = New System.Windows.Forms.CheckBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.txtPasswordLogin = New System.Windows.Forms.TextBox()
        Me.txtUsernameLogin = New System.Windows.Forms.TextBox()
        Me.lblPasswordLogin = New System.Windows.Forms.Label()
        Me.lblUsernameLogin = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cbShowPassLogin
        '
        Me.cbShowPassLogin.AutoSize = True
        Me.cbShowPassLogin.Location = New System.Drawing.Point(102, 165)
        Me.cbShowPassLogin.Name = "cbShowPassLogin"
        Me.cbShowPassLogin.Size = New System.Drawing.Size(102, 17)
        Me.cbShowPassLogin.TabIndex = 14
        Me.cbShowPassLogin.Text = "Show Password"
        Me.cbShowPassLogin.UseVisualStyleBackColor = True
        '
        'btnLogin
        '
        Me.btnLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.257!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.Location = New System.Drawing.Point(102, 188)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(125, 23)
        Me.btnLogin.TabIndex = 13
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'txtPasswordLogin
        '
        Me.txtPasswordLogin.Location = New System.Drawing.Point(102, 140)
        Me.txtPasswordLogin.Name = "txtPasswordLogin"
        Me.txtPasswordLogin.Size = New System.Drawing.Size(125, 20)
        Me.txtPasswordLogin.TabIndex = 12
        '
        'txtUsernameLogin
        '
        Me.txtUsernameLogin.Location = New System.Drawing.Point(102, 91)
        Me.txtUsernameLogin.Name = "txtUsernameLogin"
        Me.txtUsernameLogin.Size = New System.Drawing.Size(125, 20)
        Me.txtUsernameLogin.TabIndex = 11
        '
        'lblPasswordLogin
        '
        Me.lblPasswordLogin.AutoSize = True
        Me.lblPasswordLogin.Location = New System.Drawing.Point(35, 140)
        Me.lblPasswordLogin.Name = "lblPasswordLogin"
        Me.lblPasswordLogin.Size = New System.Drawing.Size(53, 13)
        Me.lblPasswordLogin.TabIndex = 10
        Me.lblPasswordLogin.Text = "Password"
        '
        'lblUsernameLogin
        '
        Me.lblUsernameLogin.AutoSize = True
        Me.lblUsernameLogin.Location = New System.Drawing.Point(33, 94)
        Me.lblUsernameLogin.Name = "lblUsernameLogin"
        Me.lblUsernameLogin.Size = New System.Drawing.Size(55, 13)
        Me.lblUsernameLogin.TabIndex = 9
        Me.lblUsernameLogin.Text = "Username"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(96, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 20)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Login Kasir"
        '
        'FormLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.cbShowPassLogin)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtPasswordLogin)
        Me.Controls.Add(Me.txtUsernameLogin)
        Me.Controls.Add(Me.lblPasswordLogin)
        Me.Controls.Add(Me.lblUsernameLogin)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormLogin"
        Me.Text = "FormLogin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbShowPassLogin As System.Windows.Forms.CheckBox
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents txtPasswordLogin As System.Windows.Forms.TextBox
    Friend WithEvents txtUsernameLogin As System.Windows.Forms.TextBox
    Friend WithEvents lblPasswordLogin As System.Windows.Forms.Label
    Friend WithEvents lblUsernameLogin As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
