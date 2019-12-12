using julekalenderApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace julekalenderApi.Data
{
    public class JuleKalenderApiContext : DbContext
    {
        public JuleKalenderApiContext(DbContextOptions<JuleKalenderApiContext> context) : base(context)
        {

        }

        public DbSet<Knowledge> Knowledges { get; set; }
    }
}
