using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
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

        public async Task OnGetAsync()
        {
            var subscribers = from s in _context.Subscribers
                select s;
            if (!string.IsNullOrEmpty(SearchString))
            {
                subscribers = subscribers.Where(s => s.Name.Contains(SearchString));
            }

            Subscribers = await subscribers.ToListAsync();
        }

        public IList<Models.Subscribers> Subscribers { get;set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        // Requires using Microsoft.AspNetCore.Mvc.Rendering;
        public SelectList Names { get; set; }
        [BindProperty(SupportsGet = true)]
        public string Name { get; set; }
    }
}
