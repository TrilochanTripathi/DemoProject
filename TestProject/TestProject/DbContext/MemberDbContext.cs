using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestProject.Models;
using EFCore= Microsoft.EntityFrameworkCore;

namespace TestProject.DbContext
{
    public class MemberDbContext : EFCore.DbContext
    {
        public MemberDbContext()
        {

        }

        protected override void OnConfiguring(EFCore.DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=LAPTOP-AG68MF4U;Database=MemberDB;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(EFCore.ModelBuilder modelBuilder)
        {
        }
        //entities
        public EFCore.DbSet<Member> Members { get; set; }
        public EFCore.DbSet<Account> UserAccounts { get; set; }
    }
 
}
