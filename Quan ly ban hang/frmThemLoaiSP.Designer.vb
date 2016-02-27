<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmThemLoaiSP
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmThemLoaiSP))
        Me.txtMaLoai = New System.Windows.Forms.TextBox()
        Me.lblMaLoai = New System.Windows.Forms.Label()
        Me.lblTieuDe = New System.Windows.Forms.Label()
        Me.txtTenLoai = New System.Windows.Forms.TextBox()
        Me.lblTenLoai = New System.Windows.Forms.Label()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.btnLamMoi = New System.Windows.Forms.Button()
        Me.lblVien1 = New System.Windows.Forms.Label()
        Me.lblVien2 = New System.Windows.Forms.Label()
        Me.ptbLogo = New System.Windows.Forms.PictureBox()
        Me.lblBanQuyen2 = New System.Windows.Forms.Label()
        Me.lblBanQuyen1 = New System.Windows.Forms.Label()
        Me.lsvLoaiSP = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnThoat = New System.Windows.Forms.Button()
        CType(Me.ptbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtMaLoai
        '
        Me.txtMaLoai.Location = New System.Drawing.Point(311, 141)
        Me.txtMaLoai.Name = "txtMaLoai"
        Me.txtMaLoai.Size = New System.Drawing.Size(108, 20)
        Me.txtMaLoai.TabIndex = 39
        '
        'lblMaLoai
        '
        Me.lblMaLoai.AutoSize = True
        Me.lblMaLoai.Location = New System.Drawing.Point(264, 144)
        Me.lblMaLoai.Name = "lblMaLoai"
        Me.lblMaLoai.Size = New System.Drawing.Size(41, 13)
        Me.lblMaLoai.TabIndex = 40
        Me.lblMaLoai.Text = "Mã loại"
        '
        'lblTieuDe
        '
        Me.lblTieuDe.AutoSize = True
        Me.lblTieuDe.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Bold)
        Me.lblTieuDe.ForeColor = System.Drawing.Color.Red
        Me.lblTieuDe.Location = New System.Drawing.Point(11, 9)
        Me.lblTieuDe.Name = "lblTieuDe"
        Me.lblTieuDe.Size = New System.Drawing.Size(237, 40)
        Me.lblTieuDe.TabIndex = 41
        Me.lblTieuDe.Text = "Loại sản phẩm"
        '
        'txtTenLoai
        '
        Me.txtTenLoai.Location = New System.Drawing.Point(311, 188)
        Me.txtTenLoai.Name = "txtTenLoai"
        Me.txtTenLoai.Size = New System.Drawing.Size(108, 20)
        Me.txtTenLoai.TabIndex = 42
        '
        'lblTenLoai
        '
        Me.lblTenLoai.AutoSize = True
        Me.lblTenLoai.Location = New System.Drawing.Point(260, 191)
        Me.lblTenLoai.Name = "lblTenLoai"
        Me.lblTenLoai.Size = New System.Drawing.Size(45, 13)
        Me.lblTenLoai.TabIndex = 43
        Me.lblTenLoai.Text = "Tên loại"
        '
        'btnXoa
        '
        Me.btnXoa.Image = CType(resources.GetObject("btnXoa.Image"), System.Drawing.Image)
        Me.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnXoa.Location = New System.Drawing.Point(125, 261)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(95, 50)
        Me.btnXoa.TabIndex = 45
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnSua
        '
        Me.btnSua.Image = CType(resources.GetObject("btnSua.Image"), System.Drawing.Image)
        Me.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSua.Location = New System.Drawing.Point(237, 261)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(95, 50)
        Me.btnSua.TabIndex = 46
        Me.btnSua.Text = "Sửa"
        Me.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSua.UseVisualStyleBackColor = True
        '
        'btnThem
        '
        Me.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnThem.Image = CType(resources.GetObject("btnThem.Image"), System.Drawing.Image)
        Me.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnThem.Location = New System.Drawing.Point(12, 261)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(95, 50)
        Me.btnThem.TabIndex = 44
        Me.btnThem.Text = "Thêm"
        Me.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'btnLamMoi
        '
        Me.btnLamMoi.Image = CType(resources.GetObject("btnLamMoi.Image"), System.Drawing.Image)
        Me.btnLamMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLamMoi.Location = New System.Drawing.Point(340, 261)
        Me.btnLamMoi.Name = "btnLamMoi"
        Me.btnLamMoi.Size = New System.Drawing.Size(95, 50)
        Me.btnLamMoi.TabIndex = 48
        Me.btnLamMoi.Text = "Làm mới"
        Me.btnLamMoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLamMoi.UseVisualStyleBackColor = True
        '
        'lblVien1
        '
        Me.lblVien1.AutoSize = True
        Me.lblVien1.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblVien1.Location = New System.Drawing.Point(-205, 65)
        Me.lblVien1.Name = "lblVien1"
        Me.lblVien1.Size = New System.Drawing.Size(559, 13)
        Me.lblVien1.TabIndex = 49
        Me.lblVien1.Text = "................................................................................." &
    "................................................................................" &
    "......................."
        '
        'lblVien2
        '
        Me.lblVien2.AutoSize = True
        Me.lblVien2.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblVien2.Location = New System.Drawing.Point(395, 65)
        Me.lblVien2.Name = "lblVien2"
        Me.lblVien2.Size = New System.Drawing.Size(73, 13)
        Me.lblVien2.TabIndex = 52
        Me.lblVien2.Text = "......................"
        '
        'ptbLogo
        '
        Me.ptbLogo.BackgroundImage = CType(resources.GetObject("ptbLogo.BackgroundImage"), System.Drawing.Image)
        Me.ptbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ptbLogo.Location = New System.Drawing.Point(310, 42)
        Me.ptbLogo.Name = "ptbLogo"
        Me.ptbLogo.Size = New System.Drawing.Size(110, 58)
        Me.ptbLogo.TabIndex = 51
        Me.ptbLogo.TabStop = False
        '
        'lblBanQuyen2
        '
        Me.lblBanQuyen2.AutoSize = True
        Me.lblBanQuyen2.Location = New System.Drawing.Point(9, 360)
        Me.lblBanQuyen2.Name = "lblBanQuyen2"
        Me.lblBanQuyen2.Size = New System.Drawing.Size(164, 13)
        Me.lblBanQuyen2.TabIndex = 54
        Me.lblBanQuyen2.Text = "MSSV: PS03299 - Lớp: PT10303"
        '
        'lblBanQuyen1
        '
        Me.lblBanQuyen1.AutoSize = True
        Me.lblBanQuyen1.Location = New System.Drawing.Point(9, 337)
        Me.lblBanQuyen1.Name = "lblBanQuyen1"
        Me.lblBanQuyen1.Size = New System.Drawing.Size(174, 13)
        Me.lblBanQuyen1.TabIndex = 53
        Me.lblBanQuyen1.Text = "Họ và tên: PHẠM NHẬT TRƯỜNG"
        '
        'lsvLoaiSP
        '
        Me.lsvLoaiSP.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.lsvLoaiSP.FullRowSelect = True
        Me.lsvLoaiSP.Location = New System.Drawing.Point(18, 111)
        Me.lsvLoaiSP.Name = "lsvLoaiSP"
        Me.lsvLoaiSP.Size = New System.Drawing.Size(230, 128)
        Me.lsvLoaiSP.TabIndex = 55
        Me.lsvLoaiSP.UseCompatibleStateImageBehavior = False
        Me.lsvLoaiSP.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Mã loại"
        Me.ColumnHeader1.Width = 55
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Tên loại"
        Me.ColumnHeader2.Width = 153
        '
        'btnThoat
        '
        Me.btnThoat.BackColor = System.Drawing.Color.Transparent
        Me.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnThoat.Image = CType(resources.GetObject("btnThoat.Image"), System.Drawing.Image)
        Me.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnThoat.Location = New System.Drawing.Point(340, 323)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(95, 50)
        Me.btnThoat.TabIndex = 56
        Me.btnThoat.Text = "Quay lại"
        Me.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnThoat.UseVisualStyleBackColor = False
        '
        'frmThemLoaiSP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(441, 382)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.lsvLoaiSP)
        Me.Controls.Add(Me.lblBanQuyen2)
        Me.Controls.Add(Me.lblBanQuyen1)
        Me.Controls.Add(Me.lblVien2)
        Me.Controls.Add(Me.ptbLogo)
        Me.Controls.Add(Me.lblVien1)
        Me.Controls.Add(Me.btnLamMoi)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnSua)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.txtTenLoai)
        Me.Controls.Add(Me.lblTenLoai)
        Me.Controls.Add(Me.lblTieuDe)
        Me.Controls.Add(Me.txtMaLoai)
        Me.Controls.Add(Me.lblMaLoai)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmThemLoaiSP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Thêm loại sản phẩm"
        CType(Me.ptbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtMaLoai As TextBox
    Friend WithEvents lblMaLoai As Label
    Friend WithEvents lblTieuDe As Label
    Friend WithEvents txtTenLoai As TextBox
    Friend WithEvents lblTenLoai As Label
    Friend WithEvents btnXoa As Button
    Friend WithEvents btnSua As Button
    Friend WithEvents btnThem As Button
    Friend WithEvents btnLamMoi As Button
    Friend WithEvents lblVien1 As Label
    Friend WithEvents lblVien2 As Label
    Friend WithEvents ptbLogo As PictureBox
    Friend WithEvents lblBanQuyen2 As Label
    Friend WithEvents lblBanQuyen1 As Label
    Friend WithEvents lsvLoaiSP As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents btnThoat As Button
End Class
