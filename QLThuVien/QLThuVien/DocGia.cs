namespace QLThuVien
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DocGia")]
    public partial class DocGia
    {
        [Key]
        [StringLength(20)]
        public string MaDG { get; set; }

        [StringLength(50)]
        public string Hoten { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Ngaysinh { get; set; }

        [StringLength(10)]
        public string Gioitinh { get; set; }

        [StringLength(50)]
        public string Diachi { get; set; }
    }
}
