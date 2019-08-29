using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WatchList.Models
{
    public class Repository : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder opts)
        {
            opts.UseSqlServer("Server=localdb\\MSSQLLocalDB;Database=MoviesDB;Trusted_Connection=true;");
        }
    }
}
