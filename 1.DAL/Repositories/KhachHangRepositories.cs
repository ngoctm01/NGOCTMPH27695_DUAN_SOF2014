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
    public class KhachHangRepositories :IKhachHangRepositories
    {
        private FpolyDBContext _dbcontext;
        private List<KhachHang> _listkhachhang;
        public KhachHangRepositories()
        {
            _dbcontext = new FpolyDBContext();
            _listkhachhang = new List<KhachHang>();
            GetAllKhachHang();
        }
        public List<KhachHang> GetAllKhachHang()
        {
            _listkhachhang = _dbcontext.KhachHang.ToList();
            return _listkhachhang;
        }
        public bool AddKhachHang(KhachHang kh)
        {
            if (kh == null) return false;
            kh.Id = Guid.NewGuid();
            _dbcontext.Add(kh);
            _dbcontext.SaveChanges();
            return true;
        }
        public bool UpdateKhachHang(KhachHang kh)
        {
            if (kh == null) return false;
             var x = _dbcontext.KhachHang.FirstOrDefault(x=>x.Ten == kh.Ten);
            x.TenDem = kh.TenDem;
            x.Ho = kh.Ho;
            x.NgaySinh = kh.NgaySinh;
            x.Sdt = kh.Sdt;
            x.DiaChi = kh.DiaChi;
            x.ThanhPho = kh.ThanhPho;
            x.QuocGia = kh.QuocGia;
            x.MatKhau = kh.MatKhau;
            _dbcontext.Update(x);
            _dbcontext.SaveChanges();
            return true;
        }
        public bool DeleteKhachHang(KhachHang kh)
        {
            if (kh == null) return false;
            var x = _dbcontext.KhachHang.FirstOrDefault(x => x.Ten == kh.Ten);
            _dbcontext.Remove(x);
            _dbcontext.SaveChanges();
            return true;
        }

        public KhachHang GetById(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _dbcontext.KhachHang.FirstOrDefault(x => x.Id == id);
        }
    }
}
