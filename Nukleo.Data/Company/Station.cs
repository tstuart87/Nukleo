using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nukleo.Data.Company
{
    public class Station
    {
        [Key]
        public Guid Id { get; set; }
    }
}
