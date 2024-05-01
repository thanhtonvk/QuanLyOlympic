using QuanLyThiOlympic.Models;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace QuanLyThiOlympic.DAO
{
    internal class ThanhVienDAO
    {
        private readonly DBContext _context;

        public ThanhVienDAO()
        {
            _context = new DBContext();
        }

        public int AddThanhVien(ThanhVien thanhVien)
        {
            _context.ThanhViens.Add(thanhVien);
            return _context.SaveChanges();
        }

        public int UpdateThanhVien(ThanhVien thanhVien)
        {
            _context.ThanhViens.AddOrUpdate(thanhVien);
            return _context.SaveChanges();
        }

        public int DeleteThanhVien(int id)
        {
            var thanhVien = _context.ThanhViens.Find(id);
            if (thanhVien != null)
            {
                _context.ThanhViens.Remove(thanhVien);
                return _context.SaveChanges();
            }
            return 0;
        }

        public ThanhVien GetThanhVienById(int id)
        {
            return _context.ThanhViens.Find(id);
        }

        public List<ThanhVien> GetAllThanhVien()
        {
            return _context.ThanhViens.ToList();
        }

        public List<ThanhVien> SearchThanhVien(string keyword)
        {
            return _context.ThanhViens
                            .Where(tv => tv.TenDoiThi.Contains(keyword) || tv.TenSinhVien.Contains(keyword))
                            .ToList();
        }
    }
}
