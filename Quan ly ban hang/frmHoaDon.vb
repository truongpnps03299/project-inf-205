'**********************************
'*  Họ và tên: PHẠM NHẬT TRƯỜNG   *
'*  Mã SV: PS03299                *
'*  Lớp: PT10303                  *
'**********************************
Imports System.Data
Imports System.Data.SqlClient

Public Class frmHoaDon

    'Truy xuất dữ liệu
    Dim con As New SqlConnection("workstation id=PS03299.mssql.somee.com;packet size=4096;user id=truongpnps03299_SQLLogin_1;pwd=on1hh5585i;data source=PS03299.mssql.somee.com;persist security info=False;initial catalog=PS03299")

    'Định nghĩa hàm truy xuất DataBaseAccess
    Private _DBAccess As New DataBaseAccess

    'Khai báo biến kiểm tra trạng thái load
    Private _isLoading As Boolean = False

    'Định nghĩa thủ tục load GridView
    Private Sub LoadDataOnGridView()
        Dim sqlQuery As String = String.Format("Select ChiTietHoaDon.MaHD,HoaDon.MaKH,TenKH,ThoiGian,SanPham.MaSP,TenSP,SLMua,DonGia,SLMua*DonGia from ChiTietHoaDon,HoaDon,SanPham,KhachHang where HoaDon.MaHD = ChiTietHoaDon.MaHD and ChiTietHoaDon.MaSP = SanPham.MaSP and HoaDon.MaKH = KhachHang.MaKH")
        Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        Me.dgvHoaDon.DataSource = dTable
        With Me.dgvHoaDon
            .Columns(0).HeaderText = "Mã HĐ"
            .Columns(0).Width = 80
            .Columns(1).HeaderText = "Mã KH"
            .Columns(1).Width = 80
            .Columns(2).HeaderText = "Tên Khách Hàng"
            .Columns(2).Width = 140
            .Columns(3).HeaderText = "Thời Gian"
            .Columns(3).Width = 85
            .Columns(4).HeaderText = "Mã Sản Phẩm"
            .Columns(5).HeaderText = "Tên Sản Phẩm"
            .Columns(5).Width = 150
            .Columns(6).HeaderText = "SL Mua"
            .Columns(6).Width = 75
            .Columns(7).HeaderText = "Đơn Giá"
            .Columns(7).Width = 75
            .Columns(8).HeaderText = "Tổng tiền"
            .Columns(8).Width = 80
        End With
    End Sub
    Private Sub btnQuayLai_Click(sender As Object, e As EventArgs) Handles btnQuayLai.Click
        frmTrangChinh.Show() 'Hiện trang Chính
        Me.Hide()
    End Sub
    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub

    Private Sub frmHoaDon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataOnGridView()
    End Sub
    'Định nghĩa thủ tục hiện thị kết quả
    Private Sub TimKiemHoaDon(value As String)
        Dim sqlQuery As String = String.Format("Select ChiTietHoaDon.MaHD,HoaDon.MaKH,TenKH,ThoiGian,SanPham.MaSP,TenSP,SLMua,DonGia,SLMua*DonGia from ChiTietHoaDon,HoaDon,SanPham,KhachHang where HoaDon.MaHD = ChiTietHoaDon.MaHD and ChiTietHoaDon.MaSP = SanPham.MaSP and HoaDon.MaKH = KhachHang.MaKH")
        If Me.cbbTimKiem.SelectedIndex = 0 Then 'Tìm theo mã hóa đơn
            sqlQuery += String.Format(" And ChiTietHoaDon.MaHD LIKE N'%{0}%'", value)
        ElseIf Me.cbbTimKiem.SelectedIndex = 1 Then
            sqlQuery += String.Format(" And TenKH LIKE N'%{0}%'", value)
        ElseIf Me.cbbTimKiem.SelectedIndex = 2 Then
            sqlQuery += String.Format(" And TenSP LIKE N'%{0}%'", value)
        End If
        Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        Me.dgvHoaDon.DataSource = dTable
        With Me.dgvHoaDon
            .Columns(0).HeaderText = "Mã HĐ"
            .Columns(0).Width = 80
            .Columns(1).HeaderText = "Mã KH"
            .Columns(1).Width = 80
            .Columns(2).HeaderText = "Tên Khách Hàng"
            .Columns(2).Width = 140
            .Columns(3).HeaderText = "Thời Gian"
            .Columns(3).Width = 85
            .Columns(4).HeaderText = "Mã Sản Phẩm"
            .Columns(5).HeaderText = "Tên Sản Phẩm"
            .Columns(5).Width = 150
            .Columns(6).HeaderText = "SL Mua"
            .Columns(6).Width = 75
            .Columns(7).HeaderText = "Đơn Giá"
            .Columns(7).Width = 75
            .Columns(8).HeaderText = "Tổng tiền"
            .Columns(8).Width = 80
        End With
    End Sub
    Private Sub txtTimHoaDon_TextChanged(sender As Object, e As EventArgs) Handles txtTimHoaDon.TextChanged
        TimKiemHoaDon(Me.txtTimHoaDon.Text)
    End Sub

    'Gán dữ liệu vào khung textbox
    Private Sub dgvHoaDon_SelectionChanged(sender As Object, e As EventArgs) Handles dgvHoaDon.SelectionChanged

        Dim index As Integer = dgvHoaDon.CurrentRow.Index
            txtMaHoaDon.Text = dgvHoaDon.Rows(index).Cells(0).Value.ToString
            txtMaKH.Text = dgvHoaDon.Rows(index).Cells(1).Value.ToString
        dtpThoiGian.Value = dgvHoaDon.Rows(index).Cells(3).Value.ToString
        txtMaSP.Text = dgvHoaDon.Rows(index).Cells(4).Value.ToString
            txtSoLuongMua.Text = dgvHoaDon.Rows(index).Cells(6).Value.ToString
            txtDonGia.Text = dgvHoaDon.Rows(index).Cells(7).Value.ToString

    End Sub

    'Định nghĩa làm mới
    Private Sub LamMoi()
        txtMaHoaDon.Text = ""
        txtMaKH.Text = ""
        dtpThoiGian.ResetText()
        txtMaSP.Text = ""
        txtSoLuongMua.Text = ""
        txtDonGia.Text = ""
    End Sub

    'Định nghĩa nút thêm
    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Try
            con.Open()
            Dim MaHD As String = txtMaHoaDon.Text
            Dim MaKH As String = txtMaKH.Text
            Dim ThoiGian As String = Format(Convert.ToDateTime(dtpThoiGian.Text), "MM/dd/yyyy")
            Dim MaSP As String = txtMaSP.Text
            Dim SLMua As String = txtSoLuongMua.Text
            Dim DonGia As String = txtDonGia.Text
            Dim com As New SqlCommand("INSERT INTO HoaDon (MaHD,ThoiGian,MaKH) VALUES (N'" + MaHD + "','" + ThoiGian + "',N'" + MaKH + "')", con)
            Dim com2 As New SqlCommand("INSERT INTO ChiTietHoaDon (MaSP,MaHD,SLMua,DonGia) VALUES (N'" + MaSP + "',N'" + MaHD + "',N'" + SLMua + "',N'" + DonGia + "')", con)
            com.ExecuteNonQuery()
            com2.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("Thêm dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadDataOnGridView()
            LamMoi()
        Catch ex As Exception
            MessageBox.Show("Lỗi thêm dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Định nghĩa nút xóa
    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Try
            con.Open()
            Dim MaHD As String = txtMaHoaDon.Text
            Dim MaSP As String = txtMaSP.Text
            Dim com As New SqlCommand("DELETE FROM ChiTietHoaDon WHERE MaHD = '" + MaHD + "'", con)
            Dim com2 As New SqlCommand("DELETE FROM HoaDon WHERE MaHD = '" + MaHD + "'", con)
            com.ExecuteNonQuery()
            com2.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("Xóa dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadDataOnGridView()
            LamMoi()
        Catch ex As Exception
            MessageBox.Show("Lỗi xóa dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Định nghĩa nút sửa
    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        Try
            con.Open()
            Dim MaHD As String = txtMaHoaDon.Text
            Dim MaKH As String = txtMaKH.Text
            Dim ThoiGian As String = Format(Convert.ToDateTime(dtpThoiGian.Text), "MM/dd/yyyy")
            Dim MaSP As String = txtMaSP.Text
            Dim SLMua As String = txtSoLuongMua.Text
            Dim DonGia As String = txtDonGia.Text
            Dim com As New SqlCommand("UPDATE HoaDon SET ThoiGian =N'" + ThoiGian + "',MaKH =N'" + MaKH + "' WHERE MaHD =N'" + MaHD + "'", con)
            Dim com2 As New SqlCommand("UPDATE ChiTietHoaDon SET SLMua =N'" + SLMua + "',DonGia ='" + DonGia + "' WHERE MaSP =N'" + MaSP + "'", con)
            com.ExecuteNonQuery()
            com2.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("Cập nhật dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadDataOnGridView()
            LamMoi()
        Catch ex As Exception
            MessageBox.Show("Lỗi cập nhật dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Định nghĩa nút làm mới
    Private Sub btnLamMoi_Click(sender As Object, e As EventArgs) Handles btnLamMoi.Click
        LamMoi()
    End Sub


End Class