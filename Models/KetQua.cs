namespace QuanLyThiOlympic.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KetQua")]
    public partial class KetQua
    {
        public int Id { get; set; }

        public int? IdCuocThi { get; set; }

        public string TenCuocThi { get; set; }

        public int? IdDoiThi { get; set; }

        public string TenDoiThi { get; set; }

        public string XepHang { get; set; }

        public string MoTa { get; set; }
    }
}
