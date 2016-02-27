'**********************************
'*  Họ và tên: PHẠM NHẬT TRƯỜNG   *
'*  Mã SV: PS03299                *
'*  Lớp: PT10303                  *
'**********************************
Imports System.Data
Imports System.Data.SqlClient

Public Class frmSanPham

    'Truy xuất dữ liệu
    Dim con As New SqlConnection("workstation id=PS03299.mssql.somee.com;packet size=4096;user id=truongpnps03299_SQLLogin_1;pwd=on1hh5585i;data source=PS03299.mssql.somee.com;persist security info=False;initial catalog=PS03299")

    'Định nghĩa hàm truy xuất DataBaseAccess
    Private _DBAccess As New DataBaseAccess

    'Khai báo biến kiểm tra trạng thái load
    Private _isLoading As Boolean = False

    'Định nghĩa thủ tục load ComboBox
    Private Sub LoadDataOnComboBox()
        Dim sqlQuery As String = "Select MaLoaiSP, TenLoaiSP from dbo.LoaiSanPham"
        Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        Me.cbbLoaiSP.DataSource = dTable
        Me.cbbLoaiSP.ValueMember = "MaLoaiSP"
        Me.cbbLoaiSP.DisplayMember = "TenLoaiSP"

    End Sub

    'Định nghĩa thủ tục load GridView
    Private Sub LoadDataOnGridView(MaLoaiSP As String)
        Dim sqlQuery As String = String.Format("Select MaSP,TenSP,SoLuong,MoTa,MaLoaiSP from dbo.SanPham where MaLoaiSP = '{0}'", MaLoaiSP)
        Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        Me.dgwSanPham.DataSource = dTable
        With Me.dgwSanPham
            .Columns(0).HeaderText = "Mã Sản Phẩm"
            .Columns(1).HeaderText = "Tên Sản Phẩm"
            .Columns(1).Width = 150
            .Columns(2).HeaderText = "Số Lượng"
            .Columns(3).HeaderText = "Mô Tả"
            .Columns(3).Width = 205
            .Columns(4).HeaderText = "Mã Loại SP"
        End With
    End Sub

    'Làm mới dữ liệu
    Private Sub LamMoi()
        txtMaSanPham.Text = ""
        txtTenSP.Text = ""
        txtSoLuong.Text = ""
        txtMoTa.Text = ""
        txtMaLoaiSP.Text = ""
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
    Private Sub frmSanPham_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _isLoading = True 'True khi dữ liệu bắt đầu load
        LoadDataOnComboBox()
        LoadDataOnGridView(Me.cbbLoaiSP.SelectedValue)
        _isLoading = False 'Fasle khi dữ liệu load xong

    End Sub

    'Load dữ liệu từ loại sản phẩm
    Private Sub cbbLoaiSP_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbLoaiSP.SelectedIndexChanged
        If Not _isLoading Then 'Nếu Load dữ liệu xong thì
            LoadDataOnGridView(Me.cbbLoaiSP.SelectedValue)
        End If
    End Sub

    'Định nghĩa thủ tục tìm kiếm SP
    Private Sub TimKiemSanPham(MaLoaiSP As String, value As String)
        Dim sqlQuery As String = String.Format("Select MaSP,TenSP,SoLuong,MoTa,MaLoaiSP from dbo.SanPham where MaLoaiSP = '{0}'", MaLoaiSP)
        If Me.cbbTimKiem.SelectedIndex = 0 Then
            sqlQuery += String.Format("And MaSP LIKE N'%{0}%'", value)
        ElseIf Me.cbbTimKiem.SelectedIndex = 1 Then
            sqlQuery += String.Format("And TenSP LIKE N'%{0}%'", value)
        End If
        Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        Me.dgwSanPham.DataSource = dTable
        With Me.dgwSanPham
            .Columns(0).HeaderText = "Mã Sản Phẩm"
            .Columns(1).HeaderText = "Tên Sản Phẩm"
            .Columns(1).Width = 150
            .Columns(2).HeaderText = "Số Lượng"
            .Columns(3).HeaderText = "Mô Tả"
            .Columns(3).Width = 205
            .Columns(4).HeaderText = "Mã Loại SP"
        End With
    End Sub

    'Load dữ liệu loại tìm kiếm
    Private Sub txtTimSanPham_TextChanged(sender As Object, e As EventArgs) Handles txtTimSanPham.TextChanged
        TimKiemSanPham(Me.cbbLoaiSP.SelectedValue, Me.txtTimSanPham.Text)
    End Sub

    'Gán dữ liệu vào khung textbox
    Private Sub dgwSanPham_SelectionChanged(sender As Object, e As EventArgs) Handles dgwSanPham.SelectionChanged
        Dim index As Integer = dgwSanPham.CurrentRow.Index
        txtMaSanPham.Text = dgwSanPham.Rows(index).Cells(0).Value.ToString
        txtTenSP.Text = dgwSanPham.Rows(index).Cells(1).Value.ToString
        txtSoLuong.Text = dgwSanPham.Rows(index).Cells(2).Value.ToString
        txtMoTa.Text = dgwSanPham.Rows(index).Cells(3).Value.ToString
        txtMaLoaiSP.Text = dgwSanPham.Rows(index).Cells(4).Value.ToString
    End Sub

    'Định nghĩa nút thêm
    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Try
            con.Open()
            Dim MaSP As String = txtMaSanPham.Text
            Dim TenSP As String = txtTenSP.Text
            Dim SoLuong As String = txtSoLuong.Text
            Dim MoTa As String = txtMoTa.Text
            Dim MaLoaiSP As String = txtMaLoaiSP.Text
            Dim com As New SqlCommand("INSERT INTO SanPham (MaSP,TenSP,SoLuong,MoTa,MaLoaiSP) VALUES (N'" + MaSP + "',N'" + TenSP + "',N'" + SoLuong + "',N'" + MoTa + "',N'" + MaLoaiSP + "')", con)
            com.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("Thêm dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadDataOnGridView(Me.cbbLoaiSP.SelectedValue)
            LamMoi()
        Catch ex As Exception
            MessageBox.Show("Lỗi thêm dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    'Định nghãi nút Xóa
    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Try
            con.Open()
            Dim MaSP As String = txtMaSanPham.Text
            Dim com As New SqlCommand("DELETE FROM SanPham Where MaSP = '" + MaSP + "'", con)
            com.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("Xóa dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadDataOnGridView(Me.cbbLoaiSP.SelectedValue)
            LamMoi()
        Catch ex As Exception
            MessageBox.Show("Lỗi xóa dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Định nghĩa nút sửa
    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        Try
            con.Open()
            Dim MaSP As String = txtMaSanPham.Text
            Dim TenSP As String = txtTenSP.Text
            Dim SoLuong As String = txtSoLuong.Text
            Dim MoTa As String = txtMoTa.Text
            Dim MaLoaiSP As String = txtMaLoaiSP.Text
            Dim com As New SqlCommand("UPDATE SanPham SET TenSP =N'" + TenSP + "',SoLuong =N'" + SoLuong + "',MoTa =N'" + MoTa + "',MaLoaiSP =N'" + MaLoaiSP + "' WHERE MaSP =N'" + MaSP + "'", con)
            com.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("Cập nhật dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadDataOnGridView(Me.cbbLoaiSP.SelectedValue)
            LamMoi()
        Catch ex As Exception
            MessageBox.Show("Lỗi cập nhật dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Định nghĩa nút làm mới
    Private Sub btnLamMoi_Click(sender As Object, e As EventArgs) Handles btnLamMoi.Click
        LamMoi()
    End Sub

    'Định nghĩa nút thêm loại sản phẩm
    Private Sub btnThemLoai_Click(sender As Object, e As EventArgs) Handles btnThemLoai.Click
        frmThemLoaiSP.Show()
        Me.Hide()
    End Sub
End Class