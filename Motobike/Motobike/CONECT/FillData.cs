using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
namespace Motobike.CONECT
{
    internal class FillData
    {
        SqlConnection conn = null;

        public void Connect()
        {
            KetNoiXE ketNoi = new KetNoiXE();
            conn = ketNoi.CON();
        }
        public SqlCommand FillManv(SqlCommand cmd)
        {
            Connect();
            cmd = new SqlCommand();
            cmd.CommandType=System.Data.CommandType.Text;
            cmd.CommandText = @"select MaNV from NhanVien";
            cmd.Connection = conn;
            return cmd;
        }
        public SqlCommand FillMaKH(SqlCommand cmd)
        {
            Connect();
            cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = @"select MaKH from KhachHang";
            cmd.Connection = conn;
            return cmd;
        }
        public SqlCommand FillMaNCC(SqlCommand cmd)
        {
            Connect();
            cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = @"select MaNCC from NhaCungCap";
            cmd.Connection = conn;
            return cmd;
        }
        public SqlCommand FillTenNCC(SqlCommand cmd)
        {
            Connect();
            cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = @"select TenNCC from NhaCungCap";
            cmd.Connection = conn;
            return cmd;
        }
        public SqlCommand FillMaHang(SqlCommand cmd)
        {
            Connect();
            cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = @"select MaHang from DMHang";
            cmd.Connection = conn;
            return cmd;
        }
        public SqlCommand FillMaHD(SqlCommand cmd)
        {
            Connect();
            cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = @"select SoHDN from HoaDonNhap_New";
            cmd.Connection = conn;
            return cmd;
        }
        public SqlCommand FillTenKhach(SqlCommand cmd)
        {
            Connect();
            cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = @"select TenKH from KhachHang";
            cmd.Connection = conn;
            return cmd;
        }
        public SqlCommand FillMaHD2(SqlCommand cmd)
        {
            Connect();
            cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = @"select SoDDH from DonDatHang";
            cmd.Connection = conn;
            return cmd;
        }
        public SqlCommand FillTenhang(SqlCommand cmd)
        {
            Connect();
            cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = @"select TenHang from DMHang";
            cmd.Connection = conn;
            return cmd;
        }
        public SqlCommand FillMamau(SqlCommand cmd)
        {
            Connect();
            cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = @"select MaMau from MauSac";
            cmd.Connection = conn;
            return cmd;
        }
        public SqlCommand FillMaPhanh(SqlCommand cmd)
        {
            Connect();
            cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = @"select MaPhanh from PhanhXe";
            cmd.Connection = conn;
            return cmd;
        }
        public SqlCommand FillMaLoai(SqlCommand cmd)
        {
            Connect();
            cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = @"select MaLoai from TheLoai";
            cmd.Connection = conn;
            return cmd;
        }
        public SqlCommand FillMaDongCo(SqlCommand cmd)
        {
            Connect();
            cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = @"select MaDongCo from DongCo";
            cmd.Connection = conn;
            return cmd;
        }
        public SqlCommand FillMaHangXe(SqlCommand cmd)
        {
            Connect();
            cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = @"select MaHangSX from HangSX";
            cmd.Connection = conn;
            return cmd;
        }
        public SqlCommand FillMaNuocSx(SqlCommand cmd)
        {
            Connect();
            cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = @"select MaNuocSX from NuocSX";
            cmd.Connection = conn;
            return cmd;
        }
        public SqlCommand FillMaTinhTrang(SqlCommand cmd)
        {
            Connect();
            cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = @"select MaTinhTrang from TinhTrang";
            cmd.Connection = conn;
            return cmd;
        }



        public SqlCommand Macuoi(SqlCommand cmd)
        {
            Connect();
            cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = @"SELECT TOP 1 SoHDN
                                FROM HoaDonNhap_New
                                ORDER BY SoHDN DESC;";

            cmd.Connection = conn;
            return cmd;
        }
        public SqlCommand Macuoi2(SqlCommand cmd)
        {
            Connect();
            cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = @"SELECT TOP 1 SoDDH
                                FROM CTDonDatHang
                                ORDER BY SoDDH DESC;";

            cmd.Connection = conn;
            return cmd;
        }



    }

}
