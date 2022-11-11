using _1.DAL.Context;
using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories
{
    public class CuaHangRepositories :ICuaHangRepositories
    {
        private FpolyDBContext _dbcontext;
        private List<CuaHang> _lstcuahang;
        public CuaHangRepositories()
        {
            _dbcontext = new FpolyDBContext();
            _lstcuahang = new List<CuaHang>();
            GetAllCuaHang();
        }
        public List<CuaHang> GetAllCuaHang()
        {
            _lstcuahang = _dbcontext.CuaHang.ToList();
            return _lstcuahang;
        }
        public bool AddCuaHang(CuaHang ch)
        {
            if (ch == null) return false;
            ch.Id = Guid.NewGuid();
            _dbcontext.Add(ch);
            _dbcontext.SaveChanges();
            return true;
        }
        public bool UpdateCuaHang(CuaHang ch)
        {
            if (ch == null) return false;
            var x = _dbcontext.CuaHang.FirstOrDefault(c => c.Ma == ch.Ma);
            x.Ten = ch.Ten;
            x.DiaChi = ch.DiaChi;
            x.ThanhPho = ch.ThanhPho;
            x.QuocGia = ch.QuocGia;
            _dbcontext.Update(x);
            _dbcontext.SaveChanges();
            return true;
        }
        public bool DeleteCuaHang(CuaHang ch)
        {
            if (ch == null) return false;
            var x = _dbcontext.CuaHang.FirstOrDefault(c => c.Ma == ch.Ma);
           
            _dbcontext.Remove(x);
            _dbcontext.SaveChanges();
            return true;
        }

        public CuaHang GetById(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _dbcontext.CuaHang.FirstOrDefault(c => c.Id == id);  
        }
    }
}
