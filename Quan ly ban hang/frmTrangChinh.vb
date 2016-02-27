'**********************************
'*  Họ và tên: PHẠM NHẬT TRƯỜNG   *
'*  Mã SV: PS03299                *
'*  Lớp: PT10303                  *
'**********************************
Public Class frmTrangChinh


    Private Sub btnSanPham_Click(sender As Object, e As EventArgs) Handles btnSanPham.Click
        frmSanPham.Show()  ' Hiện trang Sản Phẩm
        Me.Hide()
    End Sub
    Private Sub btnKhachHang_Click(sender As Object, e As EventArgs) Handles btnKhachHang.Click
        frmKhachHang.Show() 'Hiện trang Khách Hàng
        Me.Hide()
    End Sub

    Private Sub btnNhanVien_Click(sender As Object, e As EventArgs) Handles btnNhanVien.Click
        frmNhanVien.Show() 'Hiện trang Nhân Viên
        Me.Hide()
    End Sub

    Private Sub btnHoaDon_Click(sender As Object, e As EventArgs) Handles btnHoaDon.Click
        frmHoaDon.Show() 'Hiện trang Hóa Đơn
        Me.Hide()
    End Sub

    Private Sub btnLienHe_Click(sender As Object, e As EventArgs) Handles btnLienHe.Click
        frmLienHe.Show() 'Hiện trang Liên Hệ
        Me.Hide()
    End Sub
    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub

End Class