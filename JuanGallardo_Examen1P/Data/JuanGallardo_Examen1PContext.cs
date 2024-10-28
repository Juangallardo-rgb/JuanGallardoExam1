using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using JuanGallardo_Examen1P.Models;

    public class JuanGallardo_Examen1PContext : DbContext
    {
        public JuanGallardo_Examen1PContext (DbContextOptions<JuanGallardo_Examen1PContext> options)
            : base(options)
        {
        }

        public DbSet<JuanGallardo_Examen1P.Models.JGmodel1> JGmodel1 { get; set; } = default!;
    }
