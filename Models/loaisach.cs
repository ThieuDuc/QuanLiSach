namespace QuanLySach
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("loaisach")]
    public partial class loaisach
    {
        [Key]
        public int MAloaisach { get; set; }

        [Required]
        [StringLength(50)]
        public string tenloai { get; set; }
    }
}
