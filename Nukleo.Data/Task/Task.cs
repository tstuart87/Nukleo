using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nukleo.Data.Task
{
    public class Task
    {
        [Key]
        public Guid Id { get; set; }
    }
}
