using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MegaDesk_Asp.Net.Model;
using MegaDesk3._0.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace MegaDesk3._0.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MegaDesk3_0Context(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MegaDesk3_0Context>>()))
            {
                // Look for any DeskQuotes.
                if (context.DeskQuote.Any())
                {
                    return;   // DB has been seeded
                }

                context.DeskQuote.AddRange(
                    new DeskQuote
                    {
                        Width = 96,
                        Depth = 48,
                        QuoteDate = DateTime.Parse("2019-11-5"),
                        NumberOfDrawers = 7,
                        CustomerName = "Peter Weathers",
                        DeskTopMaterial = "Rosewood",
                        RushDays = 3,
                        TotalCost = 4538
                    },
                    new DeskQuote
                    {
                        Width = 96,
                        Depth = 12,
                        QuoteDate = DateTime.Parse("2019-11-2"),
                        NumberOfDrawers = 1,
                        CustomerName = "John Andrews",
                        DeskTopMaterial = "Laminate",
                        RushDays = 7,
                        TotalCost = 532
                    },
                    new DeskQuote
                        {
                            Width = 30,
                            Depth = 40,
                            QuoteDate = DateTime.Parse("2019-11-4"),
                            NumberOfDrawers = 3,
                            CustomerName = "Jack Peters",
                            DeskTopMaterial = "Oak",
                            RushDays = 7,
                            TotalCost = 780
                        },
                    new DeskQuote
                        {
                            Width = 50,
                            Depth = 40,
                            QuoteDate = DateTime.Parse("2019-11-6"),
                            NumberOfDrawers = 5,
                            CustomerName = "Harry Anderson",
                            DeskTopMaterial = "Oak",
                            RushDays = 7,
                            TotalCost = 1685
                        },
                    new DeskQuote
                        {
                            Width = 55,
                            Depth = 21,
                            QuoteDate = DateTime.Parse("2019-11-8"),
                            NumberOfDrawers = 7,
                            CustomerName = "Jane Seymour",
                            DeskTopMaterial = "Laminate",
                            RushDays = 7,
                            TotalCost = 835
                        },
                    new DeskQuote
                        {
                            Width = 50,
                            Depth = 40,
                            QuoteDate = DateTime.Parse("2019-11-9"),
                            NumberOfDrawers = 7,
                            CustomerName = "David Haynes",
                            DeskTopMaterial = "Oak",
                            RushDays = 3,
                            TotalCost = 1820
                        },
                    new DeskQuote
                        {
                            Width = 50,
                            Depth = 40,
                            QuoteDate = DateTime.Parse("2019-11-9"),
                            NumberOfDrawers = 7,
                            CustomerName = "Katy Taylor",
                            DeskTopMaterial = "Oak",
                            RushDays = 3,
                            TotalCost = 1820
                        },
                    new DeskQuote
                        {
                            Width = 96,
                            Depth = 48,
                            QuoteDate = DateTime.Parse("2019-11-9"),
                            NumberOfDrawers = 7,
                            CustomerName = "Kaye Jackson",
                            DeskTopMaterial = "Veneer",
                            RushDays = 3,
                            TotalCost = 4363
                        }
                );
                context.SaveChanges();
            }
        }
    }
}
