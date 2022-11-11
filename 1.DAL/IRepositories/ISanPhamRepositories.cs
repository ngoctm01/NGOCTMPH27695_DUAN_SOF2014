using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface ISanPhamRepositories
    {
        List<SanPham> GetAllSanPham();
        bool AddSanPham(SanPham sanPham);
        bool UpdateSanPham(SanPham sanPham);
        bool DeleteSanPham(SanPham sanPham);
        SanPham GetById(Guid id);
       
    }
}
