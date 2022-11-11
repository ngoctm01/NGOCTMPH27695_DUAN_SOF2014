using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using _1.DAL.Repositories;
using _2.BUS.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services
{
    public class QLCuaHangServices : IQLCuaHangServices
    {
        ICuaHangRepositories _ICuaHangRepositories;
        List<CuaHang> _lstcuahang;
        public QLCuaHangServices()
        {
            _ICuaHangRepositories = new CuaHangRepositories();
            _lstcuahang = new List<CuaHang>();
        }

        public List<CuaHang> GetAll()
        {
             _lstcuahang = _ICuaHangRepositories.GetAllCuaHang().ToList();
            return _lstcuahang;
        }
    }
}
