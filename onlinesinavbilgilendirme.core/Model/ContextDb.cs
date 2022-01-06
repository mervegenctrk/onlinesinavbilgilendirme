using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onlinesinavbilgilendirme.core.Model
{
    public class ContextDb : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=duyurular;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        public DbSet<OsymDuyuru> OsymDuyurular { get; set; }
        public DbSet<DuzceDuyuru> DuzceDuyurular { get; set; }
        public DbSet<AnadoluDuyuru> AnadoluDuyurular { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
