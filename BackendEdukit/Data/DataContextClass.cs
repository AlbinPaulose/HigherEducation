using System.Collections.Generic;
using BackendEdukit.Models;
using Microsoft.EntityFrameworkCore;
namespace BackendEdukit.Data
{
    public class DataContextClass:DbContext
    {
        public DataContextClass(DbContextOptions<DataContextClass> options) : base(options)
        {

        }
        public DbSet<Course> tblcourse { get; set; }
        public DbSet<FututeCourse> tblfuturecourse { get; set; }

        public DbSet<College> tblcollege { get; set; }

        public DbSet<CollegeNew> tblcollegenew { get; set; }
    }
}

