using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface ICuaHangRepositories
    {
        List<CuaHang> GetAllCuaHang();
        bool AddCuaHang(CuaHang cuaHang);
        bool DeleteCuaHang(CuaHang cuaHang);
        bool UpdateCuaHang(CuaHang cuaHang);
        CuaHang GetById(Guid id);
      
    }
}
