using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RazorPagesFitForm.Data;
using System;
using System.Linq;
using RazorPagesFitForm.Models;

namespace RazorPagesFitForm
{ 
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesFitFormContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorPagesFitFormContext>>()))
            {
                if (context.Subscribers.Any())
                {
                    return; //DB has been seeded
                }

                context.Subscribers.AddRange(
                    new Subscribers()
                    {
                        Name = "Luke",
                        Email = "lukethao@outlook.com",
                        SubDate = DateTime.Parse("2020-01-01")
                    });
            }
            
        }
    }
}