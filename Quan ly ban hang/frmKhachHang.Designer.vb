<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmKhachHang
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmKhachHang))
        Me.lblVien2 = New System.Windows.Forms.Label()
        Me.lblVien1 = New System.Windows.Forms.Label()
        Me.lblTieuDe = New System.Windows.Forms.Label()
        Me.ptbLogo = New System.Windows.Forms.PictureBox()
        Me.dgwKhachHang = New System.Windows.Forms.DataGridView()
        Me.txtTimKhachHang = New System.Windows.Forms.TextBox()
        Me.lblTimKhachHang = New System.Windows.Forms.Label()
        Me.txtTenKhachHang = New System.Windows.Forms.TextBox()
        Me.lblTenKhachHang = New System.Windows.Forms.Label()
        Me.txtMaKhachHang = New System.Windows.Forms.TextBox()
        Me.lblMaKhachHang = New System.Windows.Forms.Label()
        Me.txtDiaChi = New System.Windows.Forms.TextBox()
        Me.lblDiaChi = New System.Windows.Forms.Label()
        Me.txtSoDienThoai = New System.Windows.Forms.TextBox()
        Me.lblSoDienThoai = New System.Windows.Forms.Label()
        Me.lblBanQuyen2 = New System.Windows.Forms.Label()
        Me.lblBanQuyen1 = New System.Windows.Forms.Label()
        Me.btnQuayLai = New System.Windows.Forms.Button()
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.btnLamMoi = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.cbbTimKiem = New System.Windows.Forms.ComboBox()
        CType(Me.ptbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgwKhachHang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblVien2
        '
        Me.lblVien2.AutoSize = True
        Me.lblVien2.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblVien2.Location = New System.Drawing.Point(641, 48)
        Me.lblVien2.Name = "lblVien2"
        Me.lblVien2.Size = New System.Drawing.Size(73, 13)
        Me.lblVien2.TabIndex = 39
        Me.lblVien2.Text = "......................"
        '
        'lblVien1
        '
        Me.lblVien1.AutoSize = True
        Me.lblVien1.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblVien1.Location = New System.Drawing.Point(-2, 48)
        Me.lblVien1.Name = "lblVien1"
        Me.lblVien1.Size = New System.Drawing.Size(559, 13)
        Me.lblVien1.TabIndex = 38
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
        Me.lblTieuDe.Size = New System.Drawing.Size(199, 40)
        Me.lblTieuDe.TabIndex = 37
        Me.lblTieuDe.Text = "Khách hàng"
        '
        'ptbLogo
        '
        Me.ptbLogo.BackgroundImage = CType(resources.GetObject("ptbLogo.BackgroundImage"), System.Drawing.Image)
        Me.ptbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ptbLogo.Location = New System.Drawing.Point(556, 25)
        Me.ptbLogo.Name = "ptbLogo"
        Me.ptbLogo.Size = New System.Drawing.Size(110, 58)
        Me.ptbLogo.TabIndex = 36
        Me.ptbLogo.TabStop = False
        '
        'dgwKhachHang
        '
        Me.dgwKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwKhachHang.Location = New System.Drawing.Point(1, 99)
        Me.dgwKhachHang.Name = "dgwKhachHang"
        Me.dgwKhachHang.ReadOnly = True
        Me.dgwKhachHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgwKhachHang.Size = New System.Drawing.Size(695, 178)
        Me.dgwKhachHang.TabIndex = 3
        '
        'txtTimKhachHang
        '
        Me.txtTimKhachHang.Location = New System.Drawing.Point(310, 70)
        Me.txtTimKhachHang.Name = "txtTimKhachHang"
        Me.txtTimKhachHang.Size = New System.Drawing.Size(179, 20)
        Me.txtTimKhachHang.TabIndex = 1
        '
        'lblTimKhachHang
        '
        Me.lblTimKhachHang.AutoSize = True
        Me.lblTimKhachHang.Location = New System.Drawing.Point(75, 73)
        Me.lblTimKhachHang.Name = "lblTimKhachHang"
        Me.lblTimKhachHang.Size = New System.Drawing.Size(102, 13)
        Me.lblTimKhachHang.TabIndex = 42
        Me.lblTimKhachHang.Text = "Tìm tên khách hàng"
        '
        'txtTenKhachHang
        '
        Me.txtTenKhachHang.Location = New System.Drawing.Point(289, 300)
        Me.txtTenKhachHang.Name = "txtTenKhachHang"
        Me.txtTenKhachHang.Size = New System.Drawing.Size(166, 20)
        Me.txtTenKhachHang.TabIndex = 5
        '
        'lblTenKhachHang
        '
        Me.lblTenKhachHang.AutoSize = True
        Me.lblTenKhachHang.Location = New System.Drawing.Point(197, 303)
        Me.lblTenKhachHang.Name = "lblTenKhachHang"
        Me.lblTenKhachHang.Size = New System.Drawing.Size(86, 13)
        Me.lblTenKhachHang.TabIndex = 47
        Me.lblTenKhachHang.Text = "Tên khách hàng"
        '
        'txtMaKhachHang
        '
        Me.txtMaKhachHang.Location = New System.Drawing.Point(86, 300)
        Me.txtMaKhachHang.Name = "txtMaKhachHang"
        Me.txtMaKhachHang.Size = New System.Drawing.Size(100, 20)
        Me.txtMaKhachHang.TabIndex = 4
        '
        'lblMaKhachHang
        '
        Me.lblMaKhachHang.AutoSize = True
        Me.lblMaKhachHang.Location = New System.Drawing.Point(-2, 303)
        Me.lblMaKhachHang.Name = "lblMaKhachHang"
        Me.lblMaKhachHang.Size = New System.Drawing.Size(82, 13)
        Me.lblMaKhachHang.TabIndex = 45
        Me.lblMaKhachHang.Text = "Mã khách hàng"
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
        Me.lblDiaChi.TabIndex = 51
        Me.lblDiaChi.Text = "Địa chỉ"
        '
        'txtSoDienThoai
        '
        Me.txtSoDienThoai.Location = New System.Drawing.Point(86, 392)
        Me.txtSoDienThoai.Name = "txtSoDienThoai"
        Me.txtSoDienThoai.Size = New System.Drawing.Size(149, 20)
        Me.txtSoDienThoai.TabIndex = 7
        '
        'lblSoDienThoai
        '
        Me.lblSoDienThoai.AutoSize = True
        Me.lblSoDienThoai.Location = New System.Drawing.Point(10, 395)
        Me.lblSoDienThoai.Name = "lblSoDienThoai"
        Me.lblSoDienThoai.Size = New System.Drawing.Size(70, 13)
        Me.lblSoDienThoai.TabIndex = 53
        Me.lblSoDienThoai.Text = "Số điện thoại"
        '
        'lblBanQuyen2
        '
        Me.lblBanQuyen2.AutoSize = True
        Me.lblBanQuyen2.Location = New System.Drawing.Point(-2, 464)
        Me.lblBanQuyen2.Name = "lblBanQuyen2"
        Me.lblBanQuyen2.Size = New System.Drawing.Size(164, 13)
        Me.lblBanQuyen2.TabIndex = 56
        Me.lblBanQuyen2.Text = "MSSV: PS03299 - Lớp: PT10303"
        '
        'lblBanQuyen1
        '
        Me.lblBanQuyen1.AutoSize = True
        Me.lblBanQuyen1.Location = New System.Drawing.Point(-2, 441)
        Me.lblBanQuyen1.Name = "lblBanQuyen1"
        Me.lblBanQuyen1.Size = New System.Drawing.Size(174, 13)
        Me.lblBanQuyen1.TabIndex = 55
        Me.lblBanQuyen1.Text = "Họ và tên: PHẠM NHẬT TRƯỜNG"
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
        'btnThoat
        '
        Me.btnThoat.BackColor = System.Drawing.Color.Transparent
        Me.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnThoat.Image = CType(resources.GetObject("btnThoat.Image"), System.Drawing.Image)
        Me.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnThoat.Location = New System.Drawing.Point(601, 426)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(95, 50)
        Me.btnThoat.TabIndex = 12
        Me.btnThoat.Text = "Thoát"
        Me.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnThoat.UseVisualStyleBackColor = False
        '
        'btnLamMoi
        '
        Me.btnLamMoi.Image = CType(resources.GetObject("btnLamMoi.Image"), System.Drawing.Image)
        Me.btnLamMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLamMoi.Location = New System.Drawing.Point(601, 361)
        Me.btnLamMoi.Name = "btnLamMoi"
        Me.btnLamMoi.Size = New System.Drawing.Size(95, 50)
        Me.btnLamMoi.TabIndex = 11
        Me.btnLamMoi.Text = "Làm mới"
        Me.btnLamMoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLamMoi.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Image = CType(resources.GetObject("btnXoa.Image"), System.Drawing.Image)
        Me.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnXoa.Location = New System.Drawing.Point(601, 300)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(95, 50)
        Me.btnXoa.TabIndex = 9
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnSua
        '
        Me.btnSua.Image = CType(resources.GetObject("btnSua.Image"), System.Drawing.Image)
        Me.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSua.Location = New System.Drawing.Point(490, 361)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(95, 50)
        Me.btnSua.TabIndex = 10
        Me.btnSua.Text = "Sửa"
        Me.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSua.UseVisualStyleBackColor = True
        '
        'btnThem
        '
        Me.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnThem.Image = CType(resources.GetObject("btnThem.Image"), System.Drawing.Image)
        Me.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnThem.Location = New System.Drawing.Point(490, 299)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(95, 50)
        Me.btnThem.TabIndex = 8
        Me.btnThem.Text = "Thêm"
        Me.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'cbbTimKiem
        '
        Me.cbbTimKiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbTimKiem.FormattingEnabled = True
        Me.cbbTimKiem.Items.AddRange(New Object() {"Mã khách hàng", "Tên khách hàng", "Số điện thoại"})
        Me.cbbTimKiem.Location = New System.Drawing.Point(183, 70)
        Me.cbbTimKiem.Name = "cbbTimKiem"
        Me.cbbTimKiem.Size = New System.Drawing.Size(121, 21)
        Me.cbbTimKiem.TabIndex = 116
        '
        'frmKhachHang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(702, 486)
        Me.Controls.Add(Me.cbbTimKiem)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.btnLamMoi)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnSua)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.btnQuayLai)
        Me.Controls.Add(Me.lblBanQuyen2)
        Me.Controls.Add(Me.lblBanQuyen1)
        Me.Controls.Add(Me.txtSoDienThoai)
        Me.Controls.Add(Me.lblSoDienThoai)
        Me.Controls.Add(Me.txtDiaChi)
        Me.Controls.Add(Me.lblDiaChi)
        Me.Controls.Add(Me.txtTenKhachHang)
        Me.Controls.Add(Me.lblTenKhachHang)
        Me.Controls.Add(Me.txtMaKhachHang)
        Me.Controls.Add(Me.lblMaKhachHang)
        Me.Controls.Add(Me.txtTimKhachHang)
        Me.Controls.Add(Me.lblTimKhachHang)
        Me.Controls.Add(Me.dgwKhachHang)
        Me.Controls.Add(Me.lblVien2)
        Me.Controls.Add(Me.lblVien1)
        Me.Controls.Add(Me.lblTieuDe)
        Me.Controls.Add(Me.ptbLogo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmKhachHang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Khách hàng - Phần mềm quản lý bán hàng"
        CType(Me.ptbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgwKhachHang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblVien2 As Label
    Friend WithEvents lblVien1 As Label
    Friend WithEvents lblTieuDe As Label
    Friend WithEvents ptbLogo As PictureBox
    Friend WithEvents dgwKhachHang As DataGridView
    Friend WithEvents txtTimKhachHang As TextBox
    Friend WithEvents lblTimKhachHang As Label
    Friend WithEvents txtTenKhachHang As TextBox
    Friend WithEvents lblTenKhachHang As Label
    Friend WithEvents txtMaKhachHang As TextBox
    Friend WithEvents lblMaKhachHang As Label
    Friend WithEvents txtDiaChi As TextBox
    Friend WithEvents lblDiaChi As Label
    Friend WithEvents txtSoDienThoai As TextBox
    Friend WithEvents lblSoDienThoai As Label
    Friend WithEvents lblBanQuyen2 As Label
    Friend WithEvents lblBanQuyen1 As Label
    Friend WithEvents btnQuayLai As Button
    Friend WithEvents btnThoat As Button
    Friend WithEvents btnLamMoi As Button
    Friend WithEvents btnXoa As Button
    Friend WithEvents btnSua As Button
    Friend WithEvents btnThem As Button
    Friend WithEvents cbbTimKiem As ComboBox
End Class
