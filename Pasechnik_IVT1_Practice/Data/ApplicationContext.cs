using Microsoft.EntityFrameworkCore;
using Pasechnik_IVT1_Practice.Data.Entities;

namespace Pasechnik_IVT1_Practice.Data
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Country> Countries { get; set; }
        public DbSet<CountryMat> Country_Mats { get; set; }
        public DbSet<CountryRing> Country_Rings { get; set; }
        public DbSet<CountrySportsEquipment> Country_Sports_Equipments { get; set; }
        public DbSet<Mat> Mats { get; set; }
        public DbSet<Entities.Region> Regions { get; set; }
        public DbSet<Ring> Rings { get; set; }
        public DbSet<SportsEquipment> Sports_Equipments { get; set; }
        public DbSet<SportType> Sports_Types { get; set; }

        public string DbPath { get; }

        public ApplicationContext()
        {
            //var folder = Environment.SpecialFolder.LocalApplicationData;
            //var path = Environment.GetFolderPath(folder);
            //DbPath = System.IO.Path.Join(path, "pasechnik_practice.sql");
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseMySql("server=localhost;user=root;database=pasechnik_ivt1_practice;", new MySqlServerVersion(new Version(10, 4, 28)));
    }

}
