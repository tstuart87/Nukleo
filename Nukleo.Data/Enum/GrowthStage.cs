using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nukleo.Data.Enum
{
    public enum CornGrowthStage
    {
        [Display(Name = " ")]
        blank,
        V0,
        VE,
        V1,
        V2,
        V3,
        V4,
        V5,
        V6,
        V7,
        V8,
        V9,
        V10,
        V11,
        V12,
        V13,
        V14,
        V15,
        VT,
        R1,
        R2,
        R3,
        R4,
        R5,
        R6
    }

    public enum SoyGrowthStage
    {
        [Display(Name = " ")]
        blank,
        VE,
        VC,
        V1,
        V2,
        V3,
        V4,
        V5,
        V6,
        V7,
        V8,
        V9,
        V10,
        V11,
        V12,
        V13,
        V14,
        V15,
        R1,
        R2,
        R3,
        R4,
        R5,
        R6,
        R7,
        R8
    }
}
