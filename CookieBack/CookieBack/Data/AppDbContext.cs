using CookieBack.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CookieBack.Data
{
    public class AppDbContext : DbContext
    {

    }
    public DbSet<Product> Products { get; set; }
}
