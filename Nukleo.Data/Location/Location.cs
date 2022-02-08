using Nukleo.Data.Enum;
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
        public string City { get; set; }
        public State State { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public DateTimeOffset PlantingDate { get; set; }
        public DateTimeOffset HarvestDate { get; set; }
    }
}
