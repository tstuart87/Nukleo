using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nukleo.Data.Location
{
    public class Location
    {
        [Key]
        public Guid Id { get; set; }
    }
}
