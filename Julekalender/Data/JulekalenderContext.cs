using Julekalender.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Julekalender.Data
{
    public class JulekalenderContext : DbContext
    {
        public JulekalenderContext(DbContextOptions<JulekalenderContext> options) : base(options)
        {

        }

        public DbSet<Tipp> Tipps { get; set; }
    }
}
