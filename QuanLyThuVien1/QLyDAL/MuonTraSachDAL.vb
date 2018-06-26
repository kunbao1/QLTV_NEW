﻿Imports System
Imports QLyDTO
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Public Class MuonTraSachDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub
    Public Function XacNhan(mt As MuonTraSachDTO)
        Dim query As String = String.Empty
        query &= "INSERT INTO [tblCHITIETPHIEUMUON]"
        query &= "(maphieumuon,madocgia,hoten,masach,tensach,matheloai,matacgia,ngaymuon,soluongmuon,ngaytra,xacnhantra,ghichu)"
        query &= "VALUES (@maphieumuon,@madocgia,@hoten,@masach,@tensach,@matheloai,@matacgia,@ngaymuon,@soluongmuon,@ngaytra,@xacnhantra,@ghichu)"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maphieumuon", mt.MaPhieuMuon)
                    .Parameters.AddWithValue("@madocgia", mt.MaDocGia)
                    .Parameters.AddWithValue("@hoten", mt.TenDocGia)
                    .Parameters.AddWithValue("@masach", mt.MaSach)
                    .Parameters.AddWithValue("@tensach", mt.TenSach)
                    .Parameters.AddWithValue("@matheloai", mt.TheLoai)
                    .Parameters.AddWithValue("@matacgia", mt.TacGia)
                    .Parameters.AddWithValue("@ngaymuon", mt.NgayMuon)
                    .Parameters.AddWithValue("@soluongmuon", mt.SoLuongMuon)
                    .Parameters.AddWithValue("@ngaytra", mt.NgayTra)
                    .Parameters.AddWithValue("@xacnhantra", mt.XacNhanTra)
                    .Parameters.AddWithValue("@ghichu", mt.GhiChu)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    Return 1 ' them that bai!!!
                End Try
            End Using
        End Using
        Return 0 ' thanh cong
    End Function
    Public Function CapNhatMuonTra(mt As MuonTraSachDTO)
        Dim query As String = String.Empty
        query &= " UPDATE [tblCHITIETPHIEUMUON] SET "
        query &= " [maphieumuon] = @maphieumuon "
        query &= " ,[madocgia] = @madocgia "
        query &= " ,[hoten] = @hoten "
        query &= " ,[masach] = @masach "
        query &= " ,[tensach] = @tensach "
        query &= " ,[matheloai] = @matheloai "
        query &= " ,[matacgia] = @matacgia "
        query &= " ,[ngaymuon] = @ngaymuon "
        query &= " ,[soluongmuon] = @soluongmuon "
        query &= " ,[ngaytra] = @ngaytra "
        query &= " ,[xacnhantra] = @xacnhantra "
        query &= " ,[ghichu] = @ghichu "
        query &= " WHERE "
        query &= " [maphieumuon] = @maphieumuon "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maphieumuon", mt.MaPhieuMuon)
                    .Parameters.AddWithValue("@madocgia", mt.MaDocGia)
                    .Parameters.AddWithValue("@hoten", mt.TenDocGia)
                    .Parameters.AddWithValue("@masach", mt.MaSach)
                    .Parameters.AddWithValue("@tensach", mt.TenSach)
                    .Parameters.AddWithValue("@matheloai", mt.TheLoai)
                    .Parameters.AddWithValue("@matacgia", mt.TacGia)
                    .Parameters.AddWithValue("@ngaymuon", mt.NgayMuon)
                    .Parameters.AddWithValue("@soluongmuon", mt.SoLuongMuon)
                    .Parameters.AddWithValue("@ngaytra", mt.NgayTra)
                    .Parameters.AddWithValue("@xacnhantra", mt.XacNhanTra)
                    .Parameters.AddWithValue("@ghichu", mt.GhiChu)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    Return 1 ' cap nhat that bai!!!
                End Try
            End Using
        End Using
        Return 0 ' thanh cong
    End Function
    Public Function XoaPhieu(mt As MuonTraSachDTO)
        Dim query As String = String.Empty
        query &= " DELETE [tblCHITIETPHIEUMUON]"
        query &= " WHERE "
        query &= " [maphieumuon] = @maphieumuon "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maphieumuon", mt.MaPhieuMuon)
                    .Parameters.AddWithValue("@madocgia", mt.MaDocGia)
                    .Parameters.AddWithValue("@tendocgia", mt.TenDocGia)
                    .Parameters.AddWithValue("@masach", mt.MaSach)
                    .Parameters.AddWithValue("@tensach", mt.TenSach)
                    .Parameters.AddWithValue("@theloai", mt.TheLoai)
                    .Parameters.AddWithValue("@tacgia", mt.TacGia)
                    .Parameters.AddWithValue("@ngaymuon", mt.NgayMuon)
                    .Parameters.AddWithValue("@soluongmuon", mt.SoLuongMuon)
                    .Parameters.AddWithValue("@ngaytra", mt.NgayTra)
                    .Parameters.AddWithValue("@xacnhantra", mt.XacNhanTra)
                    .Parameters.AddWithValue("@ghichu", mt.GhiChu)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    Return 1 ' xoa that bai!!!
                End Try
            End Using
        End Using
        Return 0 ' thanh cong
    End Function
End Class
