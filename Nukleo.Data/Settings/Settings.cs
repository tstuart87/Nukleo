using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nukleo.Data.Settings
{
    public class Settings
    {
        [Key]
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
    }
}
