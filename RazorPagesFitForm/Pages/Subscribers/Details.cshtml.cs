using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesFitForm.Data;
using RazorPagesFitForm.Models;

namespace RazorPagesFitForm.Pages.Subscribers
{
    public class DetailsModel : PageModel
    {
        private readonly RazorPagesFitForm.Data.RazorPagesFitFormContext _context;

        public DetailsModel(RazorPagesFitForm.Data.RazorPagesFitFormContext context)
        {
            _context = context;
        }

        public Models.Subscribers Subscribers { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Subscribers).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SubscribersExists(Subscribers.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool SubscribersExists(object iD)
        {
            throw new NotImplementedException();
        }
    }
}
