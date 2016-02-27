Imports System.Configuration
Imports System.Data.SqlClient

Public Class frmDangNhap
    'Khai báo biến kết nối CSDL
    Private _ConnectionString As String = "workstation id=PS03299.mssql.somee.com;packet size=4096;user id=truongpnps03299_SQLLogin_1;pwd=on1hh5585i;data source=PS03299.mssql.somee.com;persist security info=False;initial catalog=PS03299"
    Private Connect As SqlConnection
    Private Data As SqlDataAdapter
    'Định nghĩa hàm lấy dữ liệu vào bảng DataTable
    Private Function getDataTable(sqlQuery As String) As DataTable
        Dim DataTable As New DataTable
        'Khởi tạo biến Connect
        Connect = New SqlConnection(_ConnectionString)

        'Khởi tạo biến Data
        Data = New SqlDataAdapter(sqlQuery, Connect)

        Try
            'Mở Connection
            Connect.Open()

            'Lấy dữ liệu vào DataTable
            Data.Fill(DataTable)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error") 'Thông báo nếu có lỗi
        Finally
            Connect.Close() 'Đóng Connect
        End Try
        Return DataTable
    End Function

    'Định nghĩa hàm kiểm tra tài khoản
    Private Function CheckLogin(TaiKhoan As String, MatKhau As String, GiaTri As String)
        Dim sqlQuery As String = String.Format("select * from NhanVien where MaNV ='{0}' and MatKhau ='{1}' and GiaTri ='{2}'", TaiKhoan, MatKhau, GiaTri)
        Dim DataTable As DataTable = getDataTable(sqlQuery)
        Return DataTable.Rows.Count > 0
    End Function

    'Định nghĩa hàm kiểm tra tài khoản
    Private Function SetQuyen()
        Dim sqlQuery As String = String.Format("select GiaTri from dbo.NhanVien")
        Dim DataTable As DataTable = getDataTable(sqlQuery)
        Return DataTable.Rows.Count > 0
    End Function

    'Định nghĩa hàm kiểm tra tài khoản có rỗng hay không
    Private Function IsEmpty() As Boolean
        'Trả về hàm true nếu NguoiDung hoặc MatKhau trống
        Return String.IsNullOrEmpty(Me.txtNguoiDung.Text) OrElse String.IsNullOrEmpty(Me.txtMatKhau.Text)
    End Function

    Private Sub btnDangNhap_Click(sender As Object, e As EventArgs) Handles btnDangNhap.Click
        'Kiểm tra tài khoản đúng hay không
        If IsEmpty() Then
            MessageBox.Show("Yêu cầu Tài Khoản và Mật Khẩu không được để trống")
        Else
            If CheckLogin(Me.txtNguoiDung.Text.ToLower, Me.txtMatKhau.Text.ToLower, 1) Then
                MessageBox.Show("Đăng nhập thành công với vai trò quản trị")
                Me.Hide()
                Dim frm As New frmTrangChinh
                frm.btnNhanVien.Enabled = True
                frm.ShowDialog()
            ElseIf CheckLogin(Me.txtNguoiDung.Text.ToLower, Me.txtMatKhau.Text.ToLower, 0) Then
                MessageBox.Show("Đăng nhập thành công với vai trò nhân viên")
                Me.Hide()
                Dim frm As New frmTrangChinh
                frm.ShowDialog()
            Else
                    MessageBox.Show("Người Dùng hoặc Mật Khẩu nhập sai")
            End If
        End If
    End Sub

    Private Sub btnHuyBo_Click(sender As Object, e As EventArgs) Handles btnHuyBo.Click
        Me.Close()
    End Sub

End Class
