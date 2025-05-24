using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyCuaHangMayTinh.DTO;
using QuanLyCuaHangMayTinh.DAL;
using System.Data;

namespace QuanLyCuaHangMayTinh.BLL
{
    public class LoaiSanPhamBLL
    {
        LoaiSanPhamDAL loaiSanPhamDAL = new LoaiSanPhamDAL();

        public List<LoaiSanPham> GetAllListLoaiSp()
        {
            return loaiSanPhamDAL.GetAllListLoaiSp();
        }

        public bool InserLoaiSanPham(LoaiSanPham lsp)
        {
            return loaiSanPhamDAL.ThemLoaiSanPham(lsp);
        }

        public bool EditLoaiSanPham(LoaiSanPham lsp)
        {
            return loaiSanPhamDAL.SuaLoaiSanPham(lsp);
        }

        public bool DeleteLoaiSanPham(LoaiSanPham lsp)
        {
            return loaiSanPhamDAL.DeleteLoaiSanPham(lsp);
        }

        // Tim Kiem Loai San Pham
        public List<LoaiSanPham> TimKiemLoaiSanPham(LoaiSanPham lsp)
        {
            return loaiSanPhamDAL.TimKiemLoaiSanPham(lsp);
        }

        // Load Danh Sach Loai San Pham
        public List<LoaiSanPham> LocDanhSachLoaiSanPham(LoaiSanPham lsp)
        {
            return loaiSanPhamDAL.LoadDanhSachLoaiSanPham(lsp);
        }
    }
}
