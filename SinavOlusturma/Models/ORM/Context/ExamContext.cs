using Microsoft.EntityFrameworkCore;
using SinavOlusturma.Models.ORM.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SinavOlusturma.Models.ORM.Context
{
    public class ExamContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=ExamDB.db");
        }

        public DbSet<User> Users { get; set; }
    }
}
