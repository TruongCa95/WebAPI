using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using WebAPI.Data.Model;

namespace WebAPI.Model.DataContext
{
   public class APIDataContext: DbContext
    {
        public APIDataContext(DbContextOptions options): base(options)
        {
        }
        public DbSet<User> Users { get; set; }
    }
}
