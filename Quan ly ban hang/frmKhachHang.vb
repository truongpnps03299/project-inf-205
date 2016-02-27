'**********************************
'*  Họ và tên: PHẠM NHẬT TRƯỜNG   *
'*  Mã SV: PS03299                *
'*  Lớp: PT10303                  *
'**********************************
Imports System.Data
Imports System.Data.SqlClient

Public Class frmKhachHang

    'Truy xuất dữ liệu
    Dim con As New SqlConnection("workstation id=PS03299.mssql.somee.com;packet size=4096;user id=truongpnps03299_SQLLogin_1;pwd=on1hh5585i;data source=PS03299.mssql.somee.com;persist security info=False;initial catalog=PS03299")

    'Định nghĩa hàm truy xuất DataBaseAccess
    Private _DBAccess As New DataBaseAccess

    'Khai báo biến kiểm tra trạng thái load
    Private _isLoading As Boolean = False


    'Định nghĩa thủ tục load GridView
    Private Sub LoadDataOnGridView()
        Dim sqlQuery As String = String.Format("Select MaKH,TenKH,DiaChi,SoDT from dbo.KhachHang")
        Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        Me.dgwKhachHang.DataSource = dTable
        With Me.dgwKhachHang
            .Columns(0).HeaderText = "Mã Khách Hàng"
            .Columns(0).Width = 120
            .Columns(1).HeaderText = "Tên Khách Hàng"
            .Columns(1).Width = 150
            .Columns(2).HeaderText = "Địa Chỉ"
            .Columns(2).Width = 282
            .Columns(3).HeaderText = "Số Điện Thoại"
        End With
    End Sub

    'Định nghĩa nút quay lại
    Private Sub btnQuayLai_Click(sender As Object, e As EventArgs) Handles btnQuayLai.Click
        frmTrangChinh.Show() 'Hiện trang Chính
        Me.Hide()
    End Sub

    'Định nghĩa nút thoát
    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub

    'Load dữ liệu
    Private Sub frmKhachHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataOnGridView()
    End Sub

    'Định nghĩa thủ tục tìm kiếm Khách Hàng
    Private Sub TimKiemKhachHang(value As String)
        Dim sqlQuery As String = String.Format("Select MaKH,TenKH,DiaChi,SoDT from dbo.KhachHang")
        If Me.cbbTimKiem.SelectedIndex = 0 Then
            sqlQuery += String.Format(" Where MaKH Like N'%{0}%'", value)
        ElseIf Me.cbbTimKiem.SelectedIndex = 1 Then
            sqlQuery += String.Format(" Where TenKH Like N'%{0}%'", value)
        ElseIf Me.cbbTimKiem.SelectedIndex = 2 Then
            sqlQuery += String.Format(" Where SoDT Like N'%{0}%'", value)
        End If
        Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        Me.dgwKhachHang.DataSource = dTable
        With Me.dgwKhachHang
            .Columns(0).HeaderText = "Mã Khách Hàng"
            .Columns(0).Width = 120
            .Columns(1).HeaderText = "Tên Khách Hàng"
            .Columns(1).Width = 150
            .Columns(2).HeaderText = "Địa Chỉ"
            .Columns(2).Width = 282
            .Columns(3).HeaderText = "Số Điện Thoại"
        End With
    End Sub

    'Định nghĩa loại tìm kiếm
    Private Sub txtTimKhachHang_TextChanged(sender As Object, e As EventArgs) Handles txtTimKhachHang.TextChanged
        TimKiemKhachHang(Me.txtTimKhachHang.Text)
    End Sub

    'Gán dữ liệu vào TextBox
    Private Sub dgwKhachHang_SelectionChanged(sender As Object, e As EventArgs) Handles dgwKhachHang.SelectionChanged
        Dim index As String = dgwKhachHang.CurrentRow.Index
        txtMaKhachHang.Text = dgwKhachHang.Rows(index).Cells(0).Value.ToString
        txtTenKhachHang.Text = dgwKhachHang.Rows(index).Cells(1).Value.ToString
        txtDiaChi.Text = dgwKhachHang.Rows(index).Cells(2).Value.ToString
        txtSoDienThoai.Text = dgwKhachHang.Rows(index).Cells(3).Value.ToString
    End Sub

    'Định nhgiã nút làm mới
    Private Sub LamMoi()
        txtMaKhachHang.Text = ""
        txtTenKhachHang.Text = ""
        txtDiaChi.Text = ""
        txtSoDienThoai.Text = ""
    End Sub

    'Định nghĩa nút thêm
    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Try
            con.Open()
            Dim MaKH As String = txtMaKhachHang.Text
            Dim TenKH As String = txtTenKhachHang.Text
            Dim DiaChi As String = txtDiaChi.Text
            Dim SoDT As String = txtSoDienThoai.Text
            Dim com As New SqlCommand("INSERT INTO KhachHang (MaKH,TenKH,DiaChi,SoDT) VALUES (N'" + MaKH + "',N'" + TenKH + "',N'" + DiaChi + "',N'" + SoDT + "')", con)
            com.ExecuteNonQuery()
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
            Dim MaKH As String = txtMaKhachHang.Text
            Dim com As New SqlCommand("DELETE FROM KhachHang Where MaKH = '" + MaKH + "'", con)
            com.ExecuteNonQuery()
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
            Dim MaKH As String = txtMaKhachHang.Text
            Dim TenKH As String = txtTenKhachHang.Text
            Dim DiaChi As String = txtDiaChi.Text
            Dim SoDT As String = txtSoDienThoai.Text
            Dim com As New SqlCommand("UPDATE KhachHang SET TenKH =N'" + TenKH + "',DiaChi =N'" + DiaChi + "',SoDT =N'" + SoDT + "' WHERE MaKH =N'" + MaKH + "'", con)
            com.ExecuteNonQuery()
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