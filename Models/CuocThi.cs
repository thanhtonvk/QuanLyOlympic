namespace QuanLyThiOlympic.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CuocThi")]
    public partial class CuocThi
    {
        public int Id { get; set; }

        public string Ten { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayBatdau { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayKetThuc { get; set; }

        public string MoTa { get; set; }

        public string DiaChi { get; set; }

        public string DonViToChuc { get; set; }

        [StringLength(20)]
        public string SDT { get; set; }
    }
}
