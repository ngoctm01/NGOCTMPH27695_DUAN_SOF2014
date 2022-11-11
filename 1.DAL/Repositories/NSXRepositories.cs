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
    public class NSXRepositories :INSXRepositories
    {
        private FpolyDBContext _dbcontex;
        private List<Nsx> _lstNsx;
        public NSXRepositories()
        {
            _dbcontex = new FpolyDBContext();
            _lstNsx = new List<Nsx>();
            GetAllNsx();
        }
        public bool AddNsx(Nsx nsx)
        {
            if (nsx == null) return false;
            nsx.Id = Guid.NewGuid();
            _dbcontex.Add(nsx); 
            _dbcontex.SaveChanges();
            return true;
        }
        public List<Nsx> GetAllNsx()
        {
            _lstNsx = _dbcontex.Nsx.ToList();
            return _lstNsx;
        }
        public bool DeleteNsx(Nsx nsx)
        {
            if (nsx == null) return false;
            var x = _dbcontex.Nsx.FirstOrDefault(x => x.Ma == nsx.Ma);
            _dbcontex.Remove(x);
            _dbcontex.SaveChanges();
            return true;
        }
        public bool UpdateNsx(Nsx nsx)
        {
            if (nsx == null) return false;
            var x = _dbcontex.Nsx.FirstOrDefault(x => x.Ma == nsx.Ma);
            x.Ten = nsx.Ten;
            _dbcontex.Update(x);
            _dbcontex.SaveChanges();
            return true;
        }

        public Nsx GetById(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _dbcontex.Nsx.FirstOrDefault(x => x.Id == id);
        }
    }
}
