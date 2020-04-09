using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesFitForm.Models;

namespace RazorPagesFitForm.Data
{
    public class RazorPagesFitFormContext : DbContext
    {
        public RazorPagesFitFormContext (DbContextOptions<RazorPagesFitFormContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesFitForm.Models.Subscribers> Subscribers { get; set; }
    }
}
