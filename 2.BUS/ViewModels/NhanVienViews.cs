using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.ViewModels
{
    public class NhanVienViews
    {
        public string Manv { get; set; }
        public string Tennv { get; set; }
        public string GioiTinh { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string Sdt { get; set; }
        public string Dchi { get; set; }
        public string Tencv { get; set; }
        public string TemCH { get; set; }
        public NhanVien NhanVien;
     
    }
}
