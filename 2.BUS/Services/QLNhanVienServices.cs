using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using _1.DAL.Repositories;
using _2.BUS.IServices;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services
{
    public class QLNhanVienServices : IQLNhanVienServices
    {
        INhanVienRepositories _INhanVienRepositories;
        ICuaHangRepositories _ICuaHangRepositories;
        IChucVuRepositories _IChucVuRepositories;
        public QLNhanVienServices()
        {
            _INhanVienRepositories = new NhanVienRepositories();
            _ICuaHangRepositories = new CuaHangRepositories();
            _IChucVuRepositories = new ChucVuRepositories();
        }
        public string Add(NhanVienViews obj)
        {
            if (obj == null) return "them that bai";
            var nhanvien = obj.NhanVien;
            if (_INhanVienRepositories.AddNhanVien(nhanvien)) return "them thanh cong";
            return "them that bai";
        }
        public string Delete(NhanVien obj)
        {
            throw new NotImplementedException();
        }
        public List<NhanVienViews> GetAll()
        { 
           List<NhanVienViews> _lstnhanvienviews = new List<NhanVienViews>();
            _lstnhanvienviews = (from a in _INhanVienRepositories.GetAllNhanVien()
                                 join b in _ICuaHangRepositories.GetAllCuaHang() on a.IdCh equals b.Id
                                 join c in _IChucVuRepositories.GetAll() on a.IdCv equals c.Id
                                 select new NhanVienViews()
                                 {
                                     Tennv = a.Ho+" "+a.TenDem+" "+a.Ten,
                                     Manv = a.Ma,
                                     GioiTinh = a.GioiTinh,
                                     NgaySinh = (DateTime)a.NgaySinh,
                                     Sdt = a.Sdt,
                                     Dchi = a.DiaChi,
                                     Tencv = c.Ten,
                                     TemCH = b.Ten,
                                 }).ToList();
            return _lstnhanvienviews;
        }

        public string Update(NhanVien obj)
        {
            throw new NotImplementedException();
        }
    }
}
