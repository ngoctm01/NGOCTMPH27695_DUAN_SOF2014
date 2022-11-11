using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface IChucVuRepositories
    {
      
        bool AddChucVu(ChucVu chucVu);
        bool UpdateChucVu(ChucVu chucVu);
        bool DeleteChucVu(ChucVu chucVu);
        ChucVu GetById(Guid id);
        List<ChucVu> GetAll();
    }
}
