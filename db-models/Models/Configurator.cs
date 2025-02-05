using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Configurator
    {
        public required int Id { get; set; }
        public required Users UserId { get; set; }
        public required string? Name { get; set; }
        [StringLength(200)]
        public required string? Engine { get; set; }
        [StringLength(50)]
        public required int? Horsepower { get; set; }
        public required int? doorsNumber { get; set; }
        public int? YearProd { get; set; }
        public required string? Color { get; set; }
        [StringLength(30)]
        public required int? totalCost { get; set; }
        public required string? VehicleType { get; set; }
        [StringLength(30)]
        public required string? TransmissionTpye { get; set; }
        [StringLength(20)]
        public required string? WheelDrive { get; set; }
        [StringLength(25)]
        public required int? MonthlyPrice { get; set; }
        public required string? WheelType { get; set; }
        [StringLength(30)]
        public required string? CarpetType { get; set; }
        [StringLength(30)]
        public required string? LightType { get; set; }
        [StringLength(30)]
        public required float? FuelConsumption { get; set; }

        public required float? Co2Emission { get; set; }
        public required string? FuelType { get; set; }
        [StringLength(20)]   
        public required int? TankCapacity { get; set; }
    } 
}
