using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nukleo.Data.Equipment
{
    public class Equipment
    {
        [Key]
        public Guid Id { get; set; }
    }
}
