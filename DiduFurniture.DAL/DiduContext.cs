using DiduFurniture.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DiduFurniture.DAL
{
   public class DiduContext :DbContext
    {
        public DiduContext(DbContextOptions<DiduContext> options):base(options)
        { }

        public DbSet<Users> Users { get; set; }
    }
}
