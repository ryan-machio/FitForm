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
    public class DeleteModel : PageModel
    {
        private readonly RazorPagesFitForm.Data.RazorPagesFitFormContext _context;

        public DeleteModel(RazorPagesFitForm.Data.RazorPagesFitFormContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Models.Subscribers Subscribers { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Subscribers = await _context.Subscribers.FirstOrDefaultAsync(m => m.Id == id);

            if (Subscribers == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Subscribers = await _context.Subscribers.FindAsync(id);

            if (Subscribers != null)
            {
                _context.Subscribers.Remove(Subscribers);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
