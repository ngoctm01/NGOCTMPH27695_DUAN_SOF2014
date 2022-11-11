using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface IKhachHangRepositories
    {
        List<KhachHang> GetAllKhachHang();
        bool AddKhachHang(KhachHang khachHang);
        bool DeleteKhachHang(KhachHang khachHang);
        bool UpdateKhachHang(KhachHang khachHang);

        KhachHang GetById(Guid id);
     
    }
}
