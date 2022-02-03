using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nukleo.Data.Enum
{
    public enum PlotRating
    {
        [Display(Name = " ")]
        NoRating,
        Excellent = 5,
        [Display(Name = "Above Average")]
        AboveAverage = 4,
        Average = 3,
        [Display(Name = "Below Average")]
        BelowAverage = 2,
        Poor = 1
    }
}


