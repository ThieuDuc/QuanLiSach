namespace QuanLySach
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Sach")]
    public partial class Sach
    {
        [Key]
        public int Id_Sach { get; set; }

        [Required]
        [StringLength(10)]
        public string MaSach { get; set; }

        [Required]
        [StringLength(250)]
        public string TenSach { get; set; }

        public int DonGia { get; set; }

        public int SoLuong { get; set; }

        public int? MAloaisach { get; set; }
    }
}
