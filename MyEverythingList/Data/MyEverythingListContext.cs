#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyEverythingList.Models;

namespace MyEverythingList.Data
{
    public class MyEverythingListContext : DbContext
    {
        public MyEverythingListContext (DbContextOptions<MyEverythingListContext> options)
            : base(options)
        {
        }

        public DbSet<MyEverythingList.Models.List> List { get; set; }
    }
}
