using QuanLyThiOlympic.Models;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace QuanLyThiOlympic.DAO
{
    internal class KetQuaDAO
    {
        private readonly DBContext _context;

        public KetQuaDAO()
        {
            _context = new DBContext();
        }

        public int AddKetQua(KetQua ketQua)
        {
            _context.KetQuas.Add(ketQua);
            return _context.SaveChanges();
        }

        public int UpdateKetQua(KetQua ketQua)
        {
            _context.KetQuas.AddOrUpdate(ketQua);
            return _context.SaveChanges();
        }

        public int DeleteKetQua(int id)
        {
            var ketQua = _context.KetQuas.Find(id);
            if (ketQua != null)
            {
                _context.KetQuas.Remove(ketQua);
                return _context.SaveChanges();
            }
            return 0;
        }

        public KetQua GetKetQuaById(int id)
        {
            return _context.KetQuas.Find(id);
        }

        public List<KetQua> GetAllKetQua()
        {
            return _context.KetQuas.ToList();
        }

        public List<KetQua> SearchKetQua(string keyword)
        {
            return _context.KetQuas
                            .Where(kq => kq.TenCuocThi.Contains(keyword) || kq.TenDoiThi.Contains(keyword))
                            .ToList();
        }
    }
}
