﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Filip_Ioana_Lab2.Data;
using Filip_Ioana_Lab2.Models;

namespace Filip_Ioana_Lab2.Pages.Members
{
    public class CreateModel : PageModel
    {
        private readonly Filip_Ioana_Lab2.Data.Filip_Ioana_Lab2Context _context;

        public CreateModel(Filip_Ioana_Lab2.Data.Filip_Ioana_Lab2Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Member Member { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Member.Add(Member);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}