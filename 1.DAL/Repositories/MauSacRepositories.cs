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
    public class MauSacRepositories :IMauSacRepositories
    {
        private FpolyDBContext _dbcontext;
        private List<MauSac> _lstmausac;
        public MauSacRepositories()
        {
            _dbcontext = new FpolyDBContext();
            _lstmausac = new List<MauSac>();
            GetAllMauSac();
        }
        public List<MauSac> GetAllMauSac()
        {
            _lstmausac = _dbcontext.MauSac.ToList();
            return _lstmausac;
        }
        public bool AddMauSac(MauSac ms)
        {
            if (ms == null) return false;
             ms.Id = Guid.NewGuid();
            _dbcontext.Add(ms);
            _dbcontext.SaveChanges();
            return true;
        }
        public bool DeleteMauSac(MauSac ms)
        {
            if (ms == null) return false;
            var x  = _dbcontext.MauSac.FirstOrDefault(x=>x.Ma == ms.Ma);
            _dbcontext.Remove(x);
            _dbcontext.SaveChanges();
            return true;
        }
        public bool UpdateMauSac(MauSac ms)
        {
            if (ms == null) return false;
            var x = _dbcontext.MauSac.FirstOrDefault(x => x.Ma == ms.Ma);
            x.Ten = ms.Ten;
            _dbcontext.Update(x);
            _dbcontext.SaveChanges();
            return true;
        }
        public MauSac GetById(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _dbcontext.MauSac.FirstOrDefault(X => X.Id == id);
        }
    }
}
