using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Xml.Linq;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InfraStracture
{
    public class DataContext :DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Owner>().Property(x => x.Id).HasDefaultValueSql("NEWID()");
        modelBuilder.Entity<PorfolioItem>().Property(x => x.Id).HasDefaultValueSql("NEWID()");
        modelBuilder.Entity<Owner>().HasData(new Core.Entities.Owner()
        {
            Id = Guid.NewGuid(),
            Avatar = "avatar.jpg",
            FullName = "ismail benjemra",
            Profil = "Microsoft Developper"
        });
        }

        public DbSet<Owner> Owner { get; set; }
        public DbSet<PorfolioItem> PortfolioItem { get; set; }
    }
}
