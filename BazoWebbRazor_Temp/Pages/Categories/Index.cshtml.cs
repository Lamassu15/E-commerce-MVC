﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BazoWebbApp.Data;
using BazoWebbRazor_Temp.Models;

namespace BazoWebbRazor_Temp.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly BazoWebbApp.Data.ApplicationDbContext _context;

        public IndexModel(BazoWebbApp.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Category> Category { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Category = await _context.Categories.ToListAsync();
        }
    }
}
