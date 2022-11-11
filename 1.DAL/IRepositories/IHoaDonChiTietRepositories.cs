using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface IHoaDonChiTietRepositories
    {
        List<HoaDonChiTiet> GetAllHoaDonChiTiet();
        bool AddHoaDonChiTiet(HoaDonChiTiet hoaDonChiTiet);
        bool DeleteHoaDonChiTiet(HoaDonChiTiet hoaDonChiTiet);
        bool UpdateHoaDonChiTiet(HoaDonChiTiet hoaDonChiTiet);
     
        
    }
}
