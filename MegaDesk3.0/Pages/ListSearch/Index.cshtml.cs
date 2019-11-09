using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MegaDesk3._0.Data;
using MegaDesk_Asp.Net.Model;

namespace MegaDesk3._0.Pages.ListSearch
{
    public class IndexModel : PageModel
    {
        private readonly MegaDesk3._0.Data.MegaDesk3_0Context _context;

        public IndexModel(MegaDesk3._0.Data.MegaDesk3_0Context context)
        {
            _context = context;
        }

        public string NameSort { get; set; }
        public string DateSort { get; set; }
        public string CurrentFilter { get; set; }
        public string CurrentSort { get; set; }

        public PaginatedList<DeskQuote> DeskQuote { get;set; }

        public async Task OnGetAsync(string sortOrder,
            string currentFilter, string searchString, int? pageIndex)
        {
            CurrentSort = sortOrder;
            NameSort = String.IsNullOrEmpty(sortOrder) ? "name_desc" :
            NameSort = sortOrder == "Name" ? "name_desc" : "Name";

            if (searchString != null)
            {
                pageIndex = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            CurrentFilter = searchString;

            IQueryable<DeskQuote> deskQuoteQ = from s in _context.DeskQuote
                                               select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                deskQuoteQ = deskQuoteQ.Where(s => s.CustomerName.Contains(searchString));
            }

            switch (sortOrder)
            {
                case "name_desc":
                    deskQuoteQ = deskQuoteQ.OrderByDescending(s => s.CustomerName);
                    break;
                /*case "Date":
                    deskQuoteQ = deskQuoteQ.OrderBy(s => s.QuoteDate);
                    break;*/
                /*case "date_desc":
                    deskQuoteQ = deskQuoteQ.OrderByDescending(s => s.QuoteDate);
                    break;*/
                default:
                    deskQuoteQ = deskQuoteQ.OrderBy(s => s.CustomerName);
                    break;
            }

            int pageSize = 5;
            DeskQuote = await PaginatedList<DeskQuote>.CreateAsync(
                deskQuoteQ.AsNoTracking(), pageIndex ?? 1, pageSize);
            
        }
    }
}
