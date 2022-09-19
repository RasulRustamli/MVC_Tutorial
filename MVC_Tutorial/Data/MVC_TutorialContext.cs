using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVC_Tutorial.Models;

namespace MVC_Tutorial.Data
{
    public class MVC_TutorialContext : DbContext
    {
        public MVC_TutorialContext (DbContextOptions<MVC_TutorialContext> options)
            : base(options)
        {
        }

        public DbSet<MVC_Tutorial.Models.Movie> Movie { get; set; } = default!;
    }
}
