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
    public class QLChucVuServices : IQLChucVuServices
    {
        IChucVuRepositories _IChucVuRepositories;
        List<ChucVu> _lstchucvu;
        public QLChucVuServices()
        {
            _lstchucvu = new List<ChucVu>();
            _IChucVuRepositories = new ChucVuRepositories();
        }
        public List<ChucVu> GetAll()
        {
            _lstchucvu = _IChucVuRepositories.GetAll().ToList();
            return _lstchucvu;
        }
    }
}
