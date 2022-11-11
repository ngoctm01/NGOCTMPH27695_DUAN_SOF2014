using _1.DAL.Context;
using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _1.DAL.Repositories
{
    public class ChiTietSPRepositories :IChiTietSPRepositories
    {
        private  FpolyDBContext _dbcontext;
        private List<ChiTietSp> _lstchitietsp;
        public ChiTietSPRepositories()
        {
            _lstchitietsp = new List<ChiTietSp>();
            _dbcontext = new FpolyDBContext();
            GetAllChiTietSP();
        }
        public bool AddChiTietSP(ChiTietSp chiTietSp)
        {
            if (chiTietSp == null) return false;
            chiTietSp.Id = Guid.NewGuid();
            _dbcontext.Add(chiTietSp);
            _dbcontext.SaveChanges();
            return true;
        }
        public bool UpdateChiTietSP(ChiTietSp chiTietSp)
        {
            if (chiTietSp == null) return false;
            var x = _dbcontext.ChiTietSp.FirstOrDefault(x => x.NamBh == chiTietSp.NamBh);
            x.IdSp = chiTietSp.IdSp;
            x.IdNsx = chiTietSp.IdNsx;
            x.IdMauSac = chiTietSp.IdMauSac;
            x.IdDongSp = chiTietSp.IdDongSp;
            x.MoTa = chiTietSp.MoTa;
            x.SoLuongTon = chiTietSp.SoLuongTon;
            x.GiaBan = chiTietSp.GiaBan;
            x.GiaNhap = chiTietSp.GiaNhap;
            _dbcontext.Update(x);
            _dbcontext.SaveChanges();
            return true;
        }
        public bool DeleteChiTietSP(ChiTietSp chiTietSp)
        {
            if (chiTietSp == null) return false;
            var x = _dbcontext.ChiTietSp.FirstOrDefault(x => x.NamBh == chiTietSp.NamBh);
            _dbcontext.Remove(x);
            _dbcontext.SaveChanges();
            return true;
        }

        public ChiTietSp GetById(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _dbcontext.ChiTietSp.FirstOrDefault(c => c.Id == id);
        }
        public List<ChiTietSp> GetAllChiTietSP()
        {
            _lstchitietsp = _dbcontext.ChiTietSp.ToList();
            return _lstchitietsp;
        }
    }
}
