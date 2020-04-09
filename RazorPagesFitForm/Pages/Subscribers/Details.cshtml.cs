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
    }
}
