using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MovieWebApp.Data;
using MovieWebApp.Models;

namespace MovieWebApp.Pages_Movies
{
    public class DetailsModel : PageModel
    {
        private readonly MovieWebApp.Data.MovieContext _context;

        public DetailsModel(MovieWebApp.Data.MovieContext context)
        {
            _context = context;
        }

        public Movie Movie { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Movie = await _context.Movie.FirstOrDefaultAsync(m => m.Tittle == id);

            if (Movie == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
