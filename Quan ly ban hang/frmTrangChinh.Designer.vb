<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTrangChinh
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTrangChinh))
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblVien2 = New System.Windows.Forms.Label()
        Me.lblVien1 = New System.Windows.Forms.Label()
        Me.lblTieuDe = New System.Windows.Forms.Label()
        Me.ptbLogo = New System.Windows.Forms.PictureBox()
        Me.btnLienHe = New System.Windows.Forms.Button()
        Me.btnHoaDon = New System.Windows.Forms.Button()
        Me.btnSanPham = New System.Windows.Forms.Button()
        Me.btnKhachHang = New System.Windows.Forms.Button()
        Me.btnNhanVien = New System.Windows.Forms.Button()
        Me.btnThoat = New System.Windows.Forms.Button()
        CType(Me.ptbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 442)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(164, 13)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "MSSV: PS03299 - Lớp: PT10303"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 419)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(174, 13)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Họ và tên: PHẠM NHẬT TRƯỜNG"
        '
        'lblVien2
        '
        Me.lblVien2.AutoSize = True
        Me.lblVien2.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblVien2.Location = New System.Drawing.Point(399, 49)
        Me.lblVien2.Name = "lblVien2"
        Me.lblVien2.Size = New System.Drawing.Size(73, 13)
        Me.lblVien2.TabIndex = 27
        Me.lblVien2.Text = "......................"
        '
        'lblVien1
        '
        Me.lblVien1.AutoSize = True
        Me.lblVien1.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblVien1.Location = New System.Drawing.Point(-2, 49)
        Me.lblVien1.Name = "lblVien1"
        Me.lblVien1.Size = New System.Drawing.Size(316, 13)
        Me.lblVien1.TabIndex = 26
        Me.lblVien1.Text = "................................................................................." &
    "......................"
        '
        'lblTieuDe
        '
        Me.lblTieuDe.AutoSize = True
        Me.lblTieuDe.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Bold)
        Me.lblTieuDe.ForeColor = System.Drawing.Color.Red
        Me.lblTieuDe.Location = New System.Drawing.Point(12, 9)
        Me.lblTieuDe.Name = "lblTieuDe"
        Me.lblTieuDe.Size = New System.Drawing.Size(285, 40)
        Me.lblTieuDe.TabIndex = 25
        Me.lblTieuDe.Text = "Quản lý bán hàng"
        '
        'ptbLogo
        '
        Me.ptbLogo.BackgroundImage = CType(resources.GetObject("ptbLogo.BackgroundImage"), System.Drawing.Image)
        Me.ptbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ptbLogo.Location = New System.Drawing.Point(314, 26)
        Me.ptbLogo.Name = "ptbLogo"
        Me.ptbLogo.Size = New System.Drawing.Size(110, 58)
        Me.ptbLogo.TabIndex = 24
        Me.ptbLogo.TabStop = False
        '
        'btnLienHe
        '
        Me.btnLienHe.BackgroundImage = CType(resources.GetObject("btnLienHe.BackgroundImage"), System.Drawing.Image)
        Me.btnLienHe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnLienHe.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLienHe.Location = New System.Drawing.Point(316, 264)
        Me.btnLienHe.Name = "btnLienHe"
        Me.btnLienHe.Size = New System.Drawing.Size(125, 125)
        Me.btnLienHe.TabIndex = 23
        Me.btnLienHe.Text = "Liên hệ"
        Me.btnLienHe.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnLienHe.UseVisualStyleBackColor = True
        '
        'btnHoaDon
        '
        Me.btnHoaDon.BackgroundImage = CType(resources.GetObject("btnHoaDon.BackgroundImage"), System.Drawing.Image)
        Me.btnHoaDon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnHoaDon.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHoaDon.Location = New System.Drawing.Point(12, 264)
        Me.btnHoaDon.Name = "btnHoaDon"
        Me.btnHoaDon.Size = New System.Drawing.Size(125, 125)
        Me.btnHoaDon.TabIndex = 21
        Me.btnHoaDon.Text = "Hóa đơn"
        Me.btnHoaDon.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnHoaDon.UseVisualStyleBackColor = True
        '
        'btnSanPham
        '
        Me.btnSanPham.BackgroundImage = CType(resources.GetObject("btnSanPham.BackgroundImage"), System.Drawing.Image)
        Me.btnSanPham.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSanPham.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSanPham.Location = New System.Drawing.Point(164, 194)
        Me.btnSanPham.Name = "btnSanPham"
        Me.btnSanPham.Size = New System.Drawing.Size(125, 125)
        Me.btnSanPham.TabIndex = 18
        Me.btnSanPham.Text = "Sản phẩm"
        Me.btnSanPham.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSanPham.UseVisualStyleBackColor = True
        '
        'btnKhachHang
        '
        Me.btnKhachHang.BackgroundImage = CType(resources.GetObject("btnKhachHang.BackgroundImage"), System.Drawing.Image)
        Me.btnKhachHang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnKhachHang.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKhachHang.Location = New System.Drawing.Point(316, 115)
        Me.btnKhachHang.Name = "btnKhachHang"
        Me.btnKhachHang.Size = New System.Drawing.Size(125, 125)
        Me.btnKhachHang.TabIndex = 19
        Me.btnKhachHang.Text = "Khách hàng"
        Me.btnKhachHang.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnKhachHang.UseVisualStyleBackColor = True
        '
        'btnNhanVien
        '
        Me.btnNhanVien.BackgroundImage = CType(resources.GetObject("btnNhanVien.BackgroundImage"), System.Drawing.Image)
        Me.btnNhanVien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnNhanVien.Enabled = False
        Me.btnNhanVien.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNhanVien.Location = New System.Drawing.Point(12, 115)
        Me.btnNhanVien.Name = "btnNhanVien"
        Me.btnNhanVien.Size = New System.Drawing.Size(125, 125)
        Me.btnNhanVien.TabIndex = 20
        Me.btnNhanVien.Text = "Nhân viên"
        Me.btnNhanVien.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNhanVien.UseVisualStyleBackColor = True
        '
        'btnThoat
        '
        Me.btnThoat.BackColor = System.Drawing.Color.Transparent
        Me.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnThoat.Image = CType(resources.GetObject("btnThoat.Image"), System.Drawing.Image)
        Me.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnThoat.Location = New System.Drawing.Point(346, 405)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(95, 50)
        Me.btnThoat.TabIndex = 92
        Me.btnThoat.Text = "Thoát"
        Me.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnThoat.UseVisualStyleBackColor = False
        '
        'frmTrangChinh
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(455, 463)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblVien2)
        Me.Controls.Add(Me.lblVien1)
        Me.Controls.Add(Me.lblTieuDe)
        Me.Controls.Add(Me.ptbLogo)
        Me.Controls.Add(Me.btnLienHe)
        Me.Controls.Add(Me.btnHoaDon)
        Me.Controls.Add(Me.btnSanPham)
        Me.Controls.Add(Me.btnKhachHang)
        Me.Controls.Add(Me.btnNhanVien)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmTrangChinh"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Phần mềm quản lý bán hàng"
        CType(Me.ptbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblVien2 As Label
    Friend WithEvents lblVien1 As Label
    Friend WithEvents lblTieuDe As Label
    Friend WithEvents ptbLogo As PictureBox
    Friend WithEvents btnLienHe As Button
    Friend WithEvents btnHoaDon As Button
    Friend WithEvents btnSanPham As Button
    Friend WithEvents btnKhachHang As Button
    Friend WithEvents btnNhanVien As Button
    Friend WithEvents btnThoat As Button
End Class
