using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.Core.Interfaces
{
    public interface IEntity<TId>
    {
        public TId Id { get; set; }
        public DateTime CreatedDate { get; set; } 
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
    }
}
