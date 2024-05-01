using QuanLyThiOlympic.Models;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace QuanLyThiOlympic.DAO
{
    internal class DoiThiDAO
    {
        private readonly DBContext _context;

        public DoiThiDAO()
        {
            _context = new DBContext();
        }

        public int AddDoiThi(DoiThi doiThi)
        {
            _context.DoiThis.Add(doiThi);
            return _context.SaveChanges();
        }

        public int UpdateDoiThi(DoiThi doiThi)
        {
            _context.DoiThis.AddOrUpdate(doiThi);
            return _context.SaveChanges();
        }

        public int DeleteDoiThi(int id)
        {
            var doiThi = _context.DoiThis.Find(id);
            if (doiThi != null)
            {
                _context.DoiThis.Remove(doiThi);
                return _context.SaveChanges();
            }
            return 0;
        }

        public DoiThi GetDoiThiById(int id)
        {
            return _context.DoiThis.Find(id);
        }

        public List<DoiThi> GetAllDoiThi()
        {
            return _context.DoiThis.ToList();
        }

        public List<DoiThi> SearchDoiThi(string keyword)
        {
            return _context.DoiThis
                            .Where(dt => dt.TenDoiThi.Contains(keyword))
                            .ToList();
        }
    }
}
