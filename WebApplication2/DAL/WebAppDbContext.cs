using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplication2.Models;

namespace WebApplication2.DAL
{
    public class WebAppDbContext : DbContext
    {
        public WebAppDbContext()
        {

        }

        public DbSet<products> Products { get; set; }

    }
}