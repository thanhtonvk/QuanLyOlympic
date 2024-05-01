using QuanLyThiOlympic.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThiOlympic.DAO
{
    internal class PhanQuyenDAO
    {
        private readonly DBContext _context;

        public PhanQuyenDAO()
        {
            _context = new DBContext();
        }
        public int AddPhanQuyen(PhanQuyen phanQuyen)
        {
            _context.PhanQuyens.Add(phanQuyen);
            return _context.SaveChanges();
        }

        public int UpdatePhanQuyen(PhanQuyen phanQuyen)
        {
            _context.PhanQuyens.AddOrUpdate(phanQuyen);
            return _context.SaveChanges();
        }
        public int DeletePhanQuyen(int id)
        {
            var phanQuyen = _context.PhanQuyens.Find(id);
            if (phanQuyen != null)
            {
                _context.PhanQuyens.Remove(phanQuyen);
                return _context.SaveChanges();
            }
            return 0;
        }
        public PhanQuyen GetPhanQuyenById(int id)
        {
            return _context.PhanQuyens.Find(id);
        }
        public List<PhanQuyen> GetAllPhanQuyen()
        {
            return _context.PhanQuyens.ToList();
        }
        public List<PhanQuyen> SearchPhanQuyen(string keyword)
        {
            return _context.PhanQuyens
                            .Where(pq => pq.ChucVu.Contains(keyword) || pq.MoTa.Contains(keyword))
                            .ToList();
        }

    }
}
