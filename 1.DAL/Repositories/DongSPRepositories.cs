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
    public class DongSPRepositories :IDongSPRepositories
    {
        private FpolyDBContext _dbcontext;
        private List<DongSp> _listdongsp;
       public DongSPRepositories()
        {
            _dbcontext = new FpolyDBContext();
            _listdongsp = new List<DongSp>();
            GetAllDongSP();
        }
        public List<DongSp> GetAllDongSP()
        {
           _listdongsp = _dbcontext.DongSp.ToList();
            return _listdongsp;
        } 
        public bool AddDongSP(DongSp dongSp)
        {
            if (dongSp == null) return false;
            dongSp.Id = Guid.NewGuid();
            _dbcontext.Add(dongSp);
            _dbcontext.SaveChanges();
            return true;
        }
        public bool UpdateDongSP(DongSp dongsp)
        {
            if (dongsp == null) return false;
            var x = _dbcontext.DongSp.FirstOrDefault(x => x.Ma == dongsp.Ma);
            x.Ten = dongsp.Ten;
            _dbcontext.Update(x);
            _dbcontext.SaveChanges();
            return true;
        }
        public bool DeleteDongSP(DongSp dongsp)
        {
            if (dongsp == null) return false;
            var x = _dbcontext.DongSp.FirstOrDefault(x=>x.Ma == dongsp.Ma); 
            _dbcontext.Remove(x);
            _dbcontext.SaveChanges();
            return true;
        }
        public DongSp GetById(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _dbcontext.DongSp.FirstOrDefault(x => x.Id == id);
        }
    }
}
