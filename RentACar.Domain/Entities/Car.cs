using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.Domain.Entities
{
    public class Car: Entity<Guid>
    {                
        public Guid BrandId { get; set; }
        public Guid CapacityId { get; set; }
        public Guid CategoryId { get; set; }
        public Guid ColorId { get; set; }
        public Guid DoorId { get; set; }
        public Guid FuelTypeId { get; set; }
        public Guid GearId { get; set; }
        public Guid ModelId { get; set; }
        public Guid SerieId { get; set; }        
        public Guid WheelDriveId { get; set; }        
        public Guid YearId { get; set; }
        public int EnginePower { get; set; }
        public int EngineCapacity { get; set; }
        public int TrunkCapacity { get; set; }
        public string Description { get; set; }
        public string Plate { get; set; }
        public decimal DailyPrice { get; set; }
        public decimal MonthlyPrice { get; set; }               
        public bool IsAvailable { get; set; }        

        
        














        }
}
