using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Extra 
    {
        public required int Id { get; set; }
        public string? Interior { get; set; }
        public string? Safety{ get; set; }
        public string? Infotainment { get; set; }
        public string? Comfort { get; set; }
    }
}
