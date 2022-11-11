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
    public class HoaDonRepostiories :IHoaDonRepositories
    {
        private FpolyDBContext _dbcontext;
        private List<HoaDon> _lsthoadon;
        public HoaDonRepostiories()
        {
            _dbcontext = new FpolyDBContext();
            _lsthoadon = new List<HoaDon>();
            GetAllHoaDon();
        }
        public List<HoaDon> GetAllHoaDon()
        {
            _lsthoadon = _dbcontext.HoaDon.ToList();
            return _lsthoadon;
        }
        public bool AddHoaDon(HoaDon hd)
        {
            if (hd == null) return false;
            hd.Id = Guid.NewGuid();
            _dbcontext.Add(hd);
            _dbcontext.SaveChanges();
            return true;
        }
        public bool UpdateHoaDon(HoaDon hd)
        {
            if (hd == null) return false;
            var x = _dbcontext.HoaDon.FirstOrDefault(x => x.NgayTao == hd.NgayTao);
            x.NgayThanhToan = hd.NgayTao;
            x.NgayShip = hd.NgayShip;
            x.NgayNhan = hd.NgayNhan;
            x.TinhTrang = hd.TinhTrang;
            x.TenNguoiNhan = hd.TenNguoiNhan;
            x.DiaChi = hd.DiaChi;
            x.Sdt = hd.Sdt;
            _dbcontext.Update(x);
            _dbcontext.SaveChanges();
            return true;
        }
        public bool DeleteHoaDon(HoaDon hd)
        {
            if (hd == null) return false;
            var x = _dbcontext.HoaDon.FirstOrDefault(x => x.NgayTao == hd.NgayTao);
            _dbcontext.Remove(x);
            _dbcontext.SaveChanges();
            return true;
        }
        public HoaDon GetById(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _dbcontext.HoaDon.FirstOrDefault(x => x.Id == id);
        }
    }
}
