namespace QuanLyThiOlympic.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NguoiDung")]
    public partial class NguoiDung
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string TenTaiKhoan { get; set; }

        [StringLength(255)]
        public string MatKhau { get; set; }

        public string HoTen { get; set; }

        public string DiaChi { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgaySinh { get; set; }

        public string SoCCCD { get; set; }

        [StringLength(20)]
        public string SDT { get; set; }

        public string Role { get; set; }
    }
}
