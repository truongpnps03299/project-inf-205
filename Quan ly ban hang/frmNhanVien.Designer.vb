<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNhanVien
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNhanVien))
        Me.btnLamMoi = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.lblBanQuyen2 = New System.Windows.Forms.Label()
        Me.lblBanQuyen1 = New System.Windows.Forms.Label()
        Me.txtSoDienThoai = New System.Windows.Forms.TextBox()
        Me.lblSoDienThoai = New System.Windows.Forms.Label()
        Me.txtDiaChi = New System.Windows.Forms.TextBox()
        Me.lblDiaChi = New System.Windows.Forms.Label()
        Me.txtTenNhanVien = New System.Windows.Forms.TextBox()
        Me.lblTimNhanVien = New System.Windows.Forms.Label()
        Me.lblTenNhanVien = New System.Windows.Forms.Label()
        Me.txtMaNhanVien = New System.Windows.Forms.TextBox()
        Me.lblMaNhanVien = New System.Windows.Forms.Label()
        Me.txtTimNhanVien = New System.Windows.Forms.TextBox()
        Me.dgwNhanVien = New System.Windows.Forms.DataGridView()
        Me.btnQuayLai = New System.Windows.Forms.Button()
        Me.lblVien2 = New System.Windows.Forms.Label()
        Me.lblVien1 = New System.Windows.Forms.Label()
        Me.lblTieuDe = New System.Windows.Forms.Label()
        Me.ptbLogo = New System.Windows.Forms.PictureBox()
        Me.txtMatKhau = New System.Windows.Forms.TextBox()
        Me.lblMatKhau = New System.Windows.Forms.Label()
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.lblQuyen = New System.Windows.Forms.Label()
        Me.txtQuyen = New System.Windows.Forms.TextBox()
        Me.cbbTimKiem = New System.Windows.Forms.ComboBox()
        CType(Me.dgwNhanVien, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnLamMoi
        '
        Me.btnLamMoi.Image = CType(resources.GetObject("btnLamMoi.Image"), System.Drawing.Image)
        Me.btnLamMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLamMoi.Location = New System.Drawing.Point(593, 362)
        Me.btnLamMoi.Name = "btnLamMoi"
        Me.btnLamMoi.Size = New System.Drawing.Size(95, 50)
        Me.btnLamMoi.TabIndex = 12
        Me.btnLamMoi.Text = "Làm mới"
        Me.btnLamMoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLamMoi.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Image = CType(resources.GetObject("btnXoa.Image"), System.Drawing.Image)
        Me.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnXoa.Location = New System.Drawing.Point(593, 301)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(95, 50)
        Me.btnXoa.TabIndex = 10
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnSua
        '
        Me.btnSua.Image = CType(resources.GetObject("btnSua.Image"), System.Drawing.Image)
        Me.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSua.Location = New System.Drawing.Point(482, 362)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(95, 50)
        Me.btnSua.TabIndex = 11
        Me.btnSua.Text = "Sửa"
        Me.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSua.UseVisualStyleBackColor = True
        '
        'btnThem
        '
        Me.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnThem.Image = CType(resources.GetObject("btnThem.Image"), System.Drawing.Image)
        Me.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnThem.Location = New System.Drawing.Point(482, 300)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(95, 50)
        Me.btnThem.TabIndex = 9
        Me.btnThem.Text = "Thêm"
        Me.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'lblBanQuyen2
        '
        Me.lblBanQuyen2.AutoSize = True
        Me.lblBanQuyen2.Location = New System.Drawing.Point(-2, 464)
        Me.lblBanQuyen2.Name = "lblBanQuyen2"
        Me.lblBanQuyen2.Size = New System.Drawing.Size(164, 13)
        Me.lblBanQuyen2.TabIndex = 79
        Me.lblBanQuyen2.Text = "MSSV: PS03299 - Lớp: PT10303"
        '
        'lblBanQuyen1
        '
        Me.lblBanQuyen1.AutoSize = True
        Me.lblBanQuyen1.Location = New System.Drawing.Point(-2, 441)
        Me.lblBanQuyen1.Name = "lblBanQuyen1"
        Me.lblBanQuyen1.Size = New System.Drawing.Size(174, 13)
        Me.lblBanQuyen1.TabIndex = 78
        Me.lblBanQuyen1.Text = "Họ và tên: PHẠM NHẬT TRƯỜNG"
        '
        'txtSoDienThoai
        '
        Me.txtSoDienThoai.Location = New System.Drawing.Point(86, 390)
        Me.txtSoDienThoai.Name = "txtSoDienThoai"
        Me.txtSoDienThoai.Size = New System.Drawing.Size(149, 20)
        Me.txtSoDienThoai.TabIndex = 7
        '
        'lblSoDienThoai
        '
        Me.lblSoDienThoai.AutoSize = True
        Me.lblSoDienThoai.Location = New System.Drawing.Point(10, 393)
        Me.lblSoDienThoai.Name = "lblSoDienThoai"
        Me.lblSoDienThoai.Size = New System.Drawing.Size(70, 13)
        Me.lblSoDienThoai.TabIndex = 76
        Me.lblSoDienThoai.Text = "Số điện thoại"
        '
        'txtDiaChi
        '
        Me.txtDiaChi.Location = New System.Drawing.Point(86, 335)
        Me.txtDiaChi.Multiline = True
        Me.txtDiaChi.Name = "txtDiaChi"
        Me.txtDiaChi.Size = New System.Drawing.Size(369, 41)
        Me.txtDiaChi.TabIndex = 6
        '
        'lblDiaChi
        '
        Me.lblDiaChi.AutoSize = True
        Me.lblDiaChi.Location = New System.Drawing.Point(40, 338)
        Me.lblDiaChi.Name = "lblDiaChi"
        Me.lblDiaChi.Size = New System.Drawing.Size(40, 13)
        Me.lblDiaChi.TabIndex = 74
        Me.lblDiaChi.Text = "Địa chỉ"
        '
        'txtTenNhanVien
        '
        Me.txtTenNhanVien.Location = New System.Drawing.Point(289, 300)
        Me.txtTenNhanVien.Name = "txtTenNhanVien"
        Me.txtTenNhanVien.Size = New System.Drawing.Size(166, 20)
        Me.txtTenNhanVien.TabIndex = 5
        '
        'lblTimNhanVien
        '
        Me.lblTimNhanVien.AutoSize = True
        Me.lblTimNhanVien.Location = New System.Drawing.Point(85, 73)
        Me.lblTimNhanVien.Name = "lblTimNhanVien"
        Me.lblTimNhanVien.Size = New System.Drawing.Size(92, 13)
        Me.lblTimNhanVien.TabIndex = 67
        Me.lblTimNhanVien.Text = "Tìm tên nhân viên"
        '
        'lblTenNhanVien
        '
        Me.lblTenNhanVien.AutoSize = True
        Me.lblTenNhanVien.Location = New System.Drawing.Point(207, 303)
        Me.lblTenNhanVien.Name = "lblTenNhanVien"
        Me.lblTenNhanVien.Size = New System.Drawing.Size(76, 13)
        Me.lblTenNhanVien.TabIndex = 72
        Me.lblTenNhanVien.Text = "Tên nhân viên"
        '
        'txtMaNhanVien
        '
        Me.txtMaNhanVien.Location = New System.Drawing.Point(86, 300)
        Me.txtMaNhanVien.Name = "txtMaNhanVien"
        Me.txtMaNhanVien.Size = New System.Drawing.Size(100, 20)
        Me.txtMaNhanVien.TabIndex = 4
        '
        'lblMaNhanVien
        '
        Me.lblMaNhanVien.AutoSize = True
        Me.lblMaNhanVien.Location = New System.Drawing.Point(12, 303)
        Me.lblMaNhanVien.Name = "lblMaNhanVien"
        Me.lblMaNhanVien.Size = New System.Drawing.Size(72, 13)
        Me.lblMaNhanVien.TabIndex = 70
        Me.lblMaNhanVien.Text = "Mã nhân viên"
        '
        'txtTimNhanVien
        '
        Me.txtTimNhanVien.Location = New System.Drawing.Point(310, 70)
        Me.txtTimNhanVien.Name = "txtTimNhanVien"
        Me.txtTimNhanVien.Size = New System.Drawing.Size(179, 20)
        Me.txtTimNhanVien.TabIndex = 1
        '
        'dgwNhanVien
        '
        Me.dgwNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwNhanVien.Location = New System.Drawing.Point(1, 99)
        Me.dgwNhanVien.Name = "dgwNhanVien"
        Me.dgwNhanVien.ReadOnly = True
        Me.dgwNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgwNhanVien.Size = New System.Drawing.Size(695, 178)
        Me.dgwNhanVien.TabIndex = 3
        '
        'btnQuayLai
        '
        Me.btnQuayLai.BackColor = System.Drawing.Color.Transparent
        Me.btnQuayLai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnQuayLai.Image = CType(resources.GetObject("btnQuayLai.Image"), System.Drawing.Image)
        Me.btnQuayLai.Location = New System.Drawing.Point(13, 39)
        Me.btnQuayLai.Name = "btnQuayLai"
        Me.btnQuayLai.Size = New System.Drawing.Size(37, 38)
        Me.btnQuayLai.TabIndex = 0
        Me.btnQuayLai.UseVisualStyleBackColor = False
        '
        'lblVien2
        '
        Me.lblVien2.AutoSize = True
        Me.lblVien2.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblVien2.Location = New System.Drawing.Point(641, 48)
        Me.lblVien2.Name = "lblVien2"
        Me.lblVien2.Size = New System.Drawing.Size(73, 13)
        Me.lblVien2.TabIndex = 64
        Me.lblVien2.Text = "......................"
        '
        'lblVien1
        '
        Me.lblVien1.AutoSize = True
        Me.lblVien1.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblVien1.Location = New System.Drawing.Point(-2, 48)
        Me.lblVien1.Name = "lblVien1"
        Me.lblVien1.Size = New System.Drawing.Size(559, 13)
        Me.lblVien1.TabIndex = 63
        Me.lblVien1.Text = "................................................................................." &
    "................................................................................" &
    "......................."
        '
        'lblTieuDe
        '
        Me.lblTieuDe.AutoSize = True
        Me.lblTieuDe.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Bold)
        Me.lblTieuDe.ForeColor = System.Drawing.Color.Red
        Me.lblTieuDe.Location = New System.Drawing.Point(64, 8)
        Me.lblTieuDe.Name = "lblTieuDe"
        Me.lblTieuDe.Size = New System.Drawing.Size(174, 40)
        Me.lblTieuDe.TabIndex = 62
        Me.lblTieuDe.Text = "Nhân Viên"
        '
        'ptbLogo
        '
        Me.ptbLogo.BackgroundImage = CType(resources.GetObject("ptbLogo.BackgroundImage"), System.Drawing.Image)
        Me.ptbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ptbLogo.Location = New System.Drawing.Point(556, 25)
        Me.ptbLogo.Name = "ptbLogo"
        Me.ptbLogo.Size = New System.Drawing.Size(110, 58)
        Me.ptbLogo.TabIndex = 61
        Me.ptbLogo.TabStop = False
        '
        'txtMatKhau
        '
        Me.txtMatKhau.Location = New System.Drawing.Point(310, 392)
        Me.txtMatKhau.Name = "txtMatKhau"
        Me.txtMatKhau.Size = New System.Drawing.Size(145, 20)
        Me.txtMatKhau.TabIndex = 8
        '
        'lblMatKhau
        '
        Me.lblMatKhau.AutoSize = True
        Me.lblMatKhau.Location = New System.Drawing.Point(252, 395)
        Me.lblMatKhau.Name = "lblMatKhau"
        Me.lblMatKhau.Size = New System.Drawing.Size(52, 13)
        Me.lblMatKhau.TabIndex = 84
        Me.lblMatKhau.Text = "Mật khẩu"
        '
        'btnThoat
        '
        Me.btnThoat.BackColor = System.Drawing.Color.Transparent
        Me.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnThoat.Image = CType(resources.GetObject("btnThoat.Image"), System.Drawing.Image)
        Me.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnThoat.Location = New System.Drawing.Point(593, 427)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(95, 50)
        Me.btnThoat.TabIndex = 13
        Me.btnThoat.Text = "Thoát"
        Me.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnThoat.UseVisualStyleBackColor = False
        '
        'lblQuyen
        '
        Me.lblQuyen.AutoSize = True
        Me.lblQuyen.Location = New System.Drawing.Point(299, 430)
        Me.lblQuyen.Name = "lblQuyen"
        Me.lblQuyen.Size = New System.Drawing.Size(76, 13)
        Me.lblQuyen.TabIndex = 86
        Me.lblQuyen.Text = "Quyền quản trị"
        '
        'txtQuyen
        '
        Me.txtQuyen.Location = New System.Drawing.Point(381, 427)
        Me.txtQuyen.Name = "txtQuyen"
        Me.txtQuyen.Size = New System.Drawing.Size(74, 20)
        Me.txtQuyen.TabIndex = 87
        '
        'cbbTimKiem
        '
        Me.cbbTimKiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbTimKiem.FormattingEnabled = True
        Me.cbbTimKiem.Items.AddRange(New Object() {"Mã nhân viên", "Tên nhân viên", "Số điện thoại"})
        Me.cbbTimKiem.Location = New System.Drawing.Point(183, 70)
        Me.cbbTimKiem.Name = "cbbTimKiem"
        Me.cbbTimKiem.Size = New System.Drawing.Size(121, 21)
        Me.cbbTimKiem.TabIndex = 117
        '
        'frmNhanVien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(700, 482)
        Me.Controls.Add(Me.cbbTimKiem)
        Me.Controls.Add(Me.txtQuyen)
        Me.Controls.Add(Me.lblQuyen)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.txtMatKhau)
        Me.Controls.Add(Me.lblMatKhau)
        Me.Controls.Add(Me.btnLamMoi)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnSua)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.lblBanQuyen2)
        Me.Controls.Add(Me.lblBanQuyen1)
        Me.Controls.Add(Me.txtSoDienThoai)
        Me.Controls.Add(Me.lblSoDienThoai)
        Me.Controls.Add(Me.txtDiaChi)
        Me.Controls.Add(Me.lblDiaChi)
        Me.Controls.Add(Me.txtTenNhanVien)
        Me.Controls.Add(Me.lblTimNhanVien)
        Me.Controls.Add(Me.lblTenNhanVien)
        Me.Controls.Add(Me.txtMaNhanVien)
        Me.Controls.Add(Me.lblMaNhanVien)
        Me.Controls.Add(Me.txtTimNhanVien)
        Me.Controls.Add(Me.dgwNhanVien)
        Me.Controls.Add(Me.btnQuayLai)
        Me.Controls.Add(Me.lblVien2)
        Me.Controls.Add(Me.lblVien1)
        Me.Controls.Add(Me.lblTieuDe)
        Me.Controls.Add(Me.ptbLogo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmNhanVien"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nhân viên - Phần mềm quản lý bán hàng"
        CType(Me.dgwNhanVien, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnLamMoi As Button
    Friend WithEvents btnXoa As Button
    Friend WithEvents btnSua As Button
    Friend WithEvents btnThem As Button
    Friend WithEvents lblBanQuyen2 As Label
    Friend WithEvents lblBanQuyen1 As Label
    Friend WithEvents txtSoDienThoai As TextBox
    Friend WithEvents lblSoDienThoai As Label
    Friend WithEvents txtDiaChi As TextBox
    Friend WithEvents lblDiaChi As Label
    Friend WithEvents txtTenNhanVien As TextBox
    Friend WithEvents lblTimNhanVien As Label
    Friend WithEvents lblTenNhanVien As Label
    Friend WithEvents txtMaNhanVien As TextBox
    Friend WithEvents lblMaNhanVien As Label
    Friend WithEvents txtTimNhanVien As TextBox
    Friend WithEvents dgwNhanVien As DataGridView
    Friend WithEvents btnQuayLai As Button
    Friend WithEvents lblVien2 As Label
    Friend WithEvents lblVien1 As Label
    Friend WithEvents lblTieuDe As Label
    Friend WithEvents ptbLogo As PictureBox
    Friend WithEvents txtMatKhau As TextBox
    Friend WithEvents lblMatKhau As Label
    Friend WithEvents btnThoat As Button
    Friend WithEvents lblQuyen As Label
    Friend WithEvents txtQuyen As TextBox
    Friend WithEvents cbbTimKiem As ComboBox
End Class
