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
    public class SanPhamRepositories : ISanPhamRepositories
    {
        private FpolyDBContext _dbcontext;
        private List<SanPham> _lstsanpham;
        public SanPhamRepositories()
        {
            _dbcontext = new FpolyDBContext();  
            _lstsanpham = new List<SanPham>();
            GetAllSanPham();
        }
        public List<SanPham> GetAllSanPham()
        {
            _lstsanpham = _dbcontext.SanPham.ToList();
            return _lstsanpham;
        }
        public bool AddSanPham(SanPham sp)
        {
            if (sp == null) return false;
            sp.Id = Guid.NewGuid();
            _dbcontext.Add(sp);
            _dbcontext.SaveChanges();
            return true;
        }
        public bool UpdateSanPham(SanPham sp)
        {
            if (sp == null) return false;
            var x = _dbcontext.SanPham.FirstOrDefault(x => x.Ma == sp.Ma);
            x.Ten = sp.Ten;
            _dbcontext.Update(x);
            _dbcontext.SaveChanges();
            return true;
        }
        public bool DeleteSanPham(SanPham sp)
        {
            if (sp == null) return false;
            var x = _dbcontext.SanPham.FirstOrDefault(x => x.Ma == sp.Ma);
            _dbcontext.Remove(x);
            _dbcontext.SaveChanges();
            return true;
        }
        public SanPham GetById(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _dbcontext.SanPham.FirstOrDefault(x => x.Id == id);
        }
    }
}
