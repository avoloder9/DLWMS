﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.Data
{
    public class DLWMSDbContext : DbContext
    {
        //C:\Users\Adnan\Desktop\pr3 sqlBaze\DLWMS.db
        private string dbPutanja;
        public DLWMSDbContext() 

        {
            dbPutanja=ConfigurationManager.ConnectionStrings["DLWMSPutanja"].ConnectionString;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(dbPutanja);
        }
        public DbSet<Predmet> Predmeti { get; set; }
        public DbSet<Student> Studenti { get; set; }

    }
}