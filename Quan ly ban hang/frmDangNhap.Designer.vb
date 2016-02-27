<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDangNhap
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDangNhap))
        Me.ptbDangNhap = New System.Windows.Forms.PictureBox()
        Me.lblTieuDe = New System.Windows.Forms.Label()
        Me.ptbLogo = New System.Windows.Forms.PictureBox()
        Me.lblVien1 = New System.Windows.Forms.Label()
        Me.lblVien2 = New System.Windows.Forms.Label()
        Me.lblNguoiDung = New System.Windows.Forms.Label()
        Me.lblMatKhau = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNguoiDung = New System.Windows.Forms.TextBox()
        Me.txtMatKhau = New System.Windows.Forms.TextBox()
        Me.btnDangNhap = New System.Windows.Forms.Button()
        Me.btnHuyBo = New System.Windows.Forms.Button()
        Me.lblVien3 = New System.Windows.Forms.Label()
        Me.lblVien4 = New System.Windows.Forms.Label()
        Me.lblBanQuyen1 = New System.Windows.Forms.Label()
        Me.lblBanQuyen2 = New System.Windows.Forms.Label()
        CType(Me.ptbDangNhap, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ptbDangNhap
        '
        Me.ptbDangNhap.BackgroundImage = CType(resources.GetObject("ptbDangNhap.BackgroundImage"), System.Drawing.Image)
        Me.ptbDangNhap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ptbDangNhap.Location = New System.Drawing.Point(32, 80)
        Me.ptbDangNhap.Margin = New System.Windows.Forms.Padding(4)
        Me.ptbDangNhap.Name = "ptbDangNhap"
        Me.ptbDangNhap.Size = New System.Drawing.Size(210, 161)
        Me.ptbDangNhap.TabIndex = 0
        Me.ptbDangNhap.TabStop = False
        '
        'lblTieuDe
        '
        Me.lblTieuDe.AutoSize = True
        Me.lblTieuDe.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTieuDe.ForeColor = System.Drawing.Color.Red
        Me.lblTieuDe.Location = New System.Drawing.Point(8, 9)
        Me.lblTieuDe.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTieuDe.Name = "lblTieuDe"
        Me.lblTieuDe.Size = New System.Drawing.Size(442, 40)
        Me.lblTieuDe.TabIndex = 1
        Me.lblTieuDe.Text = "Phần mềm quản lý bán hàng"
        '
        'ptbLogo
        '
        Me.ptbLogo.BackgroundImage = CType(resources.GetObject("ptbLogo.BackgroundImage"), System.Drawing.Image)
        Me.ptbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ptbLogo.Location = New System.Drawing.Point(458, 25)
        Me.ptbLogo.Margin = New System.Windows.Forms.Padding(4)
        Me.ptbLogo.Name = "ptbLogo"
        Me.ptbLogo.Size = New System.Drawing.Size(133, 62)
        Me.ptbLogo.TabIndex = 2
        Me.ptbLogo.TabStop = False
        '
        'lblVien1
        '
        Me.lblVien1.AutoSize = True
        Me.lblVien1.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblVien1.Location = New System.Drawing.Point(-81, 49)
        Me.lblVien1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblVien1.Name = "lblVien1"
        Me.lblVien1.Size = New System.Drawing.Size(539, 16)
        Me.lblVien1.TabIndex = 1
        Me.lblVien1.Text = "................................................................................." &
    "................................................................................" &
    "................"
        '
        'lblVien2
        '
        Me.lblVien2.AutoSize = True
        Me.lblVien2.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblVien2.Location = New System.Drawing.Point(563, 49)
        Me.lblVien2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblVien2.Name = "lblVien2"
        Me.lblVien2.Size = New System.Drawing.Size(50, 16)
        Me.lblVien2.TabIndex = 3
        Me.lblVien2.Text = ".............."
        '
        'lblNguoiDung
        '
        Me.lblNguoiDung.AutoSize = True
        Me.lblNguoiDung.Location = New System.Drawing.Point(269, 135)
        Me.lblNguoiDung.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNguoiDung.Name = "lblNguoiDung"
        Me.lblNguoiDung.Size = New System.Drawing.Size(77, 16)
        Me.lblNguoiDung.TabIndex = 4
        Me.lblNguoiDung.Text = "Người dùng"
        '
        'lblMatKhau
        '
        Me.lblMatKhau.AutoSize = True
        Me.lblMatKhau.Location = New System.Drawing.Point(269, 176)
        Me.lblMatKhau.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMatKhau.Name = "lblMatKhau"
        Me.lblMatKhau.Size = New System.Drawing.Size(62, 16)
        Me.lblMatKhau.TabIndex = 5
        Me.lblMatKhau.Text = "Mật khẩu"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label6.Location = New System.Drawing.Point(-7, 245)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(620, 16)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = resources.GetString("Label6.Text")
        '
        'txtNguoiDung
        '
        Me.txtNguoiDung.Location = New System.Drawing.Point(391, 135)
        Me.txtNguoiDung.Name = "txtNguoiDung"
        Me.txtNguoiDung.Size = New System.Drawing.Size(200, 22)
        Me.txtNguoiDung.TabIndex = 1
        '
        'txtMatKhau
        '
        Me.txtMatKhau.Location = New System.Drawing.Point(391, 173)
        Me.txtMatKhau.Name = "txtMatKhau"
        Me.txtMatKhau.Size = New System.Drawing.Size(200, 22)
        Me.txtMatKhau.TabIndex = 2
        Me.txtMatKhau.UseSystemPasswordChar = True
        '
        'btnDangNhap
        '
        Me.btnDangNhap.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDangNhap.Location = New System.Drawing.Point(391, 274)
        Me.btnDangNhap.Name = "btnDangNhap"
        Me.btnDangNhap.Size = New System.Drawing.Size(106, 32)
        Me.btnDangNhap.TabIndex = 4
        Me.btnDangNhap.Text = "Đăng nhập"
        Me.btnDangNhap.UseVisualStyleBackColor = True
        '
        'btnHuyBo
        '
        Me.btnHuyBo.Location = New System.Drawing.Point(516, 274)
        Me.btnHuyBo.Name = "btnHuyBo"
        Me.btnHuyBo.Size = New System.Drawing.Size(75, 32)
        Me.btnHuyBo.TabIndex = 5
        Me.btnHuyBo.Text = "Hủy bỏ"
        Me.btnHuyBo.UseVisualStyleBackColor = True
        '
        'lblVien3
        '
        Me.lblVien3.AutoSize = True
        Me.lblVien3.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblVien3.Location = New System.Drawing.Point(343, 136)
        Me.lblVien3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblVien3.Name = "lblVien3"
        Me.lblVien3.Size = New System.Drawing.Size(48, 16)
        Me.lblVien3.TabIndex = 12
        Me.lblVien3.Text = "----------"
        '
        'lblVien4
        '
        Me.lblVien4.AutoSize = True
        Me.lblVien4.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblVien4.Location = New System.Drawing.Point(331, 176)
        Me.lblVien4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblVien4.Name = "lblVien4"
        Me.lblVien4.Size = New System.Drawing.Size(60, 16)
        Me.lblVien4.TabIndex = 13
        Me.lblVien4.Text = "-------------"
        '
        'lblBanQuyen1
        '
        Me.lblBanQuyen1.AutoSize = True
        Me.lblBanQuyen1.Location = New System.Drawing.Point(12, 274)
        Me.lblBanQuyen1.Name = "lblBanQuyen1"
        Me.lblBanQuyen1.Size = New System.Drawing.Size(213, 16)
        Me.lblBanQuyen1.TabIndex = 17
        Me.lblBanQuyen1.Text = "Họ và tên: PHẠM NHẬT TRƯỜNG"
        '
        'lblBanQuyen2
        '
        Me.lblBanQuyen2.AutoSize = True
        Me.lblBanQuyen2.Location = New System.Drawing.Point(12, 296)
        Me.lblBanQuyen2.Name = "lblBanQuyen2"
        Me.lblBanQuyen2.Size = New System.Drawing.Size(197, 16)
        Me.lblBanQuyen2.TabIndex = 18
        Me.lblBanQuyen2.Text = "MSSV: PS03299 - Lớp: PT10303"
        '
        'frmDangNhap
        '
        Me.AcceptButton = Me.btnDangNhap
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(606, 321)
        Me.Controls.Add(Me.lblBanQuyen2)
        Me.Controls.Add(Me.lblBanQuyen1)
        Me.Controls.Add(Me.lblVien4)
        Me.Controls.Add(Me.lblVien3)
        Me.Controls.Add(Me.btnHuyBo)
        Me.Controls.Add(Me.btnDangNhap)
        Me.Controls.Add(Me.txtMatKhau)
        Me.Controls.Add(Me.txtNguoiDung)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblMatKhau)
        Me.Controls.Add(Me.lblNguoiDung)
        Me.Controls.Add(Me.lblVien2)
        Me.Controls.Add(Me.lblVien1)
        Me.Controls.Add(Me.ptbLogo)
        Me.Controls.Add(Me.lblTieuDe)
        Me.Controls.Add(Me.ptbDangNhap)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "frmDangNhap"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Phần mềm quản lý bán hàng"
        CType(Me.ptbDangNhap, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ptbDangNhap As PictureBox
    Friend WithEvents lblTieuDe As Label
    Friend WithEvents ptbLogo As PictureBox
    Friend WithEvents lblVien1 As Label
    Friend WithEvents lblVien2 As Label
    Friend WithEvents lblNguoiDung As Label
    Friend WithEvents lblMatKhau As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtNguoiDung As TextBox
    Friend WithEvents txtMatKhau As TextBox
    Friend WithEvents btnDangNhap As Button
    Friend WithEvents btnHuyBo As Button
    Friend WithEvents lblVien3 As Label
    Friend WithEvents lblVien4 As Label
    Friend WithEvents lblBanQuyen1 As Label
    Friend WithEvents lblBanQuyen2 As Label
End Class
