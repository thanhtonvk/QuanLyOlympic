using QuanLyThiOlympic.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace QuanLyThiOlympic.DAO
{
    internal class CuocThiDAO
    {
        private readonly DBContext _context;

        public CuocThiDAO()
        {
            _context = new DBContext();
        }

        public int AddCuocThi(CuocThi cuocThi)
        {
            _context.CuocThis.Add(cuocThi);
            return _context.SaveChanges();
        }

        public int UpdateCuocThi(CuocThi cuocThi)
        {
            _context.CuocThis.AddOrUpdate(cuocThi);
            return _context.SaveChanges();
        }

        public int DeleteCuocThi(int id)
        {
            var cuocThi = _context.CuocThis.Find(id);
            if (cuocThi != null)
            {
                _context.CuocThis.Remove(cuocThi);
                return _context.SaveChanges();
            }
            return 0;
        }

        public CuocThi GetCuocThiById(int id)
        {
            return _context.CuocThis.Find(id);
        }

        public List<CuocThi> GetAllCuocThi()
        {
            return _context.CuocThis.ToList();
        }

        public List<CuocThi> SearchCuocThi(string keyword)
        {
            return _context.CuocThis
                            .Where(ct => ct.Ten.Contains(keyword) || ct.MoTa.Contains(keyword))
                            .ToList();
        }
    }
}
