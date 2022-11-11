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
    public  class ChucVuRepositories :IChucVuRepositories
    {
        private FpolyDBContext _dbcontext;
        private List<ChucVu> _lstchucvu;
        public ChucVuRepositories()
        {
            _dbcontext = new FpolyDBContext();
            _lstchucvu = new List<ChucVu>();
            GetAll();
        }
      
        public bool AddChucVu(ChucVu cv)
        {
            if (cv == null) return false;
            cv.Id = Guid.NewGuid();
            _dbcontext.Add(cv);
            _dbcontext.SaveChanges();
            return true;
        }
        public bool DeleteChucVu(ChucVu cv)
        {
            if (cv == null) return false;
            var x = _dbcontext.ChucVu.FirstOrDefault(x => x.Ten == cv.Ten);
            _dbcontext.Remove(x);
            _dbcontext.SaveChanges();
            return true;
        }
        public bool UpdateChucVu(ChucVu cv)
        {
            if (cv == null) return false;
            var x = _dbcontext.ChucVu.FirstOrDefault(x => x.Ten == cv.Ten);
            _dbcontext.Update(x);
            _dbcontext.SaveChanges();
            return true;
        }
        public ChucVu GetById(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _dbcontext.ChucVu.FirstOrDefault(x => x.Id == id);
        }
        public List<ChucVu> GetAll()
        {
            _lstchucvu = _dbcontext.ChucVu.ToList();
            return _lstchucvu;
        }
    }
}
