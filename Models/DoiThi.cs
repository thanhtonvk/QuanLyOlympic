namespace QuanLyThiOlympic.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DoiThi")]
    public partial class DoiThi
    {
        public int Id { get; set; }

        public int IdCuocThi { get; set; }

        public string TenCuocThi { get; set; }

        [StringLength(255)]
        public string TenDoiThi { get; set; }

        public int IdNguoiHuongDan { get; set; }

        public string HoTenNguoiHuongDan { get; set; }
    }
}
