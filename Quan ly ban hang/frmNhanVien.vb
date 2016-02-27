'**********************************
'*  Họ và tên: PHẠM NHẬT TRƯỜNG   *
'*  Mã SV: PS03299                *
'*  Lớp: PT10303                  *
'**********************************
Imports System.Data
Imports System.Data.SqlClient
Public Class frmNhanVien

    'Truy xuất dữ liệu
    Dim con As New SqlConnection("workstation id=PS03299.mssql.somee.com;packet size=4096;user id=truongpnps03299_SQLLogin_1;pwd=on1hh5585i;data source=PS03299.mssql.somee.com;persist security info=False;initial catalog=PS03299")

    'Định nghĩa hàm truy xuất DataBaseAccess
    Private _DBAccess As New DataBaseAccess

    'Khai báo biến kiểm tra trạng thái load
    Private _isLoading As Boolean = False


    'Định nghĩa thủ tục load GridView
    Private Sub LoadDataOnGridView()
        Dim sqlQuery As String = String.Format("Select MaNV,MatKhau,TenNhanVien,DiaChi,SoDienThoai,GiaTri from dbo.NhanVien")
        Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        Me.dgwNhanVien.DataSource = dTable
        With Me.dgwNhanVien
            .Columns(0).HeaderText = "Mã Nhân Viên"
            .Columns(0).Width = 120
            .Columns(1).HeaderText = "Tên Mât Khẩu"
            .Columns(2).HeaderText = "Tên Nhân Viên"
            .Columns(2).Width = 150
            .Columns(3).HeaderText = "Đỉa Chỉ"
            .Columns(3).Width = 132
            .Columns(4).HeaderText = "Số Điện Thoại"
            .Columns(5).HeaderText = "Quyền"
            .Columns(5).Width = 50
        End With
    End Sub
    Private Sub btnQuayLai_Click(sender As Object, e As EventArgs) Handles btnQuayLai.Click
        frmTrangChinh.Show() 'Hiện trang Chính
        Me.Hide()
    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub

    Private Sub frmNhanVien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataOnGridView()
    End Sub

    'Định nghĩa làm mới
    Private Sub LamMoi()
        txtMaNhanVien.Text = ""
        txtMatKhau.Text = ""
        txtTenNhanVien.Text = ""
        txtDiaChi.Text = ""
        txtSoDienThoai.Text = ""
        txtQuyen.Text = ""
    End Sub

    'Định nghĩa thủ tục tìm kiếm Nhân Viên
    Private Sub TimKiemNhanVien(value As String)
        Dim sqlQuery As String = String.Format("Select MaNV,MatKhau,TenNhanVien,DiaChi,SoDienThoai,GiaTri from dbo.NhanVien")
        If Me.cbbTimKiem.SelectedIndex = 0 Then
            sqlQuery += String.Format(" Where MaNV Like N'%{0}%'", value)
        ElseIf Me.cbbTimKiem.SelectedIndex = 1 Then
            sqlQuery += String.Format(" Where TenNhanVien Like N'%{0}%'", value)
        ElseIf Me.cbbTimKiem.SelectedIndex = 2 Then
            sqlQuery += String.Format(" Where SoDienThoai Like N'%{0}%'", value)
        End If
        Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        Me.dgwNhanVien.DataSource = dTable
        With Me.dgwNhanVien
            .Columns(0).HeaderText = "Mã Nhân Viên"
            .Columns(0).Width = 120
            .Columns(1).HeaderText = "Mât Khẩu"
            .Columns(2).HeaderText = "Tên Nhân Viên"
            .Columns(2).Width = 150
            .Columns(3).HeaderText = "Đỉa Chỉ"
            .Columns(3).Width = 132
            .Columns(4).HeaderText = "Số Điện Thoại"
            .Columns(5).HeaderText = "Quyền"
            .Columns(5).Width = 50
        End With
    End Sub
    Private Sub txtTimNhanVien_TextChanged(sender As Object, e As EventArgs) Handles txtTimNhanVien.TextChanged
        TimKiemNhanVien(Me.txtTimNhanVien.Text)
    End Sub

    'Gán dữ liệu vào TextBox
    Private Sub dgwNhanVien_SelectionChanged(sender As Object, e As EventArgs) Handles dgwNhanVien.SelectionChanged
        Dim index As String = dgwNhanVien.CurrentRow.Index
        txtMaNhanVien.Text = dgwNhanVien.Rows(index).Cells(0).Value.ToString
        txtMatKhau.Text = dgwNhanVien.Rows(index).Cells(1).Value.ToString
        txtTenNhanVien.Text = dgwNhanVien.Rows(index).Cells(2).Value.ToString
        txtDiaChi.Text = dgwNhanVien.Rows(index).Cells(3).Value.ToString
        txtSoDienThoai.Text = dgwNhanVien.Rows(index).Cells(4).Value.ToString
        txtQuyen.Text = dgwNhanVien.Rows(index).Cells(5).Value.ToString
    End Sub

    'Định nghĩa nút thêm
    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Try
            con.Open()
            Dim MaNV As String = txtMaNhanVien.Text
            Dim MatKhau As String = txtMatKhau.Text
            Dim TenNV As String = txtTenNhanVien.Text
            Dim DiaChi As String = txtDiaChi.Text
            Dim SoDT As String = txtSoDienThoai.Text
            Dim Quyen As String = txtQuyen.Text
            Dim com As New SqlCommand("INSERT INTO NhanVien (MaNV,MatKhau,TenNhanVien,DiaChi,SoDienThoai,GiaTri) VALUES (N'" + MaNV + "',N'" + MatKhau + "',N'" + TenNV + "',N'" + DiaChi + "',N'" + SoDT + "',N'" + Quyen + "')", con)
            com.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("Thêm dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadDataOnGridView()
            LamMoi()
        Catch ex As Exception
            MessageBox.Show("Lỗi thêm dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Đinh nghĩa nút xóa
    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Try
            con.Open()
            Dim MaNV As String = txtMaNhanVien.Text
            Dim com As New SqlCommand("DELETE FROM NhanVien Where MaNV = '" + MaNV + "'", con)
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
            Dim MaNV As String = txtMaNhanVien.Text
            Dim MatKhau As String = txtMatKhau.Text
            Dim TenNV As String = txtTenNhanVien.Text
            Dim DiaChi As String = txtDiaChi.Text
            Dim SoDT As String = txtSoDienThoai.Text
            Dim Quyen As String = txtQuyen.Text
            Dim com As New SqlCommand("UPDATE NhanVien SET MatKhau =N'" + MatKhau + "',TenNhanVien =N'" + TenNV + "',DiaChi =N'" + DiaChi + "',SoDienThoai =N'" + SoDT + "',GiaTri =N'" + Quyen + "' WHERE MaNV =N'" + MaNV + "'", con)
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