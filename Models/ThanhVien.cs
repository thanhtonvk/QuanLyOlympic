namespace QuanLyThiOlympic.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThanhVien")]
    public partial class ThanhVien
    {
        public int Id { get; set; }

        public int? IdDoiThi { get; set; }

        public string TenDoiThi { get; set; }

        public int? IdSinhVien { get; set; }

        public string TenSinhVien { get; set; }

        [StringLength(50)]
        public string VaiTro { get; set; }
    }
}
