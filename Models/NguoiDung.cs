namespace QuanLySach
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NguoiDung")]
    public partial class NguoiDung
    {
        [Key]
        public int IDNguoiDung { get; set; }

        [Required]
        [StringLength(50)]
        public string TenNguoiDung { get; set; }

        [Required]
        [StringLength(10)]
        public string MatKhau { get; set; }

        [Required]
        [StringLength(20)]
        public string Email { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgayDangKy { get; set; }

        [Required]
        [StringLength(10)]
        public string VaiTro { get; set; }
    }
}
