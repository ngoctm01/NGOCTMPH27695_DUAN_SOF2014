using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface IDongSPRepositories
    {
        List<DongSp> GetAllDongSP();
        bool AddDongSP(DongSp dongSp);
        bool DeleteDongSP(DongSp dongSp);
        bool UpdateDongSP(DongSp dongSp);
        DongSp GetById(Guid id);
     
    }
}
