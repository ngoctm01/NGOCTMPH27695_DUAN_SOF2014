using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface IHoaDonRepositories
    {
        List<HoaDon> GetAllHoaDon();
        bool AddHoaDon(HoaDon hoaDon);
        bool UpdateHoaDon(HoaDon hoaDon);
        bool DeleteHoaDon(HoaDon hoaDon);
        HoaDon GetById(Guid id);
     
    }
}
