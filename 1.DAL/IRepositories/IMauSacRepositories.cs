using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface IMauSacRepositories
    {
        List<MauSac> GetAllMauSac();
        bool AddMauSac(MauSac mauSac);
        bool DeleteMauSac(MauSac mauSac);
        bool UpdateMauSac(MauSac mauSac);
        MauSac GetById(Guid id);
     
    }
}
