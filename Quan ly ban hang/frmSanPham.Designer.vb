<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSanPham
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSanPham))
        Me.lblVien2 = New System.Windows.Forms.Label()
        Me.lblVien1 = New System.Windows.Forms.Label()
        Me.lblTieuDe = New System.Windows.Forms.Label()
        Me.ptbLogo = New System.Windows.Forms.PictureBox()
        Me.dgwSanPham = New System.Windows.Forms.DataGridView()
        Me.lblMaSanPham = New System.Windows.Forms.Label()
        Me.txtMaSanPham = New System.Windows.Forms.TextBox()
        Me.txtTenSP = New System.Windows.Forms.TextBox()
        Me.lblTenSP = New System.Windows.Forms.Label()
        Me.txtSoLuong = New System.Windows.Forms.TextBox()
        Me.lblSoLuong = New System.Windows.Forms.Label()
        Me.lblMoTa = New System.Windows.Forms.Label()
        Me.lblMaLoaiSP = New System.Windows.Forms.Label()
        Me.txtMaLoaiSP = New System.Windows.Forms.TextBox()
        Me.lblBanQuyen2 = New System.Windows.Forms.Label()
        Me.lblBanQuyen1 = New System.Windows.Forms.Label()
        Me.btnQuayLai = New System.Windows.Forms.Button()
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.btnLamMoi = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.cbbTimKiem = New System.Windows.Forms.ComboBox()
        Me.lblTimSP = New System.Windows.Forms.Label()
        Me.txtTimSanPham = New System.Windows.Forms.TextBox()
        Me.txtMoTa = New System.Windows.Forms.TextBox()
        Me.lblLoaiSanPham = New System.Windows.Forms.Label()
        Me.cbbLoaiSP = New System.Windows.Forms.ComboBox()
        Me.btnThemLoai = New System.Windows.Forms.Button()
        CType(Me.ptbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgwSanPham, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblVien2
        '
        Me.lblVien2.AutoSize = True
        Me.lblVien2.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblVien2.Location = New System.Drawing.Point(633, 49)
        Me.lblVien2.Name = "lblVien2"
        Me.lblVien2.Size = New System.Drawing.Size(73, 13)
        Me.lblVien2.TabIndex = 19
        Me.lblVien2.Text = "......................"
        '
        'lblVien1
        '
        Me.lblVien1.AutoSize = True
        Me.lblVien1.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblVien1.Location = New System.Drawing.Point(-10, 49)
        Me.lblVien1.Name = "lblVien1"
        Me.lblVien1.Size = New System.Drawing.Size(559, 13)
        Me.lblVien1.TabIndex = 18
        Me.lblVien1.Text = "................................................................................." &
    "................................................................................" &
    "......................."
        '
        'lblTieuDe
        '
        Me.lblTieuDe.AutoSize = True
        Me.lblTieuDe.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Bold)
        Me.lblTieuDe.ForeColor = System.Drawing.Color.Red
        Me.lblTieuDe.Location = New System.Drawing.Point(56, 9)
        Me.lblTieuDe.Name = "lblTieuDe"
        Me.lblTieuDe.Size = New System.Drawing.Size(165, 40)
        Me.lblTieuDe.TabIndex = 17
        Me.lblTieuDe.Text = "Sản phẩm"
        '
        'ptbLogo
        '
        Me.ptbLogo.BackgroundImage = CType(resources.GetObject("ptbLogo.BackgroundImage"), System.Drawing.Image)
        Me.ptbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ptbLogo.Location = New System.Drawing.Point(548, 26)
        Me.ptbLogo.Name = "ptbLogo"
        Me.ptbLogo.Size = New System.Drawing.Size(110, 58)
        Me.ptbLogo.TabIndex = 16
        Me.ptbLogo.TabStop = False
        '
        'dgwSanPham
        '
        Me.dgwSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwSanPham.Location = New System.Drawing.Point(1, 132)
        Me.dgwSanPham.Name = "dgwSanPham"
        Me.dgwSanPham.ReadOnly = True
        Me.dgwSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgwSanPham.Size = New System.Drawing.Size(698, 178)
        Me.dgwSanPham.TabIndex = 3
        '
        'lblMaSanPham
        '
        Me.lblMaSanPham.AutoSize = True
        Me.lblMaSanPham.Location = New System.Drawing.Point(1, 320)
        Me.lblMaSanPham.Name = "lblMaSanPham"
        Me.lblMaSanPham.Size = New System.Drawing.Size(71, 13)
        Me.lblMaSanPham.TabIndex = 21
        Me.lblMaSanPham.Text = "Mã sản phẩm"
        '
        'txtMaSanPham
        '
        Me.txtMaSanPham.Location = New System.Drawing.Point(77, 317)
        Me.txtMaSanPham.Name = "txtMaSanPham"
        Me.txtMaSanPham.Size = New System.Drawing.Size(60, 20)
        Me.txtMaSanPham.TabIndex = 4
        '
        'txtTenSP
        '
        Me.txtTenSP.Location = New System.Drawing.Point(192, 317)
        Me.txtTenSP.Name = "txtTenSP"
        Me.txtTenSP.Size = New System.Drawing.Size(139, 20)
        Me.txtTenSP.TabIndex = 5
        '
        'lblTenSP
        '
        Me.lblTenSP.AutoSize = True
        Me.lblTenSP.Location = New System.Drawing.Point(143, 319)
        Me.lblTenSP.Name = "lblTenSP"
        Me.lblTenSP.Size = New System.Drawing.Size(43, 13)
        Me.lblTenSP.TabIndex = 23
        Me.lblTenSP.Text = "Tên SP"
        '
        'txtSoLuong
        '
        Me.txtSoLuong.Location = New System.Drawing.Point(390, 316)
        Me.txtSoLuong.Name = "txtSoLuong"
        Me.txtSoLuong.Size = New System.Drawing.Size(53, 20)
        Me.txtSoLuong.TabIndex = 6
        '
        'lblSoLuong
        '
        Me.lblSoLuong.AutoSize = True
        Me.lblSoLuong.Location = New System.Drawing.Point(335, 319)
        Me.lblSoLuong.Name = "lblSoLuong"
        Me.lblSoLuong.Size = New System.Drawing.Size(49, 13)
        Me.lblSoLuong.TabIndex = 25
        Me.lblSoLuong.Text = "Số lượng"
        '
        'lblMoTa
        '
        Me.lblMoTa.AutoSize = True
        Me.lblMoTa.Location = New System.Drawing.Point(37, 363)
        Me.lblMoTa.Name = "lblMoTa"
        Me.lblMoTa.Size = New System.Drawing.Size(34, 13)
        Me.lblMoTa.TabIndex = 27
        Me.lblMoTa.Text = "Mô tả"
        '
        'lblMaLoaiSP
        '
        Me.lblMaLoaiSP.AutoSize = True
        Me.lblMaLoaiSP.Location = New System.Drawing.Point(275, 363)
        Me.lblMaLoaiSP.Name = "lblMaLoaiSP"
        Me.lblMaLoaiSP.Size = New System.Drawing.Size(62, 13)
        Me.lblMaLoaiSP.TabIndex = 29
        Me.lblMaLoaiSP.Text = "Mã Loại SP"
        '
        'txtMaLoaiSP
        '
        Me.txtMaLoaiSP.Location = New System.Drawing.Point(343, 360)
        Me.txtMaLoaiSP.Name = "txtMaLoaiSP"
        Me.txtMaLoaiSP.Size = New System.Drawing.Size(100, 20)
        Me.txtMaLoaiSP.TabIndex = 8
        '
        'lblBanQuyen2
        '
        Me.lblBanQuyen2.AutoSize = True
        Me.lblBanQuyen2.Location = New System.Drawing.Point(1, 443)
        Me.lblBanQuyen2.Name = "lblBanQuyen2"
        Me.lblBanQuyen2.Size = New System.Drawing.Size(164, 13)
        Me.lblBanQuyen2.TabIndex = 37
        Me.lblBanQuyen2.Text = "MSSV: PS03299 - Lớp: PT10303"
        '
        'lblBanQuyen1
        '
        Me.lblBanQuyen1.AutoSize = True
        Me.lblBanQuyen1.Location = New System.Drawing.Point(1, 420)
        Me.lblBanQuyen1.Name = "lblBanQuyen1"
        Me.lblBanQuyen1.Size = New System.Drawing.Size(174, 13)
        Me.lblBanQuyen1.TabIndex = 36
        Me.lblBanQuyen1.Text = "Họ và tên: PHẠM NHẬT TRƯỜNG"
        '
        'btnQuayLai
        '
        Me.btnQuayLai.BackColor = System.Drawing.Color.Transparent
        Me.btnQuayLai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnQuayLai.Image = CType(resources.GetObject("btnQuayLai.Image"), System.Drawing.Image)
        Me.btnQuayLai.Location = New System.Drawing.Point(12, 41)
        Me.btnQuayLai.Name = "btnQuayLai"
        Me.btnQuayLai.Size = New System.Drawing.Size(37, 38)
        Me.btnQuayLai.TabIndex = 0
        Me.btnQuayLai.UseVisualStyleBackColor = False
        '
        'btnThoat
        '
        Me.btnThoat.BackColor = System.Drawing.Color.Transparent
        Me.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnThoat.Image = CType(resources.GetObject("btnThoat.Image"), System.Drawing.Image)
        Me.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnThoat.Location = New System.Drawing.Point(594, 443)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(95, 50)
        Me.btnThoat.TabIndex = 13
        Me.btnThoat.Text = "Thoát"
        Me.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnThoat.UseVisualStyleBackColor = False
        '
        'btnLamMoi
        '
        Me.btnLamMoi.Image = CType(resources.GetObject("btnLamMoi.Image"), System.Drawing.Image)
        Me.btnLamMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLamMoi.Location = New System.Drawing.Point(594, 378)
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
        Me.btnXoa.Location = New System.Drawing.Point(594, 317)
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
        Me.btnSua.Location = New System.Drawing.Point(483, 378)
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
        Me.btnThem.Location = New System.Drawing.Point(483, 316)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(95, 50)
        Me.btnThem.TabIndex = 9
        Me.btnThem.Text = "Thêm"
        Me.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'cbbTimKiem
        '
        Me.cbbTimKiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbTimKiem.FormattingEnabled = True
        Me.cbbTimKiem.Items.AddRange(New Object() {"Mã sản phẩm", "Tên sản phẩm"})
        Me.cbbTimKiem.Location = New System.Drawing.Point(390, 106)
        Me.cbbTimKiem.Name = "cbbTimKiem"
        Me.cbbTimKiem.Size = New System.Drawing.Size(121, 21)
        Me.cbbTimKiem.TabIndex = 120
        '
        'lblTimSP
        '
        Me.lblTimSP.AutoSize = True
        Me.lblTimSP.Location = New System.Drawing.Point(335, 109)
        Me.lblTimSP.Name = "lblTimSP"
        Me.lblTimSP.Size = New System.Drawing.Size(49, 13)
        Me.lblTimSP.TabIndex = 119
        Me.lblTimSP.Text = "Tìm kiếm"
        '
        'txtTimSanPham
        '
        Me.txtTimSanPham.Location = New System.Drawing.Point(517, 106)
        Me.txtTimSanPham.Name = "txtTimSanPham"
        Me.txtTimSanPham.Size = New System.Drawing.Size(179, 20)
        Me.txtTimSanPham.TabIndex = 118
        '
        'txtMoTa
        '
        Me.txtMoTa.Location = New System.Drawing.Point(77, 360)
        Me.txtMoTa.Multiline = True
        Me.txtMoTa.Name = "txtMoTa"
        Me.txtMoTa.Size = New System.Drawing.Size(196, 41)
        Me.txtMoTa.TabIndex = 7
        '
        'lblLoaiSanPham
        '
        Me.lblLoaiSanPham.AutoSize = True
        Me.lblLoaiSanPham.Location = New System.Drawing.Point(1, 109)
        Me.lblLoaiSanPham.Name = "lblLoaiSanPham"
        Me.lblLoaiSanPham.Size = New System.Drawing.Size(76, 13)
        Me.lblLoaiSanPham.TabIndex = 45
        Me.lblLoaiSanPham.Text = "Loại sản phẩm"
        '
        'cbbLoaiSP
        '
        Me.cbbLoaiSP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbLoaiSP.FormattingEnabled = True
        Me.cbbLoaiSP.Location = New System.Drawing.Point(83, 106)
        Me.cbbLoaiSP.Name = "cbbLoaiSP"
        Me.cbbLoaiSP.Size = New System.Drawing.Size(121, 21)
        Me.cbbLoaiSP.TabIndex = 46
        '
        'btnThemLoai
        '
        Me.btnThemLoai.Location = New System.Drawing.Point(208, 105)
        Me.btnThemLoai.Name = "btnThemLoai"
        Me.btnThemLoai.Size = New System.Drawing.Size(83, 23)
        Me.btnThemLoai.TabIndex = 121
        Me.btnThemLoai.Text = "Thêm Loại SP"
        Me.btnThemLoai.UseVisualStyleBackColor = True
        '
        'frmSanPham
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(701, 497)
        Me.Controls.Add(Me.btnThemLoai)
        Me.Controls.Add(Me.cbbTimKiem)
        Me.Controls.Add(Me.lblTimSP)
        Me.Controls.Add(Me.txtTimSanPham)
        Me.Controls.Add(Me.cbbLoaiSP)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.btnLamMoi)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnSua)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.btnQuayLai)
        Me.Controls.Add(Me.lblLoaiSanPham)
        Me.Controls.Add(Me.lblBanQuyen2)
        Me.Controls.Add(Me.lblBanQuyen1)
        Me.Controls.Add(Me.txtMaLoaiSP)
        Me.Controls.Add(Me.lblMaLoaiSP)
        Me.Controls.Add(Me.txtMoTa)
        Me.Controls.Add(Me.lblMoTa)
        Me.Controls.Add(Me.txtSoLuong)
        Me.Controls.Add(Me.lblSoLuong)
        Me.Controls.Add(Me.txtTenSP)
        Me.Controls.Add(Me.lblTenSP)
        Me.Controls.Add(Me.txtMaSanPham)
        Me.Controls.Add(Me.lblMaSanPham)
        Me.Controls.Add(Me.dgwSanPham)
        Me.Controls.Add(Me.lblVien2)
        Me.Controls.Add(Me.lblVien1)
        Me.Controls.Add(Me.lblTieuDe)
        Me.Controls.Add(Me.ptbLogo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSanPham"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sản phẩm - Phần mềm quản lý bán hàng"
        CType(Me.ptbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgwSanPham, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblVien2 As Label
    Friend WithEvents lblVien1 As Label
    Friend WithEvents lblTieuDe As Label
    Friend WithEvents ptbLogo As PictureBox
    Friend WithEvents dgwSanPham As DataGridView
    Friend WithEvents lblMaSanPham As Label
    Friend WithEvents txtMaSanPham As TextBox
    Friend WithEvents txtTenSP As TextBox
    Friend WithEvents lblTenSP As Label
    Friend WithEvents txtSoLuong As TextBox
    Friend WithEvents lblSoLuong As Label
    Friend WithEvents lblMoTa As Label
    Friend WithEvents lblMaLoaiSP As Label
    Friend WithEvents txtMaLoaiSP As TextBox
    Friend WithEvents lblBanQuyen2 As Label
    Friend WithEvents lblBanQuyen1 As Label
    Friend WithEvents btnQuayLai As Button
    Friend WithEvents btnThoat As Button
    Friend WithEvents btnLamMoi As Button
    Friend WithEvents btnXoa As Button
    Friend WithEvents btnSua As Button
    Friend WithEvents btnThem As Button
    Friend WithEvents cbbTimKiem As ComboBox
    Friend WithEvents lblTimSP As Label
    Friend WithEvents txtTimSanPham As TextBox
    Friend WithEvents txtMoTa As TextBox
    Friend WithEvents lblLoaiSanPham As Label
    Friend WithEvents cbbLoaiSP As ComboBox
    Friend WithEvents btnThemLoai As Button
End Class
