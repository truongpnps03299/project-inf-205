'**********************************
'*  Họ và tên: PHẠM NHẬT TRƯỜNG   *
'*  Mã SV: PS03299                *
'*  Lớp: PT10303                  *
'**********************************
Public Class frmLienHe
    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub
    Private Sub btnQuayLai_Click(sender As Object, e As EventArgs) Handles btnQuayLai.Click
        frmTrangChinh.Show() 'Hiện trang Chính
        Me.Hide()
    End Sub
End Class