namespace QLThuVien
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ThuVienModel : DbContext
    {
        public ThuVienModel()
            : base("name=ThuVienModel")
        {
        }

        public virtual DbSet<DocGia> DocGias { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<Sach> Saches { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DocGia>()
                .Property(e => e.MaDG)
                .IsFixedLength();

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.MaNV)
                .IsFixedLength();

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.Phone)
                .IsFixedLength();

            modelBuilder.Entity<Sach>()
                .Property(e => e.Masach)
                .IsFixedLength();
        }
    }
}
