namespace QuanLyThiOlympic.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhanQuyen")]
    public partial class PhanQuyen
    {
        public int Id { get; set; }

        public string ChucVu { get; set; }

        public string MoTa { get; set; }
    }
}
