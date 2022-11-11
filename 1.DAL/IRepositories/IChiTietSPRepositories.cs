using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface IChiTietSPRepositories
    {
        List<ChiTietSp> GetAllChiTietSP();
        bool AddChiTietSP(ChiTietSp chiTietSp);
        bool DeleteChiTietSP(ChiTietSp chiTietSp);
        ChiTietSp GetById(Guid id);
        bool UpdateChiTietSP(ChiTietSp chiTietSp);
       
    }
}
