using QuanLyThiOlympic.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThiOlympic.DAO
{
    internal class NguoiDungDAO
    {
        private readonly DBContext _context;

        public NguoiDungDAO()
        {
            _context = new DBContext();
        }

        public int CreateNguoiDung(NguoiDung nguoiDung)
        {
            _context.NguoiDungs.Add(nguoiDung);
            int result = _context.SaveChanges();
            return result;
        }
        public int UpdateNguoiDung(NguoiDung nguoiDung)
        {
            _context.NguoiDungs.AddOrUpdate(nguoiDung);
            return _context.SaveChanges();
        }
        public int DeleteNguoiDung(int id)
        {
            var nguoiDung = _context.NguoiDungs.Find(id);
            if (nguoiDung != null)
            {
                _context.NguoiDungs.Remove(nguoiDung);
                return _context.SaveChanges();
            }
            return 0;
        }
        public NguoiDung GetNguoiDungById(int id)
        {
            return _context.NguoiDungs.Find(id);
        }
        public List<NguoiDung> GetAllNguoiDung()
        {
            return _context.NguoiDungs.ToList();
        }
        public List<NguoiDung> SearchNguoiDung(string keyword)
        {
            // Tìm kiếm các tài khoản có tên tài khoản hoặc họ tên chứa keyword
            return _context.NguoiDungs
                            .Where(t => t.TenTaiKhoan.Contains(keyword) || t.HoTen.Contains(keyword))
                            .ToList();
        }




    }
}
