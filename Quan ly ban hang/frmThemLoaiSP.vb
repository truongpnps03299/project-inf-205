'**********************************
'*  Họ và tên: PHẠM NHẬT TRƯỜNG   *
'*  Mã SV: PS03299                *
'*  Lớp: PT10303                  *
'**********************************
Imports System.Data
Imports System.Data.SqlClient

Public Class frmThemLoaiSP
    'Định nghĩa hàm truy xuất DataBaseAccess
    Dim con As New SqlConnection("workstation id=PS03299.mssql.somee.com;packet size=4096;user id=truongpnps03299_SQLLogin_1;pwd=on1hh5585i;data source=PS03299.mssql.somee.com;persist security info=False;initial catalog=PS03299")

    'Lấy dữ liệu vào bảng list view
    Private Sub LoadData()
        con.Open()
        Dim com As New SqlCommand("Select * from LoaiSanPham", con)
        Dim da As New SqlDataAdapter(com)
        Dim dt As New DataTable
        da.Fill(dt)
        con.Close()
        lsvLoaiSP.Items.Clear()
        Dim i As Integer
        For Each row As DataRow In dt.Rows
            lsvLoaiSP.Items.Add(row("MaLoaiSP").ToString())
            lsvLoaiSP.Items(i).SubItems.Add(row("TenLoaiSP").ToString())
            i += 1
        Next
        con.Close()
    End Sub

    'Đưa listview vào text box
    Private Sub lsvLoaiSP_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsvLoaiSP.SelectedIndexChanged
        For Each list As ListViewItem In lsvLoaiSP.SelectedItems
            txtMaLoai.Text = list.SubItems(0).Text
            txtTenLoai.Text = list.SubItems(1).Text
        Next
    End Sub

    'Làm mới dữ liệu
    Private Sub LamMoi()
        txtMaLoai.Text = ""
        txtTenLoai.Text = ""
    End Sub

    'Load dữ liệu
    Private Sub frmThemLoaiSP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            con.Open()
            con.Close()
        Catch ex As Exception
            MessageBox.Show("Kết nối không thành công")
        End Try
        LoadData()
    End Sub

    'Định nghĩa nút thêm
    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Try
            con.Open()
            Dim MaLoai As String = txtMaLoai.Text
            Dim TenLoaiSP As String = txtTenLoai.Text
            Dim com As New SqlCommand("INSERT INTO LoaiSanPham (MaLoaiSP,TenLoaiSP) VALUES (N'" + MaLoai + "',N'" + TenLoaiSP + "')", con)
            com.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("Thêm dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadData()
            LamMoi()
        Catch ex As Exception
            MessageBox.Show("Lỗi thêm dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Định nghĩa nút xóa 
    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Try
            con.Open()
            Dim MaLoai As String = txtMaLoai.Text
            Dim com As New SqlCommand("DELETE FROM LoaiSanPham Where MaLoaiSP = '" + MaLoai + "'", con)
            com.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("Xóa dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadData()
            LamMoi()
        Catch ex As Exception
            MessageBox.Show("Lỗi xóa dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Định nghĩa nút sửa
    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        Try
            con.Open()
            Dim MaLoai As String = txtMaLoai.Text
            Dim TenLoaiSP As String = txtTenLoai.Text
            Dim com As New SqlCommand("UPDATE LoaiSanPham SET TenLoaiSP =N'" + TenLoaiSP + "' WHERE MaLoaiSP =N'" + MaLoai + "'", con)
            com.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("Cập nhật dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadData()
            LamMoi()
        Catch ex As Exception
            MessageBox.Show("Lỗi cập nhật dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Định nghĩa làm mới
    Private Sub btnLamMoi_Click(sender As Object, e As EventArgs) Handles btnLamMoi.Click
        LamMoi()
    End Sub

    'Đình nút quay lại
    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Dim frm As New frmSanPham
        frm = New frmSanPham
        frm.ShowDialog()
        Me.Hide()
    End Sub
End Class