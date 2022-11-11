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
    public class HoaDonChiTietRepositories : IHoaDonChiTietRepositories
    {
        private FpolyDBContext _dbcontext;
        private List<HoaDonChiTiet> _listhoadonchitiet;
        public HoaDonChiTietRepositories()
        {
            _dbcontext = new FpolyDBContext();
            _listhoadonchitiet = new List<HoaDonChiTiet>();
            GetAllHoaDonChiTiet();
        }
        public List<HoaDonChiTiet> GetAllHoaDonChiTiet()
        {
            _listhoadonchitiet = _dbcontext.HoaDonChiTiet.ToList();
            return _listhoadonchitiet;
        }
        public bool AddHoaDonChiTiet(HoaDonChiTiet hdct)
        {
            if (hdct == null) return false;
            _dbcontext.Add(hdct);
            _dbcontext.SaveChanges();
            return true;
        }

        public bool DeleteHoaDonChiTiet(HoaDonChiTiet hdct)
        {
            if (hdct == null) return false;
            var x = _dbcontext.HoaDonChiTiet.FirstOrDefault(X => X.SoLuong == hdct.SoLuong);
            _dbcontext.Remove(x);
            _dbcontext.SaveChanges();
            return true;
        }

        public bool UpdateHoaDonChiTiet(HoaDonChiTiet hdct)
        {
            if (hdct == null) return false;
            var x = _dbcontext.HoaDonChiTiet.FirstOrDefault(X => X.SoLuong == hdct.SoLuong);
            x.DonGia = hdct.DonGia;
            _dbcontext.Update(x);
            _dbcontext.SaveChanges();
            return true;
        }

    }
}
