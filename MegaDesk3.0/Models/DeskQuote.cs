using System;
using System.ComponentModel.DataAnnotations;

namespace MegaDesk_Asp.Net.Model
{
    public class DeskQuote
    {
        public int Id { get; set; }

        [Required]
        public int Width { get; set; }
        [Required]
        public int Depth { get; set; }
        [Display(Name = "Number of Drawers")]
        [Required]
        public int NumberOfDrawers { get; set; }
        [Display(Name = "Surface Area")]
        public int SurfaceArea { get; set; }
        [Display(Name = "Desktop Material")]
        [Required]
        public DeskTopMaterial Material { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Quote Date")]
        public DateTime QuoteDate { get; set; }
        [Required]
        [Display(Name = "Customer Name")]
        public string CustomerName { get; set; }
        [Display(Name = "Surface Material Cost")]
        public int SurfaceMaterialCost { get; set; }
        [Display(Name = "Rush Days")]
        public int RushDays { get; set; }
        [Display(Name = "Rush Order Cost")]
        public int RushOrderCost { get; set; }
        [Display(Name = "Quote Amount")]
        public int QuoteAmount { get; set; }
    }

    public enum DeskTopMaterial
    {
        Oak, Laminate, Pine, Rosewood, Veneer
    }
}
