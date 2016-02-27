<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmHoaDon
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHoaDon))
        Me.btnQuayLai = New System.Windows.Forms.Button()
        Me.lblBanQuyen2 = New System.Windows.Forms.Label()
        Me.lblBanQuyen1 = New System.Windows.Forms.Label()
        Me.lblTimHoaDon = New System.Windows.Forms.Label()
        Me.dgvHoaDon = New System.Windows.Forms.DataGridView()
        Me.lblVien2 = New System.Windows.Forms.Label()
        Me.lblVien1 = New System.Windows.Forms.Label()
        Me.lblTieuDe = New System.Windows.Forms.Label()
        Me.ptbLogo = New System.Windows.Forms.PictureBox()
        Me.txtTimHoaDon = New System.Windows.Forms.TextBox()
        Me.lblMaSanPham = New System.Windows.Forms.Label()
        Me.txtMaSP = New System.Windows.Forms.TextBox()
        Me.lblMaHoaDon = New System.Windows.Forms.Label()
        Me.txtMaHoaDon = New System.Windows.Forms.TextBox()
        Me.lblSoLuongMua = New System.Windows.Forms.Label()
        Me.lblDonGia = New System.Windows.Forms.Label()
        Me.txtDonGia = New System.Windows.Forms.TextBox()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnLamMoi = New System.Windows.Forms.Button()
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.txtSoLuongMua = New System.Windows.Forms.TextBox()
        Me.txtMaKH = New System.Windows.Forms.TextBox()
        Me.lblMaKH = New System.Windows.Forms.Label()
        Me.lblThoiGian = New System.Windows.Forms.Label()
        Me.dtpThoiGian = New System.Windows.Forms.DateTimePicker()
        Me.cbbTimKiem = New System.Windows.Forms.ComboBox()
        CType(Me.dgvHoaDon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnQuayLai
        '
        Me.btnQuayLai.BackColor = System.Drawing.Color.Transparent
        Me.btnQuayLai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnQuayLai.Image = CType(resources.GetObject("btnQuayLai.Image"), System.Drawing.Image)
        Me.btnQuayLai.Location = New System.Drawing.Point(18, 38)
        Me.btnQuayLai.Name = "btnQuayLai"
        Me.btnQuayLai.Size = New System.Drawing.Size(37, 38)
        Me.btnQuayLai.TabIndex = 110
        Me.btnQuayLai.UseVisualStyleBackColor = False
        '
        'lblBanQuyen2
        '
        Me.lblBanQuyen2.AutoSize = True
        Me.lblBanQuyen2.Location = New System.Drawing.Point(3, 463)
        Me.lblBanQuyen2.Name = "lblBanQuyen2"
        Me.lblBanQuyen2.Size = New System.Drawing.Size(164, 13)
        Me.lblBanQuyen2.TabIndex = 109
        Me.lblBanQuyen2.Text = "MSSV: PS03299 - Lớp: PT10303"
        '
        'lblBanQuyen1
        '
        Me.lblBanQuyen1.AutoSize = True
        Me.lblBanQuyen1.Location = New System.Drawing.Point(3, 440)
        Me.lblBanQuyen1.Name = "lblBanQuyen1"
        Me.lblBanQuyen1.Size = New System.Drawing.Size(174, 13)
        Me.lblBanQuyen1.TabIndex = 108
        Me.lblBanQuyen1.Text = "Họ và tên: PHẠM NHẬT TRƯỜNG"
        '
        'lblTimHoaDon
        '
        Me.lblTimHoaDon.AutoSize = True
        Me.lblTimHoaDon.Location = New System.Drawing.Point(80, 72)
        Me.lblTimHoaDon.Name = "lblTimHoaDon"
        Me.lblTimHoaDon.Size = New System.Drawing.Size(102, 13)
        Me.lblTimHoaDon.TabIndex = 97
        Me.lblTimHoaDon.Text = "Tìm tên mã hóa đơn"
        '
        'dgvHoaDon
        '
        Me.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHoaDon.Location = New System.Drawing.Point(6, 98)
        Me.dgvHoaDon.Name = "dgvHoaDon"
        Me.dgvHoaDon.ReadOnly = True
        Me.dgvHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvHoaDon.Size = New System.Drawing.Size(910, 178)
        Me.dgvHoaDon.TabIndex = 3
        '
        'lblVien2
        '
        Me.lblVien2.AutoSize = True
        Me.lblVien2.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblVien2.Location = New System.Drawing.Point(790, 47)
        Me.lblVien2.Name = "lblVien2"
        Me.lblVien2.Size = New System.Drawing.Size(73, 13)
        Me.lblVien2.TabIndex = 95
        Me.lblVien2.Text = "......................"
        '
        'lblVien1
        '
        Me.lblVien1.AutoSize = True
        Me.lblVien1.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblVien1.Location = New System.Drawing.Point(3, 47)
        Me.lblVien1.Name = "lblVien1"
        Me.lblVien1.Size = New System.Drawing.Size(706, 13)
        Me.lblVien1.TabIndex = 94
        Me.lblVien1.Text = resources.GetString("lblVien1.Text")
        '
        'lblTieuDe
        '
        Me.lblTieuDe.AutoSize = True
        Me.lblTieuDe.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Bold)
        Me.lblTieuDe.ForeColor = System.Drawing.Color.Red
        Me.lblTieuDe.Location = New System.Drawing.Point(69, 7)
        Me.lblTieuDe.Name = "lblTieuDe"
        Me.lblTieuDe.Size = New System.Drawing.Size(146, 40)
        Me.lblTieuDe.TabIndex = 93
        Me.lblTieuDe.Text = "Hóa đơn"
        '
        'ptbLogo
        '
        Me.ptbLogo.BackgroundImage = CType(resources.GetObject("ptbLogo.BackgroundImage"), System.Drawing.Image)
        Me.ptbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ptbLogo.Location = New System.Drawing.Point(705, 24)
        Me.ptbLogo.Name = "ptbLogo"
        Me.ptbLogo.Size = New System.Drawing.Size(110, 58)
        Me.ptbLogo.TabIndex = 92
        Me.ptbLogo.TabStop = False
        '
        'txtTimHoaDon
        '
        Me.txtTimHoaDon.Location = New System.Drawing.Point(315, 69)
        Me.txtTimHoaDon.Name = "txtTimHoaDon"
        Me.txtTimHoaDon.Size = New System.Drawing.Size(200, 20)
        Me.txtTimHoaDon.TabIndex = 1
        '
        'lblMaSanPham
        '
        Me.lblMaSanPham.AutoSize = True
        Me.lblMaSanPham.Location = New System.Drawing.Point(204, 299)
        Me.lblMaSanPham.Name = "lblMaSanPham"
        Me.lblMaSanPham.Size = New System.Drawing.Size(39, 13)
        Me.lblMaSanPham.TabIndex = 100
        Me.lblMaSanPham.Text = "Mã SP"
        '
        'txtMaSP
        '
        Me.txtMaSP.Location = New System.Drawing.Point(249, 296)
        Me.txtMaSP.Name = "txtMaSP"
        Me.txtMaSP.Size = New System.Drawing.Size(127, 20)
        Me.txtMaSP.TabIndex = 4
        '
        'lblMaHoaDon
        '
        Me.lblMaHoaDon.AutoSize = True
        Me.lblMaHoaDon.Location = New System.Drawing.Point(15, 299)
        Me.lblMaHoaDon.Name = "lblMaHoaDon"
        Me.lblMaHoaDon.Size = New System.Drawing.Size(65, 13)
        Me.lblMaHoaDon.TabIndex = 102
        Me.lblMaHoaDon.Text = "Mã hóa đơn"
        '
        'txtMaHoaDon
        '
        Me.txtMaHoaDon.Location = New System.Drawing.Point(91, 296)
        Me.txtMaHoaDon.Name = "txtMaHoaDon"
        Me.txtMaHoaDon.Size = New System.Drawing.Size(102, 20)
        Me.txtMaHoaDon.TabIndex = 5
        '
        'lblSoLuongMua
        '
        Me.lblSoLuongMua.AutoSize = True
        Me.lblSoLuongMua.Location = New System.Drawing.Point(15, 337)
        Me.lblSoLuongMua.Name = "lblSoLuongMua"
        Me.lblSoLuongMua.Size = New System.Drawing.Size(72, 13)
        Me.lblSoLuongMua.TabIndex = 104
        Me.lblSoLuongMua.Text = "Số lượng mua"
        '
        'lblDonGia
        '
        Me.lblDonGia.AutoSize = True
        Me.lblDonGia.Location = New System.Drawing.Point(208, 337)
        Me.lblDonGia.Name = "lblDonGia"
        Me.lblDonGia.Size = New System.Drawing.Size(44, 13)
        Me.lblDonGia.TabIndex = 106
        Me.lblDonGia.Text = "Đơn giá"
        '
        'txtDonGia
        '
        Me.txtDonGia.Location = New System.Drawing.Point(258, 334)
        Me.txtDonGia.Name = "txtDonGia"
        Me.txtDonGia.Size = New System.Drawing.Size(118, 20)
        Me.txtDonGia.TabIndex = 7
        '
        'btnSua
        '
        Me.btnSua.Image = CType(resources.GetObject("btnSua.Image"), System.Drawing.Image)
        Me.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSua.Location = New System.Drawing.Point(710, 357)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(95, 50)
        Me.btnSua.TabIndex = 10
        Me.btnSua.Text = "Sửa"
        Me.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSua.UseVisualStyleBackColor = True
        '
        'btnLamMoi
        '
        Me.btnLamMoi.Image = CType(resources.GetObject("btnLamMoi.Image"), System.Drawing.Image)
        Me.btnLamMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLamMoi.Location = New System.Drawing.Point(821, 357)
        Me.btnLamMoi.Name = "btnLamMoi"
        Me.btnLamMoi.Size = New System.Drawing.Size(95, 50)
        Me.btnLamMoi.TabIndex = 11
        Me.btnLamMoi.Text = "Làm mới"
        Me.btnLamMoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLamMoi.UseVisualStyleBackColor = True
        '
        'btnThoat
        '
        Me.btnThoat.BackColor = System.Drawing.Color.Transparent
        Me.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnThoat.Image = CType(resources.GetObject("btnThoat.Image"), System.Drawing.Image)
        Me.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnThoat.Location = New System.Drawing.Point(821, 422)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(95, 50)
        Me.btnThoat.TabIndex = 0
        Me.btnThoat.Text = "Thoát"
        Me.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnThoat.UseVisualStyleBackColor = False
        '
        'btnThem
        '
        Me.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnThem.Image = CType(resources.GetObject("btnThem.Image"), System.Drawing.Image)
        Me.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnThem.Location = New System.Drawing.Point(710, 295)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(95, 50)
        Me.btnThem.TabIndex = 8
        Me.btnThem.Text = "Thêm"
        Me.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Image = CType(resources.GetObject("btnXoa.Image"), System.Drawing.Image)
        Me.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnXoa.Location = New System.Drawing.Point(821, 296)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(95, 50)
        Me.btnXoa.TabIndex = 9
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'txtSoLuongMua
        '
        Me.txtSoLuongMua.Location = New System.Drawing.Point(91, 334)
        Me.txtSoLuongMua.Name = "txtSoLuongMua"
        Me.txtSoLuongMua.Size = New System.Drawing.Size(102, 20)
        Me.txtSoLuongMua.TabIndex = 6
        '
        'txtMaKH
        '
        Me.txtMaKH.Location = New System.Drawing.Point(484, 296)
        Me.txtMaKH.Name = "txtMaKH"
        Me.txtMaKH.Size = New System.Drawing.Size(115, 20)
        Me.txtMaKH.TabIndex = 111
        '
        'lblMaKH
        '
        Me.lblMaKH.AutoSize = True
        Me.lblMaKH.Location = New System.Drawing.Point(396, 299)
        Me.lblMaKH.Name = "lblMaKH"
        Me.lblMaKH.Size = New System.Drawing.Size(82, 13)
        Me.lblMaKH.TabIndex = 112
        Me.lblMaKH.Text = "Mã khách hàng"
        '
        'lblThoiGian
        '
        Me.lblThoiGian.AutoSize = True
        Me.lblThoiGian.Location = New System.Drawing.Point(435, 337)
        Me.lblThoiGian.Name = "lblThoiGian"
        Me.lblThoiGian.Size = New System.Drawing.Size(51, 13)
        Me.lblThoiGian.TabIndex = 113
        Me.lblThoiGian.Text = "Thời gian"
        '
        'dtpThoiGian
        '
        Me.dtpThoiGian.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpThoiGian.Location = New System.Drawing.Point(492, 334)
        Me.dtpThoiGian.Name = "dtpThoiGian"
        Me.dtpThoiGian.Size = New System.Drawing.Size(107, 20)
        Me.dtpThoiGian.TabIndex = 114
        '
        'cbbTimKiem
        '
        Me.cbbTimKiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbTimKiem.FormattingEnabled = True
        Me.cbbTimKiem.Items.AddRange(New Object() {"Mã hóa đơn", "Tên khách hàng", "Tên sản phẩm"})
        Me.cbbTimKiem.Location = New System.Drawing.Point(188, 69)
        Me.cbbTimKiem.Name = "cbbTimKiem"
        Me.cbbTimKiem.Size = New System.Drawing.Size(121, 21)
        Me.cbbTimKiem.TabIndex = 115
        '
        'frmHoaDon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(923, 494)
        Me.Controls.Add(Me.cbbTimKiem)
        Me.Controls.Add(Me.dtpThoiGian)
        Me.Controls.Add(Me.lblThoiGian)
        Me.Controls.Add(Me.txtMaKH)
        Me.Controls.Add(Me.lblMaKH)
        Me.Controls.Add(Me.txtSoLuongMua)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.btnLamMoi)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnSua)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.btnQuayLai)
        Me.Controls.Add(Me.lblBanQuyen2)
        Me.Controls.Add(Me.lblBanQuyen1)
        Me.Controls.Add(Me.txtDonGia)
        Me.Controls.Add(Me.lblDonGia)
        Me.Controls.Add(Me.lblSoLuongMua)
        Me.Controls.Add(Me.txtMaHoaDon)
        Me.Controls.Add(Me.lblMaHoaDon)
        Me.Controls.Add(Me.txtMaSP)
        Me.Controls.Add(Me.lblMaSanPham)
        Me.Controls.Add(Me.txtTimHoaDon)
        Me.Controls.Add(Me.lblTimHoaDon)
        Me.Controls.Add(Me.dgvHoaDon)
        Me.Controls.Add(Me.lblVien2)
        Me.Controls.Add(Me.lblVien1)
        Me.Controls.Add(Me.lblTieuDe)
        Me.Controls.Add(Me.ptbLogo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmHoaDon"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hóa Đơn - Phần mềm quản lý bán hàng"
        CType(Me.dgvHoaDon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnQuayLai As Button
    Friend WithEvents lblBanQuyen2 As Label
    Friend WithEvents lblBanQuyen1 As Label
    Friend WithEvents lblTimHoaDon As Label
    Friend WithEvents dgvHoaDon As DataGridView
    Friend WithEvents lblVien2 As Label
    Friend WithEvents lblVien1 As Label
    Friend WithEvents lblTieuDe As Label
    Friend WithEvents ptbLogo As PictureBox
    Friend WithEvents txtTimHoaDon As TextBox
    Friend WithEvents lblMaSanPham As Label
    Friend WithEvents txtMaSP As TextBox
    Friend WithEvents lblMaHoaDon As Label
    Friend WithEvents txtMaHoaDon As TextBox
    Friend WithEvents lblSoLuongMua As Label
    Friend WithEvents lblDonGia As Label
    Friend WithEvents txtDonGia As TextBox
    Friend WithEvents btnSua As Button
    Friend WithEvents btnLamMoi As Button
    Friend WithEvents btnThoat As Button
    Friend WithEvents btnThem As Button
    Friend WithEvents btnXoa As Button
    Friend WithEvents txtSoLuongMua As TextBox
    Friend WithEvents txtMaKH As TextBox
    Friend WithEvents lblMaKH As Label
    Friend WithEvents lblThoiGian As Label
    Friend WithEvents dtpThoiGian As DateTimePicker
    Friend WithEvents cbbTimKiem As ComboBox
End Class
