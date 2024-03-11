using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFUniversty.Models;
public class AkademiDbContext:DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=DESKTOP-0ESM5CG;Database=AkademiUniversityDb; Trusted_Connection=true;trustServerCertificate=True");
    }

    public DbSet<City> Cities { get; set; }
    public DbSet<Universty> Universties { get; set; }
    public DbSet<Student> students { get; set; }

}
