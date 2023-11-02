using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HendrixUniversity.Data;
using HendrixUniversity.Models;

namespace HendrixUniversity.Pages.Courses
{
    public class IndexModel : PageModel
    {
        private readonly HendrixUniversity.Data.SchoolContext _context;

        public IndexModel(HendrixUniversity.Data.SchoolContext context)
        {
            _context = context;
        }

        public IList<Course> Courses { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Courses = await _context.Courses
                .Include(c => c.Department)
                .AsNoTracking()
                .ToListAsync();
        }
    }
}
