namespace QLThuVien
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
        [StringLength(20)]
        public string Masach { get; set; }

        [StringLength(50)]
        public string Tensach { get; set; }

        [StringLength(50)]
        public string Tacgia { get; set; }

        [StringLength(50)]
        public string Nhaxb { get; set; }

        public int? Namxb { get; set; }
    }
}
