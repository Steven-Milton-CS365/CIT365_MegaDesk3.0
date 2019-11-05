using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MegaDesk3._0.Data;
using MegaDesk_Asp.Net.Model;

namespace MegaDesk3._0.Pages.DeskQuotes
{
    public class IndexModel : PageModel
    {
        private readonly MegaDesk3._0.Data.MegaDesk3_0Context _context;

        public IndexModel(MegaDesk3._0.Data.MegaDesk3_0Context context)
        {
            _context = context;
        }

        public IList<DeskQuote> DeskQuote { get;set; }

        public async Task OnGetAsync()
        {
            DeskQuote = await _context.DeskQuote.ToListAsync();
        }
    }
}
