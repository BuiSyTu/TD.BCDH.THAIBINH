using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TD.BCDH.THAIBINH.DATA.Models;

namespace TD.BCDH.THAIBINH.DATA.Data
{
    public class BCDHTBContext: DbContext
    {
        public BCDHTBContext(): base("BCDHTBContext")
        {

        }

        public DbSet<NhiemVu> NhiemVus { get; set; }
        public DbSet<NhiemVuKetQua> NhiemVuKetQuas { get; set; }
        public DbSet<VanBanDen> VanBanDens { get; set; }
        public DbSet<VanBanDi> VanBanDis { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NhiemVu>().ToTable("dbo.NhiemVu");
            modelBuilder.Entity<NhiemVuKetQua>().ToTable("dbo.NhiemVuKetQua");
            modelBuilder.Entity<VanBanDen>().ToTable("dbo.VanBanDen");
            modelBuilder.Entity<VanBanDi>().ToTable("dbo.VanBanDi");

            base.OnModelCreating(modelBuilder);
        }
    }
}
