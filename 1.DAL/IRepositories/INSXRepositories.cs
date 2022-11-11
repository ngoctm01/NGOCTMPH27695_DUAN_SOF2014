using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface INSXRepositories
    {
        List<Nsx> GetAllNsx();
        bool AddNsx(Nsx nsx);
        bool UpdateNsx(Nsx nsx);
        bool DeleteNsx(Nsx nsx);
        Nsx GetById(Guid id);
   
    }
}
