using System;
using System.ComponentModel.DataAnnotations;

namespace MegaDesk_Asp.Net.Model
{
    public class DeskQuote
    {
        #region Constants
        public const int MIN_WIDTH = 24;
        public const int MAX_WIDTH = 96;
        public const int MIN_DEPTH = 12;
        public const int MAX_DEPTH = 48;
        #endregion

        #region Local Variables
        public int Id { get; set; }

        [Required]
        [Display(Name = "Customer")]
        public string CustomerName { get; set; }

        [Range(MIN_WIDTH, MAX_WIDTH)]
        [Required]
        public int Width { get; set; }

        [Range(MIN_DEPTH, MAX_DEPTH)]
        [Required]
        public int Depth { get; set; }

        [Display(Name = "Material")]
        public string DeskTopMaterial { get; set; }

        [Display(Name = "Drawers")]
        public int NumberOfDrawers { get; set; }

        [Display(Name = "Shipping")]
        [Required]
        public int RushDays { get; set; }

        [Display(Name = "Total Cost")]
        public int TotalCost { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Quote Date")]
        public DateTime QuoteDate { get; set; }
        #endregion

        #region Calculations
        public int CalculateTotalCost()
        {
            int BaseCost = 200;
            int SurfaceArea = Width * Depth;
            int SurfaceAreaCost = CalculateSurfaceAreaCost(SurfaceArea);
            int DeskTopMaterialCost = CalculateDeskTopMaterialCost(DeskTopMaterial);
            int DrawerCost = CalculateDrawerCost(NumberOfDrawers);
            int RushDayCost = CalculateRushDayCost(RushDays, SurfaceArea);

            return BaseCost + SurfaceAreaCost + DeskTopMaterialCost + DrawerCost + RushDayCost;
        }

        public int CalculateSurfaceAreaCost(int surfaceArea)
        {
            if (surfaceArea > 1000)
            {
                return surfaceArea - 1000;
            }
            else
            {
                return 0;
            }
        }

        public int CalculateDeskTopMaterialCost(string desktopMaterial)
        {
            switch (desktopMaterial)
            {
                case "Oak":
                    return 200;
                case "laminate":
                    return 100;
                case "Pine":
                    return 50;
                case "Rosewood":
                    return 300;
                case "Veneer":
                    return 125;
                default:
                    return 50;
            }
        }

        public int CalculateDrawerCost(int numberOfDrawers)
        {
            return numberOfDrawers * 50;
        }

        public int CalculateRushDayCost(int numberOfDays, int surfaceArea)
        {
            switch (numberOfDays)
            {
                case 3:
                    if (surfaceArea < 1000)
                    {
                        return 60;
                    }
                    else if (surfaceArea >= 1000 && surfaceArea <= 2000)
                    {
                        return 70;
                    }
                    else
                    {
                        return 80;
                    }

                case 5:
                    if (surfaceArea < 1000)
                    {
                        return 40;
                    }
                    else if (surfaceArea >= 1000 && surfaceArea <= 2000)
                    {
                        return 50;
                    }
                    else
                    {
                        return 60;
                    }
                case 7:
                    if (surfaceArea < 1000)
                    {
                        return 30;
                    }
                    else if (surfaceArea >= 1000 && surfaceArea <= 2000)
                    {
                        return 35;
                    }
                    else
                    {
                        return 40;
                    }
                default:
                    return 0;
            }
        }
        #endregion

    }
}
