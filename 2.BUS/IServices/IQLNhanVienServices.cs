using _1.DAL.DomainClass;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public  interface IQLNhanVienServices
    {
        string Add(NhanVienViews obj);
        string Update(NhanVien obj);
        string Delete(NhanVien obj);
        List<NhanVienViews> GetAll();
    }
}
