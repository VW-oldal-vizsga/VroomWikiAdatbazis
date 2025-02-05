using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Car 
    {
        public required int Id { get; set; }
        public required string? Name { get; set; }
        [StringLength(30)]
        public string? Description { get; set; }
        [StringLength(250)]
        public string? Image { get; set; }
        public required string? Engine { get; set; }
        [StringLength(30)]
        public required int? Horsepower { get; set; }
        public required int? ReleaseDate { get; set; }
    }
}
