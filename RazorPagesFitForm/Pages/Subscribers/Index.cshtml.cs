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
    public class IndexModel : PageModel
    {
        private readonly RazorPagesFitForm.Data.RazorPagesFitFormContext _context;

        public IndexModel(RazorPagesFitForm.Data.RazorPagesFitFormContext context)
        {
            _context = context;
        }

        public IList<Models.Subscribers> Subscribers { get;set; }

        public async Task OnGetAsync()
        {
            Subscribers = await _context.Subscribers.ToListAsync();
        }
    }
}
