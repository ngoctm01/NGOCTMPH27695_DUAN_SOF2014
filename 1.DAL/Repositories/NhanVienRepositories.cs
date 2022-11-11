using _1.DAL.Context;
using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _1.DAL.Repositories
{
    public class NhanVienRepositories :INhanVienRepositories
    {
        private FpolyDBContext _dbcontext;
        private List<NhanVien> _lstnhanvien;
        public NhanVienRepositories()
        {
            _dbcontext = new FpolyDBContext();
            _lstnhanvien = new List<NhanVien>();
            GetAllNhanVien();
        }
        public List<NhanVien> GetAllNhanVien()
        {
            _lstnhanvien = _dbcontext.NhanVien.ToList();
            return _lstnhanvien;
        }
        public bool AddNhanVien(NhanVien nv)
        {
            if (nv == null) return false;
            nv.Id = Guid.NewGuid();
            _dbcontext.Add(nv);
            _dbcontext.SaveChanges();
            return true;
        }
        public bool UpdateNhanVien(NhanVien nv)
        {
            if (nv == null) return false;
            var x = _dbcontext.NhanVien.FirstOrDefault(x => x.Ma == nv.Ma);
            x.Ten = nv.Ten;
            x.TenDem = nv.TenDem;
            x.Ho = nv.Ho;
            x.GioiTinh = nv.GioiTinh;
            x.NgaySinh = nv.NgaySinh;
            x.DiaChi = nv.DiaChi;
            x.Sdt = nv.Sdt;
            x.MatKhau = nv.MatKhau;
            x.IdCh = nv.IdCh;
            x.IdCv = nv.IdCv;
            x.IdGuiBc = nv.IdGuiBc;
            x.TrangThai = nv.TrangThai;
            _dbcontext.Update(x);
            _dbcontext.SaveChanges();
            return true;
        }
        public bool DeleteNhanVien(NhanVien nv)
        {
            if (nv == null) return false;
            var x = _dbcontext.NhanVien.FirstOrDefault(x => x.Ma == nv.Ma);
            _dbcontext.Remove(x);
            _dbcontext.SaveChanges();
            return true;
        }

        public NhanVien GetById(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _dbcontext.NhanVien.FirstOrDefault(x=>x.Id == id) ;
        }
    }
}
