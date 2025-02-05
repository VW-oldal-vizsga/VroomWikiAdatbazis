using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class MainPage
    {
        public required int Id { get; set; }
        public string? Description { get; set; }
        [StringLength(250)]
        public required int? Founded { get; set; }
        public string? Headquarters { get; set; }
        [StringLength(30)]
        public string? Factories { get; set; }
        [StringLength(30)]
        public required string? Chairman { get; set; }
        [StringLength(30)]
        public required string? Owner { get; set; }
        [StringLength(30)]
        public string? Products { get; set; }
        public int? Employees{ get; set; }
        
        public string? History{ get; set; }
        [StringLength(300)] 
        public int? Profit { get; set; }



    }
}
