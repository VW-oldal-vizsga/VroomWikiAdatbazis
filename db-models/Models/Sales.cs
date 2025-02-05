﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Sale 
    {
        public required int Id { get; set; }
        public required int? Year { get; set; }
        public required int? TotalSale { get; set; }
        public required int? TotalIncome { get; set; }
    }
}
