﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ddfgroup.Data;

namespace ddfgroup.Areas.Admin.Pages.TransmissionTypes
{
    public class IndexModel : PageModel
    {
        private readonly ddfgroup.Data.ApplicationDbContext _context;

        public IndexModel(ddfgroup.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Transmission> Transmission { get;set; }

        public async Task OnGetAsync()
        {
            Transmission = await _context.Transmissions.ToListAsync();
        }
    }
}
