<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLienHe
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLienHe))
        Me.btnQuayLai = New System.Windows.Forms.Button()
        Me.lblVien1 = New System.Windows.Forms.Label()
        Me.lblTieuDe = New System.Windows.Forms.Label()
        Me.ptbLogo = New System.Windows.Forms.PictureBox()
        Me.lblVien2 = New System.Windows.Forms.Label()
        Me.lblNoiDung = New System.Windows.Forms.Label()
        Me.btnThoat = New System.Windows.Forms.Button()
        CType(Me.ptbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnQuayLai
        '
        Me.btnQuayLai.BackColor = System.Drawing.Color.Transparent
        Me.btnQuayLai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnQuayLai.Image = CType(resources.GetObject("btnQuayLai.Image"), System.Drawing.Image)
        Me.btnQuayLai.Location = New System.Drawing.Point(10, 40)
        Me.btnQuayLai.Name = "btnQuayLai"
        Me.btnQuayLai.Size = New System.Drawing.Size(37, 38)
        Me.btnQuayLai.TabIndex = 1
        Me.btnQuayLai.UseVisualStyleBackColor = False
        '
        'lblVien1
        '
        Me.lblVien1.AutoSize = True
        Me.lblVien1.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblVien1.Location = New System.Drawing.Point(-148, 49)
        Me.lblVien1.Name = "lblVien1"
        Me.lblVien1.Size = New System.Drawing.Size(559, 13)
        Me.lblVien1.TabIndex = 68
        Me.lblVien1.Text = "................................................................................." &
    "................................................................................" &
    "......................."
        '
        'lblTieuDe
        '
        Me.lblTieuDe.AutoSize = True
        Me.lblTieuDe.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Bold)
        Me.lblTieuDe.ForeColor = System.Drawing.Color.Red
        Me.lblTieuDe.Location = New System.Drawing.Point(61, 9)
        Me.lblTieuDe.Name = "lblTieuDe"
        Me.lblTieuDe.Size = New System.Drawing.Size(128, 40)
        Me.lblTieuDe.TabIndex = 67
        Me.lblTieuDe.Text = "Liên hệ"
        '
        'ptbLogo
        '
        Me.ptbLogo.BackgroundImage = CType(resources.GetObject("ptbLogo.BackgroundImage"), System.Drawing.Image)
        Me.ptbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ptbLogo.Location = New System.Drawing.Point(409, 26)
        Me.ptbLogo.Name = "ptbLogo"
        Me.ptbLogo.Size = New System.Drawing.Size(110, 58)
        Me.ptbLogo.TabIndex = 66
        Me.ptbLogo.TabStop = False
        '
        'lblVien2
        '
        Me.lblVien2.AutoSize = True
        Me.lblVien2.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblVien2.Location = New System.Drawing.Point(509, 49)
        Me.lblVien2.Name = "lblVien2"
        Me.lblVien2.Size = New System.Drawing.Size(73, 13)
        Me.lblVien2.TabIndex = 117
        Me.lblVien2.Text = "......................"
        '
        'lblNoiDung
        '
        Me.lblNoiDung.AutoSize = True
        Me.lblNoiDung.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoiDung.Location = New System.Drawing.Point(7, 93)
        Me.lblNoiDung.Name = "lblNoiDung"
        Me.lblNoiDung.Size = New System.Drawing.Size(527, 140)
        Me.lblNoiDung.TabIndex = 118
        Me.lblNoiDung.Text = resources.GetString("lblNoiDung.Text")
        '
        'btnThoat
        '
        Me.btnThoat.BackColor = System.Drawing.Color.Transparent
        Me.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnThoat.Image = CType(resources.GetObject("btnThoat.Image"), System.Drawing.Image)
        Me.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnThoat.Location = New System.Drawing.Point(476, 236)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(95, 50)
        Me.btnThoat.TabIndex = 2
        Me.btnThoat.Text = "Thoát"
        Me.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnThoat.UseVisualStyleBackColor = False
        '
        'frmLienHe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(580, 289)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.lblNoiDung)
        Me.Controls.Add(Me.lblVien2)
        Me.Controls.Add(Me.btnQuayLai)
        Me.Controls.Add(Me.lblVien1)
        Me.Controls.Add(Me.lblTieuDe)
        Me.Controls.Add(Me.ptbLogo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmLienHe"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Liên hệ - Phần mềm quản lý bán hàng"
        CType(Me.ptbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnQuayLai As Button
    Friend WithEvents lblVien1 As Label
    Friend WithEvents lblTieuDe As Label
    Friend WithEvents ptbLogo As PictureBox
    Friend WithEvents lblVien2 As Label
    Friend WithEvents lblNoiDung As Label
    Friend WithEvents btnThoat As Button
End Class
